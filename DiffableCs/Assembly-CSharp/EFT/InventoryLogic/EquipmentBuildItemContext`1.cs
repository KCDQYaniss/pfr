namespace EFT.InventoryLogic;

public sealed class EquipmentBuildItemContext`1 : DefaultItemContext, IMissingChildrenContextComponent
{
	private bool _hasMissingChildren; //Field offset: 0x0
	private MissingItemsError _missingItemsError; //Field offset: 0x0
	private readonly EItemViewComponent[] _viewComponents; //Field offset: 0x0
	[CompilerGenerated]
	private LocalizedError <Error>k__BackingField; //Field offset: 0x0
	private readonly IReadOnlyDictionary _missingItems; //Field offset: 0x0

	private override MissingItemsError EFT.InventoryLogic.IMissingChildrenContextComponent.Error
	{
		private get { } //Length: 5
	}

	private override bool EFT.InventoryLogic.IMissingChildrenContextComponent.HasMissingChildren
	{
		private get { } //Length: 5
	}

	public virtual LocalizedError Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected virtual IEnumerable ViewComponents
	{
		 get { } //Length: 8
	}

	public EquipmentBuildItemContext`1(TItem item, IReadOnlyDictionary missingItems, EItemViewType viewType) { }

	private EquipmentBuildItemContext`1(TItem item, ItemContext sourceContext, IReadOnlyDictionary missingItems) { }

	public virtual ItemContext CreateChild(Item item) { }

	private override MissingItemsError EFT.InventoryLogic.IMissingChildrenContextComponent.get_Error() { }

	private override bool EFT.InventoryLogic.IMissingChildrenContextComponent.get_HasMissingChildren() { }

	[CompilerGenerated]
	public virtual LocalizedError get_Error() { }

	protected virtual IEnumerable get_ViewComponents() { }

	private void Init() { }

	[CompilerGenerated]
	protected virtual void set_Error(LocalizedError value) { }

}

