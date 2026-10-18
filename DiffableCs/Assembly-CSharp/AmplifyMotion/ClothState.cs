namespace AmplifyMotion;

internal class ClothState : MotionState
{
	private static HashSet m_uniqueWarnings; //Field offset: 0x0
	private Cloth m_cloth; //Field offset: 0x30
	private Renderer m_renderer; //Field offset: 0x38
	private Matrix3x4 m_prevLocalToWorld; //Field offset: 0x40
	private Matrix3x4 m_currLocalToWorld; //Field offset: 0x70
	private int m_targetVertexCount; //Field offset: 0xA0
	private int[] m_targetRemap; //Field offset: 0xA8
	private Vector3[] m_prevVertices; //Field offset: 0xB0
	private Vector3[] m_currVertices; //Field offset: 0xB8
	private Mesh m_clonedMesh; //Field offset: 0xC0
	private MaterialDesc[] m_sharedMaterials; //Field offset: 0xC8
	private bool m_starting; //Field offset: 0xD0
	private bool m_wasVisible; //Field offset: 0xD1

	private static ClothState() { }

	public ClothState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj) { }

	internal virtual void Initialize() { }

	private void IssueError(string message) { }

	internal virtual void RenderVectors(Camera camera, CommandBuffer renderCB, float scale, Quality quality) { }

	internal virtual void Shutdown() { }

	internal virtual void UpdateTransform(CommandBuffer updateCB, bool starting) { }

}

