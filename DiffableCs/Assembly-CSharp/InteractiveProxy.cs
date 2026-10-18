//Type is in global namespace

public class InteractiveProxy : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Flick>d__11 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InteractiveProxy <>4__this; //Field offset: 0x20
		private float <t>5__2; //Field offset: 0x28

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
		public <Flick>d__11(int <>1__state) { }

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

	public WorldInteractiveObject Link; //Field offset: 0x20
	public GripPose[] Grips; //Field offset: 0x28
	public DoorHandle Handle; //Field offset: 0x30
	public Light StatusLight; //Field offset: 0x38
	public Light FlickerLight; //Field offset: 0x40
	public AnimationCurve FlickCurve; //Field offset: 0x48
	[SerializeField]
	private Vector3 _viewTarget; //Field offset: 0x50
	[SerializeField]
	private Vector3 _interactionPosition; //Field offset: 0x5C

	public InteractiveProxy() { }

	[IteratorStateMachine(typeof(<Flick>d__11))]
	private IEnumerator Flick() { }

	public Vector3 GetInteractionPosition(Vector3 yourPosition) { }

	public Vector3 GetViewDirection(Vector3 yourPosition) { }

	private void OnDoorStateChanged(WorldInteractiveObject obj, EDoorState prevstate, EDoorState nextstate) { }

	private void OnDrawGizmos() { }

	private void OnValidate() { }

	private void Start() { }

	public void StartFlicker() { }

}

