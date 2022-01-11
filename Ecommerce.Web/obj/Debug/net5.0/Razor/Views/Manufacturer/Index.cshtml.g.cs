#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "956f35ab761c39e6a33f0047b930023799baa41a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturer_Index), @"mvc.1.0.view", @"/Views/Manufacturer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956f35ab761c39e6a33f0047b930023799baa41a", @"/Views/Manufacturer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Entities.Manufacturer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
  
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
            BeginWriteAttribute("href", " href=\"", 458, "\"", 501, 1);
#nullable restore
#line 14 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
WriteAttributeValue("", 465, Url.Action("Dashboard","Dashboard"), 465, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-home""></i>Category  </a></li>
                        <li class=""breadcrumb-item"">Category</li>
                        <li class=""breadcrumb-item active"">List of Product Brand</li>
                    </ul>
                    <button class=""btn btn-primary btn-icon mobile_menu"" type=""button""><i class=""zmdi zmdi-sort-amount-desc""></i></button>
                </div>
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <button class=""btn btn-primary btn-icon float-right right_icon_toggle_btn"" type=""button""><i class=""zmdi zmdi-arrow-right""></i></button>
                </div>
            </div>
        </div>
        <div class=""container-fluid"">
            <a");
            BeginWriteAttribute("href", " href=\"", 1228, "\"", 1281, 1);
#nullable restore
#line 26 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
WriteAttributeValue("", 1235, Url.Action("AddManufacturers","Manufacturer"), 1235, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class="" btn btn-info"">Add Manufacture</a>
            <div class=""row clearfix"">
                <div class=""col-lg-12"">
                    <div class=""card"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover product_item_list c_table theme-color mb-0"">
                                <thead>
                                    <tr>
                                        <th>Image</th>
                                        <th>Product Name</th>
                                        <th data-breakpoints=""sm xs"">Detail</th>

                                        <th data-breakpoints=""xs md"">Stock</th>
                                        <th data-breakpoints=""sm xs md"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 43 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n\r\n                                            <td><h5>");
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
                                               Write(item.ManufacturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\r\n                                            <td><span class=\"text-muted\">");
#nullable restore
#line 48 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n                                            <td><span class=\"col-green\">In Stock</span></td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2726, "\"", 2797, 1);
#nullable restore
#line 52 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
WriteAttributeValue("", 2733, Url.Action("EditManufacturer","Manufacturer",new { ID=item.ID}), 2733, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default waves-effect waves-float btn-sm waves-green\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2953, "\"", 3027, 2);
#nullable restore
#line 53 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
WriteAttributeValue("", 2960, Url.Action("DeleteManufacturer","Manufacturer",new { ID=item.ID}), 2960, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3026, ";", 3026, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default waves-effect waves-float btn-sm waves-red\"><i class=\"zmdi zmdi-delete\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 56 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Manufacturer\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""body"">
                            <ul class=""pagination pagination-primary m-b-0"">
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""><i class=""zmdi zmdi-arrow-left""></i></a></li>
                                <li class=""page-item active""><a class=""page-link"" href=""javascript:void(0);"">1</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"">3</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"">4</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""><i cla");
            WriteLiteral("ss=\"zmdi zmdi-arrow-right\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Entities.Manufacturer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
