#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7635243168bccba117954f2e337a1341731eed1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_OverviewPage), @"mvc.1.0.view", @"/Views/Video/OverviewPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7635243168bccba117954f2e337a1341731eed1b", @"/Views/Video/OverviewPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58cea3eb479b3127d4d5b6797c63a66d6b104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_OverviewPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img_overView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/img/imgUpload.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyChannel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Video", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("move_page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml"
  
    Layout = "/Views/Shared/_Layout_1.cshtml";

    var user = UserAuthenticated.GetUser(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tongquankenh\">Trang tổng quan của kênh</div>\r\n<div class=\"all_tongquankenh\">\r\n    <div class=\"alltongquankenh_left\">\r\n        <div class=\"padding_tongquankenh\">\r\n            <div class=\"tramfom_img_tongquankenh\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7635243168bccba117954f2e337a1341731eed1b6217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""name_tongquan_taivieo"">Bạn có muốn xem các chỉ số cho video gần đây của mình không?</div>
        <div class=""name_tongquan_taivieo2"">Hãy đăng tải và xuất bản một video để bắt đầu.</div>
        <div class=""a_center_click"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7635243168bccba117954f2e337a1341731eed1b7713", async() => {
                WriteLiteral("<button class=\"click_create_video_tongquan\">Tải video lên</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""alltongquankenh_right"">
        <div class=""name_solieuphantich"">Số liệu phân tích về kênh</div>
        <div class=""songuoidangkyhientai"">Số người đăng ký hiện tại</div>
        <div class=""soluong_subhientai"">");
#nullable restore
#line 23 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml"
                                   Write(ViewBag.CountUserFollow);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" người đăng ký</div>
        <div class=""kengang_hietai""></div>
        <div class=""name_solieuphantich"">Tóm tắt</div>
        <div class=""all_soluotxem_time_xem"">
            <div class=""all_soluotxem_time_xem_left"">Số lượt xem</div>
            <div class=""all_soluotxem_time_xem_right"">
                <div class=""sangphai_hientai"">");
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml"
                                         Write(ViewBag.CountView.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" lượt xem</div>
            </div>
        </div>
        <div class=""all_soluotxem_time_xemtime"">
            <div class=""all_soluotxem_time_xem_left"">Tổng số Video</div>
            <div class=""all_soluotxem_time_xem_right"">
                <div class=""sangphai_hientai_time"">");
#nullable restore
#line 35 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml"
                                              Write(ViewBag.CountVideo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </div>
            </div>
        </div>
        <div class=""all_soluotxem_time_xemtime"">
            <div class=""all_soluotxem_time_xem_left"">Tổng số bình luận</div>
            <div class=""all_soluotxem_time_xem_right"">
                <div class=""sangphai_hientai_time"">");
#nullable restore
#line 41 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml"
                                              Write(ViewBag.CountComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""all_soluotxem_time_xemtime"">
            <div class=""all_soluotxem_time_xem_left"">Tổng số lượt thích</div>
            <div class=""all_soluotxem_time_xem_right"">
                <div class=""sangphai_hientai_time"">");
#nullable restore
#line 47 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Video\OverviewPage.cshtml"
                                              Write(ViewBag.CountLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>");
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
