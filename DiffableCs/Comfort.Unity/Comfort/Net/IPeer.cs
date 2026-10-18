namespace Comfort.Net;

public interface IPeer
{

	public event Action StatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool ConnectionCached
	{
		 get { } //Length: 0
	}

	public ErrorCode ErrorCode
	{
		 get { } //Length: 0
	}

	public Status Status
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_StatusChangedEvent(Action value) { }

	public void Destroy() { }

	public bool get_ConnectionCached() { }

	public ErrorCode get_ErrorCode() { }

	public Status get_Status() { }

	[CompilerGenerated]
	public void remove_StatusChangedEvent(Action value) { }

}

