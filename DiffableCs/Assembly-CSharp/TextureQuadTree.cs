//Type is in global namespace

public class TextureQuadTree : QuadTree
{
	[CompilerGenerated]
	private static class <>O
	{
		public static ParameterizedThreadStart <0>__WorkThread; //Field offset: 0x0

	}

	private class ThreadResults
	{
		public int updatedDuringFrame; //Field offset: 0x10
		public int requestedMipMapLevel; //Field offset: 0x14
		public float pixelsHBuf; //Field offset: 0x18
		public float pixelsVBuf; //Field offset: 0x1C
		public float closestDist; //Field offset: 0x20

		public ThreadResults() { }

	}

	private class UpdateParams
	{
		public BoundingFrustum frustum; //Field offset: 0x10
		public float maxScreenHScale; //Field offset: 0x18
		public float maxScreenVScale; //Field offset: 0x1C
		public int cameraInstanceID; //Field offset: 0x20
		public int frameIndex; //Field offset: 0x24

		public UpdateParams() { }

	}

	private class WorkThreadParams
	{
		public TextureQuadTree tree; //Field offset: 0x10

		public WorkThreadParams() { }

	}

	private static Thread _workThreads; //Field offset: 0x0
	private static CancellationTokenSource _terminateTokenSource; //Field offset: 0x8
	private static CancellationToken _terminateToken; //Field offset: 0x10
	public static int ThreadSleepTime; //Field offset: 0x18
	public static int ThreadMinSleepTime; //Field offset: 0x1C
	public static bool ThreadSkipJob; //Field offset: 0x20
	public static int MipOffset; //Field offset: 0x24
	public static int DropResultsAfterFramesCount; //Field offset: 0x28
	private static HashSet _trees; //Field offset: 0x30
	private static object _treesLock; //Field offset: 0x38
	private static UpdateParams _updateParams; //Field offset: 0x40
	private Texture2D _texture; //Field offset: 0x38
	private int _mipmapCount; //Field offset: 0x40
	private int _textureWidth; //Field offset: 0x44
	private int _textureHeight; //Field offset: 0x48
	private string _name; //Field offset: 0x50
	private Dictionary _results; //Field offset: 0x58
	private object updateParamsLock; //Field offset: 0x60

	public Texture2D Texture
	{
		 get { } //Length: 5
	}

	private static TextureQuadTree() { }

	public TextureQuadTree() { }

	protected virtual Quadrant CreateQuadrant(Quadrant parent, Rect bounds) { }

	public void Dispose() { }

	public Texture2D get_Texture() { }

	private ValueTuple GetMaxMipFactor(BoundingFrustum frustum) { }

	public void Insert(ref List infosList, Texture2D texture) { }

	public void SetThreadParams(Camera camera, BoundingFrustum frustum, float maxScreenHScale, float maxScreenVScale) { }

	public void UpdateTextureRequestedMipMapLevel() { }

	private static void WorkThread(object p) { }

}

