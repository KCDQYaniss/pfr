namespace EFT.Interactive;

public sealed class SniperFireTargetManager : PlayersWithImmuneToSniperFire
{
	private readonly HashSet _markedAggressors; //Field offset: 0x28

	public SniperFireTargetManager() { }

	public virtual void AddImmunePlayer(int playerRaidId) { }

	public virtual bool IsPlayerImmuneForFire(int playerRaidId) { }

	public void MarkAggressor(int playerRaidId) { }

}

