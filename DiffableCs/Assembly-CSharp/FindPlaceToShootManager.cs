//Type is in global namespace

public class FindPlaceToShootManager : BotData
{
	private Dictionary _finders; //Field offset: 0x18

	public FindPlaceToShootManager(BotOwner owner) { }

	public BotFindPlaceToShoot Register(int dist, int minDist, float periodCheck, EBotFindPlaceType findPlaceType = 1) { }

}

