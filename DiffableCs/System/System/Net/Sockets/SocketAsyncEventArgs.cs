namespace System.Net.Sockets;

public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	private bool disposed; //Field offset: 0x10
	internal int in_progress; //Field offset: 0x14
	private EndPoint remote_ep; //Field offset: 0x18
	private Socket current_socket; //Field offset: 0x20
	internal SocketAsyncResult socket_async_result; //Field offset: 0x28
	[CompilerGenerated]
	private Exception <ConnectByNameError>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <SendPacketsSendSize>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private object <UserToken>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private EventHandler Completed; //Field offset: 0x60
	private Memory _buffer; //Field offset: 0x68
	private int _offset; //Field offset: 0x78
	private int _count; //Field offset: 0x7C
	private bool _bufferIsExplicitArray; //Field offset: 0x80
	private IList _bufferList; //Field offset: 0x88

	public event EventHandler Completed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Socket AcceptSocket
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public IList BufferList
	{
		 get { } //Length: 8
	}

	public private int BytesTransferred
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private Exception ConnectByNameError
	{
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int Count
	{
		 get { } //Length: 4
	}

	internal Socket CurrentSocket
	{
		internal get { } //Length: 5
	}

	private SocketAsyncOperation LastOperation
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Memory MemoryBuffer
	{
		 get { } //Length: 11
	}

	public int Offset
	{
		 get { } //Length: 4
	}

	public EndPoint RemoteEndPoint
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	[MonoTODO("unused property")]
	public int SendPacketsSendSize
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SocketError SocketError
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SocketFlags SocketFlags
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public object UserToken
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public SocketAsyncEventArgs() { }

	internal SocketAsyncEventArgs(bool flowExecutionContext) { }

	[CompilerGenerated]
	public void add_Completed(EventHandler value) { }

	internal void Complete_internal() { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public Socket get_AcceptSocket() { }

	public IList get_BufferList() { }

	[CompilerGenerated]
	public int get_BytesTransferred() { }

	public int get_Count() { }

	internal Socket get_CurrentSocket() { }

	public Memory get_MemoryBuffer() { }

	public int get_Offset() { }

	public EndPoint get_RemoteEndPoint() { }

	[CompilerGenerated]
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	public object get_UserToken() { }

	protected override void OnCompleted(SocketAsyncEventArgs e) { }

	[CompilerGenerated]
	public void remove_Completed(EventHandler value) { }

	[CompilerGenerated]
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	private void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	private void set_ConnectByNameError(Exception value) { }

	[CompilerGenerated]
	private void set_LastOperation(SocketAsyncOperation value) { }

	public void set_RemoteEndPoint(EndPoint value) { }

	[CompilerGenerated]
	public void set_SendPacketsSendSize(int value) { }

	[CompilerGenerated]
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	public void set_SocketFlags(SocketFlags value) { }

	[CompilerGenerated]
	public void set_UserToken(object value) { }

	public void SetBuffer(byte[] buffer, int offset, int count) { }

	public void SetBuffer(Memory buffer) { }

	internal void SetBytesTransferred(int value) { }

	internal void SetConnectByNameError(Exception error) { }

	internal void SetCurrentSocket(Socket socket) { }

	internal void SetLastOperation(SocketAsyncOperation op) { }

}

