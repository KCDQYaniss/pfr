namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionEquipment : Condition
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_1; //Field offset: 0x8
		public static Func <>9__4_0; //Field offset: 0x10
		public static Func <>9__7_0; //Field offset: 0x18
		public static Func <>9__7_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <get_FormattedDescription>b__7_0(string[] e) { }

		internal string <get_FormattedDescription>b__7_1(string t) { }

		internal bool <get_TargetIsCategory>b__4_0(string[] group) { }

		internal bool <get_TargetIsCategory>b__4_1(string target) { }

	}

	public bool IncludeNotEquippedItems; //Field offset: 0xE0
	public string[][] equipmentInclusive; //Field offset: 0xE8
	public string[][] equipmentExclusive; //Field offset: 0xF0
	private Nullable _targetIsCategory; //Field offset: 0xF8

	public virtual string FormattedDescription
	{
		 get { } //Length: 1176
	}

	public bool TargetIsCategory
	{
		 get { } //Length: 474
	}

	public ConditionEquipment() { }

	public virtual string get_FormattedDescription() { }

	public bool get_TargetIsCategory() { }

}

