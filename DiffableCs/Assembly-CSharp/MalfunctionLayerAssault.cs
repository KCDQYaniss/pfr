//Type is in global namespace

public class MalfunctionLayerAssault : MalfunctionLayer
{

	public MalfunctionLayerAssault(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

