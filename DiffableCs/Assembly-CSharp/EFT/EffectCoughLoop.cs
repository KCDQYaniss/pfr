namespace EFT;

public sealed class EffectCoughLoop
{
	[CompilerGenerated]
	private sealed class <CO_Loop>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float interval; //Field offset: 0x20
		public EffectCoughLoop <>4__this; //Field offset: 0x28
		private WaitForSeconds <wait>5__2; //Field offset: 0x30

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
		public <CO_Loop>d__10(int <>1__state) { }

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

	private readonly Player _player; //Field offset: 0x10
	private readonly HashSet _sources; //Field offset: 0x18
	private Coroutine _loop; //Field offset: 0x20

	public EffectCoughLoop(Player player) { }

	[IteratorStateMachine(typeof(<CO_Loop>d__10))]
	private IEnumerator CO_Loop(float interval) { }

	public static bool IsCoughCausingEffect(IHealthEffect healthEffect) { }

	public void OnEffectRemoved(IHealthEffect healthEffect) { }

	public void OnEffectStarted(IHealthEffect healthEffect) { }

	public void Stop() { }

	private void StopLoop() { }

	private void TryStart() { }

}

