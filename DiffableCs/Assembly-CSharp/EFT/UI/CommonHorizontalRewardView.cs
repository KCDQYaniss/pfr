namespace EFT.UI;

public sealed class CommonHorizontalRewardView : UIElement
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _name; //Field offset: 0x78
	[SerializeField]
	private SpriteMap _icons; //Field offset: 0x80

	public CommonHorizontalRewardView() { }

	public void Show(QuestReward reward) { }

}

