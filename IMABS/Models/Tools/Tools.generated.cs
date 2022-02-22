//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.IMABS;

[assembly: RegisterDocumentType(Tools.CLASS_NAME, typeof(Tools))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Tools.
	/// </summary>
	public partial class Tools : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Tools";


		/// <summary>
		/// The instance of the class that provides extended API for working with Tools fields.
		/// </summary>
		private readonly ToolsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ToolsID.
		/// </summary>
		[DatabaseIDField]
		public int ToolsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ToolsID"), 0);
			}
			set
			{
				SetValue("ToolsID", value);
			}
		}


		/// <summary>
		/// Tools Title.
		/// </summary>
		[DatabaseField]
		public string ToolsTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ToolsTitle"), @"");
			}
			set
			{
				SetValue("ToolsTitle", value);
			}
		}


		/// <summary>
		/// Enable CTA banner?.
		/// </summary>
		[DatabaseField]
		public bool EnableCallToTactionBanner
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnableCallToTactionBanner"), false);
			}
			set
			{
				SetValue("EnableCallToTactionBanner", value);
			}
		}


		/// <summary>
		/// Enable promotions banner?.
		/// </summary>
		[DatabaseField]
		public bool EnablePromotionsBanner
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnablePromotionsBanner"), false);
			}
			set
			{
				SetValue("EnablePromotionsBanner", value);
			}
		}


		/// <summary>
		/// Enable Breadcrumb?.
		/// </summary>
		[DatabaseField]
		public bool EnableBreadcrumb
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("EnableBreadcrumb"), false);
			}
			set
			{
				SetValue("EnableBreadcrumb", value);
			}
		}


		/// <summary>
		/// Show in header menu.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInHeader
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInHeader"), true);
			}
			set
			{
				SetValue("AllowToViewInHeader", value);
			}
		}


		/// <summary>
		/// Show in footer menu.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInFooter
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInFooter"), true);
			}
			set
			{
				SetValue("AllowToViewInFooter", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Tools fields.
		/// </summary>
		[RegisterProperty]
		public ToolsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Tools fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ToolsFields : AbstractHierarchicalObject<ToolsFields>
		{
			/// <summary>
			/// The content item of type Tools that is a target of the extended API.
			/// </summary>
			private readonly Tools mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ToolsFields" /> class with the specified content item of type Tools.
			/// </summary>
			/// <param name="instance">The content item of type Tools that is a target of the extended API.</param>
			public ToolsFields(Tools instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ToolsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ToolsID;
				}
				set
				{
					mInstance.ToolsID = value;
				}
			}


			/// <summary>
			/// Tools Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.ToolsTitle;
				}
				set
				{
					mInstance.ToolsTitle = value;
				}
			}


			/// <summary>
			/// Enable CTA banner?.
			/// </summary>
			public bool EnableCallToTactionBanner
			{
				get
				{
					return mInstance.EnableCallToTactionBanner;
				}
				set
				{
					mInstance.EnableCallToTactionBanner = value;
				}
			}


			/// <summary>
			/// Enable promotions banner?.
			/// </summary>
			public bool EnablePromotionsBanner
			{
				get
				{
					return mInstance.EnablePromotionsBanner;
				}
				set
				{
					mInstance.EnablePromotionsBanner = value;
				}
			}


			/// <summary>
			/// Enable Breadcrumb?.
			/// </summary>
			public bool EnableBreadcrumb
			{
				get
				{
					return mInstance.EnableBreadcrumb;
				}
				set
				{
					mInstance.EnableBreadcrumb = value;
				}
			}


			/// <summary>
			/// Show in header menu.
			/// </summary>
			public bool AllowToViewInHeader
			{
				get
				{
					return mInstance.AllowToViewInHeader;
				}
				set
				{
					mInstance.AllowToViewInHeader = value;
				}
			}


			/// <summary>
			/// Show in footer menu.
			/// </summary>
			public bool AllowToViewInFooter
			{
				get
				{
					return mInstance.AllowToViewInFooter;
				}
				set
				{
					mInstance.AllowToViewInFooter = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Tools" /> class.
		/// </summary>
		public Tools() : base(CLASS_NAME)
		{
			mFields = new ToolsFields(this);
		}

		#endregion
	}
}