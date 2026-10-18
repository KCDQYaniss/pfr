namespace EFT.InventoryLogic.Operations;

public sealed class PlantTripwireOperation : AbstractAsyncOperation, ITwoItemOperation, IOneItemOperation, IInventoryOperation
{
	public readonly ThrowWeap Tripwire; //Field offset: 0x68
	[CanBeNull]
	private readonly PlantingKit _plantingKit; //Field offset: 0x70
	private readonly ItemAddress _from1; //Field offset: 0x78
	[CanBeNull]
	private readonly ItemAddress _from2; //Field offset: 0x80
	private readonly IPlayer _player; //Field offset: 0x88
	private readonly Vector3 _fromPosition; //Field offset: 0x90
	private readonly Vector3 _toPosition; //Field offset: 0x9C

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
		private get { } //Length: 3
	}

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.From2
	{
		private get { } //Length: 8
	}

	private override Item EFT.InventoryLogic.Operations.ITwoItemOperation.Item2
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.To2
	{
		private get { } //Length: 3
	}

	public PlantTripwireOperation(ushort id, ItemController controller, PlantTripwireResult plantTripwireResult, Vector3 fromPosition, Vector3 toPosition, IPlayer player) { }

	public virtual void Dispose() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.get_From2() { }

	private override Item EFT.InventoryLogic.Operations.ITwoItemOperation.get_Item2() { }

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.get_To2() { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

