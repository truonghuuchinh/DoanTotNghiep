#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba12fcce62e5c0f10aa4d66a1595bb30142db04e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Video_DetailVideo), @"mvc.1.0.view", @"/Areas/Administration/Views/Video/DetailVideo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba12fcce62e5c0f10aa4d66a1595bb30142db04e", @"/Areas/Administration/Views/Video/DetailVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf60c0025946dce12a04616957a471e29b5a4b8", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Video_DetailVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Video>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
  
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mainDetail\">\r\n    <div class=\"mainDetail__left col-lg-5\">\r\n        <video controls=\"controls\">\r\n            <source");
            BeginWriteAttribute("src", " src=\"", 170, "\"", 206, 2);
            WriteAttributeValue("", 176, "/Client/video/", 176, 14, true);
#nullable restore
#line 9 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
WriteAttributeValue("", 190, Model.LinkVideo, 190, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"video/mp4\" />\r\n        </video>\r\n        <div class=\"right__nameVideo\">\r\n            <div class=\"right__nameVideo__name\">Tên video</div>\r\n            <div class=\"right__content\">");
#nullable restore
#line 13 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>
    </div>
    <div class=""mainDetail__right col-lg-7"">
        <div class=""right__createdate"">
            <div class=""col-3 border__right"" style=""padding:0px;"">
                <div class=""right__nameVideo__name"">Ngày tạo</div>
                <div class=""right__content"">");
#nullable restore
#line 20 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
                                       Write(Model.CreateDate.Split(' ')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"col-3 border__right\">\r\n                <div class=\"right__nameVideo__name\">Lượt xem</div>\r\n                <div class=\"right__content\">");
#nullable restore
#line 24 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
                                       Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"col-3 border__right\">\r\n                <div class=\"right__nameVideo__name\">Lượt Like</div>\r\n                <div class=\"right__content\">");
#nullable restore
#line 28 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
                                       Write(Model.Like);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <div class=\"right__nameVideo__name\"> Lượt Dislike</div>\r\n                <div class=\"right__content\">");
#nullable restore
#line 32 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
                                       Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div class=\"right__poster\">\r\n            <div class=\"right__nameVideo__name\">Poster video</div>\r\n            <div class=\"right__content right__poster__content\"><img");
            BeginWriteAttribute("src", " src=\"", 1570, "\"", 1610, 2);
            WriteAttributeValue("", 1576, "/Client/imgPoster/", 1576, 18, true);
#nullable restore
#line 38 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
WriteAttributeValue("", 1594, Model.PosterImg, 1594, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" /></div>
        </div>
        <hr />
        <div class=""right__description"">
            <div class=""right__nameVideo__name"">Mô tả</div>
            <textarea readonly class=""right__description--text right__content"">
                    ");
#nullable restore
#line 44 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Video\DetailVideo.cshtml"
                Write("\r\n"+Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </textarea>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Video> Html { get; private set; }
    }
}
#pragma warning restore 1591
