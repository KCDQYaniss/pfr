namespace Audio.SpatialSystem.Utils;

public static class AudioLogRateLimiter
{
	private struct RateLimitRecord
	{
		public float lastLogTime; //Field offset: 0x0
		public int suppressedCount; //Field offset: 0x4

	}

	private static readonly Dictionary _records; //Field offset: 0x0
	private const int MAX_RECORDS = 1000; //Field offset: 0x0

	private static AudioLogRateLimiter() { }

	public static bool AllowLog(string key, float minIntervalSeconds) { }

	public static void Clear() { }

	public static int GetSuppressedCount(string key) { }

	public static string GetSuppressedSuffix(string key) { }

	public static void ResetSuppressedCount(string key) { }

}

