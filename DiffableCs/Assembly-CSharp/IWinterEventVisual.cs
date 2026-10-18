//Type is in global namespace

public interface IWinterEventVisual
{

	public WeatherObstacle WinterWeatherObstacle
	{
		 get { } //Length: 0
	}

	public WeatherObstacle get_WinterWeatherObstacle() { }

	public void StormSetup() { }

	public void StormSetupOnReconnect() { }

}

