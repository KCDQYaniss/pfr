//Type is in global namespace

public class TextureTreeQuadrant : Quadrant
{
	internal struct TextureMaxSize
	{
		public Texture2D Texture; //Field offset: 0x0
		public float MaxSize; //Field offset: 0x8
		public Vector3 Position; //Field offset: 0xC

	}

	private Bounds _bounds; //Field offset: 0x50

	public TextureTreeQuadrant(TextureTreeQuadrant parent, Rect bounds) { }

	public Bounds ComputeBounds() { }

	protected virtual Quadrant CreateQuadrant(Quadrant parent, Rect bounds) { }

	public void Dispose() { }

	public ValueTuple GetMaxMipFactor(BoundingFrustum frustum) { }

	public ValueTuple GetMaxPixelsSizeFactor(BoundingFrustum frustum, ref float maxHPixelsFactor, ref float maxVPixelsFactor, ref float closestDist) { }

}

