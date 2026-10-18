//Type is in global namespace

public class BossDecider : ABossLogic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__14_0; //Field offset: 0x10
		public static Func <>9__14_1; //Field offset: 0x18
		public static Func <>9__14_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal float <GetPlacesForCheck>b__14_0(BotGroupEnemyInfo x) { }

		internal bool <GetPlacesForCheck>b__14_1(PlaceForCheck x) { }

		internal float <GetPlacesForCheck>b__14_2(PlaceForCheck x) { }

		internal bool <SendToAttackFollowers>b__11_0(IBotOwner x) { }

	}

	private float _nextSendToSearch; //Field offset: 0x20
	private float _logicUpdate; //Field offset: 0x24
	private bool _canSendAttack; //Field offset: 0x28
	private int RemainCheckcers; //Field offset: 0x2C
	private int _killedFollowers; //Field offset: 0x30

	public BossDecider(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	private void Check() { }

	public virtual void Dispose() { }

	private void DisposeComplete() { }

	private void FollowComplete() { }

	private List GetPlacesForCheck(int needElements) { }

	private bool IsAllInCovers() { }

	private void OnFollowerStatusChange(IBotOwner arg1, FollowerStatusChange status) { }

	private void SendToAttackFollowers() { }

	public virtual void SetPatrolMode() { }

}

