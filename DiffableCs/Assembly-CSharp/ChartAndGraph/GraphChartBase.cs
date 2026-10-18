namespace ChartAndGraph;

[ExecuteInEditMode]
public abstract class GraphChartBase : AxisChart, ISerializationCallbackReceiver
{
	internal class GraphEvent : UnityEvent
	{

		public GraphEvent() { }

	}

	internal class GraphEventArgs
	{
		[CompilerGenerated]
		private float <Magnitude>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private int <Index>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private string <XString>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <YString>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Vector3 <Position>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private DoubleVector2 <Value>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private string <Category>k__BackingField; //Field offset: 0x48

		public private string Category
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private int Index
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private float Magnitude
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private Vector3 Position
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 16
		}

		public private DoubleVector2 Value
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public private string XString
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private string YString
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public GraphEventArgs(int index, Vector3 position, DoubleVector2 value, float magnitude, string category, string xString, string yString) { }

		[CompilerGenerated]
		public string get_Category() { }

		[CompilerGenerated]
		public int get_Index() { }

		[CompilerGenerated]
		public float get_Magnitude() { }

		[CompilerGenerated]
		public Vector3 get_Position() { }

		[CompilerGenerated]
		public DoubleVector2 get_Value() { }

		[CompilerGenerated]
		public string get_XString() { }

		[CompilerGenerated]
		public string get_YString() { }

		[CompilerGenerated]
		private void set_Category(string value) { }

		[CompilerGenerated]
		private void set_Index(int value) { }

		[CompilerGenerated]
		private void set_Magnitude(float value) { }

		[CompilerGenerated]
		private void set_Position(Vector3 value) { }

		[CompilerGenerated]
		private void set_Value(DoubleVector2 value) { }

		[CompilerGenerated]
		private void set_XString(string value) { }

		[CompilerGenerated]
		private void set_YString(string value) { }

	}

	[SerializeField]
	protected float heightRatio; //Field offset: 0xB8
	[SerializeField]
	protected float widthRatio; //Field offset: 0xBC
	public GraphEvent PointClicked; //Field offset: 0xC0
	public GraphEvent PointHovered; //Field offset: 0xC8
	public UnityEvent NonHovered; //Field offset: 0xD0
	[SerializeField]
	private bool scrollable; //Field offset: 0xD8
	[HideInInspector]
	[SerializeField]
	private bool autoScrollHorizontally; //Field offset: 0xD9
	[HideInInspector]
	[SerializeField]
	private double horizontalScrolling; //Field offset: 0xE0
	[HideInInspector]
	[SerializeField]
	private bool autoScrollVertically; //Field offset: 0xE8
	[HideInInspector]
	[SerializeField]
	private double verticalScrolling; //Field offset: 0xF0
	[HideInInspector]
	[SerializeField]
	protected GraphData Data; //Field offset: 0xF8

	public bool AutoScrollHorizontally
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public bool AutoScrollVertically
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public GraphData DataSource
	{
		 get { } //Length: 8
	}

	public float HeightRatio
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	public double HorizontalScrolling
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	public bool Scrollable
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	protected virtual bool SupportsCategoryLabels
	{
		 get { } //Length: 3
	}

	protected virtual bool SupportsGroupLables
	{
		 get { } //Length: 3
	}

	protected virtual bool SupportsItemLabels
	{
		 get { } //Length: 3
	}

	protected virtual float TotalDepthLink
	{
		 get { } //Length: 4
	}

	protected virtual float TotalHeightLink
	{
		 get { } //Length: 9
	}

	protected virtual float TotalWidthLink
	{
		 get { } //Length: 9
	}

	public double VerticalScrolling
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	public float WidthRatio
	{
		 get { } //Length: 9
		 set { } //Length: 28
	}

	protected GraphChartBase() { }

	protected int ClipPoints(IList points, List res, out Rect uv) { }

	private Rect CreateUvRect(Rect completeRect, Rect lineRect) { }

	public override void GenerateRealtime() { }

	public bool get_AutoScrollHorizontally() { }

	public bool get_AutoScrollVertically() { }

	public GraphData get_DataSource() { }

	public float get_HeightRatio() { }

	public double get_HorizontalScrolling() { }

	public bool get_Scrollable() { }

	protected virtual bool get_SupportsCategoryLabels() { }

	protected virtual bool get_SupportsGroupLables() { }

	protected virtual bool get_SupportsItemLabels() { }

	protected virtual float get_TotalDepthLink() { }

	protected virtual float get_TotalHeightLink() { }

	protected virtual float get_TotalWidthLink() { }

	public double get_VerticalScrolling() { }

	public float get_WidthRatio() { }

	protected virtual double GetScrollOffset(int axis) { }

	private void GraphChart_InternalDataChanged(object sender, EventArgs e) { }

	private void GraphChartBase_InternalRealTimeDataChanged(object sender, EventArgs e) { }

	protected virtual bool HasValues(AxisBase axis) { }

	private void HookEvents() { }

	protected DoubleVector4 interpolateInRect(Rect rect, DoubleVector3 point) { }

	protected virtual double MaxValue(AxisBase axis) { }

	protected virtual double MinValue(AxisBase axis) { }

	protected virtual void OnAxisValuesChanged() { }

	protected virtual void OnItemHoverted(object userData) { }

	protected virtual void OnItemSelected(object userData) { }

	protected virtual void OnLabelSettingChanged() { }

	protected virtual void OnLabelSettingsSet() { }

	protected virtual void OnValidate() { }

	public void set_AutoScrollHorizontally(bool value) { }

	public void set_AutoScrollVertically(bool value) { }

	public void set_HeightRatio(float value) { }

	public void set_HorizontalScrolling(double value) { }

	public void set_Scrollable(bool value) { }

	public void set_VerticalScrolling(double value) { }

	public void set_WidthRatio(float value) { }

	protected virtual void Start() { }

	protected string StringFromAxisFormat(double val, AxisBase axis) { }

	protected string StringFromAxisFormat(double val, AxisBase axis, int fractionDigits) { }

	protected DoubleVector4 TransformPoint(Rect viewRect, Vector3 point, DoubleVector2 min, DoubleVector2 range) { }

	protected void TransformPoints(IList points, List output, Rect viewRect, DoubleVector3 min, DoubleVector3 max) { }

	protected void TransformPoints(IList points, Rect viewRect, DoubleVector3 min, DoubleVector3 max) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	protected virtual void Update() { }

	private void UpdateMinMax(DoubleVector3 point, ref double minX, ref double minY, ref double maxX, ref double maxY) { }

	protected virtual void ValidateProperties() { }

}

