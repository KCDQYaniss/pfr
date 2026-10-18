//Type is in global namespace

internal sealed class  : , ITcpClient, IClient, IPeer
{
	[CompilerGenerated]
	private sealed class 
	{
		public string ; //Field offset: 0x10
		public string ; //Field offset: 0x18
		public  ; //Field offset: 0x20

		public () { }

		internal void (Socket ) { }

	}

	private readonly  ; //Field offset: 0x38
	private readonly  ; //Field offset: 0x40
	private readonly bool ; //Field offset: 0x48

	protected virtual ITransport 
	{
		 get { } //Length: 5
	}

	protected virtual IConnector 
	{
		 get { } //Length: 5
	}

	public (IDispatchingScheduler , Func , NetClientMonitor , bool ) { }

	public override void Connect(string connectionPoint, string clientId, string versionId) { }

	public override void Connect(IPEndPoint endPoint, string clientId, string versionId) { }

	public override void Connect(IPEndPoint endPoint, string clientId, string versionId, TimeSpan connectTimeout) { }

	public override void Connect(string connectionPoint, string clientId, string versionId, TimeSpan connectTimeout, TimeSpan reconnectTimeout) { }

	public override void Connect(IPEndPoint endPoint, string clientId, string versionId, TimeSpan connectTimeout, TimeSpan reconnectTimeout) { }

	protected virtual ITransport get_() { }

	protected virtual IConnector get_() { }

	private void (Socket , string , string ) { }

}

