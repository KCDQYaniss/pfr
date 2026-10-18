//Type is in global namespace

public class FollowerSanitarLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int BULLY_LAYER = 6; //Field offset: 0x0
	private const int FOLLOWER_TARGET_LOGIC = 7; //Field offset: 0x0
	private const int PATROL_REQUEST = 9; //Field offset: 0x0
	private const int PATROL_FOLLOWER_LOGIC = 10; //Field offset: 0x0
	private const int FIGHT_REQUEST = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int WARNS_LAYER = 13; //Field offset: 0x0
	private readonly FollowerSanitarFightLayer fightLayer; //Field offset: 0x58
	private readonly SanitarTargetLayer targetLayer; //Field offset: 0x60

	public int Id
	{
		 get { } //Length: 29
	}

	public FollowerSanitarLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public void ForceRecalcShootPos() { }

	public int get_Id() { }

	public void SetBossSanitar(IBossSanitar bossSanitar) { }

	public virtual string ShortName() { }

}

