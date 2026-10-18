//Type is in global namespace

internal abstract class 
{
	public sealed class 
	{
		private readonly  ; //Field offset: 0x10

		internal ErrorCode 
		{
			internal get { } //Length: 26
			internal set { } //Length: 26
		}

		internal IDispatchingScheduler 
		{
			internal get { } //Length: 27
		}

		internal ITransport 
		{
			internal get { } //Length: 42
		}

		internal ( ) { }

		internal ErrorCode get_() { }

		internal IDispatchingScheduler get_() { }

		internal ITransport get_() { }

		internal void set_(ErrorCode value) { }

		internal void () { }

		internal void () { }

		internal void (object , ConnectionClosingEventArgs ) { }

		internal void () { }

	}

	private readonly  ; //Field offset: 0x10
	private readonly IDispatchingScheduler ; //Field offset: 0x18
	private readonly List ; //Field offset: 0x20
	private Status ; //Field offset: 0x28
	[CompilerGenerated]
	private ErrorCode ; //Field offset: 0x2C
	[CompilerGenerated]
	private bool ; //Field offset: 0x30

	public override event Action StatusChangedEvent
	{
		 add { } //Length: 152
		 remove { } //Length: 88
	}

	public private override bool ConnectionCached
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override ErrorCode ErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override Status Status
	{
		 get { } //Length: 4
		 set { } //Length: 317
	}

	protected IDispatchingScheduler 
	{
		 get { } //Length: 5
	}

	protected  
	{
		 get { } //Length: 5
	}

	protected abstract ITransport 
	{
		 get { } //Length: 0
	}

	protected abstract IConnector 
	{
		 get { } //Length: 0
	}

	protected (IDispatchingScheduler , Func ) { }

	public override void add_StatusChangedEvent(Action value) { }

	public override void Destroy() { }

	public override void Disconnect() { }

	[CompilerGenerated]
	public override bool get_ConnectionCached() { }

	[CompilerGenerated]
	public override ErrorCode get_ErrorCode() { }

	public override Status get_Status() { }

	protected IDispatchingScheduler get_() { }

	protected  get_() { }

	protected abstract ITransport get_() { }

	protected abstract IConnector get_() { }

	public override void Reconnect() { }

	public override void remove_StatusChangedEvent(Action value) { }

	[CompilerGenerated]
	private void set_ConnectionCached(bool value) { }

	[CompilerGenerated]
	protected void set_ErrorCode(ErrorCode value) { }

	protected void set_Status(Status value) { }

	private void (StatusChangedEventArgs ) { }

	[CompilerGenerated]
	private void () { }

	[CompilerGenerated]
	private void () { }

}

