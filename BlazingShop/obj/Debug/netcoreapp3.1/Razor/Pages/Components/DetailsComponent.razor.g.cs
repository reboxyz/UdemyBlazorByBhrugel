#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36033f337198bf56ce68ad1f33fa3b21f47377ae"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using BlazingShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    public partial class DetailsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-4 border rounded row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-8");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group row");
            __builder.AddMarkupContent(6, "<div class=\"col-4\">\n                 Name\n             </div>   \n             ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-8");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "value", 
#nullable restore
#line 11 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
                                appointment.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "readonly", true);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group row");
            __builder.AddMarkupContent(16, "<div class=\"col-4\">\n                 Shade Color   \n             </div>   \n             ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-8");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 20 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
                                appointment.Product.ShadeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "readonly", true);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group row");
            __builder.AddMarkupContent(26, "<div class=\"col-4\">\n                Price\n             </div>   \n             ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-8");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 29 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
                                appointment.Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "readonly", true);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group row");
            __builder.AddMarkupContent(36, "<div class=\"col-4\">\n                 Category Name\n             </div>   \n             ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-8");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 38 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
                                appointment.Product.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "readonly", true);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group row");
            __builder.AddMarkupContent(46, "<div class=\"col-4\"></div>   \n             ");
            __builder.AddMarkupContent(47, "<div class=\"col-4\"><a href=\"/\" class=\"btn btn-success form-control\">Back to List</a></div>   \n             ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-4");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
                                   onClickShowAppointment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "class", "btn btn-primary form-control");
            __builder.AddContent(53, "Book Appointment");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "offset-1 col-3");
            __builder.OpenElement(57, "img");
            __builder.AddAttribute(58, "src", 
#nullable restore
#line 56 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
                   ConvertImageToDisplay(appointment.Product.Image)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(59, "width", "100%");
            __builder.AddAttribute(60, "style", "border-radius: 5px; border: 1px solid #bbb9b9");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Components/DetailsComponent.razor"
       
    [Parameter]
    public Appointment appointment { get; set; }
    [Parameter]
    public EventCallback onClickShowAppointment { get; set; }

    string ConvertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }
        return "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591