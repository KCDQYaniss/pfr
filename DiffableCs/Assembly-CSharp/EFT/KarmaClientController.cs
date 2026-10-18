namespace EFT;

public class KarmaClientController : IDisposable
{
	private Action unsub; //Field offset: 0x10

	public KarmaClientController() { }

	public override void Dispose() { }

	private void OnKarmaNotificationEvent(KarmaNotificationEvent karmaNotificationEvent) { }

}

