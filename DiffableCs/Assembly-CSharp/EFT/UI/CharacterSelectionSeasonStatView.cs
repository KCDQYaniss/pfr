namespace EFT.UI;

public sealed class CharacterSelectionSeasonStatView : UIElement
{
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _caption; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _value; //Field offset: 0x80

	public CharacterSelectionSeasonStatView() { }

	public void Show(ECharacterSelectionSeasonStat stat, string value, Sprite icon) { }

}

