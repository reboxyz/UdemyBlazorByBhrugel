#pragma checksum "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2431d0b80f5916678c19fa73a1c869bf0173052b"
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
#line 3 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class CategoryPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
#nullable restore
#line 17 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
         if(categories == null /*|| categories.Count == 0*/)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<p><em>Loading or No categories exist</em></p>");
#nullable restore
#line 20 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
        } else 
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container border p-3");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "<div class=\"col-5\"><h3 class=\"text-info\">Category List</h3></div>\n                    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-3");
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "class", "btn btn-info form-control");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                                            AddNewCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(13, " \n                            Add New Category\n                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row pt-4");
                __builder2.OpenElement(17, "table");
                __builder2.AddAttribute(18, "class", "table table-striped");
                __builder2.AddMarkupContent(19, "<thead><tr><th>Category Name</th>\n                                <th></th></tr></thead>\n                        ");
                __builder2.OpenElement(20, "tbody");
#nullable restore
#line 43 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                             foreach (var category in categories)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "tr");
                __builder2.OpenElement(22, "td");
                __builder2.AddAttribute(23, "key", 
#nullable restore
#line 46 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                              category.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(24, 
#nullable restore
#line 46 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                            category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                                    ");
                __builder2.OpenElement(26, "td");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddAttribute(29, "style", "width: 150px");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                                                                       (() => EditCategory(category))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(31, "\n                                            Edit\n                                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 53 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                            }   

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 58 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(32, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "<p>You\'re not signed in.</p>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 65 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal");
            __builder.AddAttribute(36, "tabindex", "-1");
            __builder.AddAttribute(37, "style", "display:block");
            __builder.AddAttribute(38, "role", "dialog");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(39);
            __builder.AddAttribute(40, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 68 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                      objCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 68 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                    ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "modal-dialog");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "modal-content");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "modal-header");
                __builder2.OpenElement(49, "h3");
                __builder2.AddAttribute(50, "class", "text-info");
                __builder2.AddContent(51, 
#nullable restore
#line 72 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                            objCategory.Id !=0 ? "Update" : "Create"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(52, " Category");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n                    ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "type", "button");
                __builder2.AddAttribute(56, "class", "close");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(58, "<span aria-hidden=\"true\">X</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "modal-body");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(62);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(64);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-9");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "row py-2");
                __builder2.AddMarkupContent(70, "<div class=\"col-4\">\n                                Category Name\n                            </div>\n                            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-8");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "class", "form-control");
                __builder2.AddAttribute(75, "type", "text");
                __builder2.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                                               objCategory.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCategory.Name = __value, objCategory.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n                        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row py-2");
                __builder2.AddMarkupContent(81, "<div class=\"offset-4 col\"><button class=\"btn btn-primary form-control\" type=\"submit\">Submit</button></div>");
#nullable restore
#line 93 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                             if (objCategory.Id > 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col");
                __builder2.OpenElement(84, "button");
                __builder2.AddAttribute(85, "class", "btn btn-danger form-control");
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                                                      DeleteCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "type", "submit");
                __builder2.AddContent(88, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 100 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 108 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "/Users/erwinrebosura/Documents/Playground/Blazor/Bhrugen/BlazingShop/BlazingShop/Pages/CategoryPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    List<Category> categories;
    Category objCategory = new Category();     // Current Catetory 
    bool ShowPopup = false;

    // Life-cycle Method
    protected override async void OnInitialized()
    {
        // Retrieve Current Logged-in User
        var user = (await authenticationState).User.Identity.Name;
        Console.WriteLine("User Email: {0}", user);
        

        //categories = Service.GetCategories();
        categories = CategoryService.GetCategories();
    } 

    private void AddNewCategory()   
    {
        // Create a new Category
        objCategory = new Category(); 
        objCategory.Id = 0;  
        ShowPopup = true;
    }

    private void EditCategory(Category category)   
    {
        objCategory = category;  // Load Category to be displayed
        ShowPopup = true;
    }

    private void ClosePopup()
    {
        ShowPopup = false;
    }

    private void DeleteCategory()
    {
        ShowPopup = false;
        var result = CategoryService.DeleteCategory(objCategory);
        categories = CategoryService.GetCategories(); // Reload categories
    }

    private void ValidSubmit()
    {
        var result = false;
        ShowPopup = false;

        if (objCategory.Id > 0) 
        {
            result = CategoryService.UpdateCategory(objCategory); 
        } else 
        {
            result = CategoryService.CreateCategory(objCategory); 
        }

        categories = CategoryService.GetCategories(); // Reload categories
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591