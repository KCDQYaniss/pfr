namespace EFT.UI;

public sealed class CaptchaWindow : HandoverSelectItemsWindow
{
	[CompilerGenerated]
	private struct <ValidAnswer>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CaptchaWindow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject _loader; //Field offset: 0x138
	[SerializeField]
	private ScrollRect _scroll; //Field offset: 0x140
	private readonly List _selectedItems; //Field offset: 0x148
	private Action _acceptAction; //Field offset: 0x150

	protected virtual bool CanStretchHorizontally
	{
		 get { } //Length: 3
	}

	protected virtual bool CloseOnAccept
	{
		 get { } //Length: 3
	}

	protected virtual int GridHeight
	{
		 get { } //Length: 6
	}

	protected virtual int GridWidth
	{
		 get { } //Length: 6
	}

	public CaptchaWindow() { }

	protected virtual void Accept() { }

	private void AddToSelection(Item item) { }

	protected virtual void ClearSelectedList() { }

	public virtual void Close() { }

	protected virtual bool get_CanStretchHorizontally() { }

	protected virtual bool get_CloseOnAccept() { }

	protected virtual int get_GridHeight() { }

	protected virtual int get_GridWidth() { }

	public void InvalidAnswer() { }

	protected virtual bool IsActive(Item item, out string tooltip) { }

	protected virtual bool IsSelected(Item item) { }

	private void RemoveFromSelection(Item item) { }

	private void ResetScroll() { }

	protected virtual void SetAcceptActive(bool value) { }

	public DialogWindowContext Show(string title, string description, ICollection items, Profile profile, ItemController controller, Action acceptAction, bool canShowCloseButton) { }

	protected virtual void TrySelectItemToHandover(Item item) { }

	protected virtual void UpdateItems(IEnumerable items) { }

	[AsyncStateMachine(typeof(<ValidAnswer>d__17))]
	public Task ValidAnswer() { }

}

