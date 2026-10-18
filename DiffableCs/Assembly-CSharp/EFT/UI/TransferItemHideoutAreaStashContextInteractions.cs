namespace EFT.UI;

public sealed class TransferItemHideoutAreaStashContextInteractions : BaseItemContextInteractions
{
	private static readonly IEnumerable _areaStashInteractions; //Field offset: 0x0
	private static readonly IEnumerable _areaStashInteractionsWithoutFavorites; //Field offset: 0x8
	private static readonly IEnumerable _inventoryStashInteractions; //Field offset: 0x10
	private readonly bool _canAddToFavorites; //Field offset: 0x60
	private readonly bool _isPlayerStash; //Field offset: 0x61

	protected virtual IEnumerable AvailableInteractions
	{
		 get { } //Length: 183
	}

	private static TransferItemHideoutAreaStashContextInteractions() { }

	public TransferItemHideoutAreaStashContextInteractions(ItemContext itemContext, ItemUiContext itemUiContext, bool isPlayerStash, bool canAddToFavorites, Action closeAction) { }

	protected virtual IEnumerable get_AvailableInteractions() { }

}

