namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod
{
	public enum MipLevel
	{
		Original = 0,
		L1 = 1,
		L2 = 2,
		L3 = 3,
		L4 = 4,
		L5 = 5,
		L6 = 6,
	}

	private enum Pass
	{
		DepthCopy = 0,
		CompositionDeferred = 1,
		CompositionForward = 2,
		DebugOverlay = 3,
	}

	private readonly float[] m_SampleThickness; //Field offset: 0x10
	private readonly float[] m_InvThicknessTable; //Field offset: 0x18
	private readonly float[] m_SampleWeightTable; //Field offset: 0x20
	private readonly int[] m_Widths; //Field offset: 0x28
	private readonly int[] m_Heights; //Field offset: 0x30
	private AmbientOcclusion m_Settings; //Field offset: 0x38
	private PropertySheet m_PropertySheet; //Field offset: 0x40
	private PostProcessResources m_Resources; //Field offset: 0x48
	private RenderTexture m_AmbientOnlyAO; //Field offset: 0x50
	private readonly RenderTargetIdentifier[] m_MRT; //Field offset: 0x58

	public MultiScaleVO(AmbientOcclusion settings) { }

	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav) { }

	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav) { }

	private float CalculateTanHalfFovHeight(Camera camera) { }

	private Vector4 CalculateZBufferParams(Camera camera) { }

	private void CheckAOTexture(PostProcessRenderContext context) { }

	public override void CompositeAmbientOnly(PostProcessRenderContext context) { }

	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable depthMap, bool invert, bool isMSAA) { }

	public override DepthTextureMode GetCameraFlags() { }

	private Vector2 GetSize(MipLevel mip) { }

	private Vector3 GetSizeArray(MipLevel mip) { }

	private void PreparePropertySheet(PostProcessRenderContext context) { }

	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA) { }

	private void PushDebug(PostProcessRenderContext context) { }

	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable depthMap, bool isMSAA) { }

	private void PushReleaseCommands(CommandBuffer cmd) { }

	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false) { }

	private void Release(CommandBuffer cmd, int id) { }

	public override void Release() { }

	public override void RenderAfterOpaque(PostProcessRenderContext context) { }

	public override void RenderAmbientOnly(PostProcessRenderContext context) { }

	public void SetResources(PostProcessResources resources) { }

}

