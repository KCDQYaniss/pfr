namespace EFT.Hideout;

public sealed class AreasPanel : UIInputNode, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AreaData <OrderAreas>b__33_0(AreaData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Action onSelected; //Field offset: 0x10
		public AreasPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0(AreaData item, AreaPanel view) { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private struct <JumpToAreaPanel>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaPanel panel; //Field offset: 0x20
		public AreasPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Action onSelected; //Field offset: 0x28
		public AreasPanel <>4__this; //Field offset: 0x30
		public AreaData[] areas; //Field offset: 0x38
		private bool <firstStart>5__2; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x41

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class AreasPanelComparer : IComparer
	{
		private static readonly Dictionary _orderList; //Field offset: 0x0
		public static readonly AreasPanelComparer Instance; //Field offset: 0x8

		private static AreasPanelComparer() { }

		public AreasPanelComparer() { }

		public override int Compare(AreaData x, AreaData y) { }

	}

	private const float SCROLL_STEP = 200; //Field offset: 0x0
	private const float SCROLL_SPEED = 0.5; //Field offset: 0x0
	private const float MARGIN_OFFSET = 120; //Field offset: 0x0
	private const float DELAY_BEFORE_MOVEMENT = 0.3; //Field offset: 0x0
	[SerializeField]
	private AreaPanel _areaPanelTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _areaPanelsContainer; //Field offset: 0x88
	[SerializeField]
	private AreasScrollRect _scrollView; //Field offset: 0x90
	[SerializeField]
	private Button _leftButton; //Field offset: 0x98
	[SerializeField]
	private Button _rightButton; //Field offset: 0xA0
	private AreaData[] _areas; //Field offset: 0xA8
	private BindableViewList _viewList; //Field offset: 0xB0
	private Action _onSelected; //Field offset: 0xB8
	private AreaPanel _selectedPanel; //Field offset: 0xC0
	private bool _captureCommands; //Field offset: 0xC8
	private bool _freeScroll; //Field offset: 0xC9
	private bool _selectedStatus; //Field offset: 0xCA
	private Vector2 _buttonSize; //Field offset: 0xCC

	public AreasPanel() { }

	[CompilerGenerated]
	private void <Awake>b__18_0() { }

	[CompilerGenerated]
	private void <Awake>b__18_1() { }

	[CompilerGenerated]
	private void <DoScroll>b__32_0() { }

	[CompilerGenerated]
	private void <DoScroll>b__32_1() { }

	private void Awake() { }

	private float ClampScroll(float normalizedPosition) { }

	private void DoScroll(float normalizedPosition) { }

	[AsyncStateMachine(typeof(<JumpToAreaPanel>d__30))]
	private Task JumpToAreaPanel(AreaPanel panel) { }

	public override void OnPointerEnter(PointerEventData data) { }

	public override void OnPointerExit(PointerEventData data) { }

	private void OnScrollHandler(Vector2 scrollPosition) { }

	public void OnStartDrag() { }

	private void OrderAreas() { }

	public void SelectArea(AreaData area) { }

	public void SetSelectedStatus(bool status) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	[AsyncStateMachine(typeof(<Show>d__19))]
	public void Show(AreaData[] areas, Action onSelected) { }

	private void SwitchArea(int direction) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

