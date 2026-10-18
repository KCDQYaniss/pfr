namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public class ConditionLaunchFlare : Condition
{
	[JsonProperty("target")]
	public string zoneID; //Field offset: 0xE0

	public virtual float value
	{
		 get { } //Length: 9
	}

	public ConditionLaunchFlare() { }

	public virtual float get_value() { }

}

