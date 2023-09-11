using Fluxor;

using FluxorTut.Pages;

namespace FluxorTut.Store.CounterUseCase;

public class Reducers
{
    [ReducerMethod(typeof(IncrementCounterAction))]
    public static CounterState ReduceIncrementCounterAction(CounterState state) =>
        new(state.ClickCount + 1);
}
