#pragma checksum "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c8dd372bfe8a0de788eb32368fb2e532336f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProjectDetail), @"mvc.1.0.view", @"/Views/Home/ProjectDetail.cshtml")]
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
#line 1 "D:\repos\C#\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\C#\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c8dd372bfe8a0de788eb32368fb2e532336f34", @"/Views/Home/ProjectDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProjectDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml"
  
    ViewData["Title"] = "جزئیات پروژه";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""cta-section theme-bg-light py-5"">
    <div class=""container text-center single-col-max-width"">
        <h2 class=""heading"">ارتباط با ما</h2>
        <div class=""intro"">
            <p>
                شما می توانید از طریق فرم زیر با ما ارتباط بگیرید. لطفا پس از پرکردن آیتم ها، پیغام مورد نظر را
                نوشته و ارسال کنید.
            </p>
            <p>از طریق شبکه های اجتماعی با ما در ارتباط باشید</p>
            <ul class=""list-inline mb-0"">
                <li class=""list-inline-item mb-3"">
                    <a class=""twitter"" href=""#"">
                        <i class=""fab fa-twitter fa-fw fa-lg"">
                        </i>
                    </a>
                </li>

                <li class=""list-inline-item mb-3"">
                    <a class=""linkedin"" href=""#"">
                        <i class=""fab fa-linkedin-in fa-fw fa-lg"">
                        </i>
                    </a>
                </li>
                <li class=""list-inline-");
            WriteLiteral(@"item mb-3"">
                    <a class=""github"" href=""#"">
                        <i class=""fab fa-github-alt fa-fw fa-lg"">
                        </i>
                    </a>
                </li>
                <li class=""list-inline-item"">
                    <a class=""instagram"" href=""#"">
                        <i class=""fab fa-instagram fa-fw fa-lg"">
                        </i>
                    </a>
                </li>
                <li class=""list-inline-item mb-3"">
                    <a class=""stack-overflow"" href=""#"">
                        <i class=""fab fa-stack-overflow fa-fw fa-lg"">
                        </i>
                    </a>
                </li>
                <li class=""list-inline-item mb-3"">
                    <a class=""medium"" href=""#"">
                        <i class=""fab fa-medium-m fa-fw fa-lg"">
                        </i>
                    </a>
                </li>
                <li class=""list-inline-item mb-3"">
                ");
            WriteLiteral(@"    <a class=""codepen"" href=""#"">
                        <i class=""fab fa-codepen fa-fw fa-lg"">
                        </i>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</section>
<section class=""contact-section px-3 py-5 p-md-5"">
    <div class=""container"">
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Image</td>
                    <td>Name</td>
                    <td>Description</td>
                    <td>Client</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 78 "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml"
                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9c8dd372bfe8a0de788eb32368fb2e532336f346772", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2901, "~/assets/images/project/", 2901, 24, true);
#nullable restore
#line 80 "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml"
AddHtmlAttributeValue("", 2925, Model.Image, 2925, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 82 "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "D:\repos\C#\DevCard\DevCard_MVC\Views\Home\ProjectDetail.cshtml"
                   Write(Model.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
