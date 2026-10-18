namespace EFT.UI;

public abstract class BaseDropDownBox : InteractableElement, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public BaseDropDownBox <>4__this; //Field offset: 0x10
		public Func values; //Field offset: 0x18
		public Func validator; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		internal void <Show>g__UpdateValues|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public int index; //Field offset: 0x10
		public BaseDropDownBox <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <ToggleMenu>b__0() { }

	}

	private struct DropDownItem
	{
		public string Label; //Field offset: 0x0
		public bool Enabled; //Field offset: 0x8

	}

	[SerializeField]
	private RectTransform _openPanel; //Field offset: 0x98
	[SerializeField]
	private RectTransform _elementsContainer; //Field offset: 0xA0
	[SerializeField]
	private Button _elementTemplate; //Field offset: 0xA8
	private readonly BindableEvent _onValueChanged; //Field offset: 0xB0
	private readonly BindableEvent _onDropdownClosed; //Field offset: 0xB8
	private Vector2 _openPanelPosition; //Field offset: 0xC0
	private bool _currentToggleState; //Field offset: 0xC8
	private bool _hover; //Field offset: 0xC9
	private readonly List _values; //Field offset: 0xD0
	private bool _isInit; //Field offset: 0xD8
	private Func _validator; //Field offset: 0xE0
	[CompilerGenerated]
	private int <CurrentIndex>k__BackingField; //Field offset: 0xE8

	public private int CurrentIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected bool CurrentState
	{
		 get { } //Length: 8
	}

	protected RectTransform ElementsContainer
	{
		 get { } //Length: 8
	}

	public virtual bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 76
	}

	public IBindableEvent OnDropdownClosed
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnValueChanged
	{
		 get { } //Length: 8
	}

	protected RectTransform OpenPanel
	{
		 get { } //Length: 8
	}

	protected BaseDropDownBox() { }

	[CompilerGenerated]
	private void <Init>b__30_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Init>b__30_1(PointerEventData arg) { }

	[UsedImplicitly]
	private void Awake() { }

	internal void ClearContainer() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public int get_CurrentIndex() { }

	protected bool get_CurrentState() { }

	protected RectTransform get_ElementsContainer() { }

	public virtual bool get_Interactable() { }

	public IBindableEvent get_OnDropdownClosed() { }

	public IBindableEvent get_OnValueChanged() { }

	protected RectTransform get_OpenPanel() { }

	protected override void HoverDropDownEventHandler(bool value) { }

	protected override void Init() { }

	protected override void OnMenuStateChanged(bool open) { }

	[CompilerGenerated]
	private void set_CurrentIndex(int value) { }

	public virtual void set_Interactable(bool value) { }

	public void SetLabelText(string text) { }

	protected abstract void SetPanelState(bool open) { }

	public override void SetSpriteAsset(TMP_SpriteAsset asset) { }

	public void SetState(bool open) { }

	protected abstract void SetTextInternal(string text) { }

	public override void Show(IEnumerable values, Func validator = null) { }

	public void Show(Func values, Func validator = null) { }

	protected void ToggleMenu(bool state) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	[UsedImplicitly]
	protected override void Update() { }

	public void UpdateValue(int value, bool sendCallback = true, Nullable min = null, Nullable max = null, bool playSound = true) { }

}

