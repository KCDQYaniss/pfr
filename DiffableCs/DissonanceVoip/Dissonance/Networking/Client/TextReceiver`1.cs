namespace Dissonance.Networking.Client;

internal class TextReceiver`1
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly EventQueue _events; //Field offset: 0x0
	private readonly Rooms _rooms; //Field offset: 0x0
	private readonly IClientCollection _peers; //Field offset: 0x0

	private static TextReceiver`1() { }

	public TextReceiver`1(EventQueue events, Rooms rooms, IClientCollection peers) { }

	[CanBeNull]
	private string GetTxtMessageRecipient(ChannelType txtRecipientType, ushort txtRecipient) { }

	public void ProcessTextMessage(ref PacketReader reader) { }

}

