#pragma checksum "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecc3a04602400936dd7f0ac5dc3a48ae9716f476"
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
    public partial class AdjMatrix : AdjMatrixBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "400px");
            __builder.AddAttribute(2, "Height", "400px");
            __builder.AddAttribute(3, "AllowDragging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(5);
                __builder2.AddAttribute(6, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 6 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
             if (Rep == Representation.Matrix)
            {
                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(7, 
#nullable restore
#line 8 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                  "Adjacency Matrix"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 8 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                     
            }
            else
            {
                

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(8, 
#nullable restore
#line 12 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                  "Weighted Adjacency Matrix"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 12 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                              
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(9, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 16 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
             if (Nodes == null || Edges == null)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(10, "<div class=\"spinner-border\" role=\"status\"><span class=\"sr-only\">Loading...</span></div>");
#nullable restore
#line 21 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
            }
            else if (TextView)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(11);
                    __builder3.AddAttribute(12, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Placeholder", "Add Nodes by typing 0, 1");
                    __builder3.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                           ShowText

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                                                OnChangeText

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 26 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                 if (!ValidInput)
                {
                    if (Rep == Representation.Matrix)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(16, "<div class=\"text-danger\">There was formatting error: please input only a sqaure matrix of either 0, 1 comma seperated</div>");
#nullable restore
#line 31 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(17, "<div class=\"text-danger\">There was formatting error, please input only a square matrix of decimal numbers upto 2 decimal places, comma seperated</div>");
#nullable restore
#line 35 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                    }

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "table-responsive");
                    __builder3.OpenElement(20, "table");
                    __builder3.AddAttribute(21, "class", "table table-bordered");
                    __builder3.OpenElement(22, "thead");
                    __builder3.OpenElement(23, "tr");
                    __builder3.OpenElement(24, "th");
                    __builder3.AddAttribute(25, "scope", "col");
                    __builder3.AddMarkupContent(26, "Node \r\n                                ");
                    __builder3.OpenElement(27, "button");
                    __builder3.AddAttribute(28, "class", "btn btn-sm font-small p-1 shadow-none btn-success oi oi-plus");
                    __builder3.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                  (async() => { NodeService.AddNode(Nodes, DefaultOptions, GetRandom(true), GetRandom(false)); await NodesChanged.InvokeAsync(Nodes); })

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 48 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                 foreach (Node node in Nodes)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(30, "th");
                    __builder3.AddAttribute(31, "scope", "col");
                    __builder3.AddContent(32, 
#nullable restore
#line 50 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                     node.Label

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 51 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n                        ");
                    __builder3.OpenElement(34, "tbody");
#nullable restore
#line 55 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                             foreach (Node tail in Nodes)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(35, "tr");
                    __builder3.OpenElement(36, "th");
                    __builder3.AddAttribute(37, "scope", "row");
                    __builder3.AddContent(38, 
#nullable restore
#line 59 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                     tail.Label

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(39, "\r\n                                    ");
                    __builder3.OpenElement(40, "button");
                    __builder3.AddAttribute(41, "class", "btn btn-sm font-small p-1 btn-danger shadow-none oi oi-trash");
                    __builder3.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                                                           () => OnTableDelete(tail)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 62 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                 foreach (Node head in Nodes)
                                {
                                    Edge edge = Adjacent(tail, head);

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(43, "td");
                    __builder3.AddAttribute(44, "class", "p-0 m-0");
#nullable restore
#line 66 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                 if (edge != null)
                                {
                                    if (Rep == Representation.Matrix)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(45);
                    __builder3.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 70 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                               1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 70 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 70 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                            1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ShowSpinButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 70 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                                             false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "CssClass", "shortInput");
                    __builder3.AddAttribute(51, "Placeholder", "Adjacent");
                    __builder3.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                            ((e) => OnChangeTable(e, tail, head))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 72 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __Blazor.GraphIt.web.Pages.AdjMatrix.TypeInference.CreateSfNumericTextBox_0(__builder3, 53, 54, 
#nullable restore
#line 75 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                  edge.Weight

#line default
#line hidden
#nullable disable
                    , 55, 
#nullable restore
#line 75 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                   0

#line default
#line hidden
#nullable disable
                    , 56, 
#nullable restore
#line 75 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                                    false

#line default
#line hidden
#nullable disable
                    , 57, "shortInput", 58, "Adjacent", 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                            ((e) => OnChangeTable(e, tail, head))

#line default
#line hidden
#nullable disable
                    ));
#nullable restore
#line 77 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                    }
                                }
                                else
                                {
                                    if (Rep == Representation.Matrix)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(60);
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 83 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                               0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 83 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 83 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                            1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "ShowSpinButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                                             false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "CssClass", "shortInput");
                    __builder3.AddAttribute(66, "Placeholder", "Adjacent");
                    __builder3.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                            ((e) => OnChangeTable(e, tail, head))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 85 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                    __Blazor.GraphIt.web.Pages.AdjMatrix.TypeInference.CreateSfNumericTextBox_1(__builder3, 68, 69, 
#nullable restore
#line 88 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                 0

#line default
#line hidden
#nullable disable
                    , 70, 
#nullable restore
#line 88 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                        0

#line default
#line hidden
#nullable disable
                    , 71, 
#nullable restore
#line 88 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                         false

#line default
#line hidden
#nullable disable
                    , 72, "shortInput", 73, "Adjacent", 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                                                            ((e) => OnChangeTable(e, tail, head))

#line default
#line hidden
#nullable disable
                    ));
#nullable restore
#line 90 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                    }


                                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 95 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 97 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 101 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 105 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
         if (TextView)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(78);
                    __builder3.AddAttribute(79, "Content", "Table View");
                    __builder3.AddAttribute(80, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                        (() => TextView = !TextView)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(82);
                    __builder3.AddAttribute(83, "Content", "Close");
                    __builder3.AddAttribute(84, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                    CloseMatrix

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
#nullable restore
#line 109 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(85);
                    __builder3.AddAttribute(86, "Content", "Text View");
                    __builder3.AddAttribute(87, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                       (() => TextView = !TextView)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(89);
                    __builder3.AddAttribute(90, "Content", "Close");
                    __builder3.AddAttribute(91, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                    CloseMatrix

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
#nullable restore
#line 114 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\AdjMatrix.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.GraphIt.web.Pages.AdjMatrix
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfNumericTextBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, TValue __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Object __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Min", __arg1);
        __builder.AddAttribute(__seq2, "ShowSpinButton", __arg2);
        __builder.AddAttribute(__seq3, "CssClass", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "onchange", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, TValue __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Object __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Min", __arg1);
        __builder.AddAttribute(__seq2, "ShowSpinButton", __arg2);
        __builder.AddAttribute(__seq3, "CssClass", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "onchange", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
