//Type is in global namespace

public class ColliderExtrusion : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CalculateCoroutine>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Vector3 position; //Field offset: 0x20
		public ColliderExtrusion <>4__this; //Field offset: 0x30
		private Vector3 <resolvedPoint>5__2; //Field offset: 0x38
		private int <penetrationCount>5__3; //Field offset: 0x44
		private int <j>5__4; //Field offset: 0x48

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
		public <CalculateCoroutine>d__20(int <>1__state) { }

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

	private const int _maxNeighboursColliders = 16; //Field offset: 0x0
	[SerializeField]
	private Collider _collider; //Field offset: 0x20
	[SerializeField]
	private float _castHalo; //Field offset: 0x28
	[SerializeField]
	private LayerMask _castMask; //Field offset: 0x2C
	private Collider[] _neighboursColliders; //Field offset: 0x30
	private int _neighboursCount; //Field offset: 0x38
	private float _castRadius; //Field offset: 0x3C
	private Vector3 _depenetration; //Field offset: 0x40
	private WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0x50
	private HashSet _ignoredColliders; //Field offset: 0x58

	public Collider Collider
	{
		 get { } //Length: 5
	}

	public ColliderExtrusion() { }

	public void AddIgnoredCollider(Collider collider) { }

	public void Calculate() { }

	public void Calculate(Vector3 position, Quaternion rotation, float depenetrationModification = 0.001) { }

	private void CalculateCastRadius() { }

	[IteratorStateMachine(typeof(<CalculateCoroutine>d__20))]
	public IEnumerator CalculateCoroutine(Vector3 position) { }

	public Vector3 CalculateDepenetration(Vector3 position, Quaternion rotation, float depenetrationModification = 0.001) { }

	public void CalculateThroughMotion(Vector3 motion) { }

	public Collider get_Collider() { }

	public Vector3 GetDepenetration() { }

	public void Init(LayerMask castMask) { }

	private bool IsColliderIgnored(Collider collider) { }

	public void RefreshNeighbours(Vector3 position, Vector3 motion) { }

	public void RemoveIgnoredCollider(Collider collider) { }

	public void SetCollider(Collider newCollider) { }

}

