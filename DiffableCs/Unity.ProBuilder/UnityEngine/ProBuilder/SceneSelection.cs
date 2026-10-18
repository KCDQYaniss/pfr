namespace UnityEngine.ProBuilder;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public class SceneSelection : IEquatable
{
	public GameObject gameObject; //Field offset: 0x10
	public ProBuilderMesh mesh; //Field offset: 0x18
	private List m_Vertices; //Field offset: 0x20
	private List m_Edges; //Field offset: 0x28
	private List m_Faces; //Field offset: 0x30
	[Obsolete("Use SetSingleVertex")]
	public int vertex; //Field offset: 0x38
	[Obsolete("Use SetSingleEdge")]
	public Edge edge; //Field offset: 0x3C
	[Obsolete("Use SetSingleFace")]
	public Face face; //Field offset: 0x48

	public List edges
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public List faces
	{
		 get { } //Length: 76
		 set { } //Length: 82
	}

	public List vertexes
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	internal SceneSelection(ProBuilderMesh mesh, List edges) { }

	public SceneSelection(GameObject gameObject = null) { }

	public SceneSelection(ProBuilderMesh mesh, int vertex) { }

	public SceneSelection(ProBuilderMesh mesh, Edge edge) { }

	public SceneSelection(ProBuilderMesh mesh, Face face) { }

	internal SceneSelection(ProBuilderMesh mesh, List vertexes) { }

	internal SceneSelection(ProBuilderMesh mesh, List faces) { }

	public void Clear() { }

	public void CopyTo(SceneSelection dst) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(SceneSelection other) { }

	public List get_edges() { }

	public List get_faces() { }

	public List get_vertexes() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	public static bool op_Inequality(SceneSelection left, SceneSelection right) { }

	public void set_edges(List value) { }

	public void set_faces(List value) { }

	public void set_vertexes(List value) { }

	public void SetSingleEdge(Edge edge) { }

	public void SetSingleFace(Face face) { }

	public void SetSingleVertex(int vertex) { }

	public virtual string ToString() { }

}

