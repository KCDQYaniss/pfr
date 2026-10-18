namespace EFT.Quests;

public class ConditionHitProgressChecker : ConditionProgressChecker
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public HitConditionCheck test; //Field offset: 0x10
		public Func <>9__4; //Field offset: 0x18
		public Func <>9__5; //Field offset: 0x20
		public Func <>9__6; //Field offset: 0x28
		public Func <>9__7; //Field offset: 0x30

		public <>c__DisplayClass2_0() { }

		internal bool <Test>b__0(string[] list) { }

		internal bool <Test>b__1(string[] list) { }

		internal bool <Test>b__2(string[] list) { }

		internal bool <Test>b__3(string[] list) { }

		internal bool <Test>b__4(string mod) { }

		internal bool <Test>b__5(string mod) { }

		internal bool <Test>b__6(string item) { }

		internal bool <Test>b__7(string item) { }

	}

	public ConditionHit Condition; //Field offset: 0x50

	public ConditionHitProgressChecker(ConditionHit condition) { }

	public virtual bool Test(object testValue) { }

	private bool TimeBetween(TimeSpan now, TimeSpan start, TimeSpan end) { }

}

