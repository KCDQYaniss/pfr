namespace EFT.UI.Insurance;

public class InsuredItemPanel : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _itemNameLabel; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _insurerNamePanel; //Field offset: 0x78
	[SerializeField]
	private TradeItemType _itemType; //Field offset: 0x80

	public InsuredItemPanel() { }

	public void Show(string itemName, string insurerName, EItemType itemType) { }

}

