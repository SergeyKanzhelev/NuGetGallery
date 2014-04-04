﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC {
    static readonly AdminClass s_Admin = new AdminClass();
    public static AdminClass Admin { get { return s_Admin; } }
    public static NuGetGallery.ApiController Api = new NuGetGallery.T4MVC_ApiController();
    public static NuGetGallery.AuthenticationController Authentication = new NuGetGallery.T4MVC_AuthenticationController();
    public static NuGetGallery.CuratedFeedsController CuratedFeeds = new NuGetGallery.T4MVC_CuratedFeedsController();
    public static NuGetGallery.CuratedPackagesController CuratedPackages = new NuGetGallery.T4MVC_CuratedPackagesController();
    public static NuGetGallery.ErrorsController Errors = new NuGetGallery.T4MVC_ErrorsController();
    public static NuGetGallery.JsonApiController JsonApi = new NuGetGallery.T4MVC_JsonApiController();
    public static NuGetGallery.PackagesController Packages = new NuGetGallery.T4MVC_PackagesController();
    public static NuGetGallery.PagesController Pages = new NuGetGallery.T4MVC_PagesController();
    public static NuGetGallery.StatisticsController Statistics = new NuGetGallery.T4MVC_StatisticsController();
    public static NuGetGallery.UsersController Users = new NuGetGallery.T4MVC_UsersController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AdminClass {
        public readonly string Name = "Admin";
        public NuGetGallery.Areas.Admin.Controllers.ConfigController Config = new NuGetGallery.Areas.Admin.Controllers.T4MVC_ConfigController();
        public NuGetGallery.Areas.Admin.Controllers.HomeController Home = new NuGetGallery.Areas.Admin.Controllers.T4MVC_HomeController();
        public NuGetGallery.Areas.Admin.Controllers.LuceneController Lucene = new NuGetGallery.Areas.Admin.Controllers.T4MVC_LuceneController();
        public T4MVC.Admin.SharedController Shared = new T4MVC.Admin.SharedController();
    }
}

   
namespace System.Web.Mvc {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class T4Extensions {
        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result) {
            return htmlHelper.RouteLink(linkText, result.GetRouteValueDictionary());
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes) {
            return ActionLink(htmlHelper, linkText, result, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes, string protocol = null, string hostName = null, string fragment = null) {
            return ActionLink(htmlHelper, linkText, result, new RouteValueDictionary(htmlAttributes), protocol, hostName, fragment);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol = null, string hostName = null, string fragment = null) {
            return htmlHelper.RouteLink(linkText, null, protocol, hostName, fragment, result.GetRouteValueDictionary(), htmlAttributes);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result) {
            return htmlHelper.BeginForm(result, FormMethod.Post);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod) {
            return htmlHelper.BeginForm(result, formMethod, null);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, object htmlAttributes) {
            return BeginForm(htmlHelper, result, formMethod, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, formMethod, htmlAttributes);
        }

        public static void RenderAction(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            htmlHelper.RenderAction(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        public static MvcHtmlString Action(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.Action(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }
        public static string Action(this UrlHelper urlHelper, ActionResult result) {
            return urlHelper.RouteUrl(null, result.GetRouteValueDictionary());
        }

        public static string Action(this UrlHelper urlHelper, ActionResult result, string protocol = null, string hostName = null) {
            return urlHelper.RouteUrl(null, result.GetRouteValueDictionary(), protocol, hostName);
        }

        public static string ActionAbsolute(this UrlHelper urlHelper, ActionResult result) {
            return String.Format("{0}{1}",urlHelper.RequestContext.HttpContext.Request.Url.GetLeftPart(UriPartial.Authority),
                urlHelper.RouteUrl(result.GetRouteValueDictionary()));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions);
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.BeginForm(result, ajaxOptions, null);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return BeginForm(ajaxHelper, result, ajaxOptions, new RouteValueDictionary(htmlAttributes));
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return ajaxHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, ajaxOptions, htmlAttributes);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result) {
            return MapRoute(routes, name, url, result, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, string[] namespaces) {
            return MapRoute(routes, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRoute(routes, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            routes.Add(name, route);
            return route;
        }

        // Note: can't name the AreaRegistrationContext methods 'MapRoute', as that conflicts with the existing methods
        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result) {
            return MapRouteArea(context, name, url, result, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, string[] namespaces) {
            return MapRouteArea(context, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRouteArea(context, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            if ((namespaces == null) && (context.Namespaces != null)) {
                 namespaces = context.Namespaces.ToArray();
            }
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            context.Routes.Add(name, route);
            route.DataTokens["area"] = context.AreaName;
            bool useNamespaceFallback = (namespaces == null) || (namespaces.Length == 0);
            route.DataTokens["UseNamespaceFallback"] = useNamespaceFallback;
            return route;
        }

        private static Route CreateRoute(string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Start by adding the default values from the anonymous object (if any)
            var routeValues = new RouteValueDictionary(defaults);

            // Then add the Controller/Action names and the parameters from the call
            foreach (var pair in result.GetRouteValueDictionary()) {
                routeValues.Add(pair.Key, pair.Value);
            }

            var routeConstraints = new RouteValueDictionary(constraints);

            // Create and add the route
            var route = new Route(url, routeValues, routeConstraints, new MvcRouteHandler());

            route.DataTokens = new RouteValueDictionary();

            if (namespaces != null && namespaces.Length > 0) {
                route.DataTokens["Namespaces"] = namespaces;
            }

            return route;
        }

        public static IT4MVCActionResult GetT4MVCResult(this ActionResult result) {
            var t4MVCResult = result as IT4MVCActionResult;
            if (t4MVCResult == null) {
                throw new InvalidOperationException("T4MVC was called incorrectly. You may need to force it to regenerate by right clicking on T4MVC.tt and choosing Run Custom Tool");
            }
            return t4MVCResult;
        }

        public static RouteValueDictionary GetRouteValueDictionary(this ActionResult result) {
            return result.GetT4MVCResult().RouteValueDictionary;
        }

        public static ActionResult AddRouteValues(this ActionResult result, object routeValues) {
            return result.AddRouteValues(new RouteValueDictionary(routeValues));
        }

        public static ActionResult AddRouteValues(this ActionResult result, RouteValueDictionary routeValues) {
            RouteValueDictionary currentRouteValues = result.GetRouteValueDictionary();

            // Add all the extra values
            foreach (var pair in routeValues) {
                currentRouteValues.Add(pair.Key, pair.Value);
            }

            return result;
        }

        public static ActionResult AddRouteValues(this ActionResult result, System.Collections.Specialized.NameValueCollection nameValueCollection) {
            // Copy all the values from the NameValueCollection into the route dictionary
            nameValueCollection.CopyTo(result.GetRouteValueDictionary());
            return result;
        }

        public static ActionResult AddRouteValue(this ActionResult result, string name, object value) {
            RouteValueDictionary routeValues = result.GetRouteValueDictionary();
            routeValues.Add(name, value);
            return result;
        }
        
        public static void InitMVCT4Result(this IT4MVCActionResult result, string area, string controller, string action) {
            result.Controller = controller;
            result.Action = action;
            result.RouteValueDictionary = new RouteValueDictionary();
            if (!String.IsNullOrWhiteSpace(area)) {result.RouteValueDictionary.Add("Area", area ?? "");} 
            result.RouteValueDictionary.Add("Controller", controller);
            result.RouteValueDictionary.Add("Action", action);
        }

        public static bool FileExists(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return false;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return System.IO.File.Exists(filePath);
        }

        static DateTime CenturyBegin=new DateTime(2001,1,1);
        public static string TimestampString(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return String.Empty;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return Convert.ToString((System.IO.File.GetLastWriteTimeUtc(filePath).Ticks-CenturyBegin.Ticks)/1000000000,16);            
        }
    }
}



namespace T4MVC {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}


  

   
[GeneratedCode("T4MVC", "2.0")]   
public interface IT4MVCActionResult {   
    string Action { get; set; }   
    string Controller { get; set; }   
    RouteValueDictionary RouteValueDictionary { get; set; }   
}   
  

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult {
    public T4MVC_ActionResult(string area, string controller, string action): base()  {
        this.InitMVCT4Result(area, controller, action);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string async_file_upload_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/async-file-upload.min.js") ? Url("async-file-upload.min.js") : Url("async-file-upload.js");
                      
        public static readonly string d3_v3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/d3.v3.min.js") ? Url("d3.v3.min.js") : Url("d3.v3.js");
                      
        public static readonly string d3_v3_min_js = Url("d3.v3.min.js");
        public static readonly string jquery_1_11_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.11.0.intellisense.min.js") ? Url("jquery-1.11.0.intellisense.min.js") : Url("jquery-1.11.0.intellisense.js");
                      
        public static readonly string jquery_1_11_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.11.0.min.js") ? Url("jquery-1.11.0.min.js") : Url("jquery-1.11.0.js");
                      
        public static readonly string jquery_1_11_0_min_js = Url("jquery-1.11.0.min.js");
        public static readonly string jquery_1_11_0_min_map = Url("jquery-1.11.0.min.map");
        public static readonly string jquery_ui_1_10_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.3.min.js") ? Url("jquery-ui-1.10.3.min.js") : Url("jquery-ui-1.10.3.js");
                      
        public static readonly string jquery_ui_1_10_3_min_js = Url("jquery-ui-1.10.3.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
                      
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
                      
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
                      
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string knockout_2_2_1_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.2.1.debug.min.js") ? Url("knockout-2.2.1.debug.min.js") : Url("knockout-2.2.1.debug.js");
                      
        public static readonly string knockout_2_2_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.2.1.min.js") ? Url("knockout-2.2.1.min.js") : Url("knockout-2.2.1.js");
                      
        public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
                      
        public static readonly string nugetgallery_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/nugetgallery.min.js") ? Url("nugetgallery.min.js") : Url("nugetgallery.js");
                      
        public static readonly string perpackagestatsgraphs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/perpackagestatsgraphs.min.js") ? Url("perpackagestatsgraphs.min.js") : Url("perpackagestatsgraphs.js");
                      
        public static readonly string stats_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/stats.min.js") ? Url("stats.min.js") : Url("stats.js");
                      
        public static readonly string statsdimensions_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/statsdimensions.min.js") ? Url("statsdimensions.min.js") : Url("statsdimensions.js");
                      
        public static readonly string statsgraphs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/statsgraphs.min.js") ? Url("statsgraphs.min.js") : Url("statsgraphs.js");
                      
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string clippy_swf = Url("clippy.swf");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class font {
            private const string URLPATH = "~/Content/font";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string fontawesome_webfont_eot = Url("fontawesome-webfont.eot");
            public static readonly string fontawesome_webfont_svg = Url("fontawesome-webfont.svg");
            public static readonly string fontawesome_webfont_ttf = Url("fontawesome-webfont.ttf");
            public static readonly string fontawesome_webfont_woff = Url("fontawesome-webfont.woff");
            public static readonly string FontAwesome_otf = Url("FontAwesome.otf");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class font_awesome {
            private const string URLPATH = "~/Content/font-awesome";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string font_awesome_ie7_min_css = Url("font-awesome-ie7.min.css");
            public static readonly string font_awesome_css = Url("font-awesome.css");
            public static readonly string font_awesome_min_css = Url("font-awesome.min.css");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string errorPage_png = Url("errorPage.png");
            public static readonly string headerbackground_png = Url("headerbackground.png");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class icons {
                private const string URLPATH = "~/Content/Images/icons";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string nuget_32_mono_b_png = Url("nuget_32_mono_b.png");
                public static readonly string nuget_32_mono_w_png = Url("nuget_32_mono_w.png");
            }
        
            public static readonly string inputBackground_png = Url("inputBackground.png");
            public static readonly string packageDefaultIcon_50x50_png = Url("packageDefaultIcon-50x50.png");
            public static readonly string packageDefaultIcon_png = Url("packageDefaultIcon.png");
            public static readonly string packageOwnerActionIcons_png = Url("packageOwnerActionIcons.png");
            public static readonly string required_png = Url("required.png");
            public static readonly string searchButton_png = Url("searchButton.png");
            public static readonly string YourPackage_png = Url("YourPackage.png");
        }
    
        public static readonly string Layout_css = Url("Layout.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Logos {
            private const string URLPATH = "~/Content/Logos";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string hero_png = Url("hero.png");
            public static readonly string herowithlogo_png = Url("herowithlogo.png");
            public static readonly string nugetlogo_png = Url("nugetlogo.png");
            public static readonly string nugetLogoFooter_png = Url("nugetLogoFooter.png");
            public static readonly string outercurve_png = Url("outercurve.png");
        }
    
        public static readonly string PageStylings_css = Url("PageStylings.css");
        public static readonly string Site_css = Url("Site.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class SyntaxHighlighter {
            private const string URLPATH = "~/Content/SyntaxHighlighter";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string shCore_css = Url("shCore.css");
            public static readonly string shCoreDefault_css = Url("shCoreDefault.css");
            public static readonly string shCoreDjango_css = Url("shCoreDjango.css");
            public static readonly string shCoreEclipse_css = Url("shCoreEclipse.css");
            public static readonly string shCoreEmacs_css = Url("shCoreEmacs.css");
            public static readonly string shCoreFadeToGrey_css = Url("shCoreFadeToGrey.css");
            public static readonly string shCoreMDUltra_css = Url("shCoreMDUltra.css");
            public static readonly string shCoreMidnight_css = Url("shCoreMidnight.css");
            public static readonly string shCoreRDark_css = Url("shCoreRDark.css");
            public static readonly string shThemeDefault_css = Url("shThemeDefault.css");
            public static readonly string shThemeDjango_css = Url("shThemeDjango.css");
            public static readonly string shThemeEclipse_css = Url("shThemeEclipse.css");
            public static readonly string shThemeEmacs_css = Url("shThemeEmacs.css");
            public static readonly string shThemeFadeToGrey_css = Url("shThemeFadeToGrey.css");
            public static readonly string shThemeMDUltra_css = Url("shThemeMDUltra.css");
            public static readonly string shThemeMidnight_css = Url("shThemeMidnight.css");
            public static readonly string shThemeRDark_css = Url("shThemeRDark.css");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class @base {
                private const string URLPATH = "~/Content/themes/base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                    public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                    public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                    public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                    public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                    public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                    public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                    public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                    public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                    public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                    public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                    public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                    public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                    public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                }
            
                public static readonly string jquery_ui_css = Url("jquery-ui.css");
                public static readonly string jquery_ui_accordion_css = Url("jquery.ui.accordion.css");
                public static readonly string jquery_ui_all_css = Url("jquery.ui.all.css");
                public static readonly string jquery_ui_autocomplete_css = Url("jquery.ui.autocomplete.css");
                public static readonly string jquery_ui_base_css = Url("jquery.ui.base.css");
                public static readonly string jquery_ui_button_css = Url("jquery.ui.button.css");
                public static readonly string jquery_ui_core_css = Url("jquery.ui.core.css");
                public static readonly string jquery_ui_datepicker_css = Url("jquery.ui.datepicker.css");
                public static readonly string jquery_ui_dialog_css = Url("jquery.ui.dialog.css");
                public static readonly string jquery_ui_menu_css = Url("jquery.ui.menu.css");
                public static readonly string jquery_ui_progressbar_css = Url("jquery.ui.progressbar.css");
                public static readonly string jquery_ui_resizable_css = Url("jquery.ui.resizable.css");
                public static readonly string jquery_ui_selectable_css = Url("jquery.ui.selectable.css");
                public static readonly string jquery_ui_slider_css = Url("jquery.ui.slider.css");
                public static readonly string jquery_ui_spinner_css = Url("jquery.ui.spinner.css");
                public static readonly string jquery_ui_tabs_css = Url("jquery.ui.tabs.css");
                public static readonly string jquery_ui_theme_css = Url("jquery.ui.theme.css");
                public static readonly string jquery_ui_tooltip_css = Url("jquery.ui.tooltip.css");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class minified {
                    private const string URLPATH = "~/Content/themes/base/minified";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                    public static class images {
                        private const string URLPATH = "~/Content/themes/base/minified/images";
                        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                        public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                        public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                        public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                        public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                        public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                        public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                        public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                        public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                        public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                        public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                        public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                        public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                        public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                        public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                    }
                
                    public static readonly string jquery_ui_min_css = Url("jquery-ui.min.css");
                    public static readonly string jquery_ui_accordion_min_css = Url("jquery.ui.accordion.min.css");
                    public static readonly string jquery_ui_autocomplete_min_css = Url("jquery.ui.autocomplete.min.css");
                    public static readonly string jquery_ui_button_min_css = Url("jquery.ui.button.min.css");
                    public static readonly string jquery_ui_core_min_css = Url("jquery.ui.core.min.css");
                    public static readonly string jquery_ui_datepicker_min_css = Url("jquery.ui.datepicker.min.css");
                    public static readonly string jquery_ui_dialog_min_css = Url("jquery.ui.dialog.min.css");
                    public static readonly string jquery_ui_menu_min_css = Url("jquery.ui.menu.min.css");
                    public static readonly string jquery_ui_progressbar_min_css = Url("jquery.ui.progressbar.min.css");
                    public static readonly string jquery_ui_resizable_min_css = Url("jquery.ui.resizable.min.css");
                    public static readonly string jquery_ui_selectable_min_css = Url("jquery.ui.selectable.min.css");
                    public static readonly string jquery_ui_slider_min_css = Url("jquery.ui.slider.min.css");
                    public static readonly string jquery_ui_spinner_min_css = Url("jquery.ui.spinner.min.css");
                    public static readonly string jquery_ui_tabs_min_css = Url("jquery.ui.tabs.min.css");
                    public static readonly string jquery_ui_theme_min_css = Url("jquery.ui.theme.min.css");
                    public static readonly string jquery_ui_tooltip_min_css = Url("jquery.ui.tooltip.min.css");
                }
            
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class custom {
                private const string URLPATH = "~/Content/themes/custom";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string jquery_ui_1_10_3_custom_css = Url("jquery-ui-1.10.3.custom.css");
                public static readonly string jquery_ui_1_10_3_custom_min_css = Url("jquery-ui-1.10.3.custom.min.css");
            }
        
        }
    
    }

}

static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;


    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


