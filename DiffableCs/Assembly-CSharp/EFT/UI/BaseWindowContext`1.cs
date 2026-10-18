namespace EFT.UI;

public abstract class BaseWindowContext`1 : WindowContext
{
	[CompilerGenerated]
	private Action OnAccept; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnDecline; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnCloseSilent; //Field offset: 0x0
	private TaskCompletionSource _windowResultCompletionSource; //Field offset: 0x0
	private bool _open; //Field offset: 0x0
	private TContextType _result; //Field offset: 0x0
	private TaskCompletionSource _acceptCompletionSource; //Field offset: 0x0

	public event Action OnAccept
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnCloseSilent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnDecline
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	private TaskCompletionSource AcceptCompletionSource
	{
		private get { } //Length: 196
	}

	public Task AcceptResult
	{
		 get { } //Length: 218
	}

	public Task WindowResult
	{
		 get { } //Length: 218
	}

	private TaskCompletionSource WindowResultCompletionSource
	{
		private get { } //Length: 196
	}

	protected BaseWindowContext`1() { }

	protected void Accept(TContextType value) { }

	protected void AcceptAndClose(TContextType value) { }

	[CompilerGenerated]
	public void add_OnAccept(Action value) { }

	[CompilerGenerated]
	public void add_OnCloseSilent(Action value) { }

	[CompilerGenerated]
	public void add_OnDecline(Action value) { }

	public virtual void Close() { }

	public void CloseSilent() { }

	public void Decline() { }

	private TaskCompletionSource get_AcceptCompletionSource() { }

	public Task get_AcceptResult() { }

	public Task get_WindowResult() { }

	private TaskCompletionSource get_WindowResultCompletionSource() { }

	[CompilerGenerated]
	public void remove_OnAccept(Action value) { }

	[CompilerGenerated]
	public void remove_OnCloseSilent(Action value) { }

	[CompilerGenerated]
	public void remove_OnDecline(Action value) { }

	private void SetResult(TContextType result) { }

}

