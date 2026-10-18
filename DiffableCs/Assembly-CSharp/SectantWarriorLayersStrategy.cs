//Type is in global namespace

public class SectantWarriorLayersStrategy : SectantCoreLayersStrategy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__27_0() { }

	}

	private const int MELEE_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int RUN_STRIKE_LOGIC = 6; //Field offset: 0x0
	private const int LEAVE_LAYER = 7; //Field offset: 0x0
	private const int SUP_LOGIC = 8; //Field offset: 0x0
	private const int PATROL_UTILITY = 9; //Field offset: 0x0
	private const int KILLA_LOGIC = 10; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const float RUN_STRIKE_PERIOD = 30; //Field offset: 0x0
	private readonly PatrolStayAtPositionLayerWithIndoor _patrolLogic; //Field offset: 0x58
	private readonly SectantMeleeLayer _sectantMeleeLayer; //Field offset: 0x60
	private readonly SectantRunAndStrikeLayer _runStrikeLogic; //Field offset: 0x68
	private readonly SectantSupSootLayer _supShoot; //Field offset: 0x70
	private float _nextCheckIsInside; //Field offset: 0x78
	private float _returnToSupShoot; //Field offset: 0x7C
	private bool _shallReturn; //Field offset: 0x80
	private BossSectantPriest _sectantBossData; //Field offset: 0x88
	private float _nextPosibleStrategyChange; //Field offset: 0x90
	private float _shootAndHideActivated; //Field offset: 0x94
	private readonly LeaveMapLayer _leave; //Field offset: 0x98
	private bool _isInside; //Field offset: 0xA0
	private BotLighthouseKeeperFriendlySectantsLogic _lighthouseKeeperFriendlySectantsLogic; //Field offset: 0xA8

	public virtual BotOwner Bot
	{
		 get { } //Length: 5
	}

	public SectantWarriorLayersStrategy(BotOwner owner) { }

	private void AcivateShootAndRun() { }

	private void AcivateSupportShoot() { }

	public void ActivateMelee() { }

	private void BossDied(EDamageType obj) { }

	private void BossLeave(BotOwner obj) { }

	public bool CanRunToEnemyWithShortPath() { }

	protected void CheckIsInside() { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual BotOwner get_Bot() { }

	public virtual bool IsCurShootAndRun() { }

	public virtual void ManualUpdate() { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnPeaceChange(bool isPeace) { }

	private void OnSpottedByHit(Nullable obj) { }

	private void OnTriggerPressed() { }

	public void ReturnToSupportShoot(float secPeriod) { }

	public virtual void SetAttackWithDelay(float delay) { }

	public virtual void SetBoss(BossSectantPriest sectantPriest) { }

	public virtual void SetCorePosition(Vector3 pos) { }

	public virtual string ShortName() { }

	public void Subscribe() { }

	private void TryActivateShootANdRun() { }

	private bool TryChangeStrategy(Action changeAction) { }

	public virtual bool TryChangeToMelee() { }

}

