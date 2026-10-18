//Type is in global namespace

public class ForcedForHelpAssaultLayerExtended : ForcedForHelpAssaultLayer
{

	public ForcedForHelpAssaultLayerExtended(BotOwner bot, int priority, float enemyDistanceToStartFight = -1, float chanceToRun = -1) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

}

