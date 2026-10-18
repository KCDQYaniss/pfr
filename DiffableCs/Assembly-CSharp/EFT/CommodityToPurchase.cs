namespace EFT;

public sealed class CommodityToPurchase
{
	public readonly IExchangeable Exchangeable; //Field offset: 0x10
	public readonly int Count; //Field offset: 0x18
	public readonly List Items; //Field offset: 0x20

	public CommodityToPurchase(IExchangeable exchangeable, int count, List items) { }

	public CommodityToPurchase Copy() { }

}

