#pragma checksum "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044e8dec181ce2740964c4b70291b3c5d2ddb075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ListingPage), @"mvc.1.0.view", @"/Views/User/ListingPage.cshtml")]
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
#line 1 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
using CommanLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"044e8dec181ce2740964c4b70291b3c5d2ddb075", @"/Views/User/ListingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b3dc22bbdf0e520c991af342611bd101ead9d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ListingPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/home.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css"" rel=""stylesheet""
      integrity=""sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx"" crossorigin=""anonymous"">
<!-- JavaScript Bundle with Popper -->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-A3rJD856KowSb7dwlZdYEkO39Gagi7vIsF0jrRAoQmDKKtQBHUuLZ9AsSv4jD4Xa""
        crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<link rel=""stylesheet"" href=""/css/Listing.css"">
<script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "044e8dec181ce2740964c4b70291b3c5d2ddb0754724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
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
            <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">

                <div class=""search"">
                    <div class=""dropdown "">
                        <a class=""btn  dropdown-toggle location"" href=""#"" role=""button"" data-bs-toggle=""dropdown""
                           aria-expanded=""false"">
                            <i class=""bi bi-geo-alt-fill""></i> location
                        </a>

                        <ul class=""dr");
            WriteLiteral(@"opdown-menu"">
                            <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                        </ul>
                    </div>
                    <input type=""text"" class=""form-control"" placeholder=""Search for restaurant, cuisine or a dish""
                           aria-label=""First name"">
                </div>

                <div class=""nav-item dropdown navigation"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" role=""button"" data-bs-toggle=""dropdown""
                       aria-expanded=""false"">
                        <i class=""bi bi-person-fill""></i> ANIKET
                    </a>
                    <ul class=""dropdown-menu"">
                        <li><a class=""dropdown-item"" href=""#"">profile</a></li>
                        <li><a class=""dropdown-item""");
            WriteLiteral(@" href=""#"">Notification</a></li>
                        <li><a class=""dropdown-item"" href=""#"">Bookmark</a></li>
                        <li><a class=""dropdown-item"" href=""#"">setting</a></li>
                        <li><a class=""dropdown-item"" href=""#"">logout</a></li>
                    </ul>
                </div>

            </div>
        </div>
    </nav>
    <nav aria-label=""breadcrumb"" class=""breadbox"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item""><a href=""#""> India</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Chandrapur</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Restaurants</li>
        </ol>
    </nav>

    <!-- <div id=""delivery"">

        <div id=""dtext"">
            <a href=""#""> Delivery </a>
            <a href=""#""> DineIn</a>
            <img src=""images/deliverylogo.png"" alt=""delivery"" id=""dlogo"">

            <img src=""images/d");
            WriteLiteral(@"ineinlogo.png"" alt=""dinein"" id=""dinelogo"">
        </div>
    </div> -->
    <!-- <div class=""d-flex"">
        <div class=""card mb-3"" id=""delivery"">
            <div class=""row g-0"">
                <div class=""col-md-4"">
                    <img src=""images/deliverylogo.png"" class=""img-fluid rounded-start"" alt=""..."">
                </div>
                <div class=""col-md-8"">
                    <div class=""card-body"">
                        <a href="""" style=""text-decoration: none;color: gray;"">
                            <h5 class=""card-title"">Delivery</h5>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""card mb-3"" id=""dine"">
            <div class=""row g-0"">
                <div class=""col-md-4"">
                    <img src=""images/dineinlogo.png"" class=""img-fluid rounded-start"" alt=""..."">
                </div>
                <div class=""col-md-8"">
                    <div class=""card-body"">
            WriteLiteral(@"
                        <a href="""" style=""text-decoration: none;color: gray;"">
                            <h5 class=""card-title"">Dine In</h5>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div> -->
    <hr>
    <div class=""conatiner filterbtn"">
        <!-- Button trigger modal -->
        <!-- <button type=""button"" class=""btn btn-outline-secondary me-3"" style=""width: 100px;font-weight:600;""
            data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop"">
            Filters
        </button>

        < Modal -->
        <!-- <div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1""
            aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""mo");
            WriteLiteral(@"dal-title"" id=""staticBackdropLabel""> Filters </h5>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""filter"">
                            <SMAll> Select location</SMAll><br>
                            <select name=""location"">
                                <option>select location</option>
                                <option>munbai</option>
                                <option>pune</option>
                                <option>nagpur</option>
                                <option>hyderbad</option>
                            </select>
                            <div class=""cuisine"">
                                <h4>cuisine</h4>
                                <ul>
                                    <li> <input type=""checkbox""> North Indian</li>
                                    <li> <input type=""check");
            WriteLiteral(@"box""> south Indian</li>
                                    <li> <input type=""checkbox""> chinese</li>
                                    <li> <input type=""checkbox""> Fast food</li>
                                    <li> <input type=""checkbox""> snacks and desert</li>
                                </ul>
                                <h4>cost for two</h4>
                                <ul>
                                    <li> <input type=""radio"" name=""h""> less than 500</li>
                                    <li> <input type=""radio"" name=""h""> 500 to 1000</li>
                                    <li> <input type=""radio"" name=""h""> 1000 to 1500</li>
                                    <li> <input type=""radio"" name=""h""> 1500 to 2000</li>
                                    <li> <input type=""radio"" name=""h""> 2000 to 2500</li>
                                </ul>
                                <h4> sort</h4>
                                <ul>
                                    <li> <i");
            WriteLiteral(@"nput type=""radio"" name=""h""> price low to high</li>
                                    <li> <input type=""radio"" name=""h""> price high to low</li>

                                </ul>

                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                        <button type=""button"" class=""btn btn-primary"">Apply</button>
                    </div>
                </div>
            </div>
        </div> -->
        ");
#nullable restore
#line 175 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
   Write(Html.Partial("FilterPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <button type=""button"" class=""btn btn-outline-secondary me-3"">pure veg</button>
        <button type=""button"" class=""btn btn-outline-secondary me-3"">Rating 4.0+</button>
        <a href=""/Restaurant/Showallrestaurant""><button type=""button"" class=""btn btn-outline-secondary me-3"">Show All</button></a>
        <p> Restaurants in ");
#nullable restore
#line 179 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
                      Write(TempData["city"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
            WriteLiteral("        <div class=\"main col-md-8\">\r\n            <div class=\"container text-center mt-5\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 233 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
                     foreach (var item in (List<RestaurantModel>)@ViewData["list"])
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4 mt-3\">\r\n                            <div class=\"card item\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 11161, "\"", 11178, 1);
#nullable restore
#line 237 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
WriteAttributeValue("", 11167, item.Image, 11167, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;\" class=\"card-img-top\" alt=\"...\">\r\n                                <div class=\"card-body\">\r\n\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 240 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <h6 class=""card-subtitle mb-2"">
                                        <div id=""star"">
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                        </div>
                                    </h6>
                                    <p class=""card-text""> ");
#nullable restore
#line 250 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
                                                     Write(item.Menutype);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> ");
#nullable restore
#line 250 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
                                                                         Write(item.CostPerPerson);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for one</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 254 "C:\Users\91962\Desktop\MvcProject\MyntraApp\MyntraApp\Views\User\ListingPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<footer class=""bg-white mt-3 fut"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-2 col-md-6 mb-4 mb-lg-0 mt-2"">
                <h6 class=""text-uppercase font-weight-bold mb-4"">About</h6>
                <ul class=""list-unstyled mb-0"">
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Contact Us</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">About Us</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Stories</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Press</a></li>
                </ul>
            </div>

            <div class=""col-lg-2 col-md-6 mb-4 mb-lg-0 mt-2"">
                <h6 class=""text-uppercase font-weight-bold mb-4"">Help</h6>
                <ul class=""list-unstyled mb-0"">
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Payments</a></");
            WriteLiteral(@"li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Shipping</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Cancellation</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Returns</a></li>
                </ul>
            </div>

            <div class=""col-lg-2 col-md-6 mb-4 mb-lg-0 mt-2"">
                <h6 class=""text-uppercase font-weight-bold mb-4"">Policy</h6>
                <ul class=""list-unstyled mb-0"">
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Return Policy</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Terms Of Use</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Security</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Privacy</a></li>
                </ul>
            </div>
            <div class=""col-lg-2 col-md-6 mb-4 mb-lg-0 mt-2"">
                <h6 class=""text-uppercase font-weight-bold");
            WriteLiteral(@" mb-4"">Company</h6>
                <ul class=""list-unstyled mb-0"">
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Login</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Register</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Sitemap</a></li>
                    <li class=""mb-2""><a href=""#"" class=""text-muted"">Our Products</a></li>
                </ul>
            </div>
            <div class=""col-lg-4 col-md-6 mb-lg-0 mt-2"">
                <h6 class=""text-uppercase font-weight-bold mb-4"">Registered Office Address</h6>
                <p class=""text-muted mb-4"">
                    Here , write the complete address of the Registered office address along
                    with telephone number.
                </p>
                <ul class=""list-inline mt-4"">
                    <li class=""list-inline-item"">
                        <a href=""#"" target=""_blank"" title=""twitter"">
                            <i clas");
            WriteLiteral(@"s=""fa fa-twitter""></i>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a href=""#"" target=""_blank"" title=""facebook"">
                            <i class=""fa fa-facebook""></i>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a href=""#"" target=""_blank"" title=""instagram"">
                            <i class=""fa fa-instagram""></i>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a href=""#"" target=""_blank"" title=""pinterest"">
                            <i class=""fa fa-youtube""></i>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a href=""#"" target=""_blank"" title=""vimeo"">
                            <i class=""fa fa-google""></i>
                        </a>
                 ");
            WriteLiteral(@"   </li>
                </ul>
            </div>
        </div>
    </div>
    <hr class=""p-0 m-0 b-0"">
    <div class=""bg-light py-2"">
        <div class=""container text-center"">
            <p class=""text-muted mb-0 py-2"">&copy; 2019 zomato All risghts reserved.</p>
        </div>
    </div>
</footer>
");
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