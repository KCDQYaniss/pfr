//Type is in global namespace

[Obfuscation(Exclude = True)]
public sealed class ConditionHideoutArea : Condition
{
	[JsonProperty("area")]
	public EAreaType Area; //Field offset: 0xE0

	[JsonProperty("areaType")]
	private int _area
	{
		private set { } //Length: 7
	}

	public virtual string FormattedDescription
	{
		 get { } //Length: 340
	}

	public ConditionHideoutArea() { }

	public virtual string get_FormattedDescription() { }

	private void set__area(int value) { }

}

