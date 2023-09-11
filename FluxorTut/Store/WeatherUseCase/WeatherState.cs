using Fluxor;

using FluxorTut.Model;

namespace FluxorTut.Store.WeatherUseCase;

[FeatureState]
public class WeatherState
{
    public bool IsLoading { get; }
    public IEnumerable<WeatherForecast> Forecasts { get; } = null!;

    private WeatherState()
    {
        Forecasts = Array.Empty<WeatherForecast>();
        IsLoading = true;
    }

    public WeatherState(bool isLoading, IEnumerable<WeatherForecast>? forecasts)
    {
        IsLoading = isLoading;
        Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
    }
}
