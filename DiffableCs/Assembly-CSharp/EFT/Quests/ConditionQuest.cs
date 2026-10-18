namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionQuest : ConditionOneTarget
{
	[JsonProperty("status")]
	public EQuestStatus[] statuses; //Field offset: 0xE8
	[JsonProperty("isFinisher")]
	public bool isFinisher; //Field offset: 0xF0
	public int availableAfter; //Field offset: 0xF4

	public virtual float value
	{
		 get { } //Length: 9
	}

	public ConditionQuest() { }

	public virtual float get_value() { }

	protected virtual List IdentityFields() { }

}

