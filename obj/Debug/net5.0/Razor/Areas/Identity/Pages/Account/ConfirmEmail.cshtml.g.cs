#pragma checksum "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a7a0d8e721cce86aef8ae17ec6c053b7f87d86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
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
#line 1 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\_ViewImports.cshtml"
using Pulp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\_ViewImports.cshtml"
using Pulp.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\_ViewImports.cshtml"
using Pulp.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Pulp.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a7a0d8e721cce86aef8ae17ec6c053b7f87d86", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82574a8173c6b50500d76d99f983e2513d19cea4", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ba17075ede8680414ef56598d9e15d6fcdbf0d6", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-center p-5 mt-3\" style=\"color: #7BB38E\">");
#nullable restore
#line 7 "D:\Prepreation\project\Pulp-Products-Store-ITI-main\Pulp-Products-Store-ITI-main\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
                                                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<input type=\"button\" onclick=\"alert(\'Added\')\" value=\"test add user\" style=\"background-color:#7BB38E\"/>\n<script>\n    function alertMe() {\n\n    }\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
