#pragma checksum "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Shared\DetailsLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "effd838d3935c76c354896c2e78ce1aea307cad1"
// <auto-generated/>
#pragma warning disable 1591
namespace JobSearch.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using JobSearch.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\_Imports.razor"
using JobSearch.UI.Shared;

#line default
#line hidden
#nullable disable
    public partial class DetailsLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "main");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<header>\r\n        <div class=\"name\">\r\n            <h1><span class=\"bold\">Github</span> <span class=\"light\">Jobs</span></h1>\r\n        </div>\r\n    </header>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content-ppal");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Shared\DetailsLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<footer>\r\n        <p> joseluisroot  DevChallenges.io</p>\r\n    </footer>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
