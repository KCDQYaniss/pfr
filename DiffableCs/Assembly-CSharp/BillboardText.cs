//Type is in global namespace

public class BillboardText : MonoBehaviour
{
	private RectTransform mRect; //Field offset: 0x20
	[CompilerGenerated]
	private Text <UIText>k__BackingField; //Field offset: 0x28
	internal TextDirection Direction; //Field offset: 0x30
	public RectTransform RectTransformOverride; //Field offset: 0x38
	[CompilerGenerated]
	private object <UserData>k__BackingField; //Field offset: 0x40
	public float Scale; //Field offset: 0x48
	public bool parentSet; //Field offset: 0x4C
	public RectTransform parent; //Field offset: 0x50
	public bool Recycled; //Field offset: 0x58
	private CanvasRenderer[] mRenderers; //Field offset: 0x60

	public RectTransform Rect
	{
		 get { } //Length: 588
	}

	public Text UIText
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public object UserData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BillboardText() { }

	public RectTransform get_Rect() { }

	[CompilerGenerated]
	public Text get_UIText() { }

	[CompilerGenerated]
	public object get_UserData() { }

	[CompilerGenerated]
	public void set_UIText(Text value) { }

	[CompilerGenerated]
	public void set_UserData(object value) { }

	public void SetVisible(bool visible) { }

}

