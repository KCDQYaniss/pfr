namespace EFT.InventoryLogic.Operations;

public class ToggleOperation : AbstractAsyncOperation, IOneItemOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	internal sealed class ToggleCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("value")]
		public bool Value; //Field offset: 0x28

		public ToggleCommand() { }

	}

	protected const int NVG_ON_ID = 20; //Field offset: 0x0
	protected const int FACESHIELD_ON_ID = 400; //Field offset: 0x0
	protected readonly TogglableComponent Togglable; //Field offset: 0x68
	private readonly ItemAddress _from; //Field offset: 0x70
	private readonly Item _item; //Field offset: 0x78
	private readonly bool _newValue; //Field offset: 0x80

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 5
	}

	internal ToggleOperation(ushort id, ItemController controller, ToggleResult toggleResult) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

