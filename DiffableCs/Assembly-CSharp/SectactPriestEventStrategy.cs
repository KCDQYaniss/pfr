//Type is in global namespace

public class SectactPriestEventStrategy : BaseBrain
{
	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int GIFTER_LOGIC = 6; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0

	public SectactPriestEventStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void OnMemberRemove(BotOwner obj) { }

	public virtual string ShortName() { }

}

