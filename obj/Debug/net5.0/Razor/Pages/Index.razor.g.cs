#pragma checksum "C:\Users\student\source\repos\SearchEngine\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a750eb14f83c1f38f4772a787892a44d5d01682"
// <auto-generated/>
#pragma warning disable 1591
namespace SearchEngine.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using SearchEngine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\student\source\repos\SearchEngine\_Imports.razor"
using SearchEngine.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\source\repos\SearchEngine\Pages\Index.razor"
using SearchEngine.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Not Google</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "search-box");
            __builder.OpenComponent<SearchEngine.Components.SearchBox>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<div class=\"button-box\"></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
