#pragma checksum "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\Pages\CounterPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a27cd8374bb59f2daa15c521470dfecc361a7de"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp3s.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using BlazorApp3s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\_Imports.razor"
using BlazorApp3s.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class CounterPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter Page</h1>\r\n\r\n");
            __builder.OpenComponent<BlazorApp3s.Pages.Counter>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<BlazorApp3s.Pages.CounterLogging>(3);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
