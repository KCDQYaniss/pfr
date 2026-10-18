namespace EFT.BlitDebug;

public class DebugGraphics : Graphics
{
	private static bool found; //Field offset: 0x0

	public DebugGraphics() { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice) { }

	public static void Blit(Texture source, Material mat, int pass, int destDepthSlice) { }

	public static void Blit(Texture source, Material mat, int pass) { }

	public static string ExtractStackTrace() { }

}

