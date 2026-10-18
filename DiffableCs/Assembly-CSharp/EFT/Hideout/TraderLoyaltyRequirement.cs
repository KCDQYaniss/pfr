namespace EFT.Hideout;

public sealed class TraderLoyaltyRequirement : TraderRequirement
{
	[JsonProperty("loyaltyLevel")]
	public int LoyaltyLevel; //Field offset: 0x40
	[JsonProperty("traderId")]
	public string TraderId; //Field offset: 0x48

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public TraderLoyaltyRequirement() { }

	[CompilerGenerated]
	private bool <Test>b__4_0(TraderInfo traderInfo) { }

	public virtual ERequirementType get_Type() { }

	public virtual void Test(IEnumerable value) { }

}

