#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4f96a57c7b3d3b448c61b1839c917b89dbfff9"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor"
     foreach (var product in listProduct)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazingShop.Pages.Components.IndividualProduct>(2);
            __builder.AddAttribute(3, "product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingShop.Data.Product>(
#nullable restore
#line 10 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor"
                                                                  product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/Index.razor"
       
    List<Product> listProduct = new List<Product>();

    protected override void OnInitialized()
    {
        listProduct = ProductService.GetProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
