namespace EFT.Animals;

[RequireComponent(typeof(Bird))]
public class BirdBoidBrain : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CalculateVelocity>d__13 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BirdBoidBrain <>4__this; //Field offset: 0x20

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
		public <CalculateVelocity>d__13(int <>1__state) { }

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
	private sealed class <UpdateBirdDirection>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BirdBoidBrain <>4__this; //Field offset: 0x20

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
		public <UpdateBirdDirection>d__14(int <>1__state) { }

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

	protected const string _birdsLayer = "Water"; //Field offset: 0x0
	protected Bird _bird; //Field offset: 0x20
	protected int _layersMask; //Field offset: 0x28
	protected SphereCollider _collider; //Field offset: 0x30
	protected Vector3 _cohesion; //Field offset: 0x38
	protected Vector3 _separation; //Field offset: 0x44
	protected Vector3 _alignment; //Field offset: 0x50
	[HideInInspector]
	public Vector3 Velocity; //Field offset: 0x5C
	[HideInInspector]
	public Transform TransformCache; //Field offset: 0x68
	protected BirdBoidsSpawner _swarmBrain; //Field offset: 0x70

	public BirdBoidBrain() { }

	[IteratorStateMachine(typeof(<CalculateVelocity>d__13))]
	protected IEnumerator CalculateVelocity() { }

	public void Init(BirdBoidsSpawner swarmBrain) { }

	protected void Start() { }

	protected void Update() { }

	[IteratorStateMachine(typeof(<UpdateBirdDirection>d__14))]
	protected IEnumerator UpdateBirdDirection() { }

}

