namespace EFT.UI.Seasons;

public sealed class BattlePassExchangeWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x18

		public <>c__DisplayClass55_0() { }

		internal void <ResetAfterExchange>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public CanvasGroup state; //Field offset: 0x10

		public <>c__DisplayClass56_0() { }

		internal void <SetAcceptState>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public BattlePassDocumentScheme scheme; //Field offset: 0x10

		public <>c__DisplayClass76_0() { }

		internal bool <GetSourceItemState>b__0(BattlePassDocumentScheme selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public BattlePassDocumentScheme document; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <UpdateTargetItemsState>b__0(BattlePassDocumentScheme selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public BattlePassDocumentScheme document; //Field offset: 0x10

		public <>c__DisplayClass85_0() { }

		internal bool <CanSelectMoreDocuments>b__0(BattlePassDocumentScheme selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public BattlePassDocumentScheme document; //Field offset: 0x10

		public <>c__DisplayClass89_0() { }

		internal bool <SelectTarget>b__0(BattlePassDocumentScheme selected) { }

		internal bool <SelectTarget>b__1(BattlePassDocumentScheme selected) { }

	}

	[CompilerGenerated]
	private struct <PushAnimationFromSelected>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeDocumentView selected; //Field offset: 0x20
		public BattlePassExchangeDocumentView target; //Field offset: 0x28
		private BattlePassExchangeDocumentView <clone>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PushAnimationToSelected>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x20
		public BattlePassExchangeDocumentView source; //Field offset: 0x28
		private BattlePassExchangeDocumentView <clone>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemoveSelectedDocumentAsync>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"item", "view"})]
		public ValueTuple pair; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetSelectedDocument>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x20
		public BattlePassDocumentScheme document; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetSelectedItem>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowSelectedDocumentAfterAnimation>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeDocumentView source; //Field offset: 0x20
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x28
		public BattlePassExchangeDocumentView target; //Field offset: 0x30
		public CanvasGroup canvasGroup; //Field offset: 0x38
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SmoothBiasSelected>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeDocumentView view; //Field offset: 0x20
		private List <buffer>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateCanAcceptTask>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeWindow <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string TITLE = "UI/BattlePass/ExchangeDocuments"; //Field offset: 0x0
	private const string TOOLTIP_EXCHANGE_DESCRIPTION = "UI/BattlePass/ExchangeDocuments/Tooltip/ExchangeDescription"; //Field offset: 0x0
	private const string TOOLTIP_TARGET_DESCRIPTION = "UI/BattlePass/ExchangeDocuments/Tooltip/TargetDescription"; //Field offset: 0x0
	private const string TOOLTIP_MULTIPLE_DOCUMENTS = "UI/BattlePass/ExchangeDocuments/Tooltip/MultipleDocuments"; //Field offset: 0x0
	private const string TOOLTIP_REMOVE_DOCUMENT = "UI/BattlePass/ExchangeDocuments/Tooltip/RemoveDocument"; //Field offset: 0x0
	private const string TOOLTIP_SECRET_DOCUMENTS = "UI/BattlePass/ExchangeDocuments/Tooltip/SecretDocuments"; //Field offset: 0x0
	private const string TOOLTIP_EXCHANGE_CONDITIONS = "UI/BattlePass/ExchangeDocuments/Tooltip/CompleteExchangeConditions"; //Field offset: 0x0
	private const float ANIMATION_DURATION = 0.2; //Field offset: 0x0
	private const float ANIMATION_DURATION_FAST = 0.1; //Field offset: 0x0
	[SerializeField]
	private BattlePassExchangeDocumentView _sourceItemTemplate; //Field offset: 0xB8
	[SerializeField]
	private BattlePassExchangeDocumentView _targetItemTemplate; //Field offset: 0xC0
	[SerializeField]
	private BattlePassExchangeDocumentView _slotTemplate; //Field offset: 0xC8
	[SerializeField]
	private GameObject _slotsPlaceHoldersContainer; //Field offset: 0xD0
	[SerializeField]
	private GameObject _slotPlaceHolders; //Field offset: 0xD8
	[SerializeField]
	private RectTransform _sourceItemsContainer; //Field offset: 0xE0
	[SerializeField]
	private RectTransform _targetItemsContainer; //Field offset: 0xE8
	[SerializeField]
	private RectTransform _slotsContainer; //Field offset: 0xF0
	[SerializeField]
	private TMP_Text _exchangeRateField; //Field offset: 0xF8
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0x100
	[SerializeField]
	private GameObject[] _exchangeDisabledElements; //Field offset: 0x108
	[SerializeField]
	private GameObject[] _exchangeEnabledElements; //Field offset: 0x110
	[SerializeField]
	private Image _arrowToTheRight; //Field offset: 0x118
	[SerializeField]
	private Image _arrowToTheLeft; //Field offset: 0x120
	[SerializeField]
	private GameObject _rightSelectModePanel; //Field offset: 0x128
	[SerializeField]
	private GameObject _exchangeDocumentsTarget; //Field offset: 0x130
	[SerializeField]
	private GameObject _exchangeBoxesTarget; //Field offset: 0x138
	[SerializeField]
	private GameObject _slotsGroup; //Field offset: 0x140
	[SerializeField]
	private DefaultUiButtonNewStyle _setExchangeToDocuments; //Field offset: 0x148
	[SerializeField]
	private DefaultUiButtonNewStyle _setExchangeToBoxes; //Field offset: 0x150
	[SerializeField]
	private DefaultUiButtonNewStyle[] _backButtons; //Field offset: 0x158
	[SerializeField]
	private PointerEventsProxy _infoButton; //Field offset: 0x160
	[SerializeField]
	private Image _selectedItemImage; //Field offset: 0x168
	[SerializeField]
	private GameObject _selectedItemImageLoader; //Field offset: 0x170
	[SerializeField]
	private CanvasGroup _acceptReadyState; //Field offset: 0x178
	[SerializeField]
	private CanvasGroup _acceptPendingState; //Field offset: 0x180
	[SerializeField]
	private CanvasGroup _acceptSuccessState; //Field offset: 0x188
	private BattlePassController _controller; //Field offset: 0x190
	private IImageLoader _imageLoader; //Field offset: 0x198
	private readonly Dictionary _documents; //Field offset: 0x1A0
	private BattlePassDocumentScheme _targetDocument; //Field offset: 0x1A8
	private BattlePass _battlePass; //Field offset: 0x1B0
	private readonly Dictionary _selectedViews; //Field offset: 0x1B8
	private readonly Dictionary _targetItems; //Field offset: 0x1C0
	private readonly Dictionary _sourceItems; //Field offset: 0x1C8
	private readonly BindableList _selectedDocuments; //Field offset: 0x1D0
	private EBattlePassExchangeMode _exchangeMode; //Field offset: 0x1D8
	private bool _exchangeOperationInProgress; //Field offset: 0x1DC
	private bool _inSuccessState; //Field offset: 0x1DD

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public BattlePassExchangeWindow() { }

	[CompilerGenerated]
	private bool <HasDocuments>b__69_0(BattlePassDocumentScheme document) { }

	[CompilerGenerated]
	private void <Show>b__52_0(BattlePassItem _) { }

	private void Accept() { }

	private static float AnimationDuration(bool instant) { }

	private bool CanAcceptExchange() { }

	private bool CanSelectMoreDocuments(BattlePassDocumentScheme document) { }

	private static void ClearContainer(RectTransform container) { }

	private void ClearViews() { }

	private int ExchangeRate() { }

	protected virtual bool get_ShowOnTop() { }

	private int GetCount(BattlePassDocumentScheme document) { }

	private EDocumentPresentSubState GetSourceItemState(BattlePassDocumentScheme scheme) { }

	private bool HasDocuments() { }

	private void HideTooltip() { }

	private void OnBackButtonClicked() { }

	[AsyncStateMachine(typeof(<PushAnimationFromSelected>d__88))]
	private Task PushAnimationFromSelected(BattlePassExchangeDocumentView selected, BattlePassExchangeDocumentView target) { }

	[AsyncStateMachine(typeof(<PushAnimationToSelected>d__86))]
	private Task PushAnimationToSelected(BattlePassExchangeDocumentView source) { }

	private void Rebuild() { }

	private void RebuildSource() { }

	private void RebuildTargets() { }

	private void RemoveSelectedDocument(ValueTuple pair) { }

	[AsyncStateMachine(typeof(<RemoveSelectedDocumentAsync>d__82))]
	private Task RemoveSelectedDocumentAsync(ValueTuple pair) { }

	public void ResetAfterExchange() { }

	private void ResetSelectedImage() { }

	private void SelectSource(ValueTuple pair) { }

	private void SelectTarget(ValueTuple pair) { }

	private void SetAcceptState(CanvasGroup targetState, bool instant = false) { }

	private void SetExchangeBoxes() { }

	private void SetExchangeDocuments() { }

	private void SetLeftArrowState(bool state, bool instant) { }

	public void SetOperationInProgress(bool state) { }

	[AsyncStateMachine(typeof(<SetSelectedDocument>d__90))]
	private Task SetSelectedDocument(BattlePassDocumentScheme document) { }

	[AsyncStateMachine(typeof(<SetSelectedItem>d__91))]
	private Task SetSelectedItem() { }

	private void SetupSlotsCount() { }

	public BattlePassExchangeWindowContext Show(BattlePass battlePass, BattlePassController controller, IImageLoader imageLoader) { }

	private void ShowItemExchangeTarget() { }

	[AsyncStateMachine(typeof(<ShowSelectedDocumentAfterAnimation>d__87))]
	private Task ShowSelectedDocumentAfterAnimation(BattlePassExchangeDocumentView source, BattlePassExchangeDocumentView target, CanvasGroup canvasGroup) { }

	private void ShowSourceItem(BattlePassDocumentScheme document) { }

	private void ShowTargetItem(BattlePassDocumentScheme document) { }

	private void ShowTooltip() { }

	[AsyncStateMachine(typeof(<SmoothBiasSelected>d__83))]
	private Task SmoothBiasSelected(BattlePassExchangeDocumentView view) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateCanAccept() { }

	[AsyncStateMachine(typeof(<UpdateCanAcceptTask>d__71))]
	private Task UpdateCanAcceptTask() { }

	private void UpdateExchangeEnabled(bool state) { }

	private void UpdateRightArrowState(bool instant) { }

	private void UpdateSourceItemsState() { }

	private void UpdateTargetItemsState() { }

	private void UpdateTargets() { }

}

