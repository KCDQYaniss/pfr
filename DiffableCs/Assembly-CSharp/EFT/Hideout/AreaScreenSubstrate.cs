namespace EFT.Hideout;

public sealed class AreaScreenSubstrate : UIScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__45_0; //Field offset: 0x8
		public static Func <>9__45_1; //Field offset: 0x10
		public static Func <>9__45_2; //Field offset: 0x18
		public static Func <>9__45_3; //Field offset: 0x20
		public static Func <>9__45_5; //Field offset: 0x28
		public static Func <>9__45_6; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal EPanelType <DataToDisplay>b__45_0(KeyValuePair kvp) { }

		internal RelatedData <DataToDisplay>b__45_1(KeyValuePair kvp) { }

		internal bool <DataToDisplay>b__45_2(KeyValuePair x) { }

		internal bool <DataToDisplay>b__45_3(KeyValuePair x) { }

		internal EPanelType <DataToDisplay>b__45_5(KeyValuePair x) { }

		internal RelatedData <DataToDisplay>b__45_6(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public ItemsProducerBase producer; //Field offset: 0x10
		public AreaScreenSubstrate <>4__this; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <SelectArea>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public AreaScreenSubstrate <>4__this; //Field offset: 0x10
		public ELevelType state; //Field offset: 0x18
		public CanvasGroup oldStageGroup; //Field offset: 0x20

		public <>c__DisplayClass41_0() { }

		internal void <SetState>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public AreaScreenSubstrate <>4__this; //Field offset: 0x10
		public bool stateChanged; //Field offset: 0x18
		public RectTransform container; //Field offset: 0x20
		public List showTasks; //Field offset: 0x28
		public Stage stage; //Field offset: 0x30
		public ELevelType levelType; //Field offset: 0x38

		public <>c__DisplayClass42_0() { }

		internal Transform <CreateViewList>b__1(RelatedData arg) { }

		internal void <CreateViewList>b__2(RelatedData item, IAreaRelatedPanel view) { }

		internal bool <CreateViewList>b__3() { }

		internal void <CreateViewList>g__OnStateChanged|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public AreaScreenSubstrate <>4__this; //Field offset: 0x10
		public ELevelType levelType; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal bool <DataToDisplay>b__4(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private struct <CreateViewList>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaScreenSubstrate <>4__this; //Field offset: 0x20
		public ELevelType levelType; //Field offset: 0x28
		private <>c__DisplayClass42_0 <>8__1; //Field offset: 0x30
		public AsyncViewList viewList; //Field offset: 0x38
		private Dictionary <dataToDisplay>5__2; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ViewListCreated>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaScreenSubstrate <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const float FADE_DELAY = 0.3; //Field offset: 0x0
	public const float CONTENT_HEIGHT_DELTA = 80; //Field offset: 0x0
	[SerializeField]
	private float _maxHeight; //Field offset: 0x90
	[SerializeField]
	private AreaSubstrateSettings _areaSubstrateSettings; //Field offset: 0x98
	[SerializeField]
	private RectTransform _nextStageContainer; //Field offset: 0xA0
	[SerializeField]
	private CanvasGroup _nextStageGroup; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _currentStageContainer; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _currentStageGroup; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _nextLevelButton; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _currentLevelButton; //Field offset: 0xC8
	[SerializeField]
	private AreaPanel _areaPanel; //Field offset: 0xD0
	[SerializeField]
	private Button _closeButton; //Field offset: 0xD8
	[SerializeField]
	private AreaPanelSettings _areaPanelSettings; //Field offset: 0xE0
	[SerializeField]
	private Image _areaStatusImage; //Field offset: 0xE8
	[SerializeField]
	private CanvasGroup _buttonCanvasGroup; //Field offset: 0xF0
	[SerializeField]
	private DefaultUIButton _actionButton; //Field offset: 0xF8
	[SerializeField]
	private AreaDetails _areaDetailsPanel; //Field offset: 0x100
	[SerializeField]
	private LayoutElement _contentLayout; //Field offset: 0x108
	private Action _onButtonClicked; //Field offset: 0x110
	private Action _onClosed; //Field offset: 0x118
	private AreaData _dataToShow; //Field offset: 0x120
	private AreaData _chosenData; //Field offset: 0x128
	private int _selectedLevel; //Field offset: 0x130
	private InventoryController _inventoryController; //Field offset: 0x138
	private IEftSession _session; //Field offset: 0x140
	private AsyncViewList _nextViewList; //Field offset: 0x148
	private AsyncViewList _currentViewList; //Field offset: 0x150
	private ELevelType _currentState; //Field offset: 0x158
	private bool _resetState; //Field offset: 0x15C
	private bool _showOnEnable; //Field offset: 0x15D
	private UIParent _areaHandlers; //Field offset: 0x160
	[CompilerGenerated]
	private Action _stateChangedToken; //Field offset: 0x168

	private event Action _stateChangedToken
	{
		[CompilerGenerated]
		private add { } //Length: 251
		[CompilerGenerated]
		private remove { } //Length: 251
	}

	public AreaScreenSubstrate() { }

	[CompilerGenerated]
	private void <Awake>b__34_0() { }

	[CompilerGenerated]
	private void <Awake>b__34_1() { }

	[CompilerGenerated]
	private void <Awake>b__34_2() { }

	[CompilerGenerated]
	private void <SelectArea>b__36_0(bool silent) { }

	[CompilerGenerated]
	private void add__stateChangedToken(Action value) { }

	private void Awake() { }

	private IAreaRelatedPanel ChooseView(RelatedData data) { }

	public virtual void Close() { }

	private void CloseSelf() { }

	[AsyncStateMachine(typeof(<CreateViewList>d__42))]
	private Task CreateViewList(AsyncViewList viewList, ELevelType levelType) { }

	private Dictionary DataToDisplay(Stage stage, ELevelType levelType) { }

	private ELevelType GetAppropriateState() { }

	public void Init(InventoryController inventoryController, IEftSession session, Action onButtonClicked, Action onClosed) { }

	private bool IsVisibilityPass(EPanelType panelType, ELevelType levelType) { }

	private void OnEnable() { }

	private void OnLevelUpdated() { }

	private void ReconstructScreen() { }

	[CompilerGenerated]
	private void remove__stateChangedToken(Action value) { }

	public void SelectArea(AreaData areaData) { }

	private void SetErrorsChecked() { }

	private void SetState(ELevelType state, bool force) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<ViewListCreated>d__44))]
	private Task ViewListCreated() { }

}

