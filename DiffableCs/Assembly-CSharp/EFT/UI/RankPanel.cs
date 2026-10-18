namespace EFT.UI;

public sealed class RankPanel : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _rank; //Field offset: 0x70
	[SerializeField]
	private GameObject _eliteRank; //Field offset: 0x78

	public RankPanel() { }

	public void Show(int rankLevel, int maxRank) { }

}

