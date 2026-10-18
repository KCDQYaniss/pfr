namespace EFT.Trading;

public static class PriceCalculator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Item item; //Field offset: 0x10
		public int itemsCount; //Field offset: 0x18
		public IBasePriceSource basePriceSource; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal double <CalculateBaseTaxesAllItems>b__0(Item subItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <CalculateBasePriceForAllItems>b__0(Item subItem) { }

	}

	private const double LOG_POW_BASE = 4; //Field offset: 0x0
	private const double PRICE_MODIFIER = 1.08; //Field offset: 0x0
	private const double RESOURCE_ITEM_TAX_FIRST_COEFFICIENT = 0.1; //Field offset: 0x0
	private const double RESOURCE_ITEM_TAX_SECOND_COEFFICIENT = 0.9; //Field offset: 0x0
	private const double ZERO_DURABILITY_COEFFICIENT = 0.01; //Field offset: 0x0
	private const double TEAMMATE_DOGTAG_PRICE = 1; //Field offset: 0x0
	private static readonly List _tempItemsList; //Field offset: 0x0

	private static PriceCalculator() { }

	public static double ApplyCustomPriceIfNeeded(Item item, double currentPrice) { }

	public static double CalculateBasePriceForAllItems(Item item, int itemsCount, IBasePriceSource basePriceSource, bool isFence) { }

	private static double CalculateBasePriceForSingleItem(Item item, int itemsCount, IBasePriceSource basePriceSource) { }

	public static double CalculateBaseTaxesAllItems(Item item, int itemsCount, IBasePriceSource basePriceSource) { }

	public static double CalculateBuyoutBasePriceForSingleItem(Item item, int itemsCount, IBasePriceSource basePriceSource, bool isFence) { }

	public static double CalculateTaxPrice(Item item, int offerItemCount, double requirementsPrice, bool sellInOnePiece) { }

}

