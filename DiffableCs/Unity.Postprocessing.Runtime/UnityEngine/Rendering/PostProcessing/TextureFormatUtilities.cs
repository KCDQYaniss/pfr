namespace UnityEngine.Rendering.PostProcessing;

[Extension]
public static class TextureFormatUtilities
{
	private static Dictionary s_FormatAliasMap; //Field offset: 0x0
	private static Dictionary s_SupportedRenderTextureFormats; //Field offset: 0x8
	private static Dictionary s_SupportedTextureFormats; //Field offset: 0x10

	private static TextureFormatUtilities() { }

	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture) { }

	private static bool IsObsolete(object value) { }

	[Extension]
	internal static bool IsSupported(RenderTextureFormat format) { }

	[Extension]
	internal static bool IsSupported(TextureFormat format) { }

}

