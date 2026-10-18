namespace EFT.Quests;

public sealed class ConditionEquipmentProgressChecker : ConditionProgressChecker
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Test>b__2_0(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public List playerEquipment; //Field offset: 0x10
		public ConditionEquipmentProgressChecker <>4__this; //Field offset: 0x18
		public IBaseHandbook handbook; //Field offset: 0x20
		public Func <>9__3; //Field offset: 0x28
		public Func <>9__5; //Field offset: 0x30

		public <>c__DisplayClass2_0() { }

		internal bool <Test>b__1(string[] list) { }

		internal bool <Test>b__2(string[] list) { }

		internal bool <Test>b__3(string item) { }

		internal bool <Test>b__5(string item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public string item; //Field offset: 0x10
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass2_1() { }

		internal bool <Test>b__4(string eq) { }

	}

	private readonly ConditionEquipment Condition; //Field offset: 0x50

	public ConditionEquipmentProgressChecker(ConditionEquipment condition) { }

	public virtual bool Test(object testValue) { }

}

