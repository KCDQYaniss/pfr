namespace EFT;

[Extension]
public static class StringExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToPascalCase>b__28_0(string part) { }

	}

	public const string BULLET_POINT = "•"; //Field offset: 0x0
	private const string DIGITS = "0123456789"; //Field offset: 0x0
	private static readonly Dictionary _digitSizesCache; //Field offset: 0x0
	private static readonly Regex _monospacePattern; //Field offset: 0x8

	private static StringExtensions() { }

	[Extension]
	public static void Append(StringBuilder builder, string text, Color color) { }

	[Extension]
	public static void AppendLabeledValue(StringBuilder builder, string label, string data, Color labelColor, string dataColor, bool labelEnabled = true) { }

	[Extension]
	public static void AppendLabeledValue(StringBuilder builder, string label, string data, string labelColor, Color dataColor, bool labelEnabled = true) { }

	[Extension]
	public static void AppendLabeledValue(StringBuilder builder, string label, string data, Color labelColor, Color dataColor, bool labelEnabled = true) { }

	[Extension]
	public static void AppendLabeledValue(StringBuilder builder, string label, string data, string labelColor, string dataColor, bool labelEnabled = true) { }

	[Extension]
	public static void AppendLine(StringBuilder builder, string text, Color color) { }

	[Extension]
	public static string Blue(string input) { }

	private static float CacheFontDigits(TMP_FontAsset fontAsset) { }

	[Extension]
	public static string Capitalize(string input) { }

	[Extension]
	public static string ConvertToMonospace(string text, bool onlyDigits = true) { }

	[Extension]
	public static string ConvertToResourceLocation(string s, bool removeExtension = true) { }

	[Extension]
	public static void CopyToClipboard(string s) { }

	[Extension]
	public static bool EqualsAndNotNull(string s1, string s2) { }

	[Extension]
	public static string Green(string input) { }

	[Extension]
	public static bool IsNullOrEmpty(string string) { }

	public static bool IsPunctuation(char character) { }

	[Extension]
	public static string Red(string input) { }

	[Extension]
	public static string RemoveHtml(string source) { }

	[Extension]
	public static string ReplaceFirst(string text, string search, string replace) { }

	[Extension]
	public static string SetColor(string s, Color color) { }

	[Extension]
	public static void SetMonospaceText(TMP_Text textField, string text, bool onlyDigits = true) { }

	[Extension]
	public static string SplitByCapitalLetters(string input) { }

	public static string ToBulletPointList(IEnumerable items, string itemPrefix = "  ") { }

	[Extension]
	public static string ToEscapedLiteral(string input) { }

	[Extension]
	public static string ToPascalCase(string input) { }

	[Extension]
	public static string ToStringReduceThousands(int num) { }

	[Extension]
	public static string ValidateDoubleSlash(string s) { }

	[Extension]
	public static string Yellow(string input) { }

}

