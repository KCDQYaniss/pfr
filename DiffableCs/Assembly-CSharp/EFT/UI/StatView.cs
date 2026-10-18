namespace EFT.UI;

public sealed class StatView : UIElement
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _name; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _value; //Field offset: 0x80
	[SerializeField]
	private SpriteMap _icons; //Field offset: 0x88
	[SerializeField]
	private ColorMap _colors; //Field offset: 0x90

	public StatView() { }

	public void Show(QuestReward reward) { }

}

