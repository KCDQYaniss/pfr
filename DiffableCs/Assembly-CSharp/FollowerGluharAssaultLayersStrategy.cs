//Type is in global namespace

public class FollowerGluharAssaultLayersStrategy : GluharAbstractLayersStrategy
{
	private const int ENEMY_LOGIC_ROLE = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ENEMY_LOGIC_SIMPLE = 7; //Field offset: 0x0
	private const int ENEMY_LOGIC_KILLA = 8; //Field offset: 0x0
	private const int PATROL_REQUEST = 9; //Field offset: 0x0
	private const int FIGHT_REQUEST = 10; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int HOLD_OR_COVER_FIGHT = 15; //Field offset: 0x0
	private const int TARGET_LOGIC_SIMPLE = 43; //Field offset: 0x0
	private FollowerGluharAssaultFightLayer _enemyLogicRole; //Field offset: 0x60
	private GluharTargetLayer target; //Field offset: 0x68
	private GluharAsKillaLayer enemyLogicKilla; //Field offset: 0x70

	public FollowerGluharAssaultLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void FindBoss() { }

	private void OnBossFinded(IBossToFollow bossToFollow) { }

	protected virtual void SetBoss(BossGluhar gluhar) { }

	public virtual string ShortName() { }

}

