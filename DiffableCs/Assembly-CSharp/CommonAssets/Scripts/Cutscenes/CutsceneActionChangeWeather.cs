namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionChangeWeather : CutsceneBaseAction
{
	public string weatherConfigId; //Field offset: 0x40
	private WeatherBank _locationWeatherBank; //Field offset: 0x48

	public CutsceneActionChangeWeather() { }

	private void Awake() { }

	public virtual void Init() { }

}

