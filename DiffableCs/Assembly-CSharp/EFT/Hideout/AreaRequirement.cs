namespace EFT.Hideout;

public sealed class AreaRequirement : Requirement
{
	[JsonProperty("areaType")]
	public EAreaType AreaType; //Field offset: 0x38
	[JsonProperty("requiredLevel")]
	public int RequiredLevel; //Field offset: 0x3C
	[CompilerGenerated]
	private AreaData <AreaData>k__BackingField; //Field offset: 0x40

	[JsonIgnore]
	public private AreaData AreaData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual ERequirementType Type
	{
		 get { } //Length: 3
	}

	public AreaRequirement() { }

	[CompilerGenerated]
	public AreaData get_AreaData() { }

	public virtual ERequirementType get_Type() { }

	[CompilerGenerated]
	private void set_AreaData(AreaData value) { }

	public void Test(Dictionary areaData) { }

}

