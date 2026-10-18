namespace EFT.NextObservedPlayer;

public class ObservedPlayerVoIP : MonoBehaviour, IDissonancePlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__56_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__56_0(AudioSource source) { }

	}

	private const float VOIP_FADE_IN_TIME_MS = 50; //Field offset: 0x0
	private const float VOIP_FADE_OUT_TIME_MS = 150; //Field offset: 0x0
	private AudioSource _voipAudioSource; //Field offset: 0x20
	[CompilerGenerated]
	private BetterSource <VoipEftSource>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private IPlayerVoipController <VoipController>k__BackingField; //Field offset: 0x30
	private ObservedPlayerView _observedPlayer; //Field offset: 0x38
	private VoiceBroadcastTrigger _broadcastTrigger; //Field offset: 0x40
	private SoundSettingsGroup _soundSettings; //Field offset: 0x48
	private readonly CompositeDisposable CompositeDisposable; //Field offset: 0x50
	[CompilerGenerated]
	private DissonanceComms <DissonanceComms>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private EVoipState <VoipState>k__BackingField; //Field offset: 0x60
	private bool _disposed; //Field offset: 0x61
	private bool _sourceInitialized; //Field offset: 0x62
	private float _rolloff; //Field offset: 0x64
	[CompilerGenerated]
	private Action OnVoipSourceCreated; //Field offset: 0x68

	public event Action OnVoipSourceCreated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private DissonanceComms DissonanceComms
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool IsTracking
	{
		 get { } //Length: 113
	}

	public override string PlayerId
	{
		 get { } //Length: 30
	}

	public override Vector3 Position
	{
		 get { } //Length: 346
	}

	public override Quaternion Rotation
	{
		 get { } //Length: 339
	}

	public override NetworkPlayerType Type
	{
		 get { } //Length: 6
	}

	public override AudioSource VoipAudioSource
	{
		 get { } //Length: 5
		 set { } //Length: 307
	}

	public IPlayerVoipController VoipController
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private BetterSource VoipEftSource
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private EVoipState VoipState
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ObservedPlayerVoIP() { }

	[CompilerGenerated]
	private void <AddVoiceBroadcastTrigger>b__49_0(int value) { }

	[CompilerGenerated]
	public void add_OnVoipSourceCreated(Action value) { }

	private void AddVoiceBroadcastTrigger() { }

	private void ApplyVoIPStatusCommand(VoIPCommandMessage voIPCommandMessage) { }

	private bool CheckIsHeard(in Vector3 voicePos, float sqrDistance) { }

	public void Dispose() { }

	public void Execute(ICommandMessage command) { }

	[CompilerGenerated]
	private DissonanceComms get_DissonanceComms() { }

	public override bool get_IsTracking() { }

	public override string get_PlayerId() { }

	public override Vector3 get_Position() { }

	public override Quaternion get_Rotation() { }

	public override NetworkPlayerType get_Type() { }

	public override AudioSource get_VoipAudioSource() { }

	[CompilerGenerated]
	public IPlayerVoipController get_VoipController() { }

	[CompilerGenerated]
	public BetterSource get_VoipEftSource() { }

	[CompilerGenerated]
	private EVoipState get_VoipState() { }

	private void InitializeVoipSource(AudioSource source) { }

	public void InitVoip(ObservedPlayerView player, EVoipState voipState) { }

	public ValueTuple IsHeard(in Vector3 voicePos, float sqrDistance) { }

	private void OnDestroy() { }

	public void RegisterInOcclusion() { }

	[CompilerGenerated]
	public void remove_OnVoipSourceCreated(Action value) { }

	[CompilerGenerated]
	private void set_DissonanceComms(DissonanceComms value) { }

	public override void set_VoipAudioSource(AudioSource value) { }

	[CompilerGenerated]
	protected void set_VoipController(IPlayerVoipController value) { }

	[CompilerGenerated]
	private void set_VoipEftSource(BetterSource value) { }

	[CompilerGenerated]
	private void set_VoipState(EVoipState value) { }

	public void SetRolloff(float rolloff) { }

	public void SetSpatialBlend(float spatialBlend) { }

	private void SetVoIPState(EVoipState voipState) { }

	private void TrackPlayerPosition() { }

}

