#pragma checksum "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b50575f8d6c4029ef22781c3ef535c4af857399"
// <auto-generated/>
#pragma warning disable 1591
namespace GraphIt.web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using GraphIt.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using GraphIt.web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using GraphIt.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using BlazorPro.BlazorSize;

#line default
#line hidden
#nullable disable
    public partial class Home : HomeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar sticky-top navbar-expand navbar-custom py-0 px-0");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "dropdown px-1");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<button class=\"btn shadow-none NavNone dropdown-toggle\" type=\"button\" id=\"repre\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                Representations\r\n            </button>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "dropdown-menu");
            __builder.AddAttribute(12, "aria-labelledby", "repre");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "dropdown-item");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Home.razor"
                                                   OnMatrixClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Adjacency Matrix");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "dropdown-item");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Home.razor"
                                                   OnWeightMatrixClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Weighted Matrix");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, @"<div class=""dropdown px-1"">
            <button class=""btn shadow-none NavNone dropdown-toggle"" type=""button"" id=""saveas"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Save As
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""saveas"">
                <a class=""dropdown-item"">PNG</a>
                <a class=""dropdown-item"">Graph File</a>
            </div>
        </div>
        ");
            __builder.AddMarkupContent(27, "<div class=\"px-1\">\r\n            <button class=\"btn shadow-none NavNone\" type=\"button\">\r\n                Open\r\n            </button>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591