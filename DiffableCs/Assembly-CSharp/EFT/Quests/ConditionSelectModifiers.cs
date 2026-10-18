namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionSelectModifiers : Condition
{
	[JsonProperty("target")]
	private MongoID[] _target; //Field offset: 0xE0

	public IReadOnlyList Target
	{
		 get { } //Length: 8
	}

	public ConditionSelectModifiers() { }

	public IReadOnlyList get_Target() { }

}

