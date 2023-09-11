using Fluxor;

using FluxorTut.Store;
using FluxorTut.Store.WeatherUseCase;

using Microsoft.AspNetCore.Components;

namespace FluxorTut.Pages;

public partial class FetchData
{
    [Inject] private IState<WeatherState> WeatherState { get; set; } = null!;
    [Inject] private IDispatcher Dispatcher { get; set; } = null!;
}
