namespace EFT.UI;

public sealed class TradingOfferTooltip : Tooltip
{
	private const string GOOD_COLOR = "#83C5A9"; //Field offset: 0x0
	private const string BAD_COLOR = "#D42929"; //Field offset: 0x0
	private const string REQUIRED_KEY = "TradingOffer/Required"; //Field offset: 0x0
	private const string CURRENT_KEY = "TradingOffer/YourLevel"; //Field offset: 0x0
	[SerializeField]
	private Image _avatar; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _traderName; //Field offset: 0xB0
	[SerializeField]
	private TMP_Text _loyaltyLevelTitle; //Field offset: 0xB8
	[SerializeField]
	private TMP_Text _requiredLabel; //Field offset: 0xC0
	[SerializeField]
	private TMP_Text _currentLabel; //Field offset: 0xC8
	[SerializeField]
	private RankPanel _requiredRank; //Field offset: 0xD0
	[SerializeField]
	private RankPanel _currentRank; //Field offset: 0xD8

	public TradingOfferTooltip() { }

	public void Show(QuestReward reward, Profile profile, IImageLoader imageLoader) { }

}

