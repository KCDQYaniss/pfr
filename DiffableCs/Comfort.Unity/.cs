//Type is in global namespace

internal sealed class  : IConnection
{
	public sealed class 
	{
		private readonly  ; //Field offset: 0x10
		private readonly ConnectionPerformance ; //Field offset: 0x18
		private readonly  ; //Field offset: 0x20
		private Transceiver ; //Field offset: 0x28
		private Action ; //Field offset: 0x30
		[CompilerGenerated]
		private ConnectionState ; //Field offset: 0x38
		internal readonly SendBuffer ; //Field offset: 0x40
		internal readonly ReceiveBuffer ; //Field offset: 0x48
		private ArraySegment ; //Field offset: 0x50
		private int ; //Field offset: 0x60
		private ArraySegment ; //Field offset: 0x68
		private int ; //Field offset: 0x78
		private int ; //Field offset: 0x7C

		public IFrameIndexer 
		{
			 get { } //Length: 5
		}

		internal ConnectionState 
		{
			[CompilerGenerated]
			internal get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		internal IConnection 
		{
			internal get { } //Length: 5
		}

		internal Transceiver 
		{
			internal get { } //Length: 5
			internal set { } //Length: 91
		}

		internal Action 
		{
			internal get { } //Length: 76
		}

		public (long , string , Func , ConnectionPerformance ) { }

		public IFrameIndexer get_() { }

		[CompilerGenerated]
		internal ConnectionState get_() { }

		internal IConnection get_() { }

		internal Transceiver get_() { }

		internal Action get_() { }

		[CompilerGenerated]
		private void set_(ConnectionState value) { }

		internal void set_(Transceiver value) { }

		internal void (Action ) { }

		internal void (ErrorCode ) { }

		internal int (ref ArraySegment ) { }

		internal int (ref ArraySegment ) { }

		internal void () { }

		private int (ref ArraySegment ) { }

		private void (int ) { }

		private void (ErrorCode ) { }

		internal void () { }

		private int (ref ArraySegment , Transceiver ) { }

		private int (byte[] , int , int ) { }

		internal void (ErrorCode ) { }

		internal void (ErrorCode ) { }

		internal void (EventHandler ) { }

	}

	public sealed class 
	{
		private abstract class 
		{

			internal abstract Delegate 
			{
				internal get { } //Length: 0
			}

			protected () { }

			internal abstract Delegate get_() { }

			internal override void (object , ConnectionLostedEventArgs ) { }

			internal override void (object , ConnectionRestoredEventArgs ) { }

			internal override void (object , ConnectionClosingEventArgs ) { }

			internal override void (object , ConnectionClosedEventArgs ) { }

		}

		private sealed class  : 
		{
			private readonly EventHandler ; //Field offset: 0x10

			internal virtual Delegate 
			{
				internal get { } //Length: 5
			}

			internal (EventHandler ) { }

			internal virtual Delegate get_() { }

			internal virtual void (object , ConnectionLostedEventArgs ) { }

		}

		private sealed class  : 
		{
			private readonly EventHandler ; //Field offset: 0x10

			internal virtual Delegate 
			{
				internal get { } //Length: 5
			}

			internal (EventHandler ) { }

			internal virtual Delegate get_() { }

			internal virtual void (object , ConnectionRestoredEventArgs ) { }

		}

		private sealed class  : 
		{
			private readonly EventHandler ; //Field offset: 0x10

			internal virtual Delegate 
			{
				internal get { } //Length: 5
			}

			internal (EventHandler ) { }

			internal virtual Delegate get_() { }

			internal virtual void (object , ConnectionClosingEventArgs ) { }

		}

		private sealed class  : 
		{
			private readonly EventHandler ; //Field offset: 0x10

			internal virtual Delegate 
			{
				internal get { } //Length: 5
			}

			internal (EventHandler ) { }

			internal virtual Delegate get_() { }

			internal virtual void (object , ConnectionClosedEventArgs ) { }

		}

		[CompilerGenerated]
		private sealed class 
		{
			public Delegate ; //Field offset: 0x10

			public () { }

			internal bool ( ) { }

		}

		private readonly IConnection ; //Field offset: 0x10
		private readonly List ; //Field offset: 0x18

		internal (IConnection ) { }

		internal void (EventHandler ) { }

		internal void (EventHandler ) { }

		internal void (EventHandler ) { }

		internal void (EventHandler ) { }

		internal void (Delegate ) { }

		internal void (EventHandler ) { }

		internal void (ErrorCode ) { }

		internal void (ErrorCode ) { }

		internal void (ErrorCode ) { }

		internal void (ErrorCode ) { }

	}

	private const int  = 34; //Field offset: 0x0
	public const string  = ".E.1"; //Field offset: 0x0
	private readonly  ; //Field offset: 0x10
	private readonly long ; //Field offset: 0x18
	private readonly string ; //Field offset: 0x20
	private readonly  ; //Field offset: 0x28
	[CompilerGenerated]
	private TimeSpan ; //Field offset: 0x30
	private DateTime ; //Field offset: 0x38
	private DateTime ; //Field offset: 0x40

	private override event EventHandler Comfort.Net.IConnection.ClosedEvent
	{
		private add { } //Length: 30
		private remove { } //Length: 30
	}

	private override event EventHandler Comfort.Net.IConnection.ClosingEvent
	{
		private add { } //Length: 30
		private remove { } //Length: 30
	}

	private override event EventHandler Comfort.Net.IConnection.LostedEvent
	{
		private add { } //Length: 30
		private remove { } //Length: 30
	}

	private override event EventHandler Comfort.Net.IConnection.RestoredEvent
	{
		private add { } //Length: 30
		private remove { } //Length: 30
	}

	public override string ClientId
	{
		 get { } //Length: 5
	}

	private override Transceiver Comfort.Net.IConnection.Receiver
	{
		private get { } //Length: 27
		private set { } //Length: 113
	}

	private override ConnectionState Comfort.Net.IConnection.State
	{
		private get { } //Length: 26
	}

	public override IFrameIndexer FrameIndexer
	{
		 get { } //Length: 27
	}

	public override long Id
	{
		 get { } //Length: 5
	}

	public private override TimeSpan Ping
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private DateTime 
	{
		private get { } //Length: 117
		private set { } //Length: 96
	}

	private ( , long , string ) { }

	private override void Comfort.Net.IConnection.add_ClosedEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.add_ClosingEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.add_LostedEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.add_RestoredEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.Close(ErrorCode errorCode) { }

	private override Transceiver Comfort.Net.IConnection.get_Receiver() { }

	private override ConnectionState Comfort.Net.IConnection.get_State() { }

	private override void Comfort.Net.IConnection.remove_ClosedEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.remove_ClosingEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.remove_LostedEvent(EventHandler value) { }

	private override void Comfort.Net.IConnection.remove_RestoredEvent(EventHandler value) { }

	private override int Comfort.Net.IConnection.Send(ref ArraySegment segment) { }

	private override int Comfort.Net.IConnection.SendUnreliable(ref ArraySegment segment) { }

	private override void Comfort.Net.IConnection.set_Receiver(Transceiver value) { }

	public override string get_ClientId() { }

	public override IFrameIndexer get_FrameIndexer() { }

	public override long get_Id() { }

	[CompilerGenerated]
	public override TimeSpan get_Ping() { }

	private DateTime get_() { }

	[CompilerGenerated]
	private void set_Ping(TimeSpan value) { }

	private void set_(DateTime value) { }

}

