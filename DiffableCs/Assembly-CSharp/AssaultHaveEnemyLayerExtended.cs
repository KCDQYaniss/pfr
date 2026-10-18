//Type is in global namespace

public class AssaultHaveEnemyLayerExtended : AssaultHaveEnemyLayer
{

	public AssaultHaveEnemyLayerExtended(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

