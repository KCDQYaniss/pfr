namespace ChartAndGraph;

internal class CanvasChartMesh : ChartMeshBase
{
	private VertexHelper mVHWrapAround; //Field offset: 0x58
	private List mListWrapAround; //Field offset: 0x60
	private UIVertex[] mTmpQuad; //Field offset: 0x68
	private bool mTextOnly; //Field offset: 0x70

	public CanvasChartMesh(bool forText) { }

	public CanvasChartMesh(VertexHelper wrapAround) { }

	public virtual void AddQuad(UIVertex vLeftTop, UIVertex vRightTop, UIVertex vLeftBottom, UIVertex vRightBottom) { }

	public virtual BillboardText AddText(AnyChart chart, Text prefab, Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData) { }

	public virtual void AddXYRect(Rect rect, int subMeshGroup, float depth) { }

	public virtual void AddXZRect(Rect rect, int subMeshGroup, float yPosition) { }

	public virtual void AddYZRect(Rect rect, int subMeshGroup, float xPosition) { }

}

