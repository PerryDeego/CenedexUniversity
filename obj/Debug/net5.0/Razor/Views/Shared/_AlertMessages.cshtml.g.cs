#pragma checksum "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\Shared\_AlertMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c1004fb56b5959665715c0f4f733710c1942697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AlertMessages), @"mvc.1.0.view", @"/Views/Shared/_AlertMessages.cshtml")]
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
#line 1 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using CenedexUniversityWebSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using CenedexUniversityWebSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c1004fb56b5959665715c0f4f733710c1942697", @"/Views/Shared/_AlertMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a567708cef0a3c29b262da8729f871a564e8d8e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AlertMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\Shared\_AlertMessages.cshtml"
 if (TempData["mssg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            var msg = \"");
#nullable restore
#line 6 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\Shared\_AlertMessages.cshtml"
                   Write((string)TempData["mssg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

            Swal.fire({
                position: 'top-end',
                icon: 'success',
                title: 'Your work has been saved',
                text: msg,
                showConfirmButton: false,
                timer: 2500
            })
        });
    </script>
");
#nullable restore
#line 18 "C:\Users\perry\Desktop\CenedexUniversityWebSystem - V1.6\CenedexUniversityWebSystem\Views\Shared\_AlertMessages.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591