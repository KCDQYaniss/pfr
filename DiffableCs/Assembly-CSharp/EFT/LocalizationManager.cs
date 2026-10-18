namespace EFT;

public sealed class LocalizationManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_0; //Field offset: 0x8
		public static Func <>9__31_1; //Field offset: 0x10
		public static Func <>9__31_2; //Field offset: 0x18
		public static Func <>9__31_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <CacheFonts>b__31_0(TMP_FontAsset font) { }

		internal TMP_FontAsset <CacheFonts>b__31_1(TMP_FontAsset font) { }

		internal List <CacheFonts>b__31_2(TMP_FontAsset font) { }

		internal TMP_FontAsset <CacheFonts>b__31_3(TMP_FontAsset font) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public string fontFamily; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <CacheFonts>b__5(TMP_FontAsset font) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public TMP_FontAsset mainFallBack; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_1
	{
		public List fallBackCache; //Field offset: 0x10
		public <>c__DisplayClass35_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass35_1() { }

		internal bool <UpdateFonts>b__0(TMP_FontAsset fallBack) { }

	}

	private const string FONTS_PATH = "UI/Fonts"; //Field offset: 0x0
	public const string RUSSIAN_LOCALIZATION = "ru"; //Field offset: 0x0
	public const string ENGLISH_LOCALIZATION = "en"; //Field offset: 0x0
	public const string FRENCH_LOCALIZATION = "fr"; //Field offset: 0x0
	public const string GERMAN_LOCALIZATION = "ge"; //Field offset: 0x0
	private static readonly Dictionary _staticLocales; //Field offset: 0x0
	private static LocalizationManager _instance; //Field offset: 0x8
	private readonly IReadOnlyDictionary _fallbackFontsInfo; //Field offset: 0x10
	private readonly Dictionary _languageSpecificFallBacks; //Field offset: 0x18
	[CompilerGenerated]
	private IDictionary <AvailableLanguages>k__BackingField; //Field offset: 0x20
	private readonly Dictionary _availableMainMenuCultures; //Field offset: 0x28
	private readonly Dictionary _availableCultures; //Field offset: 0x30
	private readonly Dictionary _locales; //Field offset: 0x38
	private readonly BindableEvent _onLocaleUpdatedEvent; //Field offset: 0x40
	private string _currentApplicationCulture; //Field offset: 0x48
	private IEnumerable _dynamicFonts; //Field offset: 0x50
	private IEnumerable _allFonts; //Field offset: 0x58
	private IReadOnlyDictionary _realFallBacks; //Field offset: 0x60
	private IReadOnlyDictionary _fallBacksCache; //Field offset: 0x68
	[CompilerGenerated]
	private string <Culture>k__BackingField; //Field offset: 0x70

	public private IDictionary AvailableLanguages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal string Culture
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public static string DefaultLanguage
	{
		 get { } //Length: 712
	}

	internal static LocalizationManager Instance
	{
		internal get { } //Length: 254
	}

	private static LocalizationManager() { }

	private LocalizationManager() { }

	[CompilerGenerated]
	private List <CacheFonts>b__31_4(TMP_FontAsset font) { }

	[CompilerGenerated]
	private bool <CacheFonts>b__31_6(TMP_FontAsset font2) { }

	public Action AddLocaleUpdateListener(Action callback) { }

	private void CacheFonts() { }

	public void Clear() { }

	public bool ContainsCulture(string localeId) { }

	public bool ContainsMainMenuCulture(string localeId) { }

	private Locale ConvertToLocale(Dictionary dictionary) { }

	[CompilerGenerated]
	public IDictionary get_AvailableLanguages() { }

	[CompilerGenerated]
	internal string get_Culture() { }

	public static string get_DefaultLanguage() { }

	internal static LocalizationManager get_Instance() { }

	internal bool HasValidLocalization(string id) { }

	public void Init(Dictionary availableLanguages) { }

	internal string LanguageName(string culture) { }

	internal string LocalizedValue(string id) { }

	private string LocalizedValue(string id, string locale) { }

	[CompilerGenerated]
	private void set_AvailableLanguages(IDictionary value) { }

	[CompilerGenerated]
	internal void set_Culture(string value) { }

	private bool TryGetLocalization(string id, string locale, out string localizedValue) { }

	public void UpdateApplicationLanguage() { }

	private void UpdateFonts(string localeType) { }

	private void UpdateLocale(string localeId, Locale newLocale) { }

	public void UpdateLocales(string localeId, Dictionary newLocale, bool isMainLocale = false) { }

	public void UpdateMainMenuLocales(string localeId, Locale newLocale) { }

}

