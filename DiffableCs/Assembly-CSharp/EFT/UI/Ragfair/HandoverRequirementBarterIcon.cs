namespace EFT.UI.Ragfair;

public sealed class HandoverRequirementBarterIcon : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _barterIcon; //Field offset: 0x70
	[SerializeField]
	private Color _unavailableColor; //Field offset: 0x78
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x88
	[SerializeField]
	private Color _selectedColor; //Field offset: 0x98
	private string _itemName; //Field offset: 0xA8
	private SimpleTooltip _tooltip; //Field offset: 0xB0
	private Requisite _requisite; //Field offset: 0xB8

	public HandoverRequirementBarterIcon() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(Requisite requisite, SimpleTooltip tooltip) { }

	public void UpdateView() { }

}

