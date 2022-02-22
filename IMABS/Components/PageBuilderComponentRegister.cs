using IMABS.Components;
using IMABS.Components.FormComponents.IconSelectorDropDown;
using IMABS.Components.Sections;
using IMABS.Components.Sections.CallToActionBanner;
using IMABS.Components.Sections.PromotionsBanner;
using IMABS.Components.Sections.ThreeColumnSection;
using IMABS.Components.Widgets.AtAGlance;
using IMABS.Components.Widgets.CTAButton;
using IMABS.Components.Widgets.FeatureWidget;
using IMABS.Components.Widgets.CTATileWidget;
using IMABS.Components.Widgets.ImageCardWidget;
using IMABS.Components.Widgets.SupportWidget;
using IMABS.Components.Widgets.TextWidget;
using IMABS.Components.Widgets.VideoCardWidget;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using IMABS.Components.Widgets.ContributionWidget;
using IMABS.Components.Widgets.ContactWidget;
using IMABS.Components.Widgets.HeaderBannerWidget;



//Sections
[assembly: RegisterSection(PagebuilderIdentifiers.THREECOLUMNSECTION_IDENTIFIER, "Three Column Section", typeof(ThreeColumnSectionProperties), customViewName: "~/Components/Sections/ThreeColumnSection/_ThreeColumnSection.cshtml", Description = "Three Column Section", IconClass = "icon-l-cols-3")]

[assembly: RegisterSection(PagebuilderIdentifiers.FOURCOLUMNSECTION_IDENTIFIER, "Four Column Section", typeof(ThemeSectionProperties), "~/Components/Sections/FourColumnSection/_FourColumnColumnSection.cshtml", Description = "Four Column Section", IconClass = "icon-l-cols-4")]

[assembly: RegisterSection(PagebuilderIdentifiers.CTABANNERSECTION_IDENTIFIER, typeof(CallToActionBannerViewComponent), "Call To Action Banner Section", typeof(ThemeSectionProperties), Description = "Call To Action Banner Section", IconClass = "icon-carousel")]

[assembly: RegisterSection(PagebuilderIdentifiers.PROMOBANNERSECTION_IDENTIFIER, typeof(PromotionsBannerViewComponent), "Promotions Banner Section", typeof(ThemeSectionProperties), Description = "Promotions Banner Section", IconClass = "icon-tag")]



//Widget
[assembly: RegisterWidget(PagebuilderIdentifiers.FEATUREWIDGET_IDENTIFIER, typeof(FeatureWidgetViewComponent), "Feature widget", typeof(FeatureWidgetProperties), Description = "Feature widget.", IconClass = "icon-cb-check")]

[assembly: RegisterWidget(PagebuilderIdentifiers.ATAGLANCEWIDGET_IDENTIFIER, typeof(AtAGlanceWidgetViewComponent), "At a glance widget", typeof(AtAGlanceWidgetProperties), Description = "To add stats use this widget.", IconClass = "icon-gauge")]

[assembly: RegisterWidget(PagebuilderIdentifiers.TEXTWIDGET_IDENTIFIER, typeof(TextWidgetViewComponent), "Text widget", typeof(TextWidgetProperties), Description = "Using this widget you can add the text.", IconClass = "icon-l-header-text")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CTABUTTONWIDGET_IDENTIFIER, typeof(CTAButtonWidgetViewComponent), "CTA button widget", typeof(CTAButtonWidgetProperties), Description = "Using this widget to add link button and allot to add css, and redirection link and target window to open link url.", IconClass = "icon-a-lowercase")]

[assembly: RegisterWidget(PagebuilderIdentifiers.SUPPORTWIDGET_IDENTIFIER, typeof(SupportWidgetViewComponent), "Support widget", typeof(SupportWidgetProperties), Description = "Support widget.", IconClass = "icon-picture")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CTATILEWIDGET_IDENTIFIER, typeof(CTATileWidgetViewComponent), "CTA tile widget", typeof(CTATileWidgetProperties), Description = "CTA tile widget.", IconClass = "icon-file")]

[assembly: RegisterFormComponent(PagebuilderIdentifiers.ICONCOMPONENT_IDENTIFIER, typeof(IconSelectorDropDownComponent), "Drop-down with custom Icon data", IconClass = "icon-menu")]

[assembly: RegisterWidget(PagebuilderIdentifiers.VIDEOCARDWIDGET_IDENTIFIER, typeof(VideoCardWidgetVIewComponent), "Video card widget", typeof(VideoCardWidgetProperties), Description = "Video card widget.", IconClass = "icon-camera")]

[assembly: RegisterWidget(PagebuilderIdentifiers.IMAGECARDWIDGET_IDENTIFIER, typeof(ImageCardWidgetViewComponent), "Image card widget", typeof(ImageCardWidgetProperties), Description = "Image card widget.", IconClass = "icon-id-card")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CONTACTWIDGET_IDENTIFIER, typeof(ContactWidgetViewComponent), "Contact widget", typeof(ContactWidgetProperties), Description = "Using this widget you can add the contact tile.", IconClass = "icon-l-list-article")]

[assembly: RegisterWidget(PagebuilderIdentifiers.HEADERBANNERWIDGET_IDENTIFIER, typeof(HeaderBannerWidgetViewComponent), "Header Banner widget", typeof(HeaderBannerWidgetProperties), Description = "Using this widget you can add header with image and text.", IconClass = "icon-rectangle-o-h")]

[assembly: RegisterWidget(PagebuilderIdentifiers.CONTRIBUTIONWIDGET_IDENTIFIER, typeof(ContributionWidgetViewComponent), "Contribution widget", typeof(ContributionWidgetProperties), Description = "Contribution widget.", IconClass = "icon-choice-user-scheme")]

//[assembly: RegisterWidget(PagebuilderIdentifiers.IMAGEWIDGET_IDENTIFIER, typeof(ImageWidgetController), "Image Widget", Description = "It will render the image which can be seleted from media library and allows editors to add class, alt text, dimensions and redirection link to image", IconClass = "icon-picture")]

//[assembly: RegisterWidget(PagebuilderIdentifiers.CATEGORYWIDGET_IDENTIFIER, typeof(SupportWidgetController), "Support Widget", Description = "It will render the image for support, add support name, description and redirection page url/email id.", IconClass = "icon-picture")]

//View Component
//[assembly: RegisterWidget(PagebuilderIdentifiers.FEATUREWIDGET_IDENTIFIER, "Feature widget", typeof(FeatureWidgetProperties), "~/Components/Widgets/FeatureWidget/_FeatureWidget.cshtml", Description = "Displays an image, text, and a CTA button.", IconClass = "icon-badge")]



//// Widgets
//[assembly: RegisterWidget(PagebuilderIdentifiers.ATAGLANCEWIDGET_IDENTIFIER, "Testimonial", typeof(TestimonialWidgetProperties), "~/Components/Widgets/TestimonialWidget/_DancingGoat_LandingPage_TestimonialWidget.cshtml", Description = "Displays a quotation with its author.", IconClass = "icon-right-double-quotation-mark")]
//[assembly: RegisterWidget(PagebuilderIdentifiers.CTA_BUTTON_WIDGET, "CTA button", typeof(CTAButtonWidgetProperties), "~/Components/Widgets/CTAButton/_DancingGoat_General_CTAButtonWidget.cshtml", Description = "Call to action button with configurable target page.", IconClass = "icon-rectangle-a")]
//[assembly: RegisterWidget(PagebuilderIdentifiers.TESTIMONIAL_WIDGET, "Testimonial", typeof(TestimonialWidgetProperties), "~/Components/Widgets/TestimonialWidget/_DancingGoat_LandingPage_TestimonialWidget.cshtml", Description = "Displays a quotation with its author.", IconClass = "icon-right-double-quotation-mark")]
//[assembly: RegisterWidget(PagebuilderIdentifiers.CTA_BUTTON_WIDGET, "CTA button", typeof(CTAButtonWidgetProperties), "~/Components/Widgets/CTAButton/_DancingGoat_General_CTAButtonWidget.cshtml", Description = "Call to action button with configurable target page.", IconClass = "icon-rectangle-a")]



//// Sections
//[assembly: RegisterSection(PagebuilderIdentifiers.SINGLE_COLUMN_SECTION, "1 column", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_SingleColumnSection.cshtml", Description = "Single-column section with one full-width zone.", IconClass = "icon-square")]
//[assembly: RegisterSection(PagebuilderIdentifiers.TWO_COLUMN_SECTION, "2 columns - 50/50", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_TwoColumnSection.cshtml", Description = "Two-column section with zones layout 50% + 50%.", IconClass = "icon-l-cols-2")]
//[assembly: RegisterSection(PagebuilderIdentifiers.THREE_COLUMN_SECTION, "3 columns - 33/33/33", typeof(ThreeColumnSectionProperties), "~/Components/Sections/ThreeColumnSection/_DancingGoat_ThreeColumnSection.cshtml", Description = "Three-column section with zones layout 33% + 33% + 33%.", IconClass = "icon-l-cols-3")]
//[assembly: RegisterSection(PagebuilderIdentifiers.SECTION_75_25, "2 columns - 75/25", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_Section_75_25.cshtml", Description = "Two-column section with zones layout 75% + 25%.", IconClass = "icon-l-cols-70-30")]
//[assembly: RegisterSection(PagebuilderIdentifiers.SECTION_25_75, "2 columns - 25/75", typeof(ThemeSectionProperties), "~/Components/Sections/_DancingGoat_Section_25_75.cshtml", Description = "Two-column section with zones layout 25% + 75%.", IconClass = "icon-l-cols-30-70")]
