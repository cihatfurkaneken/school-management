#pragma checksum "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b590fdbfddf5e1c2fa6c0bbcbdab8165535341f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Shared\_Layout.cshtml"
using WebObs.MVC.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b590fdbfddf5e1c2fa6c0bbcbdab8165535341f6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f83a2fd80ef7f7576a04c536943f09215007d0b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fixed-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b590fdbfddf5e1c2fa6c0bbcbdab8165535341f63972", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">


    <link rel=""shortcut icon"" href=""/assets/images/favicon.ico"">


    <title>Okul Yönetim Sistemi</title>


    <link href=""/assets/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/core.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/components.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/icons.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/pages.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/menu.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/responsive.css"" rel=""stylesheet"" type=""text/css"" />


    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
    <script src=""https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js""></script>
    <![endif]-->
    <script src=""/assets/js/mod");
                WriteLiteral("ernizr.min.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b590fdbfddf5e1c2fa6c0bbcbdab8165535341f66092", async() => {
                WriteLiteral(@"


    <div id=""wrapper"">

        <div class=""topbar"">


            <div class=""topbar-left"">

            </div>

            <div class=""navbar navbar-default"" role=""navigation"">
                <div class=""container"">

                    <!-- Page title -->
                    <ul class=""nav navbar-nav navbar-left"">
                        <li>
                            <button class=""button-menu-mobile open-left"">
                                <i class=""zmdi zmdi-menu""></i>
                            </button>
                        </li>
                        <li>
                            <h4 class=""page-title"">Okul Yönetim Sistemi</h4>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        
      
        <div class=""left side-menu"">
            <div class=""sidebar-inner slimscrollleft"">
                <div class=""user-box"">
                    <h5>Kullanıcı</h5>
                    <h4>");
#nullable restore
#line 72 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Shared\_Layout.cshtml"
                   Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                </div>
              
                <div id=""sidebar-menu"">
                    <ul>
                        <li class=""text-muted menu-title"">Menü</li>

                        <li>
                            <a href=""/Home/Index/"" class=""waves-effect""><i class=""zmdi zmdi-home""></i> <span> Ana Sayfa </span> </a>
                        </li>

                        <li>
                            <a href=""/Ders/GetDersler"" class=""waves-effect""><i class=""zmdi zmdi-book""></i> <span> Dersler </span> </a>
                        </li>

                        <li>
                            <a href=""/Ogrenci/GetOgrenciler"" class=""waves-effect""><i class=""zmdi zmdi-account""></i><span> Öğrenciler </span></a>
                        </li>

                        <li>
                            <a href=""/OgrenciDers/GetOgrenciDers"" class=""waves-effect""><i class=""zmdi zmdi-info""></i><span> Öğrenci Bilgi </span></a>
                        </li>
                      ");
                WriteLiteral(@"  <li>
                            <a href=""/Security/Logout"" class=""waves-effect""><i class=""zmdi zmdi-mail-reply""></i><span> Çıkış Yap </span></a>
                        </li>


                    </ul>
                    <div class=""clearfix""></div>
                </div>
                <!-- Sidebar -->
                <div class=""clearfix""></div>

            </div>

        </div>       
        <div class=""content-page"">    
            <div class=""content"">
                <div class=""container"">

                    <div class=""row"">
                        ");
#nullable restore
#line 113 "C:\Users\cihat\Desktop\WebOBS\WebOBS\WebObs.MVC\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                   

                </div> 

            </div> 

            <footer class=""footer"">
                172120003 - Cihat Furkan Eken
            </footer>

        </div>     
       

    </div>
  



    <script>
        var resizefunc = [];
    </script>

    <!-- jQuery  -->
    <script src=""/assets/js/jquery.min.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>
    <script src=""/assets/js/detect.js""></script>
    <script src=""/assets/js/fastclick.js""></script>
    <script src=""/assets/js/jquery.slimscroll.js""></script>
    <script src=""/assets/js/jquery.blockUI.js""></script>
    <script src=""/assets/js/waves.js""></script>
    <script src=""/assets/js/jquery.nicescroll.js""></script>
    <script src=""/assets/js/jquery.scrollTo.min.js""></script>

    <!-- App js -->
    <script src=""/assets/js/jquery.core.js""></script>
    <script src=""/assets/js/jquery.app.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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