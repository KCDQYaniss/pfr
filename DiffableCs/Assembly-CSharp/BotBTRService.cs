//Type is in global namespace

public class BotBTRService
{
	private List _friendlyPlayersByBtrSupport; //Field offset: 0x10
	private List _betrayers; //Field offset: 0x18
	private BotOwner _btrOwner; //Field offset: 0x20

	public bool BtrSupportPurchased
	{
		 get { } //Length: 69
	}

	public BotBTRService() { }

	private void AddBetrayer(IPlayer player) { }

	private void AddFriendlyPlayer(Player player) { }

	public void Dispose() { }

	public bool get_BtrSupportPurchased() { }

	public bool IsFriendlyPlayersByBtrSupport(IPlayer player) { }

	public void OnBTRSupportInterruptedByBetrayer(IPlayer betrayer) { }

	public void OnBTRSupportPurchased(List passengers) { }

	public void OnBTRSupportStop() { }

	public void RegisterBotBTR(BotOwner owner) { }

	public void Reset() { }

}

