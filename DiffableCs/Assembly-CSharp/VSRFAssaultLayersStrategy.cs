//Type is in global namespace

public class VSRFAssaultLayersStrategy : BaseBrain
{
	public const int GRENADE_DANGER = 1; //Field offset: 0x0
	public const int ASSAULT_LOGIC = 2; //Field offset: 0x0
	public const int PATROL_LOGIC = 3; //Field offset: 0x0
	public const int TARGET_LOGIC = 4; //Field offset: 0x0
	public const int FLANK = 6; //Field offset: 0x0
	public const int PATROL_FOLLOWER_LOGIC = 8; //Field offset: 0x0
	public const int DEFENCE_LOGIC = 9; //Field offset: 0x0
	private AIPeriodAction _period; //Field offset: 0x58

	public VSRFAssaultLayersStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	private void SetEnemyInfo() { }

	public virtual string ShortName() { }

}

