namespace EFT.Weather;

public class WeatherCurve : WeatherCurveBase, IWeatherFactory
{

	public WeatherCurve() { }

	public WeatherCurve(WeatherNode[] nodes) { }

	public WeatherCurve(IWeatherCurve start, WeatherNode end) { }

	public override WeatherCurve Create(WeatherNode node) { }

}

