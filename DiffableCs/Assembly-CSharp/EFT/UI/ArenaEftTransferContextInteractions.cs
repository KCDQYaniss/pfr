namespace EFT.UI;

public sealed class ArenaEftTransferContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _interactionsIdle; //Field offset: 0x0
	private static readonly IEnumerable _interactionsSelected; //Field offset: 0x8
	private readonly bool _isSelected; //Field offset: 0x60

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 136
	}

	private static ArenaEftTransferContextInteractions() { }

	public ArenaEftTransferContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, Action closeAction, bool isSelected) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

}

