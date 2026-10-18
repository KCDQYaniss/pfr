//Type is in global namespace

public class BossSanitarLayersStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int PANIC_LOGIC = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int SANITAR_LAYER = 6; //Field offset: 0x0
	private const int SANITAR_TARGET_LOGIC = 7; //Field offset: 0x0
	private const int PATROL_UTILITY = 8; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private readonly BossSanitarFightLayer _fightLayer; //Field offset: 0x58
	private readonly SanitarTargetLayer _targetLayer; //Field offset: 0x60

	public BossSanitarLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public void ForceRecalcShootPos() { }

	public virtual string ShortName() { }

}

