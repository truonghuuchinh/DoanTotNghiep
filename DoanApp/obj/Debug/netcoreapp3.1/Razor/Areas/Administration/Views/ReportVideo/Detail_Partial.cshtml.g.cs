#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6397f73f3a2ee6fc9a68604be1bdc2c9ac807a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_ReportVideo_Detail_Partial), @"mvc.1.0.view", @"/Areas/Administration/Views/ReportVideo/Detail_Partial.cshtml")]
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6397f73f3a2ee6fc9a68604be1bdc2c9ac807a4", @"/Areas/Administration/Views/ReportVideo/Detail_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf60c0025946dce12a04616957a471e29b5a4b8", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_ReportVideo_Detail_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReportVideo_Vm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #mediumModal .modal-dialog .modal-content {
        
        margin-left: 35px;
    }
    #tableDetail {
        width: 60% ;
        min-width: 770px;
    }
    .modal-header{
        background:#dddd;

    }
</style>
<table id=""tableDetail"">
    <thead>
        <tr>
            <th>
                Nội dung báo cáo
            </th>
            <th>Ngày báo cáo</th>
            <th class=""center"">
                Video báo cáo
            </th>
            <th class=""center"">Người báo cáo</th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""tbodyReport"">

");
#nullable restore
#line 36 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"tr-shadow\" title=\"Click vào Poster để xem\">\r\n                <td style=\"width:280px; padding:10px;\"><div>");
#nullable restore
#line 39 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
                                                       Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></td>\r\n                <td>");
#nullable restore
#line 40 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
               Write(item.CreateDate.Split(' ')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\" width:300px;\" class=\"center hover\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6397f73f3a2ee6fc9a68604be1bdc2c9ac807a46816", async() => {
                WriteLiteral("<img class=\"imgPoster\"");
                BeginWriteAttribute("src", " src=\"", 1153, "\"", 1192, 2);
                WriteAttributeValue("", 1159, "/Client/imgPoster/", 1159, 18, true);
#nullable restore
#line 42 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
WriteAttributeValue("", 1177, item.ImgPoster, 1177, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
                                                                   WriteLiteral(item.VideoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div style=\"margin-top:15px;\">");
#nullable restore
#line 43 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
                                             Write(item.NameVideo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </td>\r\n                <td class=\"center\">\r\n                    <div>");
#nullable restore
#line 46 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
                    Write(item.NamUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </td>\r\n\r\n            </tr>\r\n            <tr class=\"spacer\"></tr>\r\n");
#nullable restore
#line 51 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\ReportVideo\Detail_Partial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReportVideo_Vm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
