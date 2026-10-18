namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionGlobalVariableValue : ConditionOneTarget
{
	[CompilerGenerated]
	private bool <ShowCounter>k__BackingField; //Field offset: 0xE8

	public virtual string FormattedDescription
	{
		 get { } //Length: 372
	}

	public virtual bool HiddenByDefault
	{
		 get { } //Length: 3
	}

	[JsonProperty("showCounter")]
	public private bool ShowCounter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ConditionGlobalVariableValue() { }

	public virtual string get_FormattedDescription() { }

	public virtual bool get_HiddenByDefault() { }

	[CompilerGenerated]
	public bool get_ShowCounter() { }

	[CompilerGenerated]
	private void set_ShowCounter(bool value) { }

}

