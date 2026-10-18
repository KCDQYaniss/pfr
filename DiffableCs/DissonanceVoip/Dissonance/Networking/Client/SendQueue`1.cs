namespace Dissonance.Networking.Client;

internal class SendQueue`1 : ISendQueue
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal List <.ctor>b__9_0() { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private readonly IClient _client; //Field offset: 0x0
	private readonly ReadonlyLockedValue _serverReliableQueue; //Field offset: 0x0
	private readonly ReadonlyLockedValue _serverUnreliableQueue; //Field offset: 0x0
	private readonly ReadonlyLockedValue _reliableP2PQueue; //Field offset: 0x0
	private readonly ReadonlyLockedValue _unreliableP2PQueue; //Field offset: 0x0
	private readonly ReadonlyLockedValue _sendBufferPool; //Field offset: 0x0
	private readonly ConcurrentPool _listPool; //Field offset: 0x0
	private readonly List _tmpRecycleQueue; //Field offset: 0x0

	private static SendQueue`1() { }

	public SendQueue`1(IClient client, ReadonlyLockedValue bytePool) { }

	private static int Drop(ReadonlyLockedValue l) { }

	public override void EnqeueUnreliable(ArraySegment packet) { }

	private void EnqueueP2P(ushort localId, ICollection destinations, ICollection queue, ArraySegment packet) { }

	public override void EnqueueReliable(ArraySegment packet) { }

	public override void EnqueueReliableP2P(ushort localId, IList destinations, ArraySegment packet) { }

	public override void EnqueueUnreliableP2P(ushort localId, IList destinations, ArraySegment packet) { }

	public override byte[] GetSendBuffer() { }

	public override void RecycleSendBuffer(byte[] buffer) { }

	public void Stop() { }

	public void Update() { }

}

