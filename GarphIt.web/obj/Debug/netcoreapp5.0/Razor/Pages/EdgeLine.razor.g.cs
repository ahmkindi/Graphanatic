#pragma checksum "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d36cdd9e6a163455620c7298531da0bfa8bac83"
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
#line 1 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using GraphIt.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using GraphIt.web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using GraphIt.web.Pages.Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using GraphIt.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using BlazorPro.BlazorSize;

#line default
#line hidden
#nullable disable
    public partial class EdgeLine : EdgeLineBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "g");
            __builder.AddAttribute(1, "class", "pointer");
            __builder.AddAttribute(2, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                 OnMouseDown

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "path");
            __builder.AddAttribute(4, "id", 
#nullable restore
#line 5 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
               Edge.EdgeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "d", 
#nullable restore
#line 5 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                ShowEdge.Path

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "stroke-width", 
#nullable restore
#line 5 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                              Edge.Width

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "stroke", 
#nullable restore
#line 5 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                   Edge.EdgeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "marker-end", "url(#" + (
#nullable restore
#line 6 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                             "arrowhead"+Edge.EdgeId

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(9, "fill", "none");
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 6 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                            ActiveEdgeCss

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "text");
            __builder.AddAttribute(13, "text-anchor", "middle");
            __builder.AddAttribute(14, "font-size", 
#nullable restore
#line 7 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                           ShowEdge.FontSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "fill", 
#nullable restore
#line 7 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                     Edge.LabelColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "dy", 
#nullable restore
#line 7 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                           ShowEdge.Yoffset

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "rotate", 
#nullable restore
#line 7 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                                                      ShowEdge.Rotate

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(18, "textPath");
            __builder.AddAttribute(19, "href", 
#nullable restore
#line 8 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                          "#"+Edge.EdgeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "startOffset", "50%");
            __builder.AddContent(21, 
#nullable restore
#line 8 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                               ShowEdge.Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
     if (DefaultOptions.Weighted)
    {
        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "text");
            __builder.AddAttribute(23, "text-anchor", "middle");
            __builder.AddAttribute(24, "font-size", 
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                   ShowEdge.FontSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "fill", 
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                             Edge.EdgeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "dy", "-" + (
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                                   Edge.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "rotate", 
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                                                        ShowEdge.Rotate

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(28, "textPath");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 15 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                  "#"+Edge.EdgeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "startOffset", "50%");
            __builder.AddContent(31, 
#nullable restore
#line 15 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                       ShowEdge.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
               
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
     if (DefaultOptions.Directed)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "defs");
            __builder.OpenElement(33, "marker");
            __builder.AddAttribute(34, "id", 
#nullable restore
#line 22 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                          "arrowhead"+Edge.EdgeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "markerWidth", 
#nullable restore
#line 22 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                  ShowEdge.EdgeArrow.Width

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "markerHeight", 
#nullable restore
#line 22 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                                           ShowEdge.EdgeArrow.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "refX", 
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                           ShowEdge.EdgeArrow.ArrowOffset[0]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "refY", 
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                     ShowEdge.EdgeArrow.ArrowOffset[1]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "orient", "auto");
            __builder.OpenElement(40, "polygon");
            __builder.AddAttribute(41, "points", 
#nullable restore
#line 24 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                  $"{ShowEdge.EdgeArrow.Points[0]} {ShowEdge.EdgeArrow.Points[1]}, " +
                                  $"{ShowEdge.EdgeArrow.Points[2]} {ShowEdge.EdgeArrow.Points[3]}, " +
                                  $"{ShowEdge.EdgeArrow.Points[4]} {ShowEdge.EdgeArrow.Points[5]}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "fill", 
#nullable restore
#line 26 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
                                                                                                            Edge.EdgeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeLine.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
