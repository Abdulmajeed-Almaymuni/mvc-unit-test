#pragma checksum "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ece6c4520ec51ebc416415cf0e3a335f726c7c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
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
#line 1 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\_ViewImports.cshtml"
using CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\_ViewImports.cshtml"
using CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ece6c4520ec51ebc416415cf0e3a335f726c7c1", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
  
    Student student = ViewBag.Student;
    ViewData["title"] = "Student Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
 if (student != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>ID: ");
#nullable restore
#line 8 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
      Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Student Name: ");
#nullable restore
#line 9 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
                Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
                                   Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Student Email: ");
#nullable restore
#line 10 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
                 Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a href=\"/Students\" class=\"btn btn-primary\">Back</a>\r\n");
#nullable restore
#line 12 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
   
} else {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Data not found</p>\r\n");
#nullable restore
#line 16 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Details.cshtml"
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
