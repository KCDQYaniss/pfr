//Type is in global namespace

public abstract class BotTraderServiceFriendlyBase
{
	protected Player friendlyPlayer; //Field offset: 0x10
	protected List friendlyTeam; //Field offset: 0x18
	protected BotLighthouseKeeperServices services; //Field offset: 0x20
	protected IPlayersCollection allBots; //Field offset: 0x28
	protected ITimer reactivateTimer; //Field offset: 0x30

	public string PlayerGroupId
	{
		 get { } //Length: 254
	}

	public int PlayerId
	{
		 get { } //Length: 29
	}

	public string PlayerProfileId
	{
		 get { } //Length: 245
	}

	public BotTraderServiceFriendlyBase(BotLighthouseKeeperServices services, IPlayersCollection allBots, Player player) { }

	protected abstract void ActivateService(Player playerServiceOwner, bool reactivate) { }

	public string get_PlayerGroupId() { }

	public int get_PlayerId() { }

	public string get_PlayerProfileId() { }

	protected bool IsExUsec(IPlayer player) { }

	protected bool IsZryachiyOrFollower(IPlayer player) { }

	protected abstract bool OutOfRange(Vector3 position) { }

}

