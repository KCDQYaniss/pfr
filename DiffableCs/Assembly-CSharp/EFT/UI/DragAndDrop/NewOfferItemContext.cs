namespace EFT.UI.DragAndDrop;

public sealed class NewOfferItemContext : ItemContext
{
	[CompilerGenerated]
	private readonly RagfairNewOfferContext <OfferContext>k__BackingField; //Field offset: 0x68

	public RagfairNewOfferContext OfferContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NewOfferItemContext(Item item, RagfairNewOfferContext newOfferContext) { }

	private NewOfferItemContext(Item item, NewOfferItemContext source) { }

	public virtual ItemContext CreateChild(Item item) { }

	[CompilerGenerated]
	public RagfairNewOfferContext get_OfferContext() { }

}

