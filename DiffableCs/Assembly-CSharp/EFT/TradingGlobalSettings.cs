namespace EFT;

public sealed class TradingGlobalSettings
{
	internal sealed class BuyRestrictionMaxBonusConfig
	{
		public float multiplier; //Field offset: 0x10

		public BuyRestrictionMaxBonusConfig() { }

	}

	public BuyoutRestrictions BuyoutRestrictions; //Field offset: 0x10
	public Dictionary BuyRestrictionMaxBonus; //Field offset: 0x18

	public TradingGlobalSettings() { }

}

