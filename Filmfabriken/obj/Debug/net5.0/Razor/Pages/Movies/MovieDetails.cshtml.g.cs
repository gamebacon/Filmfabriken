#pragma checksum "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd9832a4aa8cb901adfcd4aafc9e0b9d83c11287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FilmFabriken.Pages.Movies.Pages_Movies_MovieDetails), @"mvc.1.0.razor-page", @"/Pages/Movies/MovieDetails.cshtml")]
namespace FilmFabriken.Pages.Movies
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
#line 1 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\_ViewImports.cshtml"
using FilmFabriken;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9832a4aa8cb901adfcd4aafc9e0b9d83c11287", @"/Pages/Movies/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2efb2a63536cca589fb855ee276c0fc3e48af26", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Movies_MovieDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"inspect-container\">\r\n        <div class=\"inspect-top-section \">\r\n            <div class=\"inspect-poster-wrapper\">\r\n                <img class=\"inspect-poster\"");
            BeginWriteAttribute("src", " src=", 257, "", 282, 1);
#nullable restore
#line 9 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml"
WriteAttributeValue("", 262, Model.Input.ImgPath, 262, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 282, "\"", 306, 1);
#nullable restore
#line 9 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml"
WriteAttributeValue("", 288, Model.Input.Title, 288, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"inspect-details\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 393, "\"", 401, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"p-3 h2 inspect-heading font-weight-bolder\">");
#nullable restore
#line 13 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml"
                                                                       Write(Model.Input.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"p-3 h4 inspect-rating\">");
#nullable restore
#line 14 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml"
                                                   Write(Model.Input.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"p-3 h4 font-weight-bold\">(");
#nullable restore
#line 15 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml"
                                                      Write(Model.Input.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                </div>\r\n                <div class=\"inspect-overview p-lg-4\">\r\n                    <span class=\"font-weight-bold\">");
#nullable restore
#line 18 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\MovieDetails.cshtml"
                                              Write(Model.Input.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"inspect-bottom-section bg-light\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9832a4aa8cb901adfcd4aafc9e0b9d83c112876536", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmFabriken.Pages.Movies.MovieDetails> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmFabriken.Pages.Movies.MovieDetails> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmFabriken.Pages.Movies.MovieDetails>)PageContext?.ViewData;
        public FilmFabriken.Pages.Movies.MovieDetails Model => ViewData.Model;
    }
}
#pragma warning restore 1591
