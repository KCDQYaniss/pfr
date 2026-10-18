namespace EFT.InventoryLogic.Operations;

public sealed class EatOperation : AbstractOperation
{
	internal sealed class EatCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("item")]
		public string Item; //Field offset: 0x28
		[JsonProperty("count")]
		public int Count; //Field offset: 0x30
		[JsonProperty("time")]
		public int Time; //Field offset: 0x34

		public EatCommand() { }

	}

	private readonly Item _item; //Field offset: 0x40
	private readonly int _count; //Field offset: 0x48

	internal EatOperation(ushort id, ItemController controller, Item item, int count) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

