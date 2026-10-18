//Type is in global namespace

public class BoarClosePatrolLayer : BoarAbstractPatrolLayer
{
	protected readonly float CLOSE_MIN_DIST_RND_BOSS; //Field offset: 0xF0
	protected readonly float CLOSE_MAX_DIST_RND_BOSS; //Field offset: 0xF4
	protected readonly float SDIST_TO_BOSS_NORMAL; //Field offset: 0xF8
	private float _nextCheckOnBoss; //Field offset: 0xFC

	public BoarClosePatrolLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <TryFindInPreCache>b__8_0(GroupPoint point) { }

	[CompilerGenerated]
	private bool <TryFindInPreCache>b__8_1(GroupPoint point) { }

	[CompilerGenerated]
	private bool <TryFindInPreCache>b__8_2(GroupPoint x) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	private bool TryFindInPreCache(out CustomNavigationPoint customNavigationPoint) { }

}

