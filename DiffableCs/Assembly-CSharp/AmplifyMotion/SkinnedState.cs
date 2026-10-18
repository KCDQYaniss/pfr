namespace AmplifyMotion;

internal class SkinnedState : MotionState
{
	private static HashSet m_uniqueWarnings; //Field offset: 0x0
	private SkinnedMeshRenderer m_renderer; //Field offset: 0x30
	private int m_boneCount; //Field offset: 0x38
	private Transform[] m_boneTransforms; //Field offset: 0x40
	private Matrix3x4[] m_bones; //Field offset: 0x48
	private int m_weightCount; //Field offset: 0x50
	private int[] m_boneIndices; //Field offset: 0x58
	private float[] m_boneWeights; //Field offset: 0x60
	private int m_vertexCount; //Field offset: 0x68
	private Vector4[] m_baseVertices; //Field offset: 0x70
	private Vector3[] m_prevVertices; //Field offset: 0x78
	private Vector3[] m_currVertices; //Field offset: 0x80
	private int m_gpuBoneTexWidth; //Field offset: 0x88
	private int m_gpuBoneTexHeight; //Field offset: 0x8C
	private int m_gpuVertexTexWidth; //Field offset: 0x90
	private int m_gpuVertexTexHeight; //Field offset: 0x94
	private Material m_gpuSkinDeformMat; //Field offset: 0x98
	private Color[] m_gpuBoneData; //Field offset: 0xA0
	private Texture2D m_gpuBones; //Field offset: 0xA8
	private Texture2D m_gpuBoneIndices; //Field offset: 0xB0
	private Texture2D[] m_gpuBaseVertices; //Field offset: 0xB8
	private RenderTexture m_gpuPrevVertices; //Field offset: 0xC0
	private RenderTexture m_gpuCurrVertices; //Field offset: 0xC8
	private Mesh m_clonedMesh; //Field offset: 0xD0
	private Matrix3x4 m_worldToLocalMatrix; //Field offset: 0xD8
	private Matrix3x4 m_prevLocalToWorld; //Field offset: 0x108
	private Matrix3x4 m_currLocalToWorld; //Field offset: 0x138
	private MaterialDesc[] m_sharedMaterials; //Field offset: 0x168
	private ManualResetEvent m_asyncUpdateSignal; //Field offset: 0x170
	private bool m_asyncUpdateTriggered; //Field offset: 0x178
	private bool m_starting; //Field offset: 0x179
	private bool m_wasVisible; //Field offset: 0x17A
	private bool m_useFallback; //Field offset: 0x17B
	private bool m_useGPU; //Field offset: 0x17C

	private static SkinnedState() { }

	public SkinnedState(AmplifyMotionCamera owner, AmplifyMotionObjectBase obj) { }

	internal virtual void AsyncUpdate() { }

	private void AsyncUpdateVertices(bool starting) { }

	internal virtual void Initialize() { }

	private void InitializeBone1(Vector4[] baseVertices, int[] boneIndices) { }

	private void InitializeBone2(Vector4[] baseVertices, int[] boneIndices, float[] boneWeights) { }

	private void InitializeBone4(Vector4[] baseVertices, int[] boneIndices, float[] boneWeights) { }

	private bool InitializeGPUSkinDeform() { }

	private void IssueError(string message) { }

	private void IssueWarning(string message) { }

	internal virtual void RenderVectors(Camera camera, CommandBuffer renderCB, float scale, Quality quality) { }

	internal virtual void Shutdown() { }

	private void ShutdownGPUSkinDeform() { }

	private void UpdateBones() { }

	private void UpdateBonesGPU() { }

	internal virtual void UpdateTransform(CommandBuffer updateCB, bool starting) { }

	private void UpdateVerticesBone1() { }

	private void UpdateVerticesBone2() { }

	private void UpdateVerticesBone4() { }

	private void UpdateVerticesFallback(bool starting) { }

	private void UpdateVerticesGPU(CommandBuffer updateCB, bool starting) { }

	private void WaitForAsyncUpdate() { }

}

