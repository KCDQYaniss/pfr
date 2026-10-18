//Type is in global namespace

public class PmcUsecLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_REQUEST = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ENEMY_LOGIC2 = 6; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 7; //Field offset: 0x0
	private const int PATROL_UTILITY = 8; //Field offset: 0x0
	private const int FIGHT_REQUEST = 9; //Field offset: 0x0
	private const int EXFILTRATION = 10; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int PURSUIT_BASE = 13; //Field offset: 0x0
	private const int LOOT_PATROL = 14; //Field offset: 0x0
	private const int WARNS_LAYER = 15; //Field offset: 0x0

	public PmcUsecLayersStrategy(BotOwner owner, bool withPursuit) { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void OnBossKilled(IPlayer killer, IPlayer target) { }

	private void OnScavDamage(DamageInfo damageInfo, Player victim) { }

	public virtual string ShortName() { }

}

