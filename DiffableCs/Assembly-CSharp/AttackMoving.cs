//Type is in global namespace

public class AttackMoving : MoveNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__12_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <UpdateNodeByBrain>b__12_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public AttackMoving <>4__this; //Field offset: 0x10
		public float recalcTime; //Field offset: 0x18
		public bool withShoot; //Field offset: 0x1C

		public <>c__DisplayClass12_0() { }

		internal void <UpdateNodeByBrain>b__0(CustomNavigationPoint navigationPoint) { }

	}

	public float DangerTime; //Field offset: 0x28
	protected readonly Aiming _aiming; //Field offset: 0x30
	private readonly BifacialTransform _ownerTransform; //Field offset: 0x38
	private readonly BifacialTransform _ownerWeaponRoot; //Field offset: 0x40
	private float _lastRecalcTime; //Field offset: 0x48
	private int _cantAttackTimes; //Field offset: 0x4C
	private Vector3 _goDirection; //Field offset: 0x50
	private float _updatePointTimer; //Field offset: 0x5C
	private float _nextCoverCheck; //Field offset: 0x60

	public float LOOK_TO_ENEMY_IF_SEEN
	{
		 get { } //Length: 58
	}

	public AttackMoving(BotOwner bot) { }

	protected override void AimingAndShoot(CoreActionResultParams data) { }

	public float get_LOOK_TO_ENEMY_IF_SEEN() { }

	protected override Aiming GetAiming(BotOwner bot) { }

	protected void RestartFindTime() { }

	public virtual void UpdateNodeByBrain(CoreActionResultParams data) { }

	protected override bool UseSenseEnemyPositionOnCoverSearch() { }

}

