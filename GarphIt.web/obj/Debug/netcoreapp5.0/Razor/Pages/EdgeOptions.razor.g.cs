#pragma checksum "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc4090f309d42ed0f7f509458dff0ca85ff7c48"
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
    public partial class EdgeOptions : EdgeOptionsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
 if (Open)
{
    NavCss = "NavActive";
    OpenCss = "show";
}
else
{
    NavCss = "NavNone";
    OpenCss = "";
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
 if (!ActiveEdges.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<li class=\"navbar-text font-weight-bold pl-2 pr-custom border-dark border-right\">Default</li>\r\n    ");
            __builder.OpenElement(1, "li");
            __builder.AddAttribute(2, "class", "dropdown" + " border-dark" + " border-right" + " " + (
#nullable restore
#line 17 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                  NavCss

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 17 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                          OpenCss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "data-toggle", "tooltip");
            __builder.AddAttribute(4, "data-placement", "bottom");
            __builder.AddAttribute(5, "title", "Color");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn shadow-none");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                  (() => Open = !Open)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "id", "defedgecolor");
            __builder.AddAttribute(10, "aria-haspopup", "true");
            __builder.AddAttribute(11, "aria-expanded", 
#nullable restore
#line 18 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                               Open

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "oi oi-brush");
            __builder.AddAttribute(14, "style", "color:" + (
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                    DefaultOptions.EdgeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "oi oi-text");
            __builder.AddAttribute(17, "style", "color:" + (
#nullable restore
#line 19 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                            DefaultOptions.EdgeLabelColor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "dropdown-menu" + " " + (
#nullable restore
#line 21 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                   OpenCss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "aria-labelledby", "defedgecolor");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "class", "dropdown-item");
            __builder.AddContent(24, "Fill ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(25);
            __builder.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                    DefaultOptions.EdgeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                           OnDefEdgeColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "dropdown-item");
            __builder.AddContent(31, "Label ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(32);
            __builder.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                     DefaultOptions.EdgeLabelColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                 OnDefEdgeLabelColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(38, "<div class=\"py-2\">\r\n            Width\r\n        </div>\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "p-custom");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "class", "shortInput");
            __builder.AddAttribute(43, "type", "number");
            __builder.AddAttribute(44, "Min", "1");
            __builder.AddAttribute(45, "Max", "15");
            __builder.AddAttribute(46, "step", "1");
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 31 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                DefaultOptions.EdgeWidth

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                     OnDefWidthChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<li class=\"navbar-text font-weight-bold pl-2 pr-custom-1 border-dark border-right\">Selected</li>\r\n    ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "dropdown" + " border-dark" + " border-right" + " " + (
#nullable restore
#line 38 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                  NavCss

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 38 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                          OpenCss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "data-toggle", "tooltip");
            __builder.AddAttribute(53, "data-placement", "bottom");
            __builder.AddAttribute(54, "title", "Color");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn shadow-none");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                  (() => Open = !Open)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "id", "medgecolor");
            __builder.AddAttribute(59, "aria-haspopup", "true");
            __builder.AddAttribute(60, "aria-expanded", 
#nullable restore
#line 39 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                             Open

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(61, "span");
            __builder.AddAttribute(62, "class", "oi oi-brush");
            __builder.AddAttribute(63, "style", "color:" + (
#nullable restore
#line 40 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                    ActiveEdges[0].EdgeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.OpenElement(64, "span");
            __builder.AddAttribute(65, "class", "oi oi-text");
            __builder.AddAttribute(66, "style", "color:" + (
#nullable restore
#line 40 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                            ActiveEdges[0].LabelColor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "dropdown-menu" + " " + (
#nullable restore
#line 42 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                   OpenCss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "aria-labelledby", "medgecolor");
            __builder.OpenElement(71, "span");
            __builder.AddAttribute(72, "class", "dropdown-item");
            __builder.AddContent(73, "Fill ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(74);
            __builder.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                    ActiveEdges[0].EdgeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                           OnEdgeColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "span");
            __builder.AddAttribute(79, "class", "dropdown-item");
            __builder.AddContent(80, "Label ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfColorPicker>(81);
            __builder.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                     ActiveEdges[0].LabelColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.ColorPickerEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                             OnEdgeLabelColorChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
    if (ActiveEdges.Count == 1)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "li");
            __builder.AddAttribute(85, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(86, "<div class=\"py-2\">\r\n                Width\r\n            </div>\r\n            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "p-custom");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "class", "shortInput");
            __builder.AddAttribute(91, "type", "number");
            __builder.AddAttribute(92, "Min", "1");
            __builder.AddAttribute(93, "Max", "15");
            __builder.AddAttribute(94, "step", "1");
            __builder.AddAttribute(95, "value", 
#nullable restore
#line 54 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                    ActiveEdges[0].Width

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                                     OnWidthChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "li");
            __builder.AddAttribute(99, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(100, "<div class=\"py-2\">\r\n                Label\r\n            </div>\r\n            ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "p-custom");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "class", "shortInput");
            __builder.AddAttribute(105, "value", 
#nullable restore
#line 62 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                  ActiveEdges[0].Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                   OnEdgeLabelChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
         if (DefaultOptions.Weighted)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(107, "li");
            __builder.AddAttribute(108, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(109, "<div class=\"py-2\">\r\n                    Weight\r\n                </div>\r\n                ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "p-custom");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "class", "shortInput");
            __builder.AddAttribute(114, "type", "number");
            __builder.AddAttribute(115, "Min", "1");
            __builder.AddAttribute(116, "value", 
#nullable restore
#line 72 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                          ActiveEdges[0].Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                                            OnWeightChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(118, "li");
            __builder.AddAttribute(119, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(120, "<div class=\"py-2\">\r\n                Width\r\n            </div>\r\n            ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "p-custom");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "class", "shortInput");
            __builder.AddAttribute(125, "type", "number");
            __builder.AddAttribute(126, "Min", "1");
            __builder.AddAttribute(127, "Max", "15");
            __builder.AddAttribute(128, "step", "1");
            __builder.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                                       OnWidthChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.OpenElement(131, "li");
            __builder.AddAttribute(132, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(133, "<div class=\"py-2\">\r\n                Label\r\n            </div>\r\n            ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "p-custom");
            __builder.OpenElement(136, "input");
            __builder.AddAttribute(137, "class", "shortInput");
            __builder.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                     OnEdgeLabelChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
         if (DefaultOptions.Weighted)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(139, "li");
            __builder.AddAttribute(140, "class", "d-flex flex-row px-2 border-dark border-right");
            __builder.AddMarkupContent(141, "<div class=\"py-2\">\r\n                    Weight\r\n                </div>\r\n                ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "p-custom");
            __builder.OpenElement(144, "input");
            __builder.AddAttribute(145, "class", "shortInput");
            __builder.AddAttribute(146, "type", "number");
            __builder.AddAttribute(147, "Min", "1");
            __builder.AddAttribute(148, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                                             OnWeightChange

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 105 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(149, "li");
            __builder.AddAttribute(150, "class", "d-flex flex-row px-2");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "NavNone px-1 py-2");
            __builder.AddAttribute(153, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                   () => OnCurve(-0.1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(154, "<span class=\"oi oi-minus\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        ");
            __builder.AddMarkupContent(156, "<div class=\"py-2\">\r\n            Curve\r\n        </div>\r\n        ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "NavNone px-1 py-2");
            __builder.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                   () => OnCurve(0.1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(160, "<span class=\"oi oi-plus\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 114 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
 if (ActiveEdges.Any())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(161, "li");
            __builder.AddAttribute(162, "class", "NavNone p-2 border-dark border-left");
            __builder.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
                                                              async () => await DeleteActiveEdges.InvokeAsync(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(164, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
#nullable restore
#line 118 "C:\Users\ahmki\OneDrive - University of Warwick\Warwick Studies\year 3\CS310-Final-Project\Project\GraphIt\GarphIt.web\Pages\EdgeOptions.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
