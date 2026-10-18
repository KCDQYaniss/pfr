//Type is in global namespace

public class TagillaHelperAgroStrategy : BaseBrain
{
	private const int AMBUSH_LOGIC = 1; //Field offset: 0x0
	private const int ENEMY_LOGIC = 2; //Field offset: 0x0
	private const int PATROL_LOGIC = 3; //Field offset: 0x0
	private const int TARGET_LOGIC = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int PATROL_REQUEST = 6; //Field offset: 0x0
	private const int FIGHT_REQUEST = 7; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0

	public TagillaHelperAgroStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

