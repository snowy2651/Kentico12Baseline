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
using CMS.DocumentEngine.Types.Component;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(PageMetaData.CLASS_NAME, typeof(PageMetaData))]

namespace CMS.DocumentEngine.Types.Component
{
	/// <summary>
	/// Represents a content item of type PageMetaData.
	/// </summary>
	public partial class PageMetaData : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Component.PageMetaData";


		/// <summary>
		/// The instance of the class that provides extended API for working with PageMetaData fields.
		/// </summary>
		private readonly PageMetaDataFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// PageMetaDataID.
		/// </summary>
		[DatabaseIDField]
		public int PageMetaDataID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("PageMetaDataID"), 0);
			}
			set
			{
				SetValue("PageMetaDataID", value);
			}
		}


		/// <summary>
		/// Page Title.
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
		/// Description of the page, used in SEO meta data, Social sharing links description and also for navigation elements for this page.
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
		/// Comma separated list of keywords for SEO.
		/// </summary>
		[DatabaseField]
		public string Keywords
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Keywords"), @"");
			}
			set
			{
				SetValue("Keywords", value);
			}
		}


		/// <summary>
		/// Thumbnail for this page, used both in Social Media linking as the preview image, as well as in various navigation elements that reference this page.
		/// </summary>
		[DatabaseField]
		public string ThumbnailSmall
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ThumbnailSmall"), @"");
			}
			set
			{
				SetValue("ThumbnailSmall", value);
			}
		}


		/// <summary>
		/// Large thumbnail for this page, used both in Social Media linking as the preview image, as well as in various navigation elements that reference this page.
		/// </summary>
		[DatabaseField]
		public string ThumbnailLarge
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ThumbnailLarge"), @"");
			}
			set
			{
				SetValue("ThumbnailLarge", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with PageMetaData fields.
		/// </summary>
		[RegisterProperty]
		public PageMetaDataFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with PageMetaData fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class PageMetaDataFields : AbstractHierarchicalObject<PageMetaDataFields>
		{
			/// <summary>
			/// The content item of type PageMetaData that is a target of the extended API.
			/// </summary>
			private readonly PageMetaData mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="PageMetaDataFields" /> class with the specified content item of type PageMetaData.
			/// </summary>
			/// <param name="instance">The content item of type PageMetaData that is a target of the extended API.</param>
			public PageMetaDataFields(PageMetaData instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// PageMetaDataID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.PageMetaDataID;
				}
				set
				{
					mInstance.PageMetaDataID = value;
				}
			}


			/// <summary>
			/// Page Title.
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
			/// Description of the page, used in SEO meta data, Social sharing links description and also for navigation elements for this page.
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
			/// Comma separated list of keywords for SEO.
			/// </summary>
			public string Keywords
			{
				get
				{
					return mInstance.Keywords;
				}
				set
				{
					mInstance.Keywords = value;
				}
			}


			/// <summary>
			/// Thumbnail for this page, used both in Social Media linking as the preview image, as well as in various navigation elements that reference this page.
			/// </summary>
			public string ThumbnailSmall
			{
				get
				{
					return mInstance.ThumbnailSmall;
				}
				set
				{
					mInstance.ThumbnailSmall = value;
				}
			}


			/// <summary>
			/// Large thumbnail for this page, used both in Social Media linking as the preview image, as well as in various navigation elements that reference this page.
			/// </summary>
			public string ThumbnailLarge
			{
				get
				{
					return mInstance.ThumbnailLarge;
				}
				set
				{
					mInstance.ThumbnailLarge = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="PageMetaData" /> class.
		/// </summary>
		public PageMetaData() : base(CLASS_NAME)
		{
			mFields = new PageMetaDataFields(this);
		}

		#endregion
	}
}