namespace Audio.AmbientSubsystem.GameEvents;

public class RunddansEventAudioPlayer : IGameEventAudioPlayer
{
	[CompilerGenerated]
	private struct <Init>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RunddansEventAudioPlayer <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private KeyValuePair <data>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadObject>d__36`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string path; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		private ResourceRequest <loadOperation>5__2; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string EVENT_SUCCESSFUL_CLIP_PATH = "Audio/Events/Runddans/runddans_quest_done"; //Field offset: 0x0
	private const string GENERATOR_INTERACTION_TAG = "Generator/Repair"; //Field offset: 0x0
	private const float FROSTBIT_COOLDOWN = 30; //Field offset: 0x0
	private const float MAX_PITCH = 1; //Field offset: 0x0
	private const float MAX_VOLUME_DB = 0; //Field offset: 0x0
	private const float MIN_PITCH = 0.1; //Field offset: 0x0
	private const float MIN_VOLUME_DB = -80; //Field offset: 0x0
	private const float PITCH_FADE_OUT_DURATION = 2; //Field offset: 0x0
	private const float MAX_DISTANCE_TO_PLAY_EVENT_CLIP = 100; //Field offset: 0x0
	private const float PITCH_FADE_IN_DURATION = 2; //Field offset: 0x0
	private const float VOLUME_FADE_IN_DURATION = 1; //Field offset: 0x0
	private const string EVENT_MIXER_PITCH = "EventRadioPitch"; //Field offset: 0x0
	private const string EVENT_MIXER_VOLUME = "EventRadioVolume"; //Field offset: 0x0
	private const string EVENT_MIXER_NAME = "EventRadio"; //Field offset: 0x0
	private const float VOLUME_FADE_OUT_DURATION = 3; //Field offset: 0x0
	private const string FROSTBITE_BANK_PATH = "Audio/Events/Runddans/FrozenBuff/RunddansFrozenBuffSoundBank"; //Field offset: 0x0
	private const string GENERATOR_REPAIR_CLIP_PATH = "Audio/Events/Runddans/generator_repair_loop"; //Field offset: 0x0
	private readonly AudioMixer _eventRadioMixer; //Field offset: 0x10
	private Action _unsubscribeOnStop; //Field offset: 0x18
	private EState _prevState; //Field offset: 0x20
	private CancellationTokenSource _tokenSource; //Field offset: 0x28
	private AudioClip _eventSuccessfulClip; //Field offset: 0x30
	private AudioClip _generatorRepairClip; //Field offset: 0x38
	private TagBank _frostbiteSoundBank; //Field offset: 0x40
	private EventObject _generatorData; //Field offset: 0x48
	private float _frostbiteSoundNextPlayTime; //Field offset: 0x50
	private int _myRaidId; //Field offset: 0x54
	private IHealthController _myPlayerHealthController; //Field offset: 0x58
	private BetterSource _playerInteractionSource; //Field offset: 0x60
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; //Field offset: 0x68

	public private override bool IsRunning
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RunddansEventAudioPlayer() { }

	private void GeneratorFinishedWorkHandler() { }

	private void GeneratorStateEventHandler(EState state) { }

	[CompilerGenerated]
	public override bool get_IsRunning() { }

	private void HandleMyPlayer() { }

	[AsyncStateMachine(typeof(<Init>d__35))]
	private Task Init() { }

	private bool IsMyPlayerInRunddans() { }

	[AsyncStateMachine(typeof(<LoadObject>d__36`1))]
	private Task LoadObject(string path, CancellationToken cancellationToken) { }

	private void MyPlayerEnvironmentChangedHandler(int playerRaidId, EnvironmentType environment) { }

	private void OnPersonAdded(IPlayer player) { }

	private void OnStateChanged(EState state) { }

	private void PlayerInteractionEventHandler(PlayerInteractionEvent interactionEvent) { }

	private void PlayFrostbiteEffect(IHealthEffect healthEffect) { }

	private void ResetMixerParams() { }

	public override void Run() { }

	[CompilerGenerated]
	private void set_IsRunning(bool value) { }

	public override void Stop() { }

}

