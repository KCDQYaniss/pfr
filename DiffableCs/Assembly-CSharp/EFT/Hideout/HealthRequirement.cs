namespace EFT.Hideout;

public sealed class HealthRequirement : Requirement
{
	[JsonProperty("Energy")]
	private int _energyValue; //Field offset: 0x38
	[JsonProperty("Hydration")]
	private int _hydrationValue; //Field offset: 0x3C
	private OfflineHealthController _healthController; //Field offset: 0x40

	public virtual bool Fulfilled
	{
		 get { } //Length: 149
	}

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public HealthRequirement() { }

	public virtual bool get_Fulfilled() { }

	public virtual ERequirementType get_Type() { }

	public void Test(OfflineHealthController healthController) { }

}

