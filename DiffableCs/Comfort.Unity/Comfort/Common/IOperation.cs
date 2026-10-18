namespace Comfort.Common;

public interface IOperation : IEnumerator
{

	public event Action CompletedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action FailedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action SucceedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool Completed
	{
		 get { } //Length: 0
	}

	public string Error
	{
		 get { } //Length: 0
	}

	public bool Failed
	{
		 get { } //Length: 0
	}

	public bool Succeed
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_CompletedEvent(Action value) { }

	[CompilerGenerated]
	public void add_FailedEvent(Action value) { }

	[CompilerGenerated]
	public void add_SucceedEvent(Action value) { }

	public bool get_Completed() { }

	public string get_Error() { }

	public bool get_Failed() { }

	public bool get_Succeed() { }

	[CompilerGenerated]
	public void remove_CompletedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_FailedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_SucceedEvent(Action value) { }

}

