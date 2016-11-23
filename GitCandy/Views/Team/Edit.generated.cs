﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GitCandy;
    using GitCandy.App_GlobalResources;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Team/Edit.cshtml")]
    public partial class _Views_Team_Edit_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.TeamModel>
    {
        public _Views_Team_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Team\Edit.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, String.Format(SR.Team_EditTitle, Model.Name));
    var token = GitCandy.Security.Token.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h3>");

            
            #line 8 "..\..\Views\Team\Edit.cshtml"
Write(String.Format(SR.Team_EditTitle, Model.Name));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n\r\n");

            
            #line 11 "..\..\Views\Team\Edit.cshtml"
 using (Html.BeginForm("Edit", "Team", FormMethod.Post))
{

            
            #line default
            #line hidden
WriteLiteral("    <dl");

WriteLiteral(" class=\"dl-horizontal col-md-8\"");

WriteLiteral(">\r\n        <dt>");

            
            #line 14 "..\..\Views\Team\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.Name));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Views\Team\Edit.cshtml"
       Write(Html.HiddenFor(s => s.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\Team\Edit.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 20 "..\..\Views\Team\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.Nickname));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 21 "..\..\Views\Team\Edit.cshtml"
       Write(Html.TextBoxFor(s => s.Nickname, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n        <dd>\r\n            <span");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 24 "..\..\Views\Team\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Nickname));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n        </dd>\r\n\r\n        <dt>");

            
            #line 28 "..\..\Views\Team\Edit.cshtml"
       Write(Html.DisplayNameFor(s => s.Description));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 29 "..\..\Views\Team\Edit.cshtml"
       Write(Html.TextAreaFor(s => s.Description, 4, 0, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n        <dd>\r\n            <span");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Views\Team\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n        </dd>\r\n\r\n        <dt></dt>\r\n        <dd>");

            
            #line 37 "..\..\Views\Team\Edit.cshtml"
       Write(Html.ValidationSummary(true, SR.Team_UpdateUnsuccessfull, new { @class = "alert alert-dismissable alert-danger" }));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\Team\Edit.cshtml"
       Write(Html.ActionLink(SR.Shared_Back, "Detail", new { Model.Name }, new { @class = "btn btn-default pull-left" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Team\Edit.cshtml"
                                                     Write(SR.Shared_Save);

            
            #line default
            #line hidden
WriteLiteral("</button> &nbsp;\r\n            <button");

WriteLiteral(" type=\"reset\"");

WriteLiteral(" class=\"btn btn-inverse\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Team\Edit.cshtml"
                                                    Write(SR.Shared_Reset);

            
            #line default
            #line hidden
WriteLiteral("</button> &nbsp;\r\n");

            
            #line 45 "..\..\Views\Team\Edit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Team\Edit.cshtml"
             if (token != null && token.IsSystemAdministrator)
            {
                
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Team\Edit.cshtml"
           Write(Html.ActionLink(SR.Shared_Delete, "Delete", new { Model.Name }, new { @class = "btn btn-danger" }));

            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Team\Edit.cshtml"
                                                                                                                   
            }

            
            #line default
            #line hidden
WriteLiteral("        </dd>\r\n    </dl>\r\n");

            
            #line 51 "..\..\Views\Team\Edit.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
