//Type is in global namespace

public class SectantSupSootLayer : AbstractSectantLayerFight
{
	public const float DIST_CHANGE_TO_MEELE_FROM_FIRE = 5; //Field offset: 0x0
	public const float PERIOD_SEEN_TOATTACK = 4; //Field offset: 0x0
	private const string _nameIn = "SupShootSect_IN"; //Field offset: 0x0
	private const string _nameOut = "SupShootSect_OUT"; //Field offset: 0x0
	private const float DistToEnemyToCanRun = 30; //Field offset: 0x0
	private BossSectantPriest _bossSectant; //Field offset: 0x90
	private float _nextTimeCheckCover; //Field offset: 0x98
	private float _posibleStart; //Field offset: 0x9C
	private bool _canShoot; //Field offset: 0xA0
	private bool _isInside; //Field offset: 0xA1
	private string _name; //Field offset: 0xA8
	private Vector3 _corePoint; //Field offset: 0xB0
	private readonly SectantWarriorLayersStrategy _strategy; //Field offset: 0xC0
	private readonly bool withDistCheckShoot; //Field offset: 0xC8
	[CompilerGenerated]
	private CustomNavigationPoint <PointToShoot>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <HaveCoverToShoot>k__BackingField; //Field offset: 0xD8

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

	public SectantSupSootLayer(BotOwner bot, int priority, SectantWarriorLayersStrategy strategy) { }

	protected void CheckEnemyStatus() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	private Vector3 FindPosToStart(EnemyInfo enemy) { }

	public CustomNavigationPoint FollowerCheckData() { }

	[CompilerGenerated]
	public bool get_HaveCoverToShoot() { }

	[CompilerGenerated]
	public CustomNavigationPoint get_PointToShoot() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private bool ReadyToFight() { }

	[CompilerGenerated]
	private void set_HaveCoverToShoot(bool value) { }

	[CompilerGenerated]
	private void set_PointToShoot(CustomNavigationPoint value) { }

	public void SetBoss(BossSectantPriest sectantPriest) { }

	public void SetCorePosition(Vector3 corePoint) { }

	public void SetDelay(float delay) { }

	public void SetInside(bool isInside) { }

	public virtual bool ShallUseNow() { }

}

