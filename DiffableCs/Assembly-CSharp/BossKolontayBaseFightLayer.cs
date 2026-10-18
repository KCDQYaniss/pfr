//Type is in global namespace

public abstract class BossKolontayBaseFightLayer : KolontayAbstractFightLayer
{
	public const float DIST_TO_ATTACK_CLOSE = 15; //Field offset: 0x0
	public const float DIST_TO_GET_HIT_NO_ATTACK = 5; //Field offset: 0x0
	public const int MAX_ENEMIES_TO_MELEE = 1; //Field offset: 0x0
	private float _endShoot; //Field offset: 0xA0
	protected float _nextSetMisfire; //Field offset: 0xA4
	protected float _endShootTime; //Field offset: 0xA8
	protected float _startMelee; //Field offset: 0xAC
	protected BotMeleeAssaultData _assaultData; //Field offset: 0xB0
	protected bool _doCloseAttack; //Field offset: 0xB8

	protected BossKolontayBaseFightLayer(BotOwner bot, int priority) { }

	protected AICoreActionResult AttackLogicOrMelee(EnemyInfo enemy, string info) { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected bool IsTooManyToMelee() { }

	protected AICoreActionEnd SubEndOneMeleeAttack() { }

}

