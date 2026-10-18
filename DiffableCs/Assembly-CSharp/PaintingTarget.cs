//Type is in global namespace

[RequireComponent(typeof(MeshFilter))]
public class PaintingTarget : MonoBehaviour
{
	public bool ApplyVertexColors; //Field offset: 0x20
	public Mesh SharedMesh; //Field offset: 0x28
	public Mesh TargetMesh; //Field offset: 0x30
	public List VerticesColors; //Field offset: 0x38
	public float GizmosScale; //Field offset: 0x40
	[HideInInspector]
	public Vector4 ChannelScale; //Field offset: 0x44
	[HideInInspector]
	public bool ShowVertices; //Field offset: 0x54
	private Color highlightedColor; //Field offset: 0x58
	private List highlightedVertices; //Field offset: 0x68

	public PaintingTarget() { }

	private void Awake() { }

}

