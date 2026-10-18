namespace EFT.UI;

public class WelcomeScreen`2 : BaseScreen
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GetLocaleLabel; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <LoadAndApplyLocale>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public WelcomeScreen <>4__this; //Field offset: 0x0
		public string locale; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWithFallback>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public WelcomeScreen <>4__this; //Field offset: 0x0
		public string locale; //Field offset: 0x0
		private string <fallbackLocale>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NextButtonClickHandler>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public WelcomeScreen <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryLoadLocale>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public WelcomeScreen <>4__this; //Field offset: 0x0
		public string locale; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly string[] DefaultLocales; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0x0
	[SerializeField]
	private GameObject _loadingCaption; //Field offset: 0x0
	[SerializeField]
	private GameObject _loader; //Field offset: 0x0
	[SerializeField]
	private GameObject _descriptionText; //Field offset: 0x0
	[SerializeField]
	private DropDownBox _languageDropdown; //Field offset: 0x0
	private readonly List _locales; //Field offset: 0x0
	private readonly Dictionary _localeLoads; //Field offset: 0x0
	private Dictionary _localizationList; //Field offset: 0x0
	private IClientSession _session; //Field offset: 0x0
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x0
	private string _selectedLocale; //Field offset: 0x0
	private string _requestedLocale; //Field offset: 0x0
	private bool _languageDropdownInitialized; //Field offset: 0x0

	private static WelcomeScreen`2() { }

	public WelcomeScreen`2() { }

	public virtual void Close() { }

	private string GetFallbackLocale() { }

	private static string GetLocaleLabel(string locale) { }

	private static IEnumerable GetSupportedLocales() { }

	private string GetSystemLocale() { }

	[AsyncStateMachine(typeof(<LoadAndApplyLocale>d__17))]
	private Task LoadAndApplyLocale(string locale) { }

	private Task LoadLocale(ILocalizationLoader localizationLoader, string locale) { }

	private Task LoadLocaleOnce(string locale) { }

	[AsyncStateMachine(typeof(<LoadWithFallback>d__18))]
	private Task LoadWithFallback(string locale) { }

	[AsyncStateMachine(typeof(<NextButtonClickHandler>d__16))]
	private void NextButtonClickHandler() { }

	private void OnLanguageSelected(int index) { }

	private void RefreshLanguageDropdown() { }

	private void SetButtonsAvailability(bool value) { }

	private void SetLocaleLoadingStatus(bool value) { }

	private void Show(ILocalizationLoader localizationLoader) { }

	public virtual void Show(TController controller) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryLoadLocale>d__19))]
	private Task TryLoadLocale(string locale) { }

	private void UpdateDropdownSelection(string locale) { }

	private void UpdateWelcomeLocalization(string locale) { }

}

