#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43da3001cbf0023474851afeda02c47e4394f7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchVideo), @"mvc.1.0.view", @"/Views/Home/SearchVideo.cshtml")]
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43da3001cbf0023474851afeda02c47e4394f7af", @"/Views/Home/SearchVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58cea3eb479b3127d4d5b6797c63a66d6b104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Video_vm>>
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
            WriteLiteral("\r\n<div class=\"site-layout\">\r\n    <div class=\"site-layout_centent \">\r\n        <div class=\"text_popular\">Tìm kiếm Video</div>\r\n");
#nullable restore
#line 7 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
         if (Model.Count==0||Model==null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""content_Nologin"" >
                <div class=""message_nologin"">
                    <h3 class=""no_relationship"">Video bạn tìm không có </h3>
                    <h6 style=""margin-left:80px;"">Vui lòng  thử lại</h6>
                </div>
                
            </div>
");
#nullable restore
#line 16 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43da3001cbf0023474851afeda02c47e4394f7af6341", async() => {
                WriteLiteral("\r\n                    <div class=\"popular_left\">\r\n                        <video");
                BeginWriteAttribute("onmouseover", " onmouseover=\"", 804, "\"", 838, 3);
                WriteAttributeValue("", 818, "viewBefore(", 818, 11, true);
#nullable restore
#line 23 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
WriteAttributeValue("", 829, item.Id, 829, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 837, ")", 837, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("onmouseout", " onmouseout=\"", 839, "\"", 873, 3);
                WriteAttributeValue("", 852, "clearBefore(", 852, 12, true);
#nullable restore
#line 23 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
WriteAttributeValue("", 864, item.Id, 864, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 872, ")", 872, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 874, "\"", 913, 3);
                WriteAttributeValue(" ", 882, "nextSecond", 883, 11, true);
                WriteAttributeValue(" ", 893, "nextSecond-", 894, 12, true);
#nullable restore
#line 23 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
WriteAttributeValue("", 905, item.Id, 905, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                               data-poster=\"");
#nullable restore
#line 24 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                                       Write(item.PosterImg);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"player\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43da3001cbf0023474851afeda02c47e4394f7af8569", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1032, "~/Client/video/", 1032, 15, true);
#nullable restore
#line 25 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
AddHtmlAttributeValue("", 1047, item.LinkVideo, 1047, 15, false);

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
                WriteLiteral("\r\n                        </video>\r\n                    </div>\r\n                    <div class=\"popular_right\">\r\n                        <div class=\"header__popular\">");
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"all_papge\">\r\n                            <div class=\"ten_kenh\">");
#nullable restore
#line 31 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                                             Write(item.FirtsName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 31 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                                                             Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .</div>\r\n                            <div class=\"luot_xem\">\r\n                                ");
#nullable restore
#line 33 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                           Write(ConvertViewCount.ConvertView(item.ViewCount));

#line default
#line hidden
#nullable disable
                WriteLiteral(" lượt xem\r\n                            </div>\r\n                            <div class=\"dau_cham_cach\">.</div>\r\n                            <div class=\"thoi_gian_cong_chieu\">");
#nullable restore
#line 36 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                                                         Write(CaculatorHours.Caculator(item.CreateDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"mota_noidung_video\">");
#nullable restore
#line 38 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                ");
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
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 41 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Home\SearchVideo.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var currentPage = 2;

            $('.site-layout').on('scroll', function () {
                let div = $(this).get(0);
                if (div.scrollTop + div.clientHeight >= div.scrollHeight) {
                    loadData();
                    currentPage += 1;
                }
            });
            function loadData() {
                var inputSearch = $(""#nameSearch"").val();
                $.get(""/Home/SearchVideo_Partial/?page="" + currentPage + ""&nameSearch="" + inputSearch, function (respone) {
                    $('.site-layout_centent').append(respone);
                    loadSecondVideo();
                });
            }
        });
    </script>

");
            }
            );
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
