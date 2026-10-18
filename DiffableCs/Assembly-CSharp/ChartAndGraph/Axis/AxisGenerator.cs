namespace ChartAndGraph.Axis;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
internal class AxisGenerator : MonoBehaviour, IAxisGenerator
{
	private static readonly int _chartTiling; //Field offset: 0x0
	private MeshRenderer mRenderer; //Field offset: 0x20
	private MeshFilter mFilter; //Field offset: 0x28
	private Mesh mCleanMesh; //Field offset: 0x30
	private AxisBase mAxis; //Field offset: 0x38
	private Material mDispose; //Field offset: 0x40
	private Material mMaterial; //Field offset: 0x48
	private float mTiling; //Field offset: 0x50
	private WorldSpaceChartMesh mMesh; //Field offset: 0x58
	private Mesh mCreated; //Field offset: 0x60

	private static AxisGenerator() { }

	public AxisGenerator() { }

	public override GameObject GetGameObject() { }

	private float GetTiling(AnyChart parent, ChartOrientation orientation, ChartDivisionInfo inf) { }

	private void OnDestroy() { }

	public override void SetAxis(double scrollOffset, AnyChart parent, AxisBase axis, ChartOrientation axisOrientation, bool isSubDivisions) { }

	public override Object This() { }

	protected override void Update() { }

}

