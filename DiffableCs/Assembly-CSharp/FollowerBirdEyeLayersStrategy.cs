//Type is in global namespace

public class FollowerBirdEyeLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 2; //Field offset: 0x0
	private const int ENEMY_BUILDING = 7; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int PATROL_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_REQUEST = 6; //Field offset: 0x0
	private const int ENEMY_HOLD_LOGIC = 8; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int ASSAULT_ENEMY_BUILDING = 13; //Field offset: 0x0

	public FollowerBirdEyeLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	public virtual string ShortName() { }

}

