namespace EFT.UI.Ragfair;

public class RagfairContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _interactions; //Field offset: 0x0
	private readonly RagFair _ragfair; //Field offset: 0x60

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	protected virtual IEnumerable SubInteractions
	{
		 get { } //Length: 78
	}

	private static RagfairContextInteractions() { }

	public RagfairContextInteractions(RagFair ragfair, ItemContext itemContext, ItemUiContext itemUiContext, Action onClose) { }

	public virtual void CreateSubInteractions(EItemInfoButton parentInteraction, ISubInteractionsWrapper subInteractionsWrapper) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

	protected virtual IEnumerable get_SubInteractions() { }

	protected virtual void Search(RagfairSearch ragfairSearch) { }

}

