namespace Comfort.Common;

public abstract class AbstractOperation : IOperation, IEnumerator
{
	[CompilerGenerated]
	private Action ; //Field offset: 0x10
	[CompilerGenerated]
	private Action ; //Field offset: 0x18
	[CompilerGenerated]
	private Action ; //Field offset: 0x20

	public override event Action CompletedEvent
	{
		 add { } //Length: 90
		 remove { } //Length: 8
	}

	public override event Action FailedEvent
	{
		 add { } //Length: 90
		 remove { } //Length: 8
	}

	public override event Action SucceedEvent
	{
		 add { } //Length: 90
		 remove { } //Length: 8
	}

	private event Action 
	{
		[CompilerGenerated]
		private add { } //Length: 495
		[CompilerGenerated]
		private remove { } //Length: 494
	}

	private event Action 
	{
		[CompilerGenerated]
		private add { } //Length: 495
		[CompilerGenerated]
		private remove { } //Length: 494
	}

	private event Action 
	{
		[CompilerGenerated]
		private add { } //Length: 495
		[CompilerGenerated]
		private remove { } //Length: 494
	}

	public abstract bool Completed
	{
		 get { } //Length: 0
	}

	public abstract string Error
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool Failed
	{
		 get { } //Length: 0
	}

	public abstract bool Succeed
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 3
	}

	protected AbstractOperation() { }

	public override void add_CompletedEvent(Action value) { }

	public override void add_FailedEvent(Action value) { }

	public override void add_SucceedEvent(Action value) { }

	[CompilerGenerated]
	private void add_(Action value) { }

	[CompilerGenerated]
	private void add_(Action value) { }

	[CompilerGenerated]
	private void add_(Action value) { }

	public abstract bool get_Completed() { }

	public abstract string get_Error() { }

	public abstract bool get_Failed() { }

	public abstract bool get_Succeed() { }

	protected void RaiseCompletedEvent() { }

	protected void RaiseFailedEvent() { }

	protected void RaiseSucceedEvent() { }

	public override void remove_CompletedEvent(Action value) { }

	public override void remove_FailedEvent(Action value) { }

	public override void remove_SucceedEvent(Action value) { }

	[CompilerGenerated]
	private void remove_(Action value) { }

	[CompilerGenerated]
	private void remove_(Action value) { }

	[CompilerGenerated]
	private void remove_(Action value) { }

	protected abstract void set_Error(string value) { }

	protected abstract void set_Succeed(bool value) { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

