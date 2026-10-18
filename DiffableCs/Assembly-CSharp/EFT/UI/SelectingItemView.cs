namespace EFT.UI;

public sealed class SelectingItemView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	private const string NO_ITEM_HEADER = "EMPTY_SLOT"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _name; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _details; //Field offset: 0x78
	[SerializeField]
	private Image _itemIcon; //Field offset: 0x80
	[SerializeField]
	private Image _background; //Field offset: 0x88
	[SerializeField]
	private GameObject _foundInRaid; //Field offset: 0x90
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x98
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0xA0
	private ItemIcon _realItemIcon; //Field offset: 0xA8
	private Action _onSelected; //Field offset: 0xB0
	private Item _currentItem; //Field offset: 0xB8

	public SelectingItemView() { }

	private void IconChangedHandler() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void ScaleImage(Vector2 size) { }

	public void SetDetails(string details) { }

	public void SetItem(Item item, Action onSelected) { }

}

