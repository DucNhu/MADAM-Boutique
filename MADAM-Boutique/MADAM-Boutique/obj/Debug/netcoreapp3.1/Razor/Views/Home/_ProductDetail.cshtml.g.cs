#pragma checksum "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6cec3c1cf209f45cc181979ce01ba1b4e879877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ProductDetail), @"mvc.1.0.view", @"/Views/Home/_ProductDetail.cshtml")]
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
#line 1 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\_ViewImports.cshtml"
using MADAM_Boutique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\_ViewImports.cshtml"
using MADAM_Boutique.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\_ViewImports.cshtml"
using MADAM_Boutique.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
using MADAM_Boutique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6cec3c1cf209f45cc181979ce01ba1b4e879877", @"/Views/Home/_ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e9228fcf9a064465c1f9aa0b2ca47c68204b0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn border-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6cec3c1cf209f45cc181979ce01ba1b4e8798775931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-3"">
                <div class=""left-sidebar"">
                    <h2>Category</h2>
                    <div class=""panel-group category-products"" id=""accordian"">
                        <!--category-productsr-->
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Sportswear
                                    </a>
                                </h4>
                            </div>
                            <div id=""sportswear"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
     ");
            WriteLiteral("                               <ul>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1187, 0);
            EndWriteAttribute();
            WriteLiteral(">Nike </a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1251, "\"", 1258, 0);
            EndWriteAttribute();
            WriteLiteral(">Under Armour </a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1330, "\"", 1337, 0);
            EndWriteAttribute();
            WriteLiteral(">Adidas </a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1403, "\"", 1410, 0);
            EndWriteAttribute();
            WriteLiteral(">Puma</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1473, "\"", 1480, 0);
            EndWriteAttribute();
            WriteLiteral(@">ASICS </a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#mens"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Mens
                                    </a>
                                </h4>
                            </div>
                            <div id=""mens"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2418, "\"", 2425, 0);
            EndWriteAttribute();
            WriteLiteral(">Fendi</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2489, "\"", 2496, 0);
            EndWriteAttribute();
            WriteLiteral(">Guess</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2560, "\"", 2567, 0);
            EndWriteAttribute();
            WriteLiteral(">Valentino</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2635, "\"", 2642, 0);
            EndWriteAttribute();
            WriteLiteral(">Dior</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2705, "\"", 2712, 0);
            EndWriteAttribute();
            WriteLiteral(">Versace</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2778, "\"", 2785, 0);
            EndWriteAttribute();
            WriteLiteral(">Armani</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2850, "\"", 2857, 0);
            EndWriteAttribute();
            WriteLiteral(">Prada</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2921, "\"", 2928, 0);
            EndWriteAttribute();
            WriteLiteral(">Dolce and Gabbana</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3004, "\"", 3011, 0);
            EndWriteAttribute();
            WriteLiteral(">Chanel</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3076, "\"", 3083, 0);
            EndWriteAttribute();
            WriteLiteral(@">Gucci</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>

                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#womens"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Womens
                                    </a>
                                </h4>
                            </div>
                            <div id=""womens"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4028, "\"", 4035, 0);
            EndWriteAttribute();
            WriteLiteral(">Fendi</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4099, "\"", 4106, 0);
            EndWriteAttribute();
            WriteLiteral(">Guess</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4170, "\"", 4177, 0);
            EndWriteAttribute();
            WriteLiteral(">Valentino</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4245, "\"", 4252, 0);
            EndWriteAttribute();
            WriteLiteral(">Dior</a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 4315, "\"", 4322, 0);
            EndWriteAttribute();
            WriteLiteral(@">Versace</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Kids</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Fashion</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Households</a></h4>
                            </div>
                        </div>
                        <div class=""panel pa");
            WriteLiteral(@"nel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Interiors</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Clothing</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Bags</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Shoes</a></h4>
                            </div>
                      ");
            WriteLiteral(@"  </div>
                    </div><!--/category-products-->

                    <div class=""brands_products"">
                        <!--brands_products-->
                        <h2>Brands</h2>
                        <div class=""brands-name"">
                            <ul class=""nav nav-pills nav-stacked"">
                                <li><a");
            BeginWriteAttribute("href", " href=\"", 6733, "\"", 6740, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"pull-right\">(50)</span>Acne</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 6832, "\"", 6839, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"pull-right\">(56)</span>Grüne Erde</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 6937, "\"", 6944, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"pull-right\">(27)</span>Albiro</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 7038, "\"", 7045, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"pull-right\">(32)</span>Ronhill</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 7140, "\"", 7147, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"pull-right\">(5)</span>Oddmolly</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 7242, "\"", 7249, 0);
            EndWriteAttribute();
            WriteLiteral("> <span class=\"pull-right\">(9)</span>Boudestijn</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 7346, "\"", 7353, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <span class=""pull-right"">(4)</span>Rösch creative culture</a></li>
                            </ul>
                        </div>
                    </div><!--/brands_products-->

                    <div class=""price-range"">
                        <!--price-range-->
                        <h2>Price Range</h2>
                        <div class=""well"">
                            <input type=""text"" class=""span2""");
            BeginWriteAttribute("value", " value=\"", 7785, "\"", 7793, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-slider-min=""0"" data-slider-max=""600"" data-slider-step=""5"" data-slider-value=""[250,450]"" id=""sl2""><br />
                            <b>$ 0</b> <b class=""pull-right"">$ 600</b>
                        </div>
                    </div><!--/price-range-->

                    <div class=""shipping text-center"">
                        <!--shipping-->
                        <img src=""images/home/shipping.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8214, "\"", 8220, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div><!--/shipping-->

                </div>
            </div>

            <div class=""col-sm-9 padding-right"">
                <div class=""product-details"">
                    <!--product-details-->
                    <div class=""col-sm-5"">
                        <div class=""view-product"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 8587, "\"", 8622, 2);
            WriteAttributeValue("", 8593, "/images/shop/", 8593, 13, true);
#nullable restore
#line 157 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
WriteAttributeValue("", 8606, Model.ImagePath, 8606, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8623, "\"", 8645, 1);
#nullable restore
#line 157 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
WriteAttributeValue("", 8629, Model.ImagePath, 8629, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <h3>ZOOM</h3>\r\n                        </div>\r\n                        <div id=\"similar-product\" class=\"carousel slide\" data-ride=\"carousel\">\r\n\r\n                            <!-- Wrapper for slides -->\r\n");
            WriteLiteral(@"
                            <!-- Controls -->
                            <a class=""left item-control"" href=""#similar-product"" data-slide=""prev"">
                                <i class=""fa fa-angle-left""></i>
                            </a>
                            <a class=""right item-control"" href=""#similar-product"" data-slide=""next"">
                                <i class=""fa fa-angle-right""></i>
                            </a>
                        </div>

                    </div>
                    <div class=""col-sm-7"">
                        <div class=""product-information"">
                            <!--/product-information-->
                            <img src=""images/product-details/new.jpg"" class=""newarrival""");
            BeginWriteAttribute("alt", " alt=\"", 11054, "\"", 11060, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <h2>");
#nullable restore
#line 196 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
                           Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>Web ID: ");
#nullable restore
#line 197 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
                                  Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <img src=\"images/product-details/rating.png\"");
            BeginWriteAttribute("alt", " alt=\"", 11256, "\"", 11262, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <span>\r\n                                <span>US $");
#nullable restore
#line 200 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
                                     Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <label>Quantity:</label>\r\n                                <input type=\"text\" value=\"3\" />\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6cec3c1cf209f45cc181979ce01ba1b4e87987723270", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6cec3c1cf209f45cc181979ce01ba1b4e87987723565", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 204 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ProductID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <button type=\"submit\" class=\"btn add-to-cart\">\r\n                                        <i class=\"fa fa-shopping-cart\"></i>Add to cart\r\n                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 203 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\MADAM-Boutique\MADAM-Boutique\MADAM-Boutique\Views\Home\_ProductDetail.cshtml"
AddHtmlAttributeValue("", 11536, Model.ProductID, 11536, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </span>\r\n                            <p><b>Availability:</b> In Stock</p>\r\n                            <p><b>Condition:</b> New</p>\r\n                            <p><b>Brand:</b> E-SHOPPER</p>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 12207, "\"", 12214, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/product-details/share.png\" class=\"share img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 12288, "\"", 12294, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                        </div><!--/product-information-->
                    </div>
                </div><!--/product-details-->



                <div class=""recommended_items"">
                    <!--recommended_items-->
                    <h2 class=""title text-center"">recommended items</h2>

                    <div id=""recommended-item-carousel"" class=""carousel slide"" data-ride=""carousel"">
                        <div class=""carousel-inner"">
                            <div class=""item active"">
                                <div class=""col-sm-4"">
                                    <div class=""product-image-wrapper"">
                                        <div class=""single-products"">
                                            <div class=""productinfo text-center"">
                                                <img src=""images/home/recommend1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13194, "\"", 13200, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <h2>$56</h2>
                                                <p>Easy Polo Black Edition</p>
                                                <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""product-image-wrapper"">
                                        <div class=""single-products"">
                                            <div class=""productinfo text-center"">
                                                <img src=""images/home/recommend2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14063, "\"", 14069, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <h2>$56</h2>
                                                <p>Easy Polo Black Edition</p>
                                                <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""product-image-wrapper"">
                                        <div class=""single-products"">
                                            <div class=""productinfo text-center"">
                                                <img src=""images/home/recommend3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14932, "\"", 14938, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <h2>$56</h2>
                                                <p>Easy Polo Black Edition</p>
                                                <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""item"">
                                <div class=""col-sm-4"">
                                    <div class=""product-image-wrapper"">
                                        <div class=""single-products"">
                                            <div class=""productinfo text-center"">
                                                <img src=""images/home/recommend1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15885, "\"", 15891, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <h2>$56</h2>
                                                <p>Easy Polo Black Edition</p>
                                                <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""product-image-wrapper"">
                                        <div class=""single-products"">
                                            <div class=""productinfo text-center"">
                                                <img src=""images/home/recommend2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16754, "\"", 16760, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <h2>$56</h2>
                                                <p>Easy Polo Black Edition</p>
                                                <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""product-image-wrapper"">
                                        <div class=""single-products"">
                                            <div class=""productinfo text-center"">
                                                <img src=""images/home/recommend3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17623, "\"", 17629, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <h2>$56</h2>
                                                <p>Easy Polo Black Edition</p>
                                                <button type=""button"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Add to cart</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <a class=""left recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""prev"">
                            <i class=""fa fa-angle-left""></i>
                        </a>
                        <a class=""right recommended-item-control"" href=""#recommended-item-carousel"" data-slide=""next"">
                            <i class=""fa fa-angle-right""></i>
                        </a>
                    </div>
          ");
            WriteLiteral("      </div><!--/recommended_items-->\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6cec3c1cf209f45cc181979ce01ba1b4e87987735599", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!--/Footer-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
