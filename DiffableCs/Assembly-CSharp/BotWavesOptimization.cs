//Type is in global namespace

public static class BotWavesOptimization
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public CountTypeBotWave countTypeBotWave; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <OptimizeBotWavesSimple>b__0(CountTypeBotWave x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public CountTypeBotWave botWave; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <OptimizeBotWaves>b__0(CountTypeBotWave x) { }

		internal bool <OptimizeBotWaves>b__1(CountTypeBotWave x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public WildSpawnType role; //Field offset: 0x10
		public BotDifficulty difficulty; //Field offset: 0x14

		public <>c__DisplayClass8_0() { }

		internal bool <MarkAsDelayed>b__0(CountTypeBotWave x) { }

	}

	private const int BACKEND_MAX = 55; //Field offset: 0x0
	private const int PER_ROLE_LIMIT = 30; //Field offset: 0x0
	private const int MAX_MARKSMANS_AMOUNT = 10; //Field offset: 0x0

	private static void CutOffLimit(List array, List delayed, int limit) { }

	private static void MarkAsDelayed(WildSpawnType role, BotDifficulty difficulty, int count, List delayed) { }

	public static List OptimizeBotWaves(List wavesProfiles, out List delayed) { }

	public static List OptimizeBotWavesSimple(List wavesProfile) { }

	private static void ReduceBotsAmount(List array, List delayed, float coeff, ref int delta, ref int targetDelta, bool alignLast) { }

	private static void ReduceBotsAmountByType(List array, List delayed, WildSpawnType role, int maxAmount, int maxReduce) { }

}

