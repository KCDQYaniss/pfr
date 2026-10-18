namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionArenaRoundResult : Condition, ICanResetConditionProgress
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GenerateFormattedDescription>b__5_1(string r) { }

	}

	public string[] resultType; //Field offset: 0xE0
	public string[] roundEndType; //Field offset: 0xE8
	public string[] state; //Field offset: 0xF0

	public virtual string FormattedDescription
	{
		 get { } //Length: 18
	}

	public ConditionArenaRoundResult() { }

	[CompilerGenerated]
	private string <GenerateFormattedDescription>b__5_0(string r) { }

	private string GenerateFormattedDescription() { }

	public virtual string get_FormattedDescription() { }

}

