namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionTransitionLocation : Condition
{
	[CompilerGenerated]
	private string[] <MapNames>k__BackingField; //Field offset: 0xE0
	private List _identities; //Field offset: 0xE8

	public virtual string FormattedDescription
	{
		 get { } //Length: 207
	}

	[JsonProperty("target")]
	public private string[] MapNames
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ConditionTransitionLocation() { }

	public virtual string get_FormattedDescription() { }

	[CompilerGenerated]
	public string[] get_MapNames() { }

	public virtual bool HasIdentity(int identity) { }

	[CompilerGenerated]
	private void set_MapNames(string[] value) { }

}

