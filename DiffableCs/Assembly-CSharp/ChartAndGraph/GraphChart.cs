namespace ChartAndGraph;

public class GraphChart : GraphChartBase, ICanvas
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__32_3; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector4 <InternalGenerateChart>b__32_3(DoubleVector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public string catName; //Field offset: 0x10
		public GraphChart <>4__this; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <InternalGenerateChart>b__0(int idx, Vector2 pos) { }

		internal void <InternalGenerateChart>b__1(int idx, Vector2 pos) { }

		internal void <InternalGenerateChart>b__2() { }

	}

	private class CategoryObject
	{
		public CanvasChartMesh mItemLabels; //Field offset: 0x10
		public CanvasLines mLines; //Field offset: 0x18
		public CanvasLines mDots; //Field offset: 0x20
		public CanvasLines mFill; //Field offset: 0x28
		public Dictionary mCahced; //Field offset: 0x30

		public CategoryObject() { }

	}

	private Vector2 mLastSetSize; //Field offset: 0x100
	private HashSet mOccupiedCateogies; //Field offset: 0x108
	private Dictionary mTexts; //Field offset: 0x110
	private HashSet mActiveTexts; //Field offset: 0x118
	private Dictionary mCategoryObjects; //Field offset: 0x120
	private List mTmpData; //Field offset: 0x128
	private List mClipped; //Field offset: 0x130
	private List mTransformed; //Field offset: 0x138
	private List mTmpToRemove; //Field offset: 0x140
	private GameObject mFixPosition; //Field offset: 0x148
	private GameObject mMask; //Field offset: 0x150
	private Nullable mLastPosition; //Field offset: 0x158
	private GraphicRaycaster mCaster; //Field offset: 0x168
	private bool SupressRealtimeGeneration; //Field offset: 0x170
	private StringBuilder mRealtimeStringBuilder; //Field offset: 0x178
	public UnityEvent MousePan; //Field offset: 0x180
	[SerializeField]
	private bool horizontalPanning; //Field offset: 0x188
	[SerializeField]
	private bool verticalPanning; //Field offset: 0x189

	public bool HorizontalPanning
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public bool VerticalPanning
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public GraphChart() { }

	[CompilerGenerated]
	private bool <OnItemLeave>b__40_0(string x) { }

	private void AddBillboardText(string cat, int index, BillboardText text) { }

	private double AddRadius(double radius, double mag, double min, double max) { }

	protected virtual void ClearChart() { }

	private CanvasLines CreateDataObject(CategoryData data, GameObject rectMask) { }

	private GameObject CreateRectMask(Rect viewRect) { }

	private void Dots_Click(string category, int idx, Vector2 pos) { }

	private void Dots_Hover(string category, int idx, Vector2 pos) { }

	private void Dots_Leave(string category) { }

	private void FitCanvas() { }

	public virtual void GenerateRealtime() { }

	public bool get_HorizontalPanning() { }

	public bool get_VerticalPanning() { }

	private void HandleMouseDrag() { }

	public virtual void InternalGenerateChart() { }

	private void MouseDraged(Vector2 delta) { }

	protected virtual void OnItemHoverted(object userData) { }

	protected virtual void OnItemLeave(object userData) { }

	protected virtual void OnItemSelected(object userData) { }

	public void set_HorizontalPanning(bool value) { }

	public void set_VerticalPanning(bool value) { }

	protected virtual void Update() { }

}

