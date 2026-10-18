namespace EFT.InventoryLogic;

public sealed class AddSuboperation : IOneItemOperation, IInventoryOperation, ISubOperation
{
	private readonly Item _item; //Field offset: 0x10
	private readonly ItemAddress _to; //Field offset: 0x18
	private readonly IInventoryOperation _baseInventoryOperation; //Field offset: 0x20

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 3
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 5
	}

	private override IInventoryOperation EFT.InventoryLogic.Operations.ISubOperation.BaseInventoryOperation
	{
		private get { } //Length: 5
	}

	public AddSuboperation(Item item, ItemAddress to, IInventoryOperation baseInventoryOperation) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	private override IInventoryOperation EFT.InventoryLogic.Operations.ISubOperation.get_BaseInventoryOperation() { }

}

