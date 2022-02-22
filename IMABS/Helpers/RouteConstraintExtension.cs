using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Data;
using System.Linq;

namespace IMABS.Helpers
{
    public class RouteConstraintExtension
    {
        /// <summary>
        /// Set a new route.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static RouteValueDictionary SetRoute(RouteValueDictionary values, string controller, string action, string NodeAliasPath = null)
        {
            values["controller"] = controller;
            values["action"] = action;
            values["NodeAliasPath"] = NodeAliasPath;
            return values;
        }

        #region CMS Url Contraint

        public class CmsUrlConstraint : IRouteConstraint
        {
            ///// <summary>
            ///// Check for a CMS page for the current route.
            ///// </summary>
            ///// <param name="httpContext"></param>
            ///// <param name="route"></param>
            ///// <param name="parameterName"></param>
            ///// <param name="values"></param>
            ///// <param name="routeDirection"></param>
            ///// <returns></returns>
            //public bool Match(HttpContextBase httpContext, Route route, string parameterName, 
            //    RouteValueDictionary values, RouteDirection routeDirection)
            //{
                
            //}

            public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
            {
                string pageUrl = values[routeKey] == null ? "/Home" : $"/{values[routeKey].ToString()}";

                // Check if the page is being viewed in preview.
                //bool previewEnabled = HttpContext.Kentico().Preview().Enabled;

                // Ignore the site resource directory containing Image, CSS and JS assets to save call to Kentico API.
                if (pageUrl.StartsWith("/resources"))
                    return false;

                // Get page from Kentico by alias path in its published or unpublished state.
                // PageLogic.GetByNodeAliasPath() method carries out the document lookup by Node Alias Path.
                TreeNode page = DocumentHelper.GetDocuments()
                                .OnCurrentSite()
                                //.Culture()
                                .Path(pageUrl)
                                .LatestVersion()
                                .TopN(1)
                                .FirstOrDefault();
                //PageLogic.GetByNodeAliasPath(pageUrl, previewEnabled);

                DataTable pageDt = new DataTable();

                var docQuery = new DocumentQuery()
                   .OnCurrentSite()
                   .AllCultures()
                   .Path(pageUrl)
                   .TopN(1);

                if (docQuery != null)
                {
                    pageDt = docQuery.Tables[0];
                }

                string className = string.Empty;
                int NodeId = 0;
                if (pageDt != null && pageDt.Rows.Count > 0)
                {
                    foreach (System.Data.DataColumn col in pageDt.Columns)
                    {
                        if (col.ColumnName == "ClassName")
                        {
                            className = pageDt.Rows[0][col.ColumnName].ToString();
                        }
                        else if (col.ColumnName == "NodeID")
                        {
                            int.TryParse(pageDt.Rows[0][col.ColumnName].ToString(), out NodeId);
                        }
                    }

                    if (page == null && NodeId > 0)
                    {
                        page = DocumentHelper.GetDocuments().AllCultures().WhereEquals("NodeID", NodeId).FirstOrDefault();
                    }
                }

                if (page != null)
                {
                    // Store current page in HttpContext.
                    httpContext.Items["CmsPage"] = page;

                    #region Map MVC Routes

                    // Set the routing depending on the page type.
                    if (page.ClassName == Home.CLASS_NAME)
                        SetRoute(values, "Home", "Index");

                    #endregion

                    if (values["controller"].ToString() != "Page")
                        return true;
                }
                else if (values != null && values.Keys != null && values.Keys.Count > 0 && values.Keys.Contains("controller") && values["controller"].ToString() == "HttpErrors" && values.Keys.Contains("action"))
                {
                    SetRoute(values, values["controller"].ToString(), values["action"].ToString());
                    return true;
                }


                return false;
            }
        }

        #endregion
    }
}
