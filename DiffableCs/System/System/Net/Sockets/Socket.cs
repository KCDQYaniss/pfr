namespace System.Net.Sockets;

public class Socket : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static AsyncCallback <>9__10_0; //Field offset: 0x8
		public static Func <>9__14_0; //Field offset: 0x10
		public static Func <>9__14_1; //Field offset: 0x18
		public static AsyncCallback <>9__15_0; //Field offset: 0x20
		public static AsyncCallback <>9__15_1; //Field offset: 0x28
		public static Func <>9__22_0; //Field offset: 0x30
		public static Func <>9__22_1; //Field offset: 0x38
		public static AsyncCallback <>9__23_0; //Field offset: 0x40
		public static AsyncCallback <>9__23_1; //Field offset: 0x48
		public static IOAsyncCallback <>9__295_0; //Field offset: 0x50
		public static IOAsyncCallback <>9__297_0; //Field offset: 0x58

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

		internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

		internal void <.cctor>b__367_10(IAsyncResult ares) { }

		internal void <.cctor>b__367_11(IOAsyncResult ares) { }

		internal void <.cctor>b__367_12(IOAsyncResult ares) { }

		internal void <.cctor>b__367_13(IAsyncResult ares) { }

		internal void <.cctor>b__367_14(IOAsyncResult ares) { }

		internal void <.cctor>b__367_15(IAsyncResult ares) { }

		internal void <.cctor>b__367_16(IOAsyncResult ares) { }

		internal void <.cctor>b__367_17(IAsyncResult ares) { }

		internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

		internal void <.cctor>b__367_3(IAsyncResult ares) { }

		internal void <.cctor>b__367_4(IOAsyncResult ares) { }

		internal void <.cctor>b__367_5(IOAsyncResult ares) { }

		internal void <.cctor>b__367_6(IAsyncResult ares) { }

		internal void <.cctor>b__367_7(IOAsyncResult ares) { }

		internal void <.cctor>b__367_8(IAsyncResult ares) { }

		internal void <.cctor>b__367_9(IOAsyncResult ares) { }

		internal void <BeginSend>b__297_0(IOAsyncResult s) { }

		internal void <ConnectAsync>b__10_0(IAsyncResult iar) { }

		internal CachedEventArgs <ReceiveAsync>b__14_0() { }

		internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

		internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

		internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

		internal void <SendAsync>b__295_0(IOAsyncResult s) { }

		internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

		internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

		internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

		internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass240_0
	{
		public SocketAsyncResult sockares; //Field offset: 0x10

		public <>c__DisplayClass240_0() { }

		internal void <BeginConnect>b__0(Task t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass298_0
	{
		public int sent_so_far; //Field offset: 0x10

		public <>c__DisplayClass298_0() { }

		internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass355_0
	{
		public Socket <>4__this; //Field offset: 0x10
		public IOSelectorJob job; //Field offset: 0x18
		public IntPtr handle; //Field offset: 0x20

		public <>c__DisplayClass355_0() { }

		internal void <QueueIOSelectorJob>b__0(Task t) { }

	}

	public sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static ContextCallback <>9__14_0; //Field offset: 0x8
			public static SendOrPostCallback <>9__20_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal void <.cctor>b__27_0(object state) { }

			internal void <.cctor>b__27_1(object state) { }

			internal void <InvokeContinuation>b__20_0(object s) { }

			internal void <OnCompleted>b__14_0(object runState) { }

		}

		internal static readonly AwaitableSocketAsyncEventArgs Reserved; //Field offset: 0x0
		private static readonly Action s_completedSentinel; //Field offset: 0x8
		private static readonly Action s_availableSentinel; //Field offset: 0x10
		private Action _continuation; //Field offset: 0x90
		private ExecutionContext _executionContext; //Field offset: 0x98
		private object _scheduler; //Field offset: 0xA0
		private short _token; //Field offset: 0xA8
		[CompilerGenerated]
		private bool <WrapExceptionsInIOExceptions>k__BackingField; //Field offset: 0xAA

		public bool WrapExceptionsInIOExceptions
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		private static AwaitableSocketAsyncEventArgs() { }

		public AwaitableSocketAsyncEventArgs() { }

		private Exception CreateException(SocketError error) { }

		[CompilerGenerated]
		public bool get_WrapExceptionsInIOExceptions() { }

		public override int GetResult(short token) { }

		public override ValueTaskSourceStatus GetStatus(short token) { }

		private void InvokeContinuation(Action continuation, object state, bool forceAsync) { }

		protected virtual void OnCompleted(SocketAsyncEventArgs _) { }

		public override void OnCompleted(Action continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

		public ValueTask ReceiveAsync(Socket socket) { }

		private void Release() { }

		public bool Reserve() { }

		public ValueTask SendAsyncForNetworkStream(Socket socket) { }

		[CompilerGenerated]
		public void set_WrapExceptionsInIOExceptions(bool value) { }

		private override void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

		private void ThrowException(SocketError error) { }

		private void ThrowIncorrectTokenException() { }

		private void ThrowMultipleContinuationsException() { }

	}

	private sealed class CachedEventArgs
	{
		public TaskSocketAsyncEventArgs TaskAccept; //Field offset: 0x10
		public Int32TaskSocketAsyncEventArgs TaskReceive; //Field offset: 0x18
		public Int32TaskSocketAsyncEventArgs TaskSend; //Field offset: 0x20
		public AwaitableSocketAsyncEventArgs ValueTaskReceive; //Field offset: 0x28
		public AwaitableSocketAsyncEventArgs ValueTaskSend; //Field offset: 0x30

		public CachedEventArgs() { }

	}

	private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs
	{
		internal bool _wrapExceptionsInIOExceptions; //Field offset: 0xB0

		public Int32TaskSocketAsyncEventArgs() { }

	}

	private class TaskSocketAsyncEventArgs`1 : SocketAsyncEventArgs
	{
		internal AsyncTaskMethodBuilder _builder; //Field offset: 0x0
		internal bool _accessed; //Field offset: 0x0

		internal TaskSocketAsyncEventArgs`1() { }

		internal AsyncTaskMethodBuilder GetCompletionResponsibility(out bool responsibleForReturningToPool) { }

	}

	private struct WSABUF
	{
		public int len; //Field offset: 0x0
		public IntPtr buf; //Field offset: 0x8

	}

	private static readonly EventHandler AcceptCompletedHandler; //Field offset: 0x0
	private static readonly EventHandler ReceiveCompletedHandler; //Field offset: 0x8
	private static readonly EventHandler SendCompletedHandler; //Field offset: 0x10
	private static readonly TaskSocketAsyncEventArgs s_rentedSocketSentinel; //Field offset: 0x18
	private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; //Field offset: 0x20
	private static readonly Task s_zeroTask; //Field offset: 0x28
	private static object s_InternalSyncObject; //Field offset: 0x30
	internal static bool s_SupportsIPv4; //Field offset: 0x38
	internal static bool s_SupportsIPv6; //Field offset: 0x39
	internal static bool s_OSSupportsIPv6; //Field offset: 0x3A
	internal static bool s_Initialized; //Field offset: 0x3B
	private static bool s_LoggingEnabled; //Field offset: 0x3C
	private static AsyncCallback AcceptAsyncCallback; //Field offset: 0x40
	private static IOAsyncCallback BeginAcceptCallback; //Field offset: 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; //Field offset: 0x50
	private static AsyncCallback ConnectAsyncCallback; //Field offset: 0x58
	private static IOAsyncCallback BeginConnectCallback; //Field offset: 0x60
	private static AsyncCallback DisconnectAsyncCallback; //Field offset: 0x68
	private static IOAsyncCallback BeginDisconnectCallback; //Field offset: 0x70
	private static AsyncCallback ReceiveAsyncCallback; //Field offset: 0x78
	private static IOAsyncCallback BeginReceiveCallback; //Field offset: 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; //Field offset: 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; //Field offset: 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; //Field offset: 0x98
	private static AsyncCallback SendAsyncCallback; //Field offset: 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; //Field offset: 0xA8
	private static AsyncCallback SendToAsyncCallback; //Field offset: 0xB0
	private CachedEventArgs _cachedTaskEventArgs; //Field offset: 0x10
	private bool is_closed; //Field offset: 0x18
	private bool is_listening; //Field offset: 0x19
	private int linger_timeout; //Field offset: 0x1C
	private AddressFamily addressFamily; //Field offset: 0x20
	private SocketType socketType; //Field offset: 0x24
	private ProtocolType protocolType; //Field offset: 0x28
	internal SafeSocketHandle m_Handle; //Field offset: 0x30
	internal EndPoint seed_endpoint; //Field offset: 0x38
	internal SemaphoreSlim ReadSem; //Field offset: 0x40
	internal SemaphoreSlim WriteSem; //Field offset: 0x48
	internal bool is_blocking; //Field offset: 0x50
	internal bool is_bound; //Field offset: 0x51
	internal bool is_connected; //Field offset: 0x52
	private int m_IntCleanedUp; //Field offset: 0x54
	internal bool connect_in_progress; //Field offset: 0x58

	public AddressFamily AddressFamily
	{
		 get { } //Length: 4
	}

	public int Available
	{
		 get { } //Length: 175
	}

	public bool Blocking
	{
		 get { } //Length: 5
		 set { } //Length: 204
	}

	internal bool CleanedUp
	{
		internal get { } //Length: 8
	}

	public bool Connected
	{
		 get { } //Length: 5
	}

	public bool DontFragment
	{
		 set { } //Length: 146
	}

	public bool DualMode
	{
		 get { } //Length: 224
		 set { } //Length: 153
	}

	public bool EnableBroadcast
	{
		 set { } //Length: 133
	}

	public bool ExclusiveAddressUse
	{
		 set { } //Length: 149
	}

	internal static int FamilyHint
	{
		internal get { } //Length: 313
	}

	public IntPtr Handle
	{
		 get { } //Length: 27
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 301
	}

	public bool IsBound
	{
		 get { } //Length: 5
	}

	private bool IsDualMode
	{
		private get { } //Length: 238
	}

	public EndPoint LocalEndPoint
	{
		 get { } //Length: 251
	}

	public bool NoDelay
	{
		 set { } //Length: 133
	}

	public static bool OSSupportsIPv4
	{
		 get { } //Length: 93
	}

	public static bool OSSupportsIPv6
	{
		 get { } //Length: 93
	}

	public ProtocolType ProtocolType
	{
		 get { } //Length: 4
	}

	public int ReceiveBufferSize
	{
		 get { } //Length: 115
		 set { } //Length: 123
	}

	public int ReceiveTimeout
	{
		 set { } //Length: 131
	}

	public EndPoint RemoteEndPoint
	{
		 get { } //Length: 257
	}

	public int SendBufferSize
	{
		 get { } //Length: 115
		 set { } //Length: 123
	}

	public int SendTimeout
	{
		 set { } //Length: 131
	}

	public SocketType SocketType
	{
		 get { } //Length: 4
	}

	public short Ttl
	{
		 get { } //Length: 285
		 set { } //Length: 267
	}

	private static Socket() { }

	internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	public Socket Accept() { }

	internal void Accept(Socket acceptSocket) { }

	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	private static int Available_icall(IntPtr socket, out int error) { }

	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) { }

	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	public void Bind(EndPoint localEP) { }

	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	internal static void cancel_blocking_socket_operation(Thread thread) { }

	internal bool CanTryAddressFamily(AddressFamily family) { }

	public void Close(int timeout) { }

	public void Close() { }

	internal static void Close_icall(IntPtr socket, out int error) { }

	private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs saea) { }

	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	public void Connect(IPAddress address, int port) { }

	public void Connect(EndPoint remoteEP) { }

	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	public bool ConnectAsync(SocketAsyncEventArgs e) { }

	internal Task ConnectAsync(IPAddress address, int port) { }

	public void Disconnect(bool reuseSocket) { }

	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	public Socket EndAccept(IAsyncResult asyncResult) { }

	public void EndConnect(IAsyncResult asyncResult) { }

	public void EndDisconnect(IAsyncResult asyncResult) { }

	public int EndReceive(IAsyncResult asyncResult) { }

	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	public int EndSend(IAsyncResult asyncResult) { }

	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	public int EndSendTo(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public AddressFamily get_AddressFamily() { }

	public int get_Available() { }

	public bool get_Blocking() { }

	internal bool get_CleanedUp() { }

	public bool get_Connected() { }

	public bool get_DualMode() { }

	internal static int get_FamilyHint() { }

	public IntPtr get_Handle() { }

	private static object get_InternalSyncObject() { }

	public bool get_IsBound() { }

	private bool get_IsDualMode() { }

	public EndPoint get_LocalEndPoint() { }

	public static bool get_OSSupportsIPv4() { }

	public static bool get_OSSupportsIPv6() { }

	public ProtocolType get_ProtocolType() { }

	public int get_ReceiveBufferSize() { }

	public EndPoint get_RemoteEndPoint() { }

	public int get_SendBufferSize() { }

	public SocketType get_SocketType() { }

	public short get_Ttl() { }

	private bool GetCheckedIPs(SocketAsyncEventArgs e, out IPAddress[] addresses) { }

	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false) { }

	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	internal static void InitializeSockets() { }

	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	internal void InternalShutdown(SocketShutdown how) { }

	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	private void Linger(IntPtr handle) { }

	public void Listen(int backlog) { }

	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	public bool Poll(int microSeconds, SelectMode mode) { }

	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	[CLSCompliant(False)]
	public int Receive(IList buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Receive(IList buffers, SocketFlags socketFlags) { }

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Receive(Span buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	private int Receive(Memory buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	internal ValueTask ReceiveAsync(Memory buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	private Task ReceiveAsyncApm(Memory buffer, SocketFlags socketFlags) { }

	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	private int ReceiveFrom(Memory buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP) { }

	private static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs saea) { }

	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	public int Send(IList buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Send(IList buffers, SocketFlags socketFlags) { }

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	public int Send(ReadOnlySpan buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	public bool SendAsync(SocketAsyncEventArgs e) { }

	private Task SendAsyncApm(ReadOnlyMemory buffer, SocketFlags socketFlags) { }

	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	private static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	public void set_Blocking(bool value) { }

	public void set_DontFragment(bool value) { }

	public void set_DualMode(bool value) { }

	public void set_EnableBroadcast(bool value) { }

	public void set_ExclusiveAddressUse(bool value) { }

	public void set_NoDelay(bool value) { }

	public void set_ReceiveBufferSize(int value) { }

	public void set_ReceiveTimeout(int value) { }

	public void set_SendBufferSize(int value) { }

	public void set_SendTimeout(int value) { }

	public void set_Ttl(short value) { }

	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	public void Shutdown(SocketShutdown how) { }

	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	private void SocketDefaults() { }

	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	private void ThrowIfBufferNull(byte[] buffer) { }

	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	private void ThrowIfDisposedAndClosed() { }

	private void ThrowIfUdp() { }

	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

}

