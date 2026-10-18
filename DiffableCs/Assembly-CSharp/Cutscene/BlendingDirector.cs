namespace Cutscene;

[RequireComponent(typeof(PlayableDirector))]
public class BlendingDirector : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Action onBlendInFinished; //Field offset: 0x10
		public BlendingDirector <>4__this; //Field offset: 0x18

		public <>c__DisplayClass46_0() { }

		internal void <Play>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public Action onFinished; //Field offset: 0x10
		public BlendingDirector <>4__this; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <Stop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public Action onFinished; //Field offset: 0x10
		public BlendingDirector <>4__this; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <Seek>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <BlendIn>d__50 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayableDirector director; //Field offset: 0x20
		public float startTime; //Field offset: 0x28
		public AnimationPlayableOutput output; //Field offset: 0x30
		public float blendTime; //Field offset: 0x40
		public Action onFinished; //Field offset: 0x48
		public BlendingDirector <>4__this; //Field offset: 0x50
		private float <t>5__2; //Field offset: 0x58

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
		public <BlendIn>d__50(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <BlendOut>d__49 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float blendTime; //Field offset: 0x20
		public float fromWeight; //Field offset: 0x24
		public AnimationPlayableOutput output; //Field offset: 0x28
		public Action onFinished; //Field offset: 0x38
		public PlayableDirector director; //Field offset: 0x40
		public BlendingDirector <>4__this; //Field offset: 0x48
		private float <t>5__2; //Field offset: 0x50

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
		public <BlendOut>d__49(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SeekBlend>d__51 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BlendingDirector <>4__this; //Field offset: 0x20
		public float startTime; //Field offset: 0x28
		public float blendTime; //Field offset: 0x2C
		public Action onFinished; //Field offset: 0x30
		private float <t>5__2; //Field offset: 0x38

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
		public <SeekBlend>d__51(int <>1__state) { }

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

	internal enum BlendType
	{
		None = 0,
		In = 1,
		Out = 2,
		Seek = 3,
	}

	private static bool _abortBlendIn; //Field offset: 0x0
	[SerializeField]
	private PlayableDirector _playableDirector; //Field offset: 0x20
	[CompilerGenerated]
	private BlendType <CurrentBlend>k__BackingField; //Field offset: 0x28
	private AnimationPlayableOutput _output; //Field offset: 0x30
	private Playable _originalSourcePlayable; //Field offset: 0x40
	private Playable _clone; //Field offset: 0x50
	private AnimationMixerPlayable _mixer; //Field offset: 0x60
	private int _cloneIndex; //Field offset: 0x70
	private int _originalIndex; //Field offset: 0x74
	private float _decreasingWeight; //Field offset: 0x78
	private float _increasingWeight; //Field offset: 0x7C
	private TrackAsset _trackAsset; //Field offset: 0x80
	private double _outTime; //Field offset: 0x88
	private Action _scheduledBlendOutCallback; //Field offset: 0x90
	private float _scheduledBlendOutDuration; //Field offset: 0x98
	private AnimationPlayableOutput _originalOutput; //Field offset: 0xA0
	private int _outputTrackIndex; //Field offset: 0xB0
	private Stopwatch _sw; //Field offset: 0xB8
	private Coroutine _blendInCoroutine; //Field offset: 0xC0
	private Coroutine _blendOutCoroutine; //Field offset: 0xC8
	private Coroutine _seekBlendCoroutine; //Field offset: 0xD0
	private string _overrideDirectorOutputName; //Field offset: 0xD8

	public BlendType CurrentBlend
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsBlending
	{
		 get { } //Length: 8
	}

	public bool IsBlendingIn
	{
		 get { } //Length: 8
	}

	public bool IsBlendingOut
	{
		 get { } //Length: 8
	}

	public bool IsPlaying
	{
		 get { } //Length: 96
	}

	public string Name
	{
		 get { } //Length: 29
	}

	public PlayableDirector PlayableDirector
	{
		 get { } //Length: 5
	}

	public double TimeRemaining
	{
		 get { } //Length: 195
	}

	public BlendingDirector() { }

	[CompilerGenerated]
	private void <Update>b__41_0() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<BlendIn>d__50))]
	private IEnumerator BlendIn(PlayableDirector director, AnimationPlayableOutput output, float blendTime, float startTime = -1, Action onFinished = null) { }

	[IteratorStateMachine(typeof(<BlendOut>d__49))]
	private IEnumerator BlendOut(PlayableDirector director, AnimationPlayableOutput output, float blendTime, float fromWeight = 1, Action onFinished = null) { }

	private void BuildOutput() { }

	[CompilerGenerated]
	public BlendType get_CurrentBlend() { }

	public bool get_IsBlending() { }

	public bool get_IsBlendingIn() { }

	public bool get_IsBlendingOut() { }

	public bool get_IsPlaying() { }

	public string get_Name() { }

	public PlayableDirector get_PlayableDirector() { }

	public double get_TimeRemaining() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void Play(float blendInDuration = 0.5, float blendOutDuration = 0.5, float startTime = -1, float endTime = -1, Action onBlendInFinished = null, Action onFinished = null) { }

	public void Seek(float toTime, float blendDuration, Action onFinished = null) { }

	[IteratorStateMachine(typeof(<SeekBlend>d__51))]
	private IEnumerator SeekBlend(float blendTime, float startTime = -1, Action onFinished = null) { }

	[CompilerGenerated]
	public void set_CurrentBlend(BlendType value) { }

	public void Stop(float blendDuration = 0.5, Action onFinished = null) { }

	private void StopCoroutines() { }

	private void Update() { }

}

