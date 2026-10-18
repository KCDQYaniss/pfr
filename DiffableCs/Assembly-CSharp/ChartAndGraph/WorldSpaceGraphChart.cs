namespace ChartAndGraph;

public class WorldSpaceGraphChart : GraphChartBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector3 <InternalGenerateChart>b__27_0(DoubleVector3 x) { }

	}

	[SerializeField]
	private float _textIdleDistance; //Field offset: 0x100
	[SerializeField]
	[Tooltip("If this value is set all the text in the chart will be rendered to this specific camera. otherwise text is rendered to the main camera")]
	private Camera _textCamera; //Field offset: 0x108
	private readonly Dictionary _texts; //Field offset: 0x110
	private float _totalDepth; //Field offset: 0x118
	private GameObject _emptyPointPrefab; //Field offset: 0x120
	private readonly HashSet _activeTexts; //Field offset: 0x128

	public Camera TextCamera
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	protected virtual Camera TextCameraLink
	{
		 get { } //Length: 8
	}

	public float TextIdleDistance
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	protected virtual float TextIdleDistanceLink
	{
		 get { } //Length: 9
	}

	protected virtual float TotalDepthLink
	{
		 get { } //Length: 9
	}

	public WorldSpaceGraphChart() { }

	private void AddBillboardText(string cat, BillboardText text) { }

	protected virtual void ClearChart() { }

	private FillPathGenerator CreateFillObject(CategoryData data) { }

	private PathGenerator CreateLineObject(CategoryData data) { }

	private GameObject CreatePointObject(CategoryData data) { }

	public virtual void GenerateRealtime() { }

	public Camera get_TextCamera() { }

	protected virtual Camera get_TextCameraLink() { }

	public float get_TextIdleDistance() { }

	protected virtual float get_TextIdleDistanceLink() { }

	protected virtual float get_TotalDepthLink() { }

	public virtual void InternalGenerateChart() { }

	protected virtual void OnItemHoverted(object userData) { }

	protected virtual void OnNonHoverted() { }

	protected virtual void OnPropertyUpdated() { }

	public void set_TextCamera(Camera value) { }

	public void set_TextIdleDistance(float value) { }

}

