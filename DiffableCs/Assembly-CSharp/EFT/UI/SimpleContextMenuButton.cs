namespace EFT.UI;

public class SimpleContextMenuButton : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x70
	[SerializeField]
	private Button _button; //Field offset: 0x78
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x80
	[SerializeField]
	private Sprite _backgroundSprite; //Field offset: 0x88
	[SerializeField]
	private Color _defaultBackgroundColor; //Field offset: 0x90
	[SerializeField]
	private Color _selectedBackgroundColor; //Field offset: 0xA0
	[SerializeField]
	private Image _subMenuArrow; //Field offset: 0xB0
	[CanBeNull]
	[SerializeField]
	private RectTransform _singleInstanceParent; //Field offset: 0xB8
	private Action _onClicked; //Field offset: 0xC0
	private Action _onHover; //Field offset: 0xC8
	private SimpleTooltip _tooltip; //Field offset: 0xD0
	private bool _locked; //Field offset: 0xD8
	private bool _displayTooltip; //Field offset: 0xD9
	private string _lockReason; //Field offset: 0xE0
	private bool _blocked; //Field offset: 0xE8
	private bool _underCursor; //Field offset: 0xE9
	private bool _shown; //Field offset: 0xEA

	public bool Blocked
	{
		 get { } //Length: 8
		 set { } //Length: 93
	}

	public bool SingleInstance
	{
		 get { } //Length: 206
	}

	public virtual Transform Transform
	{
		 get { } //Length: 102
	}

	public SimpleContextMenuButton() { }

	[CompilerGenerated]
	private void <Show>b__24_0() { }

	public virtual void Close() { }

	public bool get_Blocked() { }

	public bool get_SingleInstance() { }

	public virtual Transform get_Transform() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void set_Blocked(bool value) { }

	public void SetButtonInteraction(IResult interactionState) { }

	public override void Show(string caption, string imageText, Sprite sprite, Action onClicked, Action onHover, bool subMenu = false, bool hideIcon = false) { }

}

