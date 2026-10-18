namespace EFT.UI.Map;

[UsedImplicitly]
public sealed class MapScreen : UIElement, ISelectionContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Item <Show>b__15_0(MapComponent x) { }

	}

	internal sealed class MapTabController : UIElementTabController
	{
		private readonly Profile _profile; //Field offset: 0x18
		private readonly InventoryController _inventoryController; //Field offset: 0x20
		private readonly CompoundItem _container; //Field offset: 0x28

		public MapTabController(MapScreen mapTab, InventoryController inventoryController, CompoundItem container) { }

		public virtual void Show() { }

	}

	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x70
	[SerializeField]
	private PocketMap _pocketMap; //Field offset: 0x78
	[SerializeField]
	private PocketMapMarkerManager _mapMarkerManager; //Field offset: 0x80
	[SerializeField]
	private MapMarkerWindow _markerWindow; //Field offset: 0x88
	[SerializeField]
	private GameObject _mapBlock; //Field offset: 0x90
	[SerializeField]
	private GameObject _emptyBlock; //Field offset: 0x98
	[SerializeField]
	private DropdownItemSelector _mapSelector; //Field offset: 0xA0
	private InventoryController _inventoryController; //Field offset: 0xA8
	private MapComponent _selectedMap; //Field offset: 0xB0
	private SelectableItemContext _itemContext; //Field offset: 0xB8
	private readonly HashSet _availableMaps; //Field offset: 0xC0

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public MapScreen() { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	public virtual void Close() { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	public void Init(MapComponent map) { }

	private void PickMapsFromCollection(IEnumerable items) { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	private void SetSelectedMap(MapComponent map) { }

	public void Show(InventoryController inventoryController, CompoundItem container) { }

	private void ShowMap(Item item) { }

	private void ShowSelectedMap() { }

}

