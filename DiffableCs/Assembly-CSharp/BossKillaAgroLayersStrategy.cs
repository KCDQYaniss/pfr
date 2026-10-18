//Type is in global namespace

public class BossKillaAgroLayersStrategy : BaseBrain
{
	private const int AMBUSH_LOGIC = 1; //Field offset: 0x0
	private const int ENEMY_LOGIC = 2; //Field offset: 0x0
	private const int PATROL_LOGIC = 3; //Field offset: 0x0
	private const int TARGET_LOGIC = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int PATROL_REQUEST = 6; //Field offset: 0x0
	private const int FIGHT_REQUEST = 7; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private AIPeriodAction _checkEnemy; //Field offset: 0x58
	private Vector3 _corePos; //Field offset: 0x60

	public BossKillaAgroLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	public virtual string ShortName() { }

	private void UpdateCheckEnemyInfo() { }

}

