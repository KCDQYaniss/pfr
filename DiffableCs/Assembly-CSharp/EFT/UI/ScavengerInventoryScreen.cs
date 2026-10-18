namespace EFT.UI;

public sealed class ScavengerInventoryScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8
		public static Func <>9__18_0; //Field offset: 0x10
		public static Action <>9__18_1; //Field offset: 0x18
		public static Action <>9__18_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <SellAll>b__18_0(Trader x) { }

		internal void <SellAll>b__18_1() { }

		internal void <SellAll>b__18_2() { }

		internal bool <TryGetFirstLevelItems>b__17_0(Item item) { }

	}

	[CompilerGenerated]
	private struct <SellAll>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ScavengerInventoryScreen <>4__this; //Field offset: 0x20
		private CancellationToken <cancelToken>5__2; //Field offset: 0x28
		private Trader <trader>5__3; //Field offset: 0x30
		private List <firstLevelItems>5__4; //Field offset: 0x38
		private List <removeResults>5__5; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ScavengerInventoryScreenController : EftScreenController
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass21_0
		{
			public TaskCompletionSource taskSource; //Field offset: 0x10

			public <>c__DisplayClass21_0() { }

			internal void <CloseScreenInterruption>b__0() { }

			internal void <CloseScreenInterruption>b__1() { }

		}

		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__21 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public ScavengerInventoryScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private <>c__DisplayClass21_0 <>8__1; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private Action OnShowNextScreen; //Field offset: 0x58
		public readonly OfflineInventoryController MainController; //Field offset: 0x60
		public readonly OfflineInventoryController ScavController; //Field offset: 0x68
		public readonly IHealthController HealthController; //Field offset: 0x70
		public readonly Stash PlayerStash; //Field offset: 0x78
		public readonly IEftSession Session; //Field offset: 0x80
		public readonly ItemUiContext UiContext; //Field offset: 0x88

		public event Action OnShowNextScreen
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public bool HasItems
		{
			 get { } //Length: 95
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public ScavengerInventoryScreenController(OfflineInventoryController mainController, OfflineInventoryController scavController, IHealthController healthController, Stash playerStash, IEftSession session) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[CompilerGenerated]
		public void add_OnShowNextScreen(Action value) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__21))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		public bool get_HasItems() { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		public void remove_OnShowNextScreen(Action value) { }

		public void ShowNextScreen() { }

	}

	[SerializeField]
	private ItemsPanel _itemsPanel; //Field offset: 0xA0
	[SerializeField]
	private SimpleStashPanel _simpleStashPanel; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _sellAllButton; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _scavCaption; //Field offset: 0xC8
	[SerializeField]
	private TagBank _scavPhrases; //Field offset: 0xD0
	[SerializeField]
	private GameObject _loadingPanel; //Field offset: 0xD8
	[SerializeField]
	private GameObject _loadingSpinner; //Field offset: 0xE0
	private BackEndInventoryController _playerInventoryController; //Field offset: 0xE8
	private BackEndInventoryController _scavInventoryController; //Field offset: 0xF0
	private IEftSession _backendSession; //Field offset: 0xF8
	private bool _assortmentRefreshed; //Field offset: 0x100

	public ScavengerInventoryScreen() { }

	[CompilerGenerated]
	private void <Awake>b__14_0() { }

	[CompilerGenerated]
	private void <Awake>b__14_1() { }

	[CompilerGenerated]
	private void <Awake>b__14_2() { }

	[CompilerGenerated]
	private void <Show>b__16_0() { }

	[UsedImplicitly]
	private void Awake() { }

	public virtual void Close() { }

	private void RemoveItemHandler(RemoveItemEventArgs args) { }

	[AsyncStateMachine(typeof(<SellAll>d__18))]
	private Task SellAll() { }

	public virtual void Show(ScavengerInventoryScreenController controller) { }

	private void Show(OfflineInventoryController mainController, OfflineInventoryController scavController, IHealthController healthController, Stash playerStash, IEftSession session, ItemUiContext uiContext) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryGetFirstLevelItems(out IEnumerable items) { }

	private void UpdateSellAllButton() { }

}

