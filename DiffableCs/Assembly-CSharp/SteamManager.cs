//Type is in global namespace

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <MenuStatusTimerCoroutine>d__22 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SteamManager <>4__this; //Field offset: 0x20

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
		public <MenuStatusTimerCoroutine>d__22(int <>1__state) { }

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

	private const int MENU_ACTIONS_VARIANTS_COUNT = 6; //Field offset: 0x0
	private const int MAP_VARIANTS_COUNT = 3; //Field offset: 0x0
	public const string TRADING_RAGFAIR_VARIABLE = "Ragfair"; //Field offset: 0x0
	private static readonly Dictionary _statusTokens; //Field offset: 0x0
	private static readonly Dictionary _statusVariables; //Field offset: 0x8
	protected static bool s_EverInitialized; //Field offset: 0x10
	protected static SteamManager s_instance; //Field offset: 0x18
	private UpdateEftStatusEvent _pendingStatusEvent; //Field offset: 0x20
	private UpdateEftStatusEvent _currentStatusEvent; //Field offset: 0x28
	private Coroutine _menuStatusCoroutine; //Field offset: 0x30
	private DateTime _menuStatusStartTime; //Field offset: 0x38
	private bool _enabled; //Field offset: 0x40
	private float _menuStatusChangeDelaySeconds; //Field offset: 0x44
	protected bool m_bInitialized; //Field offset: 0x48
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook; //Field offset: 0x50

	public static bool Initialized
	{
		 get { } //Length: 84
	}

	public static bool InitializedInternal
	{
		 get { } //Length: 303
	}

	public static SteamManager Instance
	{
		 get { } //Length: 395
	}

	private static SteamManager() { }

	public SteamManager() { }

	protected override void Awake() { }

	public static bool get_Initialized() { }

	public static bool get_InitializedInternal() { }

	public static SteamManager get_Instance() { }

	public void Init(EEftStatus initialStatus, IReadOnlyDictionary additionalData = null) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void InitOnPlayMode() { }

	private bool IsMenuStatus(EEftStatus status) { }

	private bool IsMenuTimerElapsed() { }

	[IteratorStateMachine(typeof(<MenuStatusTimerCoroutine>d__22))]
	private IEnumerator MenuStatusTimerCoroutine() { }

	protected override void OnDestroy() { }

	protected override void OnEnable() { }

	private void OnUpdateSteamStatus(UpdateEftStatusEvent statusEvent) { }

	private void SetPlayerInfo(string side, string level) { }

	private static void SetStatus(EEftStatus status) { }

	private static void SetStatusVariable(EEftStatusVariable statusVariable, string value) { }

	private void SetVariableText(UpdateEftStatusEvent statusEvent, out bool setPlaceHolder) { }

	private void StartMenuStatusTimer() { }

	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText) { }

	private void StopMenuStatusTimer() { }

	public void SubscribeGlobalEvents() { }

	protected override void Update() { }

	private void UpdateStatus(UpdateEftStatusEvent statusEvent) { }

}

