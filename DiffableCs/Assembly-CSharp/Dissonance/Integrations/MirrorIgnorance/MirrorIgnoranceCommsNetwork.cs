namespace Dissonance.Integrations.MirrorIgnorance;

[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Basics/Quick-Start-MirrorIgnorance/")]
[Obfuscation(Exclude = True, ApplyToMembers = True)]
public class MirrorIgnoranceCommsNetwork : BaseCommsNetwork
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal byte[] <.ctor>b__13_0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__NullMessageReceivedHandler; //Field offset: 0x0

	}

	public short TypeCode; //Field offset: 0xD0
	public bool Activated; //Field offset: 0xD2
	private readonly ConcurrentPool _loopbackBuffers; //Field offset: 0xD8
	private readonly List _loopbackQueue; //Field offset: 0xE0

	public MirrorIgnoranceCommsNetwork() { }

	internal int CopyPacketToNetworkWriter(ArraySegment packet, NetworkWriter writer) { }

	internal ArraySegment CopyToArraySegment(NetworkReader msg, ArraySegment segment) { }

	protected virtual MirrorIgnoranceClient CreateClient(Unit details) { }

	protected virtual MirrorIgnoranceServer CreateServer(Unit details) { }

	protected virtual void Initialize() { }

	internal static void NullMessageReceivedHandler(NetworkMessage netmsg) { }

	internal bool PreprocessPacketToClient(ArraySegment packet, MirrorConn destination) { }

	internal bool PreprocessPacketToServer(ArraySegment packet) { }

	protected virtual void Update() { }

}

