namespace UnityEngine;

[NativeHeader("Runtime/Export/Networking/UdpSocket.bindings.h")]
public sealed class UdpSocket
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public SocketAddress socketAddress; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal byte <SendTo>b__0(int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public SocketAddress socketAddress; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal byte <ReceiveFrom>b__0(int i) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	public int ReceiveBufferSize
	{
		 set { } //Length: 48
	}

	public int SendBufferSize
	{
		 set { } //Length: 48
	}

	public UdpSocket() { }

	public bool Bind(IPEndPoint localEP) { }

	public void Close() { }

	protected virtual void Finalize() { }

	[FreeFunction("UdpSocket_Bindings::Close", IsThreadSafe = True)]
	private static void Internal_Close(IntPtr ptr) { }

	[FreeFunction("UdpSocket_Bindings::Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create() { }

	[FreeFunction("UdpSocket_Bindings::Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("UdpSocket_Bindings::IOControl", IsThreadSafe = True)]
	private static int Internal_IOControl(IntPtr ptr, int ioControlCode, IntPtr optionInValue, int optionInSize, IntPtr optionOutValue, int optionOutSize, out int bytesReturned) { }

	[FreeFunction("UdpSocket_Bindings::Open", IsThreadSafe = True)]
	private static bool Internal_Open(IntPtr ptr, string ip, int port) { }

	[FreeFunction("UdpSocket_Bindings::Poll_Recv", IsThreadSafe = True)]
	private static bool Internal_Poll_Recv(IntPtr ptr, int microSeconds) { }

	[FreeFunction("UdpSocket_Bindings::Recv", IsThreadSafe = True)]
	private static int Internal_Recv(IntPtr ptr, byte* data, int offset, int size, int flags, byte* addr, ref int addrLen) { }

	[FreeFunction("UdpSocket_Bindings::Send", IsThreadSafe = True)]
	private static int Internal_Send(IntPtr ptr, byte* data, int offset, int size, int flags, byte* addr, int addrLen) { }

	[FreeFunction("UdpSocket_Bindings::SetSocketOption", IsThreadSafe = True)]
	private static int Internal_SetSocketOption(IntPtr ptr, int level, int option, int value) { }

	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	public bool Poll(int microSeconds, SelectMode mode) { }

	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP) { }

	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	public void set_ReceiveBufferSize(int value) { }

	public void set_SendBufferSize(int value) { }

}

