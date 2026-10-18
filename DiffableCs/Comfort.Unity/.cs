//Type is in global namespace

internal sealed class  : , ICommunicator
{
	private sealed class  : IPipe
	{
		private readonly  ; //Field offset: 0x10

		public override bool Closed
		{
			 get { } //Length: 31
		}

		public override ICommunicationErrorHandler ErrorHandler
		{
			 get { } //Length: 5
		}

		internal ( ) { }

		public override void Close(ErrorCode errorCode) { }

		private override CommunicationId Comfort.Communication.Core.IPipe.Add(WrappedObject wrappedObject) { }

		private override BinaryWriter Comfort.Communication.Core.IPipe.CreateWriter(bool unreliable) { }

		public override bool get_Closed() { }

		public override ICommunicationErrorHandler get_ErrorHandler() { }

	}

	public sealed class 
	{
		private readonly object ; //Field offset: 0x10
		private DataPacketWriter ; //Field offset: 0x18

		public () { }

		internal void (Transceiver ) { }

		internal void () { }

		internal BinaryWriter () { }

		private void () { }

	}

	private readonly object ; //Field offset: 0x18
	private readonly  ; //Field offset: 0x20
	private readonly  ; //Field offset: 0x28
	private readonly  ; //Field offset: 0x30
	private readonly  ; //Field offset: 0x38
	private IConnection ; //Field offset: 0x40

	public override IConnection Connection
	{
		 get { } //Length: 5
		 set { } //Length: 222
	}

	internal ( , Action  = null) { }

	private override long Comfort.Communication.ICommunicator.Add(T obj) { }

	private override long Comfort.Communication.ICommunicator.AddUnreliable(T obj) { }

	private override bool Comfort.Communication.ICommunicator.Remove() { }

	private override bool Comfort.Communication.ICommunicator.Remove(T obj) { }

	private override bool Comfort.Communication.ICommunicator.Remove(long index) { }

	private override bool Comfort.Communication.ICommunicator.TryRemove(T obj) { }

	private override bool Comfort.Communication.ICommunicator.TryRemove(long index) { }

	private override bool Comfort.Communication.ICommunicator.TryRemove() { }

	public override T Get() { }

	public override T Get(long index) { }

	public override IConnection get_Connection() { }

	public override void set_Connection(IConnection value) { }

	public override T TryGet() { }

	public override T TryGet(long index) { }

	private bool (Type , long ) { }

	private bool (Type , long ) { }

	private void (IConnection ) { }

	private void (object , ConnectionClosedEventArgs ) { }

	private void (ErrorCode ) { }

}

