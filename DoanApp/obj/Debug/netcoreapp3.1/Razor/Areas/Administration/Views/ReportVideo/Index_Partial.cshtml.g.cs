#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2717c4680652e29d43543b1b421a50ca62f8bccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_ReportVideo_Index_Partial), @"mvc.1.0.view", @"/Areas/Administration/Views/ReportVideo/Index_Partial.cshtml")]
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2717c4680652e29d43543b1b421a50ca62f8bccf", @"/Areas/Administration/Views/ReportVideo/Index_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf60c0025946dce12a04616957a471e29b5a4b8", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_ReportVideo_Index_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<ReportVideo_Vm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
  
    int count = 0;
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 143, "\"", 179, 3);
            WriteAttributeValue("", 153, "showDetailReport(", 153, 17, true);
#nullable restore
#line 9 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
WriteAttributeValue("", 170, item.Id, 170, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 178, ")", 178, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 180, "\"", 223, 4);
            WriteAttributeValue("", 188, "tr-shadow", 188, 9, true);
            WriteAttributeValue(" ", 197, "hover", 198, 6, true);
            WriteAttributeValue(" ", 203, "removeItem-", 204, 12, true);
#nullable restore
#line 9 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
WriteAttributeValue("", 215, item.Id, 215, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Click vào để xem chi tiết\">\r\n        <td style=\"width:280px;\"><div class=\"content__report\">");
#nullable restore
#line 10 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
                                                         Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n        <td style=\" width:300px;\" class=\"center\">\r\n            <img class=\"imgPoster\"");
            BeginWriteAttribute("src", " src=\"", 437, "\"", 476, 2);
            WriteAttributeValue("", 443, "/Client/imgPoster/", 443, 18, true);
#nullable restore
#line 12 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
WriteAttributeValue("", 461, item.ImgPoster, 461, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n            <div class=\"nameVideoReport\">");
#nullable restore
#line 13 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
                                    Write(item.NameVideo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </td>\r\n        <td class=\"center\">\r\n            ");
#nullable restore
#line 16 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
       Write(item.NamUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            <div class=\"table-data-feature\">\r\n                <button class=\"item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Phản hồi\"");
            BeginWriteAttribute("onclick", " onclick=\"", 813, "\"", 870, 5);
            WriteAttributeValue("", 823, "replyFunction(event,", 823, 20, true);
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
WriteAttributeValue("", 843, item.UserId, 843, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 855, ",", 855, 1, true);
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
WriteAttributeValue("", 856, item.VideoId, 856, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 869, ")", 869, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"zmdi zmdi-mail-reply\"></i>\r\n                </button>\r\n                <button class=\"item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Xóa\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1051, "\"", 1091, 3);
            WriteAttributeValue("", 1061, "deleteFunction(event,", 1061, 21, true);
#nullable restore
#line 24 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
WriteAttributeValue("", 1082, item.Id, 1082, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1090, ")", 1090, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"zmdi zmdi-delete\"></i>\r\n                </button>\r\n            </div>\r\n        </td>\r\n    </tr>\r\n    <tr class=\"spacer\"></tr>\r\n");
#nullable restore
#line 31 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Index_Partial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<ReportVideo_Vm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
