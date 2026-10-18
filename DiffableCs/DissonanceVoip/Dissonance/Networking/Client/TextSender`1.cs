namespace Dissonance.Networking.Client;

internal class TextSender`1
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly ISession _session; //Field offset: 0x0
	private readonly ISendQueue _sender; //Field offset: 0x0
	private readonly IClientCollection _peers; //Field offset: 0x0
	private readonly List _tmpDests; //Field offset: 0x0

	private static TextSender`1() { }

	public TextSender`1(ISendQueue sender, ISession session, IClientCollection peers) { }

	public void Send(string data, ChannelType type, string recipient) { }

}

