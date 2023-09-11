using Fluxor;

using FluxorTut.Store;

using Microsoft.AspNetCore.Components;
using FluxorTut.Store.CounterUseCase;

namespace FluxorTut.Pages;

public partial class Counter
{
    [Inject]
    public IDispatcher Dispatcher { get; set; } = null!;
    [Inject]
    private IState<CounterState> CounterState { get; set; } = null!;

    private void IncrementCount()
    {
        var action = new IncrementCounterAction();
        Dispatcher.Dispatch(action);
    }
}
