#pragma checksum "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed92e487509727a7ceff34f0411de7bcfb7d5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_HomePage), @"mvc.1.0.view", @"/Views/Restaurant/HomePage.cshtml")]
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
#line 1 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\_ViewImports.cshtml"
using MyntraApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\_ViewImports.cshtml"
using MyntraApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
using CommanLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed92e487509727a7ceff34f0411de7bcfb7d5d1", @"/Views/Restaurant/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b3dc22bbdf0e520c991af342611bd101ead9d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Restaurant_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FoodApp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
  
    var data = ViewBag.Category;
    var loginmsg = @ViewBag.loginmsg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
  
    ViewData["Title"] = "HomePage";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aed92e487509727a7ceff34f0411de7bcfb7d5d15916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aed92e487509727a7ceff34f0411de7bcfb7d5d17030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




<div class=""container-fluid text-center searchdiv"">

    <nav class=""navbar navbar-inverse  navigationbar"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""collapse navbar-collapse"" id=""myNavbar"">
                <ul class=""nav navbar-nav navbar-right"">
");
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-default btn-lg\" id=\"myBtns\"><span class=\"glyphicon glyphicon-user\"></span>Sign Up</button>\r\n                    ");
#nullable restore
#line 36 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
               Write(Html.Partial("SignupPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-default btn-lg\" id=\"myBtn\"><span class=\"glyphicon glyphicon-log-in\"></span> Login</button>\r\n\r\n                    ");
#nullable restore
#line 39 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
               Write(Html.Partial("LoginPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n");
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    <h1><em>zomato</em></h1>\r\n    <h2>Find The Best Restaurant, Cafe, And Bars</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aed92e487509727a7ceff34f0411de7bcfb7d5d19925", async() => {
                WriteLiteral(@"
        <span class=""input-group searechbar"">
            <div class=""input-group-btn"">
                <button class=""btn btn-default searechbarbtn"" type=""submit"">
                    <i class=""glyphicon glyphicon-map-marker""></i>
                </button>
            </div>
            <input type=""search"" class=""form-control txtname""  placeholder=""Search your location "" required>
        </span>
        <span class=""input-group searechbar"">
            <div class=""input-group-btn"">
                <button class=""btn btn-default searechbarbtn"" type=""submit"">
                    <i class=""glyphicon glyphicon-search""></i>
                </button>
            </div>
            <input type=""text"" class=""form-control"" size=""50"" placeholder=""Search for Restaurant"" required>
        </span>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div class=\"container \">\r\n    <h1> Quick Search</h1>\r\n    <h3>Select Your City</h3>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 89 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
Write(Html.DropDownList("citylist",new SelectList( (IEnumerable<string>)@ViewBag.citylist),"Please Select Your City",new {@class="form-control Citys"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p class=\"alert-danger\">");
#nullable restore
#line 90 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
                       Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3>Find Restaurant By Meal Type</h3>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 93 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
         foreach (var item in (List<CategoryModel>)@ViewData["category"])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 4244, "\"", 4287, 2);
            WriteAttributeValue("", 4251, "/Restaurant/Listing/", 4251, 20, true);
#nullable restore
#line 95 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
WriteAttributeValue("", 4271, item.CategoryId, 4271, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-sm-4 card\">\r\n                    <div class=\"inside\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4406, "\"", 4431, 1);
#nullable restore
#line 98 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
WriteAttributeValue("", 4412, item.CategoryImage, 4412, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4432, "\"", 4438, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"inside2\">\r\n                        <h4>");
#nullable restore
#line 101 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 102 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
                      Write(item.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 106 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<hr />\r\n<footer class=\"bg-white\">\r\n    ");
#nullable restore
#line 112 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
Write(Html.Partial("Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</footer>\r\n\r\n<script type=\"text/javascript\">\r\n    //var a = ");
#nullable restore
#line 116 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\HomePage.cshtml"
         Write(ViewBag.loginmsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    //if(a!=null){\r\n        window.onload = function () {\r\n            $(\"#myModal\").modal();\r\n        }\r\n    //}\r\n    \r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
