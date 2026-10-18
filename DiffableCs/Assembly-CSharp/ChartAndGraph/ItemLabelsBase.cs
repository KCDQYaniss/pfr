namespace ChartAndGraph;

public abstract class ItemLabelsBase : ChartSettingItemBase, ISerializationCallbackReceiver
{
	[SerializeField]
	[Tooltip("This prefab will be used to create all the text associated with the chart. If the prefab is null no labels will be shown")]
	private Text textPrefab; //Field offset: 0x38
	[SerializeField]
	[Tooltip(" determine the formatting of the label data. when the values are available , you can use the predefined macros : '\\n' for newline , '<?category>' for the current category and '<?group>' for the current group")]
	private TextFormatting textFormat; //Field offset: 0x40
	[SerializeField]
	[Tooltip("the font size for the labels")]
	private int fontSize; //Field offset: 0x48
	[Range(1, 3)]
	[SerializeField]
	[Tooltip("adjusts the sharpness of the font")]
	private float fontSharpness; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("the seperation of each label from it's origin")]
	private float seperation; //Field offset: 0x50
	[SerializeField]
	[Tooltip("the location of the label relative to the item")]
	private ChartOrientedSize location; //Field offset: 0x58

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

	public ChartOrientedSize Location
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public float Seperation
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public TextFormatting TextFormat
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	public Text TextPrefab
	{
		 get { } //Length: 5
		 set { } //Length: 104
	}

	protected ItemLabelsBase() { }

	private void AddChildObjects() { }

	public float get_FontSharpness() { }

	public int get_FontSize() { }

	public ChartOrientedSize get_Location() { }

	public float get_Seperation() { }

	public TextFormatting get_TextFormat() { }

	public Text get_TextPrefab() { }

	public void set_FontSharpness(float value) { }

	public void set_FontSize(int value) { }

	public void set_Location(ChartOrientedSize value) { }

	public void set_Seperation(float value) { }

	public void set_TextFormat(TextFormatting value) { }

	public void set_TextPrefab(Text value) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	public override void ValidateProperties() { }

}

