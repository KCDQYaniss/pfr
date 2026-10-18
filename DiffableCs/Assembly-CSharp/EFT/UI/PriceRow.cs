namespace EFT.UI;

public sealed class PriceRow : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _amount; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _extraLabel; //Field offset: 0x78

	public PriceRow() { }

	private void DisableAll() { }

	public void Show(SingleLineInfo rowInfo) { }

}

