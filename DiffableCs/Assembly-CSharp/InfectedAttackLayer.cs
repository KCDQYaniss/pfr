//Type is in global namespace

public class InfectedAttackLayer : BaseLogicLayer
{
	internal enum EZombieMode
	{
		Slow = 1,
		Fast = 2,
		Shooting = 3,
	}

	private const float MELEE_ATTACK_DIST = 4; //Field offset: 0x0
	private const float ENEMY_REPORT_PERIOD = 10; //Field offset: 0x0
	public const float MIN_TALK_DELAY = 1; //Field offset: 0x0
	public const float MAX_TALK_DELAY = 3; //Field offset: 0x0
	private float _talk; //Field offset: 0x90
	private EZombieMode _currentZombieMode; //Field offset: 0x94
	private float _holdAfterMeleeAttackStop; //Field offset: 0x98
	private float _meleeAttackStop; //Field offset: 0x9C
	private float _startMelee; //Field offset: 0xA0
	private float _lastEnemyReportTime; //Field offset: 0xA4
	private float _waitFor; //Field offset: 0xA8
	private float _callTime; //Field offset: 0xAC

	public EZombieMode CurrentZombieMode
	{
		 get { } //Length: 7
	}

	public InfectedAttackLayer(BotOwner bot, int priority) { }

	public void Call() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemyZigZag() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemyZigZag() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public EZombieMode get_CurrentZombieMode() { }

	public virtual AICoreActionResult GetDecision() { }

	private AICoreActionResult GetFastMeleeZombieDecision() { }

	private AICoreActionResult GetSlowMeleeZombieDecision() { }

	private AICoreActionResult GetSlowShootingZombieDecision() { }

	private bool KnowAboutEnemy() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public void SetZombieMode(EZombieMode mode) { }

	public virtual bool ShallUseNow() { }

	private void TryReportEnemy() { }

}

