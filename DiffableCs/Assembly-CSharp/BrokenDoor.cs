//Type is in global namespace

public class BrokenDoor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SplintersGoneForGood>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BrokenDoor <>4__this; //Field offset: 0x20
		private float <timePass>5__2; //Field offset: 0x28

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
		public <SplintersGoneForGood>d__10(int <>1__state) { }

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

	public Rigidbody[] Splinters; //Field offset: 0x20
	public Vector3 ExplosionCenter; //Field offset: 0x28
	public ParticleSystem VFX; //Field offset: 0x38
	[Header("Turned ON when breaking door")]
	public GameObject[] On; //Field offset: 0x40
	[Header("Turned OFF when breaking door")]
	public GameObject[] Off; //Field offset: 0x48
	public Collider[] IgnoreColliders; //Field offset: 0x50

	public BrokenDoor() { }

	public void Breach(Vector3 playerPosition) { }

	public void BreachQuick() { }

	public void Init() { }

	public void OnDrawGizmos() { }

	[IteratorStateMachine(typeof(<SplintersGoneForGood>d__10))]
	private IEnumerator SplintersGoneForGood() { }

}

