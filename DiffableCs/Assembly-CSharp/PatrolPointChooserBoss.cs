//Type is in global namespace

public class PatrolPointChooserBoss : PatrolPointChooserBasic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_2; //Field offset: 0x8
		public static Func <>9__2_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <TryToFindWay>b__2_0(PatrolWay x) { }

		internal bool <TryToFindWay>b__2_2(PatrolWay x) { }

	}


	public PatrolPointChooserBoss(BotOwner owner) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__2_1(PatrolWay x) { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

