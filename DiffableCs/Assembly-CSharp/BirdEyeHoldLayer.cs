//Type is in global namespace

public class BirdEyeHoldLayer : BirdEyeAbstractLayer
{
	protected const float WAIT_ENEMY_PERIOD_TO_NOTHING = 60; //Field offset: 0x0
	protected const float INIT_END_DIST = 40; //Field offset: 0x0
	private ShootToPoint _pointToControl; //Field offset: 0xB8
	private bool _isInited; //Field offset: 0xC0
	private bool _isSubs; //Field offset: 0xC1
	private EnemyInfo _lastEnemy; //Field offset: 0xC8
	private float _initTime; //Field offset: 0xD0
	private BotFindPlaceToShoot _finderUsing; //Field offset: 0xD8
	private BotFindPlaceToShoot _finderStandart; //Field offset: 0xE0
	private BotFindPlaceToShoot _finderClose; //Field offset: 0xE8

	public BirdEyeHoldLayer(BotOwner bot, int priority) { }

	private void DeInit() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual ShootToPoint GetShootPoint() { }

	public void Init(Vector3 pointToControl) { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	private void OnBulletNear(BotOwner bot, IPlayer source) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnMemberRemove(BotOwner obj) { }

	private void OnTargetInventoryOpened(Player player, bool obj) { }

	private float sDistToShoot() { }

	public virtual bool ShallUseNow() { }

}

