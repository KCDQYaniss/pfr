namespace Audio.AmbientSubsystem;

public class PrecipitationAmbientBlender : MonoBehaviour, ISoundBlender, IDisposable, ISeasonDependent
{
	private const float MAX_BLEND_SPEED = 1; //Field offset: 0x0
	private const int INVALID_HASH = -1; //Field offset: 0x0
	[SerializeField]
	[Tooltip("For Calculation by Room PrecipitationVolumeRange")]
	private float _dynamicCrossfadeDuration; //Field offset: 0x20
	[SerializeField]
	private float _dynamicBlendSpeed; //Field offset: 0x24
	[SerializeField]
	[Space(10)]
	private AudioSource _precipitationSource; //Field offset: 0x28
	[SerializeField]
	private AudioSource _precipitationMixSource; //Field offset: 0x30
	[SerializeField]
	private float _defaultBlendSpeed; //Field offset: 0x38
	[SerializeField]
	private float _crossfadeDuration; //Field offset: 0x3C
	[SerializeField]
	private EnvironmentType _environment; //Field offset: 0x40
	[SerializeField]
	private AudioMixerGroup _outputMixerGroup; //Field offset: 0x48
	[SerializeField]
	private float _maxVolumeCheckDelta; //Field offset: 0x50
	private SeasonAmbientSoundDataSO _ambientSoundData; //Field offset: 0x58
	private IAudioCrossfader _crossfader; //Field offset: 0x60
	private ERainIntensity _prevRainIntensity; //Field offset: 0x68
	private EAudioRoomTypeMask _currentRoomType; //Field offset: 0x6C
	private float _targetStaticVolume; //Field offset: 0x70
	private float _targetDynamicVolume; //Field offset: 0x74
	private float _prevTargetVolume; //Field offset: 0x78
	private RoomPrecipitationCalculator _precipitationCalculator; //Field offset: 0x80
	private Action _unsubscribeOnDestroy; //Field offset: 0x88
	private bool _initialized; //Field offset: 0x90
	private RoomAmbientData _currentAmbientData; //Field offset: 0x98
	private SeasonAmbientSettings _ambientSettings; //Field offset: 0xA0
	private float _globalsVolumeMult; //Field offset: 0xA8
	private ESeasonStatus _currentSeason; //Field offset: 0xAC
	private int _lastClipHash; //Field offset: 0xB0

	private ERainIntensity CurrentPrecipitationIntensity
	{
		private get { } //Length: 69
	}

	private float CurrentTargetVolume
	{
		private get { } //Length: 53
	}

	public PrecipitationAmbientBlender() { }

	public override void Dispose() { }

	private ERainIntensity get_CurrentPrecipitationIntensity() { }

	private float get_CurrentTargetVolume() { }

	private EnvironmentType GetCurrentEnvironment() { }

	public override void Init() { }

	public override void ManualUpdate(float dt = 0) { }

	private void OnDestroy() { }

	private void OnPlayerRoomChanged(MyPlayerRoomChangedEvent roomChangedEvent) { }

	private void SetClip() { }

	public override void SetSeasonStatus(ESeasonStatus targetSeasonStatus) { }

	private void StartCrossfader(float duration = 1, float speed = 1) { }

	private bool TryGetClip(out AudioClip clip) { }

	private void UpdateDynamicVolume() { }

	private void UpdateGlobalsVolumeMult() { }

}

