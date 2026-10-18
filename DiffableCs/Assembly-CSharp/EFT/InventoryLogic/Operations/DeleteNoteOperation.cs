namespace EFT.InventoryLogic.Operations;

public sealed class DeleteNoteOperation : AbstractAsyncOperation
{
	internal sealed class DeleteNoteCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("index")]
		public int Index; //Field offset: 0x20

		public DeleteNoteCommand() { }

	}

	private readonly int _index; //Field offset: 0x68

	internal DeleteNoteOperation(ushort id, ItemController controller, DeleteNoteResult deleteNoteResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

