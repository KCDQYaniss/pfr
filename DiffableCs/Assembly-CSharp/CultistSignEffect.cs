//Type is in global namespace

public class CultistSignEffect : HalloweenEffect
{
	[CompilerGenerated]
	private sealed class <RunProcess>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CultistSignEffect <>4__this; //Field offset: 0x20
		private float <from>5__2; //Field offset: 0x28
		private float <to>5__3; //Field offset: 0x2C
		private float <time>5__4; //Field offset: 0x30

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
		public <RunProcess>d__8(int <>1__state) { }

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

	private static readonly int _dissolveId; //Field offset: 0x0
	private MaterialPropertyBlock _mpb; //Field offset: 0x28
	private MeshRenderer _renderer; //Field offset: 0x30
	private bool _value; //Field offset: 0x38
	[Range(0, 1)]
	[SerializeField]
	private float _dissolvePower; //Field offset: 0x3C
	[Range(1, 5)]
	[SerializeField]
	private float _interpolateTime; //Field offset: 0x40

	private static CultistSignEffect() { }

	public CultistSignEffect() { }

	public void Initialize() { }

	private void OnDestroy() { }

	private void ResetEffect() { }

	[IteratorStateMachine(typeof(<RunProcess>d__8))]
	protected virtual IEnumerator RunProcess() { }

	public void SetValue(bool value) { }

}

