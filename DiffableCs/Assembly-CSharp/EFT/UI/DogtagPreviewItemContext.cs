namespace EFT.UI;

public sealed class DogtagPreviewItemContext : ItemContext
{

	public virtual bool IsPreviewHighlightAvailable
	{
		 get { } //Length: 3
	}

	public DogtagPreviewItemContext() { }

	private DogtagPreviewItemContext(Item item, ItemContext source) { }

	public virtual ItemContext CreateChild(Item item) { }

	public virtual bool get_IsPreviewHighlightAvailable() { }

	public virtual ContextInteractions GetItemContextInteractions(Action closeAction) { }

	public virtual bool IsDropAvailable(DragItemContext itemContext) { }

}

