namespace EFT.UI;

public class SeasonsRanksSelector : UIElement
{
	[SerializeField]
	private List _items; //Field offset: 0x70
	private int _playerRank; //Field offset: 0x78
	private int _selectedRank; //Field offset: 0x7C
	private Action _rankSelectedAction; //Field offset: 0x80

	private static SeasonsRanksConfig Config
	{
		private get { } //Length: 33
	}

	public SeasonsRanksSelector() { }

	private void Draw() { }

	private static SeasonsRanksConfig get_Config() { }

	private int GetLoopedRank(int rank) { }

	public void Select(int rank) { }

	private void SelectHandler(int rankIndex) { }

	public void Show(int playerRank, int selectedRank, Action rankSelectedAction) { }

}

