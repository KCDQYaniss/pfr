//Type is in global namespace

internal class AssaultTargetLayerExtended : AssaultTargetLayer
{

	public AssaultTargetLayerExtended(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

