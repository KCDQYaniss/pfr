namespace EFT;

public sealed class NetworkKolotunController : KolotunController
{
	private readonly Action _kolotunStateUnsubscribe; //Field offset: 0x40

	public NetworkKolotunController(KolotunGlobalSettings settings, Location location, LocationSettings locationSettings) { }

	public virtual void Dispose() { }

	private void OnStateReceived(KolotunStateEvent data) { }

}

