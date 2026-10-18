namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionPrestigeLevel : Condition
{
	[CompilerGenerated]
	private EGameMode <GameMode>k__BackingField; //Field offset: 0xE0

	public virtual string FormattedDescription
	{
		 get { } //Length: 183
	}

	[JsonProperty("gameMode")]
	public private EGameMode GameMode
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ConditionPrestigeLevel() { }

	public virtual string get_FormattedDescription() { }

	[CompilerGenerated]
	public EGameMode get_GameMode() { }

	[CompilerGenerated]
	private void set_GameMode(EGameMode value) { }

}

