#pragma checksum "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d386d06a919e7afdd060d547ddf7b7ecf262b4"
// <auto-generated/>
#pragma warning disable 1591
namespace GameIndustry.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using GameIndustry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using GameIndustry.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using GameIndustry.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using GameIndustry.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Gitrepositories\BlazzorApp\GameIndustry\_Imports.razor"
using GameIndustry.Helpers;

#line default
#line hidden
#nullable disable
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
 if (PannelIsShown)
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "popUpModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "popUpModal");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display:block");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "dialog");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
#nullable restore
#line 14 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
__builder.AddContent(18, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                       ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
                                         OnConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "close bnt-danger");
            __builder.AddAttribute(24, "style", "color:red");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">\r\n                         &times;\r\n                     </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "modal-body");
#nullable restore
#line 23 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
__builder.AddContent(29, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-footer");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
                                      OnConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddMarkupContent(37, "\r\n                        Yes\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
                                      OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "class", "btn btn-primary");
            __builder.AddMarkupContent(43, "\r\n                        No\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\Gitrepositories\BlazzorApp\GameIndustry\Shared\Confirmation.razor"
       
    [Parameter] public string Title { get; set; } = "Confirmation";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    bool PannelIsShown { get; set; } = false;
    public void ShowPanel() => PannelIsShown = true;
    public void HidePanel() => PannelIsShown = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591