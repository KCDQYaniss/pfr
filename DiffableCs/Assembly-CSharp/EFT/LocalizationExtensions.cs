namespace EFT;

[Extension]
public static class LocalizationExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public EStringCase stringCase; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal string <Localized>b__0(string id) { }

	}


	[Extension]
	public static string FormatSeparate(float number, string separator = " ") { }

	[Extension]
	public static string FormatSeparate(double number, string separator = " ") { }

	[Extension]
	public static string FormatSeparate(int number, string separator = " ") { }

	[Extension]
	public static string FormatSeparate(long number, string separator = " ") { }

	[Extension]
	public static string LocalizeAreaName(EAreaType type) { }

	[Extension]
	public static string Localized(string id, string prefix = null) { }

	[Extension]
	public static string[] Localized(IReadOnlyList idArray, EStringCase stringCase = 0) { }

	[Extension]
	public static string Localized(string id, EStringCase stringCase) { }

	[Extension]
	public static string Localized(TError error) { }

	[Extension]
	public static string Localized(TEnum id, EStringCase stringCase = 0) { }

	[Extension]
	public static string LocalizedEnum(T value, string prefix = null) { }

	[Extension]
	public static string LocalizedName(MongoID itemTemplateId) { }

	[Extension]
	public static string LocalizedName(Item item) { }

	[Extension]
	public static string LocalizedShort(TEnum id, EStringCase case) { }

	[Extension]
	public static string LocalizedShortName(MongoID itemTemplateId) { }

	[Extension]
	public static string LocalizedShortName(Item item) { }

	[Extension]
	public static string ParseLocalization(string original) { }

	private static string ParseTag(string tag1, string tag2, string text) { }

}

