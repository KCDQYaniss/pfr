namespace EFT.UI.Ragfair;

public sealed class OfferItemDescription : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8
		public static Func <>9__21_1; //Field offset: 0x10
		public static Func <>9__21_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <SetItemName>b__21_0(string x) { }

		internal float <SetItemName>b__21_1(RepairableComponent x) { }

		internal float <SetItemName>b__21_2(RepairableComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public OfferItemDescription <>4__this; //Field offset: 0x10
		public Offer offer; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1(PointerEventData arg) { }

		internal void <Show>b__2(PointerEventData arg) { }

	}

	private const int DURABILITY_THRESHOLD = 10; //Field offset: 0x0
	[SerializeField]
	private HoverTrigger _hoverTrigger; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _offerItemName; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _offerStackCount; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _offersCount; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI _itemCategory; //Field offset: 0x90
	[SerializeField]
	private InteractionButtonsContainer _offerContextMenu; //Field offset: 0x98
	[SerializeField]
	private RagfairOfferItemView _offerItemView; //Field offset: 0xA0
	[SerializeField]
	private Transform _resourceCountersContainer; //Field offset: 0xA8
	[SerializeField]
	private OfferViewResourceCounter _resourceCounterTemplate; //Field offset: 0xB0
	private Offer _offer; //Field offset: 0xB8
	private ItemUiContext _itemUiContext; //Field offset: 0xC0
	private InventoryController _inventoryController; //Field offset: 0xC8
	private HandbookNode _selectedNode; //Field offset: 0xD0
	private ContextInteractions _contextInteractions; //Field offset: 0xD8
	private SimpleTooltip _tooltip; //Field offset: 0xE0
	private bool _expanded; //Field offset: 0xE8
	private readonly List _resourceCounters; //Field offset: 0xF0
	private UiElementPool _resourceCounterPool; //Field offset: 0xF8

	public OfferItemDescription() { }

	private PointerEventsProxy AddCounter(EItemAttributeId iconType, float value, float maxValue, string textColor) { }

	private void Clear() { }

	private void ClearContextMenu() { }

	private void ClearCounters() { }

	public virtual void Close() { }

	private void HideTooltip() { }

	private void OnExamine(ExamineItemEventArgs eventArgs) { }

	private void OnExamineEventHandler(ExamineItemEventArgs args) { }

	private void SetItemName() { }

	public void Show(Handbook handbook, Offer offer, bool expanded, InventoryController inventoryController, ItemUiContext itemUiContext, InsuranceCompany insuranceCompany) { }

	private void ShowArmorPlatesTooltip() { }

	private void ShowDurabilityTooltip() { }

	public void UpdateItemStackCountLabel() { }

}

