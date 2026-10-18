namespace UI.Hideout;

public sealed class HideoutCustomizationOptionsWithSlotsPanel : HideoutCustomizationOptionsPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__7_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CreateCellsGrid>b__7_0(AreaData x) { }

		internal bool <OnItemSelection>b__5_0(HideoutCustomizationCell cell) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public HideoutCustomizationController customizationController; //Field offset: 0x10
		public HideoutCustomizationOptionsWithSlotsPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public EAreaType areaType; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <CreateCellsGrid>b__1(AreaData a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public HideoutCustomizationSlotOffer offer; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <CollectStashSlotsForAreaOffers>b__0(Slot s) { }

	}

	[SerializeField]
	private HideoutCustomizationSlotsGroupView _slotsGroup; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _resetAllButton; //Field offset: 0xC0
	private Action _onSlotItemSelectionChangedAction; //Field offset: 0xC8
	private Func _canSelect; //Field offset: 0xD0

	public HideoutCustomizationOptionsWithSlotsPanel() { }

	private void ClearAllSlots() { }

	public virtual void Close() { }

	private static Dictionary CollectOffersByArea(IEnumerable slotsOffers) { }

	private static Dictionary CollectStashSlotsForAreaOffers(Slot[] stashSlots, IEnumerable offers) { }

	private void CreateCellsGrid(IEnumerable slotsOffers, Slot[] stashSlots) { }

	protected virtual void OnCellSelected(HideoutCustomizationCell selectedCell) { }

	private void OnItemSelection(bool itemSelectionInProcess) { }

	public void Show(EHideoutCustomizationType customizationType, HideoutCustomizationController customizationController, Action slotClickHandler) { }

	private void ShowSlots(HideoutCustomizationCell selectedCell) { }

}

