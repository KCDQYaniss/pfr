//Type is in global namespace

public class BlackDivisionControlBuildingLayer : ControlBuildingLayer
{
	protected BossFinder _boss; //Field offset: 0xA0

	public BlackDivisionControlBuildingLayer(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual bool ShallUseNow() { }

}

