namespace EFT.UI.DragAndDrop;

public sealed class ModSlotView : SlotView, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__14_1; //Field offset: 0x10
		public static Func <>9__14_2; //Field offset: 0x18
		public static Func <>9__14_4; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <SetFilters>b__14_0(ItemFilter x) { }

		internal bool <SetFilters>b__14_1(ItemFilter x) { }

		internal IEnumerable <SetFilters>b__14_2(ItemFilter x) { }

		internal bool <SetFilters>b__14_4(Sprite sprite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public IEnumerable excludeTypes; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <SetFilters>b__3(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public Type t; //Field offset: 0x10

		public <>c__DisplayClass14_1() { }

		internal bool <SetFilters>b__5(Type excludedType) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__LoadModIconSprite; //Field offset: 0x0

	}

	internal struct TooltipData
	{
		public string Error; //Field offset: 0x0
		public string ItemName; //Field offset: 0x8

		public virtual string ToString() { }

	}

	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x170
	[SerializeField]
	private TextMeshProUGUI _slotName; //Field offset: 0x178
	[SerializeField]
	private RectTransform _filtersGroup; //Field offset: 0x180
	[SerializeField]
	private Sprite _uncheckedChamberSprite; //Field offset: 0x188
	private TooltipData _tooltipData; //Field offset: 0x190
	private bool _locked; //Field offset: 0x1A0

	public ModSlotView() { }

	protected virtual ItemView CreateItemViewKernel(Item item, IItemOwner itemOwner) { }

	private void ModLock(bool locked, Slot slot) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void SetActiveCamora(Item item, EModLockedState lockedState) { }

	private void SetFilters(Slot slot) { }

	public void SetLocked(KeyValuePair lockedState, Slot slot, Item item) { }

	private void SetUnknownIconStatus(bool value) { }

	protected virtual void SetupItemView(Item item) { }

	public void Show(Slot slot, ItemContext parentItemContext, ItemController inventoryController, ItemUiContext itemUiContext) { }

	private bool TryGetArmorSlot(out ArmorSlot outArmorSlot, out ArmorPlate outArmorPlate) { }

}

