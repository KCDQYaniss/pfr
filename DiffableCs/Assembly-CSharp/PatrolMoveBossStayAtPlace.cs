//Type is in global namespace

public class PatrolMoveBossStayAtPlace : PatrolMoveSimple
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__6_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Update>b__6_1() { }

	}

	private const float DIST_TO_SLOW = 4; //Field offset: 0x0
	private float _nextTimeRefreshCover; //Field offset: 0x30
	private readonly IPatrolMoveBossStayAtPlace _patrolMoveStay; //Field offset: 0x38
	private CustomNavigationPoint _point; //Field offset: 0x40

	public PatrolMoveBossStayAtPlace(BotOwner owner, PatrollingData data, IPatrolMoveBossStayAtPlace bossLogic) { }

	[CompilerGenerated]
	private void <Update>b__6_0(CustomNavigationPoint point) { }

	private void AddBot(IBotOwner bot) { }

	public virtual void Dispose() { }

	public virtual void DrawGizmosSelected() { }

	public Vector3 GetLookToPoint() { }

	private void OnFollowerStatusChange(IBotOwner bot, FollowerStatusChange status) { }

	private void OnPositionsRecalculated() { }

	public virtual void Update() { }

}

