#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/LearnBlazor/LearnRouting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c13bbb483db9a04b5b34d4dd7392f39a6e21dbdb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Pages.LearnBlazor
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnnewrouting/{parameter1}/{parameter2}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnnewrouting/{parameter1}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnrouting")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnnewrouting")]
    public partial class LearnRouting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Learn Routing</h3>\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "First Parameter: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/LearnBlazor/LearnRouting.razor"
                     Parameter1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Second Parameter: ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/LearnBlazor/LearnRouting.razor"
                      Parameter2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/LearnBlazor/LearnRouting.razor"
       
    [Parameter]
    public string Parameter1 { get; set; }
    [Parameter]
    public string Parameter2 { get; set; } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
