//Type is in global namespace

public class BotFriendChecker : BotData
{
	private const float DIST_TO_AIM = 50; //Field offset: 0x0
	private const float DIST_TO_LOOK = 50; //Field offset: 0x0
	private const float DIST_TO_EAT = 50; //Field offset: 0x0
	private const float DIST_TO_GESTUS = 20; //Field offset: 0x0
	private const float DIST_TO_TILT = 50; //Field offset: 0x0
	private const float DIST_TO_WATCH_WEAPON = 50; //Field offset: 0x0
	private readonly float _distToBeClose; //Field offset: 0x18
	private readonly BotsConnections _botsConnections; //Field offset: 0x20
	private float _nextTimeCheck; //Field offset: 0x28
	private readonly WDictionary _chancesNoEat; //Field offset: 0x30
	private readonly WDictionary _chancesTotal; //Field offset: 0x38

	public BotFriendChecker(BotOwner owner, BotsConnections botsConnections) { }

	public void ManualUpdate() { }

}

