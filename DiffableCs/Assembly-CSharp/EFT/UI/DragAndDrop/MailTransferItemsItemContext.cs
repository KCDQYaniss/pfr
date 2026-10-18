namespace EFT.UI.DragAndDrop;

public sealed class MailTransferItemsItemContext : ItemContext
{
	private readonly IReadOnlyDictionary _itemExpirationTimeDict; //Field offset: 0x68

	public MailTransferItemsItemContext(IReadOnlyDictionary itemExpirationTimeDict, Item item, EItemViewType viewType) { }

	private MailTransferItemsItemContext(Item item, MailTransferItemsItemContext sourceContext) { }

	public virtual ItemContext CreateChild(Item item) { }

	public bool TryGetExpirationTime(Item item, out TimeSpan time) { }

}

