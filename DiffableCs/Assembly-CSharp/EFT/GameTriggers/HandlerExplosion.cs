namespace EFT.GameTriggers;

public class HandlerExplosion : BaseTriggerHandler
{
	[CompilerGenerated]
	private sealed class <Explosion>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HandlerExplosion <>4__this; //Field offset: 0x20
		public int playerRaidId; //Field offset: 0x28

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
		public <Explosion>d__7(int <>1__state) { }

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
	private MineSettings _mineSettings; //Field offset: 0x28
	[SerializeField]
	private EDamageType _damageType; //Field offset: 0x98
	private bool _isDone; //Field offset: 0x9C

	private static IBallisticsCalculator Calculator
	{
		private get { } //Length: 93
	}

	public HandlerExplosion() { }

	[CompilerGenerated]
	private DamageInfo <Explosion>b__7_0() { }

	[IteratorStateMachine(typeof(<Explosion>d__7))]
	private IEnumerator Explosion(int playerRaidId) { }

	private static IBallisticsCalculator get_Calculator() { }

	private DamageInfo GetDamageInfo(MineSettings mineSettings) { }

	private void OnExplosionTriggerEvent(TriggerEvent triggerEvent) { }

	private void Start() { }

}

