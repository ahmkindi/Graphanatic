#pragma checksum "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e1584357ddfc40fb3fd08c1d3a20adaa7d7ae4"
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
    public partial class AlgoNodeCircle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "text");
            __builder.AddAttribute(1, "x", 
#nullable restore
#line 1 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
          AlgorithmNode.Node.Xaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "y", 
#nullable restore
#line 2 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
           AlgorithmNode.Node.Yaxis-AlgorithmNode.Node.Radius-10

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "text-anchor", "middle");
            __builder.AddContent(4, 
#nullable restore
#line 3 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                            AlgorithmNode.Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "g");
            __builder.AddAttribute(7, "id", 
#nullable restore
#line 4 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
        AlgorithmNode.Node.NodeId

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(8, "circle");
            __builder.AddAttribute(9, "cx", 
#nullable restore
#line 5 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                 AlgorithmNode.Node.Xaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "cy", 
#nullable restore
#line 6 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                 AlgorithmNode.Node.Yaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "r", 
#nullable restore
#line 7 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                AlgorithmNode.Node.Radius

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "stroke", 
#nullable restore
#line 8 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                     AlgorithmNode.Node.NodeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "stroke-width", "2");
            __builder.AddAttribute(14, "fill", 
#nullable restore
#line 10 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                   AlgorithmNode.Node.NodeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "text");
            __builder.AddAttribute(17, "text-anchor", "middle");
            __builder.AddAttribute(18, "fill", 
#nullable restore
#line 12 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                 AlgorithmNode.Node.LabelColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "stroke", 
#nullable restore
#line 13 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                   AlgorithmNode.Node.NodeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "stroke-width", "1");
            __builder.AddAttribute(21, "font-size", 
#nullable restore
#line 15 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
                       AlgorithmNode.Node.Radius/2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "font-family", "Verdana");
            __builder.AddAttribute(23, "x", 
#nullable restore
#line 17 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
              AlgorithmNode.Node.Xaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "y", 
#nullable restore
#line 18 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
              AlgorithmNode.Node.Yaxis

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, 
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
         AlgorithmNode.Node.Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AlgoNodeCircle.razor"
      
    [Parameter] public AlgorithmNode AlgorithmNode { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
