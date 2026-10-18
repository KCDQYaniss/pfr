//Type is in global namespace

public class FollowerKolontaySecurityPatrol : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public FollowerKolontaySecurityPatrol <>4__this; //Field offset: 0x10
		public Nullable otherTrg; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal bool <RecheckCoverAtMiddle>b__0(GroupPoint point) { }

	}

	private readonly bool _secutiry; //Field offset: 0x90
	private Vector3 _offset; //Field offset: 0x94
	private readonly BossFinder _boss; //Field offset: 0xA0
	private PatrolPointContainer _bossPatrolPoint; //Field offset: 0xA8
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xB0
	private float _nextCheckCoverInMiddle; //Field offset: 0xB8
	private float _offsetDist; //Field offset: 0xBC
	private float SDIST_OFFSET; //Field offset: 0xC0

	public FollowerKolontaySecurityPatrol(BotOwner bot, int priority, bool secutiry) { }

	[CompilerGenerated]
	private void <OnFinded>b__16_0() { }

	private Vector3 CenterFindCoverPos() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void OnBossPatrolChanged(PatrolPointContainer obj) { }

	private void OnFinded() { }

	protected void RecheckCoverAtMiddle(PatrolPointContainer obj) { }

	protected CoverSearchData RecheckCoverData(PatrolPointContainer obj) { }

	public virtual bool ShallUseNow() { }

}

