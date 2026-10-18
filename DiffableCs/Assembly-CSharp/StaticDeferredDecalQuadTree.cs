//Type is in global namespace

public class StaticDeferredDecalQuadTree : QuadTree
{
	[CompilerGenerated]
	private static class <>O
	{
		public static ParameterizedThreadStart <0>__WorkThread; //Field offset: 0x0

	}

	private class UpdateParams
	{
		public BoundingFrustum frustum; //Field offset: 0x10
		public int maxDepth; //Field offset: 0x18
		public List threadResults; //Field offset: 0x20

		public UpdateParams() { }

	}

	private class WorkThreadParams
	{
		public StaticDeferredDecalQuadTree tree; //Field offset: 0x10

		public WorkThreadParams() { }

	}

	private static CancellationTokenSource _terminateTokenSource; //Field offset: 0x0
	private static CancellationToken _terminateToken; //Field offset: 0x8
	public static int ThreadSleepTime; //Field offset: 0x10
	public static bool ThreadSkipJob; //Field offset: 0x14
	private static UpdateParams _updateParams; //Field offset: 0x18
	private Thread _workThreads; //Field offset: 0x38
	private object updateParamsLock; //Field offset: 0x40
	private object updateResultLock; //Field offset: 0x48

	private static StaticDeferredDecalQuadTree() { }

	public StaticDeferredDecalQuadTree() { }

	public Dictionary ConstructCommandBuffersAndTexturesTrees(Mesh mesh, CommandBufferPreDrawDelegate preDrawCallback) { }

	protected virtual Quadrant CreateQuadrant(Quadrant parent, Rect bounds) { }

	public void Dispose() { }

	public void GetCommandBuffers(BoundingFrustum frustum, ref List commandBuffers, int maxDepth) { }

	public CommandBuffer GetRootCommandBuffer() { }

	public bool GetThreadResults(ref List commandBuffers) { }

	public void Insert(StaticDeferredDecal decal, Mesh mesh) { }

	public void RecordCommandBuffer(BoundingFrustum frustum, CommandBuffer commandBuffer, int maxDepth, CommandBufferPreDrawDelegate preDrawCallback, Mesh mesh) { }

	public void SetThreadParams(BoundingFrustum frustum, int maxDepth) { }

	private static void WorkThread(object p) { }

}

