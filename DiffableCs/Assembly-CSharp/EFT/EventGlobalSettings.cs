namespace EFT;

public sealed class EventGlobalSettings
{
	public bool EventActive; //Field offset: 0x10
	public int EventTime; //Field offset: 0x14
	public int WeatherChangeTime; //Field offset: 0x18
	public float ExitTimeMultiplier; //Field offset: 0x1C
	public float StaminaMultiplier; //Field offset: 0x20
	public WeatherEventSettings EventWeather; //Field offset: 0x28
	public WeatherEventSettings SummonSuccessWeather; //Field offset: 0x30
	public WeatherEventSettings SummonFailedWeather; //Field offset: 0x38
	public string[] LocationsToIgnore; //Field offset: 0x40

	public EventGlobalSettings() { }

}

