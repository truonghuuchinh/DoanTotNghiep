#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe67821b2253ac09d09331cad39110bbcc74197b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Role_Index), @"mvc.1.0.view", @"/Areas/Administration/Views/Role/Index.cshtml")]
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
#line 1 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanData.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanApp.Areas.Administration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanApp.Commons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe67821b2253ac09d09331cad39110bbcc74197b", @"/Areas/Administration/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf60c0025946dce12a04616957a471e29b5a4b8", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<DoanData.Models.AppRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
  
    int count = 0;
    int totalUser = ViewBag.ListUser.Count;
    string[] role = new string[] {"Admin","Manager","User" };
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">

    <div class=""box"">
        <div class=""box-header displayFlex"">
            <div>Danh sách vai trò</div>
            <div class=""btn btn-primary displayFlex "" id=""showCreate""> <i style=""margin-right:7px;"" class=""zmdi zmdi-plus-circle""></i>   Thêm</div>
        </div>
        <div class=""box-body overflow-scroll"">
            <table>
                <thead>
                    <tr>

                        <th>
                            Tên
                        </th>
                        <th>
                            Quyền
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 36 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 1067, "\"", 1100, 3);
            WriteAttributeValue("", 1075, "tr-shadow", 1075, 9, true);
            WriteAttributeValue(" ", 1084, "remove-", 1085, 8, true);
#nullable restore
#line 38 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
WriteAttributeValue("", 1092, item.Id, 1092, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <td>\r\n                                <textarea class=\"tr-shadow__textarea\" readonly> ");
#nullable restore
#line 41 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                                                            Write(count<totalUser? ViewBag.ListUser[count]:"không có User");

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 44 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                 if (item.Name.Contains("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"role admin\">");
#nullable restore
#line 46 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                 if (item.Name.Contains("User"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"role user\">");
#nullable restore
#line 50 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 51 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                 if (item.Name.Contains("Manager"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"role member\">");
#nullable restore
#line 54 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                 if (!role.Contains(item.Name))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"role \" style=\"background: #a7a7a7; width: 35%; text-align: center; \">");
#nullable restore
#line 58 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 62 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                 if (User.IsInRole("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"table-data-feature\">\r\n\r\n                                        <button class=\"item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2639, "\"", 2671, 3);
            WriteAttributeValue("", 2649, "editFunction(", 2649, 13, true);
#nullable restore
#line 66 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
WriteAttributeValue("", 2662, item.Id, 2662, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2670, ")", 2670, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"zmdi zmdi-edit\"></i>\r\n                                        </button>\r\n                                        <button class=\"item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2920, "\"", 2954, 3);
            WriteAttributeValue("", 2930, "deleteFunction(", 2930, 15, true);
#nullable restore
#line 69 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
WriteAttributeValue("", 2945, item.Id, 2945, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2953, ")", 2953, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"zmdi zmdi-delete\"></i>\r\n                                        </button>\r\n                                    </div>\r\n");
#nullable restore
#line 73 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n                        <tr class=\"spacer\"></tr>\r\n");
#nullable restore
#line 77 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Role\Index.cshtml"
                        count++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#showCreate"").click(function () {

            OpenPopUp2(""Thêm Quyền"", ""/Administration/Role/Create"");
            $(""#Name"").val('');
            $(""#errorName"").text('');
            setTimeout(() => { $(""#Name"").focus(); }, 500);
        });
        function editFunction(id) {
            OpenPopUp2(""Cập nhật Quyền"", ""/Administration/Role/Update/?Id="" + id);
           
        }
        function deleteFunction(id) {
            var isDelete = confirm(""Bạn có chắc muốn xóa phần tử này"");
            if (isDelete) {
                $.get(""/Administration/Role/Delete/?id="" + id, function (result) {
                    if (result == ""Success"") {
                        $("".remove-"" + id).remove();
                        alertSuccess(""Đã xóa"");
                    }
                });


            }
        }

        searchAll(""/Administration/Role/Index_Partial/"");
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<DoanData.Models.AppRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
