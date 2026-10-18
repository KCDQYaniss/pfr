namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public class ConditionFindItem : ConditionItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__11_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <get_FormattedDescription>b__11_0(string t) { }

		internal bool <get_TargetIsCategory>b__8_0(string t) { }

	}

	public bool countInRaid; //Field offset: 0xF8
	private Nullable _targetIsCategory; //Field offset: 0xF9

	public virtual string FormattedDescription
	{
		 get { } //Length: 705
	}

	public virtual bool ResetOnSessionEnd
	{
		 get { } //Length: 3
	}

	[JsonIgnore]
	public virtual bool Reversible
	{
		 get { } //Length: 3
	}

	[JsonIgnore]
	public virtual bool SaveCompletionOnBacked
	{
		 get { } //Length: 3
	}

	public bool TargetIsCategory
	{
		 get { } //Length: 474
	}

	public ConditionFindItem() { }

	public virtual string get_FormattedDescription() { }

	public virtual bool get_ResetOnSessionEnd() { }

	public virtual bool get_Reversible() { }

	public virtual bool get_SaveCompletionOnBacked() { }

	public bool get_TargetIsCategory() { }

}

