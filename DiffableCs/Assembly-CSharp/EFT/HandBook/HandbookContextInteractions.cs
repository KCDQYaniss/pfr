namespace EFT.HandBook;

public sealed class HandbookContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _interactions; //Field offset: 0x0

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	protected virtual IEnumerable SubInteractions
	{
		 get { } //Length: 78
	}

	private static HandbookContextInteractions() { }

	public HandbookContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext) { }

	public virtual void CreateSubInteractions(EItemInfoButton parentInteraction, ISubInteractionsWrapper subInteractionsWrapper) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

	protected virtual IEnumerable get_SubInteractions() { }

}

