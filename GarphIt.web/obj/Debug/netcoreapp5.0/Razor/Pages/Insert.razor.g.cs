#pragma checksum "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba8e6c37d1f45da49dc2e48b6d6a3e6450263676"
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
    public partial class Insert : InsertBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (InsertNode)
{
    NodeCss = "NavActive";
}
else
{
    NodeCss = "NavNone";
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (InsertEdge)
{
    EdgeCss = "NavActive";
}
else
{
    EdgeCss = "NavNone";
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", (
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
            NodeCss

#line default
#line hidden
#nullable disable
            ) + " p-2" + " border-right" + " border-dark");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                            UpdateInsertNode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Node");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "class", (
#nullable restore
#line 20 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
            EdgeCss

#line default
#line hidden
#nullable disable
            ) + " p-2" + " mr-1" + " border-right" + " border-dark");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                 UpdateInsertEdge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Edge");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "NavNone dropdown");
            __builder.AddMarkupContent(12, "<button class=\"btn shadow-none dropdown-toggle\" id=\"common\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n        Common Graphs\r\n    </button>\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "dropdown-menu");
            __builder.AddAttribute(15, "aria-labelledby", "common");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "dropdown-item");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Cyclic)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Single Cyclic");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "dropdown-item");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Tree)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Tree (straight line)");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "dropdown-item");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Complete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Clique");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "dropdown-item");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Star)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Star");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "dropdown-item");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.RBipartite)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Regular Bipartite");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "dropdown-item");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.CBipartite)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Complete Bipartite");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (GraphMode == GraphMode.InsertNode)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<li class=\"navbar-text font-weight-bold broder-left border-dark px-2\">Click To Add Node</li>");
#nullable restore
#line 38 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
}
else if (GraphMode == GraphMode.InsertEdge)
{
    if (NewEdge.WaitingForNode)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "NavNone p-2 broder-left border-right border-dark");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                               async () => await NewEdgeChanged.InvokeAsync(new NewEdge())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Change First Node");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<li class=\"navbar-text font-weight-bold px-2\">Choose Second Node</li>");
#nullable restore
#line 45 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "<li class=\"navbar-text font-weight-bold broder-left border-dark px-2\">Choose First Node</li>");
#nullable restore
#line 49 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
    }
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (WantedGraph != null && !Loading)
{
    string Klabel = "Nodes: ";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
     if (WantedGraph == CommonGraph.CBipartite)
    {
        Klabel = "Left Nodes: ";
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(53);
            __builder.AddAttribute(54, "Width", "300px");
            __builder.AddAttribute(55, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(57);
                __builder2.AddAttribute(58, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "container");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "class", "row");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col d-flex justify-content-center");
                    __builder3.AddContent(65, 
#nullable restore
#line 67 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                             Klabel

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(66, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(67);
                    __builder3.AddAttribute(68, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 68 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                  1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 68 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                         1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "CssClass", "shortInput shadow-none");
                    __builder3.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 68 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                                         numNodes

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => numNodes = __value, numNodes))));
                    __builder3.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int?>>>(() => numNodes));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col d-flex justify-content-center my-3 border-bottom border-dark");
#nullable restore
#line 73 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                             if (WantedGraph == CommonGraph.CBipartite)
                            {
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(79, 
#nullable restore
#line 75 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                  "Right Nodes: "

#line default
#line hidden
#nullable disable
                    );
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(80);
                    __builder3.AddAttribute(81, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 76 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                      1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 76 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                             1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "CssClass", "shortInput");
                    __builder3.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 76 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                                 KValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => KValue = __value, KValue))));
                    __builder3.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int?>>>(() => KValue));
                    __builder3.CloseComponent();
#nullable restore
#line 77 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                            }
                            else if (WantedGraph == CommonGraph.RBipartite)
                            {
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(87, 
#nullable restore
#line 80 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                  "Degree (k): "

#line default
#line hidden
#nullable disable
                    );
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(88);
                    __builder3.AddAttribute(89, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 81 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                      1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 81 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                             1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "CssClass", "shortInput");
                    __builder3.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 81 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                                 KValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => KValue = __value, KValue))));
                    __builder3.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int?>>>(() => KValue));
                    __builder3.CloseComponent();
#nullable restore
#line 82 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\r\n                    ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "d-flex align-items-baseline");
                    __builder3.OpenElement(98, "button");
                    __builder3.AddAttribute(99, "class", "btn btn-outline-success shadow-none btn-sm");
                    __builder3.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                             CreateGraph

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(101, "\r\n                            Done\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\r\n                        ");
                    __builder3.OpenElement(103, "button");
                    __builder3.AddAttribute(104, "class", "ml-auto btn btn-outline-dark shadow-none btn-sm");
                    __builder3.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                  (() => WantedGraph = null)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(106, "\r\n                            Cancel\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 97 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (ErrorCreatingGraph != "")
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(107);
            __builder.AddAttribute(108, "Width", "300px");
            __builder.AddAttribute(109, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 100 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(111);
                __builder2.AddAttribute(112, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "container text-center");
                    __builder3.OpenElement(115, "div");
                    __builder3.AddAttribute(116, "class", "row");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col d-flex justify-content-center my-3 border-bottom border-dark");
                    __builder3.AddContent(119, 
#nullable restore
#line 106 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                             ErrorCreatingGraph

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n                    ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "row");
                    __builder3.OpenElement(123, "div");
                    __builder3.AddAttribute(124, "class", "col d-flex justify-content-center");
                    __builder3.OpenElement(125, "button");
                    __builder3.AddAttribute(126, "class", "btn btn-outline-dark shadow-none btn-sm");
                    __builder3.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                              (() => ErrorCreatingGraph = "")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(128, "\r\n                                OK\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 120 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
