#pragma checksum "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3deab607b93a76ea2b0c7d775b1a40a7ebd467d"
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
    public partial class Design : DesignBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar sticky-top navbar-expand navbar-custom py-0 px-0");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "text-center col-md-6 border-right border-dark");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-md-flex flex-row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"font-weight-bold text-left\">\r\n                Default Node:\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "px-2");
            __builder.AddMarkupContent(12, "\r\n                Radius ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(13);
            __builder.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 10 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                               DefaultDesign.NodeRadius

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "CssClass", "radius");
            __builder.AddAttribute(16, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                             10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                    100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                             1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Format", "###");
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                       ((e) => OnDefRadiusChange(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "px-2");
            __builder.AddMarkupContent(25, "\r\n                Color ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(26);
            __builder.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                             DefaultDesign.NodeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                   OnDefNodeColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "px-2");
            __builder.AddMarkupContent(33, "\r\n                Label ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(34);
            __builder.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                             DefaultDesign.NodeLabelColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                        OnDefNodeLabelColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 20 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
         if (ActiveNode != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "d-md-flex flex-row");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<div class=\"font-weight-bold text-left\">\r\n                    Current Node:\r\n                </div>\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "px-2");
            __builder.AddMarkupContent(47, "\r\n                    Radius ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfNumericTextBox<int?>>(48);
            __builder.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 27 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                   ActiveNode.Radius

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 27 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                          10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 27 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                                 100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "Step", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int?>(
#nullable restore
#line 27 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                                          1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "Format", "###");
            __builder.AddAttribute(54, "CssClass", "radius");
            __builder.AddAttribute(55, "Placeholder", "Radius");
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                  ((e) => OnRadiusChange(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "px-2");
            __builder.AddMarkupContent(61, "\r\n                    Color ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(62);
            __builder.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                 ActiveNode.NodeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                    OnNodeColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "px-2");
            __builder.AddMarkupContent(69, "\r\n                    Label\r\n");
#nullable restore
#line 35 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                     if (ActiveNode.Label == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                        ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(71);
            __builder.AddAttribute(72, "CssClass", "radius");
            __builder.AddAttribute(73, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ChangedEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                  OnNodeLabelChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                              ActiveNode.NodeId.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 38 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                        ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(77);
            __builder.AddAttribute(78, "CssClass", "radius");
            __builder.AddAttribute(79, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ChangedEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                  OnNodeLabelChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                                             ActiveNode.Label

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 42 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                    ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(83);
            __builder.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                           ActiveNode.LabelColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
                                                                               OnNodeLabelColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 46 "C:\Users\ahmki\source\repos\GarphIt\GarphIt.web\Pages\Design.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
