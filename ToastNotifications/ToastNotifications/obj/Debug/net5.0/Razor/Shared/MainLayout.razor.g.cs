#pragma checksum "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acf28d7cd98d0fca7c282ec3b71f2d9dcc635b58"
// <auto-generated/>
#pragma warning disable 1591
namespace ToastNotifications.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using ToastNotifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using ToastNotifications.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using ToastNotifications.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\_Imports.razor"
using ToastNotifications.Components;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ToastNotifications.Components.Toast>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page");
            __builder.AddAttribute(4, "b-dgf8jh4ss5");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "sidebar");
            __builder.AddAttribute(7, "b-dgf8jh4ss5");
            __builder.OpenComponent<ToastNotifications.Shared.NavMenu>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddAttribute(12, "b-dgf8jh4ss5");
            __builder.AddMarkupContent(13, "<div class=\"top-row px-4\" b-dgf8jh4ss5><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-dgf8jh4ss5>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content px-4");
            __builder.AddAttribute(16, "b-dgf8jh4ss5");
            __builder.AddContent(17, 
#nullable restore
#line 16 "E:\blazor_blazor-tutorial\ToastNotifications\ToastNotifications\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591