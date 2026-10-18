namespace EFT;

public sealed class AudioArray : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public bool cancelled; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <PlayWithOffset>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public bool isVolumetric; //Field offset: 0x10
		public AudioArray <>4__this; //Field offset: 0x18
		public Action onCancelCallback; //Field offset: 0x20
		public Action originalCallback; //Field offset: 0x28

		public <>c__DisplayClass14_0() { }

		internal void <SetupStopTrigger>g__OnStop|0(bool volumetric) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public List sources; //Field offset: 0x10
		public AudioClip sequenceClip; //Field offset: 0x18
		public bool cancelled; //Field offset: 0x20

		public <>c__DisplayClass9_0() { }

		internal void <PlaySequence>b__1() { }

		internal void <PlaySequence>g__SetupSource|0(float time, bool init = false) { }

	}

	[CompilerGenerated]
	private struct <PlayOneShot>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioArray <>4__this; //Field offset: 0x28
		public AudioClip sound; //Field offset: 0x30
		public bool volumetric; //Field offset: 0x38
		public Action onFinish; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayOneShotAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioClip sound; //Field offset: 0x20
		public AudioArray <>4__this; //Field offset: 0x28
		public bool volumetric; //Field offset: 0x30
		public Action onFinish; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlaySequence>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioArray <>4__this; //Field offset: 0x28
		public bool volumetric; //Field offset: 0x30
		public AudioSequence sequence; //Field offset: 0x38
		public EAudioSequenceType sequenceType; //Field offset: 0x40
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x48
		public Action onCancel; //Field offset: 0x50
		private SequenceSettings <parameters>5__2; //Field offset: 0x58
		private bool <loop>5__3; //Field offset: 0x90
		private Stopwatch <stopwatch>5__4; //Field offset: 0x98
		private TaskAwaiter <>u__1; //Field offset: 0xA0
		private int <offset>5__5; //Field offset: 0xA8
		private int <loopMilliseconds>5__6; //Field offset: 0xAC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayWithOffset>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AudioArray <>4__this; //Field offset: 0x28
		public bool volumetric; //Field offset: 0x30
		public AudioClip sound; //Field offset: 0x38
		public Action onCancel; //Field offset: 0x40
		public float offset; //Field offset: 0x48
		private <>c__DisplayClass10_0 <>8__1; //Field offset: 0x50
		public Action onFinish; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private AudioSource _audioSource2D; //Field offset: 0x20
	private List _audioSources3D; //Field offset: 0x28
	[CompilerGenerated]
	private Action _sequenceCancelAction; //Field offset: 0x30

	private event Action _sequenceCancelAction
	{
		[CompilerGenerated]
		private add { } //Length: 262
		[CompilerGenerated]
		private remove { } //Length: 262
	}

	public AudioArray() { }

	[CompilerGenerated]
	private bool <Init>b__8_0(AudioSource source) { }

	[CompilerGenerated]
	private void add__sequenceCancelAction(Action value) { }

	public void Awake() { }

	private List GetSources(bool volumetric) { }

	public void Init(Nullable overlap = null) { }

	public void OnDestroy() { }

	public void OnDisable() { }

	public void PlayLoop(AudioClip sound, bool volumetric) { }

	[AsyncStateMachine(typeof(<PlayOneShot>d__11))]
	public void PlayOneShot(AudioClip sound, bool volumetric, Action onFinish = null) { }

	[AsyncStateMachine(typeof(<PlayOneShotAsync>d__12))]
	public Task PlayOneShotAsync(AudioClip sound, bool volumetric, Action onFinish = null) { }

	[AsyncStateMachine(typeof(<PlaySequence>d__9))]
	public void PlaySequence(AudioSequence sequence, EAudioSequenceType sequenceType, bool volumetric, Action onCancel = null) { }

	[AsyncStateMachine(typeof(<PlayWithOffset>d__10))]
	public void PlayWithOffset(AudioClip sound, bool volumetric, float offset, Action onFinish = null, Action onCancel = null) { }

	[CompilerGenerated]
	private void remove__sequenceCancelAction(Action value) { }

	private void SetupStopTrigger(bool isVolumetric, Action onCancelCallback, Action originalCallback = null) { }

	public void Stop(bool volumetric) { }

}

