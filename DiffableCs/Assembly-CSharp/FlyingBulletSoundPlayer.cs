//Type is in global namespace

public class FlyingBulletSoundPlayer : BulletSoundPlayer
{
	[CompilerGenerated]
	private sealed class <FrameCoroutine>d__25 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FlyingBulletSoundPlayer <>4__this; //Field offset: 0x20
		public string id; //Field offset: 0x28
		public float magnitude; //Field offset: 0x30
		public Vector3 forward; //Field offset: 0x34
		public Vector3 normal; //Field offset: 0x40

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
		public <FrameCoroutine>d__25(int <>1__state) { }

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
	private sealed class <FrameCoroutineWithRandomParameters>d__26 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FlyingBulletSoundPlayer <>4__this; //Field offset: 0x20

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
		public <FrameCoroutineWithRandomParameters>d__26(int <>1__state) { }

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
	private sealed class <ResetVignetteEffect>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FlyingBulletSoundPlayer <>4__this; //Field offset: 0x20
		public float coef; //Field offset: 0x28
		public float savedValue; //Field offset: 0x2C
		private float <start>5__2; //Field offset: 0x30

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
		public <ResetVignetteEffect>d__28(int <>1__state) { }

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
	private AudioClip[] _sources; //Field offset: 0x20
	[MinMaxVec2(0, 10, -1)]
	[SerializeField]
	private Vector2 _minMaxRadius; //Field offset: 0x28
	[SerializeField]
	private AnimationCurve _vignette; //Field offset: 0x30
	[SerializeField]
	private float _vignetteTime; //Field offset: 0x38
	[SerializeField]
	private float _vignetteDelta; //Field offset: 0x3C
	private List _ballisticCalculators; //Field offset: 0x40
	private Dictionary _shotDistances; //Field offset: 0x48
	private string[] _playedShots; //Field offset: 0x50
	private int _shotIndex; //Field offset: 0x58
	private PrismEffects _prismEffects; //Field offset: 0x60
	private float _savedVignetting; //Field offset: 0x68
	private IEnumerator _vignettingCoroutine; //Field offset: 0x70
	private Player _player; //Field offset: 0x78
	private Coroutine _frameCoroutine; //Field offset: 0x80
	private float _lastClipPlayingTime; //Field offset: 0x88
	private bool _isPlayerInitialized; //Field offset: 0x8C
	private bool _isPrismEffectInitialized; //Field offset: 0x8D
	private bool _isSourcesInit; //Field offset: 0x8E

	public FlyingBulletSoundPlayer() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<FrameCoroutine>d__25))]
	private IEnumerator FrameCoroutine(string id, Vector3 forward, Vector3 normal, float magnitude) { }

	[IteratorStateMachine(typeof(<FrameCoroutineWithRandomParameters>d__26))]
	private IEnumerator FrameCoroutineWithRandomParameters() { }

	public virtual void Init(Camera camera, PlayerCameraController playerCameraController) { }

	private void InsertId(string id) { }

	private void OnDestroy() { }

	private void OnSniperZoneShoot(SonicInfo obj) { }

	private void PlaySound(Shot shot, Vector3 forward, Vector3 normal) { }

	[IteratorStateMachine(typeof(<ResetVignetteEffect>d__28))]
	private IEnumerator ResetVignetteEffect(float savedValue, float coef) { }

	private void StartVignetteEffect(float coef) { }

	private void StopFrameCoroutine() { }

	public virtual void TryShot(Shot shot, Camera camera, string id, int currentIndex) { }

}

