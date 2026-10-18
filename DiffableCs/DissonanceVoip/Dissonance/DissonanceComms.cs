namespace Dissonance;

[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Reference/Components/Dissonance-Comms/")]
public sealed class DissonanceComms : MonoBehaviour, IPriorityManager, IAccessTokenCollection, IChannelPriorityProvider, IVolumeProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__89_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Initialize>b__89_0(string current, MonoBehaviour component) { }

	}

	[CompilerGenerated]
	private sealed class <CoResumePlayback>d__95 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DissonanceComms <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

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
		public <CoResumePlayback>d__95(int <>1__state) { }

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

	private static readonly Log Log; //Field offset: 0x0
	public static string ClientPlayerId; //Field offset: 0x8
	[CompilerGenerated]
	private static DissonanceComms <Instance>k__BackingField; //Field offset: 0x10
	public static readonly SemanticVersion Version; //Field offset: 0x18
	[SerializeField]
	[UsedImplicitly]
	private string _lastPrefabError; //Field offset: 0x20
	private bool _started; //Field offset: 0x28
	private readonly Rooms _rooms; //Field offset: 0x30
	private readonly PlayerChannels _playerChannels; //Field offset: 0x38
	private readonly RoomChannels _roomChannels; //Field offset: 0x40
	private readonly TextChat _text; //Field offset: 0x48
	private readonly OpenChannelVolumeDuck _autoChannelDuck; //Field offset: 0x50
	private readonly PlayerTrackerManager _playerTrackers; //Field offset: 0x58
	private readonly PlaybackPool _playbackPool; //Field offset: 0x60
	private readonly PlayerCollection _players; //Field offset: 0x68
	private readonly CodecSettingsLoader _codecSettingsLoader; //Field offset: 0x70
	private readonly PriorityManager _playbackPriorityManager; //Field offset: 0x78
	private readonly CapturePipelineManager _capture; //Field offset: 0x80
	private ICommsNetwork _net; //Field offset: 0x88
	private string _localPlayerName; //Field offset: 0x90
	[SerializeField]
	[UsedImplicitly]
	private bool _isMuted; //Field offset: 0x98
	[SerializeField]
	[UsedImplicitly]
	private bool _isDeafened; //Field offset: 0x99
	[SerializeField]
	[UsedImplicitly]
	private float _oneMinusBaseRemoteVoiceVolume; //Field offset: 0x9C
	[SerializeField]
	[UsedImplicitly]
	private VoicePlayback _playbackPrefab; //Field offset: 0xA0
	[SerializeField]
	[UsedImplicitly]
	private GameObject _playbackPrefab2; //Field offset: 0xA8
	[SerializeField]
	[UsedImplicitly]
	private string _micName; //Field offset: 0xB0
	[SerializeField]
	[UsedImplicitly]
	private ChannelPriority _playerPriority; //Field offset: 0xB8
	[SerializeField]
	[UsedImplicitly]
	private TokenSet _tokens; //Field offset: 0xC0
	[CompilerGenerated]
	private Action OnPlayerJoinedSession; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnPlayerLeftSession; //Field offset: 0xD0
	[CompilerGenerated]
	private Action OnPlayerStartedSpeaking; //Field offset: 0xD8
	[CompilerGenerated]
	private Action OnPlayerStoppedSpeaking; //Field offset: 0xE0
	[CompilerGenerated]
	private Action OnPlayerEnteredRoom; //Field offset: 0xE8
	[CompilerGenerated]
	private Action OnPlayerExitedRoom; //Field offset: 0xF0
	[CompilerGenerated]
	private Action LocalPlayerNameChanged; //Field offset: 0xF8
	private bool _muteAllRemoteVoices; //Field offset: 0x100
	private Coroutine _resumeCo; //Field offset: 0x108

	public event Action LocalPlayerNameChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerEnteredRoom
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerExitedRoom
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerJoinedSession
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerLeftSession
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerStartedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerStoppedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action TokenAdded
	{
		 add { } //Length: 33
		 remove { } //Length: 286
	}

	public event Action TokenRemoved
	{
		 add { } //Length: 33
		 remove { } //Length: 286
	}

	private override ChannelPriority Dissonance.Audio.Capture.IChannelPriorityProvider.DefaultChannelPriority
	{
		private get { } //Length: 7
		private set { } //Length: 7
	}

	private override ChannelPriority Dissonance.Audio.Playback.IPriorityManager.TopPriority
	{
		private get { } //Length: 26
	}

	private override float Dissonance.Audio.Playback.IVolumeProvider.TargetVolume
	{
		private get { } //Length: 94
	}

	public private static DissonanceComms Instance
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		private set { } //Length: 183
	}

	public bool IsDeafened
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public bool IsMuted
	{
		 get { } //Length: 8
		 set { } //Length: 145
	}

	public bool IsNetworkInitialized
	{
		 get { } //Length: 93
	}

	internal bool IsStarted
	{
		internal get { } //Length: 5
	}

	public string LocalPlayerName
	{
		 get { } //Length: 8
		 set { } //Length: 388
	}

	[CanBeNull]
	public IMicrophoneCapture MicrophoneCapture
	{
		 get { } //Length: 30
	}

	[CanBeNull]
	public string MicrophoneName
	{
		 get { } //Length: 8
		 set { } //Length: 193
	}

	private bool MuteAllRemoteVoices
	{
		private get { } //Length: 8
		private set { } //Length: 15
	}

	internal float PacketLoss
	{
		internal get { } //Length: 40
	}

	public GameObject PlaybackPrefab
	{
		 get { } //Length: 8
		 set { } //Length: 679
	}

	[NotNull]
	public PlayerChannels PlayerChannels
	{
		 get { } //Length: 5
	}

	public ChannelPriority PlayerPriority
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	[NotNull]
	public ReadOnlyCollection Players
	{
		 get { } //Length: 27
	}

	public float RemoteVoiceVolume
	{
		 get { } //Length: 40
		 set { } //Length: 235
	}

	[NotNull]
	public RoomChannels RoomChannels
	{
		 get { } //Length: 5
	}

	[NotNull]
	public Rooms Rooms
	{
		 get { } //Length: 76
	}

	[NotNull]
	public TextChat Text
	{
		 get { } //Length: 5
	}

	[NotNull]
	public override IEnumerable Tokens
	{
		 get { } //Length: 8
	}

	public ChannelPriority TopPrioritySpeaker
	{
		 get { } //Length: 26
	}

	private static DissonanceComms() { }

	public DissonanceComms() { }

	[CompilerGenerated]
	private ICommsNetwork <.ctor>b__47_0() { }

	[CompilerGenerated]
	public void add_LocalPlayerNameChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerJoinedSession(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerLeftSession(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerStoppedSpeaking(Action value) { }

	public void add_TokenAdded(Action value) { }

	public void add_TokenRemoved(Action value) { }

	public override bool AddToken(string token) { }

	private void Awake() { }

	public override bool ContainsToken(string token) { }

	[IteratorStateMachine(typeof(<CoResumePlayback>d__95))]
	private IEnumerator CoResumePlayback() { }

	private override ChannelPriority Dissonance.Audio.Capture.IChannelPriorityProvider.get_DefaultChannelPriority() { }

	private override void Dissonance.Audio.Capture.IChannelPriorityProvider.set_DefaultChannelPriority(ChannelPriority value) { }

	private override ChannelPriority Dissonance.Audio.Playback.IPriorityManager.get_TopPriority() { }

	private override float Dissonance.Audio.Playback.IVolumeProvider.get_TargetVolume() { }

	[CanBeNull]
	public VoicePlayerState FindPlayer(string playerId) { }

	[CompilerGenerated]
	public static DissonanceComms get_Instance() { }

	public bool get_IsDeafened() { }

	public bool get_IsMuted() { }

	public bool get_IsNetworkInitialized() { }

	internal bool get_IsStarted() { }

	public string get_LocalPlayerName() { }

	public IMicrophoneCapture get_MicrophoneCapture() { }

	public string get_MicrophoneName() { }

	private bool get_MuteAllRemoteVoices() { }

	internal float get_PacketLoss() { }

	public GameObject get_PlaybackPrefab() { }

	public PlayerChannels get_PlayerChannels() { }

	public ChannelPriority get_PlayerPriority() { }

	public ReadOnlyCollection get_Players() { }

	public float get_RemoteVoiceVolume() { }

	public RoomChannels get_RoomChannels() { }

	public Rooms get_Rooms() { }

	public TextChat get_Text() { }

	public override IEnumerable get_Tokens() { }

	public ChannelPriority get_TopPrioritySpeaker() { }

	public void GetMicrophoneDevices(List output) { }

	private IMicrophoneCapture GetOrAddMicrophone() { }

	public bool HasAnyToken(TokenSet tokens) { }

	public void Initialize() { }

	private void Net_PlayerJoined(string playerId, CodecSettings codecSettings) { }

	private void Net_PlayerLeft(string playerId) { }

	private void Net_PlayerRoomEvent(RoomEvent evt) { }

	private void Net_PlayerStartedSpeaking(string player) { }

	private void Net_PlayerStoppedSpeaking(string player) { }

	private void Net_VoicePacketReceived(VoicePacket packet) { }

	private void OnApplicationPause(bool paused) { }

	[UsedImplicitly]
	private void OnDestroy() { }

	[UsedImplicitly]
	private void OnDisable() { }

	[UsedImplicitly]
	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_LocalPlayerNameChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerJoinedSession(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerLeftSession(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerStoppedSpeaking(Action value) { }

	public void remove_TokenAdded(Action value) { }

	public void remove_TokenRemoved(Action value) { }

	public override bool RemoveToken(string token) { }

	public void ResetMicrophoneCapture() { }

	[CompilerGenerated]
	private static void set_Instance(DissonanceComms value) { }

	public void set_IsDeafened(bool value) { }

	public void set_IsMuted(bool value) { }

	public void set_LocalPlayerName(string value) { }

	public void set_MicrophoneName(string value) { }

	private void set_MuteAllRemoteVoices(bool value) { }

	public void set_PlaybackPrefab(GameObject value) { }

	public void set_PlayerPriority(ChannelPriority value) { }

	public void set_RemoteVoiceVolume(float value) { }

	public void StopTracking(IDissonancePlayer player) { }

	[Obsolete("Use `SubscribeToRecordedAudio` instead")]
	public void SubcribeToRecordedAudio(IMicrophoneSubscriber listener) { }

	public void SubcribeToVoiceActivation(IVoiceActivationListener listener) { }

	public void SubscribeToRecordedAudio(IMicrophoneSubscriber listener) { }

	public static void TestDependencies() { }

	public void TrackPlayerPosition(IDissonancePlayer player) { }

	public void UnsubscribeFromRecordedAudio(IMicrophoneSubscriber listener) { }

	public void UnsubscribeFromVoiceActivation(IVoiceActivationListener listener) { }

	[UsedImplicitly]
	private void Update() { }

}

