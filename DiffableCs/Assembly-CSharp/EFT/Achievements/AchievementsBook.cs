namespace EFT.Achievements;

public sealed class AchievementsBook : ConditionalBook, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public AchievementTemplate template; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <CreateAchievement>b__0(KeyValuePair s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public AchievementTemplate template; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <TryCreateAchievement>b__0(Achievement existingAchievement) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public AchievementsBook <>4__this; //Field offset: 0x10
		public int i; //Field offset: 0x18
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal bool <RemoveConditionalsWithoutTemplate>b__0(AchievementTemplate x) { }

	}

	private readonly Dictionary _completedStatuses; //Field offset: 0x88
	private readonly Dictionary _globalProgressData; //Field offset: 0x90

	public AchievementsBook(string profileId, EPlayerSide profileGroup, Dictionary achievementsData, Dictionary globalProgressData, Dictionary conditionCounters) { }

	private void CreateAchievement(AchievementTemplate template) { }

	private Achievement CreateAchievement(AchievementTemplate template, AchievementStatusData statusData, Dictionary conditionCounters) { }

	private AchievementStatusData CreateStatus(int unlockDate, AchievementTemplate template) { }

	public virtual void Dispose() { }

	public virtual void LoadAll() { }

	public virtual void RemoveConditionalsWithoutTemplate() { }

	private void TryCreateAchievement(AchievementTemplate template) { }

}

