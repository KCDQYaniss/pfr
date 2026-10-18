namespace EFT;

public static class ClientLoadTimeMetrics
{
	private static readonly int OFFLINE_METRICS; //Field offset: 0x0
	private static readonly int ONLINE_METRICS; //Field offset: 0x4
	private static readonly int GAME_STARTUP_METRIC; //Field offset: 0x8
	private static readonly int RAID_LOAD_METRIC; //Field offset: 0xC
	private static readonly int DEATH_TO_STATS_METRIC; //Field offset: 0x10
	private static readonly int STATS_TO_MENU_METRIC; //Field offset: 0x14
	private static Stopwatch _gameStartupStopwatch; //Field offset: 0x18
	private static Stopwatch _locationLoadStopwatch; //Field offset: 0x20
	private static Stopwatch _deathToStatisticsStopwatch; //Field offset: 0x28
	private static Stopwatch _statisticsToMenuStopwatch; //Field offset: 0x30
	private static bool _lastRaidOffline; //Field offset: 0x38
	private static string _raidLocationName; //Field offset: 0x40
	private static bool _loadTimeMetricIsPmc; //Field offset: 0x48
	private static bool _isEnabled; //Field offset: 0x49
	private static bool _suppressMetricsForTutorialFlow; //Field offset: 0x4A

	private static bool CanRecordLoadTimeMetrics
	{
		private get { } //Length: 87
	}

	private static ClientLoadTimeMetrics() { }

	public static void BeginDeathToStatisticsLoad(bool offlineRaid, bool isPmc) { }

	public static void BeginGameStartupToMainMenu() { }

	public static void BeginLocationLoadToRaidStart(bool offlineRaid, string locationName, bool isPmc) { }

	public static void BeginStatisticsCloseToMainMenu(bool offlineRaid, bool isPmc) { }

	public static void BeginSuppressingForTutorialFlow() { }

	public static void EnableMetricsCollection(bool enable) { }

	public static void EndDeathToStatisticsLoad(bool offlineRaid, bool isPmc) { }

	public static void EndLocationLoadToRaidStart(bool offlineRaid, bool sendMetrics) { }

	private static bool get_CanRecordLoadTimeMetrics() { }

	public static void OnMainMenuShown(bool interactiveMainMenuForColdBoot) { }

	private static void ResetAllStopWatches() { }

	private static void ResetRaidLoadAndDeathState() { }

	private static void SendLoadMetric(bool offlineRaid, int metricsType, double elapsedSeconds, string locationName, bool isPmc) { }

}

