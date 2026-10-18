namespace EFT.UI;

public class LabelContentRow : UIElement
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _titleText; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _mainText; //Field offset: 0x80

	public LabelContentRow() { }

	public void Show(string mainText, string titleText = null, Sprite sprite = null) { }

}

