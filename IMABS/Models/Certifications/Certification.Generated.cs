﻿//--------------------------------------------------------------------------------------------------
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

[assembly: RegisterDocumentType(Certification.CLASS_NAME, typeof(Certification))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type Certification.
	/// </summary>
	public partial class Certification : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.Certification";


		/// <summary>
		/// The instance of the class that provides extended API for working with Certification fields.
		/// </summary>
		private readonly CertificationFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CertificationID.
		/// </summary>
		[DatabaseIDField]
		public int CertificationID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CertificationID"), 0);
			}
			set
			{
				SetValue("CertificationID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Description.
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
		/// Desktop banner.
		/// </summary>
		[DatabaseField]
		public Guid DesktopBanner
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("DesktopBanner"), Guid.Empty);
			}
			set
			{
				SetValue("DesktopBanner", value);
			}
		}


		/// <summary>
		/// Tablet banner.
		/// </summary>
		[DatabaseField]
		public Guid TabletBanner
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("TabletBanner"), Guid.Empty);
			}
			set
			{
				SetValue("TabletBanner", value);
			}
		}


		/// <summary>
		/// Mobile banner.
		/// </summary>
		[DatabaseField]
		public Guid MobileBanner
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("MobileBanner"), Guid.Empty);
			}
			set
			{
				SetValue("MobileBanner", value);
			}
		}


		/// <summary>
		/// Certification title.
		/// </summary>
		[DatabaseField]
		public string CertificationTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CertificationTitle"), @"");
			}
			set
			{
				SetValue("CertificationTitle", value);
			}
		}


		/// <summary>
		/// Certification content.
		/// </summary>
		[DatabaseField]
		public string CertificationContent
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CertificationContent"), @"");
			}
			set
			{
				SetValue("CertificationContent", value);
			}
		}


		/// <summary>
		/// Training title.
		/// </summary>
		[DatabaseField]
		public string TrainingTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TrainingTitle"), @"");
			}
			set
			{
				SetValue("TrainingTitle", value);
			}
		}


		/// <summary>
		/// Training content.
		/// </summary>
		[DatabaseField]
		public string TrainingContent
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TrainingContent"), @"");
			}
			set
			{
				SetValue("TrainingContent", value);
			}
		}


		/// <summary>
		/// Video panel title.
		/// </summary>
		[DatabaseField]
		public string VideoPanelTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("VideoPanelTitle"), @"");
			}
			set
			{
				SetValue("VideoPanelTitle", value);
			}
		}


		/// <summary>
		/// Video panel sub-title.
		/// </summary>
		[DatabaseField]
		public string VideoPanelSubTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("VideoPanelSubTitle"), @"");
			}
			set
			{
				SetValue("VideoPanelSubTitle", value);
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
		/// Gets an object that provides extended API for working with Certification fields.
		/// </summary>
		[RegisterProperty]
		public CertificationFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Certification fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CertificationFields : AbstractHierarchicalObject<CertificationFields>
		{
			/// <summary>
			/// The content item of type Certification that is a target of the extended API.
			/// </summary>
			private readonly Certification mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CertificationFields" /> class with the specified content item of type Certification.
			/// </summary>
			/// <param name="instance">The content item of type Certification that is a target of the extended API.</param>
			public CertificationFields(Certification instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CertificationID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CertificationID;
				}
				set
				{
					mInstance.CertificationID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}


			/// <summary>
			/// Description.
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
			/// Desktop banner.
			/// </summary>
			public DocumentAttachment DesktopBanner
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("DesktopBanner");
				}
			}


			/// <summary>
			/// Tablet banner.
			/// </summary>
			public DocumentAttachment TabletBanner
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("TabletBanner");
				}
			}


			/// <summary>
			/// Mobile banner.
			/// </summary>
			public DocumentAttachment MobileBanner
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("MobileBanner");
				}
			}


			/// <summary>
			/// Certification title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.CertificationTitle;
				}
				set
				{
					mInstance.CertificationTitle = value;
				}
			}


			/// <summary>
			/// Certification content.
			/// </summary>
			public string Content
			{
				get
				{
					return mInstance.CertificationContent;
				}
				set
				{
					mInstance.CertificationContent = value;
				}
			}


			/// <summary>
			/// Training title.
			/// </summary>
			public string TrainingTitle
			{
				get
				{
					return mInstance.TrainingTitle;
				}
				set
				{
					mInstance.TrainingTitle = value;
				}
			}


			/// <summary>
			/// Training content.
			/// </summary>
			public string TrainingContent
			{
				get
				{
					return mInstance.TrainingContent;
				}
				set
				{
					mInstance.TrainingContent = value;
				}
			}


			/// <summary>
			/// Video panel title.
			/// </summary>
			public string VideoPanelTitle
			{
				get
				{
					return mInstance.VideoPanelTitle;
				}
				set
				{
					mInstance.VideoPanelTitle = value;
				}
			}


			/// <summary>
			/// Video panel sub-title.
			/// </summary>
			public string VideoPanelSubTitle
			{
				get
				{
					return mInstance.VideoPanelSubTitle;
				}
				set
				{
					mInstance.VideoPanelSubTitle = value;
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
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Certification" /> class.
		/// </summary>
		public Certification() : base(CLASS_NAME)
		{
			mFields = new CertificationFields(this);
		}

		#endregion
	}
}