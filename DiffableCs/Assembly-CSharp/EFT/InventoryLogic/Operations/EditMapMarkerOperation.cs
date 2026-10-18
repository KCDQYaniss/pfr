namespace EFT.InventoryLogic.Operations;

public sealed class EditMapMarkerOperation : AbstractAsyncOperation
{
	internal sealed class EditMapMarkerCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("X")]
		public int X; //Field offset: 0x28
		[JsonProperty("Y")]
		public int Y; //Field offset: 0x2C
		[JsonProperty("mapMarker")]
		public MapMarker MapMarker; //Field offset: 0x30

		public EditMapMarkerCommand() { }

	}

	private readonly int _x; //Field offset: 0x68
	private readonly int _y; //Field offset: 0x6C
	private readonly MapComponent _map; //Field offset: 0x70
	private readonly MapMarker _marker; //Field offset: 0x78

	internal EditMapMarkerOperation(ushort id, ItemController controller, EditMapMarkerResult editMarkerResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

