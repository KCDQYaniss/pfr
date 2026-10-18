//Type is in global namespace

public abstract class BossWedgeBaseLayersStrategy : BaseBrain
{
	private readonly BossWedgeDistTracker _wedgeDistTracker; //Field offset: 0x58

	protected BossWedgeDistTracker WedgeDistTracker
	{
		 get { } //Length: 5
	}

	protected BossWedgeBaseLayersStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected BossWedgeDistTracker get_WedgeDistTracker() { }

	public virtual void ManualUpdate() { }

}

