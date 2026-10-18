namespace Audio.Weapons;

public sealed class PlayerOcclusionService : IOcclusionService
{
	private IObserverToPlayerBridge _playerBridge; //Field offset: 0x10

	public PlayerOcclusionService() { }

	public override void Process(BetterSource source) { }

	public override void RegisterPlayer(IObserverToPlayerBridge playerBridge) { }

}

