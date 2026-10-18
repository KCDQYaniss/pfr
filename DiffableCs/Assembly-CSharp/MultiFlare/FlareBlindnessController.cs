namespace MultiFlare;

public class FlareBlindnessController
{
	[CompilerGenerated]
	private sealed class <Execute>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FlareBlindnessController <>4__this; //Field offset: 0x20

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
		public <Execute>d__8(int <>1__state) { }

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

	private readonly MonoBehaviour _owner; //Field offset: 0x10
	private readonly FlareSettings _settings; //Field offset: 0x18
	private float _currentValue; //Field offset: 0x20
	private float _desiredValue; //Field offset: 0x24
	private Coroutine _routine; //Field offset: 0x28

	public FlareBlindnessController(MonoBehaviour owner, FlareSettings settings, float initValue) { }

	public void Disable() { }

	public void Enable(float value) { }

	[IteratorStateMachine(typeof(<Execute>d__8))]
	private IEnumerator Execute() { }

	private void TryStopRoutine() { }

}

