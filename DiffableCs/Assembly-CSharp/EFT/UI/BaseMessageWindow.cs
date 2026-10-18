namespace EFT.UI;

public abstract class BaseMessageWindow : DialogWindow
{
	[CompilerGenerated]
	private struct <AnimateText>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseMessageWindow <>4__this; //Field offset: 0x20
		public Color color; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <Co_WaitForReaction>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DateTime endTime; //Field offset: 0x20
		public BaseMessageWindow <>4__this; //Field offset: 0x28
		public Action onFinished; //Field offset: 0x30

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

	private const float ANIMATE_DURATION = 0.15; //Field offset: 0x0
	private const int ANIMATE_LOOPS_COUNT = 8; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _message; //Field offset: 0xD8
	private Coroutine _waitForReactionCoroutine; //Field offset: 0xE0
	private string _description; //Field offset: 0xE8

	public TextAlignmentOptions MessageAlignment
	{
		 set { } //Length: 94
	}

	protected BaseMessageWindow() { }

	[AsyncStateMachine(typeof(<AnimateText>d__9))]
	protected Task AnimateText(Color color) { }

	[IteratorStateMachine(typeof(<Co_WaitForReaction>d__10))]
	private IEnumerator Co_WaitForReaction(DateTime endTime, Action onFinished) { }

	public void set_MessageAlignment(TextAlignmentOptions value) { }

	protected void SetMessage(string message) { }

	protected DialogWindowContext Show(string title, string message, bool canShowCloseButton, float time = 0, bool exitActsAsAccept = false) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

