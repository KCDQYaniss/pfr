namespace EFT.Hideout;

public sealed class QuestRequirement : Requirement
{
	[JsonProperty("questId")]
	public string QuestId; //Field offset: 0x38

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public QuestRequirement() { }

	public virtual ERequirementType get_Type() { }

	public bool Test(QuestController questController) { }

}

