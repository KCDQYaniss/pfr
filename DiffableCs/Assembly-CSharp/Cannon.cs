//Type is in global namespace

public class Cannon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <FireCannon>d__13 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Cannon <>4__this; //Field offset: 0x20
		private RaycastHit <hit>5__2; //Field offset: 0x28

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
		public <FireCannon>d__13(int <>1__state) { }

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

	public float Distance; //Field offset: 0x20
	public float XSpeed; //Field offset: 0x24
	public float YSpeed; //Field offset: 0x28
	public float YMinLimit; //Field offset: 0x2C
	public float YMaxLimit; //Field offset: 0x30
	[Range(0, 50000)]
	public float Force; //Field offset: 0x34
	public Transform Target; //Field offset: 0x38
	private float _x; //Field offset: 0x40
	private float _y; //Field offset: 0x44

	public Cannon() { }

	private static float ClampAngle(float angle, float min, float max) { }

	[IteratorStateMachine(typeof(<FireCannon>d__13))]
	private IEnumerator FireCannon() { }

	private void Start() { }

	private void Update() { }

	private void UpdatePosition() { }

}

