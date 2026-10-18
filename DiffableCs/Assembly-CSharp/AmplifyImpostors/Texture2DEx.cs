namespace AmplifyImpostors;

[Extension]
public static class Texture2DEx
{
	internal enum Compression
	{
		None = 0,
		RLE = 1,
	}

	private static readonly byte[] Footer; //Field offset: 0x0

	private static Texture2DEx() { }

	[Extension]
	public static byte[] EncodeToTGA(Texture2D tex, Compression compression = 1) { }

	private static bool Equals(Color32 first, Color32 second) { }

}

