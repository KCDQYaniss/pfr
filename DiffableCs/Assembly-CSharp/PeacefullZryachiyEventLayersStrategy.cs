//Type is in global namespace

public class PeacefullZryachiyEventLayersStrategy : BaseBrain
{
	private const int GIFTER_LOGIC = 6; //Field offset: 0x0
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0

	public PeacefullZryachiyEventLayersStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void OnKill(IPlayer killer, IPlayer target) { }

	public virtual string ShortName() { }

}

