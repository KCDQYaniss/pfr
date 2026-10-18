namespace Audio.AmbientSubsystem;

public class WeatherRandomAmbientSoundPlayer : BaseRandomAmbientSoundPlayer, ISeasonDependent, IWindDependent, IPrecipitationDependent
{
	internal class SeasonWeatherSoundData : SerializableEnumDictionary
	{

		public SeasonWeatherSoundData() { }

	}

	[HideInInspector]
	[Space]
	public bool enabledSeasons; //Field offset: 0x120
	[SerializeField]
	private Vector2 _fadeOutSecRangeOnPrecipitationStop; //Field offset: 0x124
	[HideInInspector]
	[SerializeField]
	private SeasonWeatherSoundData _seasonWeatherSoundData; //Field offset: 0x130
	[HideInInspector]
	[SerializeField]
	private WeatherSoundDataContainer _commonWeatherSoundData; //Field offset: 0x138
	private ERainIntensity _currRainIntensity; //Field offset: 0x140
	private EWindSpeed _currWindSpeed; //Field offset: 0x144
	private EAudioRoomTypeMask _currRoomType; //Field offset: 0x148
	private ESeasonStatus _currSeasonStatus; //Field offset: 0x14C
	private Action _unsubOnDestroy; //Field offset: 0x150
	[CompilerGenerated]
	private SoundBank <CurrentBank>k__BackingField; //Field offset: 0x158

	protected virtual SoundBank CurrentBank
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private EnvironmentType EnvironmentType
	{
		private get { } //Length: 19
	}

	public WeatherRandomAmbientSoundPlayer() { }

	public override void ApplyPrecipitationsIntensity(ERainIntensity targetIntensity) { }

	public override void ApplyWindSpeed(EWindSpeed targetWindSpeed) { }

	public virtual void ChangeSoundBank(SoundBank newSoundBank) { }

	[CompilerGenerated]
	protected virtual SoundBank get_CurrentBank() { }

	private EnvironmentType get_EnvironmentType() { }

	protected virtual AudioClip GetClip() { }

	protected virtual float GetRandomDelay() { }

	protected virtual void Init() { }

	private void MyPlayerRoomChangedEventHandler(MyPlayerRoomChangedEvent roomChangedEvent) { }

	protected virtual void OnDestroy() { }

	[CompilerGenerated]
	protected virtual void set_CurrentBank(SoundBank value) { }

	public override void SetSeasonStatus(ESeasonStatus targetSeasonStatus) { }

	private bool TryGetCurrentWeatherData(out WeatherSoundData weatherData) { }

	private bool TrySetBank() { }

}

