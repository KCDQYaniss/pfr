namespace EFT.UI.SessionEnd;

public sealed class HealthTreatmentScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public HealthTreatmentScreenController controller; //Field offset: 0x10
		public HealthTreatmentScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

	}

	internal sealed class HealthTreatmentScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__24 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public HealthTreatmentScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30
			private TaskAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private Action OnShowNextScreen; //Field offset: 0x58
		[CompilerGenerated]
		private Action OnCloseInProgress; //Field offset: 0x60
		public readonly Profile Profile; //Field offset: 0x68
		public readonly InventoryController InventoryController; //Field offset: 0x70
		public readonly OfflineHealthController HealthController; //Field offset: 0x78
		public readonly ItemUiContext Context; //Field offset: 0x80
		public readonly IEftSession Session; //Field offset: 0x88
		public readonly Trader Trader; //Field offset: 0x90

		public event Action OnCloseInProgress
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public event Action OnShowNextScreen
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public HealthTreatmentScreenController(Profile profile, InventoryController inventoryController, OfflineHealthController healthController, ItemUiContext context, IEftSession session) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[CompilerGenerated]
		public void add_OnCloseInProgress(Action value) { }

		[CompilerGenerated]
		public void add_OnShowNextScreen(Action value) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__24))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		public void remove_OnCloseInProgress(Action value) { }

		[CompilerGenerated]
		public void remove_OnShowNextScreen(Action value) { }

		public void ShowNextScreen() { }

	}

	[SerializeField]
	private HealthTreatmentServiceView _healthTreatmentView; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB0

	public HealthTreatmentScreen() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	[CompilerGenerated]
	private void <Awake>b__4_1() { }

	private void Awake() { }

	public virtual void Close() { }

	public static bool IsAvailable(Profile profile, OfflineHealthController healthController, TraderInfo trader) { }

	private void SetBlockedStatus(bool blocked) { }

	public virtual void Show(HealthTreatmentScreenController controller) { }

	private void Show(Profile profile, InventoryController inventoryController, OfflineHealthController healthController, ItemUiContext uiContext, IEftSession session) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

