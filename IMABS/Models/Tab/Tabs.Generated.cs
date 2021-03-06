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

[assembly: RegisterDocumentType(Tabs.CLASS_NAME, typeof(Tabs))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Tabs.
	/// </summary>
	public partial class Tabs : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Tabs";


		/// <summary>
		/// The instance of the class that provides extended API for working with Tabs fields.
		/// </summary>
		private readonly TabsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// TabsID.
		/// </summary>
		[DatabaseIDField]
		public int TabsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("TabsID"), 0);
			}
			set
			{
				SetValue("TabsID", value);
			}
		}


		/// <summary>
		/// Tabs Name.
		/// </summary>
		[DatabaseField]
		public string TabsName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TabsName"), @"");
			}
			set
			{
				SetValue("TabsName", value);
			}
		}


		/// <summary>
		/// Tab Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), @"");
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Display.
		/// </summary>
		[DatabaseField]
		public bool IsActive
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("IsActive"), true);
			}
			set
			{
				SetValue("IsActive", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Tabs fields.
		/// </summary>
		[RegisterProperty]
		public TabsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Tabs fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class TabsFields : AbstractHierarchicalObject<TabsFields>
		{
			/// <summary>
			/// The content item of type Tabs that is a target of the extended API.
			/// </summary>
			private readonly Tabs mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="TabsFields" /> class with the specified content item of type Tabs.
			/// </summary>
			/// <param name="instance">The content item of type Tabs that is a target of the extended API.</param>
			public TabsFields(Tabs instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// TabsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.TabsID;
				}
				set
				{
					mInstance.TabsID = value;
				}
			}


			/// <summary>
			/// Tabs Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.TabsName;
				}
				set
				{
					mInstance.TabsName = value;
				}
			}


			/// <summary>
			/// Tab Image.
			/// </summary>
			public string Image
			{
				get
				{
					return mInstance.Image;
				}
				set
				{
					mInstance.Image = value;
				}
			}


			/// <summary>
			/// Display.
			/// </summary>
			public bool IsActive
			{
				get
				{
					return mInstance.IsActive;
				}
				set
				{
					mInstance.IsActive = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Tabs" /> class.
		/// </summary>
		public Tabs() : base(CLASS_NAME)
		{
			mFields = new TabsFields(this);
		}

		#endregion
	}
}