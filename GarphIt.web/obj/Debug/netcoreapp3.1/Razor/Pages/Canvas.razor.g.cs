#pragma checksum "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3e0c0166b65c3df18d23babeb0736f85c94139"
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
using Syncfusion.Blazor.Navigations.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\_Imports.razor"
using BlazorPro.BlazorSize;

#line default
#line hidden
#nullable disable
    public partial class Canvas : CanvasBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.GraphIt.web.Pages.Canvas.TypeInference.CreateSfContextMenu_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                       ContextMenus.NodeItems

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.MenuEvents<MenuItem>>(4);
                __builder2.AddAttribute(5, "ItemSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.MenuEventArgs<MenuItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.MenuEventArgs<MenuItem>>(this, 
#nullable restore
#line 4 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                 Select

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n");
            }
            , 7, (__value) => {
#nullable restore
#line 3 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                     ContextMenus.NodeMenu = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(8, "\r\n");
            __Blazor.GraphIt.web.Pages.Canvas.TypeInference.CreateSfContextMenu_1(__builder, 9, 10, 
#nullable restore
#line 6 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                       ContextMenus.CanvasItems

#line default
#line hidden
#nullable disable
            , 11, (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.MenuEvents<MenuItem>>(13);
                __builder2.AddAttribute(14, "ItemSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.MenuEventArgs<MenuItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.MenuEventArgs<MenuItem>>(this, 
#nullable restore
#line 7 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                 Select

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n");
            }
            , 16, (__value) => {
#nullable restore
#line 6 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                       ContextMenus.CanvasMenu = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(17, "\r\n");
            __Blazor.GraphIt.web.Pages.Canvas.TypeInference.CreateSfContextMenu_2(__builder, 18, 19, 
#nullable restore
#line 9 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                       ContextMenus.EdgeItems

#line default
#line hidden
#nullable disable
            , 20, (__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.MenuEvents<MenuItem>>(22);
                __builder2.AddAttribute(23, "ItemSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.MenuEventArgs<MenuItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.MenuEventArgs<MenuItem>>(this, 
#nullable restore
#line 10 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                 Select

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n");
            }
            , 25, (__value) => {
#nullable restore
#line 9 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                     ContextMenus.EdgeMenu = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenElement(27, "svg");
            __builder.AddAttribute(28, "viewBox", (
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
               SVGControl.Xaxis

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                 SVGControl.Yaxis

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                    (int)((double)Browser.Width*SVGControl.Scale)

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 13 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                     (int)((double)Browser.Height*SVGControl.Scale)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "tabindex", "0");
            __builder.AddAttribute(30, "class", 
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                          SvgClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                   OnMove

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                         OnMouseDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                                OnKeyUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "oncontextmenu", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                     OnRightClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(35, "oncontextmenu", 
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                    OnMouseUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onmousewheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                              OnScroll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onwheel", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.WheelEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                                                  OnScroll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(39, (__value) => {
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                          svgCanvas = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 16 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
     if (Nodes != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
         if (Edges != null)
        {
            foreach (Edge edge in Edges)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                ");
            __builder.OpenComponent<GraphIt.web.Pages.EdgeLine>(42);
            __builder.AddAttribute(43, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Edge>(
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                edge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ActiveNode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Node>(
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                  ActiveNode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ActiveEdge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Edge>(
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                          ActiveEdge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "OnEdgeClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GraphIt.models.Edge>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GraphIt.models.Edge>(this, 
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                   OnEdgeClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(47, "OnEdgeRightClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GraphIt.models.Edge>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GraphIt.models.Edge>(this, 
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                                                  OnEdgeRightClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(48, "DefaultOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.DefaultOptions>(
#nullable restore
#line 22 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                                                                                    DefaultOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 23 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
         
        foreach (Node node in Nodes)
        {

            if ((ActiveNode != null && node.NodeId == ActiveNode.NodeId))
            {
                continue;
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "            ");
            __builder.OpenComponent<GraphIt.web.Pages.NodeCircle>(51);
            __builder.AddAttribute(52, "Node", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Node>(
#nullable restore
#line 32 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                              node

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "ActiveNode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Node>(
#nullable restore
#line 32 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                ActiveNode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "OnNodeClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GraphIt.models.Node>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GraphIt.models.Node>(this, 
#nullable restore
#line 32 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                         OnNodeClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(55, "OnNodeRightClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GraphIt.models.Node>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GraphIt.models.Node>(this, 
#nullable restore
#line 32 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                        OnNodeRightClick

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 33 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
        }
        if (ActiveNode != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "            ");
            __builder.OpenComponent<GraphIt.web.Pages.NodeCircle>(58);
            __builder.AddAttribute(59, "Node", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Node>(
#nullable restore
#line 36 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                              ActiveNode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "ActiveNode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GraphIt.models.Node>(
#nullable restore
#line 36 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                      ActiveNode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "OnNodeClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GraphIt.models.Node>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GraphIt.models.Node>(this, 
#nullable restore
#line 36 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                               OnNodeClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(62, "OnNodeRightClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GraphIt.models.Node>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GraphIt.models.Node>(this, 
#nullable restore
#line 36 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                              OnNodeRightClick

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 37 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 40 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
 if (NewEdge.GetEdgeWeight)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(66);
            __builder.AddAttribute(67, "Width", "300px");
            __builder.AddAttribute(68, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(71);
                __builder2.AddAttribute(72, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(73, "\r\n                ");
                    __Blazor.GraphIt.web.Pages.Canvas.TypeInference.CreateSfNumericTextBox_3(__builder3, 74, 75, 
#nullable restore
#line 45 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                      1

#line default
#line hidden
#nullable disable
                    , 76, "Edge Weight", 77, 
#nullable restore
#line 45 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                   FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                    , 78, 
#nullable restore
#line 45 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                                                                                     NewEdge.Weight

#line default
#line hidden
#nullable disable
                    , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewEdge.Weight = __value, NewEdge.Weight)), 80, () => NewEdge.Weight);
                    __builder3.AddMarkupContent(81, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(82);
                    __builder3.AddAttribute(83, "CssClass", "e-success");
                    __builder3.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                         (() => AddNewEdge(true))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(86, "Done");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(88);
                    __builder3.AddAttribute(89, "CssClass", "e-danger");
                    __builder3.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
                                                        (() => AddNewEdge(false))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(92, "Cancel");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 51 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Canvas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.GraphIt.web.Pages.Canvas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfContextMenu_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::System.Action<global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateSfContextMenu_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::System.Action<global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateSfContextMenu_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::System.Action<global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.AddComponentReferenceCapture(__seq2, (__value) => { __arg2((global::Syncfusion.Blazor.Navigations.SfContextMenu<TValue>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Syncfusion.Blazor.Inputs.FloatLabelType __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Min", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "FloatLabelType", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
