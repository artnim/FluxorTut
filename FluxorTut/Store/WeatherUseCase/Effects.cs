using System.Net.Http.Json;

using Fluxor;

using FluxorTut.Model;

namespace FluxorTut.Store.WeatherUseCase;

public class Effects
{
    private readonly HttpClient _httpClient;
    public Effects(HttpClient httpClient) { _httpClient = httpClient; }

    [EffectMethod]
    public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher)
    {
        var forecasts = await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json")!;
        dispatcher.Dispatch(new FetchDataResultAction(forecasts));
    }
}

public class FetchDataResultAction
{
    public IEnumerable<WeatherForecast> Forecasts { get; }

    public FetchDataResultAction(IEnumerable<WeatherForecast>? forecasts)
    {
        Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
    }
}
