namespace EFT.UI.Map;

public sealed class EntryPointView : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _background; //Field offset: 0x70
	[SerializeField]
	private Image _glow; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _nameLabel; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _indexLabel; //Field offset: 0x90
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x98
	[SerializeField]
	private Color _selectedColor; //Field offset: 0xA8
	[SerializeField]
	private Color _defaultTextColor; //Field offset: 0xB8
	[SerializeField]
	private Color _selectedTextColor; //Field offset: 0xC8
	[SerializeField]
	private Outline _outline; //Field offset: 0xD8
	[SerializeField]
	private Color _defaultOutlineColor; //Field offset: 0xE0
	[SerializeField]
	private Color _selectedOutlineColor; //Field offset: 0xF0
	[SerializeField]
	private Image _iconImage; //Field offset: 0x100
	[SerializeField]
	private Image _allowDiableIcon; //Field offset: 0x108
	[SerializeField]
	private Sprite _defaultSprite; //Field offset: 0x110
	[SerializeField]
	private Sprite _selectedSprite; //Field offset: 0x118
	[SerializeField]
	private Sprite _lockedSprite; //Field offset: 0x120
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0x128
	[SerializeField]
	private Image _textObject; //Field offset: 0x130
	private readonly Color32 _defaultBackgroundColor; //Field offset: 0x138
	private bool _allowSelection; //Field offset: 0x13C
	private EntryPoint _point; //Field offset: 0x140
	private Action _onSelect; //Field offset: 0x148
	private bool _selected; //Field offset: 0x150

	public EntryPointView() { }

	public void Deselect() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Select() { }

	private void SetInfo(EntryPoint point) { }

	public void Show(bool allowSelection, EntryPoint entryPoint, bool editPositions, Action onSelect, Action onDoubleClick) { }

	private void Update() { }

}

