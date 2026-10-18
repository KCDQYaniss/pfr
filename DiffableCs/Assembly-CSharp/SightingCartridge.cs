//Type is in global namespace

[RequireComponent(typeof(LineRenderer))]
public class SightingCartridge : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Start>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SightingCartridge <>4__this; //Field offset: 0x20
		private OperationAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly int _color; //Field offset: 0x0
	public Transform WeaponHierarchy; //Field offset: 0x20
	private Transform _muzzle; //Field offset: 0x28
	private Vector3 hitPoint; //Field offset: 0x30
	private LineRenderer _lr; //Field offset: 0x40
	public float GizmoSize; //Field offset: 0x48
	private GameObject _sphere; //Field offset: 0x50

	private static SightingCartridge() { }

	public SightingCartridge() { }

	[AsyncStateMachine(typeof(<Start>d__7))]
	private Task Start() { }

	private void Update() { }

	private void UpdateLineRenderer(Transform hier) { }

}

