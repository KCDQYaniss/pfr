//Type is in global namespace

public static class FinalStatsDataProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetFavoriteWeapon>b__1_0(KeyValuePair mastering) { }

	}


	private static float CalculateKillDeathRatio(CountersCollection counters) { }

	public static FinalStatsArgs CreateFinalStatsArgs(Profile profile, AchievementsController achievementsController, QuestController questController, IEftSession session, EGameMode mode, EndingElement finalEnding, EFinalType finalType) { }

	public static FinalStatsArgs CreateTestData() { }

	private static void FillCombatStats(ref FinalStatsArgs args, CountersCollection counters) { }

	private static void FillPlayerInfo(ref FinalStatsArgs args, Profile profile) { }

	private static string GetFavoriteWeapon(Profile profile, out int maxKills) { }

	private static string GetGameEdition(Profile profile) { }

}

