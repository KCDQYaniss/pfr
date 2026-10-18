//Type is in global namespace

public class SummoningPriestPatrol : SectantSummoningBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindPoint>b__4_0(GroupPoint point) { }

	}

	private CustomNavigationPoint _point; //Field offset: 0x90
	private Nullable _CenterFound; //Field offset: 0x98

	public SummoningPriestPatrol(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

