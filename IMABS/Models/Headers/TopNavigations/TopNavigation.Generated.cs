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

[assembly: RegisterDocumentType(TopNavigation.CLASS_NAME, typeof(TopNavigation))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type TopNavigation.
	/// </summary>
	public partial class TopNavigation : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.TopNavigation";


		/// <summary>
		/// The instance of the class that provides extended API for working with TopNavigation fields.
		/// </summary>
		private readonly TopNavigationFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// TopNavigationID.
		/// </summary>
		[DatabaseIDField]
		public int TopNavigationID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("TopNavigationID"), 0);
			}
			set
			{
				SetValue("TopNavigationID", value);
			}
		}


		/// <summary>
		/// Navigation Item Name to display.
		/// </summary>
		[DatabaseField]
		public string NavigationItemName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("NavigationItemName"), @"");
			}
			set
			{
				SetValue("NavigationItemName", value);
			}
		}


		/// <summary>
		/// Navigation Item url third party URL.
		/// </summary>
		[DatabaseField]
		public string NavigationItemUrl
		{
			get
			{
				return ValidationHelper.GetString(GetValue("NavigationItemUrl"), @"");
			}
			set
			{
				SetValue("NavigationItemUrl", value);
			}
		}


		/// <summary>
		/// Icon class.
		/// </summary>
		[DatabaseField]
		public string IconClass
		{
			get
			{
				return ValidationHelper.GetString(GetValue("IconClass"), @"");
			}
			set
			{
				SetValue("IconClass", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with TopNavigation fields.
		/// </summary>
		[RegisterProperty]
		public TopNavigationFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with TopNavigation fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class TopNavigationFields : AbstractHierarchicalObject<TopNavigationFields>
		{
			/// <summary>
			/// The content item of type TopNavigation that is a target of the extended API.
			/// </summary>
			private readonly TopNavigation mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="TopNavigationFields" /> class with the specified content item of type TopNavigation.
			/// </summary>
			/// <param name="instance">The content item of type TopNavigation that is a target of the extended API.</param>
			public TopNavigationFields(TopNavigation instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// TopNavigationID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.TopNavigationID;
				}
				set
				{
					mInstance.TopNavigationID = value;
				}
			}


			/// <summary>
			/// Navigation Item Name to display.
			/// </summary>
			public string NavigationItemName
			{
				get
				{
					return mInstance.NavigationItemName;
				}
				set
				{
					mInstance.NavigationItemName = value;
				}
			}


			/// <summary>
			/// Navigation Item url third party URL.
			/// </summary>
			public string NavigationItemUrl
			{
				get
				{
					return mInstance.NavigationItemUrl;
				}
				set
				{
					mInstance.NavigationItemUrl = value;
				}
			}


			/// <summary>
			/// Icon class.
			/// </summary>
			public string IconClass
			{
				get
				{
					return mInstance.IconClass;
				}
				set
				{
					mInstance.IconClass = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="TopNavigation" /> class.
		/// </summary>
		public TopNavigation() : base(CLASS_NAME)
		{
			mFields = new TopNavigationFields(this);
		}

		#endregion
	}
}