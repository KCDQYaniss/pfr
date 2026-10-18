namespace EFT.UI;

public sealed class DogtagPreviewSelectableItemContext : SelectableItemContext
{

	public DogtagPreviewSelectableItemContext(ISelectionContext selectionContext) { }

	private DogtagPreviewSelectableItemContext(Item item, DogtagPreviewSelectableItemContext source) { }

	public virtual SelectableItemContext CreateSelectableChild(Item item) { }

	public virtual ContextInteractions GetItemContextInteractions(Action closeAction) { }

}

