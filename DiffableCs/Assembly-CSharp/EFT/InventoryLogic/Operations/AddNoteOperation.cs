namespace EFT.InventoryLogic.Operations;

public sealed class AddNoteOperation : AbstractAsyncOperation
{
	internal sealed class AddNoteCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("note")]
		public Note Note; //Field offset: 0x20

		public AddNoteCommand() { }

	}

	private readonly Note _note; //Field offset: 0x68

	internal AddNoteOperation(ushort id, ItemController controller, AddNoteResult addNoteResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

