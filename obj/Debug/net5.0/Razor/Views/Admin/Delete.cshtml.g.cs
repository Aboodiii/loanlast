#pragma checksum "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d6daf68b9294529e84e8267a3cbe49d1ee2cc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Delete), @"mvc.1.0.view", @"/Views/Admin/Delete.cshtml")]
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
#line 1 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d6daf68b9294529e84e8267a3cbe49d1ee2cc0", @"/Views/Admin/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanManagementDone.Models.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/jquery-1.10.2.min.js "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 16 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 20 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 24 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 40 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 44 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 48 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 52 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 56 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 60 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 64 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberTwo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 68 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberTwo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 72 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 76 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 80 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 84 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 88 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 92 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 96 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 100 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 104 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdIssuedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 108 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdIssuedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 112 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 116 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExpiryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 120 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 124 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 128 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 132 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 136 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 140 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 144 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 150 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SuretyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 154 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SuretyId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>

    </dl>

    <div class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Modal body text goes here.</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>

");
#nullable restore
#line 179 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-actions no-color"">
            <input type=""submit"" value=""Delete"" class="" btn btn-danger btn-rounded"" /> |

            <a href=""/Admin/Index"" class=""btn btn-info btn-rounded"" id=""btndelete""><i class=""bi bi-eye""></i>Back to list</a>
        </div>
");
#nullable restore
#line 188 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\Delete.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <br />\r\n\r\n    <br /><br />\r\n\r\n    <br />\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2d6daf68b9294529e84e8267a3cbe49d1ee2cc017086", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link rel=""stylesheet"" href="" https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.css "">
<script src="" https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js ""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#btndelete "").click(function () {
            // alert ( "" Alert Message "" ) ;
            swal("" Here Is the alert Message "")
           });
     } );
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanManagementDone.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
