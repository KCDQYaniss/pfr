//Type is in global namespace

public class HeatHazeEmitter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Delay>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HeatHazeEmitter <>4__this; //Field offset: 0x20
		public IHeatHazeEmitter emitter; //Field offset: 0x28

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
		public <Delay>d__10(int <>1__state) { }

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

	public Vector3 Bounds; //Field offset: 0x20
	public Vector3 Center; //Field offset: 0x2C
	[MinMaxVec2(0, 2, -1)]
	public Vector2 LifetimeDelta; //Field offset: 0x38
	[MinMaxVec2(0.01, 1, -1)]
	public Vector2 Size; //Field offset: 0x40
	public int Count; //Field offset: 0x48
	public float VelocityFactor; //Field offset: 0x4C
	public float Angle; //Field offset: 0x50
	public float DelayInSec; //Field offset: 0x54
	[HideInInspector]
	public float Chance; //Field offset: 0x58

	public HeatHazeEmitter() { }

	[IteratorStateMachine(typeof(<Delay>d__10))]
	private IEnumerator Delay(IHeatHazeEmitter emitter) { }

	private void Emit(IHeatHazeEmitter emitter) { }

	public void OnDrawGizmosSelected() { }

	public void OnShot(IHeatHazeEmitter emitter) { }

}

