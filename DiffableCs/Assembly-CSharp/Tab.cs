//Type is in global namespace

public class Tab : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private struct <Deselect>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tab <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnSelectionChanged; //Field offset: 0x20
	[SerializeField]
	protected GameObject _normalVersion; //Field offset: 0x28
	[SerializeField]
	protected GameObject _selectedVersion; //Field offset: 0x30
	[SerializeField]
	protected CanvasGroup _canvasGroup; //Field offset: 0x38
	[SerializeField]
	protected Image _targetImage; //Field offset: 0x40
	[SerializeField]
	protected Sprite _hoverSprite; //Field offset: 0x48
	[SerializeField]
	protected GameObject _hoverGraphic; //Field offset: 0x50
	[SerializeField]
	protected GameObject _idleGraphic; //Field offset: 0x58
	[SerializeField]
	private HoverTooltipArea _disabledTooltip; //Field offset: 0x60
	public LocalizedText LocalizedText; //Field offset: 0x68
	public bool Interactable; //Field offset: 0x70
	protected Sprite _normalSprite; //Field offset: 0x78
	private bool _selected; //Field offset: 0x80
	protected bool _uiSelected; //Field offset: 0x81
	protected ITabController Controller; //Field offset: 0x88

	public event Action OnSelectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected override bool CanHandlePointerClick
	{
		 get { } //Length: 17
	}

	public Tab() { }

	[CompilerGenerated]
	public void add_OnSelectionChanged(Action value) { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<Deselect>d__25))]
	public override Task Deselect() { }

	protected override bool get_CanHandlePointerClick() { }

	public override void HandlePointerClick(bool isSelectedNow) { }

	public override void Hover(bool isHovered) { }

	public override void Init(ITabController controller) { }

	protected override void OnAwake() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnSelectionChanged(Action value) { }

	public override void Select(bool sendCallback = true, bool uiOnly = false) { }

	public void SetDisabledTooltip(string tooltip) { }

	internal override void SetInteractable(bool active) { }

	private void UpdateDisabledTooltip() { }

	private void UpdateVersion() { }

	protected override void UpdateVisual(bool selected, bool uiOnly = false) { }

}

