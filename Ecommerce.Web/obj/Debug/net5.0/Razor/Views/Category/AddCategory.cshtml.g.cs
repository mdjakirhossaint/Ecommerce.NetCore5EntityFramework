#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528d756d7bcba4c6b5030aed8f98e1556ad6878a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_AddCategory), @"mvc.1.0.view", @"/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528d756d7bcba4c6b5030aed8f98e1556ad6878a", @"/Views/Category/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddCategoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px; width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "528d756d7bcba4c6b5030aed8f98e1556ad6878a6713", async() => {
                WriteLiteral(@"
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""Category Name"" name=""CategoryName"" required>
                                </div>
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""Category Description"" name=""CategoryDescription"">
                                </div>

                                <div class=""form-group"">
                                    <label>Select Image</label>
                                    <input class=""form-control"" name=""CategoryPictures"" id=""categoryPictures"" type=""file""  />
                                    <div id=""picturesArea"" class=""form-group""></div>
                                    <input type=""hidden"" name=""CategoryPictures"" id=""PictureIDs"" />
                                </div>

                                <div class=""form");
                WriteLiteral(@"-group"">
                                    <div class=""radio inlineblock"">
                                        <input type=""radio"" name=""Status"" id=""Female"" class=""with-gap"" value=""True"">
                                        <label for=""Female"">Status</label>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""checkbox"">
                                        <input id=""checkbox"" type=""checkbox"">
                                        <label for=""checkbox"">I have read and accept the terms</label>
                                    </div>
                                </div>
                                <button id=""CategoryAddBtn"" class=""btn btn-raised btn-primary waves-effect"" type=""button"">SUBMIT</button>
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
#line 32 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
AddHtmlAttributeValue("", 1475, Url.Action("AddCategory","Category"), 1475, 37, false);

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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<div id=\"imageTemplate\" style=\"display:none\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "528d756d7bcba4c6b5030aed8f98e1556ad6878a10964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 69 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    $('#CategoryAddBtn').click(function () {
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
#line 81 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
          Write(Url.Action("AddCategory","Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n         type: \"post\",\r\n             data: $(\"#AddCategoryForm\").serialize()\r\n     }).done(function (responses) {\r\n         debugger;\r\n         alert(\"Category Save Succesfully\");\r\n         window.location.href = \"");
#nullable restore
#line 87 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
                            Write(Url.Action("Index", "Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
     }).fail(function () {

     });
    });

    $(""#categoryPictures"").change(function () {
          debugger;
          var pictures = this.files;
          var picsData = new FormData();
        for (var i = 0; i < pictures.length; i++) {
            picsData.append(""Picture"", pictures[i]);
        }
        $.ajax({
            url: """);
#nullable restore
#line 101 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
             Write(Url.Action("UploadPictures","Shared"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: ""post"",
            data: picsData,
            datatype: ""json"",
            processData: false,
            contentType: false
        }).done(function (responses) {
            debugger;
            for (var i = 0; i < responses.length; i++) {
                var picResponse = responses[i];

                AttachNewImage(picResponse.pictureUrl, picResponse.id);
            }
        }).fail(function () { });
    });

    function AttachNewImage(imageURL, imageID) {
        debugger;

        var $newImageHTML = $(""#imageTemplate"").clone();

        $newImageHTML.find("".image"").attr(""src"", """);
#nullable restore
#line 122 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Category\AddCategory.cshtml"
                                             Write(Url.Content("~/Images/"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + imageURL);

        $newImageHTML.find("".image"").attr(""data-id"", imageID);

        $(""#picturesArea"").append($newImageHTML.html());

        RemoveImageOnClick();

    }

    function RemoveImageOnClick() {
        $(""#picturesArea .image"").click(function () {

            debugger;
            $(this).remove();

        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
