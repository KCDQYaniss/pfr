namespace ChartAndGraph.Axis;

[ExecuteInEditMode]
[RequireComponent(typeof(CanvasRenderer))]
internal class CanvasAxisGenerator : Image, IAxisGenerator
{
	private static readonly int _chartTiling; //Field offset: 0x0
	private MeshRenderer mRenderer; //Field offset: 0x118
	private MeshFilter mFilter; //Field offset: 0x120
	private Mesh mCleanMesh; //Field offset: 0x128
	private AxisBase mAxis; //Field offset: 0x130
	private AnyChart mParent; //Field offset: 0x138
	private ChartOrientation mOrientation; //Field offset: 0x140
	private bool mIsSubDivisions; //Field offset: 0x144
	private Material mDispose; //Field offset: 0x148
	private Material mMaterial; //Field offset: 0x150
	private CanvasChartMesh mMesh; //Field offset: 0x158
	private float mTiling; //Field offset: 0x160
	private double mScrollOffset; //Field offset: 0x168

	private static CanvasAxisGenerator() { }

	public CanvasAxisGenerator() { }

	private void AddToCanvasChartMesh(CanvasChartMesh mesh) { }

	public override GameObject GetGameObject() { }

	private float GetTiling(MaterialTiling tiling) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	protected virtual void OnPopulateMesh(Mesh m) { }

	public override void SetAxis(double scrollOffset, AnyChart parent, AxisBase axis, ChartOrientation axisOrientation, bool isSubDivisions) { }

	public override Object This() { }

	protected override void Update() { }

	protected virtual void UpdateMaterial() { }

}

