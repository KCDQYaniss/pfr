namespace EFT;

public sealed class TradeOperationResult
{
	internal class Sum
	{
		public int sell; //Field offset: 0x10
		public int buy; //Field offset: 0x14
		public int sell_with_comm; //Field offset: 0x18
		public int buy_with_comm; //Field offset: 0x1C

		public Sum() { }

	}

	public int code; //Field offset: 0x10
	public Sum sum; //Field offset: 0x18
	public int calc; //Field offset: 0x20
	public string type; //Field offset: 0x28

	public TradeOperationResult() { }

}

