#pragma checksum "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be6140c8ded68a2e9d9cbc5e1c76e8ff835f3baf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_MenuPage), @"mvc.1.0.view", @"/Views/Restaurant/MenuPage.cshtml")]
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
#line 1 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
using CommanLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6140c8ded68a2e9d9cbc5e1c76e8ff835f3baf", @"/Views/Restaurant/MenuPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b3dc22bbdf0e520c991af342611bd101ead9d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Restaurant_MenuPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/home.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RestaurantController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
  
    RestaurantModel restaurant = @ViewBag.Restaurant;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css"" rel=""stylesheet""
      integrity=""sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx"" crossorigin=""anonymous"">
<!-- JavaScript Bundle with Popper -->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-A3rJD856KowSb7dwlZdYEkO39Gagi7vIsF0jrRAoQmDKKtQBHUuLZ9AsSv4jD4Xa""
        crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<link rel=""stylesheet"" href=""/css/Listing.css"">
<link rel=""stylesheet"" href=""/css/FoodApp.css"">
<link rel=""stylesheet"" href=""/css/MenuPage.css"">
<script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6140c8ded68a2e9d9cbc5e1c76e8ff835f3baf6315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""container "">
    <nav class=""navbar navbar-expand-lg bg-light bg-transparent "">
        <div class=""container-fluid d-flex"">
            <a class=""navbar-brand logo"" href=""#""><em>zomato</em></a>
            <button class=""navbar-toggler navigation"" type=""button"" data-bs-toggle=""collapse""
                    data-bs-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false""
                    aria-label=""Toggle "">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse d-flex"" id=""navbarNavDropdown"">

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6140c8ded68a2e9d9cbc5e1c76e8ff835f3baf8881", async() => {
                WriteLiteral(@"
                    <div class=""input-group-btn"">
                        <button class=""btn btn-default"" style=""margin:5px"" type=""submit"" formaction=""GetRestautrantbyName"">
                            <i class=""bi bi-search""></i>
                        </button>
                    </div>
                    <input type=""text"" class=""form-control"" name=""searchinput"" placeholder=""Search for restaurant, cuisine or a dish"">
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <div class=""nav-item dropdown navigation"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" role=""button"" data-bs-toggle=""dropdown""
                       aria-expanded=""false"">
                        <i class=""bi bi-person-fill""></i> ANIKET
                    </a>
                    <ul class=""dropdown-menu"">
                        <li><a class=""dropdown-item"" href=""#"">Orders</a></li>
                        <li><a class=""dropdown-item"" href=""#"">Logout</a></li>
                    </ul>
                </div>
                <div class=""navigation"">
                    <i class=""bi bi-cart""></i>Cart(0)
                </div>

            </div>
        </div>
    </nav>
    <hr />
    <div>
        <div class=""Resturantdetails"">
            <img");
            BeginWriteAttribute("src", " src=", 3159, "", 3181, 1);
#nullable restore
#line 61 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
WriteAttributeValue("", 3164, restaurant.Image, 3164, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:400px\"/>\r\n        </div>\r\n        <div class=\"resttext\">\r\n            <p style=\"color:black;font-size:40px;margin:0px\">");
#nullable restore
#line 64 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
                                                        Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 65 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
          Write(restaurant.Menutype);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>");
#nullable restore
#line 65 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
                                    Write(restaurant.CostPerPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral(" For One</p>            \r\n        </div>\r\n    </div>\r\n    <hr / style=\"margin:0px\">\r\n    <p style=\"color:dimgrey;font-size:20px;margin:0px\">Add Your Dishes</p>\r\n\r\n    <div class=\"row d-flex d-inline-block\">\r\n");
#nullable restore
#line 72 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
         foreach (var menu in (List<MenuModel>)@ViewBag.Menu)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card mb-3 d-flex\" style=\"max-width: 540px;\">\r\n                    <div class=\"row g-0\">\r\n                        <div class=\"col-md-5\">\r\n                            <img");
            BeginWriteAttribute("src", " src=", 3893, "", 3909, 1);
#nullable restore
#line 77 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
WriteAttributeValue("", 3898, menu.Image, 3898, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\">\r\n                        </div>\r\n                        <div class=\"col-md-7\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 81 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
                                                  Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                               ₹ ");
#nullable restore
#line 83 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
                            Write(menu.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />        
                                <span class=""text-body-secondary"">Quantity: <span>-</span> 1 <span>+</span></span>
                            </p>
                                <button type=""button"" class=""btn btn-success"">Add To Cart</button>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 91 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<hr />\r\n\r\n<footer class=\"bg-white\">\r\n    ");
#nullable restore
#line 97 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\Restaurant\MenuPage.cshtml"
Write(Html.Partial("Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</footer>");
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