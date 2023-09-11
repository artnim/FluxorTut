using Fluxor;

using FluxorTut.Store;

using Microsoft.AspNetCore.Components;

namespace FluxorTut.Components;

public class FetchDataInitializer : ComponentBase
{
    [Inject] private IDispatcher Dispatcher { get; set; }= null!;

    protected override void OnInitialized()
    {
        Dispatcher.Dispatch(new FetchDataAction());
        base.OnInitialized();
    }
}
