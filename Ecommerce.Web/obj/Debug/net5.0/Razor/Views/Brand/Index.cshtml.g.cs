#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0154db6d2277d321671edad65925856e6457be61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0154db6d2277d321671edad65925856e6457be61", @"/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Entities.Branding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
  
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
                    <h2></h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 454, "\"", 497, 1);
#nullable restore
#line 14 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
WriteAttributeValue("", 461, Url.Action("Dashboard","Dashboard"), 461, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-home""></i>Dashboard</a></li>
                        <li class=""breadcrumb-item"">Brand</li>
                        <li class=""breadcrumb-item active"">List of Brand</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""box-header"">
            <a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 865, 1);
#nullable restore
#line 22 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
WriteAttributeValue("", 834, Url.Action("AddBrand","Brand"), 834, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""fa fa-edit btn btn-info"">Add New Brand</a>
            <h3 class=""box-title"" style=""margin-left:300px"">All Brand List Show</h3>
        </div>
        <div class=""container-fluid"">
            <div class=""row clearfix"">
                <div class=""col-lg-12"">
                    <div class=""card"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover product_item_list c_table theme-color mb-0"">
                                <thead>
                                    <tr>
                                        <th>Image</th>
                                        <th>Brand Name</th>
                                        <th data-breakpoints=""sm xs"">Details</th>
                                        <th data-breakpoints=""sm xs md"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 40 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
                                     foreach (var item in Model)
                                    {
                                        var picURL = item.BrandingPictures != null && item.BrandingPictures.Count > 0 ?
                                                 "/Images/" +
                                                     item.BrandingPictures.FirstOrDefault().Picture.PictureURL :
                                                            "/Images/default.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td><img");
            BeginWriteAttribute("src", " src=\"", 2421, "\"", 2434, 1);
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
WriteAttributeValue("", 2427, picURL, 2427, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" alt=\"Product img\"></td>\r\n                                            <td><h5>");
#nullable restore
#line 48 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
                                               Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\r\n                                            <td><span class=\"text-muted\">");
#nullable restore
#line 49 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
                                                                    Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td class=\"btn-group\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2783, "\"", 2840, 1);
#nullable restore
#line 51 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
WriteAttributeValue("", 2790, Url.Action("EditBrand","Brand",new { ID=item.ID}), 2790, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\"><i class=\"zmdi zmdi-edit\"></i>Edit</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2953, "\"", 3013, 2);
#nullable restore
#line 52 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
WriteAttributeValue("", 2960, Url.Action("DeleteBrand","Brand",new { ID=item.ID}), 2960, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3012, ";", 3012, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger \"><i class=\"zmdi zmdi-delete\"></i>Delete</a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 55 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Brand\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Entities.Branding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
