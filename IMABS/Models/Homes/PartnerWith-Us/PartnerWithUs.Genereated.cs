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

[assembly: RegisterDocumentType(PartnerWithUs.CLASS_NAME, typeof(PartnerWithUs))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type PartnerWithUs.
	/// </summary>
	public partial class PartnerWithUs : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.PartnerWithUs";


		/// <summary>
		/// The instance of the class that provides extended API for working with PartnerWithUs fields.
		/// </summary>
		private readonly PartnerWithUsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// PertnerWithUsID.
		/// </summary>
		[DatabaseIDField]
		public int PartnerWithUsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("PartnerWithUsID"), 0);
			}
			set
			{
				SetValue("PartnerWithUsID", value);
			}
		}


		/// <summary>
		/// Title will be displayed in bold colour.
		/// </summary>
		[DatabaseField]
		public string Title
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Title"), @"");
			}
			set
			{
				SetValue("Title", value);
			}
		}


		/// <summary>
		/// Sub Title in will be above the partner with Us Title in light colour.
		/// </summary>
		[DatabaseField]
		public string SubTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SubTitle"), @"");
			}
			set
			{
				SetValue("SubTitle", value);
			}
		}


		/// <summary>
		/// Description will be displayed below the title.
		/// </summary>
		[DatabaseField]
		public string Description
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Description"), @"");
			}
			set
			{
				SetValue("Description", value);
			}
		}


		/// <summary>
		/// Left side image in partner with us section.
		/// </summary>
		[DatabaseField]
		public Guid SectionImage
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("SectionImage"), Guid.Empty);
			}
			set
			{
				SetValue("SectionImage", value);
			}
		}


		/// <summary>
		/// Button Title (Display Name).
		/// </summary>
		[DatabaseField]
		public string CTAButtonTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CTAButtonTitle"), @"");
			}
			set
			{
				SetValue("CTAButtonTitle", value);
			}
		}


		/// <summary>
		/// Link of button to redirect user.
		/// </summary>
		[DatabaseField]
		public string CTAButtonLink
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CTAButtonLink"), @"");
			}
			set
			{
				SetValue("CTAButtonLink", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with PartnerWithUs fields.
		/// </summary>
		[RegisterProperty]
		public PartnerWithUsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with PartnerWithUs fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class PartnerWithUsFields : AbstractHierarchicalObject<PartnerWithUsFields>
		{
			/// <summary>
			/// The content item of type PartnerWithUs that is a target of the extended API.
			/// </summary>
			private readonly PartnerWithUs mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="PartnerWithUsFields" /> class with the specified content item of type PartnerWithUs.
			/// </summary>
			/// <param name="instance">The content item of type PartnerWithUs that is a target of the extended API.</param>
			public PartnerWithUsFields(PartnerWithUs instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// PertnerWithUsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.PartnerWithUsID;
				}
				set
				{
					mInstance.PartnerWithUsID = value;
				}
			}


			/// <summary>
			/// Title will be displayed in bold colour.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.Title;
				}
				set
				{
					mInstance.Title = value;
				}
			}


			/// <summary>
			/// Sub Title in will be above the partner with Us Title in light colour.
			/// </summary>
			public string SubTitle
			{
				get
				{
					return mInstance.SubTitle;
				}
				set
				{
					mInstance.SubTitle = value;
				}
			}


			/// <summary>
			/// Description will be displayed below the title.
			/// </summary>
			public string Description
			{
				get
				{
					return mInstance.Description;
				}
				set
				{
					mInstance.Description = value;
				}
			}


			/// <summary>
			/// Left side image in partner with us section.
			/// </summary>
			public DocumentAttachment SectionImage
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("SectionImage");
				}
			}


			/// <summary>
			/// Button Title (Display Name).
			/// </summary>
			public string CTAButtonTitle
			{
				get
				{
					return mInstance.CTAButtonTitle;
				}
				set
				{
					mInstance.CTAButtonTitle = value;
				}
			}


			/// <summary>
			/// Link of button to redirect user.
			/// </summary>
			public string CTAButtonLink
			{
				get
				{
					return mInstance.CTAButtonLink;
				}
				set
				{
					mInstance.CTAButtonLink = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="PartnerWithUs" /> class.
		/// </summary>
		public PartnerWithUs() : base(CLASS_NAME)
		{
			mFields = new PartnerWithUsFields(this);
		}

		#endregion
	}
}