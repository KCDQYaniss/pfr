namespace UI;

public class RecorderRaidPanel : UIInputNode
{
	[CompilerGenerated]
	private struct <PlayProcess>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RecorderRaidPanel <>4__this; //Field offset: 0x20
		public float totalTime; //Field offset: 0x28
		private CancellationToken <token>5__2; //Field offset: 0x30
		private float <currentTime>5__3; //Field offset: 0x38
		private string <maxTime>5__4; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string TIME_FORMAT = "mm\:ss"; //Field offset: 0x0
	[SerializeField]
	private TickerLine _tickerLine; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _tapeNameLabel; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _timerLabel; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _keyLabel; //Field offset: 0x98
	private CancellationTokenSource _tokenSrc; //Field offset: 0xA0

	public RecorderRaidPanel() { }

	public virtual void Close() { }

	private string GetTimeString(float time) { }

	[AsyncStateMachine(typeof(<PlayProcess>d__7))]
	private Task PlayProcess(float totalTime) { }

	public void SetTape(string tapeName, float duration) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void ValidateInputKey() { }

}

