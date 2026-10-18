namespace EFT.InventoryLogic;

public sealed class ModdingSelectableItemContext : SelectableItemContext
{
	internal interface IModdingSelectionContext : ISelectionContext
	{

		public IEnumerable GetAllItems(Slot slot) { }

		public EEditBuildItemAvailability GetItemAvailability(Item item) { }

		public void Highlight(ModdingSelectableItemContext context, bool selected) { }

	}

	public readonly Slot Slot; //Field offset: 0x88
	public readonly IModdingSelectionContext ModdingSelectionContext; //Field offset: 0x90

	public ModdingSelectableItemContext(IModdingSelectionContext selectionContext) { }

	private ModdingSelectableItemContext(Item item, Slot slot, ModdingSelectableItemContext sourceContext) { }

	public ModdingSelectableItemContext CreateModdingChild(Item item) { }

	public ModdingSelectableItemContext CreateModdingChild(Item item, Slot slot) { }

	public virtual SelectableItemContext CreateSelectableChild(Item item) { }

	public virtual ContextInteractions GetItemContextInteractions(Action closeAction) { }

	public void Highlight(bool selected) { }

}

