#pragma checksum "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\Pages\Links\EditLinks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b432c0604986ba383f05eb8531290eaf091d773"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Advance.Pages.Links
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Blazor_Advance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Blazor_Advance.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Blazor_Advance.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\_Imports.razor"
using Blazor_Advance.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditLink/{CurrentID}")]
    public partial class EditLinks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Arpit Deora\source\repos\Blazor_Advance\Blazor_Advance\Pages\Links\EditLinks.razor"
 
    [Parameter]
    public string CurrentID { get; set; }

    Sidebar sidebar = new Sidebar();
    protected override async Task OnInitializedAsync()
    {
        sidebar = _sidebar.GetLinksById(Convert.ToInt32(CurrentID));
    }


    private void UpdateLink()
    {
        _sidebar.Update(sidebar);
        _navigation.NavigateTo("Link");
    }
    private void Cancel()
    {
        _navigation.NavigateTo("Link");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SidebarService _sidebar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService _student { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
