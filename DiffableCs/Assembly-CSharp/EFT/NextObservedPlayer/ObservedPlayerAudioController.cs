namespace EFT.NextObservedPlayer;

public class ObservedPlayerAudioController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Idle>d__263 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ObservedPlayerAudioController <>4__this; //Field offset: 0x20
		public EPlayerState state; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Idle>d__263(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <OutOfRangeSpeakingCoroutine>d__218 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float distance; //Field offset: 0x20
		public ObservedPlayerAudioController <>4__this; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <OutOfRangeSpeakingCoroutine>d__218(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <Run>d__264 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ObservedPlayerAudioController <>4__this; //Field offset: 0x20
		public EPlayerState state; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Run>d__264(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <Sprint>d__262 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ObservedPlayerAudioController <>4__this; //Field offset: 0x20
		public EPlayerState state; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Sprint>d__262(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const float COVERT_MOVEMENT_BLEND_RANGE = 0.2; //Field offset: 0x0
	private const float MIN_TIME_SINCE_LAST_STEP = 0.2; //Field offset: 0x0
	private const float FIRST_STEP_SOUND_DELAY_SECONDS = 0.05; //Field offset: 0x0
	private const float SURFACE_CHECK_RAYCAST_OFFSET = 0.5; //Field offset: 0x0
	private const float MIN_FALL_DAMAGE = 1; //Field offset: 0x0
	private const float MIN_COMMON_DAMAGE = 4; //Field offset: 0x0
	private const float TIME_BETWEEN_PRONE_SWEEPS = 0.5; //Field offset: 0x0
	private const float MAX_LENGTH_TURN_SOUND = 0.6; //Field offset: 0x0
	private const float LANDING_VOLUME_MULT = 2.5; //Field offset: 0x0
	private const float LANDING_THRESHOLD = 0.3; //Field offset: 0x0
	private const float MIN_TIME_SINCE_LAST_LANDING = 0.5; //Field offset: 0x0
	private const float DEFAULT_FP_ROLLOFF = 70; //Field offset: 0x0
	private const float MAX_STEP_SOUND_SPEED_FACTOR = 1; //Field offset: 0x0
	private const float MIN_ALLOWED_MOVEMENT_SPEED = 0.01; //Field offset: 0x0
	private const float DEFAULT_TRAVEL_SPEED_MS = 5; //Field offset: 0x0
	private const int BUFFER_ZONE = 2; //Field offset: 0x0
	private const float DEFAULT_ROLL_OFF = 60; //Field offset: 0x0
	private static readonly EPhraseTrigger[] _localPhrases; //Field offset: 0x0
	private const float COVERT_MOVEMENT_THRESHOLD = 0.4; //Field offset: 0x0
	[CompilerGenerated]
	private EnvironmentType <Environment>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private SoundElement <PropIn>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private SoundElement <PropOut>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Action PhraseSituation; //Field offset: 0x38
	private readonly Vector3 _speechLocalPosition; //Field offset: 0x40
	private ObservedPlayerView _observer; //Field offset: 0x50
	private bool _surfaceHit; //Field offset: 0x58
	private float _lastSpeedCovertCheck; //Field offset: 0x5C
	private ESurfaceSound _currentSurface; //Field offset: 0x60
	private LayerMask _stepLayerMask; //Field offset: 0x64
	private BaseSpeaker _speaker; //Field offset: 0x68
	private float _awareness; //Field offset: 0x70
	private bool _heavyBreath; //Field offset: 0x74
	private bool _muffled; //Field offset: 0x75
	private BetterSource _nestedStepSoundSource; //Field offset: 0x78
	private BetterSource _speechSource; //Field offset: 0x80
	private BetterSource _searchSource; //Field offset: 0x88
	private readonly SpeechInterruptFader _speechFade; //Field offset: 0x90
	private bool _nestedStepOcclusionRegistered; //Field offset: 0x98
	private bool _distanceDirty; //Field offset: 0x99
	private Sounds _playerSounds; //Field offset: 0xA0
	private AudioClip _fractureSound; //Field offset: 0xA8
	private bool _previousFaceShield; //Field offset: 0xB0
	private bool _previousNightVision; //Field offset: 0xB1
	private bool _previousThermalVision; //Field offset: 0xB2
	private AudioClip _faceshieldOnSound; //Field offset: 0xB8
	private AudioClip _faceshieldOffSound; //Field offset: 0xC0
	private AudioClip _nightVisionOnSound; //Field offset: 0xC8
	private AudioClip _nightVisionOffSound; //Field offset: 0xD0
	private AudioClip _thermalVisionOnSound; //Field offset: 0xD8
	private AudioClip _thermalVisionOffSound; //Field offset: 0xE0
	private AudioClip _switchHeadlights; //Field offset: 0xE8
	private Dictionary _soundBySurface; //Field offset: 0xF0
	private SurfaceSet _currentSet; //Field offset: 0xF8
	private SoundBank _gearSoundBank; //Field offset: 0x100
	private SoundBank _gearMediumSoundBank; //Field offset: 0x108
	private SoundBank _gearFastSoundBank; //Field offset: 0x110
	private SoundBank _backpackDropBank; //Field offset: 0x118
	private Coroutine _idleCoroutine; //Field offset: 0x120
	private Coroutine _runCoroutine; //Field offset: 0x128
	private Coroutine _sprintCoroutine; //Field offset: 0x130
	private Coroutine _outOfRangeSpeakingCoroutine; //Field offset: 0x138
	private bool _playedAtLeastOneStep; //Field offset: 0x140
	private float _nextJumpAfter; //Field offset: 0x144
	private bool _exhaustionIsAudible; //Field offset: 0x148
	private float _nextSurfaceCheckTime; //Field offset: 0x14C
	private float _sign; //Field offset: 0x150
	private float _lastStepTime; //Field offset: 0x154
	private Dictionary _lastPlayedHeadDeviceStatus; //Field offset: 0x158
	private float _lastTimeTurnSound; //Field offset: 0x160
	private float _distance; //Field offset: 0x164
	private bool _enqueuedForRelease; //Field offset: 0x168
	private Action _voipSourceBinding; //Field offset: 0x170
	private ETagStatus _fraction; //Field offset: 0x178
	private float _headphonesRolloffMultiplier; //Field offset: 0x17C
	private float _maxSpeed; //Field offset: 0x180
	private GenericEventTranslator _eventTranslator; //Field offset: 0x188
	private bool _isOnSoftSurface; //Field offset: 0x190
	private ObservedPlayerStepsImitator _stepsImitator; //Field offset: 0x198
	private IPlayerStepAudioController _specificStepAudioController; //Field offset: 0x1A0
	private BaseVaultingAudioController _vaultAudioController; //Field offset: 0x1A8
	private BaseVaultingAudioController _sprintVaultAudioController; //Field offset: 0x1B0
	private BaseVaultingAudioController _climbAudioController; //Field offset: 0x1B8
	private ISoundInteractionController _tripwireInteractionSoundController; //Field offset: 0x1C0
	private Action _unsubscribeOnDestroy; //Field offset: 0x1C8
	private bool _isFirstStepSoundPlaying; //Field offset: 0x1D0
	private bool _disposed; //Field offset: 0x1D1
	private readonly WaitForSeconds _firstStepDelay; //Field offset: 0x1D8
	private AudioSourcePrewarmer _sourcePrewarmer; //Field offset: 0x1E0
	private IDropBackPackEvents _dropBackPackEvents; //Field offset: 0x1E8
	private AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x1F0
	private int _animatorFootstepCurveHash; //Field offset: 0x1F8
	private readonly Dictionary _cachedMovementRolloff; //Field offset: 0x200
	private ClientAudioSettings _clientAudioSettings; //Field offset: 0x208
	private PlayerAudioSettings _playerAudioSettings; //Field offset: 0x210
	private AnimationCurve _landingVolumeCurve; //Field offset: 0x218
	[CompilerGenerated]
	private IPlayerCustomAudioSettings <CustomAudioSettings>k__BackingField; //Field offset: 0x220
	private bool _prevAimState; //Field offset: 0x228
	[CompilerGenerated]
	private float <CovertMovementEfficiency>k__BackingField; //Field offset: 0x22C

	public event Action PhraseSituation
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public float AimingVolumeReduction
	{
		 get { } //Length: 49
	}

	private float AnimatorFootstepSign
	{
		private get { } //Length: 125
	}

	public float BotSoundMovementOverallVolumeMult
	{
		 get { } //Length: 57
	}

	private bool BreathIsAudible
	{
		private get { } //Length: 48
	}

	public float CovertEquipmentNoise
	{
		 get { } //Length: 77
	}

	public private float CovertMovementEfficiency
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float CovertMovementEquipment
	{
		 get { } //Length: 49
	}

	public float CovertMovementHardSurfaceReduction
	{
		 get { } //Length: 49
	}

	public float CovertMovementSoftSurfaceReduction
	{
		 get { } //Length: 49
	}

	public float CovertMovementSpeed
	{
		 get { } //Length: 49
	}

	private EPlayerState CurrentMovementState
	{
		private get { } //Length: 111
	}

	public private IPlayerCustomAudioSettings CustomAudioSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float DefaultRolloff
	{
		 get { } //Length: 79
	}

	private float Distance
	{
		private get { } //Length: 254
	}

	public private EnvironmentType Environment
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private float FootStepSign
	{
		private get { } //Length: 72
	}

	private bool FootStepSimulation
	{
		private get { } //Length: 32
	}

	private bool IsHeavyBreathing
	{
		private get { } //Length: 48
	}

	private float MaxFallTimeByState
	{
		private get { } //Length: 41
	}

	private float MinStepSoundBlendValue
	{
		private get { } //Length: 49
	}

	private float Overweight
	{
		private get { } //Length: 49
	}

	public float PerkBushNoiseMultiplier
	{
		 get { } //Length: 49
	}

	private ObservedPlayerInfoContainer PlayerInfo
	{
		private get { } //Length: 39
	}

	private EPointOfView PointOfView
	{
		private get { } //Length: 34
	}

	private EPlayerState PrevMovementState
	{
		private get { } //Length: 111
	}

	public private SoundElement PropIn
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private SoundElement PropOut
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private float ProtagonistHearing
	{
		private get { } //Length: 101
	}

	private float SinceLastStep
	{
		private get { } //Length: 83
	}

	private float SoundRadiusByOverweight
	{
		private get { } //Length: 49
	}

	private BetterSource SpeechSource
	{
		private get { } //Length: 225
	}

	private ObservedPlayerStateContext StateContext
	{
		private get { } //Length: 51
	}

	private BetterSource VoipAudioSource
	{
		private get { } //Length: 48
	}

	private float WalkOverweight
	{
		private get { } //Length: 49
	}

	private static ObservedPlayerAudioController() { }

	public ObservedPlayerAudioController() { }

	[CompilerGenerated]
	public void add_PhraseSituation(Action value) { }

	private void ApplyAimingCommand(AimingCommandMessage aimingCommandMessage) { }

	public void ApplyDeath(CreateCorpsePacket deathPacket) { }

	private void ApplyEffectOnPlayerCommand(EffectOnPlayerStatusCommandMessage effectOnPlayerStatusCommandMessage) { }

	private void ApplyHeadDeviceStatusCommand(HeadDeviceStatusCommandMessage headDeviceStatusCommandMessage) { }

	private void ApplyMovementListenPointOfView() { }

	public void ApplyMovementModel(ObservedPlayerMovementModel nextModel) { }

	private void ApplyShotCommand() { }

	public void ApplySpectating(bool spectate) { }

	private void ApplyTakeDamageCommand(SoundDamageInfoCommandMessage takeDamageCommandMessage) { }

	private void ApplyTripwireSoundInteraction(TripwireSoundInteractionCommandMessage tripwireSoundMessage) { }

	private void ApplyUnderRoofStatus(SetUnderRoofStatusMessage underRoofStatusMessage) { }

	private void ApplyVoiceMuffledCommand(SetVoiceMuffledStatusMessage voiceMuffledStatusMessage) { }

	private void BackpackDropEventHandler(IAnimatorEventParameter animatorEventParameter) { }

	public float CalculateAimingVolume() { }

	private float CalculateBaseAimingVolume() { }

	private float CalculateCovertVolumeMultiplier() { }

	private float CalculateMovementRolloff(EAudioMovementState movementState = 0, bool includeSpeedMult = false) { }

	private ValueTuple CalculateMovementSurface() { }

	private float CalculateMovementVolumeDefaultMultiplier(EAudioMovementState movementState) { }

	private Vector3 CalculatePosWithSpeechOffset() { }

	private float CalculateRolloff(float defaultRolloff) { }

	private float CalculateSpeedMult() { }

	private float CalculateStepSoundSpeedRolloffMult() { }

	private float CalculateStepSoundVolumeSpeedFactor() { }

	private bool CanPlayLandingSound(float landingHeight) { }

	private bool CheckSurface(float range) { }

	private void CreateNestedSource() { }

	private void CreateSpeechSource(bool onDeadPlayer = false) { }

	private void CreateTripWireInteractionController(IPlayer observedPlayer) { }

	public void DefaultPlay(SoundBank bank, float volume = 1, EAudioMovementState movementState = 0) { }

	public void Dispose() { }

	private void DisposeSoundControllers() { }

	private float DistanceFromProtagonistHearingEdge(float spreadRange, bool buffer = true) { }

	private void EnsureStepOcclusionRegistered() { }

	private void EnterMountedStateHandler(float timeToMount) { }

	public void Execute(ICommandMessage command) { }

	private void ExitMountedStateHandler(float timeToUnmount) { }

	public float get_AimingVolumeReduction() { }

	private float get_AnimatorFootstepSign() { }

	public float get_BotSoundMovementOverallVolumeMult() { }

	private bool get_BreathIsAudible() { }

	public float get_CovertEquipmentNoise() { }

	[CompilerGenerated]
	public float get_CovertMovementEfficiency() { }

	public float get_CovertMovementEquipment() { }

	public float get_CovertMovementHardSurfaceReduction() { }

	public float get_CovertMovementSoftSurfaceReduction() { }

	public float get_CovertMovementSpeed() { }

	private EPlayerState get_CurrentMovementState() { }

	[CompilerGenerated]
	public IPlayerCustomAudioSettings get_CustomAudioSettings() { }

	public float get_DefaultRolloff() { }

	private float get_Distance() { }

	[CompilerGenerated]
	public EnvironmentType get_Environment() { }

	private float get_FootStepSign() { }

	private bool get_FootStepSimulation() { }

	private bool get_IsHeavyBreathing() { }

	private float get_MaxFallTimeByState() { }

	private float get_MinStepSoundBlendValue() { }

	private float get_Overweight() { }

	public float get_PerkBushNoiseMultiplier() { }

	private ObservedPlayerInfoContainer get_PlayerInfo() { }

	private EPointOfView get_PointOfView() { }

	private EPlayerState get_PrevMovementState() { }

	[CompilerGenerated]
	public SoundElement get_PropIn() { }

	[CompilerGenerated]
	public SoundElement get_PropOut() { }

	private float get_ProtagonistHearing() { }

	private float get_SinceLastStep() { }

	private float get_SoundRadiusByOverweight() { }

	private BetterSource get_SpeechSource() { }

	private ObservedPlayerStateContext get_StateContext() { }

	private BetterSource get_VoipAudioSource() { }

	private float get_WalkOverweight() { }

	private float GetAverageRotationSpeed() { }

	private float GetCachedRolloff(EAudioMovementState movementState) { }

	private float GetCurrentSurfaceReduction() { }

	private float GetMaxCovertVolumeMultiplier() { }

	private void GroundedStateHandler(float fallHeight, float jumpHeight) { }

	private void HandleSeasonController() { }

	[IteratorStateMachine(typeof(<Idle>d__263))]
	private IEnumerator Idle(EPlayerState state = 1) { }

	public void IncreaseAwareness(float aware = 5) { }

	private void InitGlobalsPlayerAudioSettings() { }

	public void Initialize(ObservedPlayerView observedPlayer, ObservedPlayerSpawnMessage spawnMessage) { }

	private void InitializeHeadDevicesDefaultStatuses() { }

	private void InitSeasonStepLayerController(ESeasonStatus seasonStatus) { }

	public void InitVaultingAudioControllers(ObservedPlayerView observedPlayer) { }

	private bool IsAiUseSimpleSkeleton() { }

	private bool IsBankNull(SoundBank bank, EAudioMovementState movementState) { }

	private bool IsPrevStateClimb() { }

	private void LateUpdate() { }

	public void ManualUpdate() { }

	private void OnDestroy() { }

	private void OnPhraseTold(EPhraseTrigger event, TaggedClip clip, TagBank bank, BaseSpeaker speaker) { }

	public void OnPlayerDeath(EBodyPart lastDamagedBodyPart, EDamageType lastDamageType) { }

	public void OnPlayerGetDamage(float damage, EDamageType damageType) { }

	private void OnProtagonistHearingChanged() { }

	private void OnRolloffChanged(HeadphonesUpdateEvent headphonesUpdateEvent) { }

	private void OnSeasonControllerInit(ISeasonsController controller) { }

	private void OnSpeakerRelease(bool force) { }

	private void OnSpeechInterrupted(BaseSpeaker speaker, bool hasReplacement) { }

	private bool OutOfProtagonistsRange(float spreadRange, bool buffer = true) { }

	[IteratorStateMachine(typeof(<OutOfRangeSpeakingCoroutine>d__218))]
	private IEnumerator OutOfRangeSpeakingCoroutine(float distance) { }

	private void PlayAtPoint(Vector3 pos, AudioClip clip, int rolloff, float volume = 1) { }

	public void PlayFaceShieldSound(bool isOn) { }

	public void PlayFractureSound() { }

	private void PlayGearSound(float volume = 1, bool fast = false) { }

	private void PlayLandingSound(SoundBank bank, float balance, float volume = 1) { }

	public void PlayNightVisionSound(bool isOn) { }

	private void PlayPhraseClip(TaggedClip clip) { }

	public void PlayPhraseFromCommand(PhraseCommandMessage phraseCommandMessage) { }

	private void PlayPrewarmSound(BetterSource source) { }

	private void PlaySearchSound(StartSearchContentMessage contentMessage) { }

	private void PlaySingleGearSound(SoundBank bank, float volume = 1) { }

	private void PlaySoundBank(string soundBank) { }

	private void PlaySpeechFromTime(TaggedClip clip, float time) { }

	private void PlaySprintGearSound() { }

	private void PlayStepSound() { }

	public void PlaySwitchHeadlightsSound() { }

	public void PlayThermalVisionSound(bool isOn) { }

	private void PlayToggleSound(bool isOn, AudioClip toggleOn, AudioClip toggleOff) { }

	private void PlayTurnSound(float speed = 55) { }

	private void RefreshSearchSourcePointOfView() { }

	private void ReleaseNestedSource(bool forced = false) { }

	public void ReleaseSearchSource() { }

	private void ReleaseSources(bool forced = false) { }

	private void ReleaseSpeaker() { }

	private void ReleaseSpeechSource() { }

	[CompilerGenerated]
	public void remove_PhraseSituation(Action value) { }

	[IteratorStateMachine(typeof(<Run>d__264))]
	private IEnumerator Run(EPlayerState state = 4) { }

	private void Say(EPhraseTrigger phraseTrigger, bool demand = false, float delay = 0, ETagStatus mask = 0, bool aggressive = false) { }

	[CompilerGenerated]
	private void set_CovertMovementEfficiency(float value) { }

	[CompilerGenerated]
	private void set_CustomAudioSettings(IPlayerCustomAudioSettings value) { }

	[CompilerGenerated]
	private void set_Environment(EnvironmentType value) { }

	[CompilerGenerated]
	private void set_PropIn(SoundElement value) { }

	[CompilerGenerated]
	private void set_PropOut(SoundElement value) { }

	public void SetCustomSettings(WildSpawnType wildSpawnType) { }

	private void SetEnvironment(int playerRaidId, EnvironmentType environmentType) { }

	private void SetRolloff(BetterSource source, float rolloff) { }

	[IteratorStateMachine(typeof(<Sprint>d__262))]
	private IEnumerator Sprint(EPlayerState state = 5) { }

	private void StartSearchSourcePlayback(AudioClip clip) { }

	private void StateChangedHandler(EPlayerState previousState, EPlayerState nextState) { }

	private void StopCoroutineIfNotNull(ref Coroutine coroutine) { }

	private void StopOutOfRangeSpeakingCoroutine() { }

	private void StopSoundCoroutines() { }

	private void SubscribeBackpackDropEvents() { }

	public void ToggleMuteSpeechSource(bool muteSpeech) { }

	private void TryPlayStopRecorderSound(UseRecorderCommandMessage recorderCommand) { }

	private void UnsubscribeAudio() { }

	private void UpdateBreathStatus(bool isHeavyBreathing, bool force = false) { }

	private void UpdateCovertEfficiency(float speed, bool force = false) { }

	private void UpdateExhaustionAudibility(bool isHeavyBreathing, bool breathIsAudible) { }

	private void UpdateSourcePriority(BetterSource source) { }

	private void UpdateSpectatorVisorStepFrequency(float timeSinceLastStep, bool isSprint) { }

	private void UpdateSpeechMixerGroup() { }

	private void UpdateStepImitator() { }

	private void UpdateStepSourceRolloff(EAudioMovementState movementState = 0, bool includeSpeedMult = false) { }

	private void UpdateSurfaceData(bool hit, ESurfaceSound surfaceSound) { }

	private void UpdateVoipParameters() { }

}

