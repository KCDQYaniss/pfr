namespace EFT.UI.Seasons;

public sealed class BattlePassRewardFullView : UIElement
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _nameField; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _nameField2; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _typeField; //Field offset: 0x88
	[SerializeField]
	private GameObject _sideLabel; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _sideField; //Field offset: 0x98

	public Rect ImageSize
	{
		 get { } //Length: 684
	}

	public BattlePassRewardFullView() { }

	public Rect get_ImageSize() { }

	public void Show(BattlePassReward reward, IImageLoader imageLoader) { }

}

