namespace EFT.InventoryLogic.Operations;

public sealed class CreateMapMarkerOperation : AbstractAsyncOperation
{
	internal sealed class CreateMapMarkerCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("mapMarker")]
		public MapMarker MapMarker; //Field offset: 0x28

		public CreateMapMarkerCommand() { }

	}

	private readonly MapComponent _map; //Field offset: 0x68
	private readonly MapMarker _marker; //Field offset: 0x70

	internal CreateMapMarkerOperation(ushort id, ItemController controller, CreateMapMarkerResult createMapMarkerResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

