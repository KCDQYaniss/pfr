namespace ChartAndGraph;

public abstract class AxisBase : ChartSettingItemBase, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public double startValue; //Field offset: 0x10
		public double range; //Field offset: 0x18
		public double parentSize; //Field offset: 0x20

		public <>c__DisplayClass23_0() { }

		internal double <DrawDivisions>b__0(double x) { }

	}

	public class TextData
	{
		public ChartDivisionInfo info; //Field offset: 0x10
		public float interp; //Field offset: 0x18
		public int fractionDigits; //Field offset: 0x1C

		public TextData() { }

	}

	[SerializeField]
	private bool SimpleView; //Field offset: 0x38
	[SerializeField]
	[Tooltip("the format of the axis labels. This can be either a number, time or date time. If the selected value is either DateTime or Time , user ChartDateUtillity to convert dates to double values that can be set to the graph")]
	private AxisFormat format; //Field offset: 0x3C
	[SerializeField]
	[Tooltip("the depth of the axis reltive to the chart position")]
	private AutoFloat depth; //Field offset: 0x40
	[FormerlySerializedAs("MainDivisions")]
	[SerializeField]
	[Tooltip("The main divisions of the chart axis")]
	private ChartMainDivisionInfo mainDivisions; //Field offset: 0x48
	[FormerlySerializedAs("SubDivisions")]
	[SerializeField]
	[Tooltip("The sub divisions of each main division")]
	private ChartSubDivisionInfo subDivisions; //Field offset: 0x50
	private Dictionary mFormats; //Field offset: 0x58
	private List mTmpToRemove; //Field offset: 0x60

	public AutoFloat Depth
	{
		 get { } //Length: 5
		 set { } //Length: 24
	}

	public AxisFormat Format
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	public ChartDivisionInfo MainDivisions
	{
		 get { } //Length: 5
	}

	public ChartDivisionInfo SubDivisions
	{
		 get { } //Length: 5
	}

	public AxisBase() { }

	private void AddInnerItems() { }

	internal void AddMainDivisionToChartMesh(double scrollOffset, AnyChart parent, Transform parentTransform, IChartMesh mesh, ChartOrientation orientation) { }

	internal void AddSubdivisionToChartMesh(double scrollOffset, AnyChart parent, Transform parentTransform, IChartMesh mesh, ChartOrientation orientation) { }

	private void DrawDivisions(double scrollOffset, AnyChart parent, Transform parentTransform, ChartDivisionInfo info, IChartMesh mesh, int group, ChartOrientation orientation, double gap, bool oppositeSide, double mainGap) { }

	public AutoFloat get_Depth() { }

	public AxisFormat get_Format() { }

	public ChartDivisionInfo get_MainDivisions() { }

	public ChartDivisionInfo get_SubDivisions() { }

	private void GetDirectionVectors(AnyChart parent, ChartDivisionInfo info, ChartOrientation orientation, float scrollOffset, bool oppositeSide, out DoubleVector3 startPosition, out DoubleVector3 lengthDirection, out DoubleVector3 advanceDirection) { }

	private Nullable GetMainGap(AnyChart parent, double range) { }

	private void GetStartEnd(AnyChart parent, ChartOrientation orientation, float total, out float start, out float end) { }

	public void set_Depth(AutoFloat value) { }

	public void set_Format(AxisFormat value) { }

	private void SetMeshUv(IChartMesh mesh, float length, float offset) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	public void ValidateProperties() { }

}

