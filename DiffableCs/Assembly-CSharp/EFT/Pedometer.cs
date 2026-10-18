namespace EFT;

public class Pedometer
{
	[CompilerGenerated]
	private sealed class <Engine>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Pedometer <>4__this; //Field offset: 0x20

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
		public <Engine>d__8(int <>1__state) { }

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

	private const float _updateTime = 1; //Field offset: 0x0
	private Player _player; //Field offset: 0x10
	private readonly float[] _distances; //Field offset: 0x18
	private readonly float[] _marks; //Field offset: 0x20
	private Vector3 _lastPosition; //Field offset: 0x28
	private IEnumerator _engine; //Field offset: 0x38
	public EPlayerState CurrentState; //Field offset: 0x40

	public Pedometer(Player player) { }

	[IteratorStateMachine(typeof(<Engine>d__8))]
	private IEnumerator Engine() { }

	public float GetDistance() { }

	public float GetDistanceFromMark(EPlayerState state) { }

	public void MakeMark(EPlayerState state) { }

	public void Start() { }

	public void Stop() { }

}

