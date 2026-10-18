namespace Dissonance.Networking.Client;

internal class VoiceReceiver`1
{
	private static readonly Log Log; //Field offset: 0x0
	private static readonly TimeSpan ActiveTimeout; //Field offset: 0x0
	private static readonly TimeSpan InactiveTimeout; //Field offset: 0x0
	private readonly ISession _session; //Field offset: 0x0
	private readonly IClientCollection _clients; //Field offset: 0x0
	private readonly EventQueue _events; //Field offset: 0x0
	private readonly Rooms _rooms; //Field offset: 0x0
	private readonly ConcurrentPool _channelListPool; //Field offset: 0x0
	private readonly List _receivers; //Field offset: 0x0

	private static VoiceReceiver`1() { }

	public VoiceReceiver`1(ISession session, IClientCollection clients, EventQueue events, Rooms rooms, ConcurrentPool channelListPool) { }

	private void CheckTimeouts(DateTime utcNow) { }

	private void OnPlayerLeft(string name) { }

	public void ReceiveVoiceData(ref PacketReader reader, Nullable utcNow = null) { }

	public void Stop() { }

	public void Update(DateTime utcNow) { }

}

