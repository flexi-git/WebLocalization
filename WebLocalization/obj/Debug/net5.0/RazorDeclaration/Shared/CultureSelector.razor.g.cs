// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebLocalization.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using WebLocalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\_Imports.razor"
using WebLocalization.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\Shared\CultureSelector.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class CultureSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\Shared\CultureSelector.razor"
       

    CultureInfo[] cultures = new[]
    {
        new CultureInfo("en-US"),
        new CultureInfo("ar-QA")
        //new CultureInfo("en"),
        //new CultureInfo("fr-FR")
    };

    CultureInfo culture
    {

        get => CultureInfo.CurrentCulture;

        //// wasm
        //set
        //{
        //    var jsInProcessRuntime = (IJSInProcessRuntime)jsRuntime;
        //    jsInProcessRuntime.InvokeVoid("setInLocalStorage", "culture", value.Name);
        //    _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
        //}

        //// server
        set
        {
            var culture = value.Name;
            var uri = new Uri(_navigationManager.Uri)
                .GetComponents(UriComponents.PathAndQuery, UriFormat.Unescaped);

            var query = $"?culture={Uri.EscapeDataString(culture)}&redirectionURI={Uri.EscapeDataString(uri)}";
            _navigationManager.NavigateTo("/Culture/SetCulture" + query, forceLoad: true);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591