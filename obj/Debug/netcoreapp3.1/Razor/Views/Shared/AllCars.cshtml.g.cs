#pragma checksum "E:\code\Shop\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c089243fd3526c07c6d11f351d9c1a6dba2141a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
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
#line 1 "E:\code\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\code\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c089243fd3526c07c6d11f351d9c1a6dba2141a", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baabd4d78ea955865b39ec4eca129b80525a3d33", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-lg-4\">\r\n    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 82, 1);
#nullable restore
#line 3 "E:\code\Shop\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 72, Model.img, 72, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 83, "\"", 100, 1);
#nullable restore
#line 3 "E:\code\Shop\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 89, Model.name, 89, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <h2>Название: ");
#nullable restore
#line 4 "E:\code\Shop\Views\Shared\AllCars.cshtml"
             Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Цена: ");
#nullable restore
#line 5 "E:\code\Shop\Views\Shared\AllCars.cshtml"
        Write(Model.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><a class=\"btn btn-warning\" href=\"#\">Подпробнее</a></p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591