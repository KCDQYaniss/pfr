namespace AmplifyMotion;

internal class SolidState : MotionState
{
	private static HashSet m_uniqueWarnings; //Field offset: 0x0
	private MeshRenderer m_meshRenderer; //Field offset: 0x30
	private Matrix3x4 m_prevLocalToWorld; //Field offset: 0x38
	private Matrix3x4 m_currLocalToWorld; //Field offset: 0x68
	private Mesh m_mesh; //Field offset: 0x98
	private MaterialDesc[] m_sharedMaterials; //Field offset: 0xA0
	public bool m_moved; //Field offset: 0xA8
	private bool m_wasVisible; //Field offset: 0xA9

	private static SolidState() { }

	public SolidState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj) { }

	internal virtual void Initialize() { }

	private void IssueError(string message) { }

	internal virtual void RenderVectors(Camera camera, CommandBuffer renderCB, float scale, Quality quality) { }

	internal virtual void UpdateTransform(CommandBuffer updateCB, bool starting) { }

}

