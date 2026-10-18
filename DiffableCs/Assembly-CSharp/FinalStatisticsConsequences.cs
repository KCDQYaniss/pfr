//Type is in global namespace

public class FinalStatisticsConsequences : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Show>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FinalStatisticsConsequences <>4__this; //Field offset: 0x20
		public EndingElement currentEnding; //Field offset: 0x28
		public bool isPve; //Field offset: 0x30
		public FinalStatsArgs args; //Field offset: 0x38
		private Consequence[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowConsequence>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ConsequenceConfig config; //Field offset: 0x20
		public FinalStatisticsConsequences <>4__this; //Field offset: 0x30
		public FinalStatsArgs args; //Field offset: 0x38
		public string captionKey; //Field offset: 0x40
		private CanvasGroup <cg>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private YieldAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <TypeText>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FinalStatisticsConsequences <>4__this; //Field offset: 0x20
		public string captionKey; //Field offset: 0x28

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
		public <TypeText>d__14(int <>1__state) { }

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

	private struct ConsequenceConfig
	{
		public string ViewID; //Field offset: 0x0
		public Sprite BackgroundImage; //Field offset: 0x8

	}

	[SerializeField]
	private AspectRatioFitter _imageAspectRatioFitter; //Field offset: 0x20
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x28
	[SerializeField]
	private ConsequenceConfig[] _consequencesContent; //Field offset: 0x30
	[SerializeField]
	private TMP_Text _captionLabel; //Field offset: 0x38
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x40
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0x48
	private bool _isClicked; //Field offset: 0x50
	private bool _localizationLoaded; //Field offset: 0x51

	public FinalStatisticsConsequences() { }

	[CompilerGenerated]
	private void <TypeText>b__14_0(string val) { }

	private void OnNextButtonClicked() { }

	[AsyncStateMachine(typeof(<Show>d__11))]
	public Task Show(FinalStatsArgs args, EndingElement currentEnding, bool isPve) { }

	[AsyncStateMachine(typeof(<ShowConsequence>d__13))]
	private Task ShowConsequence(FinalStatsArgs args, ConsequenceConfig config, string captionKey) { }

	private void Start() { }

	private bool TryGetConsequenceConfig(string viewId, out ConsequenceConfig consequenceConfig) { }

	[IteratorStateMachine(typeof(<TypeText>d__14))]
	private IEnumerator TypeText(string captionKey) { }

}

