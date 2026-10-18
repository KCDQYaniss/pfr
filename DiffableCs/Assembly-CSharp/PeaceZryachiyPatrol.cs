//Type is in global namespace

public class PeaceZryachiyPatrol : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindPoint>b__5_0(GroupPoint point) { }

	}

	private CustomNavigationPoint _point; //Field offset: 0x90
	private AICorePoint _lastCore; //Field offset: 0x98
	private float _nextTryToDrop; //Field offset: 0xA0

	public PeaceZryachiyPatrol(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected bool ProcessHoldByTime() { }

	public virtual bool ShallUseNow() { }

}

