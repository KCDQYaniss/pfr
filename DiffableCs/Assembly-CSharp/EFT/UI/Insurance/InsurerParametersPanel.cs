namespace EFT.UI.Insurance;

public sealed class InsurerParametersPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__42_0; //Field offset: 0x8
		public static Func <>9__42_1; //Field offset: 0x10
		public static Func <>9__45_0; //Field offset: 0x18
		public static Action <>9__45_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal EItemType <InsurerSelected>b__45_0(string x) { }

		internal void <InsurerSelected>b__45_3(EItemType itemType, TradeItemType itemTypeView) { }

		internal string <Show>b__42_0(Trader trader) { }

		internal string <Show>b__42_1(Trader trader) { }

	}

	public const string NO_SELECTED_ITEMS = "Trading/NoSelectedItems"; //Field offset: 0x0
	public const string NO_PRICES_FOR_ITEMS = "Trading/NoPricesForItems"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnInsuranceAvailableChanged; //Field offset: 0x70
	[SerializeField]
	private DropDownBox _tradersDropDown; //Field offset: 0x78
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x80
	[SerializeField]
	private Image _avatar; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _minPayment; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _returnRate; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _repairerStanding; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _insureButton; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _returnTime; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _cashInStash; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _sumToPay; //Field offset: 0xC0
	[SerializeField]
	private TradeItemType _sellTypeTemplate; //Field offset: 0xC8
	[SerializeField]
	private RectTransform _sellTypesContainer; //Field offset: 0xD0
	[SerializeField]
	private Color _criticalColor; //Field offset: 0xD8
	[SerializeField]
	private Color _defaultColor; //Field offset: 0xE8
	private Inventory _inventory; //Field offset: 0xF8
	private SkillManager _skills; //Field offset: 0x100
	private ViewList _sellTypesList; //Field offset: 0x108
	private InsuranceCompany _insurance; //Field offset: 0x110
	private Action _updateItemsPrices; //Field offset: 0x118
	private int _minReturnTime; //Field offset: 0x120
	private int _maxReturnTime; //Field offset: 0x124
	private Dictionary _moneySums; //Field offset: 0x128
	private int _moneyToPay; //Field offset: 0x130
	private bool _notEnoughMoney; //Field offset: 0x134
	private double _charismaDiscount; //Field offset: 0x138
	private List _insurers; //Field offset: 0x140
	private List _insurersIndex; //Field offset: 0x148
	private CompositeDisposable _avatarCancellationSource; //Field offset: 0x150
	private MultiLineTooltip _tooltip; //Field offset: 0x158
	private MultiLineInfo _dataForTooltip; //Field offset: 0x160

	public event Action OnInsuranceAvailableChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private TraderInsurance InsuranceInfo
	{
		private get { } //Length: 98
	}

	private bool NotEnoughMoney
	{
		private get { } //Length: 8
		private set { } //Length: 42
	}

	public InsurerParametersPanel() { }

	[CompilerGenerated]
	private void <Awake>b__40_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__40_1(PointerEventData arg) { }

	[CompilerGenerated]
	private TradeItemType <InsurerSelected>b__45_1(EItemType arg) { }

	[CompilerGenerated]
	private Transform <InsurerSelected>b__45_2(EItemType arg) { }

	[CompilerGenerated]
	public void add_OnInsuranceAvailableChanged(Action value) { }

	public void Awake() { }

	public virtual void Close() { }

	private TraderInsurance get_InsuranceInfo() { }

	private bool get_NotEnoughMoney() { }

	private string GetReturnRate(int start, int end) { }

	private void InsurerSelected(int index) { }

	private void OnDisable() { }

	[CompilerGenerated]
	public void remove_OnInsuranceAvailableChanged(Action value) { }

	private void set_NotEnoughMoney(bool value) { }

	public void Show(Inventory inventory, InsuranceCompany insurance, Action updateItemsPrices, SkillManager skills) { }

	public void ShowUnavailable() { }

	public void UpdateInsureButtonStatus(Nullable error) { }

	public void UpdateLabels(int moneyToPay, bool updateMoneyToPay = true, bool updateMoneySums = true) { }

}

