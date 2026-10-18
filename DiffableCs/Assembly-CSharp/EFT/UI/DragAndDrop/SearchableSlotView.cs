namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public class SearchableSlotView : SlotView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CreateSlots>b__12_0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public SlotView itemSlotView; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <CreateSlots>b__2() { }

	}

	private const string POCKETS_SLOT_ID = "Pockets"; //Field offset: 0x0
	private const string SPECIAL_SLOTS_HEADER = "InventoryScreen/SpecialSlotsHeader"; //Field offset: 0x0
	[SerializeField]
	private SearchableItemView _searchableItemView; //Field offset: 0x170
	[SerializeField]
	private Transform _specSlotsPanel; //Field offset: 0x178
	[SerializeField]
	private SlotView _specSlotTemplate; //Field offset: 0x180
	[SerializeField]
	private TMP_Text _specSlotHeader; //Field offset: 0x188
	[CanBeNull]
	private IPlayerSearchController _searchController; //Field offset: 0x190
	private readonly CompositeDisposable _slotsDisposable; //Field offset: 0x198
	private bool _showSlots; //Field offset: 0x1A0

	public SearchableSlotView() { }

	[CompilerGenerated]
	private void <CreateSlots>b__12_1() { }

	private void CreateSlots(Item item) { }

	public virtual void DragCancelled() { }

	public virtual void DragStarted() { }

	protected virtual void OnAddToSlot(Item item, AddItemEventArgs args) { }

	protected virtual void OnRemoveFromSlot(Item item, RemoveItemEventArgs args) { }

	private void SearchOperationsChangedHandler() { }

	public virtual void Show(Slot slot, ItemContext parentItemContext, ItemController itemController, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance, bool canClickOnHeader = false) { }

	private void ShowContent(Item item) { }

	private void TryShowSearchableItemView(Item item) { }

}

