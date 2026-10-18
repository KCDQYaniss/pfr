namespace System.Drawing;

internal static class KnownColorTable
{
	private static int[] s_colorTable; //Field offset: 0x0
	private static string[] s_colorNameTable; //Field offset: 0x8

	private static void EnsureColorNameTable() { }

	private static void EnsureColorTable() { }

	private static void InitColorNameTable() { }

	private static void InitColorTable() { }

	public static int KnownColorToArgb(KnownColor color) { }

	public static string KnownColorToName(KnownColor color) { }

	private static void UpdateSystemColors(int[] colorTable) { }

}

