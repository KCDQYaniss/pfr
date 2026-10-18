namespace ChartAndGraph;

public class ChartDivisionInfo : IInternalSettings
{
	internal enum DivisionMessure
	{
		TotalDivisions = 0,
		DataUnits = 1,
	}

	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Tooltip("messure used to create divisions")]
	protected DivisionMessure messure; //Field offset: 0x10
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Tooltip("data units per division")]
	protected float unitsPerDivision; //Field offset: 0x14
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Tooltip("total division lines")]
	private int total; //Field offset: 0x18
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Tooltip("Material for the line of the division")]
	private Material material; //Field offset: 0x20
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Tooltip("Material tiling for the division lines. Use this to strech or tile the material along the line")]
	private MaterialTiling materialTiling; //Field offset: 0x28
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("The length of the far side of the division lines. This is used only by 3d chart when MarkDepth >0")]
	private AutoFloat markBackLength; //Field offset: 0x30
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("The length of the the division lines.")]
	private AutoFloat markLength; //Field offset: 0x38
	[NonCanvas]
	[SerializeField]
	[Simple]
	private AutoFloat markDepth; //Field offset: 0x40
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("the thickness of the division lines")]
	private float markThickness; //Field offset: 0x48
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("A prefab for the division labels")]
	private Text textPrefab; //Field offset: 0x50
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("prefix for the axis labels")]
	private string textPrefix; //Field offset: 0x58
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("suffix for the axis labels")]
	private string textSuffix; //Field offset: 0x60
	[Canvas]
	[NonCanvas]
	[Range(0, 7)]
	[SerializeField]
	[Simple]
	[Tooltip("the number of fraction digits in text labels")]
	private int fractionDigits; //Field offset: 0x68
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("Label font size")]
	private int fontSize; //Field offset: 0x6C
	[Canvas]
	[NonCanvas]
	[Range(1, 3)]
	[SerializeField]
	[Simple]
	[Tooltip("makes the labels sharper if they are blurry")]
	private float fontSharpness; //Field offset: 0x70
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("depth seperation the division lables")]
	private float textDepth; //Field offset: 0x74
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("breadth seperation for the division labels")]
	private float textSeperation; //Field offset: 0x78
	[Canvas]
	[NonCanvas]
	[SerializeField]
	[Simple]
	[Tooltip("Alignment of the division lables")]
	private ChartDivisionAligment alignment; //Field offset: 0x7C
	[CompilerGenerated]
	private EventHandler OnDataUpdate; //Field offset: 0x80
	[CompilerGenerated]
	private EventHandler OnDataChanged; //Field offset: 0x88

	private override event EventHandler ChartAndGraph.IInternalSettings.InternalOnDataChanged
	{
		private add { } //Length: 251
		private remove { } //Length: 251
	}

	private override event EventHandler ChartAndGraph.IInternalSettings.InternalOnDataUpdate
	{
		private add { } //Length: 251
		private remove { } //Length: 251
	}

	private event EventHandler OnDataChanged
	{
		[CompilerGenerated]
		private add { } //Length: 251
		[CompilerGenerated]
		private remove { } //Length: 251
	}

	private event EventHandler OnDataUpdate
	{
		[CompilerGenerated]
		private add { } //Length: 251
		[CompilerGenerated]
		private remove { } //Length: 251
	}

	public ChartDivisionAligment Alignment
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	public float FontSharpness
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public int FontSize
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	public int FractionDigits
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	public AutoFloat MarkBackLength
	{
		 get { } //Length: 76
		 set { } //Length: 24
	}

	public AutoFloat MarkDepth
	{
		 get { } //Length: 5
		 set { } //Length: 24
	}

	public AutoFloat MarkLength
	{
		 get { } //Length: 5
		 set { } //Length: 24
	}

	public float MarkThickness
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public Material Material
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public MaterialTiling MaterialTiling
	{
		 get { } //Length: 5
		 set { } //Length: 24
	}

	public float TextDepth
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public Text TextPrefab
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public string TextPrefix
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public float TextSeperation
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public string TextSuffix
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public int Total
	{
		 get { } //Length: 4
		 set { } //Length: 20
	}

	public ChartDivisionInfo() { }

	[CompilerGenerated]
	private void add_OnDataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void add_OnDataUpdate(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.add_InternalOnDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.add_InternalOnDataUpdate(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.remove_InternalOnDataChanged(EventHandler value) { }

	private override void ChartAndGraph.IInternalSettings.remove_InternalOnDataUpdate(EventHandler value) { }

	public ChartDivisionAligment get_Alignment() { }

	public float get_FontSharpness() { }

	public int get_FontSize() { }

	public int get_FractionDigits() { }

	public AutoFloat get_MarkBackLength() { }

	public AutoFloat get_MarkDepth() { }

	public AutoFloat get_MarkLength() { }

	public float get_MarkThickness() { }

	public Material get_Material() { }

	public MaterialTiling get_MaterialTiling() { }

	public float get_TextDepth() { }

	public Text get_TextPrefab() { }

	public string get_TextPrefix() { }

	public float get_TextSeperation() { }

	public string get_TextSuffix() { }

	public int get_Total() { }

	protected override void RaiseOnChanged() { }

	[CompilerGenerated]
	private void remove_OnDataChanged(EventHandler value) { }

	[CompilerGenerated]
	private void remove_OnDataUpdate(EventHandler value) { }

	public void set_Alignment(ChartDivisionAligment value) { }

	public void set_FontSharpness(float value) { }

	public void set_FontSize(int value) { }

	public void set_FractionDigits(int value) { }

	public void set_MarkBackLength(AutoFloat value) { }

	public void set_MarkDepth(AutoFloat value) { }

	public void set_MarkLength(AutoFloat value) { }

	public void set_MarkThickness(float value) { }

	public void set_Material(Material value) { }

	public void set_MaterialTiling(MaterialTiling value) { }

	public void set_TextDepth(float value) { }

	public void set_TextPrefab(Text value) { }

	public void set_TextPrefix(string value) { }

	public void set_TextSeperation(float value) { }

	public void set_TextSuffix(string value) { }

	public void set_Total(int value) { }

	public void ValidateProperites() { }

	protected override float ValidateTotal(float total) { }

}

