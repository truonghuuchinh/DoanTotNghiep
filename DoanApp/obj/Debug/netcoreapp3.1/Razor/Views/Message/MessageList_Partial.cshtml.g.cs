#pragma checksum "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa298c65e073985d5ffa675290235d1bf2a36031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageList_Partial), @"mvc.1.0.view", @"/Views/Message/MessageList_Partial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa298c65e073985d5ffa675290235d1bf2a36031", @"/Views/Message/MessageList_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e58cea3eb479b3127d4d5b6797c63a66d6b104a", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageList_Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message_Vm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
   
    Layout = null;
    var user = UserAuthenticated.GetUser(User.Identity.Name);


#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
 if (Model!=null)
{
        foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"au-message__item unread \"");
            BeginWriteAttribute("onclick", " onclick=\"", 235, "\"", 289, 5);
            WriteAttributeValue("", 245, "loadMessage(", 245, 12, true);
#nullable restore
#line 11 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 257, item.SenderId, 257, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 271, ",", 271, 1, true);
#nullable restore
#line 11 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 272, item.ReceiverId, 272, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 288, ")", 288, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"au-message__item-inner\">\n                    <div class=\"au-message__item-text\">\n                        <div");
            BeginWriteAttribute("class", " class=\"", 429, "\"", 475, 2);
            WriteAttributeValue("", 437, "avatar-wrap", 437, 11, true);
#nullable restore
#line 14 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue(" ", 448, item.Online?"online":"", 449, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div class=\"avatar\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 563, "\"", 635, 1);
#nullable restore
#line 16 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 569, item.LoginExternal?item.Avartar:"/Client/avartar/"+item.Avartar, 569, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                            </div>\n                        </div>\n                        <div class=\"text\">\n                            <h5 class=\"name\">");
#nullable restore
#line 20 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
                                        Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <p");
            BeginWriteAttribute("class", " class=\"", 843, "\"", 875, 2);
            WriteAttributeValue("", 851, "watched-", 851, 8, true);
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 859, item.ReceiverId, 859, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 876, "\"", 924, 1);
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 884, item.CheckWatched?"color:#0351c6;":"", 884, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
                                                                                                            Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                    <div class=\"au-message__item-time\">\n                        <span>");
#nullable restore
#line 25 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
                         Write(CaculatorHours.Caculator(item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 29 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("         <hr />\r\n");
#nullable restore
#line 31 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
        foreach (var item in ViewBag.GetUserNoneChat)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"au-message__item unread \"");
            BeginWriteAttribute("onclick", " onclick=\"", 1354, "\"", 1408, 5);
            WriteAttributeValue("", 1364, "loadMessage(", 1364, 12, true);
#nullable restore
#line 33 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 1376, item.SenderId, 1376, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1390, ",", 1390, 1, true);
#nullable restore
#line 33 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 1391, item.ReceiverId, 1391, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1407, ")", 1407, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"au-message__item-inner\">\n                    <div class=\"au-message__item-text\">\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1548, "\"", 1594, 2);
            WriteAttributeValue("", 1556, "avatar-wrap", 1556, 11, true);
#nullable restore
#line 36 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue(" ", 1567, item.Online?"online":"", 1568, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div class=\"avatar\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1682, "\"", 1754, 1);
#nullable restore
#line 38 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
WriteAttributeValue("", 1688, item.LoginExternal?item.Avartar:"/Client/avartar/"+item.Avartar, 1688, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                            </div>\n                        </div>\n                        <div class=\"text\">\n                            <h5 class=\"name\">");
#nullable restore
#line 42 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
                                        Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <p>");
#nullable restore
#line 43 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
                          Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                    <div class=\"au-message__item-time\">\n                        <span>");
#nullable restore
#line 47 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
                         Write(CaculatorHours.Caculator(item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                </div>\n            </div>\r\n");
#nullable restore
#line 51 "E:\HK5\Prepare Project Last Semester\DoanTotNghiep\DoanApp\Views\Message\MessageList_Partial.cshtml"
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message_Vm>> Html { get; private set; }
    }
}
#pragma warning restore 1591