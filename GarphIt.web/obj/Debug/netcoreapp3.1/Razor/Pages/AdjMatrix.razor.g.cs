#pragma checksum "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "612c1f1cd51f5f8d22bff5a0c312e1860b8acb91"
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
    public partial class AdjMatrix : AdjMatrixBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Target", "#target");
            __builder.AddAttribute(2, "Width", "350px");
            __builder.AddAttribute(3, "AllowDragging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(6);
                __builder2.AddAttribute(7, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, " Adjacency Matrix ");
                }
                ));
                __builder2.AddAttribute(9, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
             if (Nodes == null)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(11, "                ");
                    __builder3.AddMarkupContent(12, "<div class=\"spinner-border\" role=\"status\">\r\n                    <span class=\"sr-only\">Loading...</span>\r\n                </div>\r\n");
#nullable restore
#line 12 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(13, "                ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "table-responsive");
                    __builder3.AddMarkupContent(16, "\r\n                    ");
                    __builder3.OpenElement(17, "table");
                    __builder3.AddAttribute(18, "class", "table table-sm table-bordered table-striped");
                    __builder3.AddMarkupContent(19, "\r\n                        ");
                    __builder3.OpenElement(20, "thead");
                    __builder3.AddMarkupContent(21, "\r\n                            ");
                    __builder3.OpenElement(22, "tr");
                    __builder3.AddMarkupContent(23, "\r\n                                ");
                    __builder3.AddMarkupContent(24, "<th scope=\"col\">Node ID</th>\r\n");
#nullable restore
#line 20 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                 foreach (Node node in Nodes)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(25, "                                    ");
                    __builder3.OpenElement(26, "th");
                    __builder3.AddAttribute(27, "scope", "col");
                    __builder3.AddContent(28, 
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                     node.NodeId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n");
#nullable restore
#line 23 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(30, "                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                        ");
                    __builder3.OpenElement(33, "tbody");
                    __builder3.AddMarkupContent(34, "\r\n");
#nullable restore
#line 27 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                             foreach (Node node in Nodes)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(35, "                                ");
                    __builder3.OpenElement(36, "tr");
                    __builder3.AddMarkupContent(37, "\r\n                                    ");
                    __builder3.OpenElement(38, "th");
                    __builder3.AddAttribute(39, "scope", "row");
                    __builder3.AddContent(40, 
#nullable restore
#line 30 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                     node.NodeId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n");
#nullable restore
#line 31 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                     foreach (Node _ in Nodes)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(42, "                                        ");
                    __builder3.AddMarkupContent(43, "<td>Edit Me</td>\r\n");
#nullable restore
#line 34 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(44, "                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n");
#nullable restore
#line 36 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, "                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n");
#nullable restore
#line 40 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(50, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(52);
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(54, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(55);
                    __builder3.AddAttribute(56, "Content", "Close");
                    __builder3.AddAttribute(57, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\AdjMatrix.razor"
                                                CloseMatrix

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
