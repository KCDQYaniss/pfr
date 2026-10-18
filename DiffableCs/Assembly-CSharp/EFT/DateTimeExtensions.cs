namespace EFT;

[Extension]
public static class DateTimeExtensions
{
	public const int SECONDS_IN_MINUTE = 60; //Field offset: 0x0
	public const int SECONDS_IN_HOUR = 3600; //Field offset: 0x0
	public const int SECONDS_IN_DAY = 86400; //Field offset: 0x0
	public static readonly DateTime UnixEpoch; //Field offset: 0x0
	private static DateTime _startTimeLocal; //Field offset: 0x8
	private static DateTime _startTimeUtc; //Field offset: 0x10
	private static Stopwatch _stopwatch; //Field offset: 0x18

	public static DateTime MoscowNow
	{
		 get { } //Length: 194
	}

	public static DateTime Now
	{
		 get { } //Length: 272
	}

	public static double NowUnix
	{
		 get { } //Length: 79
	}

	public static DateTime UtcNow
	{
		 get { } //Length: 272
	}

	public static double UtcNowUnix
	{
		 get { } //Length: 79
	}

	public static int UtcNowUnixInt
	{
		 get { } //Length: 84
	}

	private static DateTimeExtensions() { }

	public static DateTime FromHour(int hour) { }

	public static DateTime get_MoscowNow() { }

	public static DateTime get_Now() { }

	public static double get_NowUnix() { }

	public static DateTime get_UtcNow() { }

	public static double get_UtcNowUnix() { }

	public static int get_UtcNowUnixInt() { }

	public static DateTime LocalDateTimeFromUnixTime(double milliseconds) { }

	public static void SetServerTime(double milliseconds) { }

	public static DateTime StartOfDay() { }

	[Extension]
	public static double ToUnixTime(DateTime dateTime) { }

	public static DateTime UniversalDateTimeFromUnixTime(double seconds) { }

}

