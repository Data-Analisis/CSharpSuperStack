#pragma checksum "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\Pages\FetchText.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f60ed697a67efab892057e71cf489fd1b269898"
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
#line 1 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using BlazorApp3s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\_Imports.razor"
using BlazorApp3s.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\Pages\FetchText.razor"
using BlazorApp3s.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchtext")]
    public partial class FetchText : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\CSSS\CSharpSuperStack\BlazorServerAppMovies3\BlazorApp3s\Pages\FetchText.razor"
       
    private WeatherForecast[] forecasts;
    private string[] temperatures;

    protected override async Task OnInitializedAsync()
    {
        temperatures = await ForecastTextService.GetTemperaturesAsync();
        forecasts = await ForecastTextService.GetForecastAsync(DateTime.Now, temperatures);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastTextService ForecastTextService { get; set; }
    }
}
#pragma warning restore 1591
