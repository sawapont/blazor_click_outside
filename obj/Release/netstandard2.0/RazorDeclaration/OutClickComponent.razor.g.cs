#pragma checksum "C:\Users\Alex\source\repos\SZ\OutElementClickComponent\OutClickComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67914863cf63f2d8e94f3e34885a90d07edb530c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OutElementClickComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Alex\source\repos\SZ\OutElementClickComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\Alex\source\repos\SZ\OutElementClickComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class OutClickComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\Alex\source\repos\SZ\OutElementClickComponent\OutClickComponent.razor"
      
    [Parameter]
    public string Class { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public EventCallback OnClickOut { get; set; }
    [Parameter]
    public EventCallback Click { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> InputAttributes { get; set; }

    public ElementReference Element { get; private set; }

    private string Id { get; set; } = Guid.NewGuid().ToString();

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            _jsRuntime.InvokeVoidAsync("OutClickComponent.setEvent", Id, DotNetObjectReference.Create(this));
        }
    }

    [JSInvokable]
    public Task ClickOut()
    {
        return OnClickOut.InvokeAsync(null);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591