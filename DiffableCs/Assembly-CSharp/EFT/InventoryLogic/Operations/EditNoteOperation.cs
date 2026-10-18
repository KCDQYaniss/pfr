namespace EFT.InventoryLogic.Operations;

public sealed class EditNoteOperation : AbstractAsyncOperation
{
	internal sealed class EditNoteCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("index")]
		public int Index; //Field offset: 0x20
		[JsonProperty("note")]
		public Note Note; //Field offset: 0x28

		public EditNoteCommand() { }

	}

	private readonly int _index; //Field offset: 0x68
	private readonly Note _note; //Field offset: 0x70

	internal EditNoteOperation(ushort id, ItemController controller, EditNoteResult editNoteResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

