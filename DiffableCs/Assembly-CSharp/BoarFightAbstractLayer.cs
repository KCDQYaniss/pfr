//Type is in global namespace

public abstract class BoarFightAbstractLayer : BoarAbstractLayer
{
	protected CustomNavigationPoint _coverInMiddle; //Field offset: 0xB0
	private float _nextCheckCoverInMiddle; //Field offset: 0xB8

	protected BoarFightAbstractLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndRunAwayGrenade() { }

	protected virtual AICoreActionEnd EndRunGas() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	protected void RecheckCoverAtMiddle() { }

	protected CoverSearchData RecheckCoverData() { }

}

