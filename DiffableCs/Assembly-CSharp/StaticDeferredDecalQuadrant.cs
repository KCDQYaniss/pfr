//Type is in global namespace

public class StaticDeferredDecalQuadrant : Quadrant
{
	internal sealed class CommandBufferPreDrawDelegate : MulticastDelegate
	{

		public CommandBufferPreDrawDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CommandBuffer cbBuf, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CommandBuffer cbBuf) { }

	}

	internal struct TextureMaxSize
	{
		public Texture2D Texture; //Field offset: 0x0
		public float MaxSize; //Field offset: 0x8
		public Vector3 Position; //Field offset: 0xC
		public Vector4 uvStartEnd; //Field offset: 0x18

	}

	private static readonly Bounds s_emptyBound; //Field offset: 0x0
	public CommandBuffer _subtreeCommandBuffer; //Field offset: 0x50
	public CommandBuffer _ownDecalsCommandBuffer; //Field offset: 0x58
	private SortedList _subtreeDrawInstances; //Field offset: 0x60
	private SortedList _ownDecalsDrawInstances; //Field offset: 0x68
	private Bounds _bounds; //Field offset: 0x70

	private static StaticDeferredDecalQuadrant() { }

	public StaticDeferredDecalQuadrant(StaticDeferredDecalQuadrant parent, Rect bounds) { }

	private void ClearDrawInstances() { }

	private void ClearOwnDecalsDrawInstances() { }

	public static void ComputeDecalMinMaxPoints(StaticDeferredDecal decal, ref Vector3 minPoint, ref Vector3 maxPoint, Mesh mesh) { }

	private static string ComputeHash(StaticDeferredDecal decal) { }

	public ValueTuple ConstructSubtreeCommandBuffers(Mesh mesh, CommandBufferPreDrawDelegate preDrawCallback) { }

	private void ConstructSubtreeCommandBuffers(StaticDeferredDecalQuadrant quadrant, Mesh mesh, CommandBufferPreDrawDelegate preDrawCallback, ref List decalsList, ref List texturesList, ref Bounds boundsToSet) { }

	private TextureMaxSize ConstructTextureMaxSizeElement(StaticDeferredDecal decal) { }

	private static Bounds CreateEmptyBound() { }

	protected virtual Quadrant CreateQuadrant(Quadrant parent, Rect bounds) { }

	public void Dispose() { }

	public static void GenerateCommandBufferForQuadrant(StaticDeferredDecalQuadrant q, List decals, Mesh mesh, CommandBufferPreDrawDelegate preDrawCallback) { }

	public static void GenerateOwnCommandBufferForQuadrant(StaticDeferredDecalQuadrant q, List decals, Mesh mesh, CommandBufferPreDrawDelegate preDrawCallback) { }

	public void GetCommandBuffers(BoundingFrustum frustum, ref List commandBuffers, int maxDepth) { }

	private static Dictionary GroupDecals(List decals) { }

	private bool IsEmptyBound(ref Bounds b) { }

	public void RecordCommandBuffer(BoundingFrustum frustum, CommandBuffer commandBuffer, int maxDepth, Mesh mesh) { }

	public static void RecordCommandBufferForQuadrant(StaticDeferredDecalQuadrant q, CommandBuffer cmdBuf, Mesh mesh) { }

}

