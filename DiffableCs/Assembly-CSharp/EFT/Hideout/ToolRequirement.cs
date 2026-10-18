namespace EFT.Hideout;

public sealed class ToolRequirement : ItemRequirement
{

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public ToolRequirement() { }

	public virtual ERequirementType get_Type() { }

}

