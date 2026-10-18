namespace FlyingWormConsole3.LiteNetLib.Utils;

public class NetPacketProcessor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0`1
	{
		public Func packetConstructor; //Field offset: 0x0
		public NetPacketProcessor <>4__this; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass25_0`1() { }

		internal void <Subscribe>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0`2
	{
		public Func packetConstructor; //Field offset: 0x0
		public NetPacketProcessor <>4__this; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass26_0`2() { }

		internal void <Subscribe>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0`1
	{
		public NetPacketProcessor <>4__this; //Field offset: 0x0
		public T reference; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass27_0`1() { }

		internal void <SubscribeReusable>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0`2
	{
		public NetPacketProcessor <>4__this; //Field offset: 0x0
		public T reference; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass28_0`2() { }

		internal void <SubscribeReusable>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0`2
	{
		public Func packetConstructor; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass29_0`2() { }

		internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0`1
	{
		public Func packetConstructor; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass30_0`1() { }

		internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0`2
	{
		public T reference; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass31_0`2() { }

		internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0`1
	{
		public T reference; //Field offset: 0x0
		public Action onReceive; //Field offset: 0x0

		public <>c__DisplayClass32_0`1() { }

		internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData) { }

	}

	private static class HashCache`1
	{
		public static readonly ulong Id; //Field offset: 0x0

		private static HashCache`1() { }

	}

	internal sealed class SubscribeDelegate : MulticastDelegate
	{

		public SubscribeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetDataReader reader, object userData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NetDataReader reader, object userData) { }

	}

	private readonly NetSerializer _netSerializer; //Field offset: 0x10
	private readonly Dictionary _callbacks; //Field offset: 0x18
	private readonly NetDataWriter _netDataWriter; //Field offset: 0x20

	public NetPacketProcessor() { }

	public NetPacketProcessor(int maxStringLength) { }

	protected override SubscribeDelegate GetCallbackFromData(NetDataReader reader) { }

	protected override ulong GetHash() { }

	public void ReadAllPackets(NetDataReader reader) { }

	public void ReadAllPackets(NetDataReader reader, object userData) { }

	public void ReadPacket(NetDataReader reader, object userData) { }

	public void ReadPacket(NetDataReader reader) { }

	public void RegisterNestedType() { }

	public void RegisterNestedType(Action writeDelegate, Func readDelegate) { }

	public void RegisterNestedType(Func constructor) { }

	public bool RemoveSubscription() { }

	public void Send(NetManager manager, T packet, DeliveryMethod options) { }

	public void Send(NetPeer peer, T packet, DeliveryMethod options) { }

	public void SendNetSerializable(NetPeer peer, T packet, DeliveryMethod options) { }

	public void SendNetSerializable(NetManager manager, T packet, DeliveryMethod options) { }

	public void Subscribe(Action onReceive, Func packetConstructor) { }

	public void Subscribe(Action onReceive, Func packetConstructor) { }

	public void SubscribeNetSerializable(Action onReceive) { }

	public void SubscribeNetSerializable(Action onReceive, Func packetConstructor) { }

	public void SubscribeNetSerializable(Action onReceive, Func packetConstructor) { }

	public void SubscribeNetSerializable(Action onReceive) { }

	public void SubscribeReusable(Action onReceive) { }

	public void SubscribeReusable(Action onReceive) { }

	public byte[] Write(T packet) { }

	public void Write(NetDataWriter writer, T packet) { }

	protected override void WriteHash(NetDataWriter writer) { }

	public void WriteNetSerializable(NetDataWriter writer, T packet) { }

	public byte[] WriteNetSerializable(T packet) { }

}

