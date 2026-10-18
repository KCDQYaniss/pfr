//Type is in global namespace

public class InfectedPatrolStayAtPositionLayer : PatrolStayAtPositionLayer
{
	private float _deltaToCheck; //Field offset: 0xD0
	private float _deltaToCheckMin; //Field offset: 0xD4
	private float _deltaToCheckMax; //Field offset: 0xD8

	public InfectedPatrolStayAtPositionLayer(BotOwner bot, int priority, bool tryFinGreenFirst, CoverLevel minGreenPointCoverLevel = 2, bool usePeriodForceReched = false) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual CustomNavigationPoint GetPoint() { }

	public virtual string Name() { }

	private void RndDeltaNext() { }

}

