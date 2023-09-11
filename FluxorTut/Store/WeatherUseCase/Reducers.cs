using Fluxor;

namespace FluxorTut.Store.WeatherUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction _) =>
        new WeatherState(true, null);

    [ReducerMethod]
    public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
        new WeatherState(false, action.Forecasts);
}
