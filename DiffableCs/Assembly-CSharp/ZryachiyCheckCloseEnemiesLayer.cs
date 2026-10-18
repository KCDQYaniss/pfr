//Type is in global namespace

public class ZryachiyCheckCloseEnemiesLayer : ZryachiyBaseLayer
{
	public const float DIST_TO_BECOME_ENEMY = 7; //Field offset: 0x0
	private const float DIST_CHECK_FASTER = 30; //Field offset: 0x0
	private const float DIST_TO_START_GESTUS = 10; //Field offset: 0x0
	private const float DIST_TO_START_GESTUS_MAX = 15; //Field offset: 0x0
	private const float PERIOD_AFTER_CESTUS = 5; //Field offset: 0x0
	private const float PERIOD_TO_BECOME_ENEMY = 8; //Field offset: 0x0
	private bool _showGestus; //Field offset: 0x98
	private float _nextPeriodCheck; //Field offset: 0x9C
	private readonly Dictionary _gestusShowedTime; //Field offset: 0xA0

	public ZryachiyCheckCloseEnemiesLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGestus() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

