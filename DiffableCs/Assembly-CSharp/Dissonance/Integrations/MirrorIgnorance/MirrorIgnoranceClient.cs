namespace Dissonance.Integrations.MirrorIgnorance;

public class MirrorIgnoranceClient : BaseClient
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__NullMessageReceivedHandler; //Field offset: 0x0

	}

	private readonly MirrorIgnoranceCommsNetwork _network; //Field offset: 0xA8
	private readonly NetworkWriter _sendWriter; //Field offset: 0xB0
	private readonly byte[] _receiveBuffer; //Field offset: 0xB8

	public MirrorIgnoranceClient(MirrorIgnoranceCommsNetwork network) { }

	public virtual void Connect() { }

	public virtual void Disconnect() { }

	private void OnMessageReceivedHandler(NetworkMessage netMsg) { }

	protected virtual void ReadMessages() { }

	private bool Send(ArraySegment packet, NetworkChannel channel) { }

	protected virtual void SendReliable(ArraySegment packet) { }

	protected virtual void SendUnreliable(ArraySegment packet) { }

	public virtual void SendVoiceData(ArraySegment encodedAudio) { }

}

