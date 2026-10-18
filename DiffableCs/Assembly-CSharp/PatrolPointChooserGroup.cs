//Type is in global namespace

public class PatrolPointChooserGroup : PatrolPointChooserBasic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_2; //Field offset: 0x8
		public static Func <>9__5_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <TryToFindWay>b__5_0(PatrolWay x) { }

		internal bool <TryToFindWay>b__5_2(PatrolWay x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public PatrolPointChooserGroup <>4__this; //Field offset: 0x10
		public int minSubTargets; //Field offset: 0x18
		public PatrolPointFilterDelegate pointFilter; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal bool <FindNextPoint>b__0(PatrolPoint point) { }

	}

	private float _minPointsDist; //Field offset: 0x28
	private float _maxPointsDist; //Field offset: 0x2C

	public PatrolPointChooserGroup(BotOwner owner) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__5_1(PatrolWay x) { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	private List GetFilteredPoints(List points) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

