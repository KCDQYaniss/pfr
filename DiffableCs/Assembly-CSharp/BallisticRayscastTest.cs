//Type is in global namespace

[ExecuteInEditMode]
public class BallisticRayscastTest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <DoRaycasts3>b__13_0(RaycastHit hit) { }

	}

	[SerializeField]
	private Transform _point1; //Field offset: 0x20
	[SerializeField]
	private Transform _point2; //Field offset: 0x28
	[SerializeField]
	private float _forwardRadius; //Field offset: 0x30
	[SerializeField]
	private float _backwardRadius; //Field offset: 0x34
	[SerializeField]
	private int _forwardCount; //Field offset: 0x38
	private RaycastHit[] _forward; //Field offset: 0x40
	[SerializeField]
	private int _backwardCount; //Field offset: 0x48
	private RaycastHit[] _backward; //Field offset: 0x50
	[SerializeField]
	private bool _hitFound; //Field offset: 0x58
	private RaycastHit _hit; //Field offset: 0x5C

	public BallisticRayscastTest() { }

	private int DoRaycast(Vector3 point1, Vector3 point2, RaycastHit[] hits) { }

	private void DoRaycasts() { }

	private void DoRaycasts2() { }

	private void DoRaycasts3() { }

	private void Draw(RaycastHit[] hits, int count, float radius, Color color) { }

	public void OnDrawGizmos() { }

	private void Update() { }

}

