namespace ChartAndGraph;

public abstract class ChartMeshBase : IChartMesh
{
	private List mText; //Field offset: 0x10
	private List mCurrentTexts; //Field offset: 0x18
	private Dictionary mRecycled; //Field offset: 0x20
	private List mCached; //Field offset: 0x28
	private float innerTile; //Field offset: 0x30
	[CompilerGenerated]
	private ChartOrientation <Orientation>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <Offset>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <Length>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <RecycleText>k__BackingField; //Field offset: 0x40
	private Vector2[][] mUvs; //Field offset: 0x48
	private Vector2[] mTmpUv; //Field offset: 0x50

	public override List CurrentTextObjects
	{
		 get { } //Length: 5
	}

	public override float Length
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float Offset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public ChartOrientation Orientation
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool RecycleText
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override List TextObjects
	{
		 get { } //Length: 5
	}

	public override float Tile
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public ChartMeshBase() { }

	public abstract void AddQuad(UIVertex vLeftTop, UIVertex vRightTop, UIVertex vLeftBottom, UIVertex vRightBottom) { }

	[CanBeNull]
	public override BillboardText AddText(AnyChart chart, Text prefab, Transform parentTransform, int fontSize, float fontSharpness, string text, float x, float y, float z, float angle, object userData) { }

	public abstract void AddXYRect(Rect rect, int subMeshGroup, float depth) { }

	public abstract void AddXZRect(Rect rect, int subMeshGroup, float yPosition) { }

	public abstract void AddYZRect(Rect rect, int subMeshGroup, float xPosition) { }

	public override void Clear() { }

	private void DestoryBillboard(BillboardText t) { }

	public void DestoryRecycled() { }

	public override List get_CurrentTextObjects() { }

	[CompilerGenerated]
	public override float get_Length() { }

	[CompilerGenerated]
	public override float get_Offset() { }

	[CompilerGenerated]
	public ChartOrientation get_Orientation() { }

	[CompilerGenerated]
	public bool get_RecycleText() { }

	public override List get_TextObjects() { }

	public override float get_Tile() { }

	protected Vector2[] GetUvs(Rect rect) { }

	protected Vector2[] GetUvs(Rect rect, ChartOrientation orientaion) { }

	[CompilerGenerated]
	public override void set_Length(float value) { }

	[CompilerGenerated]
	public override void set_Offset(float value) { }

	[CompilerGenerated]
	public void set_Orientation(ChartOrientation value) { }

	[CompilerGenerated]
	public void set_RecycleText(bool value) { }

	public override void set_Tile(float value) { }

}

