//Type is in global namespace

public class PartisanZeroSavageLayer : PartisanFightBaseLayer
{
	private const float NO_MELLEE_PERIOD = 150; //Field offset: 0x0
	private const float SHOOT_IF_SEEN_TOO_MUCH = 45; //Field offset: 0x0
	private BossFinder _bossLogic; //Field offset: 0x98
	private AIPeriodAction _period; //Field offset: 0xA0
	private AIMinePoint _closests; //Field offset: 0xA8
	private float DIST_TO_MELEE; //Field offset: 0xB0
	private float _lastDoGoToEnemy; //Field offset: 0xB4
	private float _startMelee; //Field offset: 0xB8
	private float _noMeleeUntil; //Field offset: 0xBC
	protected BotMeleeAssaultData _assaultData; //Field offset: 0xC0
	private bool _bossLogicFind; //Field offset: 0xC8

	public PartisanZeroSavageLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void RefreshCantShoot() { }

	public virtual bool ShallUseNow() { }

}

