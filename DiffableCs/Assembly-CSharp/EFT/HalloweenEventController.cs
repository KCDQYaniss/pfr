namespace EFT;

public sealed class HalloweenEventController : IDisposable
{
	[CompilerGenerated]
	private struct <Init>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HalloweenEventController <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static Action OnInitialized; //Field offset: 0x0
	private readonly CancellationTokenSource _initializeCancellationTokenSource; //Field offset: 0x10
	private int _eventTime; //Field offset: 0x18
	private int _secondsToChange; //Field offset: 0x1C
	private WeatherEventSettings _summonSuccessWeather; //Field offset: 0x20
	private WeatherEventSettings _startEventWeather; //Field offset: 0x28
	private WeatherEventSettings _summonFailedWeather; //Field offset: 0x30
	private bool _initialized; //Field offset: 0x38
	private Action _eventStartedUnsubscribe; //Field offset: 0x40
	private Action _eventStateUnsubscribe; //Field offset: 0x48
	private DateTime _cachedDateTime; //Field offset: 0x50
	private DateTime _summonStartTime; //Field offset: 0x58
	private EEventState _eventState; //Field offset: 0x60
	private Vector3 _ritualPosition; //Field offset: 0x64
	private bool _dateTimeCached; //Field offset: 0x70
	private string _exitNameToSave; //Field offset: 0x78
	private HalloweenEventVisual _halloweenVisual; //Field offset: 0x80
	private Action _eventExitsUnsubscribe; //Field offset: 0x88

	public static event Action OnInitialized
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	public static HalloweenEventController Instance
	{
		 get { } //Length: 241
	}

	public HalloweenEventController() { }

	[CompilerGenerated]
	private bool <UpdateExits>b__28_0(ExfiltrationPoint ep) { }

	[CompilerGenerated]
	public static void add_OnInitialized(Action value) { }

	private void CacheCurrentTime(DateTime initialTime) { }

	public void DebugAllPlaces() { }

	private void DisableExitsExceptOne() { }

	private void DisableWeatherEvent() { }

	public override void Dispose() { }

	private void EnableWeatherEvent(WeatherEventSettings desiredWeather, bool force = false) { }

	public static HalloweenEventController get_Instance() { }

	public void HandleReconnect(SyncClientEventState syncEvent) { }

	[AsyncStateMachine(typeof(<Init>d__23))]
	private Task Init(CancellationToken cancellationToken) { }

	public void RegisterClientVisual(HalloweenEventVisual container) { }

	[CompilerGenerated]
	public static void remove_OnInitialized(Action value) { }

	private void ResetWeather() { }

	private void RitualStartedHandler(HalloweenSummonStartedEvent halloweenSummonStartedEvent) { }

	public void SetEventState(EEventState eventState, bool force = false) { }

	private void StartEvent(bool force = false) { }

	private void StartSummon(bool force = false) { }

	private void StopEvent() { }

	private void SummonEnd(EEventState state, bool force = false) { }

	private void SyncEventStateHandler(HalloweenSyncStateEvent syncEvent) { }

	private void SyncExitsState(HalloweenSyncExitsEvent exitsEvent) { }

	private void UpdateExits(string exitName) { }

}

