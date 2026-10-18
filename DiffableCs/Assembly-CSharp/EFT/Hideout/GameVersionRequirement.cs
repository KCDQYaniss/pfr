namespace EFT.Hideout;

public sealed class GameVersionRequirement : Requirement
{
	[JsonProperty("GameVersions")]
	public string[] GameVersions; //Field offset: 0x38

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public GameVersionRequirement() { }

	public virtual ERequirementType get_Type() { }

}

