namespace EFT.GameTriggers;

public class HandlerPlayerCameraShake : BaseTriggerHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <Start>b__5_0(CustomExplosionShakeSettingsWithTime x) { }

	}

	[CompilerGenerated]
	private sealed class <OnTriggerCoroutine>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HandlerPlayerCameraShake <>4__this; //Field offset: 0x20

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
		public <OnTriggerCoroutine>d__8(int <>1__state) { }

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

	internal struct CustomExplosionShakeSettingsWithTime
	{
		public float OnSecond; //Field offset: 0x0
		public float RotationShakeStrength; //Field offset: 0x4
		public float PositionShakeStrength; //Field offset: 0x8

	}

	[SerializeField]
	private CustomExplosionShakeSettings _linearShakeSettings; //Field offset: 0x28
	[SerializeField]
	private List _linearShakeSettingsWithTime; //Field offset: 0x30
	private List _orderedLinearShakeSettingsWithTime; //Field offset: 0x38
	private Coroutine _linearCameraShakeCoroutine; //Field offset: 0x40
	private float _coroutineTimer; //Field offset: 0x48

	public HandlerPlayerCameraShake() { }

	private void OnDestroy() { }

	private void OnTrigger(TriggerEvent triggerEvent) { }

	[IteratorStateMachine(typeof(<OnTriggerCoroutine>d__8))]
	private IEnumerator OnTriggerCoroutine(TriggerEvent triggerEvent) { }

	private void Start() { }

}

