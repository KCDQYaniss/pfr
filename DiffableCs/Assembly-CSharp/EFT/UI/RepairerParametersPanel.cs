namespace EFT.UI;

public class RepairerParametersPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__43_0; //Field offset: 0x8
		public static Func <>9__50_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Show>b__43_0(IRepairer trader) { }

		internal string <UpdateRepairers>b__50_0(IRepairer trader) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public IItemOwner itemOwner; //Field offset: 0x10
		public RepairerParametersPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass43_0() { }

		internal void <Show>b__1() { }

	}

	private const string COLORIZED_LINE = "<color=#c5c3b4>{0}</color> {1}"; //Field offset: 0x0
	[SerializeField]
	private DropDownBox _tradersDropDown; //Field offset: 0x70
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x78
	[SerializeField]
	private Image _avatar; //Field offset: 0x80
	[SerializeField]
	private GameObject _repairerStandingGameObject; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _repairPriceRate; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _repairerStanding; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _repairSpeed; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _repairQuality; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _repairability; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _enhancementChance; //Field offset: 0xB8
	[SerializeField]
	private RepairWarningStatusPanel _repairWarningStatusPanel; //Field offset: 0xC0
	[SerializeField]
	private ConditionCharacteristicsSlider _conditionSlider; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _repairTime; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _repairDp; //Field offset: 0xD8
	[SerializeField]
	private LocalizedText _cashInStashLabel; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _cashInStash; //Field offset: 0xE8
	[SerializeField]
	private Image _cashInStashIcon; //Field offset: 0xF0
	[SerializeField]
	private Sprite _repairPointsInStashSprite; //Field offset: 0xF8
	[SerializeField]
	private LocalizedText _sumToPayLabel; //Field offset: 0x100
	[SerializeField]
	private TextMeshProUGUI _sumToPay; //Field offset: 0x108
	[SerializeField]
	private Image _sumToPayIcon; //Field offset: 0x110
	[SerializeField]
	private Sprite _repairPointsToPaySprite; //Field offset: 0x118
	[SerializeField]
	private TextMeshProUGUI _repairKitChargeText; //Field offset: 0x120
	[SerializeField]
	private Color _criticalColor; //Field offset: 0x128
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x138
	private RepairController _repairController; //Field offset: 0x148
	private IRepairStrategy _repairStrategy; //Field offset: 0x150
	private Inventory _inventory; //Field offset: 0x158
	private Sprite _cashSprite; //Field offset: 0x160
	private RepairKit _draggedRepairKit; //Field offset: 0x168
	private RepairKit _initialDraggedRepairKit; //Field offset: 0x170
	private CompositeDisposable _avatarCancellationSource; //Field offset: 0x178
	private float _lastRepairAmount; //Field offset: 0x180
	private Item _item; //Field offset: 0x188

	public IRepairer CurrentRepairer
	{
		 get { } //Length: 81
	}

	private float RealCurrentDurability
	{
		private get { } //Length: 32
	}

	public float RepairAmount
	{
		 get { } //Length: 32
	}

	public RepairerParametersPanel() { }

	[CompilerGenerated]
	private void <Awake>b__41_0(float arg) { }

	private void AddRepairKit(RepairKit repairKit) { }

	private void Awake() { }

	private bool CanRepair(RepairKit repairKit, Item item) { }

	public IRepairer get_CurrentRepairer() { }

	private float get_RealCurrentDurability() { }

	public float get_RepairAmount() { }

	private int GetCurrencyPrice(IRepairer repairer, Item item, float count) { }

	private string GetEnhancementChance(double chance) { }

	private int GetRepairerIndex(IRepairer repairer) { }

	private string GetRepairPriceRateQuality(double priceRate) { }

	private string GetRepairQualityRate(float quality) { }

	private void HideRepairKitCharges() { }

	public void ItemAddedHandler(AddItemEventArgs eventArgs) { }

	private void ItemRefreshHandler(RefreshItemEventArgs eventArgs) { }

	public void ItemRemovedHandler(RemoveItemEventArgs eventArgs) { }

	private void LateUpdate() { }

	private void RemoveRepairKit(RepairKit repairKit) { }

	private static string RepairabilityText(Vector2 repairDegradation, bool isRepairKit) { }

	private void SetDegradationValues(float sliderValue, bool setMaxValue) { }

	public void Show(IRepairStrategy repairStrategy, RepairController repairController, Item item, Inventory inventory, RepairKit draggedRepairKit) { }

	private void ShowRepairKitCharges(RepairKit repairKit) { }

	private void TraderSelected(int index) { }

	public void UpdateBuffState() { }

	public void UpdateConditionSlider() { }

	private void UpdateEnhancementChance() { }

	public void UpdateRepairers() { }

	public void UpdateRepairKitLabels() { }

	public void UpdateTraderLabels() { }

}

