namespace DG.Tweening.Plugins;

[Extension]
internal static class StringPluginExtensions
{
	public static readonly char[] ScrambledCharsAll; //Field offset: 0x0
	public static readonly char[] ScrambledCharsUppercase; //Field offset: 0x8
	public static readonly char[] ScrambledCharsLowercase; //Field offset: 0x10
	public static readonly char[] ScrambledCharsNumerals; //Field offset: 0x18
	private static int _lastRndSeed; //Field offset: 0x20

	private static StringPluginExtensions() { }

	[Extension]
	internal static StringBuilder AppendScrambledChars(StringBuilder buffer, int length, char[] chars) { }

	[Extension]
	internal static void ScrambleChars(char[] chars) { }

}

