//Type is in global namespace

public class KolontayHoldNearBossLayer : HoldNearBossLayer
{
	private readonly BossFinder _bossLogic; //Field offset: 0x90

	public KolontayHoldNearBossLayer(BotOwner bot, int priority) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

}

