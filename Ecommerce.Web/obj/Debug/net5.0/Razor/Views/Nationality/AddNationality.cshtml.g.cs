#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Nationality\AddNationality.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66fba1722570738d6c85b752429d709f2e484dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nationality_AddNationality), @"mvc.1.0.view", @"/Views/Nationality/AddNationality.cshtml")]
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
#line 1 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\_ViewImports.cshtml"
using Ecommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\_ViewImports.cshtml"
using Ecommerce.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fba1722570738d6c85b752429d709f2e484dc2", @"/Views/Nationality/AddNationality.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Nationality_AddNationality : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Entities.Nationility>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddNationalityForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Nationality\AddNationality.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""body_scroll"">
        <div class=""block-header"">
            <div class=""row"">
                <div class=""col-lg-7 col-md-6 col-sm-12"">
                    <h2>Form Validation</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html""><i class=""zmdi zmdi-home""></i> Aero</a></li>
                        <li class=""breadcrumb-item""><a href=""javascript:void(0);"">Forms</a></li>
                        <li class=""breadcrumb-item active"">Form Validation</li>
                    </ul>
                    <button class=""btn btn-primary btn-icon mobile_menu"" type=""button""><i class=""zmdi zmdi-sort-amount-desc""></i></button>
                </div>
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <button class=""btn btn-primary btn-icon float-right right_icon_toggle_btn"" type=""button""><i class=""zmdi zmdi-arrow-right""></i></button>
                </div>
            </div>");
            WriteLiteral(@"
        </div>

        <div class=""container-fluid"">
            <!-- Basic Validation -->
            <div class=""row clearfix"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""card"">
                        <div class=""body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66fba1722570738d6c85b752429d709f2e484dc25598", async() => {
                WriteLiteral(@"
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""Nationality Name"" name=""NationalityName"" required>
                                </div>

                                <div class=""form-group"">
                                    <div class=""checkbox"">
                                        <input id=""checkbox"" type=""checkbox"">
                                        <label for=""checkbox"">I have read and accept the terms</label>
                                    </div>
                                </div>
                                <button id=""NationalityAddBtn"" class=""btn btn-raised btn-primary waves-effect"" type=""button"">SUBMIT</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Nationality\AddNationality.cshtml"
AddHtmlAttributeValue("", 1515, Url.Action("AddNationality","Nationality"), 1515, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<div id=\"imageTemplate\" style=\"display:none\">\r\n    <img class=\'image img-thumbnail\'");
            BeginWriteAttribute("src", " src=\'", 2605, "\'", 2611, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""height:100px; width:100px"" />
</div>
<script>
    $('#NationalityAddBtn').click(function () {
        debugger;
        var imageIDs = [];
        $(""#picturesArea .image"").each(function () {
            var imageID = $(this).attr(""data-id"");
            imageIDs.push(imageID);
        });
        $(""#PictureIDs"").val(imageIDs.join())
         $.ajax({
         url: """);
#nullable restore
#line 65 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Nationality\AddNationality.cshtml"
          Write(Url.Action("AddNationality", "Nationality"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n         type: \"post\",\r\n             data: $(\"#AddNationalityForm\").serialize()\r\n     }).done(function (responses) {\r\n         debugger;\r\n         alert(\"Nationality Save Succesfully\");\r\n         window.location.href = \"");
#nullable restore
#line 71 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Nationality\AddNationality.cshtml"
                            Write(Url.Action("Index", "Nationality"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n     }).fail(function () {\r\n\r\n     });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Entities.Nationility> Html { get; private set; }
    }
}
#pragma warning restore 1591
