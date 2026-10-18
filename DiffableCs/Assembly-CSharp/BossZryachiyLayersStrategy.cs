//Type is in global namespace

public class BossZryachiyLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int CLOSE_ENEMY_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 4; //Field offset: 0x0
	private const int ENEMY_DIST_CHECK = 5; //Field offset: 0x0
	private const int PATROL_REQUEST = 6; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0

	public BossZryachiyLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

