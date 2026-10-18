namespace System.Net.NetworkInformation;

[MonoTODO("IPv6 support is missing")]
public class Ping : Component, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public Ping <>4__this; //Field offset: 0x10
		public IPAddress address; //Field offset: 0x18
		public int timeout; //Field offset: 0x20
		public byte[] buffer; //Field offset: 0x28
		public PingOptions options; //Field offset: 0x30

		public <>c__DisplayClass50_0() { }

		internal PingReply <SendPingAsync>b__0() { }

		internal void <SendPingAsync>b__1(Task t) { }

	}

	private struct cap_user_data_t
	{
		public uint effective; //Field offset: 0x0
		public uint permitted; //Field offset: 0x4
		public uint inheritable; //Field offset: 0x8

	}

	private struct cap_user_header_t
	{
		public uint version; //Field offset: 0x0
		public int pid; //Field offset: 0x4

	}

	private class IcmpMessage
	{
		private byte[] bytes; //Field offset: 0x10

		public byte Code
		{
			 get { } //Length: 39
		}

		public byte[] Data
		{
			 get { } //Length: 137
		}

		public ushort Identifier
		{
			 get { } //Length: 60
		}

		public IPStatus IPStatus
		{
			 get { } //Length: 204
		}

		public byte Type
		{
			 get { } //Length: 39
		}

		public IcmpMessage(byte[] bytes, int offset, int size) { }

		public IcmpMessage(byte type, byte code, ushort identifier, ushort sequence, byte[] data) { }

		private static ushort ComputeChecksum(byte[] data) { }

		public byte get_Code() { }

		public byte[] get_Data() { }

		public ushort get_Identifier() { }

		public IPStatus get_IPStatus() { }

		public byte get_Type() { }

		public byte[] GetBytes() { }

	}

	private static readonly string[] PingBinPaths; //Field offset: 0x0
	private static readonly string PingBinPath; //Field offset: 0x8
	private static bool canSendPrivileged; //Field offset: 0x10
	private static readonly byte[] default_buffer; //Field offset: 0x18
	private ushort identifier; //Field offset: 0x28
	private BackgroundWorker worker; //Field offset: 0x30
	private object user_async_state; //Field offset: 0x38
	private CancellationTokenSource cts; //Field offset: 0x40
	[CompilerGenerated]
	private PingCompletedEventHandler PingCompleted; //Field offset: 0x48

	private static Ping() { }

	public Ping() { }

	private string BuildPingArgs(IPAddress address, int timeout, PingOptions options) { }

	private static int capget(ref cap_user_header_t header, ref cap_user_data_t data) { }

	private static void CheckLinuxCapabilities() { }

	protected void OnPingCompleted(PingCompletedEventArgs e) { }

	public PingReply Send(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	public void SendAsyncCancel() { }

	public Task SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer) { }

	public Task SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options) { }

	public Task SendPingAsync(string hostNameOrAddress, int timeout) { }

	public Task SendPingAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	private PingReply SendPrivileged(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	private PingReply SendUnprivileged(IPAddress address, int timeout, byte[] buffer, PingOptions options) { }

	private override void System.IDisposable.Dispose() { }

}

