#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26562f393000ea7631606016e10ef2cca3624c46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Actions_Index), @"mvc.1.0.view", @"/Areas/Administration/Views/Actions/Index.cshtml")]
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
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\_ViewImports.cshtml"
using DoanData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26562f393000ea7631606016e10ef2cca3624c46", @"/Areas/Administration/Views/Actions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab395a05fc1c45813e520392b0915e7416e797f4", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Actions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoanData.Models.Action>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administration/assets/img/Search.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-reset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administration/assets/img/Reset.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Administration/assets/img/ic_add.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Administration/Views/shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""filter"">
    <div class=""title-filter"">Tìm kiếm</div>
    <div class=""btn-filter d-flex justify-content-between"" style=""padding: 0px 11px 10px 10px"">
        <div class=""col"">
            <input style=""width:800px;"" id=""nameSearch"" placeholder=""Nhập tên đầy đủ"" type=""text"" name=""name""
                   class=""form-control d-inline rounded-0 "">
            <button class=""btn btn-search text-white rounded-0 p-0 text-left col-2"" id=""btnSearch"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26562f393000ea7631606016e10ef2cca3624c466871", async() => {
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
            WriteLiteral("\r\n                <span class=\"header-text-site-layout\">TÌM KIẾM</span>\r\n            </button>\r\n            <button class=\"btn btn-reset\" style=\"padding-left: 0.5rem\" id=\"reload\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26562f393000ea7631606016e10ef2cca3624c468277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </button>\r\n            <span class=\"text-danger\" id=\"errorSearch\"></span>\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1110, "\"", 1118, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <button type=\"button\" class=\"btn btn-add text-white rounded-0 p-0 text-left\" id=\"showCreate\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26562f393000ea7631606016e10ef2cca3624c469877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"header-text-site-layout\">THÊM MỚI</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n               Chức năng\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.function.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"function_meeting\">\r\n                <div class=\"functions_meeting__mes\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2064, "\"", 2096, 3);
            WriteAttributeValue("", 2074, "editFunction(", 2074, 13, true);
#nullable restore
#line 53 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
WriteAttributeValue("", 2087, item.Id, 2087, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2095, ")", 2095, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <a class=\"functions_meeting__mes__btn\">\r\n                        <i class=\"fa fa-edit\"></i>\r\n                    </a>\r\n\r\n                </div>\r\n                <div class=\"functions_meeting__mes\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2318, "\"", 2352, 3);
            WriteAttributeValue("", 2328, "deleteFunction(", 2328, 15, true);
#nullable restore
#line 60 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
WriteAttributeValue("", 2343, item.Id, 2343, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2351, ")", 2351, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"functions_meeting__mes__btns\" id=\"Delete\">\r\n                        <i class=\"fa fa-trash\"></i>\r\n                    </a>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 67 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Areas\Administration\Views\Actions\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(""#showCreate"").click(function () {
            OpenPopUp(""Thêm hành động"", ""/Administration/Actions/Create"");
        });
        function editFunction(id) {
            OpenPopUp(""Cập nhật hành động"", ""/Administration/Actions/Edit/?id="" + id);
        }
        function deleteFunction(id) {
            var confirms = confirm(""Bạn chắc muốn xóa phần tử này?"");
            if (confirms)
                replaceBody(""/Administration/Actions/Delete/?id="" + id);
        }
        $(""#reload"").click(function () {
            location.reload();
        });
        $(""#btnSearch"").click(function () {
            var namesearch = $(""#nameSearch"").val();
            if (namesearch== '')
                $(""#errorSearch"").text(""Vui lòng nhập tên tìm kiếm"");
            else {
                $(""#errorSearch"").text('');
                replaceBody(""/Administration/Actions/ListActionResult/?name="" + namesearch);
            }
        });
        function replaceBody(url) {");
                WriteLiteral(@"
            $.get(url, function (respone) {
                var contentReplace = '';
                if (respone != null) {
                    respone = JSON.parse(respone);
                    $.each(respone, function (index, value) {
                        contentReplace += `<tr>
                            <td>
                                ${value.Name}
                            </td>
                            <td>
                                ${value.function.Name}
                            </td>
                            <td class=""function_meeting"">
                                <div class=""functions_meeting__mes"" onclick=""editFunction(${value.Id})"">
                                    <a class=""functions_meeting__mes__btn"">
                                        <i class=""fa fa-edit""></i>
                                    </a>
                                </div>
                                <div class=""functions_meeting__mes"" onclick=""deleteFunction(${value");
                WriteLiteral(@".Id})"">
                                    <a class=""functions_meeting__mes__btns"" id=""Delete"">
                                        <i class=""fa fa-trash""></i>
                                    </a>
                                </div>
                            </td>
                        </tr>`;
                    });
                    $('tbody').html(contentReplace);
                }
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoanData.Models.Action>> Html { get; private set; }
    }
}
#pragma warning restore 1591
