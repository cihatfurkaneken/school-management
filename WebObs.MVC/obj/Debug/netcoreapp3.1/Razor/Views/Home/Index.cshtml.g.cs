#pragma checksum "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7186ce2f65d382d78f812a9833c10a3591c01ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\_ViewImports.cshtml"
using WebObs.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\_ViewImports.cshtml"
using WebObs.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Home\Index.cshtml"
using WebObs.MVC.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7186ce2f65d382d78f812a9833c10a3591c01ba7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f83a2fd80ef7f7576a04c536943f09215007d0b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""card-box"">
            <br />
            <h2 class=""display-4"">WEB PROGRAMLAMA ÖDEVİ</h2>
            <h4>Soldaki menüden işlemlere ulaşabilirsiniz</h4>
            <h5>172120003 - Cihat Furkan Eken</h5>
            <p class=""text-muted font-13 m-t-20""><b>");
#nullable restore
#line 17 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Home\Index.cshtml"
                                               Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> Olarak Giriş Yaptınız. </p>\r\n            <br />\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppIdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591