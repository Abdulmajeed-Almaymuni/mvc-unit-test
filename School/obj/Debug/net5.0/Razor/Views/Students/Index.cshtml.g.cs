#pragma checksum "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfaa94453e1ff22f0b6ae8685c9236d7e6d29b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfaa94453e1ff22f0b6ae8685c9236d7e6d29b62", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2893f32809c6984f1f4f51fb32c8f7d676103953", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
  
    ViewData["title"] = "Students";
    List<Student> students = (List<Student>)ViewData["Students"];
    bool added = (bool)ViewData["Added"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/Students/Create\" class=\"btn btn-success\">Add New Student</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
 if (added == true) {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success \">Student Added Successfully</div>\r\n");
#nullable restore
#line 13 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
 if (students.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Details</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
             foreach (var student in students)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
                               Write(student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
                   Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
                   Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
                   Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1037, "\"", 1073, 2);
            WriteAttributeValue("", 1044, "/Students/Details/", 1044, 18, true);
#nullable restore
#line 35 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
WriteAttributeValue("", 1062, student.Id, 1062, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">View</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 40 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> No students found</p>\r\n");
#nullable restore
#line 44 "C:\Users\b0c0a\Source\Repos\mvc-unit-test\School\Views\Students\Index.cshtml"
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
