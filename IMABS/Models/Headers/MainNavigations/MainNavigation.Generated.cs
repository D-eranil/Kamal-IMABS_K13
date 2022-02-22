﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.IMABS;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(MainNavigation.CLASS_NAME, typeof(MainNavigation))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type MainNavigation.
	/// </summary>
	public partial class MainNavigation : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.MainNavigation";


		/// <summary>
		/// The instance of the class that provides extended API for working with MainNavigation fields.
		/// </summary>
		private readonly MainNavigationFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MainNavigationID.
		/// </summary>
		[DatabaseIDField]
		public int MainNavigationID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MainNavigationID"), 0);
			}
			set
			{
				SetValue("MainNavigationID", value);
			}
		}


		/// <summary>
		/// Menu Item Name to display in UI for main header menu item.
		/// </summary>
		[DatabaseField]
		public string MenuItemName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MenuItemName"), @"");
			}
			set
			{
				SetValue("MenuItemName", value);
			}
		}


		/// <summary>
		/// Check this check box to display this in footer.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInFooter
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInFooter"), false);
			}
			set
			{
				SetValue("AllowToViewInFooter", value);
			}
		}


		/// <summary>
		/// Check this check box to display this link in header.
		/// </summary>
		[DatabaseField]
		public bool AllowToViewInHeader
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("AllowToViewInHeader"), false);
			}
			set
			{
				SetValue("AllowToViewInHeader", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MainNavigation fields.
		/// </summary>
		[RegisterProperty]
		public MainNavigationFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MainNavigation fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MainNavigationFields : AbstractHierarchicalObject<MainNavigationFields>
		{
			/// <summary>
			/// The content item of type MainNavigation that is a target of the extended API.
			/// </summary>
			private readonly MainNavigation mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MainNavigationFields" /> class with the specified content item of type MainNavigation.
			/// </summary>
			/// <param name="instance">The content item of type MainNavigation that is a target of the extended API.</param>
			public MainNavigationFields(MainNavigation instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MainNavigationID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MainNavigationID;
				}
				set
				{
					mInstance.MainNavigationID = value;
				}
			}


			/// <summary>
			/// Menu Item Name to display in UI for main header menu item.
			/// </summary>
			public string MenuItemName
			{
				get
				{
					return mInstance.MenuItemName;
				}
				set
				{
					mInstance.MenuItemName = value;
				}
			}


			/// <summary>
			/// Menu Item Navigation Url.
			/// </summary>
			public IEnumerable<TreeNode> MenuItemNavigationUrl
			{
				get
				{
					return mInstance.GetRelatedDocuments("MenuItemNavigationUrl");
				}
			}


			/// <summary>
			/// Check this check box to display this in footer.
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


			/// <summary>
			/// Check this check box to display this link in header.
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
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MainNavigation" /> class.
		/// </summary>
		public MainNavigation() : base(CLASS_NAME)
		{
			mFields = new MainNavigationFields(this);
		}

		#endregion
	}
}