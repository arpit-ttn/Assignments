#pragma checksum "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\Pages\Question3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed89fdbe782a0d1f9564e6d3995b006851bbd81"
// <auto-generated/>
#pragma warning disable 1591
namespace Intro_To_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Intro_To_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Arpit Deora\source\repos\Intro_To_Blazor\Intro_To_Blazor\_Imports.razor"
using Intro_To_Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Question3")]
    public partial class Question3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Q-3 Explain the Life cycle with example.</h3><br>\r\n\r\n<img src=\"Images/BlazorComponentLifecycle.png\">\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<p>1) OnIntialized</p>\r\n");
            __builder.AddMarkupContent(2, "<p>2) OnIntializedAsync</p>\r\n");
            __builder.AddMarkupContent(3, "<p>3) OnParameterSet</p>\r\n");
            __builder.AddMarkupContent(4, "<p>4) OnParamterSetAsync</p>\r\n");
            __builder.AddMarkupContent(5, "<p>5) OnAfterRender</p>\r\n");
            __builder.AddMarkupContent(6, "<p>6) OnAfterRenderAsync</p>\r\n");
            __builder.AddMarkupContent(7, "<p>7) ShouldRender</p>\r\n\r\n\r\n");
            __builder.AddMarkupContent(8, "<p>=> OnInitialized is first called then OnIntializedAsync.It is executed when the component is completely loaded.</p>\r\n");
            __builder.AddMarkupContent(9, "<p> => OnParameterSet and OnParameterSetAsync is called each time a new and updated parameters are recieved from the parents.</p>\r\n");
            __builder.AddMarkupContent(10, "<p>=> OnAfterRender and OnAfterRenderAsync are called after each render of the component.</p>\r\n");
            __builder.AddMarkupContent(11, "<p>=> ShouldRender method return a boolean type value it returns true for refresh otherwise false.</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
