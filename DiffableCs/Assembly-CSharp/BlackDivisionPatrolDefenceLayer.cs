//Type is in global namespace

public class BlackDivisionPatrolDefenceLayer : PatrolStayAtPositionLayer
{
	protected BossFinder _boss; //Field offset: 0xD0
	private Vector3 _offset; //Field offset: 0xD8

	public BlackDivisionPatrolDefenceLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

