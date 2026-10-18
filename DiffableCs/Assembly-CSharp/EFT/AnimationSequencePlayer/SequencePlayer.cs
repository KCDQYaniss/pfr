namespace EFT.AnimationSequencePlayer;

public static class SequencePlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__14_1; //Field offset: 0x8
		public static Comparison <>9__15_0; //Field offset: 0x10
		public static Comparison <>9__16_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <RunAnimationSequenceTimelineAsync>b__14_1(AnimationParams a, AnimationParams b) { }

		internal int <RunLipSyncSequenceTimelineAsync>b__15_0(LipSyncParams a, LipSyncParams b) { }

		internal int <RunSubtitlesSequenceTimelineAsync>b__16_0(SubtitleParams a, SubtitleParams b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		private struct <<RunAnimationSequenceTimelineAsync>g__ExitTrigger|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public float delay; //Field offset: 0x20
			public <>c__DisplayClass14_0 <>4__this; //Field offset: 0x28
			public AnimationElement element; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CancellationToken cancellationToken; //Field offset: 0x10
		public Animator animator; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		[AsyncStateMachine(typeof(<<RunAnimationSequenceTimelineAsync>g__ExitTrigger|0>d))]
		internal Task <RunAnimationSequenceTimelineAsync>g__ExitTrigger|0(AnimationElement element, float delay) { }

	}

	[CompilerGenerated]
	private struct <RunAnimationSequenceTimelineAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public Animator animator; //Field offset: 0x28
		public List keysWithParams; //Field offset: 0x30
		private <>c__DisplayClass14_0 <>8__1; //Field offset: 0x38
		public AnimationDictionary animationDictionary; //Field offset: 0x40
		private AnimatorResetter <resetter>5__2; //Field offset: 0x48
		private List <sortedKeys>5__3; //Field offset: 0x50
		private float <sequenceStartTime>5__4; //Field offset: 0x58
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Key", "EndTime"})]
		private List <activeAnimations>5__5; //Field offset: 0x60
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Props", "StartTime", "EndTime"})]
		private List <activeProps>5__6; //Field offset: 0x68
		private int <nextKeyIndex>5__7; //Field offset: 0x70
		private YieldAwaiter <>u__1; //Field offset: 0x74

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunCombinedSequence>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Animator animator; //Field offset: 0x20
		public AnimationDictionary animationDictionary; //Field offset: 0x28
		public List animKeys; //Field offset: 0x30
		public SecondaryAnimationDictionary secondaryAnimationDictionary; //Field offset: 0x38
		public List secondaryAnimKeys; //Field offset: 0x40
		public ULipSyncCurvesPlayer lipSyncPlayer; //Field offset: 0x48
		public LipSyncDictionary lipSyncDictionary; //Field offset: 0x50
		public List lipSyncKeys; //Field offset: 0x58
		public List subtitleKeys; //Field offset: 0x60
		private YieldAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunLipSyncSequenceTimelineAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List lipSyncKeys; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public ULipSyncCurvesPlayer lipSyncPlayer; //Field offset: 0x30
		public LipSyncDictionary lipSyncDictionary; //Field offset: 0x38
		private List <sortedKeys>5__2; //Field offset: 0x40
		private float <sequenceStartTime>5__3; //Field offset: 0x48
		private float <activeLipSyncEndTime>5__4; //Field offset: 0x4C
		private LipSyncParams <activeLipSync>5__5; //Field offset: 0x50
		private int <nextKeyIndex>5__6; //Field offset: 0x58
		private YieldAwaiter <>u__1; //Field offset: 0x5C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunSubtitlesSequenceTimelineAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List subtitleKeys; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private List <sortedKeys>5__2; //Field offset: 0x30
		private float <sequenceStartTime>5__3; //Field offset: 0x38
		private float <activeSubtitleEndTime>5__4; //Field offset: 0x3C
		private SubtitleParams <activeSubtitle>5__5; //Field offset: 0x40
		private string <activeSubtitleText>5__6; //Field offset: 0x48
		private int <nextKeyIndex>5__7; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x54

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static bool <IsPlaying>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnPlayingStateChanged; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnSubtitleChanged; //Field offset: 0x10
	private static CancellationTokenSource _cancellationTokenSource; //Field offset: 0x18
	private static string _currentSubtitle; //Field offset: 0x20
	private static ULipSyncCurvesPlayer _lipSyncPlayer; //Field offset: 0x28

	public static event Action OnPlayingStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public static event Action OnSubtitleChanged
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public private static bool IsPlaying
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 64
	}

	[CompilerGenerated]
	public static void add_OnPlayingStateChanged(Action value) { }

	[CompilerGenerated]
	public static void add_OnSubtitleChanged(Action value) { }

	private static void Clear() { }

	private static void DisableAllProps(AnimationDictionary sequenceDictionary) { }

	[CompilerGenerated]
	public static bool get_IsPlaying() { }

	[CompilerGenerated]
	public static void remove_OnPlayingStateChanged(Action value) { }

	[CompilerGenerated]
	public static void remove_OnSubtitleChanged(Action value) { }

	[AsyncStateMachine(typeof(<RunAnimationSequenceTimelineAsync>d__14))]
	private static Task RunAnimationSequenceTimelineAsync(Animator animator, AnimationDictionary animationDictionary, List keysWithParams, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<RunCombinedSequence>d__13))]
	public static Task RunCombinedSequence(Animator animator, AnimationDictionary animationDictionary, List animKeys, SecondaryAnimationDictionary secondaryAnimationDictionary, List secondaryAnimKeys, ULipSyncCurvesPlayer lipSyncPlayer, LipSyncDictionary lipSyncDictionary, List lipSyncKeys, List subtitleKeys) { }

	[AsyncStateMachine(typeof(<RunLipSyncSequenceTimelineAsync>d__15))]
	private static Task RunLipSyncSequenceTimelineAsync(ULipSyncCurvesPlayer lipSyncPlayer, LipSyncDictionary lipSyncDictionary, List lipSyncKeys, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<RunSubtitlesSequenceTimelineAsync>d__16))]
	private static Task RunSubtitlesSequenceTimelineAsync(List subtitleKeys, CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private static void set_IsPlaying(bool value) { }

	private static void SetPropsActive(GameObject[] props, bool active) { }

	public static void StopSequence() { }

}

