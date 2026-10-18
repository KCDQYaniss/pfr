//Type is in global namespace

public class EndingStatsStage : FinalStatisticScreenStage
{
	[CompilerGenerated]
	private struct <ShowState>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EndingStatsStage <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _endingIcon; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _endingTitle; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _endingDescription; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _endingProgressText; //Field offset: 0xD8
	[SerializeField]
	private CanvasGroup _captionCanvasGroup; //Field offset: 0xE0
	[SerializeField]
	protected FinalStatisticsConsequences _finalStatisticsConsequences; //Field offset: 0xE8

	public EndingStatsStage() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	private void FillData() { }

	[AsyncStateMachine(typeof(<ShowState>d__6))]
	public virtual Task ShowState() { }

}

