namespace EFT.InventoryLogic;

public sealed class FailedInventoryResult : IResult
{
	private readonly InventoryError _inventoryError; //Field offset: 0x10

	public override string Error
	{
		 get { } //Length: 42
	}

	public override int ErrorCode
	{
		 get { } //Length: 3
	}

	public override bool Failed
	{
		 get { } //Length: 3
	}

	public override bool Succeed
	{
		 get { } //Length: 3
	}

	public FailedInventoryResult(InventoryError error) { }

	public override string get_Error() { }

	public override int get_ErrorCode() { }

	public override bool get_Failed() { }

	public override bool get_Succeed() { }

}

