#pragma checksum "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f3d6cc0369ef7f6b4657543ac8ef7751c3c78b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SparkAuto.Pages.Services.Pages_Services_Details), @"mvc.1.0.razor-page", @"/Pages/Services/Details.cshtml")]
namespace SparkAuto.Pages.Services
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
#line 1 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\_ViewImports.cshtml"
using SparkAuto.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f3d6cc0369ef7f6b4657543ac8ef7751c3c78b", @"/Pages/Services/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f761ca82db339dbc6f65982e3b318e57c2553a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Services_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "History", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px; width:423px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container pt-4 pd-2 row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\"> Detailles du Service</h2>\r\n    </div>\r\n\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f3d6cc0369ef7f6b4657543ac8ef7751c3c78b5498", async() => {
                WriteLiteral("\r\n            retour à la liste\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-carId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                                                   WriteLiteral(Model.Service.CarId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["carId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-carId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["carId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""container white-background"">
    <div class=""card"">
        <div class=""card-header bg-dark text-light container row"">
            <div class=""col-1 text-center text-white-50 pt-3"">
                <i class=""fas fa-user fa-2x""></i>
            </div>
            <div class=""col-5"">

                <label class=""text-info"">
                    ");
#nullable restore
#line 27 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
               Write(Html.DisplayFor(m => m.Service.Car.ApplicationUser.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <br />\r\n\r\n                <label class=\"text-info\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
               Write(Model.Service.Car.ApplicationUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 32 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                                          Write(Model.Service.Car.ApplicationUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n\r\n            <div class=\"col-5 text-right\">\r\n                <label class=\"text-info\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
               Write(Html.DisplayFor(m => m.Service.Car.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 38 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                                           Write(Html.DisplayFor(m => m.Service.Car.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 38 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                                                                                        Write(Html.DisplayFor(m => m.Service.Car.Style));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n                <br />\r\n\r\n                <label class=\"text-info\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
               Write(Model.Service.Car.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>

            </div>

            <div class=""col-1 text-center text-white-50 pt-3"">
                <i class=""fas fa-car fa-2x""></i>
            </div>
        </div>

        <div class=""card-body"">

                <div class=""border container rounded p-2"">
                    <h3 class=""text-info pd-2"">Service Summary</h3>

");
#nullable restore
#line 58 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                     if (Model.ServiceDetails.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\" text-danger text-center\" style=\"font-size: 18px\">\r\n                            Aucun service détails dans la liste, Veillez Ajouter un\r\n                        </p>\r\n");
#nullable restore
#line 63 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row mt-3"">
                            <div class=""col-7"">
                                <table class=""table table-striped border"">
                                    <tr class=""table-secondary"">
                                        <th>
                                            ");
#nullable restore
#line 71 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                       Write(Html.DisplayNameFor(m => m.ServiceDetails[0].SerivceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 74 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                       Write(Html.DisplayNameFor(m => m.ServiceDetails[0].SerivcePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                    </tr>\r\n\r\n");
#nullable restore
#line 78 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                     foreach (var item in Model.ServiceDetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 81 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                           Write(Html.DisplayFor(m => item.SerivceName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 82 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                           Write(Html.DisplayFor(m => item.SerivcePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <tr style=""background-color: #e2fee2"">
                                        <td colspan=""1"">
                                            <h6 class=""text-success"">Prix Total : </h6>
                                        </td>
                                        <td colspan=""2"">
                                            <h6 class=""text-success"">");
#nullable restore
#line 92 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                                                                Write(Html.DisplayFor(m => m.Service.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" €</h6>
                                        </td>
                                    </tr>
                                </table>
                            </div>

                            <div class=""col-5"">
                                <div class=""row"">
                                    <div class=""col-3"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f3d6cc0369ef7f6b4657543ac8ef7751c3c78b16349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 101 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Service.Miles);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                    <div class=\"col-9\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4f3d6cc0369ef7f6b4657543ac8ef7751c3c78b18001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 105 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Service.Miles);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-12 pt-3\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4f3d6cc0369ef7f6b4657543ac8ef7751c3c78b20110", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 109 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Service.Comments);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 118 "C:\Users\Oujdi\Desktop\Projet C#\Projet C#\ASP.NET Core\Asp.net-core with Ahmed Saleh\8-Cars-App\SparkAuto\Pages\Services\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SparkAuto.Pages.Services.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Services.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SparkAuto.Pages.Services.DetailsModel>)PageContext?.ViewData;
        public SparkAuto.Pages.Services.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
