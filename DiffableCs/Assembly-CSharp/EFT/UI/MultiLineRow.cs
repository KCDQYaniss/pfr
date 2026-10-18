namespace EFT.UI;

public sealed class MultiLineRow : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _label; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _value; //Field offset: 0x78
	[SerializeField]
	private GameObject _line; //Field offset: 0x80

	public MultiLineRow() { }

	private void DisableAll() { }

	private static string FormatTmpText(string text) { }

	private static void SetTmpText(TextMeshProUGUI textField, string text) { }

	public void Show(SingleLineInfo rowInfo) { }

}

