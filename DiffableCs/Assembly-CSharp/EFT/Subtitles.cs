namespace EFT;

public sealed class Subtitles : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8
		public static Func <>9__28_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal double <.ctor>b__21_0() { }

		internal SubtitleParams <Parse>b__28_0(CCLine cc) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Subtitles <>4__this; //Field offset: 0x10
		public double startTime; //Field offset: 0x18
		public double seconds; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal bool <Delay>b__0() { }

	}

	[CompilerGenerated]
	private struct <ShowLine>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Subtitles <>4__this; //Field offset: 0x20
		public SubtitleParams line; //Field offset: 0x28
		private float <duration>5__2; //Field offset: 0x30
		private CancellationToken <stopToken>5__3; //Field offset: 0x38
		private ActiveCCLine <activeLine>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Subtitles <>4__this; //Field offset: 0x20
		private CancellationToken <stopToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ActiveCCLine
	{
		public readonly SubtitleParams Line; //Field offset: 0x10
		public readonly Task Task; //Field offset: 0x18
		public readonly string LocalizedText; //Field offset: 0x20

		public ActiveCCLine(SubtitleParams line, Task task) { }

	}

	[CompilerGenerated]
	private Action OnNewCCLine; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnSubtitlesEnded; //Field offset: 0x18
	private string _localizationKey; //Field offset: 0x20
	private IEnumerable _lines; //Field offset: 0x28
	private readonly double _startTime; //Field offset: 0x30
	private readonly CompositeDisposable _disposeTrigger; //Field offset: 0x38
	private readonly CompositeDisposable _stopTrigger; //Field offset: 0x40
	private readonly List _lineTasks; //Field offset: 0x48
	private readonly List _currentLines; //Field offset: 0x50
	[CompilerGenerated]
	private double <Duration>k__BackingField; //Field offset: 0x58
	private readonly Func _passedTimeFunc; //Field offset: 0x60

	public event Action OnNewCCLine
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSubtitlesEnded
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public IEnumerable CurrentLines
	{
		 get { } //Length: 5
	}

	public private double Duration
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public Subtitles(IEnumerable subtitlesData, Func passedTimeFunk = null) { }

	[CompilerGenerated]
	private void <.ctor>b__21_1() { }

	[CompilerGenerated]
	public void add_OnNewCCLine(Action value) { }

	[CompilerGenerated]
	public void add_OnSubtitlesEnded(Action value) { }

	private Task Delay(double seconds) { }

	public override void Dispose() { }

	public IEnumerable get_CurrentLines() { }

	[CompilerGenerated]
	public double get_Duration() { }

	private void Init(IEnumerable subtitlesData) { }

	private void Parse() { }

	[CompilerGenerated]
	public void remove_OnNewCCLine(Action value) { }

	[CompilerGenerated]
	public void remove_OnSubtitlesEnded(Action value) { }

	[CompilerGenerated]
	private void set_Duration(double value) { }

	[AsyncStateMachine(typeof(<ShowLine>d__24))]
	private Task ShowLine(SubtitleParams line) { }

	[AsyncStateMachine(typeof(<Start>d__23))]
	private Task Start() { }

	private void Stop() { }

}

