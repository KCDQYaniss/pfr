namespace Audio.AmbientSubsystem;

public class AmbientAudioSystem : MonoBehaviourSingleton, IDisposable
{
	[SerializeField]
	private SeasonAmbientSoundDataSO _ambientData; //Field offset: 0x20
	[SerializeField]
	private MixerEffectsDataSO EffectsData; //Field offset: 0x28
	[SerializeField]
	private int _frameCountUpdateInterval; //Field offset: 0x30
	[SerializeField]
	private bool _useSimpleUnderRoofCheck; //Field offset: 0x34
	private AudioGameEventsController _eventsController; //Field offset: 0x38
	private ISoundBlender[] _soundBlenders; //Field offset: 0x40
	private AmbientSoundPlayerGroup[] _soundPlayerGroups; //Field offset: 0x48
	private AmbientSplineEmitterController[] _splineEmitterControllers; //Field offset: 0x50
	private ISeasonDependent[] _seasonDependentComponents; //Field offset: 0x58
	private IPrecipitationDependent[] _precipitationDependentComponents; //Field offset: 0x60
	private IWindDependent[] _windDependentComponents; //Field offset: 0x68
	private RoomToneController _roomToneController; //Field offset: 0x70
	private int _currentFrame; //Field offset: 0x78
	private bool _disposed; //Field offset: 0x7C
	private AmbientSoundPlayerCulling _ambientPlayerCulling; //Field offset: 0x80
	private AudioMixerParamsController _mixerParamsController; //Field offset: 0x88
	private readonly List _activeTickablePlayers; //Field offset: 0x90
	private Action _unsubOnDestroy; //Field offset: 0x98
	[CompilerGenerated]
	private ESeasonStatus <CurrentSeasonStatus>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private SeasonAmbientSoundDataSO <AmbientSoundData>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0xB0

	public private SeasonAmbientSoundDataSO AmbientSoundData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ESeasonStatus CurrentSeasonStatus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool UseSimpleUnderRoofCheck
	{
		 get { } //Length: 5
	}

	public AmbientAudioSystem() { }

	public virtual void Awake() { }

	private bool CanUpdate() { }

	private void CheckSoundData() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public SeasonAmbientSoundDataSO get_AmbientSoundData() { }

	[CompilerGenerated]
	public ESeasonStatus get_CurrentSeasonStatus() { }

	[CompilerGenerated]
	public bool get_Initialized() { }

	public bool get_UseSimpleUnderRoofCheck() { }

	private void HandleSeasonController() { }

	private void Init() { }

	private void InitEventsController() { }

	public void Initialize() { }

	private void InitSplineEmitterControllers() { }

	private void LateUpdate() { }

	public virtual void OnDestroy() { }

	private void OnSeasonControllerInitialized(ISeasonsController seasonsController) { }

	private void PreInit() { }

	private void RainIntensityChangedHandler(RainIntensityChangedEvent rainIntensityChangedEvent) { }

	public void RegisterPlayerForTick(BaseAmbientSoundPlayer player) { }

	public void RegisterPlayerInCulling(BaseAmbientSoundPlayer player) { }

	public void RemovePlayerFromCulling(BaseAmbientSoundPlayer player) { }

	public void RemovePlayerFromTick(BaseAmbientSoundPlayer player) { }

	public void Restart() { }

	[CompilerGenerated]
	private void set_AmbientSoundData(SeasonAmbientSoundDataSO value) { }

	[CompilerGenerated]
	private void set_CurrentSeasonStatus(ESeasonStatus value) { }

	[CompilerGenerated]
	private void set_Initialized(bool value) { }

	private void SetListenerInAudioCulling() { }

	private void Subscribe() { }

	private void Update() { }

	private void WindSpeedChangedHandler(AudioWindSpeedChangedEvent windSpeedChangedEvent) { }

}

