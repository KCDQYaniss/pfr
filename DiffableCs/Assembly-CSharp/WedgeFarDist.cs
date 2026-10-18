//Type is in global namespace

public class WedgeFarDist : BaseWedgeLayer
{
	private readonly BossWedgeDistTracker _distTracker; //Field offset: 0xB0
	private AIPeriodAction _usingStims; //Field offset: 0xB8
	private CustomNavigationPoint _coverInMiddle; //Field offset: 0xC0
	private float _nextCheckCoverInMiddle; //Field offset: 0xC8

	public WedgeFarDist(BotOwner bot, int priority, BossWedgeDistTracker distTracker) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private bool SawEnemyLongTime() { }

	public virtual bool ShallUseNow() { }

	private void TryUsingStims() { }

}

