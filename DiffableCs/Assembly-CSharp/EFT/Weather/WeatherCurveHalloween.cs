namespace EFT.Weather;

public class WeatherCurveHalloween : WeatherCurveBase, IWeatherFactory
{

	public WeatherCurveHalloween() { }

	public WeatherCurveHalloween(IWeatherCurve start, WeatherNode end) { }

	public override WeatherCurveHalloween Create(WeatherNode node) { }

}

