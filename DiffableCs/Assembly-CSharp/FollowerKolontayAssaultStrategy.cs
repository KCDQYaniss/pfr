//Type is in global namespace

public class FollowerKolontayAssaultStrategy : BaseBrain
{
	private const int ENEMY_LOGIC_ROLE = 1; //Field offset: 0x0
	private const int TARGET_LOGIC_SIMPLE = 43; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 22; //Field offset: 0x0
	private const int ENEMY_LOGIC_ROLE2 = 13; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int FIGHT_REQUEST = 10; //Field offset: 0x0
	private const int ENEMY_NOT_MY_HOUSE = 11; //Field offset: 0x0
	private const int WARNS_LAYER = 8; //Field offset: 0x0
	private const int ENEMY_LOGIC_SIMPLE = 7; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int PATROL_REQUEST = 9; //Field offset: 0x0
	private float _nextPossibleChangeTactics; //Field offset: 0x58
	private readonly KolontayForceAttackLayer _roleForceAttack; //Field offset: 0x60
	private readonly KolontayAssaultProtectLayer _roleProtect; //Field offset: 0x68
	private readonly BossFinder _bossLogic; //Field offset: 0x70

	public FollowerKolontayAssaultStrategy(BotOwner owner) { }

	private void CheckDist(EnemyInfo myEnemy) { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	public void SetProtect(bool v) { }

	public virtual string ShortName() { }

}

