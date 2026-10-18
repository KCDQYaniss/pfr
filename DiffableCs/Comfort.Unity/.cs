//Type is in global namespace

internal sealed class  : ITransport
{
	private readonly SocketAsyncEventArgs ; //Field offset: 0x10
	private readonly SocketAsyncEventArgs ; //Field offset: 0x18
	private readonly Action ; //Field offset: 0x20
	private Socket ; //Field offset: 0x28
	private Action ; //Field offset: 0x30
	private Action ; //Field offset: 0x38
	private TransportInfo ; //Field offset: 0x40

	public override TransportInfo Info
	{
		 get { } //Length: 11
	}

	internal (Action ) { }

	public override bool CheckConnect() { }

	public override void Close() { }

	public override void Destroy() { }

	public override TransportInfo get_Info() { }

	public override bool Receive(ref ArraySegment segment, Action callback) { }

	public override bool Send(ref ArraySegment segment, Action callback) { }

	public void (Socket ) { }

	private bool () { }

	private void (object , SocketAsyncEventArgs ) { }

	private bool () { }

	private void (object , SocketAsyncEventArgs ) { }

}

