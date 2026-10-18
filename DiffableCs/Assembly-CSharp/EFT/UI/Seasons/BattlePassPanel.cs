namespace EFT.UI.Seasons;

public sealed class BattlePassPanel : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public BattlePassPanel <>4__this; //Field offset: 0x10
		public BattlePassExchangeWindowContext context; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal Task <ShowExchangeWindow>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OpenShop; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <ExchangeDocumentsAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassPanel <>4__this; //Field offset: 0x20
		public BattlePassDocumentExchangeSelection selection; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandoverRewardAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassPanel <>4__this; //Field offset: 0x20
		private BattlePassReward <reward>5__2; //Field offset: 0x28
		private Rect <imageSize>5__3; //Field offset: 0x30
		private BattlePassRewardHandover <handover>5__4; //Field offset: 0x40
		private CancellationToken <cancellationToken>5__5; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryExecute>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassPanel <>4__this; //Field offset: 0x20
		public Func task; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitExchangeWindowResult>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattlePassExchangeWindowContext context; //Field offset: 0x20
		public BattlePassPanel <>4__this; //Field offset: 0x28
		private Task <acceptTask>5__2; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class BattlePassTabController : UIElementTabController
	{
		private readonly BattlePassController _controller; //Field offset: 0x18
		private readonly IImageLoader _imageLoader; //Field offset: 0x20

		public BattlePassTabController(BattlePassPanel content, BattlePassController controller, IImageLoader imageLoader) { }

		public virtual void Show() { }

	}

	[SerializeField]
	private BattlePassRewardPageView _rewardPage; //Field offset: 0x80
	[SerializeField]
	private BattlePassRewardPageControlsView _rewardPageControls; //Field offset: 0x88
	[SerializeField]
	private BattlePassRewardFullView _rewardView; //Field offset: 0x90
	[SerializeField]
	private BattlePassInventoryItemsView _inventoryItems; //Field offset: 0x98
	[SerializeField]
	private BattlePassRewardRequirementsView _requirements; //Field offset: 0xA0
	[SerializeField]
	private DefaultUiButtonNewStyle _handOwerButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUiButtonNewStyle _buyButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUiButtonNewStyle _exchangeButton; //Field offset: 0xB8
	[SerializeField]
	private MouseEventPropagator _scrollHandler; //Field offset: 0xC0
	[SerializeField]
	private BattlePassUITutorial _tutorial; //Field offset: 0xC8
	[SerializeField]
	private GameObject _raycastBlocker; //Field offset: 0xD0
	[SerializeField]
	private Button _tutorialButton; //Field offset: 0xD8
	[SerializeField]
	private BattlePassRewardReceivedPanel _rewardReceivedPanel; //Field offset: 0xE0
	private BattlePass _battlePass; //Field offset: 0xE8
	private BattlePassController _controller; //Field offset: 0xF0
	private IBattlePassPage _currentPage; //Field offset: 0xF8
	private BattlePassReward _currentReward; //Field offset: 0x100
	private IImageLoader _imageLoader; //Field offset: 0x108
	private bool _pageBlock; //Field offset: 0x110
	private readonly List _allRewards; //Field offset: 0x118

	public BattlePassPanel() { }

	[CompilerGenerated]
	private void <Show>b__21_0(IBattlePassPage page) { }

	[CompilerGenerated]
	private void <Show>b__21_1(BattlePassItem _) { }

	[CompilerGenerated]
	private void <Show>b__21_2() { }

	[CompilerGenerated]
	private void <Show>b__21_3() { }

	[CompilerGenerated]
	private void <Show>g__RewardClaimedHandler|21_4(BattlePassReward reward) { }

	private bool CanHandoverRewardItems() { }

	[AsyncStateMachine(typeof(<ExchangeDocumentsAsync>d__31))]
	private Task ExchangeDocumentsAsync(BattlePassDocumentExchangeSelection selection) { }

	[AsyncStateMachine(typeof(<HandoverRewardAsync>d__27))]
	private Task HandoverRewardAsync() { }

	private void HandoverRewardHandler() { }

	private static void OpenShop() { }

	private void RefreshCurrentReward() { }

	private void ScrollHandler(PointerEventData pointerData) { }

	private void SelectReward(BattlePassReward reward) { }

	private void SetHandoverButtonActive(bool active) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(BattlePass battlePass, BattlePassController controller, IImageLoader imageLoader) { }

	private void ShowExchangeWindow() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryExecute>d__30))]
	private Task TryExecute(Func task) { }

	private void UpdateHandoverButton() { }

	[AsyncStateMachine(typeof(<WaitExchangeWindowResult>d__29))]
	private Task WaitExchangeWindowResult(BattlePassExchangeWindowContext context) { }

}

