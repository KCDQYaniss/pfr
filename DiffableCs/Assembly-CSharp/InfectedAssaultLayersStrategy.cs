//Type is in global namespace

public class InfectedAssaultLayersStrategy : BaseBrain
{
	private const int PATROL_LOGIC = 2; //Field offset: 0x0

	public InfectedAssaultLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual string ShortName() { }

}

