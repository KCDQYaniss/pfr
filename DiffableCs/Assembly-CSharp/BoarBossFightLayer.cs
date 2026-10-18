//Type is in global namespace

public class BoarBossFightLayer : BoarFightAbstractLayer
{
	public const float CAN_SPRESS_DELTA_SEEN = 20; //Field offset: 0x0
	public const float DIST_BOSS_CAN_ATTACK = 15; //Field offset: 0x0
	public const float SUPPRESS_PERIOD = 10; //Field offset: 0x0
	private const float ENEMY_NO_GET_DAMAGE = 5; //Field offset: 0x0
	private float _lastHit; //Field offset: 0xC0
	private float _lastTrigger; //Field offset: 0xC4
	private float _nextPossibleChangeCover; //Field offset: 0xC8
	private float _startSuppress; //Field offset: 0xCC

	public BoarBossFightLayer(BotOwner bot, int priority) { }

	private bool CanSuppress() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMovingWithSuppress() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	private bool EnemyCanBeAttacked() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private void OnHitTarget(IPlayer arg1, DamageInfo arg2, EBodyPart arg3) { }

	private void OnTriggerPressed() { }

	public virtual bool ShallUseNow() { }

}

