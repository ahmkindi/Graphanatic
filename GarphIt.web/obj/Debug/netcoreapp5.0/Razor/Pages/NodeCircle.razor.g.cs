#pragma checksum "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035ad310ea6e9463c68e7660ec15c162a430f212"
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
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using GraphIt.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using GraphIt.web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using GraphIt.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using BlazorPro.BlazorSize;

#line default
#line hidden
#nullable disable
    public partial class NodeCircle : NodeCircleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "g");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 3 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
           NodeCss

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "id", 
#nullable restore
#line 4 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
        Node.NodeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                 OnMouseDown

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(4, "circle");
            __builder.AddAttribute(5, "cx", 
#nullable restore
#line 6 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                 Node.Xaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "cy", 
#nullable restore
#line 7 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                 Node.Yaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "r", 
#nullable restore
#line 8 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                Node.Radius

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "stroke", 
#nullable restore
#line 9 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                     Node.NodeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "stroke-width", "2");
            __builder.AddAttribute(10, "fill", 
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                   Node.NodeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "text");
            __builder.AddAttribute(13, "text-anchor", "middle");
            __builder.AddAttribute(14, "fill", 
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                 Node.LabelColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "stroke", 
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                   Node.NodeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "stroke-width", "1");
            __builder.AddAttribute(17, "font-size", 
#nullable restore
#line 16 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                       Node.Radius/2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "font-family", "Verdana");
            __builder.AddAttribute(19, "x", 
#nullable restore
#line 18 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
              Node.Xaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "y", 
#nullable restore
#line 19 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
              Node.Yaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
     Node.Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
 if (Active)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "rect");
            __builder.AddAttribute(23, "x", 
#nullable restore
#line 26 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
               Node.Xaxis-Node.Radius

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "y", 
#nullable restore
#line 27 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
               Node.Yaxis-Node.Radius

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "width", 
#nullable restore
#line 28 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                   Node.Radius*2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "height", 
#nullable restore
#line 29 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
                    Node.Radius*2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "stroke", "black");
            __builder.AddAttribute(28, "stroke-dasharray", "5,5");
            __builder.AddAttribute(29, "fill", "none");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\NodeCircle.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
