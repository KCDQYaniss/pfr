namespace Comfort.Net;

public interface IConnection
{

	public event EventHandler ClosedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler ClosingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler LostedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler RestoredEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string ClientId
	{
		 get { } //Length: 0
	}

	public IFrameIndexer FrameIndexer
	{
		 get { } //Length: 0
	}

	public long Id
	{
		 get { } //Length: 0
	}

	public TimeSpan Ping
	{
		 get { } //Length: 0
	}

	public Transceiver Receiver
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ConnectionState State
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ClosedEvent(EventHandler value) { }

	[CompilerGenerated]
	public void add_ClosingEvent(EventHandler value) { }

	[CompilerGenerated]
	public void add_LostedEvent(EventHandler value) { }

	[CompilerGenerated]
	public void add_RestoredEvent(EventHandler value) { }

	public void Close(ErrorCode errorCode) { }

	public string get_ClientId() { }

	public IFrameIndexer get_FrameIndexer() { }

	public long get_Id() { }

	public TimeSpan get_Ping() { }

	public Transceiver get_Receiver() { }

	public ConnectionState get_State() { }

	[CompilerGenerated]
	public void remove_ClosedEvent(EventHandler value) { }

	[CompilerGenerated]
	public void remove_ClosingEvent(EventHandler value) { }

	[CompilerGenerated]
	public void remove_LostedEvent(EventHandler value) { }

	[CompilerGenerated]
	public void remove_RestoredEvent(EventHandler value) { }

	public int Send(ref ArraySegment segment) { }

	public int SendUnreliable(ref ArraySegment segment) { }

	public void set_Receiver(Transceiver value) { }

}

