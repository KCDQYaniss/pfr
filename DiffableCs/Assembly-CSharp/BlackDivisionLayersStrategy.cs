//Type is in global namespace

public class BlackDivisionLayersStrategy : BaseBrain
{
	public const int GRENADE_DANGER = 1; //Field offset: 0x0
	public const int CONTROL_BUILDING_LOGIC = 17; //Field offset: 0x0
	public const int PATROL_HIDE = 15; //Field offset: 0x0
	public const int FIGHT_REQUEST = 16; //Field offset: 0x0
	public const int PURSUIT_LAYER = 14; //Field offset: 0x0
	public const int FIGHT_LOGIC = 13; //Field offset: 0x0
	public const int PATROL_STAY_AT_POS_LOGIC = 11; //Field offset: 0x0
	public const int PATROL_LOGIC_DEF = 12; //Field offset: 0x0
	public const int PATROL_DEAD_BODY = 10; //Field offset: 0x0
	public const int DISTANCE_TO_CHEAT_VISIBILITY = 9; //Field offset: 0x0
	public const int PATROL_FOLLOWER_LOGIC = 7; //Field offset: 0x0
	public const int FLANK = 6; //Field offset: 0x0
	public const int SUPRESS_ASSAULT_LOGIC = 5; //Field offset: 0x0
	public const int DEFENCE_LOGIC = 4; //Field offset: 0x0
	public const int PATROL_LOGIC = 3; //Field offset: 0x0
	public const int ASSAULT_LOGIC = 2; //Field offset: 0x0
	private AIPeriodAction _period; //Field offset: 0x58
	protected BossFinder _boss; //Field offset: 0x60

	public BlackDivisionLayersStrategy(BotOwner owner) { }

	public void Assault() { }

	public void Defence() { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public void Flank() { }

	public virtual void ManualUpdate() { }

	private void OnDoAssault(BossBlackDivision obj, IPlayer trg) { }

	private void OnDoDefence(BossBlackDivision obj, IPlayer trg) { }

	private void OnDoFlank(BossBlackDivision obj, IPlayer trg) { }

	private void OnDoSuppressAssault(BossBlackDivision arg1, IPlayer trg) { }

	private void OnFind() { }

	private void OnFindBoss(BossBlackDivision bossBlk) { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private void SetEnemyInfo() { }

	public virtual string ShortName() { }

	public void SuppressAssault() { }

}

