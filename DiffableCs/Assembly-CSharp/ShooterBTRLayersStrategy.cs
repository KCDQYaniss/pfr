//Type is in global namespace

public class ShooterBTRLayersStrategy : BaseBrain
{
	private const int BASE_LOGIC = 1; //Field offset: 0x0
	private const int SUPPRESS_LOGIC = 2; //Field offset: 0x0
	private bool _btrIsCrashed; //Field offset: 0x58
	private bool _inited; //Field offset: 0x59

	public ShooterBTRLayersStrategy(BotOwner owner) { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	private void ProcessBTRBeingHit(IPlayer aggressor) { }

	public virtual string ShortName() { }

	private void TryInitBTR() { }

}

