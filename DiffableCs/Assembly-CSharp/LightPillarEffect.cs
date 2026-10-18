//Type is in global namespace

public class LightPillarEffect : HalloweenEffect
{
	[CompilerGenerated]
	private sealed class <EndProcess>d__21 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LightPillarEffect <>4__this; //Field offset: 0x20
		private float <fade>5__2; //Field offset: 0x28

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
		public <EndProcess>d__21(int <>1__state) { }

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
	private sealed class <RunProcess>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LightPillarEffect <>4__this; //Field offset: 0x20

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
		public <RunProcess>d__19(int <>1__state) { }

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
	private sealed class <StartProcess>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LightPillarEffect <>4__this; //Field offset: 0x20
		private float <fade>5__2; //Field offset: 0x28

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
		public <StartProcess>d__20(int <>1__state) { }

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

	private static readonly int _heightTopYFadeId; //Field offset: 0x0
	private static readonly int _distanceFadeId; //Field offset: 0x4
	private MaterialPropertyBlock _mpb; //Field offset: 0x28
	private MaterialPropertyBlock _mpbGlow; //Field offset: 0x30
	private Vector3 _position; //Field offset: 0x38
	private bool _processFade; //Field offset: 0x44
	private bool _isFireFading; //Field offset: 0x45
	[SerializeField]
	private MeshRenderer _renderer; //Field offset: 0x48
	[SerializeField]
	private Vector2 _minMaxDistanceToFade; //Field offset: 0x50
	[SerializeField]
	private AnimationCurve _lightPillarFade; //Field offset: 0x58
	[SerializeField]
	[Space]
	private MeshRenderer _rendererGlow; //Field offset: 0x60
	[SerializeField]
	private Vector2 _minMaxDistanceGlowToFade; //Field offset: 0x68
	[SerializeField]
	private AnimationCurve _lightPillarGlowFade; //Field offset: 0x70
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _heightFade; //Field offset: 0x78
	[Range(0, 1)]
	[SerializeField]
	private float _speed; //Field offset: 0x7C
	[SerializeField]
	private ParticleSystem _fire; //Field offset: 0x80
	private bool _value; //Field offset: 0x88

	private static LightPillarEffect() { }

	public LightPillarEffect() { }

	[IteratorStateMachine(typeof(<EndProcess>d__21))]
	private IEnumerator EndProcess() { }

	public void Initialize(Vector3 position) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void ResetEffect() { }

	[IteratorStateMachine(typeof(<RunProcess>d__19))]
	protected virtual IEnumerator RunProcess() { }

	public void SetValue(bool value) { }

	[IteratorStateMachine(typeof(<StartProcess>d__20))]
	private IEnumerator StartProcess() { }

	private void UpdateProperties() { }

}

