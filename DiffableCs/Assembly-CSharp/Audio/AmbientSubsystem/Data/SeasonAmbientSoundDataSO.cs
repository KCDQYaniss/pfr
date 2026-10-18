namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/SeasonAmbientSoundDataSO", fileName = "SeasonAmbientSoundData")]
public class SeasonAmbientSoundDataSO : ScriptableObject
{
	private const ESeasonStatus DEFAULT_SEASON = 0; //Field offset: 0x0
	[SerializeField]
	private WindSoundStorage _windSoundStorage; //Field offset: 0x18
	[SerializeField]
	private DayTimeAmbientSeasonClips _dayTimeAmbientSeasonClips; //Field offset: 0x20
	[SerializeField]
	private PrecipitationSoundStorageSO _precipitationSoundStorageSo; //Field offset: 0x28

	public SeasonAmbientSoundDataSO() { }

	private void CheckPrecipitationStorage() { }

	private AudioClip CreateEmptyClip() { }

	private void OnEnable() { }

	public bool TryGetDayTimeSoundContainer(ESeasonStatus seasonStatus, out DayTimeAmbientSoundContainer dayTimeAmbientSoundContainer) { }

	public bool TryGetPrecipitationClip(ESeasonStatus seasonStatus, ERainIntensity intensity, EnvironmentType environment, out AudioClip clip) { }

	public bool TryGetWindClip(ESeasonStatus seasonStatus, EWindSpeed windSpeed, EnvironmentType environment, out AudioClip clip) { }

}

