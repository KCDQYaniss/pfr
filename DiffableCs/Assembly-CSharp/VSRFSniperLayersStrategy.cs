//Type is in global namespace

public class VSRFSniperLayersStrategy : BaseBrain
{
	public const int GRENADE_DANGER = 1; //Field offset: 0x0
	public const int ASSAULT_LOGIC = 2; //Field offset: 0x0
	public const int PATROL_LOGIC = 3; //Field offset: 0x0
	public const int DEFENCE_LOGIC = 4; //Field offset: 0x0
	public const int FLANK = 6; //Field offset: 0x0
	public const int PATROL_FOLLOWER_LOGIC = 7; //Field offset: 0x0
	public const int DISTANCE_TO_CHEAT_VISIBILITY = 9; //Field offset: 0x0
	public const int PATROL_DEAD_BODY = 10; //Field offset: 0x0
	public const int PATROL_UTILITY = 11; //Field offset: 0x0
	private AIPeriodAction _period; //Field offset: 0x58

	public VSRFSniperLayersStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	private void SetEnemyInfo() { }

	public virtual string ShortName() { }

}

