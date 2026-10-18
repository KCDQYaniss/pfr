namespace EFT.UI;

public class KeyCardItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField]
	private CustomTextMeshProUGUI _name; //Field offset: 0x70
	[SerializeField]
	private Image _itemIcon; //Field offset: 0x78
	[SerializeField]
	private Image _background; //Field offset: 0x80
	private ItemIcon _realItemIcon; //Field offset: 0x88
	private Action _onSelected; //Field offset: 0x90
	private Item _currentItem; //Field offset: 0x98

	public KeyCardItem() { }

	private void OnIconChanged() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void ScaleImage(Vector2 size) { }

	public void SetItem(Item item, Action onSelected) { }

}

