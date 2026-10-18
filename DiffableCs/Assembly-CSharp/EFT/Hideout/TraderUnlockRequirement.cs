namespace EFT.Hideout;

public sealed class TraderUnlockRequirement : TraderRequirement
{
	[JsonProperty("traderId")]
	public string TraderId; //Field offset: 0x40

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public TraderUnlockRequirement() { }

	[CompilerGenerated]
	private bool <Test>b__3_0(TraderInfo traderInfo) { }

	public virtual ERequirementType get_Type() { }

	public virtual void Test(IEnumerable value) { }

}

