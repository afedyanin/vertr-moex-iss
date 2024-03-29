using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MoexScreener.Components.Common;

public partial class PerspectiveGrid : IAsyncDisposable
{
    private IJSObjectReference? _jsModule;

    private ElementReference perspectiveViewer;

    [Parameter]
    public string TableName { get; set; } = "Table";

    [Parameter]
    public string Height { get; set; } = "800px";

    [Parameter]
    public bool UseWebSocket { get; set; }

    [Parameter]
    public string SchemaEndpoint { get; set; } = string.Empty;

    [Parameter]
    public string DataEndpoint { get; set; } = string.Empty;

    [Parameter]
    public string DetailsEndpoint { get; set; } = string.Empty;

    [Inject]
    private IJSRuntime JSRuntime { get; set; } = default!;


    private DotNetObjectReference<PerspectiveGrid> _dotNetObjectReference = default!;

    protected override Task OnInitializedAsync()
    {
        _dotNetObjectReference = DotNetObjectReference.Create(this);

        return base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/MoexScreener.Components/Common/PerspectiveGrid.razor.js");
            await _jsModule.InvokeVoidAsync("fetchArrow", DataEndpoint, perspectiveViewer, _dotNetObjectReference);
        }
    }

    [JSInvokable("NavigateToDetails")]
    public Task NavigateToDetails(string secId)
    {
        if (string.IsNullOrEmpty(DetailsEndpoint) ||
            string.IsNullOrEmpty(secId))
        {
            return Task.CompletedTask;
        }

        Navigation.NavigateTo($"{DetailsEndpoint}/{secId}");

        return Task.CompletedTask;
    }

    public async ValueTask DisposeAsync()
    {
        try
        {
            if (_jsModule != null)
            {
                // await _jsModule.InvokeVoidAsync("dispose");
                await _jsModule.DisposeAsync();
            }
        }
        catch (JSDisconnectedException)
        {
            // Client disconnected.
        }
    }
}
