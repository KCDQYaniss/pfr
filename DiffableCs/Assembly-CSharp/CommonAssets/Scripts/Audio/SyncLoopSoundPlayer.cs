namespace CommonAssets.Scripts.Audio;

public class SyncLoopSoundPlayer : HandlerStateBase
{
	[CompilerGenerated]
	private sealed class <PlayCoroutine>d__17 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SyncLoopSoundPlayer <>4__this; //Field offset: 0x20

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
		public <PlayCoroutine>d__17(int <>1__state) { }

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

	[SerializeField]
	private AudioSource[] _sources; //Field offset: 0x20
	[SerializeField]
	private AudioClip _clip; //Field offset: 0x28
	[SerializeField]
	private AudioMixerGroup _outputMixerGroup; //Field offset: 0x30
	[SerializeField]
	private bool _useSoundDelayCalculation; //Field offset: 0x38
	[SerializeField]
	private float _scheduleAheadTime; //Field offset: 0x3C
	[SerializeField]
	private int _maxCatchUpPerFrame; //Field offset: 0x40
	[SerializeField]
	private bool _playOnAwake; //Field offset: 0x44
	private bool _isPlaying; //Field offset: 0x45
	private double _clipLength; //Field offset: 0x48
	private Coroutine _playCoroutine; //Field offset: 0x50
	private double[] _nextGridTimes; //Field offset: 0x58
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x60

	public virtual event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public SyncLoopSoundPlayer() { }

	[CompilerGenerated]
	public virtual void add_StateChanged(Action value) { }

	public virtual void ApplyState(bool state) { }

	private void Awake() { }

	private double CalculateCommonGridTime(double dspTime) { }

	private void CollectSources() { }

	private void CollectSourcesIfNeeded() { }

	private double GetAdditionalDelay(AudioSource source) { }

	private void Init() { }

	private void InitializeSource(AudioSource source) { }

	private bool IsSourceUsable(AudioSource source) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPlay(AudioSource source, double scheduledStartDspTime) { }

	public void Play() { }

	[IteratorStateMachine(typeof(<PlayCoroutine>d__17))]
	private IEnumerator PlayCoroutine() { }

	[CompilerGenerated]
	public virtual void remove_StateChanged(Action value) { }

	private void ScheduleForSource(int index, AudioSource source, double dspTime) { }

	public void Stop() { }

}

