namespace EFT.Hideout;

public abstract class TraderRequirement : Requirement
{
	[CompilerGenerated]
	private TraderInfo <Trader>k__BackingField; //Field offset: 0x38

	[JsonIgnore]
	public TraderInfo Trader
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected TraderRequirement() { }

	[CompilerGenerated]
	public TraderInfo get_Trader() { }

	[CompilerGenerated]
	protected void set_Trader(TraderInfo value) { }

	public abstract void Test(IEnumerable tradersList) { }

}

