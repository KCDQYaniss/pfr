namespace EFT.UI;

public class TraderHoverPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField]
	private Image _buttonImage; //Field offset: 0x70
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x78
	[SerializeField]
	private Color _selectedColor; //Field offset: 0x88
	[SerializeField]
	[Space]
	private Image _standingIcon; //Field offset: 0x98
	[SerializeField]
	private Image _timeIcon; //Field offset: 0xA0
	[SerializeField]
	private Color _defaultIconColor; //Field offset: 0xA8
	[SerializeField]
	private Color _selectedIconColor; //Field offset: 0xB8
	[SerializeField]
	[Space]
	private Color _defaultTextColor; //Field offset: 0xC8
	[SerializeField]
	private CustomTextMeshProUGUI[] _labels; //Field offset: 0xD8
	private readonly Dictionary _colors; //Field offset: 0xE0
	private Action _onClick; //Field offset: 0xE8

	public TraderHoverPanel() { }

	private void Awake() { }

	public virtual void Close() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(Action onClick) { }

}

