namespace EFT.UI;

public sealed class TransferItemPlayerContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _interactions; //Field offset: 0x0

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 83
	}

	private static TransferItemPlayerContextInteractions() { }

	public TransferItemPlayerContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction) { }

	protected virtual void ExecuteInteractionInternal(EItemInfoButton interaction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

}

