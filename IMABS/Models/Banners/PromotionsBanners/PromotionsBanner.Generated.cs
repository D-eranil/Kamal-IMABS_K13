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

[assembly: RegisterDocumentType(PromotionsBanner.CLASS_NAME, typeof(PromotionsBanner))]

namespace CMS.DocumentEngine.Types.IMABS
{
	/// <summary>
	/// Represents a content item of type PromotionsBanner.
	/// </summary>
	public partial class PromotionsBanner : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "IMABS.PromotionsBanner";


		/// <summary>
		/// The instance of the class that provides extended API for working with PromotionsBanner fields.
		/// </summary>
		private readonly PromotionsBannerFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// PartnerCentralID.
		/// </summary>
		[DatabaseIDField]
		public int PromotionsBannerID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("PromotionsBannerID"), 0);
			}
			set
			{
				SetValue("PromotionsBannerID", value);
			}
		}


		/// <summary>
		/// Title.
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
		/// Sub Title.
		/// </summary>
		[DatabaseField]
		public string SubTItle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SubTItle"), @"");
			}
			set
			{
				SetValue("SubTItle", value);
			}
		}


		/// <summary>
		/// CTA Button Text.
		/// </summary>
		[DatabaseField]
		public string CTAButtonText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CTAButtonText"), @"");
			}
			set
			{
				SetValue("CTAButtonText", value);
			}
		}


		/// <summary>
		/// CTA Button Link.
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
		/// Image.
		/// </summary>
		[DatabaseField]
		public Guid Image
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("Image"), Guid.Empty);
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with PromotionsBanner fields.
		/// </summary>
		[RegisterProperty]
		public PromotionsBannerFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with PromotionsBanner fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class PromotionsBannerFields : AbstractHierarchicalObject<PromotionsBannerFields>
		{
			/// <summary>
			/// The content item of type PromotionsBanner that is a target of the extended API.
			/// </summary>
			private readonly PromotionsBanner mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="PromotionsBannerFields" /> class with the specified content item of type PromotionsBanner.
			/// </summary>
			/// <param name="instance">The content item of type PromotionsBanner that is a target of the extended API.</param>
			public PromotionsBannerFields(PromotionsBanner instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// PartnerCentralID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.PromotionsBannerID;
				}
				set
				{
					mInstance.PromotionsBannerID = value;
				}
			}


			/// <summary>
			/// Title.
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
			/// Sub Title.
			/// </summary>
			public string SubTItle
			{
				get
				{
					return mInstance.SubTItle;
				}
				set
				{
					mInstance.SubTItle = value;
				}
			}


			/// <summary>
			/// CTA Button Text.
			/// </summary>
			public string CTAButtonText
			{
				get
				{
					return mInstance.CTAButtonText;
				}
				set
				{
					mInstance.CTAButtonText = value;
				}
			}


			/// <summary>
			/// CTA Button Link.
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


			/// <summary>
			/// Image.
			/// </summary>
			public DocumentAttachment Image
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("Image");
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="PromotionsBanner" /> class.
		/// </summary>
		public PromotionsBanner() : base(CLASS_NAME)
		{
			mFields = new PromotionsBannerFields(this);
		}

		#endregion
	}
}