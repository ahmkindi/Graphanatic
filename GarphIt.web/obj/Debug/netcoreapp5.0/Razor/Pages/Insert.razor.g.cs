#pragma checksum "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4c17004892c24175e1ced40dee80491c610e2f"
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
using GraphIt.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
using Syncfusion.Blazor.Navigations.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\_Imports.razor"
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
            __builder.AddAttribute(1, "class", "btn-group-toggle border-right border-dark mr-md-2");
            __builder.AddAttribute(2, "data-toggle", "buttons");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "btn" + " " + (
#nullable restore
#line 20 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                       NodeCss

#line default
#line hidden
#nullable disable
            ) + " shadow-none" + " border-right");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                   UpdateInsertNode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<input type=\"checkbox\" autocomplete=\"off\"> Node\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "label");
            __builder.AddAttribute(9, "class", "btn" + " " + (
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                       EdgeCss

#line default
#line hidden
#nullable disable
            ) + " shadow-none");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                      UpdateInsertEdge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "<input type=\"checkbox\" autocomplete=\"off\"> Edge\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "NavNone dropdown");
            __builder.AddMarkupContent(15, "<button class=\"btn shadow-none dropdown-toggle\" id=\"common\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n        Common Graphs\r\n    </button>\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "dropdown-menu");
            __builder.AddAttribute(18, "aria-labelledby", "common");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "dropdown-item");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Cyclic)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Single Cyclic");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "dropdown-item");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Tree)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Tree (straight line)");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "dropdown-item");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Complete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Clique");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "dropdown-item");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.Star)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Star");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "dropdown-item");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.RBipartite)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Regular Bipartite");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "dropdown-item");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                           (() => WantedGraph = CommonGraph.CBipartite)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Complete Bipartite");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (WantedGraph != null && !Loading)
{
    string Klabel = "Nodes: ";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
     if (WantedGraph == CommonGraph.CBipartite)
    {
        Klabel = "Left Nodes: ";
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(48);
            __builder.AddAttribute(49, "Width", "300px");
            __builder.AddAttribute(50, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(52);
                __builder2.AddAttribute(53, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "container");
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "row");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col d-flex justify-content-center");
                    __builder3.AddContent(60, 
#nullable restore
#line 55 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                             Klabel

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(61, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(62);
                    __builder3.AddAttribute(63, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 56 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                  1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 56 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                         1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "CssClass", "shortInput shadow-none");
                    __builder3.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 56 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                                         numNodes

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => numNodes = __value, numNodes))));
                    __builder3.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int?>>>(() => numNodes));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n                    ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "row");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "col d-flex justify-content-center my-3 border-bottom border-dark");
#nullable restore
#line 61 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                             if (WantedGraph == CommonGraph.CBipartite)
                            {
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(74, 
#nullable restore
#line 63 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                  "Right Nodes: "

#line default
#line hidden
#nullable disable
                    );
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(75);
                    __builder3.AddAttribute(76, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 64 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                      1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 64 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                             1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "CssClass", "shortInput");
                    __builder3.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 64 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                                 KValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => KValue = __value, KValue))));
                    __builder3.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int?>>>(() => KValue));
                    __builder3.CloseComponent();
#nullable restore
#line 65 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                            }
                            else if (WantedGraph == CommonGraph.RBipartite)
                            {
                                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(82, 
#nullable restore
#line 68 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                  "Degree (k): "

#line default
#line hidden
#nullable disable
                    );
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(83);
                    __builder3.AddAttribute(84, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 69 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                      1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 69 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                             1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "CssClass", "shortInput");
                    __builder3.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 69 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                                 KValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => KValue = __value, KValue))));
                    __builder3.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int?>>>(() => KValue));
                    __builder3.CloseComponent();
#nullable restore
#line 70 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n                        ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "d-flex align-items-baseline");
                    __builder3.OpenElement(93, "button");
                    __builder3.AddAttribute(94, "class", "btn btn-outline-success shadow-none btn-sm");
                    __builder3.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                 CreateGraph

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(96, "\r\n                                Done\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\r\n                            ");
                    __builder3.OpenElement(98, "button");
                    __builder3.AddAttribute(99, "class", "ml-auto btn btn-outline-dark shadow-none btn-sm");
                    __builder3.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                                      (() => WantedGraph = null)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(101, "\r\n                                Cancel\r\n                            ");
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
#line 85 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
 if (ErrorCreatingGraph != "")
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(102);
            __builder.AddAttribute(103, "Width", "300px");
            __builder.AddAttribute(104, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 88 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(106);
                __builder2.AddAttribute(107, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "container text-center");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "row");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "col d-flex justify-content-center my-3 border-bottom border-dark");
                    __builder3.AddContent(114, 
#nullable restore
#line 94 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                             ErrorCreatingGraph

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\r\n                    ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "row");
                    __builder3.OpenElement(118, "div");
                    __builder3.AddAttribute(119, "class", "col d-flex justify-content-center");
                    __builder3.OpenElement(120, "button");
                    __builder3.AddAttribute(121, "class", "btn btn-outline-dark shadow-none btn-sm");
                    __builder3.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
                                                                                              (() => ErrorCreatingGraph = "")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(123, "\r\n                                OK\r\n                            ");
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
#line 108 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\Insert.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
