namespace EFT;

[Extension]
public static class TimeSpanExtensions
{
	private const string HOURS_LOCALIZATION_KEY = "HOURS"; //Field offset: 0x0
	private const string MIN_LOCALIZATION_KEY = "MIN"; //Field offset: 0x0
	private const string DAYS_LOCALIZATION_KEY = " d. "; //Field offset: 0x0
	private const string TIME_FORMAT_DELIMITER = ":"; //Field offset: 0x0
	private const string DAYS_SHORT_LOCALIZATION_KEY = "d"; //Field offset: 0x0
	private const string MINS_SHORT_LOCALIZATION_KEY = "m"; //Field offset: 0x0
	private static readonly List _timeFormatStrings; //Field offset: 0x0

	private static TimeSpanExtensions() { }

	[Extension]
	public static TimeSpan Clamp(TimeSpan span, TimeSpan from, TimeSpan to) { }

	private static long Clamp(long value, long min, long max) { }

	[Extension]
	public static string DailyQuestFormat(TimeSpan timeSpan) { }

	[Extension]
	public static string DailyStatFormat(TimeSpan timeSpan) { }

	[Extension]
	public static ValueTuple Decompose(TimeSpan span) { }

	[Extension]
	public static void Deconstruct(TimeSpan span, out int hours, out int minutes, out int seconds) { }

	[Extension]
	public static string EftArenaTransferFormat(TimeSpan timeLeft) { }

	[Extension]
	public static TimeSpan Multiply(TimeSpan multiplicand, float multiplier) { }

	[Extension]
	public static TimeSpan MultiplyByPercent(TimeSpan multiplicand, int percent) { }

	[Extension]
	public static string RagfairDateFormatLong(TimeSpan timeSpan) { }

	[Extension]
	public static string RagfairDateFormatShort(TimeSpan timeSpan) { }

	[Extension]
	public static int RoundedSeconds(TimeSpan timeSpan) { }

	[Extension]
	public static string SeasonsDateFormatLong(TimeSpan timeSpan) { }

	[Extension]
	public static string TimeLeftShortFormat(TimeSpan timeSpan, char separator =  ) { }

	[Extension]
	public static string TimePassedFormat(TimeSpan timeSpan) { }

	[Extension]
	public static string TraderFormat(TimeSpan timeLeft) { }

}

