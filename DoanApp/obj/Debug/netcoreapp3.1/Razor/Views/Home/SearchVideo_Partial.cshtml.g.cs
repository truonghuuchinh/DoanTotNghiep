#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12197b4ee886605fac1754624dccf62871c6d197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchVideo_Partial), @"mvc.1.0.view", @"/Views/Home/SearchVideo_Partial.cshtml")]
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
#line 1 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\_ViewImports.cshtml"
using DoanApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\_ViewImports.cshtml"
using DoanApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\_ViewImports.cshtml"
using DoanData.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\_ViewImports.cshtml"
using DoanApp.Commons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12197b4ee886605fac1754624dccf62871c6d197", @"/Views/Home/SearchVideo_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58cea3eb479b3127d4d5b6797c63a66d6b104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchVideo_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Video_vm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("size", new global::Microsoft.AspNetCore.Html.HtmlString("576"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
 if (Model.Count != 0 && Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"parent\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12197b4ee886605fac1754624dccf62871c6d1975913", async() => {
                WriteLiteral("\r\n                <div class=\"popular_left\">\r\n                    <video width=\"261\" height=\"165\"");
                BeginWriteAttribute("onmouseover", " onmouseover=\"", 380, "\"", 414, 3);
                WriteAttributeValue("", 394, "viewBefore(", 394, 11, true);
#nullable restore
#line 15 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 405, item.Id, 405, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 413, ")", 413, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("onmouseout", " onmouseout=\"", 415, "\"", 449, 3);
                WriteAttributeValue("", 428, "clearBefore(", 428, 12, true);
#nullable restore
#line 15 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 440, item.Id, 440, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 448, ")", 448, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 450, "\"", 489, 3);
                WriteAttributeValue(" ", 458, "nextSecond", 459, 11, true);
                WriteAttributeValue(" ", 469, "nextSecond-", 470, 12, true);
#nullable restore
#line 15 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 481, item.Id, 481, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                           data-poster=\"");
#nullable restore
#line 16 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                                   Write(item.PosterImg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"player\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12197b4ee886605fac1754624dccf62871c6d1978182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 600, "~/Client/video/", 600, 15, true);
#nullable restore
#line 17 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
AddHtmlAttributeValue("", 615, item.LinkVideo, 615, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </video>\r\n                    <span class=\"time__duration time__duration2\"></span>\r\n                </div>\r\n                <div class=\"popular_right\">\r\n                    <div class=\"header__popular\">\r\n                        ");
#nullable restore
#line 23 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"all_papge\">\r\n                        <div class=\"ten_kenh\">");
#nullable restore
#line 27 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                                         Write(item.FirtsName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 27 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                                                         Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .</div>\r\n                        <div class=\"luot_xem\">\r\n                            ");
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                       Write(ConvertViewCount.ConvertView(item.ViewCount));

#line default
#line hidden
#nullable disable
                WriteLiteral(" lượt xem\r\n                        </div>\r\n                        <div class=\"dau_cham_cach\">.</div>\r\n                        <div class=\"thoi_gian_cong_chieu\">");
#nullable restore
#line 32 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                                                     Write(CaculatorHours.Caculator(item.CreateDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"mota_noidung_video\">");
#nullable restore
#line 34 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
                                                                 WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            <img");
            BeginWriteAttribute("id", " id=\"", 1579, "\"", 1604, 2);
            WriteAttributeValue("", 1584, "addplaylist-", 1584, 12, true);
#nullable restore
#line 37 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 1596, item.Id, 1596, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1605, "\"", 1636, 3);
            WriteAttributeValue("", 1615, "addPlayList(", 1615, 12, true);
#nullable restore
#line 37 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 1627, item.Id, 1627, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1635, ")", 1635, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon-more hover add_playlist\" src=\"/Client/img/more.png\" alt=\"Alternate Text\" />\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1743, "\"", 1784, 3);
            WriteAttributeValue("", 1751, "playlist_option", 1751, 15, true);
            WriteAttributeValue(" ", 1766, "playlist-", 1767, 10, true);
#nullable restore
#line 38 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 1776, item.Id, 1776, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1808, "\"", 1860, 4);
            WriteAttributeValue("", 1816, "option_playlist", 1816, 15, true);
            WriteAttributeValue(" ", 1831, "hover", 1832, 6, true);
            WriteAttributeValue(" ", 1837, "into_playlist-", 1838, 15, true);
#nullable restore
#line 39 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 1852, item.Id, 1852, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1861, "\"", 1893, 3);
            WriteAttributeValue("", 1871, "showPlayList(", 1871, 13, true);
#nullable restore
#line 39 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 1884, item.Id, 1884, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1892, ")", 1892, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fa fa-list-alt\"></i> Thêm vào danh sách phát\r\n                </div>\r\n                <div class=\"option_playlist hover report_video\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2063, "\"", 2094, 3);
            WriteAttributeValue("", 2073, "reportVideo(", 2073, 12, true);
#nullable restore
#line 42 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
WriteAttributeValue("", 2085, item.Id, 2085, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2093, ")", 2093, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fa fa-flag\"></i> Báo cáo vi phạm\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 47 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo_Partial.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
