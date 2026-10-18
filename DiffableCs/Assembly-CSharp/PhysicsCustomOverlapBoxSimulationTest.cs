//Type is in global namespace

public class PhysicsCustomOverlapBoxSimulationTest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Test_Coroutine>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PhysicsCustomOverlapBoxSimulationTest <>4__this; //Field offset: 0x20
		private AwaitMultiWorldsOverlapBoxAsyncData <awaitData>5__2; //Field offset: 0x28

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
		public <Test_Coroutine>d__16(int <>1__state) { }

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

	internal class BoxColliderGizmoDrawer : MonoBehaviour
	{
		public BoxCollider Tester; //Field offset: 0x20
		public BoxCollider Collider; //Field offset: 0x28
		public bool IsOverlapDetected; //Field offset: 0x30
		public bool IsTriggerDetected; //Field offset: 0x31
		public bool IsTriggerDetectedPrevFrame; //Field offset: 0x32
		public Func AllowSimulatePhysics; //Field offset: 0x38

		public BoxColliderGizmoDrawer() { }

		private void OnDrawGizmos() { }

		private void OnTriggerEnter(Collider other) { }

		private void OnTriggerExit(Collider other) { }

	}

	[SerializeField]
	private BoxCollider _tester; //Field offset: 0x20
	[SerializeField]
	private LayerMask _layerMask; //Field offset: 0x28
	[SerializeField]
	private bool _manualMode; //Field offset: 0x2C
	[SerializeField]
	private bool _simulateTriggers; //Field offset: 0x2D
	private BoxCollider[] _triggers; //Field offset: 0x30
	private Dictionary _overlapDrawer; //Field offset: 0x38
	private BoxColliderGizmoDrawer[] _overlapDrawerList; //Field offset: 0x40
	private OverlapBoxSearcher _searcher; //Field offset: 0x48
	private Collider[] _result; //Field offset: 0x50
	private Collider[][] _resultBuffer; //Field offset: 0x58
	private Transform _testerTransform; //Field offset: 0x60
	private bool _processCurrentFrame; //Field offset: 0x68

	public PhysicsCustomOverlapBoxSimulationTest() { }

	[CompilerGenerated]
	private bool <Awake>b__12_0(BoxCollider col) { }

	[CompilerGenerated]
	private bool <Start>b__13_0() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void ProcessOverlapResult(int count, Collider[] result) { }

	private void Start() { }

	[IteratorStateMachine(typeof(<Test_Coroutine>d__16))]
	private IEnumerator Test_Coroutine() { }

	private void Update() { }

}

