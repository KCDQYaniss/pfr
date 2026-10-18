namespace ChartAndGraph;

internal interface IChartMesh
{

	public float Length
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float Offset
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public List TextObjects
	{
		 get { } //Length: 0
	}

	public float Tile
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void AddQuad(UIVertex vLeftTop, UIVertex vRightTop, UIVertex vLeftBottom, UIVertex vRightBottom) { }

	[CanBeNull]
	public BillboardText AddText(AnyChart chart, Text prefab, Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData) { }

	public void AddXYRect(Rect rect, int subMeshGroup, float depth) { }

	public void AddXZRect(Rect rect, int subMeshGroup, float yPosition) { }

	public void AddYZRect(Rect rect, int subMeshGroup, float xPosition) { }

	public float get_Length() { }

	public float get_Offset() { }

	public List get_TextObjects() { }

	public float get_Tile() { }

	public void set_Length(float value) { }

	public void set_Offset(float value) { }

	public void set_Tile(float value) { }

}

