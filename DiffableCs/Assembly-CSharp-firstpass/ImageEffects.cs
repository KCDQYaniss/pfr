//Type is in global namespace

[AddComponentMenu(null)]
public class ImageEffects
{
	private static readonly int _rotationMatrix; //Field offset: 0x0
	private static readonly int _centerRadius; //Field offset: 0x4
	private static readonly int _angle; //Field offset: 0x8

	private static ImageEffects() { }

	public ImageEffects() { }

	[Obsolete("Use Graphics.Blit(source,dest) instead")]
	public static void Blit(RenderTexture source, RenderTexture dest) { }

	[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest) { }

	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius) { }

}

