#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c31bd170a5039607276253feaa849ae0fb7b74e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserType_Index), @"mvc.1.0.view", @"/Views/UserType/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c31bd170a5039607276253feaa849ae0fb7b74e1", @"/Views/UserType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
  
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
                    <h2>Product List</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html""><i class=""zmdi zmdi-home""></i> Aero</a></li>
                        <li class=""breadcrumb-item"">eCommerce</li>
                        <li class=""breadcrumb-item active"">Product List</li>
                    </ul>
                    <button class=""btn btn-primary btn-icon mobile_menu"" type=""button""><i class=""zmdi zmdi-sort-amount-desc""></i></button>
                </div>
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <button class=""btn btn-primary btn-icon float-right right_icon_toggle_btn"" type=""button""><i class=""zmdi zmdi-arrow-right""></i></button>
                </div>
            </div>
        </div>
        <div class");
            WriteLiteral("=\"container-fluid\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1150, "\"", 1194, 1);
#nullable restore
#line 26 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
WriteAttributeValue("", 1157, Url.Action("AddUserType","UserType"), 1157, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class="" btn btn-info"">Add User Role</a>
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
                                        <th data-breakpoints=""xs"">Amount</th>
                                        <th data-breakpoints=""xs md"">Stock</th>
                                        <th data-breakpoints=""sm xs md"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 43 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
                                     foreach (var item in ViewBag.userList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td><img src=\"assets/images/ecommerce/1.png\" width=\"48\" alt=\"Product img\"></td>\r\n                                            <td><h5>");
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
                                               Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5></td>
                                            <td><span class=""text-muted"">randomised words even slightly believable</span></td>
                                            <td>$16.00</td>
                                            <td><span class=""col-green"">In Stock</span></td>
                                            <td>
                                                <a");
            BeginWriteAttribute("href", " href=\"", 2923, "\"", 2984, 1);
#nullable restore
#line 52 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
WriteAttributeValue("", 2930, Url.Action("EditProduct","Product",new { ID=item.ID}), 2930, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default waves-effect waves-float btn-sm waves-green\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3140, "\"", 3197, 2);
#nullable restore
#line 53 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
WriteAttributeValue("", 3147, Url.Action("Delete","Product",new { ID=item.ID}), 3147, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3196, ";", 3196, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default waves-effect waves-float btn-sm waves-red\"><i class=\"zmdi zmdi-delete\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 56 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserType\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
