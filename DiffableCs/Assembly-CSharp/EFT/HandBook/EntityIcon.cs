namespace EFT.HandBook;

public sealed class EntityIcon : UIElement
{
	[SerializeField]
	private Image _iconImage; //Field offset: 0x70
	[SerializeField]
	private Image _colorPanel; //Field offset: 0x78
	[SerializeField]
	private GameObject _loader; //Field offset: 0x80
	[SerializeField]
	private ItemViewStats _itemStats; //Field offset: 0x88
	private ItemIcon _itemIcon; //Field offset: 0x90
	private Item _item; //Field offset: 0x98
	private SimpleTooltip _tooltip; //Field offset: 0xA0

	public EntityIcon() { }

	[CompilerGenerated]
	private void <Awake>b__7_0(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Awake>b__7_1(PointerEventData eventData) { }

	private void Awake() { }

	public virtual void Close() { }

	private void IconChangedHandler() { }

	public void Show(Item item) { }

}

