//Type is in global namespace

public class PeacefulRequestLayerAssault : PeacefulRequestLayer
{

	public PeacefulRequestLayerAssault(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

