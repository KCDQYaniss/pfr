namespace EFT.UI;

public class TraderTooltip : MonoBehaviour
{
	private const string BAD_COLOR = "#c40000"; //Field offset: 0x0
	private const string NEUTRAL_COLOR = "#747b7e"; //Field offset: 0x0
	private const string TRADER_PRICE_SELL_DOWN = "Perks/SellDownMultiplier{0}"; //Field offset: 0x0
	private const string TRADER_PRICE_SELL_UP = "Perks/SellUpMultiplier{0}"; //Field offset: 0x0
	private const string TRADER_PRICE_BUY_DOWN = "Perks/BuyDownMultiplier{0}"; //Field offset: 0x0
	private const string TRADER_PRICE_BUY_UP = "Perks/BuyUpMultiplier{0}"; //Field offset: 0x0
	private const string TRADER_IS_LOCKED = "traders/trader_is_locked"; //Field offset: 0x0
	private const string GOOD_COLOR = "#54c1ff"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _nickname; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProUGUI _location; //Field offset: 0x28
	[SerializeField]
	private CustomTextMeshProUGUI _description; //Field offset: 0x30
	[SerializeField]
	private CustomTextMeshProUGUI _loyaltyLevel; //Field offset: 0x38
	[SerializeField]
	private CustomTextMeshProUGUI _standing; //Field offset: 0x40
	[SerializeField]
	private CustomTextMeshProUGUI _moneySpent; //Field offset: 0x48
	[SerializeField]
	private GameObject _nextLevelContainer; //Field offset: 0x50
	[SerializeField]
	private CustomTextMeshProUGUI _standingRequired; //Field offset: 0x58
	[SerializeField]
	private CustomTextMeshProUGUI _moneySpentRequired; //Field offset: 0x60
	[SerializeField]
	private CustomTextMeshProUGUI _playerLevelRequired; //Field offset: 0x68
	[SerializeField]
	private TextMeshProUGUI _perkPriceLabel; //Field offset: 0x70
	[SerializeField]
	private GameObject _standingMet; //Field offset: 0x78
	[SerializeField]
	private GameObject _moneySpentMet; //Field offset: 0x80
	[SerializeField]
	private GameObject _playerLevelMet; //Field offset: 0x88
	[SerializeField]
	private GameObject _detailsPanel; //Field offset: 0x90
	[SerializeField]
	private GameObject _lockedPanel; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _lockedText; //Field offset: 0xA0
	[SerializeField]
	private GameObject _separator; //Field offset: 0xA8

	public TraderTooltip() { }

	private static void AppendPriceLine(StringBuilder builder, float multiplier, string upText, string downText, bool positiveIsGood) { }

	private void FillPerkPrices(TraderInfo traderInfo) { }

	public void Hide() { }

	private void SetPosition(Vector2 position) { }

	public void Show(TraderInfo traderInfo) { }

	private void Update() { }

}

