namespace EFT.UI.Matchmaker;

public sealed class MatchmakerInsuranceScreen : MatchmakerEftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ShowMessageWindow>b__21_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public MatchmakerInsuranceScreen <>4__this; //Field offset: 0x10
		public List allItemsToInsure; //Field offset: 0x18
		public Callback <>9__1; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <InsureItems>b__0() { }

		internal void <InsureItems>b__1(IResult result) { }

	}

	private enum EInsuranceTab
	{
		Insured = 0,
		ToInsure = 1,
	}

	internal sealed class InsuranceScreenController : EftMatchmakerScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__14 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public bool moveForward; //Field offset: 0x20
			public InsuranceScreenController <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30
			private TaskAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public readonly IHealthController HealthController; //Field offset: 0x78
		public readonly InventoryController InventoryController; //Field offset: 0x80
		public readonly IEftSession Session; //Field offset: 0x88
		public readonly QuestController QuestController; //Field offset: 0x90

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		public InsuranceScreenController(QuestController questController, IHealthController healthController, InventoryController inventoryController, IEftSession session, MatchmakerPlayersController matchmakerPlayersController) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		protected virtual void CloseAction(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__14))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		public virtual bool get_KeyScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

	}

	[SerializeField]
	private Tab _insuredTab; //Field offset: 0xB0
	[SerializeField]
	private Tab _toInsureTab; //Field offset: 0xB8
	[SerializeField]
	private ItemsToInsureScreen _itemsToInsureScreen; //Field offset: 0xC0
	[SerializeField]
	private InsuredItemsScreen _insuredItemsScreen; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _readyButton; //Field offset: 0xD0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _insureButton; //Field offset: 0xE0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xE8
	private ItemUiContext _itemUiContext; //Field offset: 0xF0
	private Dictionary _tabDictionary; //Field offset: 0xF8
	private TabGroup _tabs; //Field offset: 0x100
	private IEftSession _session; //Field offset: 0x108
	private InsuranceCompany _insurance; //Field offset: 0x110

	public MatchmakerInsuranceScreen() { }

	[CompilerGenerated]
	private void <Awake>b__15_0() { }

	[CompilerGenerated]
	private void <Awake>b__15_1() { }

	[CompilerGenerated]
	private void <Awake>b__15_2() { }

	[CompilerGenerated]
	private void <Show>b__17_0() { }

	private void Awake() { }

	public virtual void Close() { }

	private void InsureItems() { }

	private void RaidReadyStatusChanged(RaidPlayer player, bool _) { }

	private void SetInsureAvailable(bool available) { }

	public virtual void Show(InsuranceScreenController controller) { }

	private void Show(QuestController questController, IHealthController healthController, InventoryController controller, IEftSession session) { }

	private void ShowMessageWindow(Action acceptAction, int itemsToInsureCount) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

