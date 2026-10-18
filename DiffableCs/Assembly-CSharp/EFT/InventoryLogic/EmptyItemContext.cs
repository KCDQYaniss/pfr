namespace EFT.InventoryLogic;

public sealed class EmptyItemContext : ItemContext
{

	public virtual bool IsPreviewHighlightAvailable
	{
		 get { } //Length: 3
	}

	public EmptyItemContext() { }

	public EmptyItemContext(EItemViewType viewType) { }

	public virtual ItemContext CreateChild(Item item) { }

	public virtual bool get_IsPreviewHighlightAvailable() { }

	public virtual bool IsDropAvailable(DragItemContext itemContext) { }

}

