#pragma checksum "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a381cc2db47f453fe246eceeee06950b36baa38"
// <auto-generated/>
#pragma warning disable 1591
namespace JobSearch.UI.Pages
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
#nullable restore
#line 3 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
using JobSearch.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
 if (jobs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
     foreach (var job in jobs)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", "/DetailsJob/" + (
#nullable restore
#line 19 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
                              job.idJob

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "section");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "info-job");
            __builder.AddMarkupContent(10, "\r\n                    <img src=\"https://picsum.photos/90/90\" alt>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "info-job-content");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "company");
            __builder.AddContent(16, 
#nullable restore
#line 24 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
                                            job.company

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "h3");
            __builder.AddAttribute(19, "class", "name-job");
            __builder.AddContent(20, 
#nullable restore
#line 25 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
                                              job.nameJob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "class", "tag");
            __builder.AddContent(24, 
#nullable restore
#line 26 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
                                           job.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "origin-time");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "origin");
            __builder.AddMarkupContent(33, "<i class=\"fas fa-globe-americas\"></i> ");
            __builder.AddContent(34, 
#nullable restore
#line 30 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
                                                                                job.place

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "time");
            __builder.AddMarkupContent(38, "<i class=\"far fa-clock\"></i> ");
            __builder.AddContent(39, 
#nullable restore
#line 31 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
                                                                     job.finalDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 35 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\GitJoseLuisRoot\challenge_1_stacklycode\JobSearch.UI\Pages\Index.razor"
       

    private IEnumerable<Job> jobs;

    protected override async Task OnInitializedAsync()
    {
        var apiName = "";
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            Console.WriteLine(httpResponse);
        }

        jobs = await JobService.getAllJobs();
    }
       


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJobService JobService { get; set; }
    }
}
#pragma warning restore 1591
