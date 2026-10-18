namespace EFT.UI;

public sealed class ErrorScreen : Window
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ErrorWindowContext context; //Field offset: 0x10
		public ErrorScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Co_WaitForReaction>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ErrorScreen <>4__this; //Field offset: 0x20
		public DateTime endTime; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Co_WaitForReaction>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum EButtonType
	{
		OkButton = 0,
		CancelButton = 1,
		QuitButton = 2,
	}

	private const string DEFAULT_HEADER = "ERROR"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _errorDescription; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _exitButton; //Field offset: 0xC0
	private Coroutine _waitForReactionCoroutine; //Field offset: 0xC8
	private string _description; //Field offset: 0xD0

	protected virtual bool DragEnabled
	{
		 get { } //Length: 3
	}

	public ErrorScreen() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void CloseSilent() { }

	private void CloseWindow(bool timeOut, bool silent) { }

	[IteratorStateMachine(typeof(<Co_WaitForReaction>d__10))]
	private IEnumerator Co_WaitForReaction(DateTime endTime) { }

	private void Decline() { }

	protected virtual bool get_DragEnabled() { }

	internal ErrorWindowContext Show(string title, string message, float waitingTime = 0, EButtonType buttonType = 0, bool removeHtml = true) { }

	private void TimeOut() { }

	private void Update() { }

}

