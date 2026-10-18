//Type is in global namespace

public class FollowerGluharProtectLayersStrategy : GluharAbstractLayersStrategy
{
	private const int ENEMY_LOGIC_ROLE = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ENEMY_LOGIC_SIMPLE = 7; //Field offset: 0x0
	private const int PATROL_REQUEST = 9; //Field offset: 0x0
	private const int FIGHT_REQUEST = 10; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 22; //Field offset: 0x0
	private const int TARGET_LOGIC_SIMPLE = 43; //Field offset: 0x0

	public FollowerGluharProtectLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void FindBoss() { }

	private void OnBossFinded(IBossToFollow bossToFollow) { }

	protected virtual void SetBoss(BossGluhar gluhar) { }

	public virtual string ShortName() { }

}

