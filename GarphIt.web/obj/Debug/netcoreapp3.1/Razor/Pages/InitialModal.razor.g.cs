#pragma checksum "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\InitialModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4064d4776eb94a06a26070700bd4cd6f640c7966"
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
    public partial class InitialModal : InitialModalBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "300px");
            __builder.AddAttribute(2, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\InitialModal.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(5);
                __builder2.AddAttribute(6, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n            ");
                    __builder3.AddMarkupContent(8, "<div class=\"col px-2 text-center lead\">\r\n                Welcome to GraphIt\r\n            </div>\r\n            ");
                    __builder3.AddMarkupContent(9, @"<div class=""text-center text-justify"">
                To get started specify some of feature of your graph, this will make it easier for you when creating the graph.
                If your unsure what you want you can skip this step and change the graph type later. If you skip the default
                will be undirected and unweighted edges.
            </div>
            ");
                    __builder3.OpenElement(10, "div");
                    __builder3.AddAttribute(11, "class", "d-inline-flex justify-content-center");
                    __builder3.AddMarkupContent(12, "\r\n                ");
                    __builder3.AddMarkupContent(13, "<p>Unweighted</p>\r\n                ");
                    __builder3.OpenElement(14, "label");
                    __builder3.AddAttribute(15, "class", "switch");
                    __builder3.AddMarkupContent(16, "\r\n                    ");
                    __builder3.OpenElement(17, "input");
                    __builder3.AddAttribute(18, "type", "checkbox");
                    __builder3.AddAttribute(19, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\InitialModal.razor"
                                                  GraphType.Weighted

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GraphType.Weighted = __value, GraphType.Weighted));
                    __builder3.SetUpdatesAttributeName("checked");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\r\n                    <span class=\"slider round\"></span>\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(22, "\r\n                ");
                    __builder3.AddMarkupContent(23, "<p>Wighted</p>\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "d-inline-flex justify-content-center");
                    __builder3.AddMarkupContent(27, "\r\n                ");
                    __builder3.AddMarkupContent(28, "<p>Undirected</p>\r\n                ");
                    __builder3.OpenElement(29, "label");
                    __builder3.AddAttribute(30, "class", "switch");
                    __builder3.AddMarkupContent(31, "\r\n                    ");
                    __builder3.OpenElement(32, "input");
                    __builder3.AddAttribute(33, "type", "checkbox");
                    __builder3.AddAttribute(34, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\InitialModal.razor"
                                                  GraphType.Directed

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GraphType.Directed = __value, GraphType.Directed));
                    __builder3.SetUpdatesAttributeName("checked");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\r\n                    <span class=\"slider round\"></span>\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __builder3.AddMarkupContent(38, "<p>Directed</p>\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "d-flex justify-content-around");
                    __builder3.AddMarkupContent(42, "\r\n                ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "p-2");
                    __builder3.AddMarkupContent(45, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(46);
                    __builder3.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\InitialModal.razor"
                                        OnSkipClick

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "CssClass", "e-outline");
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(50, "Skip");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n                ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "p-2");
                    __builder3.AddMarkupContent(55, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(56);
                    __builder3.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\InitialModal.razor"
                                        OnDoneClick

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "CssClass", "e-outline");
                    __builder3.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(60, "Done");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591