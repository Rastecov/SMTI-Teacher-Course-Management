#pragma checksum "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5acdd4bb21eed51694d6bac7c506fb8fe99349f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\_ViewImports.cshtml"
using SMTI_Teacher_Course_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\_ViewImports.cshtml"
using SMTI_Teacher_Course_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5acdd4bb21eed51694d6bac7c506fb8fe99349f", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4bdfba1e6bcc9a913c40db1bf7f3ec578760fe5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMTI_Teacher_Course_Management.Models.Users>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Login</h1>\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
 using (Html.BeginForm())
{
    

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
     if (ViewData["hasMessage"] == "True")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">");
#nullable restore
#line 13 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
                                   Write(ViewData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 18 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n       \r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
       Write(Html.LabelFor(model => model.UserId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
           Write(Html.TextBoxFor(model => model.UserId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
           Write(Html.PasswordFor(model => model.Password, new { htmlAttributes = new { @class = "password" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 33 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Login\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\erast\Documents\SEMESTER 4\WEB SERVER APP 2\Final_exam\SMTI Teacher-Course Management\SMTI Teacher-Course Management\Views\Home\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMTI_Teacher_Course_Management.Models.Users> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
