//Type is in global namespace

public class FollowerBullyLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int ENEMY_LOGIC2 = 7; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PATROL_REQUEST = 4; //Field offset: 0x0
	private const int FIGHT_REQUEST = 5; //Field offset: 0x0
	private const int GRENADE_DANGER = 6; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 8; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0

	public FollowerBullyLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

