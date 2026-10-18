namespace EFT;

public class CivilianLayersStrategy : BaseBrain
{
	private const int GRENADE_DANGER = 6; //Field offset: 0x0
	private const int HIDE_IN_COVERS = 1; //Field offset: 0x0

	public CivilianLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	public virtual string ShortName() { }

}

