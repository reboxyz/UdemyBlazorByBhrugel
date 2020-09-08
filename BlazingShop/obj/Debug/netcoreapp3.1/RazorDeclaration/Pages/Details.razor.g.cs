#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97abe2c7aa12b5c65e12adf34efdc011ac09e26"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingShop.Pages
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
#line 2 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Details.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Details.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{ProductId:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Details.razor"
       
    [Parameter]
    public int ProductId { get; set; }
    public Appointment appointment { get; set; }
    // Note! Toggle flag; False on Details Page and True on Appointment Page
    bool ShowAppointment = false;

    protected override void OnInitialized()
    {
        appointment = new Appointment()
        {
            AppointmentDate = DateTime.Now
        };
        appointment.Product = ProductService.GetProduct(ProductId);
    }

    void onClickShowAppointment()
    {
        ShowAppointment = true;
    }

    void onClickShowDetails()
    {
        ShowAppointment = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591