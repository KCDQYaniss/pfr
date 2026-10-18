namespace Audio.AmbientSubsystem.PathMoverStrategy;

public class PathMovementBackwardStrategy : PathMovementStrategyBase
{
	[CompilerGenerated]
	private sealed class <MoveCoroutine>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PathMovementBackwardStrategy <>4__this; //Field offset: 0x20
		public Action onDone; //Field offset: 0x28
		private float <duration>5__2; //Field offset: 0x30
		private float <elapsedTime>5__3; //Field offset: 0x34

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
		public <MoveCoroutine>d__7(int <>1__state) { }

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

	private float _progress; //Field offset: 0x58
	private Coroutine _moveCoroutine; //Field offset: 0x60
	private float _startTime; //Field offset: 0x68

	public virtual EMovementStrategy MovementStrategy
	{
		 get { } //Length: 3
	}

	public PathMovementBackwardStrategy(MonoBehaviour behaviour, IPositionTranslator posTranslator, Vector3[] points, float[] segmentLengths, float totalLength) { }

	public virtual EMovementStrategy get_MovementStrategy() { }

	[IteratorStateMachine(typeof(<MoveCoroutine>d__7))]
	private IEnumerator MoveCoroutine(Action onDone = null) { }

	protected virtual void OnExecute(Action onDone = null) { }

	protected virtual void ResetParameters(bool resetPosition = false) { }

	private void StopMoveCoroutine() { }

}

