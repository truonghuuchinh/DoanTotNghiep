#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7548236ece9e08d4b43239150e79dde5eee1e3db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Video_Index), @"mvc.1.0.view", @"/Areas/Administration/Views/Video/Index.cshtml")]
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7548236ece9e08d4b43239150e79dde5eee1e3db", @"/Areas/Administration/Views/Video/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf60c0025946dce12a04616957a471e29b5a4b8", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Video_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Video_vm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
   
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"box\">\r\n        <div class=\"box-header displayFlex\">\r\n            <div>Danh sách Video <a");
            BeginWriteAttribute("id", " id=\"", 202, "\"", 225, 1);
#nullable restore
#line 9 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 207, ViewBag.LinkVideo, 207, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"clickVideo\"");
            BeginWriteAttribute("href", " href=\"", 246, "\"", 282, 2);
            WriteAttributeValue("", 253, "#linkVideo-", 253, 11, true);
#nullable restore
#line 9 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 264, ViewBag.LinkVideo, 264, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></a></div>

        </div>
        <div class=""box-body overflow-scroll"">
            <div class=""table-responsive table-responsive-data2"">
                <table class=""table table-data2"">
                    <thead>
                        <tr>
                            <th>Video</th>
                            <th>Ngày đăng</th>
                            <th>Số lượt xem</th>
                            <th>Bình luận</th>
                            <th>Lượt thích</th>
                            <th>Kênh đăng tải</th>
                            <th>Tùy chỉnh</th>
                        </tr>
                    </thead>
                    <tbody id=""tbodyVideo"">
");
#nullable restore
#line 27 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                         foreach(var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("id", " id=\"", 1105, "\"", 1128, 2);
            WriteAttributeValue("", 1110, "linkVideo-", 1110, 10, true);
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 1120, item.Id, 1120, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1129, "\"", 1166, 3);
            WriteAttributeValue("", 1137, "tr-shadow", 1137, 9, true);
            WriteAttributeValue(" ", 1146, "removeItem-", 1147, 12, true);
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 1158, item.Id, 1158, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td class=\"col-3\">\r\n                                    <video class=\"secondVideo\"  controls=\"controls\">\r\n                                        <source");
            BeginWriteAttribute("src", " src=\"", 1355, "\"", 1390, 2);
            WriteAttributeValue("", 1361, "/Client/video/", 1361, 14, true);
#nullable restore
#line 32 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 1375, item.LinkVideo, 1375, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"video/mp4\" />\r\n                                    </video>\r\n                                    <div style=\"width:200px;\">");
#nullable restore
#line 34 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </td>\r\n                                <td>\r\n                                    <span class=\"block-email\">");
#nullable restore
#line 37 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                                                         Write(item.CreateDate.Split(' ')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td class=\"desc\">");
#nullable restore
#line 39 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                                            Write(ConvertViewCount.ConvertView(item.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" lượt xem</td>\r\n                                <td>");
#nullable restore
#line 40 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                               Write(ViewBag.ListCountComment[count].Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span class=\"status--process\">");
#nullable restore
#line 42 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                                                             Write(item.Like);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lượt thích</span>\r\n                                </td>\r\n                                <td class=\"imgAvartar\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2220, "\"", 2292, 1);
#nullable restore
#line 45 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 2226, item.LoginExternal?item.Avartar:"/Client/avartar/"+item.Avartar, 2226, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n                                    <div>");
#nullable restore
#line 46 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                                    Write(item.FirtsName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                                                    Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </td>\r\n                                <td>\r\n                                    <div class=\"table-data-feature\">\r\n\r\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2594, "\"", 2634, 3);
            WriteAttributeValue("", 2604, "revertStatusFunction(", 2604, 21, true);
#nullable restore
#line 51 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 2625, item.Id, 2625, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2633, ")", 2633, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2635, "\"", 2661, 3);
            WriteAttributeValue("", 2643, "item", 2643, 4, true);
            WriteAttributeValue(" ", 2647, "item-", 2648, 6, true);
#nullable restore
#line 51 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 2653, item.Id, 2653, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Ẩn\">\r\n                                            <i");
            BeginWriteAttribute("class", " class=\"", 2766, "\"", 2839, 4);
            WriteAttributeValue("", 2774, "zmdi", 2774, 4, true);
#nullable restore
#line 52 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue(" ", 2778, item.HidenVideo?"zmdi-eye":"zmdi-eye-off", 2779, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2823, "update-", 2824, 8, true);
#nullable restore
#line 52 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 2831, item.Id, 2831, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        </button>\r\n                                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2945, "\"", 2979, 3);
            WriteAttributeValue("", 2955, "deleteFunction(", 2955, 15, true);
#nullable restore
#line 54 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
WriteAttributeValue("", 2970, item.Id, 2970, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2978, ")", 2978, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Xóa"">
                                            <i class=""zmdi zmdi-delete""></i>
                                        </button>

                                    </div>
                                </td>
                            </tr>
                            <tr class=""spacer""></tr>
");
#nullable restore
#line 62 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\Index.cshtml"
                            count++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
     
        $(document).ready(function () {
            loadVideoReport();
        });
     
        searchAll(""/Administration/Video/Index_Partial"");
        PaginationPage(""/Administration/Video/Index_Partial"", ""#tbodyVideo"")
     
        function deleteFunction(id) {
            var isDelete = confirm(""Bạn có chắc muốn xóa video này"");
            if (isDelete) {
                $.post(""/Administration/Video/Delete"", {id:id}, function (respone) {
                    if (respone == ""Success"") {
                        $("".removeItem-"" + id).remove();
                        alertSuccess(""Đã xóa"");
                    }
                });
            }
        }
        function revertStatusFunction(id) {
            var isDelete = confirm(`Bạn có chắc muốn ${$("".item-"" + id).prop(""title"")} video này`);
            if (isDelete) {
                $.post(""/Administration/Video/UpdateStatus"", { id: id }, function (respone) {
                    if (respone == """);
                WriteLiteral(@"Success"") {

                        if ($("".item-"" + id).prop(""title"") == ""Ẩn"")
                            $("".item-"" + id).prop(""title"", ""Hiện"");
                        else $("".item-"" + id).prop(""title"", ""Ẩn"");
                        console.log(""Text javascript: "" + document.querySelector("".item-"" + id).getAttribute(""title""));
                        if ($("".update-"" + id).hasClass(""zmdi-eye"")) {
                            $("".update-"" + id).removeClass(""zmdi-eye"");
                            $("".update-"" + id).addClass(""zmdi-eye-off"");
                        } else {
                            $("".update-"" + id).addClass(""zmdi-eye"");
                            $("".update-"" + id).removeClass(""zmdi-eye-off"");
                        }
                        alertSuccess(""Đã cập nhật"");
                    }
                });
            }
        }
       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Video_vm>> Html { get; private set; }
    }
}
#pragma warning restore 1591