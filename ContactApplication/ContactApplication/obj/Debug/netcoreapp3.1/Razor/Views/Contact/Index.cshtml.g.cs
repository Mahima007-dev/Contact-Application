#pragma checksum "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8224d0df1ee482520c263d2976d4fecf186c6051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8224d0df1ee482520c263d2976d4fecf186c6051", @"/Views/Contact/Index.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactApplication.Models.ContactResponseDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
<script src=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js""></script>

<h2>Contact List</h2>

<table class=""table"">
    <tr>
        <th>
            First Name
        </th>
        <th>
            Last Name
        </th>
        <th>
            Phone Count
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 27 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
     if (Model.Count > 0)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phones.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 45 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ContactId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\ContactApplication\ContactApplication\Views\Contact\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactApplication.Models.ContactResponseDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
