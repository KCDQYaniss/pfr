namespace EFT.UI;

public sealed class HealthTreatmentServiceView : ServiceView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__38_0; //Field offset: 0x8
		public static Comparison <>9__41_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <ApplyTreatments>b__41_0(Item a, Item b) { }

		internal HealthTreatmentView <Show>b__38_0(TreatmentWrapper treatmentWrapper) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public HealthTreatmentServiceView <>4__this; //Field offset: 0x10
		public MultiLineTooltip tooltip; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal void <Awake>b__0(PointerEventData arg) { }

		internal void <Awake>b__1(PointerEventData arg) { }

	}

	private const string TREAT_ALL_LOC_KEY = "UI/HealthTreatmentScreen_TreatAll"; //Field offset: 0x0
	private const string TREAT_NONE_LOC_KEY = "UI/HealthTreatmentScreen_TreatNone"; //Field offset: 0x0
	private const string NOT_ENOUGH_MONEY_TOOLTIP = "UI/HealthTreatmentScreen_NotEnoughMoney"; //Field offset: 0x0
	private const string NOTHING_TO_HEAL_TOOLTIP = "UI/HealthTreatmentScreen_NoTreatmentSelected"; //Field offset: 0x0
	private const string QUICK_HEAL_DESCRIPTION = "UI/HealthTreatmentScreen_Description"; //Field offset: 0x0
	private const string TRIAL_PERIOD_DESCRIPTION = "UI/HealthTreatmentScreen_TrialDescription"; //Field offset: 0x0
	private static readonly List PossibleHealthFactors; //Field offset: 0x0
	[SerializeField]
	private InventoryScreenHealthPanel _bodyPreview; //Field offset: 0x70
	[SerializeField]
	private RectTransform _healthConditionsContainer; //Field offset: 0x78
	[SerializeField]
	private RectTransform _damageList; //Field offset: 0x80
	[SerializeField]
	private RectTransform _nothingToHealMessage; //Field offset: 0x88
	[SerializeField]
	private RectTransform _loadingIndicator; //Field offset: 0x90
	[SerializeField]
	private HealthTreatmentFactorView _healthFactorTemplate; //Field offset: 0x98
	[SerializeField]
	private HealthTreatmentEffectView _healthEffectTemplate; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _quickHealNote; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _regenTimeField; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _cashInStashField; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _costTotalField; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _treatAllField; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _regenTimeCanvasGroup; //Field offset: 0xD0
	[SerializeField]
	private UpdatableToggle _selectAllToggle; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _applyButton; //Field offset: 0xE0
	private Trader _trader; //Field offset: 0xE8
	private Profile _profile; //Field offset: 0xF0
	private InventoryController _inventoryController; //Field offset: 0xF8
	private OfflineHealthController _healthController; //Field offset: 0x100
	private IEftSession _session; //Field offset: 0x108
	private int _totalCost; //Field offset: 0x110
	private int _moneyInStash; //Field offset: 0x114
	private bool _nothingToHeal; //Field offset: 0x118
	private bool _nothingSelected; //Field offset: 0x119
	private double _healingDiscount; //Field offset: 0x120
	private bool _isTooltipUpdateNeeded; //Field offset: 0x128
	private MultiLineInfo _dataForTooltip; //Field offset: 0x130
	private BindableList _treatmentsList; //Field offset: 0x138

	private static HealthTreatmentServiceView() { }

	public HealthTreatmentServiceView() { }

	[CompilerGenerated]
	private Transform <Show>b__38_1(TreatmentWrapper treatmentWrapper) { }

	[CompilerGenerated]
	private void <Show>b__38_2(TreatmentWrapper treatmentWrapper, HealthTreatmentView treatmentView) { }

	[CompilerGenerated]
	private void <Show>b__38_3() { }

	[CompilerGenerated]
	private void <Show>b__38_4() { }

	private void AddTreatment(TreatmentWrapper treatment) { }

	private void ApplyTreatments() { }

	private void Awake() { }

	public virtual bool CheckAvailable(Trader trader) { }

	private void CreateHealthEffectsList(List effectObservers) { }

	private void CreateHealthFactorsList(List factorObservers) { }

	public static string FormatRublesString(float value) { }

	private static List GetHealthEffectObservers(Profile profile, OfflineHealthController healthController, TraderInfo trader) { }

	private static List GetHealthFactorObservers(Profile profile, OfflineHealthController healthController, TraderInfo trader) { }

	public static IEnumerable GetHealthObservers(Profile profile, OfflineHealthController healthController, TraderInfo trader) { }

	private void Init(Profile profile, InventoryController inventoryController, OfflineHealthController healthController) { }

	private void OnSelectAll(bool selected) { }

	public void Preview(Profile profile, InventoryController inventoryController, OfflineHealthController healthController) { }

	private void RecalculateCost() { }

	private void RemoveTreatment(TreatmentWrapper treatment) { }

	private void SetSelectAll(bool selected, bool sentCallback) { }

	public virtual void Show(Trader trader, Profile profile, InventoryController inventoryController, OfflineHealthController healthController, QuestBook quests, AchievementsBook achievements, ItemUiContext context, IEftSession session) { }

	private void UpdateMoneyInStash() { }

	private void UpdateRegenTime() { }

	private void UpdateTreatmentAvailability() { }

}

