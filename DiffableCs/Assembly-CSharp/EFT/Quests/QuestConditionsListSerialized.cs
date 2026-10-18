namespace EFT.Quests;

public sealed class QuestConditionsListSerialized : Dictionary, ISerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8
		public static Func <>9__1_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal EQuestStatus <Serialize>b__1_0(KeyValuePair x) { }

		internal ConditionCollection <Serialize>b__1_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Condition condition; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <EFT.ISerializer<EFT.Quests.ConditionsDict>.Deserialize>b__0(Condition x) { }

	}


	public QuestConditionsListSerialized() { }

	private override ConditionsDict EFT.ISerializer<EFT.Quests.ConditionsDict>.Deserialize() { }

	public override object Serialize(ConditionsDict t) { }

}

