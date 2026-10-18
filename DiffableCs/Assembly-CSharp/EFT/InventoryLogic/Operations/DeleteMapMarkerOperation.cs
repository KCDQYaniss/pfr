namespace EFT.InventoryLogic.Operations;

public sealed class DeleteMapMarkerOperation : AbstractAsyncOperation
{
	internal sealed class DeleteMapMarkerCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("X")]
		public int X; //Field offset: 0x28
		[JsonProperty("Y")]
		public int Y; //Field offset: 0x2C

		public DeleteMapMarkerCommand() { }

	}

	private readonly int _x; //Field offset: 0x68
	private readonly int _y; //Field offset: 0x6C
	private readonly MapComponent _map; //Field offset: 0x70

	internal DeleteMapMarkerOperation(ushort id, ItemController controller, DeleteMapMarkerResult deleteMarkerResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

