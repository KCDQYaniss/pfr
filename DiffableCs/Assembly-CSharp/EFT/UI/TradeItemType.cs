namespace EFT.UI;

public class TradeItemType : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	private readonly Color _red; //Field offset: 0x78
	private SimpleTooltip _tooltip; //Field offset: 0x88
	private EItemType _itemType; //Field offset: 0x90

	public TradeItemType() { }

	public virtual void Close() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(EItemType itemType) { }

}

