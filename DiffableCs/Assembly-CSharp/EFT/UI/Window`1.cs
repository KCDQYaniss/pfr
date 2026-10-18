namespace EFT.UI;

public abstract class Window`1 : UIInputNode, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public TContext windowContext; //Field offset: 0x0
		public Window <>4__this; //Field offset: 0x0

		public <>c__DisplayClass23_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private struct <CloseAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Window <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private RectTransform _windowTransform; //Field offset: 0x0
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _caption; //Field offset: 0x0
	[SerializeField]
	private Button _closeButton; //Field offset: 0x0
	[CompilerGenerated]
	private TContext <WindowContext>k__BackingField; //Field offset: 0x0
	protected bool Open; //Field offset: 0x0
	private Task _closeTask; //Field offset: 0x0

	protected TextMeshProUGUI Caption
	{
		 get { } //Length: 8
	}

	protected override bool ClickPutsOnTop
	{
		 get { } //Length: 3
	}

	protected Button CloseButton
	{
		 get { } //Length: 8
	}

	protected override bool DragEnabled
	{
		 get { } //Length: 3
	}

	protected override bool ShowOnTop
	{
		 get { } //Length: 3
	}

	protected private TContext WindowContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected RectTransform WindowTransform
	{
		 get { } //Length: 8
	}

	protected Window`1() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	protected override void Awake() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<CloseAsync>d__29))]
	private Task CloseAsync() { }

	protected override Task CloseInterruption() { }

	protected override TContext CreateContext() { }

	protected TextMeshProUGUI get_Caption() { }

	protected override bool get_ClickPutsOnTop() { }

	protected Button get_CloseButton() { }

	protected override bool get_DragEnabled() { }

	protected override bool get_ShowOnTop() { }

	[CompilerGenerated]
	protected TContext get_WindowContext() { }

	protected RectTransform get_WindowTransform() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	protected override void PointerDownHandler() { }

	protected override void PointerUpHandler() { }

	[CompilerGenerated]
	private void set_WindowContext(TContext value) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected TContext Show() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}

