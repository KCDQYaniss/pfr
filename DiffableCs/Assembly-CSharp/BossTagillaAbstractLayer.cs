//Type is in global namespace

public abstract class BossTagillaAbstractLayer : BaseLogicLayer
{
	private const float CLOSE_ENEMIES_UPDATE_PERIOD = 3; //Field offset: 0x0
	protected BotMeleeAssaultData _assaultData; //Field offset: 0x90
	private float _prevCloseEnemiesTimeCompute; //Field offset: 0x98
	private int _cachedCloseEnemies; //Field offset: 0x9C
	private bool _cachedAnywayAttack; //Field offset: 0xA0
	protected readonly List _curentInfos; //Field offset: 0xA8

	protected BossTagillaAbstractLayer(BotOwner bot, int priority) { }

	protected int CloseEnemiesCount(out bool anywayAttack, bool resetCache = false) { }

}

