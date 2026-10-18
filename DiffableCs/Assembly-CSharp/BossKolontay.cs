//Type is in global namespace

public class BossKolontay : ABossLogic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__26_0(AIPlaceInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public BossKolontay <>4__this; //Field offset: 0x10
		public List possibleAreas; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal Vector3 <.ctor>b__1(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public BotOwner bot; //Field offset: 0x10
		public BossKolontay <>4__this; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal void <OnGoalEnemyChanged>b__0() { }

	}

	private const float SDIST_TO_CALL = 10000; //Field offset: 0x0
	public bool _secutiryMovingClose; //Field offset: 0x20
	private Vector3 _offset; //Field offset: 0x24
	[CompilerGenerated]
	private Action OnPatrolChanged; //Field offset: 0x30
	[CompilerGenerated]
	private bool <AssaultCanKill>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private PatrolPointContainer <LastPatrol>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable <AreaId>k__BackingField; //Field offset: 0x48
	private float _nextPossibleChangeTactics; //Field offset: 0x50
	private float _nextCallTime; //Field offset: 0x54
	private bool _assaultDoProtect; //Field offset: 0x58

	public event Action OnPatrolChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private Nullable AreaId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool AssaultCanKill
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float DistanceToEnemy
	{
		 get { } //Length: 72
	}

	public private PatrolPointContainer LastPatrol
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool SecutiryMovingClose
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public BossKolontay(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnPatrolChanged(Action value) { }

	public virtual void BossLogicUpdate() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public Nullable get_AreaId() { }

	[CompilerGenerated]
	public bool get_AssaultCanKill() { }

	public float get_DistanceToEnemy() { }

	[CompilerGenerated]
	public PatrolPointContainer get_LastPatrol() { }

	public bool get_SecutiryMovingClose() { }

	public Vector3 GetOffset() { }

	public void MyAssaultCheckProtect(bool protectBoss) { }

	private void OnEnemyHitted(BotOwner arg1, Player person) { }

	private void OnGetHit(DamageInfo info, EBodyPart arg2, float arg3) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnTargetPatrolPointSetted(PatrolPointContainer point) { }

	[CompilerGenerated]
	public void remove_OnPatrolChanged(Action value) { }

	[CompilerGenerated]
	private void set_AreaId(Nullable value) { }

	[CompilerGenerated]
	public void set_AssaultCanKill(bool value) { }

	[CompilerGenerated]
	private void set_LastPatrol(PatrolPointContainer value) { }

	public void set_SecutiryMovingClose(bool value) { }

	public virtual void SetPatrolMode() { }

}

