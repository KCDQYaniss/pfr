namespace Audio.Vehicles.BTR;

public class BtrSoundController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <TransitionCoroutine>d__45 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float transitionTime; //Field offset: 0x20
		public BtrSoundController <>4__this; //Field offset: 0x28
		public EnvironmentType environment; //Field offset: 0x30
		public Action callback; //Field offset: 0x38
		private float <startTime>5__2; //Field offset: 0x40
		private float <elapsedTime>5__3; //Field offset: 0x44

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
		public <TransitionCoroutine>d__45(int <>1__state) { }

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

	private const float MIN_TRANSITION_TIME = 0.1; //Field offset: 0x0
	[SerializeField]
	private SoundSuspensionController _suspensionController; //Field offset: 0x20
	[SerializeField]
	private VehicleMovementSoundContext _indoorSoundContext; //Field offset: 0x28
	[SerializeField]
	private VehicleMovementSoundContext _outdoorSoundContext; //Field offset: 0x30
	[SerializeField]
	private SpatialAudioRoom _btrIndoorRoom; //Field offset: 0x38
	[SerializeField]
	private VehicleRotationSoundPlayer _indoorTurret; //Field offset: 0x40
	[SerializeField]
	private VehicleRotationSoundPlayer _outdoorTurret; //Field offset: 0x48
	[SerializeField]
	private BtrDriverSoundBankContainer _btrDriverSoundContainer; //Field offset: 0x50
	[SerializeField]
	private Transform _driverTransform; //Field offset: 0x58
	[SerializeField]
	private List _readyToDepartureClips; //Field offset: 0x60
	[SerializeField]
	private float _readyToDepartureBTRSignalDelay; //Field offset: 0x68
	[SerializeField]
	private BtrDoorSoundHandler[] _doorSoundHandlers; //Field offset: 0x70
	[SerializeField]
	private ClientBroadcastPlayer _broadcastPlayer; //Field offset: 0x78
	[SerializeField]
	private float _airHornVolume; //Field offset: 0x80
	private BetterSource _airHornSource; //Field offset: 0x88
	private readonly Dictionary _contextByEnvironment; //Field offset: 0x90
	private IPhraseController _phraseController; //Field offset: 0x98
	private Coroutine _transitionCoroutine; //Field offset: 0xA0
	private BTRView _btrView; //Field offset: 0xA8
	private bool _initialized; //Field offset: 0xB0
	private float _currentNormalizedSpeed; //Field offset: 0xB4
	private float _goInDurationSeconds; //Field offset: 0xB8
	private float _goOutDurationSeconds; //Field offset: 0xBC
	private bool _soundStarted; //Field offset: 0xC0
	private SpectatorBtrEnvironmentSync _spectatorBtrEnvironmentSync; //Field offset: 0xC8
	private Action _unsubscribeOnDestroy; //Field offset: 0xD0

	public bool IsInitialized
	{
		 get { } //Length: 8
	}

	public BtrSoundController() { }

	[CompilerGenerated]
	private void <StartSound>b__30_0() { }

	private float CalculateNormalizedSpeed() { }

	public void EndObservedPassengerTransition(ObservedPlayerView player) { }

	public bool get_IsInitialized() { }

	private float GetEnvironmentTransitionDuration(EnvironmentType environment, bool fast) { }

	public void Initialize(BTRView btrView, float goInDurationMs, float goOutDurationMs) { }

	public void NotifyTargetBtrTransition(ObservedPlayerView player, bool fast) { }

	private void OnBtrPauseMoveChanged(BtrPauseMoveEvent moveEvent) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnReadyToDeparture(BtrReadyToDepartureEvent readyToDepartureEvent) { }

	private void SetAirHornSourceEnvironment(EnvironmentType environment) { }

	private void SetDoorsEnvironment(EnvironmentType environment) { }

	private void SetRadioMuteState(EnvironmentType environment) { }

	private void StartSound() { }

	private void StopTransitionCoroutine() { }

	private void Subscribe() { }

	public void SyncSpectatorListenerRoom(EnvironmentType environment, IPlayer player) { }

	[IteratorStateMachine(typeof(<TransitionCoroutine>d__45))]
	private IEnumerator TransitionCoroutine(EnvironmentType environment, float transitionTime, Action callback = null) { }

	public void TransitToEnvironment(EnvironmentType environment, bool fast = false, Action callback = null) { }

	private void TransitToEnvironmentInternal(EnvironmentType environment, float time, Action callback = null) { }

	private void Unsubscribe() { }

	public void Update() { }

	public void UpdateBtrAudioRoom(EnvironmentType environment, IPlayer player, Nullable btrBotID) { }

	private void UpdateBtrAudioRoom(EnvironmentType environment, IPlayer player) { }

	private void UpdateParams(IVolumeControl inControl, IVolumeControl outControl, EnvironmentType environment, float t) { }

}

