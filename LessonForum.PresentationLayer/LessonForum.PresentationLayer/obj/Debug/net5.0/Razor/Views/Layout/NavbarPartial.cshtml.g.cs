#pragma checksum "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\LessonForum.PresentationLayer\Views\Layout\NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393b7aef3505eb400ca41c600f16e17ea758d626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout_NavbarPartial), @"mvc.1.0.view", @"/Views/Layout/NavbarPartial.cshtml")]
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
#line 1 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\LessonForum.PresentationLayer\Views\_ViewImports.cshtml"
using LessonForum.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\LessonForum.PresentationLayer\Views\_ViewImports.cshtml"
using LessonForum.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ecmel\source\repos\LessonForum\LessonForum.PresentationLayer\LessonForum.PresentationLayer\Views\_ViewImports.cshtml"
using LessonForum.EntityLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393b7aef3505eb400ca41c600f16e17ea758d626", @"/Views/Layout/NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a225bcf6cf79c7b0dc49baccb06472923517307", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Layout_NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-transparent  navbar-absolute bg-primary fixed-top"">
    <div class=""container-fluid"">
        <div class=""navbar-wrapper"">
            <div class=""navbar-toggle"">
                <button type=""button"" class=""navbar-toggler"">
                    <span class=""navbar-toggler-bar bar1""></span>
                    <span class=""navbar-toggler-bar bar2""></span>
                    <span class=""navbar-toggler-bar bar3""></span>
                </button>
            </div>
           
        </div>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-bar navbar-kebab""></span>
            <span class=""navbar-toggler-bar navbar-kebab""></span>
            <span class=""navbar-toggler-bar navbar-kebab""></span>
        </button>
        <div class=""collapse navbar-collapse justify-content-e");
            WriteLiteral("nd\" id=\"navigation\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393b7aef3505eb400ca41c600f16e17ea758d6264860", async() => {
                WriteLiteral("\r\n                <div class=\"input-group no-border\">\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1157, "\"", 1165, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"Ara...\">\r\n                    <span class=\"input-group-addon\">\r\n                        <i class=\"now-ui-icons ui-1_zoom-bold\"></i>\r\n                    </span>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#pablo"">
                        <i class=""now-ui-icons media-2_sound-wave""></i>
                        <p>
                            <span class=""d-lg-none d-md-block"">Stats</span>
                        </p>
                    </a>
                </li>
                
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#pablo"">
                        <i class=""now-ui-icons location_world""></i>
                        <p>
                            <span class=""d-lg-none d-md-block"">Account</span>
                        </p>
                    </a>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""http://example.com"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""now");
            WriteLiteral(@"-ui-icons users_single-02""></i>
                        
                        <p>
                            <span class=""d-lg-none d-md-block"">Some Actions</span>
                        </p>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                        <a class=""dropdown-item"" href=""#"">Giriş Yap</a>
                        <a class=""dropdown-item"" href=""#"">Hesap Oluştur</a>
                        <a class=""dropdown-item"" href=""#"">Profil</a>
                        <a class=""dropdown-item"" href=""#"">Ayarlar</a>
                        <a class=""dropdown-item"" href=""#"">Çıkış Yap</a>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591