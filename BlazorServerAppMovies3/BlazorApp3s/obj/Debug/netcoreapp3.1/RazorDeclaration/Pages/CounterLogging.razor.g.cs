#pragma checksum "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\Pages\CounterLogging.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc1ec34506ed921bd6b734a45b58e49d1cc0e866"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\Pages\CounterLogging.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    public partial class CounterLogging : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\mwher\source\repos\BlazorApp3s\BlazorApp3s\Pages\CounterLogging.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        logger.LogWarning("Someone has clicked me!");

        currentCount++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Counter> logger { get; set; }
    }
}
#pragma warning restore 1591