//Type is in global namespace

public class PartisanPlantingTargetLayer : PartisanBasePlantingLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public EnemyInfo enemy; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetDecision>g__GoodPoint|0(GroupPoint arg) { }

	}

	private const bool USE_TIME_TO_COMPARE = True; //Field offset: 0x0
	public const float WAIT_DANGER_PLACE = 30; //Field offset: 0x0
	public const float WAIT_SIMPLE_PLACE = 10; //Field offset: 0x0
	public const float SDIST_TO_STOP_ON_HEAR = 100; //Field offset: 0x0
	public const float SDIST_TO_STOP_ON_HEAR_DANGER = 900; //Field offset: 0x0
	public const float SDIST_ENEMY_GO_FAR = 6400; //Field offset: 0x0
	public const float PERIOD_STOP_ON_HEAR = 30; //Field offset: 0x0
	private float _minePlanted; //Field offset: 0xB0
	private bool _lastMoveStealthCauseEnemy; //Field offset: 0xB4
	private float WAIT_DEBUF_PUT_MINE; //Field offset: 0xB8
	private float _lastTimeFoundGood; //Field offset: 0xBC
	private float _stopUntil; //Field offset: 0xC0

	public PartisanPlantingTargetLayer(BotOwner bot, int priority, AvoidDangerLayer avoidLayerToCheck) { }

	protected virtual AICoreActionEnd EndGoToCoverPointTactical() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndMoveStealthy() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

