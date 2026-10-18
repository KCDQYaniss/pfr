namespace EFT;

public sealed class NetworkRunddansController : ClientRunddansController
{
	private readonly Action _eventStateUnsubscribe; //Field offset: 0x48
	private readonly Action _eventMessagesUnsubscribe; //Field offset: 0x50

	public NetworkRunddansController(RunddansGlobalSettings settings, Location location) { }

	public virtual void Dispose() { }

	private static bool IsTargetPlayer(int playerId, out Player player) { }

	private void Message(RunddansMessagesEvent data) { }

	private void State(RunddansStateEvent data) { }

}

