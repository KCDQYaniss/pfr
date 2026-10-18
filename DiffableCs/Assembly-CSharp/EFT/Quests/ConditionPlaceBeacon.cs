namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionPlaceBeacon : ConditionZone
{
	public float plantTime; //Field offset: 0xF0

	public virtual string FormattedDescription
	{
		 get { } //Length: 197
	}

	public ConditionPlaceBeacon() { }

	public virtual string get_FormattedDescription() { }

}

