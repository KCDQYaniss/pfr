namespace EFT.GameTriggers;

[Obfuscation(Exclude = True)]
public class HandlerPlaySoundSequenced : HandlerPlaybackStateBase, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public AudioHandle handleCopy; //Field offset: 0x10

		public <>c__DisplayClass40_0() { }

		internal void <FadeOutAndRelease>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__45 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandlerPlaySoundSequenced <>4__this; //Field offset: 0x28

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_InputTriggerIds>d__45(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__48 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_OutputTriggerIds>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[IsReadOnly]
	private struct ClipTiming
	{
		public readonly bool hasStartClip; //Field offset: 0x0
		public readonly bool hasLoopClip; //Field offset: 0x1
		public readonly float startLenSeconds; //Field offset: 0x4
		public readonly float loopLenSeconds; //Field offset: 0x8

		public ClipTiming(bool hasStartClip, bool hasLoopClip, float startLenSeconds, float loopLenSeconds) { }

	}

	private enum EPlaybackState
	{
		Idle = 0,
		Playing = 1,
		Stopped = 2,
	}

	[IsReadOnly]
	private struct PlaybackSchedule
	{
		public readonly bool playStart; //Field offset: 0x0
		public readonly float startClipOffsetSeconds; //Field offset: 0x4
		public readonly bool playLoop; //Field offset: 0x8
		public readonly float loopDelayAfterLookahead; //Field offset: 0xC
		public readonly float loopClipOffsetSeconds; //Field offset: 0x10

		public static PlaybackSchedule Silence
		{
			 get { } //Length: 15
		}

		public PlaybackSchedule(bool playStart, float startClipOffsetSeconds, bool playLoop, float loopDelayAfterLookahead, float loopClipOffsetSeconds) { }

		public static PlaybackSchedule get_Silence() { }

	}

	private const float MIN_TIMELINE_PHASE_SECONDS = 1E-05; //Field offset: 0x0
	[Header("Network playback: add PlaybackStateSync to this object and assign this handler in its list.")]
	[SerializeField]
	private string _playTriggerId; //Field offset: 0x20
	[SerializeField]
	private string _stopTriggerId; //Field offset: 0x28
	[SerializeField]
	private bool _playOnSoundSystemInit; //Field offset: 0x30
	[SerializeField]
	private bool _playOnce; //Field offset: 0x31
	[SerializeField]
	private float _startFade; //Field offset: 0x34
	[SerializeField]
	private float _endFade; //Field offset: 0x38
	[SerializeField]
	private PlaySoundConfig _startSound; //Field offset: 0x40
	[SerializeField]
	private PlaySoundConfig _loopSound; //Field offset: 0x88
	[SerializeField]
	private PlaySoundConfig _endSound; //Field offset: 0xD0
	[SerializeField]
	private Transform _overrideSoundPosition; //Field offset: 0x118
	[SerializeField]
	private bool _trackTransform; //Field offset: 0x120
	[SerializeField]
	private AnimationCurve _rolloffCurve; //Field offset: 0x128
	[SerializeField]
	private AnimationCurve _spatialBlendCurve; //Field offset: 0x130
	private AudioHandle _startHandle; //Field offset: 0x138
	private AudioHandle _loopHandle; //Field offset: 0x148
	private EPlaybackState _state; //Field offset: 0x158
	private Action _unsubOnDestroy; //Field offset: 0x160
	[CompilerGenerated]
	private Action StateChanged; //Field offset: 0x168

	public virtual event Action StateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__45))]
		 get { } //Length: 175
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	protected virtual bool IsPlaybackActive
	{
		 get { } //Length: 11
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__48))]
		 get { } //Length: 80
	}

	public HandlerPlaySoundSequenced() { }

	[CompilerGenerated]
	private void <Start>b__28_0(TriggerEvent _) { }

	[CompilerGenerated]
	private void <Start>b__28_1(TriggerEvent _) { }

	[CompilerGenerated]
	public virtual void add_StateChanged(Action value) { }

	private static void ApplyCustomCurve(AudioHandle handle, AudioSourceCurveType curveType, AnimationCurve curve) { }

	protected virtual void ApplyPlaybackElapsed(double elapsedSeconds) { }

	public virtual void ApplyState(bool state) { }

	private void Awake() { }

	private ClipTiming BuildClipTiming() { }

	private SpatialAudioBuilder BuildPlay(BetterAudio betterAudio, PlaySoundConfig soundConfig, Vector3 position, GameObject occlusionObject) { }

	private PlaybackSchedule BuildPlaybackSchedule(bool usePlaybackTimeline, double playbackElapsedSeconds, in ClipTiming clips) { }

	private static void FadeOutAndRelease(ref AudioHandle handle, float fade) { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__45))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	protected virtual bool get_IsPlaybackActive() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__48))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void GetSoundPlacement(out Vector3 position, out GameObject trackedObject) { }

	private void OnAudioSystemInit(AmbientAudioSystemInitializedEvent initializedEvent) { }

	private void OnDestroy() { }

	private void PlaySound() { }

	[CompilerGenerated]
	public virtual void remove_StateChanged(Action value) { }

	private static float SafePitch(float pitch) { }

	private static PlaybackSchedule ScheduleLoopPhase(in ClipTiming clips, double loopTimelineSeconds) { }

	private void Start() { }

	protected virtual void StopPlayback() { }

	private void StopSound() { }

	private bool TryPlaySound(bool usePlaybackTimeline, double playbackElapsedSeconds) { }

	public override bool TryRenameId(string oldId, string newId) { }

}

