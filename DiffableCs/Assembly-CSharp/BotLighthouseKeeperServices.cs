//Type is in global namespace

public class BotLighthouseKeeperServices
{
	private const float CHECK_FRIENDLY_PERIOD = 5; //Field offset: 0x0
	private float _nextCheckTime; //Field offset: 0x10
	private BotsController _botsController; //Field offset: 0x18
	private List _friendlyExUsecs; //Field offset: 0x20
	private List _friendlyZryachiy; //Field offset: 0x28
	private List _markedPlayers; //Field offset: 0x30

	public List FriendlyExUsecs
	{
		 get { } //Length: 5
	}

	public List FriendlyZryachiy
	{
		 get { } //Length: 5
	}

	public List MarkedPlayers
	{
		 get { } //Length: 76
	}

	public BotLighthouseKeeperServices(BotsController botsController) { }

	public void CancelAllLighthouseKeeperServicesForPlayersTeam(IPlayer player) { }

	private void CancelAllLighthouseKeeperServicesForPlayersTeam(string playerProfileId) { }

	private void CancelAllServicesForPlayer(IPlayer player) { }

	public void Dispose() { }

	public List get_FriendlyExUsecs() { }

	public List get_FriendlyZryachiy() { }

	public List get_MarkedPlayers() { }

	public bool IsExUsecsServiceActive(IPlayer player) { }

	public bool IsPlayerExUsecFriendly(IPlayer player) { }

	public bool IsPlayerZryachiyFriendly(IPlayer player) { }

	public void OnFriendlyExUsecPurchased(Player player) { }

	public void OnFriendlyZryachiyPurchased(Player player) { }

	public bool ShallWarn(BotOwner owner, IPlayer playerToWarn) { }

}

