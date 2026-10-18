//Type is in global namespace

public class VehicleSuspension : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DisableSuspension>d__21 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public VehicleSuspension <>4__this; //Field offset: 0x28

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
		public <DisableSuspension>d__21(int <>1__state) { }

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
	private sealed class <EnableSuspensionCoroutine>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public VehicleSuspension <>4__this; //Field offset: 0x28

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
		public <EnableSuspensionCoroutine>d__20(int <>1__state) { }

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

	public Rigidbody parentBody; //Field offset: 0x20
	public ConfigurableJoint joint; //Field offset: 0x28
	public SuspensionSpring springFLeft; //Field offset: 0x30
	public SuspensionSpring springFRight; //Field offset: 0x38
	public SuspensionSpring springBLeft; //Field offset: 0x40
	public SuspensionSpring springBRight; //Field offset: 0x48
	public bool suspensionEnabled; //Field offset: 0x50
	public Collider SuspensionCollider; //Field offset: 0x58
	public GameObject ViewRoot; //Field offset: 0x60
	private Coroutine _enableSuspensionCoroutine; //Field offset: 0x68
	private Coroutine _disableSuspensionCoroutine; //Field offset: 0x70
	private float previousInertiaOffset; //Field offset: 0x78

	public VehicleSuspension() { }

	public void AddViewCollidersToIgnore() { }

	[IteratorStateMachine(typeof(<DisableSuspension>d__21))]
	private IEnumerator DisableSuspension(float time) { }

	public void DisableSuspensionCoroutineStart(float time) { }

	[IteratorStateMachine(typeof(<EnableSuspensionCoroutine>d__20))]
	private IEnumerator EnableSuspensionCoroutine(float time) { }

	public void EnableSuspensionCoroutineStart(float time) { }

	private void OnDestroy() { }

	public void SetSuspensionInertiaOffset(float offset) { }

	public void SetSuspensionParams(float restLength, float travel, float springStiffness, float damperStiffness, float wheelRadius) { }

	private void SetVehicleSpringParams(VehicleSuspensionSpring spring, float restLength, float travel, float springStiffness, float damperStiffness, float wheelRadius) { }

	public void SuspensionOff() { }

	public void SuspensionOn() { }

}

