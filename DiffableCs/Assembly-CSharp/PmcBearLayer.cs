//Type is in global namespace

public class PmcBearLayer : BaseLogicLayer
{
	protected const float _checkStatusPeriod = 1; //Field offset: 0x0
	protected const float DistToEnemyToCanRun = 10; //Field offset: 0x0
	protected float sDistToCloseToBoss; //Field offset: 0x90
	protected float distToPointCloseToBoss; //Field offset: 0x94
	protected float _nextCanCheckCoversNearBoss; //Field offset: 0x98
	protected bool _haveCoverNearBoss; //Field offset: 0x9C
	protected bool erorrLoged; //Field offset: 0x9D
	private Vector3 _sampled; //Field offset: 0xA0
	private CustomNavigationPoint _coverNearBoss; //Field offset: 0xB0
	private readonly BotFollower _botFollower; //Field offset: 0xB8
	private float _nextTimeCheckCover; //Field offset: 0xC0
	private float _lastEndGoToPoint; //Field offset: 0xC4
	[CompilerGenerated]
	private bool <HaveCoverToShoot>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private CustomNavigationPoint <PointToShoot>k__BackingField; //Field offset: 0xD0

	public private bool HaveCoverToShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private CustomNavigationPoint PointToShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PmcBearLayer(BotOwner bot, int priority) { }

	protected bool CanShootAndVisible() { }

	protected void CheckCoversNearBoss() { }

	protected void CheckEnemyStatus() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public CustomNavigationPoint FollowerCheckData() { }

	[CompilerGenerated]
	public bool get_HaveCoverToShoot() { }

	[CompilerGenerated]
	public CustomNavigationPoint get_PointToShoot() { }

	protected Vector3 GetBossPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	private BotLogicDecision GoNearBoss() { }

	private float LastSeenTime() { }

	public virtual string Name() { }

	protected override bool ProtectCareKill() { }

	protected override bool ProtectWantKill() { }

	[CompilerGenerated]
	private void set_HaveCoverToShoot(bool value) { }

	[CompilerGenerated]
	private void set_PointToShoot(CustomNavigationPoint value) { }

	public virtual bool ShallUseNow() { }

	private AICoreActionEnd SubEndGoToPoint() { }

}

