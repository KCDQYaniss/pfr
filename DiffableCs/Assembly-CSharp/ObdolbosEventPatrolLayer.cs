//Type is in global namespace

public class ObdolbosEventPatrolLayer : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindPoint>b__8_0(GroupPoint point) { }

	}

	private bool _canChange; //Field offset: 0x90
	private CustomNavigationPoint _cachePoint; //Field offset: 0x98
	private CustomNavigationPoint _point; //Field offset: 0xA0
	private AICorePoint _lastCore; //Field offset: 0xA8

	public ObdolbosEventPatrolLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnInCoverChange(bool obj, CustomNavigationPoint arg2) { }

	public virtual bool ShallUseNow() { }

}

