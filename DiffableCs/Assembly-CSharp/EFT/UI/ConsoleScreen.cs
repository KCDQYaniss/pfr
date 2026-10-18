namespace EFT.UI;

public sealed class ConsoleScreen : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__71_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <PrintUnityLog>b__71_0(string current, string item) { }

	}

	public const string CONSOLE_START_COMMANDS_SAVE_KEY = "ConsoleStartCommands"; //Field offset: 0x0
	private const int MAX_LOG_ENTRIES = 2000; //Field offset: 0x0
	private const int VISIBLE_LINES = 60; //Field offset: 0x0
	private static readonly StringBuilder _sharedStringBuilder; //Field offset: 0x0
	private const int REFRESH_INTERVAL_MS = 100; //Field offset: 0x0
	public static readonly ConsoleProcessor Processor; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <WarningVisibility>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static bool <ErrorsVisibility>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private static bool <LogsVisibility>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private static bool <IAmDevShowMeLogs>k__BackingField; //Field offset: 0x13
	[SerializeField]
	private Slider _consoleSlider; //Field offset: 0x80
	[SerializeField]
	private TMP_InputField _enterCommandField; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _timePanel; //Field offset: 0x90
	[SerializeField]
	private TMP_InputFieldNoScroll _logsPanel; //Field offset: 0x98
	[SerializeField]
	private ConsoleAutoCompletePanel _consoleAutoCompletePanel; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <IsConsoleVisible>k__BackingField; //Field offset: 0xA8
	private readonly string[] _logTextArray; //Field offset: 0xB0
	private readonly string[] _timeTextArray; //Field offset: 0xB8
	private int _logCount; //Field offset: 0xC0
	private int _logHead; //Field offset: 0xC4
	private int _pendingRefreshCount; //Field offset: 0xC8
	private DateTime _lastRefreshTime; //Field offset: 0xD0
	private Dictionary _logMarkers; //Field offset: 0xD8
	private int _linesSkipped; //Field offset: 0xE0
	private string _lastAutoCompleteText; //Field offset: 0xE8
	private bool _isAutoCompleteEnabledNow; //Field offset: 0xF0
	private int _lastInputIndex; //Field offset: 0xF4
	private string _historyDraftInput; //Field offset: 0xF8
	private EMemberCategory _memberCategory; //Field offset: 0x100
	private readonly List _inputs; //Field offset: 0x108
	private Coroutine _oneFrameCoroutine; //Field offset: 0x110
	private bool _silentMode; //Field offset: 0x118
	private bool _initialized; //Field offset: 0x119

	public static bool ErrorsVisibility
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static bool IAmDevShowMeLogs
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public private bool IsConsoleVisible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private int LinesSkipped
	{
		private get { } //Length: 7
		private set { } //Length: 58
	}

	public static bool LogsVisibility
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static bool WarningVisibility
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	private static ConsoleScreen() { }

	public ConsoleScreen() { }

	[CompilerGenerated]
	private void <AddSilentMode>b__69_0(bool isEnabled) { }

	[CompilerGenerated]
	private void <InitConsole>b__60_0(string txt) { }

	[CompilerGenerated]
	private void <Show>b__68_0() { }

	private void AddCommands() { }

	private void AddLogEntry(string log, string timeStamp) { }

	private void AddSilentMode() { }

	public static void ApplyStartCommands() { }

	private void Awake() { }

	private void CheckLastCommandSuggestion() { }

	public void Clear() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public static bool get_ErrorsVisibility() { }

	[CompilerGenerated]
	public static bool get_IAmDevShowMeLogs() { }

	[CompilerGenerated]
	public bool get_IsConsoleVisible() { }

	private int get_LinesSkipped() { }

	[CompilerGenerated]
	public static bool get_LogsVisibility() { }

	[CompilerGenerated]
	public static bool get_WarningVisibility() { }

	private void Hide() { }

	private void HideAutoComplete() { }

	public void InitConsole() { }

	private static bool IsInputContainsOpenConsoleKey(string input) { }

	public void LateUpdate() { }

	public static void Log(string statement) { }

	public static void LogError(string statement) { }

	public static void LogException(Exception exception) { }

	public static void LogFormat(string statement, object[] args) { }

	public static void LogWarning(string statement) { }

	private void OnAutoCompleteSelected(AutoCompleteItem item) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void OnProfileReceive(Profile profile) { }

	private void OnScroll(PointerEventData eventData) { }

	private void OnSliderValueChanged(float value) { }

	private void OnUnityLog(string condition, string stacktrace, LogType type) { }

	private void PrintUnityLog(string condition, string stacktrace, LogType type) { }

	private void ProcessAutoCompleteVariants() { }

	public void PullUpConsole() { }

	private void RefreshParams() { }

	[CompilerGenerated]
	public static void set_ErrorsVisibility(bool value) { }

	[CompilerGenerated]
	public static void set_IAmDevShowMeLogs(bool value) { }

	[CompilerGenerated]
	private void set_IsConsoleVisible(bool value) { }

	private void set_LinesSkipped(int value) { }

	[CompilerGenerated]
	public static void set_LogsVisibility(bool value) { }

	[CompilerGenerated]
	public static void set_WarningVisibility(bool value) { }

	private void SetLastInput(int historyOffset) { }

	private void SetVisible(bool isActive) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show() { }

	private void ShowAutoComplete(string input) { }

	public static void SwitchDebugLogEnabled() { }

	public static void SwitchStackTraceEnabled() { }

	private static string TimeStamp(string color) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	public void TryCommand(string input) { }

	public void TryCommand(IConsoleCommand input) { }

	private void Update() { }

}

