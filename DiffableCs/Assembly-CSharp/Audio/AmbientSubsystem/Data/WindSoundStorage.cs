namespace Audio.AmbientSubsystem.Data;

public class WindSoundStorage : ISeasonSoundStorage
{
	[SerializeField]
	private SeasonWind _seasonPrecipitations; //Field offset: 0x10

	public WindSoundStorage() { }

	public override bool TryGetClip(ESeasonStatus seasonStatus, EWindSpeed windSpeed, EnvironmentType environment, out AudioClip clip) { }

}

