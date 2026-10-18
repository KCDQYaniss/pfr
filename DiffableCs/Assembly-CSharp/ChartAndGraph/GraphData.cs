namespace ChartAndGraph;

public class GraphData : IInternalGraphData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public string category; //Field offset: 0x10

		public <>c__DisplayClass72_0() { }

		internal bool <RemoveCategory>b__0(Slider x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public string category; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <ClearCategory>b__0(Slider x) { }

	}

	internal class CategoryData
	{
		public string Name; //Field offset: 0x10
		public bool IsBezierCurve; //Field offset: 0x18
		public int SegmentsPerCurve; //Field offset: 0x1C
		public List mTmpCurveData; //Field offset: 0x20
		public List Data; //Field offset: 0x28
		public bool Regenerate; //Field offset: 0x30
		public Nullable MaxX; //Field offset: 0x38
		public Nullable MaxY; //Field offset: 0x48
		public Nullable MinX; //Field offset: 0x58
		public Nullable MinY; //Field offset: 0x68
		public Nullable MaxRadius; //Field offset: 0x78
		public ChartItemEffect LineHoverPrefab; //Field offset: 0x88
		public ChartItemEffect PointHoverPrefab; //Field offset: 0x90
		public Material LineMaterial; //Field offset: 0x98
		public MaterialTiling LineTiling; //Field offset: 0xA0
		public double LineThickness; //Field offset: 0xA8
		public Material FillMaterial; //Field offset: 0xB0
		public bool StetchFill; //Field offset: 0xB8
		public Material PointMaterial; //Field offset: 0xC0
		public double PointSize; //Field offset: 0xC8
		public PathGenerator LinePrefab; //Field offset: 0xD0
		public FillPathGenerator FillPrefab; //Field offset: 0xD8
		public GameObject DotPrefab; //Field offset: 0xE0
		public double Depth; //Field offset: 0xE8

		public CategoryData() { }

		public void AddInnerCurve(DoubleVector3 p1, DoubleVector3 c1, DoubleVector3 c2, DoubleVector3 p2) { }

		public List getPoints() { }

	}

	internal class SerializedCategory
	{
		[NonCanvas]
		public double Depth; //Field offset: 0x10
		[NonCanvas]
		public PathGenerator LinePrefab; //Field offset: 0x18
		[NonCanvas]
		public FillPathGenerator FillPrefab; //Field offset: 0x20
		[NonCanvas]
		public GameObject DotPrefab; //Field offset: 0x28
		[HideInInspector]
		public DoubleVector3[] data; //Field offset: 0x30
		[HideInInspector]
		public Nullable MaxX; //Field offset: 0x38
		[HideInInspector]
		public Nullable MaxY; //Field offset: 0x48
		[HideInInspector]
		public Nullable MinX; //Field offset: 0x58
		[HideInInspector]
		public Nullable MinY; //Field offset: 0x68
		[HideInInspector]
		public Nullable MaxRadius; //Field offset: 0x78
		public string Name; //Field offset: 0x88
		public bool IsBezierCurve; //Field offset: 0x90
		public int SegmentsPerCurve; //Field offset: 0x94
		public ChartItemEffect LineHoverPrefab; //Field offset: 0x98
		public ChartItemEffect PointHoverPrefab; //Field offset: 0xA0
		public Material Material; //Field offset: 0xA8
		public MaterialTiling LineTiling; //Field offset: 0xB0
		public Material InnerFill; //Field offset: 0xB8
		public double LineThickness; //Field offset: 0xC0
		public bool StetchFill; //Field offset: 0xC8
		public Material PointMaterial; //Field offset: 0xD0
		public double PointSize; //Field offset: 0xD8

		public SerializedCategory() { }

	}

	private class Slider
	{
		public string category; //Field offset: 0x10
		public int from; //Field offset: 0x18
		public DoubleVector3 To; //Field offset: 0x20
		public DoubleVector3 current; //Field offset: 0x38
		public int index; //Field offset: 0x50
		public double startTime; //Field offset: 0x58
		public double totalTime; //Field offset: 0x60

		public Slider() { }

	}

	internal class VectorComparer : IComparer
	{

		public VectorComparer() { }

		public override int Compare(DoubleVector3 x, DoubleVector3 y) { }

	}

	[CompilerGenerated]
	private EventHandler DataChanged; //Field offset: 0x10
	[CompilerGenerated]
	private EventHandler RealtimeDataChanged; //Field offset: 0x18
	private bool _suspendEvents; //Field offset: 0x20
	private bool _sliderUpdated; //Field offset: 0x21
	private List mTmpDriv; //Field offset: 0x28
	[SerializeField]
	private double automaticVerticalViewGap; //Field offset: 0x30
	[SerializeField]
	private bool automaticVerticallView; //Field offset: 0x38
	[SerializeField]
	private double automaticcHorizontaViewGap; //Field offset: 0x40
	[SerializeField]
	private bool automaticHorizontalView; //Field offset: 0x48
	[SerializeField]
	private double horizontalViewSize; //Field offset: 0x50
	[SerializeField]
	private double horizontalViewOrigin; //Field offset: 0x58
	[SerializeField]
	private double verticalViewSize; //Field offset: 0x60
	[SerializeField]
	private double verticalViewOrigin; //Field offset: 0x68
	private List _sliders; //Field offset: 0x70
	private VectorComparer _comparer; //Field offset: 0x78
	private Dictionary _categoryData; //Field offset: 0x80
	[SerializeField]
	private SerializedCategory[] mSerializedData; //Field offset: 0x88

	private override event EventHandler ChartAndGraph.IInternalGraphData.InternalDataChanged
	{
		private add { } //Length: 235
		private remove { } //Length: 235
	}

	private override event EventHandler ChartAndGraph.IInternalGraphData.InternalRealTimeDataChanged
	{
		private add { } //Length: 235
		private remove { } //Length: 235
	}

	private event EventHandler DataChanged
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	private event EventHandler RealtimeDataChanged
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public double AutomaticcHorizontaViewGap
	{
		 get { } //Length: 6
		 set { } //Length: 67
	}

	public bool AutomaticHorizontalView
	{
		 get { } //Length: 5
		 set { } //Length: 63
	}

	public bool AutomaticVerticallView
	{
		 get { } //Length: 5
		 set { } //Length: 65
	}

	public double AutomaticVerticallViewGap
	{
		 get { } //Length: 6
		 set { } //Length: 67
	}

	private override IEnumerable ChartAndGraph.IInternalGraphData.Categories
	{
		private get { } //Length: 76
	}

	private override int ChartAndGraph.IInternalGraphData.TotalCategories
	{
		private get { } //Length: 71
	}

	public double HorizontalViewOrigin
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public double HorizontalViewSize
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public double VerticalViewOrigin
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public double VerticalViewSize
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public GraphData() { }

	[CompilerGenerated]
	private bool <Update>b__51_0(Slider x) { }

	[CompilerGenerated]
	private void add_DataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void add_RealtimeDataChanged(EventHandler value) { }

	public void AddCategory(string category, Material lineMaterial, double lineThickness, MaterialTiling lineTiling, Material innerFill, bool strechFill, Material pointMaterial, double pointSize) { }

	public void AddCategory3DGraph(string category, PathGenerator linePrefab, Material lineMaterial, double lineThickness, MaterialTiling lineTiling, FillPathGenerator fillPrefab, Material innerFill, bool strechFill, GameObject pointPrefab, Material pointMaterial, double pointSize, double depth, bool isCurve, int segmentsPerCurve) { }

	public void AddCurveToCategory(string category, DoubleVector2 controlPointA, DoubleVector2 controlPointB, DoubleVector2 toPoint, double pointSize = -1) { }

	public void AddLinearCurveToCategory(string category, DoubleVector2 toPoint, double pointSize = -1) { }

	public void AddPointToCategory(string category, DateTime x, DateTime y, double pointSize = -1) { }

	public void AddPointToCategory(string category, double x, DateTime y, double pointSize = -1) { }

	public void AddPointToCategory(string category, double x, double y, double pointSize = -1) { }

	public void AddPointToCategory(string category, DateTime x, double y, double pointSize = -1) { }

	public void AddPointToCategoryRealtime(string category, DateTime x, DateTime y, double slideTime = 0, double pointSize = -1) { }

	public void AddPointToCategoryRealtime(string category, DateTime x, double y, double slideTime = 0, double pointSize = -1) { }

	public void AddPointToCategoryRealtime(string category, double x, DateTime y, double slideTime = 0, double pointSize = -1) { }

	public void AddPointToCategoryRealtime(string category, double x, double y, double slideTime = 0, double pointSize = -1) { }

	private override void ChartAndGraph.IInternalGraphData.add_InternalDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalGraphData.add_InternalRealTimeDataChanged(EventHandler value) { }

	private override IEnumerable ChartAndGraph.IInternalGraphData.get_Categories() { }

	private override int ChartAndGraph.IInternalGraphData.get_TotalCategories() { }

	private override double ChartAndGraph.IInternalGraphData.GetMaxValue(int axis, bool dataValue) { }

	private override double ChartAndGraph.IInternalGraphData.GetMinValue(int axis, bool dataValue) { }

	private override void ChartAndGraph.IInternalGraphData.OnAfterDeserialize() { }

	private override void ChartAndGraph.IInternalGraphData.OnBeforeSerialize() { }

	private override void ChartAndGraph.IInternalGraphData.remove_InternalDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalGraphData.remove_InternalRealTimeDataChanged(EventHandler value) { }

	public void Clear() { }

	public void ClearAndMakeBezierCurve(string category) { }

	public void ClearAndMakeLinear(string category) { }

	public void ClearCategory(string category) { }

	public void EndBatch() { }

	public double get_AutomaticcHorizontaViewGap() { }

	public bool get_AutomaticHorizontalView() { }

	public bool get_AutomaticVerticallView() { }

	public double get_AutomaticVerticallViewGap() { }

	public double get_HorizontalViewOrigin() { }

	public double get_HorizontalViewSize() { }

	public double get_VerticalViewOrigin() { }

	public double get_VerticalViewSize() { }

	public DoubleVector3 GetPoint(string category, int index) { }

	public bool HasCategory(string category) { }

	public void MakeCurveCategorySmooth(string category) { }

	private DoubleVector2 max3(DoubleVector2 a, DoubleVector2 b, DoubleVector2 c) { }

	private double max3(double a, double b, double c) { }

	private double min3(double a, double b, double c) { }

	private DoubleVector2 min3(DoubleVector2 a, DoubleVector2 b, DoubleVector2 c) { }

	private static void ModifyMinMax(CategoryData data, DoubleVector3 point) { }

	private void RaiseDataChanged() { }

	private void RaiseRealtimeDataChanged() { }

	[CompilerGenerated]
	private void remove_DataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void remove_RealtimeDataChanged(EventHandler value) { }

	public bool RemoveCategory(string category) { }

	public void RenameCategory(string prevName, string newName) { }

	public void RestoreDataValues() { }

	private void RestoreDataValues(int axis) { }

	public void set_AutomaticcHorizontaViewGap(double value) { }

	public void set_AutomaticHorizontalView(bool value) { }

	public void set_AutomaticVerticallView(bool value) { }

	public void set_AutomaticVerticallViewGap(double value) { }

	public void set_HorizontalViewOrigin(double value) { }

	public void set_HorizontalViewSize(double value) { }

	public void set_VerticalViewOrigin(double value) { }

	public void set_VerticalViewSize(double value) { }

	public void Set2DCategoryPrefabs(string category, ChartItemEffect lineHover, ChartItemEffect pointHover) { }

	public void Set3DCategoryDepth(string category, double depth) { }

	public void Set3DCategoryPrefabs(string category, PathGenerator linePrefab, FillPathGenerator fillPrefab, GameObject dotPrefab) { }

	public void SetCategoryFill(string category, Material fillMaterial, bool strechFill) { }

	public void SetCategoryLine(string category, Material lineMaterial, double lineThickness, MaterialTiling lineTiling) { }

	public void SetCategoryPoint(string category, Material pointMaterial, double pointSize) { }

	public void SetCurveInitialPoint(string category, double x, double y, double pointSize = -1) { }

	public void SetCurveInitialPoint(string category, double x, DateTime y, double pointSize = -1) { }

	public void SetCurveInitialPoint(string category, DateTime x, DateTime y, double pointSize = -1) { }

	public void SetCurveInitialPoint(string category, DateTime x, double y, double pointSize = -1) { }

	public void StartBatch() { }

	public override void Update() { }

}

