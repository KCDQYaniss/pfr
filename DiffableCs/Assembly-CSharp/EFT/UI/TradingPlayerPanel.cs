namespace EFT.UI;

public sealed class TradingPlayerPanel : UIElement
{
	private const string GoodColor = "#54c1ff"; //Field offset: 0x0
	private const string BadColor = "#c40000"; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _level; //Field offset: 0x70
	[SerializeField]
	private Image _levelIcon; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _nickname; //Field offset: 0x80
	[SerializeField]
	private DisplayMoneyPanelTMPText _moneyCountPanel; //Field offset: 0x88
	[SerializeField]
	private GameObject _nextRankPanel; //Field offset: 0x90
	[SerializeField]
	private RankPanel _currentRank; //Field offset: 0x98
	[SerializeField]
	private RankPanel _nextRank; //Field offset: 0xA0
	[SerializeField]
	private CustomTextMeshProUGUI _currentLevel; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI _nextLevel; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _currentStanding; //Field offset: 0xB8
	[SerializeField]
	private CustomTextMeshProUGUI _nextStanding; //Field offset: 0xC0
	[SerializeField]
	private CustomTextMeshProUGUI _currentMoney; //Field offset: 0xC8
	[SerializeField]
	private CustomTextMeshProUGUI _nextMoney; //Field offset: 0xD0
	[SerializeField]
	private PlayerIconImage _playerIconImage; //Field offset: 0xD8

	public TradingPlayerPanel() { }

	public static MoneyString GetMoneyTuple(Dictionary moneySums) { }

	public void Set(Profile profile, TraderInfo traderInfo) { }

	public void UpdateStats(TraderInfo traderInfo) { }

}

