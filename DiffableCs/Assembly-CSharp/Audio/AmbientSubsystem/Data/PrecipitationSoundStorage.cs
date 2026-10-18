namespace Audio.AmbientSubsystem.Data;

public class PrecipitationSoundStorage : ISeasonSoundStorage
{
	[SerializeField]
	private SeasonPrecipitations _seasonPrecipitations; //Field offset: 0x10

	public PrecipitationSoundStorage() { }

	public override bool TryGetClip(ESeasonStatus seasonStatus, ERainIntensity intensity, EnvironmentType environment, out AudioClip clip) { }

}

