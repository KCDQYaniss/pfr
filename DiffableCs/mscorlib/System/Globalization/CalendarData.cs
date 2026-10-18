namespace System.Globalization;

internal class CalendarData
{
	internal const int MAX_CALENDARS = 23; //Field offset: 0x0
	internal static CalendarData Invariant; //Field offset: 0x0
	private static string[] HEBREW_MONTH_NAMES; //Field offset: 0x8
	private static string[] HEBREW_LEAP_MONTH_NAMES; //Field offset: 0x10
	internal string sNativeName; //Field offset: 0x10
	internal string[] saShortDates; //Field offset: 0x18
	internal string[] saYearMonths; //Field offset: 0x20
	internal string[] saLongDates; //Field offset: 0x28
	internal string sMonthDay; //Field offset: 0x30
	internal string[] saEraNames; //Field offset: 0x38
	internal string[] saAbbrevEraNames; //Field offset: 0x40
	internal string[] saAbbrevEnglishEraNames; //Field offset: 0x48
	internal string[] saDayNames; //Field offset: 0x50
	internal string[] saAbbrevDayNames; //Field offset: 0x58
	internal string[] saSuperShortDayNames; //Field offset: 0x60
	internal string[] saMonthNames; //Field offset: 0x68
	internal string[] saAbbrevMonthNames; //Field offset: 0x70
	internal string[] saMonthGenitiveNames; //Field offset: 0x78
	internal string[] saAbbrevMonthGenitiveNames; //Field offset: 0x80
	internal string[] saLeapYearMonthNames; //Field offset: 0x88
	internal int iTwoDigitYearMax; //Field offset: 0x90
	internal int iCurrentEra; //Field offset: 0x94
	internal bool bUseUserOverrides; //Field offset: 0x98

	private static CalendarData() { }

	private CalendarData() { }

	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides) { }

	private static string CalendarIdToCultureName(int calendarId) { }

	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

	internal static CalendarData GetCalendarData(int calendarId) { }

	private static string[] GetJapaneseEnglishEraNames() { }

	private static string[] GetJapaneseEraNames() { }

	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	private void InitializeEraNames(string localeName, int calendarId) { }

	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	public static int nativeGetTwoDigitYearMax(int calID) { }

}

