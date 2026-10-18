namespace EFT.UI;

public sealed class DisplayMoneyPanel : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _roubles; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _euros; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _dollars; //Field offset: 0x80

	public DisplayMoneyPanel() { }

	public void Show(IEnumerable inventoryItems) { }

}

