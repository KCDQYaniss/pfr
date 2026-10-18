namespace EFT.InventoryLogic.Operations;

public sealed class HealOperation : AbstractOperation
{
	internal sealed class HealCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("item")]
		public string Item; //Field offset: 0x28
		[JsonProperty("part")]
		public EBodyPart Part; //Field offset: 0x30
		[JsonProperty("count")]
		public int Count; //Field offset: 0x34
		[JsonProperty("time")]
		public int Time; //Field offset: 0x38

		public HealCommand() { }

	}

	private readonly Item _item; //Field offset: 0x40
	private readonly EBodyPart _bodyPart; //Field offset: 0x48
	private readonly int _count; //Field offset: 0x4C

	internal HealOperation(ushort id, ItemController controller, Item item, EBodyPart bodyPart, int count) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

