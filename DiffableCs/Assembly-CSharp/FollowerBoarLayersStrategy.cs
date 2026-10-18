//Type is in global namespace

public class FollowerBoarLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int GRENADE_DANGER = 3; //Field offset: 0x0
	private const int STATIONARY_LOGIC = 5; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 6; //Field offset: 0x0
	private const int FIGHT_REQUEST = 7; //Field offset: 0x0
	private const int PEACE = 8; //Field offset: 0x0
	private const int PATROL_LOGIC_NO_BOSS = 9; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private string _name; //Field offset: 0x58

	public FollowerBoarLayersStrategy(BotOwner owner, bool closePatrol) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

