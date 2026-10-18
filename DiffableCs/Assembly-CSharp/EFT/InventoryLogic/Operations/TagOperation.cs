namespace EFT.InventoryLogic.Operations;

public sealed class TagOperation : AbstractAsyncOperation
{
	internal sealed class TagCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("TagName")]
		public string TagName; //Field offset: 0x28
		[JsonProperty("TagColor")]
		public int TagColor; //Field offset: 0x30

		public TagCommand() { }

	}

	private readonly TagComponent _tag; //Field offset: 0x68
	private readonly string _name; //Field offset: 0x70
	private readonly int _color; //Field offset: 0x78

	public TagOperation(ushort id, ItemController controller, SetTagResult tagResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

