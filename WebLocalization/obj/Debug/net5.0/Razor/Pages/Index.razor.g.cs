#pragma checksum "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c9c43a7a97e6657c59fa4fc4c5d5db426deb1f"
// <auto-generated/>
#pragma warning disable 1591
namespace WebLocalization.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 5 "D:\AAB Blazor Project\Sample\WebLocalization\WebLocalization\Pages\Index.razor"
     _localizer["Mission"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<WebLocalization.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<WebLocalization.Resources.Resource> _localizer { get; set; }
    }
}
#pragma warning restore 1591
