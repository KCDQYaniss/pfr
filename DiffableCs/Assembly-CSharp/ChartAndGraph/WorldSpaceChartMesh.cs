namespace ChartAndGraph;

public class WorldSpaceChartMesh : ChartMeshBase
{
	private List _verticesList; //Field offset: 0x58
	private List _vectorList; //Field offset: 0x60
	private readonly List[] _trianglesList; //Field offset: 0x68
	private readonly bool _isCanvas; //Field offset: 0x70

	public WorldSpaceChartMesh(bool isCanvas) { }

	public WorldSpaceChartMesh(int groups) { }

	public virtual void AddQuad(UIVertex vLeftTop, UIVertex vRightTop, UIVertex vLeftBottom, UIVertex vRightBottom) { }

	[CanBeNull]
	public virtual BillboardText AddText(AnyChart chart, Text prefab, Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData) { }

	public void AddTriangle(int x, int y, int z) { }

	protected void AddTriangle(List tringleList, int x, int y, int z) { }

	public int AddVertex(UIVertex v) { }

	public int AddVertex(Vector3 pos, Vector2 uv) { }

	public virtual void AddXYRect(Rect rect, int subMeshGroup, float depth) { }

	public virtual void AddXZRect(Rect rect, int subMeshGroup, float yPosition) { }

	public virtual void AddYZRect(Rect rect, int subMeshGroup, float xPosition) { }

	public void ApplyToMesh(Mesh mesh) { }

	public virtual void Clear() { }

	public Mesh Generate(Mesh mesh) { }

	public Mesh Generate() { }

	private Color[] GetColors() { }

	protected List GetTrianglesForGroup(int subMeshGroup) { }

	protected void ValidateMesh() { }

}

