namespace System.Globalization;

public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	public class TokenHashValue
	{
		internal string tokenString; //Field offset: 0x10
		internal TokenType tokenType; //Field offset: 0x18
		internal int tokenValue; //Field offset: 0x1C

		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue) { }

	}

	private static DateTimeFormatInfo s_invariantInfo; //Field offset: 0x0
	internal const string KoreanYearSuff = "년"; //Field offset: 0x0
	internal const string CJKDaySuff = "日"; //Field offset: 0x0
	internal const string CJKMonthSuff = "月"; //Field offset: 0x0
	internal const string CJKYearSuff = "年"; //Field offset: 0x0
	internal const string IgnorableComma = ","; //Field offset: 0x0
	internal const string IgnorablePeriod = "."; //Field offset: 0x0
	internal const string KoreanMonthSuff = "월"; //Field offset: 0x0
	private const string invariantTimeSeparator = ":"; //Field offset: 0x0
	private const string dateSeparatorOrTimeZoneOffset = "-"; //Field offset: 0x0
	private const int SECOND_PRIME = 197; //Field offset: 0x0
	private const int TOKEN_HASH_SIZE = 199; //Field offset: 0x0
	internal const DateTimeStyles InvalidDateTimeStyles = -256; //Field offset: 0x0
	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz"; //Field offset: 0x0
	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"; //Field offset: 0x0
	private const string invariantDateSeparator = "/"; //Field offset: 0x0
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132; //Field offset: 0x0
	internal const string KoreanDaySuff = "일"; //Field offset: 0x0
	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'"; //Field offset: 0x0
	internal const string EnglishLangName = "en"; //Field offset: 0x0
	internal const string JapaneseLangName = "ja"; //Field offset: 0x0
	internal const string KoreanLangName = "ko"; //Field offset: 0x0
	internal const string ZuluName = "Z"; //Field offset: 0x0
	internal const string GMTName = "GMT"; //Field offset: 0x0
	internal const string LocalTimeMark = "T"; //Field offset: 0x0
	internal const string KoreanHourSuff = "시"; //Field offset: 0x0
	internal const string JapaneseEraStart = "元"; //Field offset: 0x0
	internal const string CJKMinuteSuff = "分"; //Field offset: 0x0
	internal const string ChineseHourSuff = "时"; //Field offset: 0x0
	internal const string CJKHourSuff = "時"; //Field offset: 0x0
	internal const string KoreanSecondSuff = "초"; //Field offset: 0x0
	internal const string KoreanMinuteSuff = "분"; //Field offset: 0x0
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"; //Field offset: 0x0
	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"; //Field offset: 0x0
	internal const string CJKSecondSuff = "秒"; //Field offset: 0x0
	private static readonly char[] s_monthSpaces; //Field offset: 0x8
	private static DateTimeFormatInfo s_jajpDTFI; //Field offset: 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; //Field offset: 0x18
	private CultureData _cultureData; //Field offset: 0x10
	private string _name; //Field offset: 0x18
	private string _langName; //Field offset: 0x20
	private CompareInfo _compareInfo; //Field offset: 0x28
	private CultureInfo _cultureInfo; //Field offset: 0x30
	private string amDesignator; //Field offset: 0x38
	private string pmDesignator; //Field offset: 0x40
	private string dateSeparator; //Field offset: 0x48
	private string generalShortTimePattern; //Field offset: 0x50
	private string generalLongTimePattern; //Field offset: 0x58
	private string timeSeparator; //Field offset: 0x60
	private string monthDayPattern; //Field offset: 0x68
	private string dateTimeOffsetPattern; //Field offset: 0x70
	private Calendar calendar; //Field offset: 0x78
	private int firstDayOfWeek; //Field offset: 0x80
	private int calendarWeekRule; //Field offset: 0x84
	private string fullDateTimePattern; //Field offset: 0x88
	private string[] abbreviatedDayNames; //Field offset: 0x90
	private string[] m_superShortDayNames; //Field offset: 0x98
	private string[] dayNames; //Field offset: 0xA0
	private string[] abbreviatedMonthNames; //Field offset: 0xA8
	private string[] monthNames; //Field offset: 0xB0
	private string[] genitiveMonthNames; //Field offset: 0xB8
	private string[] m_genitiveAbbreviatedMonthNames; //Field offset: 0xC0
	private string[] leapYearMonthNames; //Field offset: 0xC8
	private string longDatePattern; //Field offset: 0xD0
	private string shortDatePattern; //Field offset: 0xD8
	private string yearMonthPattern; //Field offset: 0xE0
	private string longTimePattern; //Field offset: 0xE8
	private string shortTimePattern; //Field offset: 0xF0
	private string[] allYearMonthPatterns; //Field offset: 0xF8
	private string[] allShortDatePatterns; //Field offset: 0x100
	private string[] allLongDatePatterns; //Field offset: 0x108
	private string[] allShortTimePatterns; //Field offset: 0x110
	private string[] allLongTimePatterns; //Field offset: 0x118
	private string[] m_eraNames; //Field offset: 0x120
	private string[] m_abbrevEraNames; //Field offset: 0x128
	private string[] m_abbrevEnglishEraNames; //Field offset: 0x130
	private CalendarId[] optionalCalendars; //Field offset: 0x138
	internal bool _isReadOnly; //Field offset: 0x140
	private DateTimeFormatFlags formatFlags; //Field offset: 0x144
	private string _fullTimeSpanPositivePattern; //Field offset: 0x148
	private string _fullTimeSpanNegativePattern; //Field offset: 0x150
	private TokenHashValue[] _dtfiTokenHash; //Field offset: 0x158

	public string[] AbbreviatedDayNames
	{
		 get { } //Length: 143
	}

	internal string[] AbbreviatedEnglishEraNames
	{
		internal get { } //Length: 200
	}

	internal string[] AbbreviatedEraNames
	{
		internal get { } //Length: 200
	}

	public string[] AbbreviatedMonthNames
	{
		 get { } //Length: 143
	}

	private string[] AllLongDatePatterns
	{
		private get { } //Length: 117
	}

	private string[] AllLongTimePatterns
	{
		private get { } //Length: 117
	}

	private string[] AllShortDatePatterns
	{
		private get { } //Length: 117
	}

	private string[] AllShortTimePatterns
	{
		private get { } //Length: 117
	}

	private string[] AllYearMonthPatterns
	{
		private get { } //Length: 117
	}

	public string AMDesignator
	{
		 get { } //Length: 111
	}

	public Calendar Calendar
	{
		 get { } //Length: 5
		 set { } //Length: 1307
	}

	internal CompareInfo CompareInfo
	{
		internal get { } //Length: 398
	}

	private CultureInfo Culture
	{
		private get { } //Length: 187
	}

	private string CultureName
	{
		private get { } //Length: 111
	}

	public static DateTimeFormatInfo CurrentInfo
	{
		 get { } //Length: 330
	}

	public string DateSeparator
	{
		 get { } //Length: 165
	}

	internal string DateTimeOffsetPattern
	{
		internal get { } //Length: 534
	}

	public string[] DayNames
	{
		 get { } //Length: 143
	}

	internal string[] EraNames
	{
		internal get { } //Length: 200
	}

	internal DateTimeFormatFlags FormatFlags
	{
		internal get { } //Length: 23
	}

	public string FullDateTimePattern
	{
		 get { } //Length: 206
	}

	internal string FullTimeSpanNegativePattern
	{
		internal get { } //Length: 174
	}

	internal string FullTimeSpanPositivePattern
	{
		internal get { } //Length: 312
	}

	internal string GeneralLongTimePattern
	{
		internal get { } //Length: 187
	}

	internal string GeneralShortTimePattern
	{
		internal get { } //Length: 187
	}

	internal bool HasForceTwoDigitYears
	{
		internal get { } //Length: 54
	}

	internal bool HasSpacesInDayNames
	{
		internal get { } //Length: 46
	}

	internal bool HasSpacesInMonthNames
	{
		internal get { } //Length: 46
	}

	internal bool HasYearMonthAdjustment
	{
		internal get { } //Length: 46
	}

	public static DateTimeFormatInfo InvariantInfo
	{
		 get { } //Length: 335
	}

	public bool IsReadOnly
	{
		 get { } //Length: 151
	}

	private string LanguageName
	{
		private get { } //Length: 111
	}

	public string LongDatePattern
	{
		 get { } //Length: 153
	}

	public string LongTimePattern
	{
		 get { } //Length: 153
	}

	public string MonthDayPattern
	{
		 get { } //Length: 181
	}

	public string[] MonthGenitiveNames
	{
		 get { } //Length: 134
	}

	public string[] MonthNames
	{
		 get { } //Length: 143
	}

	private CalendarId[] OptionalCalendars
	{
		private get { } //Length: 386
	}

	public string PMDesignator
	{
		 get { } //Length: 111
	}

	public string RFC1123Pattern
	{
		 get { } //Length: 49
	}

	public string ShortDatePattern
	{
		 get { } //Length: 153
	}

	public string ShortTimePattern
	{
		 get { } //Length: 153
	}

	public string SortableDateTimePattern
	{
		 get { } //Length: 49
	}

	public string TimeSeparator
	{
		 get { } //Length: 111
	}

	private string[] UnclonedLongDatePatterns
	{
		private get { } //Length: 200
	}

	private string[] UnclonedLongTimePatterns
	{
		private get { } //Length: 130
	}

	private string[] UnclonedShortDatePatterns
	{
		private get { } //Length: 200
	}

	private string[] UnclonedShortTimePatterns
	{
		private get { } //Length: 130
	}

	private string[] UnclonedYearMonthPatterns
	{
		private get { } //Length: 200
	}

	public string UniversalSortableDateTimePattern
	{
		 get { } //Length: 49
	}

	public string YearMonthPattern
	{
		 get { } //Length: 153
	}

	private static DateTimeFormatInfo() { }

	public DateTimeFormatInfo() { }

	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal) { }

	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	private void ClearTokenHashTable() { }

	public override object Clone() { }

	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	internal TokenHashValue[] CreateTokenHashTable() { }

	public string[] get_AbbreviatedDayNames() { }

	internal string[] get_AbbreviatedEnglishEraNames() { }

	internal string[] get_AbbreviatedEraNames() { }

	public string[] get_AbbreviatedMonthNames() { }

	private string[] get_AllLongDatePatterns() { }

	private string[] get_AllLongTimePatterns() { }

	private string[] get_AllShortDatePatterns() { }

	private string[] get_AllShortTimePatterns() { }

	private string[] get_AllYearMonthPatterns() { }

	public string get_AMDesignator() { }

	public Calendar get_Calendar() { }

	internal CompareInfo get_CompareInfo() { }

	private CultureInfo get_Culture() { }

	private string get_CultureName() { }

	public static DateTimeFormatInfo get_CurrentInfo() { }

	public string get_DateSeparator() { }

	internal string get_DateTimeOffsetPattern() { }

	public string[] get_DayNames() { }

	internal string[] get_EraNames() { }

	internal DateTimeFormatFlags get_FormatFlags() { }

	public string get_FullDateTimePattern() { }

	internal string get_FullTimeSpanNegativePattern() { }

	internal string get_FullTimeSpanPositivePattern() { }

	internal string get_GeneralLongTimePattern() { }

	internal string get_GeneralShortTimePattern() { }

	internal bool get_HasForceTwoDigitYears() { }

	internal bool get_HasSpacesInDayNames() { }

	internal bool get_HasSpacesInMonthNames() { }

	internal bool get_HasYearMonthAdjustment() { }

	public static DateTimeFormatInfo get_InvariantInfo() { }

	public bool get_IsReadOnly() { }

	private string get_LanguageName() { }

	public string get_LongDatePattern() { }

	public string get_LongTimePattern() { }

	public string get_MonthDayPattern() { }

	public string[] get_MonthGenitiveNames() { }

	public string[] get_MonthNames() { }

	private CalendarId[] get_OptionalCalendars() { }

	public string get_PMDesignator() { }

	public string get_RFC1123Pattern() { }

	public string get_ShortDatePattern() { }

	public string get_ShortTimePattern() { }

	public string get_SortableDateTimePattern() { }

	public string get_TimeSeparator() { }

	private string[] get_UnclonedLongDatePatterns() { }

	private string[] get_UnclonedLongTimePatterns() { }

	private string[] get_UnclonedShortDatePatterns() { }

	private string[] get_UnclonedShortTimePatterns() { }

	private string[] get_UnclonedYearMonthPatterns() { }

	public string get_UniversalSortableDateTimePattern() { }

	public string get_YearMonthPattern() { }

	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	public string GetAbbreviatedEraName(int era) { }

	public string GetAbbreviatedMonthName(int month) { }

	public string[] GetAllDateTimePatterns(char format) { }

	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	public string GetDayName(DayOfWeek dayofweek) { }

	public string GetEraName(int era) { }

	public override object GetFormat(Type formatType) { }

	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	public string GetMonthName(int month) { }

	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	private DateTimeFormatFlags InitializeFormatFlags() { }

	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	private string[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	private string[] internalGetAbbreviatedMonthNames() { }

	private string[] internalGetAbbreviatedMonthNamesCore() { }

	private string[] internalGetDayOfWeekNames() { }

	private string[] internalGetDayOfWeekNamesCore() { }

	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	internal string[] internalGetLeapYearMonthNames() { }

	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	private string[] internalGetMonthNames() { }

	private string[] internalGetMonthNamesCore() { }

	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	private static bool IsHebrewChar(char ch) { }

	private static bool IsJapaneseCalendar(Calendar calendar) { }

	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	public void set_Calendar(Calendar value) { }

	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

}

