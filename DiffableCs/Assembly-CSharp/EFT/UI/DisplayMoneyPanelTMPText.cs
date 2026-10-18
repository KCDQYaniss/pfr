namespace EFT.UI;

public class DisplayMoneyPanelTMPText : UIElement
{
	[SerializeField]
	private TMP_Text _roubles; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _euros; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _dollars; //Field offset: 0x80

	public DisplayMoneyPanelTMPText() { }

	public void Show(IEnumerable inventoryItems) { }

}

