#pragma checksum "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FilmFabriken.Pages.Movies.Lists.Pages_Movies_Lists_Index), @"mvc.1.0.razor-page", @"/Pages/Movies/Lists/Index.cshtml")]
namespace FilmFabriken.Pages.Movies.Lists
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
#nullable restore
#line 2 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
using FilmFabriken.Model.MovieStuff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
using FilmFabriken.wwwroot.cs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed632f0cffe7f35c21a5ef7f283c0ac52ca2d56", @"/Pages/Movies/Lists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2efb2a63536cca589fb855ee276c0fc3e48af26", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Movies_Lists_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sortBy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"container row p-0 m-auto\">\r\n    <div class=\"col-10\">\r\n        <h2 class=\"text-info\">Mina listor</h2>\r\n    </div>\r\n    <div class=\"col-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d567730", async() => {
                WriteLiteral("Skapa ny lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n    </div>\r\n    \r\n    <div class=\"col-12 border p-3 mt-3 bg-secondary\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d569064", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
             if (Model.MovieLists.Any())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row font-weight-bold\">\r\n                    <div class=\"col-3\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d569720", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 22 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MovieLists.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d5611356", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MovieLists.FirstOrDefault().Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""col-6 row"">
                        <div class=""col d-flex"">
                            <div>
                                <label>Visa filmer efter</label>
                                <br/>
                                <select name=""sortBy"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d5613261", async() => {
                    WriteLiteral("Betyg");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d5614607", async() => {
                    WriteLiteral("Titel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""col pt-lg-3"">
                                <button type=""submit"" class=""btn btn-primary"">Sortera</button>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 43 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                 foreach (MovieList movieList in Model.MovieLists)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"bg-light p-3 m-2 rounded bg-primary\">\r\n                    <div class=\"row bg-primary p-3 m-0\">\r\n                        <div class=\"col-4\">\r\n                            ");
#nullable restore
#line 48 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                       Write(Html.DisplayFor(m => movieList.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-3\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                       Write(Html.DisplayFor(m => movieList.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-3 m-1\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d5617596", async() => {
                    WriteLiteral("Radera");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                                                                 WriteLiteral(movieList.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 15, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2366, "return", 2366, 6, true);
                AddHtmlAttributeValue(" ", 2372, "confirm(\'Är", 2373, 12, true);
                AddHtmlAttributeValue(" ", 2384, "du", 2385, 3, true);
                AddHtmlAttributeValue(" ", 2387, "säker", 2388, 6, true);
                AddHtmlAttributeValue(" ", 2393, "på", 2394, 3, true);
                AddHtmlAttributeValue(" ", 2396, "att", 2397, 4, true);
                AddHtmlAttributeValue(" ", 2400, "du", 2401, 3, true);
                AddHtmlAttributeValue(" ", 2403, "vill", 2404, 5, true);
                AddHtmlAttributeValue(" ", 2408, "ta", 2409, 3, true);
                AddHtmlAttributeValue(" ", 2411, "bort", 2412, 5, true);
                AddHtmlAttributeValue(" ", 2416, "listan", 2417, 7, true);
                AddHtmlAttributeValue(" ", 2423, "\\\'", 2424, 3, true);
#nullable restore
#line 54 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
AddHtmlAttributeValue("", 2426, movieList.Name, 2426, 15, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2441, "\\\'", 2441, 2, true);
                AddHtmlAttributeValue(" ", 2443, "?\')", 2444, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed632f0cffe7f35c21a5ef7f283c0ac52ca2d5621584", async() => {
                    WriteLiteral("Redigera");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                                                 WriteLiteral(movieList.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"movie-index-parent\">\r\n");
#nullable restore
#line 59 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                         foreach(Movie movie in movieList.Movies)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"movie-index-item mx-lg-2\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2938, "\"", 2990, 2);
                WriteAttributeValue("", 2945, "/movies/moviedetails/?movie_id=", 2945, 31, true);
#nullable restore
#line 62 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
WriteAttributeValue("", 2976, movie.MovieId, 2976, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <div>\r\n                                        <img style=\"width: 150px\"");
                BeginWriteAttribute("src", " src=", 3102, "", 3139, 1);
#nullable restore
#line 64 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
WriteAttributeValue("", 3107, Util.GetImageURL(movie.ImgPath), 3107, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"movie-index-item-overview\">\r\n                                        <div");
                BeginWriteAttribute("class", " class=\"", 3307, "\"", 3315, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <span class=\"font-weight-bold\"> ");
#nullable restore
#line 68 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                                                                       Write(movie.Rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            <span class=\"font-weight-lighter\"> ");
#nullable restore
#line 69 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                                                                          Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 74 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 77 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>Du har inga listor.</p>\r\n");
#nullable restore
#line 82 "C:\Users\willi\prylar\code2\c#\razorpages\FilmFabriken\Filmfabriken\Pages\Movies\Lists\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmFabriken.Pages.Movies.Lists.Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmFabriken.Pages.Movies.Lists.Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FilmFabriken.Pages.Movies.Lists.Index>)PageContext?.ViewData;
        public FilmFabriken.Pages.Movies.Lists.Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
