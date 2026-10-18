//Type is in global namespace

internal class AdvAssaultTargetLayerExtended : AdvAssaultTargetLayer
{

	public AdvAssaultTargetLayerExtended(BotOwner bot, int priority, bool withSearch) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

