namespace EFT.Hideout;

public class AreaPanel : ButtonFeedback
{
	[CompilerGenerated]
	private struct <SetInfo>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AreaPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float SET_INFO_DELAY = 0.5; //Field offset: 0x0
	[SerializeField]
	private AreaIcon _areaIcon; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _iconImageContainer; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _areaName; //Field offset: 0xB8
	[SerializeField]
	private GameObject _statusObject; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _areaStatus; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _progressTextField; //Field offset: 0xD0
	private int _currentDot; //Field offset: 0xD8
	private Action _onSelected; //Field offset: 0xE0
	[CompilerGenerated]
	private AreaData <Data>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private AreaIcon <AreaIconCreated>k__BackingField; //Field offset: 0xF0
	private bool _active; //Field offset: 0xF8

	protected AreaIcon AreaIcon
	{
		 get { } //Length: 8
	}

	protected AreaIcon AreaIconCreated
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected TextMeshProUGUI AreaName
	{
		 get { } //Length: 8
	}

	private ValueTuple AreaStatusLabel
	{
		private get { } //Length: 252
	}

	protected RectTransform Container
	{
		 get { } //Length: 8
	}

	public private AreaData Data
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public AreaPanel() { }

	[CompilerGenerated]
	private void <Init>b__27_0(bool silent) { }

	[CompilerGenerated]
	private void <Show>b__26_0() { }

	public virtual void Close() { }

	protected AreaIcon get_AreaIcon() { }

	[CompilerGenerated]
	protected AreaIcon get_AreaIconCreated() { }

	protected TextMeshProUGUI get_AreaName() { }

	private ValueTuple get_AreaStatusLabel() { }

	protected RectTransform get_Container() { }

	[CompilerGenerated]
	public AreaData get_Data() { }

	protected override void Init(AreaData data, Action onSelected) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	[CompilerGenerated]
	protected void set_AreaIconCreated(AreaIcon value) { }

	[CompilerGenerated]
	private void set_Data(AreaData value) { }

	[AsyncStateMachine(typeof(<SetInfo>d__28))]
	protected override void SetInfo() { }

	public void Show(AreaData data, Action onSelected = null) { }

}

