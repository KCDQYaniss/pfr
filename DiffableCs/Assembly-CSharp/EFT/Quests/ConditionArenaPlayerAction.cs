namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionArenaPlayerAction : Condition, ICanResetConditionProgress
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GenerateFormattedDescription>b__3_0(string a) { }

	}

	public string[] actions; //Field offset: 0xE0

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	public ConditionArenaPlayerAction() { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

}

