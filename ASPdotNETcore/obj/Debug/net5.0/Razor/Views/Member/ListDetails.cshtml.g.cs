#pragma checksum "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a9b7d0f9532e8f4e1030cb04e1e6b71cc648f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_ListDetails), @"mvc.1.0.view", @"/Views/Member/ListDetails.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\_ViewImports.cshtml"
using ASP.NETcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\_ViewImports.cshtml"
using ASP.NETcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a9b7d0f9532e8f4e1030cb04e1e6b71cc648f5", @"/Views/Member/ListDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203d236a49d3df087e0062196815562beea5d932", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_ListDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPdotNETcore.Models.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n    <button type=\"button\" class=\"btn btn-success\" onclick=\"window.location.href=\'/Member/Create\'\">Create<i\r\n            class=\"fa fa-plus\"></i></button>\r\n    </div>\r\n    <div class=\"col-10\">\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
          using (Html.BeginForm("ListDetails", "Member", FormMethod.Get))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"row\">\r\n");
            WriteLiteral("                    <input class=\"form-control col-md-3\" name=\"searchString\"");
            BeginWriteAttribute("value", " value=\"", 618, "\"", 648, 1);
#nullable restore
#line 13 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
WriteAttributeValue("", 626, ViewBag.CurrentFilter, 626, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Type first name or last name ...\" type=\"text\">\r\n                    &nbsp;<button type=\"submit\" class=\"btn btn-primary \"><i class=\"fa fa-search\"></i>Search</button>\r\n                </p>\r\n");
#nullable restore
#line 16 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

</div>

<div class=""table-responsive"" >
    <table class=""table table-bordered table-hover"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr>
                <th></th>
                <th>First name</th>
                <th>Last name</th>
                <th>Date of birth</th>
                <th>Birth place</th>
                <th>Gender</th>
                <th>Phone number</th>
                <th>Graduated</th>
                <th>Start date</th>
                <th>End date</th>
            </tr>
        </thead>
");
#nullable restore
#line 37 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody");
            BeginWriteAttribute("id", " id=\"", 1503, "\"", 1526, 2);
            WriteAttributeValue("", 1508, "row_", 1508, 4, true);
#nullable restore
#line 39 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
WriteAttributeValue("", 1512, item.LastName, 1512, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1604, "\"", 1638, 2);
            WriteAttributeValue("", 1611, "/Member/Edit/", 1611, 13, true);
#nullable restore
#line 42 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
WriteAttributeValue("", 1624, item.LastName, 1624, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\"><i class=\"fas fa-edit\">Edit</i></a><br>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1720, "\"", 1757, 2);
            WriteAttributeValue("", 1727, "/Member/Details/", 1727, 16, true);
#nullable restore
#line 43 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
WriteAttributeValue("", 1743, item.LastName, 1743, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Details\"><i class=\"fas fa-edit\">Details</i></a><br>\r\n\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 48 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { name = item.LastName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.DateOfBirth.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item.isGraduate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item._StarDate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
                   Write(item._EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 64 "C:\Users\ASUS\OneDrive\Documents\GitHub\FormASPdotNetMVC\ASPdotNETcore\Views\Member\ListDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPdotNETcore.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
