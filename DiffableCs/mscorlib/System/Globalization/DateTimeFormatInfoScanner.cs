namespace System.Globalization;

internal class DateTimeFormatInfoScanner
{
	private enum FoundDatePattern
	{
		None = 0,
		FoundYearPatternFlag = 1,
		FoundMonthPatternFlag = 2,
		FoundDayPatternFlag = 4,
		FoundYMDPatternFlag = 7,
	}

	private static Dictionary s_knownWords; //Field offset: 0x0
	internal List m_dateWords; //Field offset: 0x10
	private FoundDatePattern _ymdFlags; //Field offset: 0x18

	private static Dictionary KnownWords
	{
		private get { } //Length: 1640
	}

	public DateTimeFormatInfoScanner() { }

	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	internal void AddIgnorableSymbols(string text) { }

	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	private static bool ArrayElementsHaveSpace(string[] array) { }

	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	private static Dictionary get_KnownWords() { }

	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	internal void ScanDateWord(string pattern) { }

	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

}

