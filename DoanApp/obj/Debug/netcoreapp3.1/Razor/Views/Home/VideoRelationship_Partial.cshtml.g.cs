#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb00ee83d1d107dad6fa371a735ff94137542c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VideoRelationship_Partial), @"mvc.1.0.view", @"/Views/Home/VideoRelationship_Partial.cshtml")]
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb00ee83d1d107dad6fa371a735ff94137542c3", @"/Views/Home/VideoRelationship_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58cea3eb479b3127d4d5b6797c63a66d6b104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VideoRelationship_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Video_vm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("261"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("95"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("YouTube video player"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("content_right--item--a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
 if (Model.Count > 0 && Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"content_right--item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb00ee83d1d107dad6fa371a735ff94137542c36355", async() => {
                WriteLiteral("\r\n                <div class=\"content_right_all\">\r\n                    <div class=\"content_right_all_left\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("video", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb00ee83d1d107dad6fa371a735ff94137542c36749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 500, "~/Client/video/", 500, 15, true);
#nullable restore
#line 14 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
AddHtmlAttributeValue("", 515, item.LinkVideo, 515, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onmouseover", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 574, "viewBefore(", 574, 11, true);
#nullable restore
#line 14 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
AddHtmlAttributeValue("", 585, item.Id, 585, 8, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 593, ")", 593, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onmouseout", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 608, "clearBefore(", 608, 12, true);
#nullable restore
#line 14 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
AddHtmlAttributeValue("", 620, item.Id, 620, 8, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 628, ")", 628, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue(" ", 638, "nextSecond", 639, 11, true);
                AddHtmlAttributeValue(" ", 649, "nextSecond-", 650, 12, true);
#nullable restore
#line 14 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
AddHtmlAttributeValue("", 661, item.Id, 661, 8, false);

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
                WriteLiteral(@"
                        <span style=""margin-top:67px !important;"" class=""time__duration time__duration2""></span>
                    </div>
                    <div class=""content_right_all_right"">
                        <div class=""content_right_text_video"">
                            <p class=""titleName"" style=""font-weight:700"">");
#nullable restore
#line 19 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"content_right_texts_video\">");
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
                                                          Write(item.FirtsName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
                                                                          Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"content_right_textss_video\">");
#nullable restore
#line 22 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
                                                           Write(item.ViewCount.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" lượt xem • ");
#nullable restore
#line 22 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
                                                                                                        Write(item.CreateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 256, "movepage_detail-", 256, 16, true);
#nullable restore
#line 11 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
AddHtmlAttributeValue("", 272, item.Id, 272, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
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
            BeginWriteAttribute("id", " id=\"", 1389, "\"", 1414, 2);
            WriteAttributeValue("", 1394, "addplaylist-", 1394, 12, true);
#nullable restore
#line 27 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
WriteAttributeValue("", 1406, item.Id, 1406, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1415, "\"", 1446, 3);
            WriteAttributeValue("", 1425, "addPlayList(", 1425, 12, true);
#nullable restore
#line 27 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
WriteAttributeValue("", 1437, item.Id, 1437, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1445, ")", 1445, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"icon-more add_playlist hover\" src=\"/Client/img/more.png\" alt=\"Alternate Text\" />\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1553, "\"", 1594, 3);
            WriteAttributeValue("", 1561, "playlist_option", 1561, 15, true);
            WriteAttributeValue(" ", 1576, "playlist-", 1577, 10, true);
#nullable restore
#line 28 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
WriteAttributeValue("", 1586, item.Id, 1586, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1618, "\"", 1670, 4);
            WriteAttributeValue("", 1626, "option_playlist", 1626, 15, true);
            WriteAttributeValue(" ", 1641, "hover", 1642, 6, true);
            WriteAttributeValue(" ", 1647, "into_playlist-", 1648, 15, true);
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
WriteAttributeValue("", 1662, item.Id, 1662, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1671, "\"", 1703, 3);
            WriteAttributeValue("", 1681, "showPlayList(", 1681, 13, true);
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
WriteAttributeValue("", 1694, item.Id, 1694, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1702, ")", 1702, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fa fa-list-alt\"></i> Thêm vào danh sách phát\r\n                </div>\r\n                <div class=\"option_playlist hover report_video\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1873, "\"", 1904, 3);
            WriteAttributeValue("", 1883, "reportVideo(", 1883, 12, true);
#nullable restore
#line 32 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
WriteAttributeValue("", 1895, item.Id, 1895, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1903, ")", 1903, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fa fa-flag\"></i> Báo cáo vi phạm\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\VideoRelationship_Partial.cshtml"
     
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
