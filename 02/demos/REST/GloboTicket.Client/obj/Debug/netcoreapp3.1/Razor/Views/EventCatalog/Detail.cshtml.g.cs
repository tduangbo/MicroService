#pragma checksum "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4da48db61a6bf3c82709c98a2ed1b0c28bfdff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EventCatalog_Detail), @"mvc.1.0.view", @"/Views/EventCatalog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4da48db61a6bf3c82709c98a2ed1b0c28bfdff", @"/Views/EventCatalog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EventCatalog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GloboTicket.Web.Models.Api.Event>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row mt-5\">\r\n    <div class=\"col-md-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 105, "\"", 126, 1);
#nullable restore
#line 4 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
WriteAttributeValue("", 111, Model.ImageUrl, 111, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"detailImage\" alt=\"Artist pic\" />\r\n    </div>\r\n    <div class=\"col-md-6 ml-1\">\r\n        <div class=\"row\">\r\n            <div class=\"columnHeader\">");
#nullable restore
#line 8 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
                                 Write(Model.CategoryName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row mt-2 bold\">\r\n            <h1>");
#nullable restore
#line 11 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row mt-2\">\r\n            <h3>");
#nullable restore
#line 14 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
           Write(Model.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"row mt-3 mt-4 bold\">\r\n            <h3>");
#nullable restore
#line 17 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
           Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"row mt-4\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row mt-5\">\r\n            <h3><span class=\"bold\">$");
#nullable restore
#line 23 "C:\Users\Me\Documents\MicroService\02\demos\REST\GloboTicket.Client\Views\EventCatalog\Detail.cshtml"
                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3><span class=\"mt-1\">&nbsp;&nbsp;&nbsp; PER TICKET</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-5\">\r\n    <div class=\"col\">\r\n        <hr />\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GloboTicket.Web.Models.Api.Event> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
