#pragma checksum "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e24dadd84aaa15649e10244acda50b6e7f9d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AddStudent), @"mvc.1.0.view", @"/Views/Student/AddStudent.cshtml")]
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
#line 1 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\_ViewImports.cshtml"
using StudentDetailsWithMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\_ViewImports.cshtml"
using StudentDetailsWithMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e24dadd84aaa15649e10244acda50b6e7f9d4b", @"/Views/Student/AddStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c2a26a50dd6df8974e59801849c82e29a309ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentDetailsWithMVC.Models.StudentModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9e24dadd84aaa15649e10244acda50b6e7f9d4b3527", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Student Details</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9e24dadd84aaa15649e10244acda50b6e7f9d4b4596", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
     using (Html.BeginForm("AddStudent", "Student", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <center>
            <table cellpadding=""10"" cellspacing=""20"" border=""1"">
                <tr>
                    <th colspan=""2"" align=""center"">Student Details</th>
                </tr>
                <tr>
                    <td>Name: </td>
                    <td>
                        ");
#nullable restore
#line 30 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
                   Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Age: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
                   Write(Html.TextBoxFor(m => m.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Address: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
                   Write(Html.TextBoxFor(m => m.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>PhoneNumber: </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
                   Write(Html.TextBoxFor(m => m.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </td>
                </tr>


            </table>
        </center>
        <br />
        <br />
        <div>
            <center>
                <input type=""submit"" value=""Submit"" />
            </center>
        </div>
        <br />
        <br />
");
                WriteLiteral("        <center>\r\n            <div>\r\n                <font color=\"green\">");
#nullable restore
#line 67 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"
                               Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</font>\r\n            </div>\r\n        </center>\r\n");
#nullable restore
#line 70 "D:\Task\MVCApplication\StudentDetailsWithMVC\Views\Student\AddStudent.cshtml"


    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentDetailsWithMVC.Models.StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
