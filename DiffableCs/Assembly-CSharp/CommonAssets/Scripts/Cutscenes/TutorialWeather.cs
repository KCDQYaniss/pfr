namespace CommonAssets.Scripts.Cutscenes;

public sealed class TutorialWeather : FinalMissionWeather
{

	protected virtual WeatherFinalConfig WeatherConfig
	{
		 get { } //Length: 73
	}

	public TutorialWeather() { }

	protected virtual WeatherFinalConfig get_WeatherConfig() { }

}

