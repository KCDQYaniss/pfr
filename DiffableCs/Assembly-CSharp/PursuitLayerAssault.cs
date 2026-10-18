//Type is in global namespace

internal class PursuitLayerAssault : PursuitLayer
{

	public PursuitLayerAssault(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

