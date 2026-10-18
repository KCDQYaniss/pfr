namespace Audio.Weapons;

public interface IOcclusionService
{

	public void Process(BetterSource source) { }

	public void RegisterPlayer(IObserverToPlayerBridge playerBridge) { }

}

