#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7270db65e581da77e5b50ba8388066a7a0b084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_Notification_Partial), @"mvc.1.0.view", @"/Views/Notification/Notification_Partial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7270db65e581da77e5b50ba8388066a7a0b084", @"/Views/Notification/Notification_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58cea3eb479b3127d4d5b6797c63a66d6b104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_Notification_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Notification>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
  
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"tong_khungss_thongbao_all\">\r\n");
#nullable restore
#line 8 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
         if (Model == null || Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"khung_thongbao_video\">\r\n                <div class=\"none_notifi\">Không có thông báo</div>\r\n            </div>\r\n");
#nullable restore
#line 13 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" class=\"getIdNotifi\"");
            BeginWriteAttribute("value", " value=\"", 458, "\"", 474, 1);
#nullable restore
#line 18 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
WriteAttributeValue("", 466, item.Id, 466, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                <div class=\"khung_thongbao_video\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7270db65e581da77e5b50ba8388066a7a0b0845945", async() => {
                WriteLiteral("\r\n                        <div class=\"khung_thongbao_video_left_daucham\">\r\n");
#nullable restore
#line 23 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
                             if (item.Watched)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"nowatched\"></div>\r\n");
#nullable restore
#line 26 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"watched\"></div>\r\n");
#nullable restore
#line 30 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"khung_thongbao_video_img\">\r\n                            <img class=\"img_trang__cuaban_thongbao\"");
                BeginWriteAttribute("alt", " alt=\"", 1242, "\"", 1248, 0);
                EndWriteAttribute();
                BeginWriteAttribute("src", " src=\"", 1249, "\"", 1325, 1);
#nullable restore
#line 33 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
WriteAttributeValue("", 1255, item.LoginExternal?item.AvartarUser:"/Client/img/"+item.AvartarUser, 1255, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"noidung_khungthongbaovideo_text\">\r\n                            <div class=\"noidung_khungthongbao_video__text\"><strong>");
#nullable restore
#line 36 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
                                                                              Write(item.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> ");
#nullable restore
#line 36 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
                                                                                                      Write(item.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"thoigian_daguithongbao\">");
#nullable restore
#line 37 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
                                                           Write(CaculatorHours.Caculator(item.CreateDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"img_thongbaovideocuado\">\r\n                            <div class=\"img_thongbaovideocuado_video\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1876, "\"", 1914, 2);
                WriteAttributeValue("", 1882, "/Client/imgPoster/", 1882, 18, true);
#nullable restore
#line 41 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
WriteAttributeValue("", 1900, item.PoterImg, 1900, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1915, "\"", 1921, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img_thong_bao_videocuado_video\">\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 564, "link_detail-", 564, 12, true);
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
AddHtmlAttributeValue("", 576, item.Id, 576, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 584, "linkDetail", 585, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
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
            WriteLiteral("\r\n                    <div class=\"daubacham_anthongbao\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2111, "\"", 2149, 3);
            WriteAttributeValue("", 2121, "optionNotifi(event,", 2121, 19, true);
#nullable restore
#line 45 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
WriteAttributeValue("", 2140, item.Id, 2140, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2148, ")", 2148, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"daubacham_anthongbao_video\">\r\n                            <img src=\"/Client/img/more.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2278, "\"", 2284, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2285, "\"", 2338, 3);
            WriteAttributeValue("", 2293, "show_daubacham_anthongbao_video", 2293, 31, true);
            WriteAttributeValue(" ", 2324, "more-", 2325, 6, true);
#nullable restore
#line 47 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
WriteAttributeValue("", 2330, item.Id, 2330, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 2426, "\"", 2475, 3);
            WriteAttributeValue("", 2434, "an_thongbaonay_all", 2434, 18, true);
            WriteAttributeValue(" ", 2452, "option_notifi-", 2453, 15, true);
#nullable restore
#line 50 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
WriteAttributeValue("", 2467, item.Id, 2467, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""kekhungheader""></div>
                        <div class=""class_nameimg_anthongbao"">
                            <div class=""khung_img_class_nameimg_anthongbo"">
                                <div class=""img_class_nameimg_anthongbo""></div>
                            </div>
                            <div class=""noidung_class_nameimg_anthongbao"">Ẩn thông báo này</div>
                        </div>
                        <div class=""class_nameimg_anthongbao"">
                            <div class=""khung_img_class_nameimg_anthongbo"">
                                <div class=""img_offthongbao""></div>
                            </div>
                            <div class=""noidung_class_nameimg_anthongbao"">Tắt thông báo từ kênh </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 66 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"


            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Notification\Notification_Partial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
