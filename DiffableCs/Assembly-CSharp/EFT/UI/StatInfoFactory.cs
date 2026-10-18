namespace EFT.UI;

public class StatInfoFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Handbook handbook; //Field offset: 0x10
		public string privateDogtagId; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal float <AddOverallStats>b__0(Item item) { }

	}

	private readonly EStatisticsType _type; //Field offset: 0x10
	private readonly StaticIcons _staticIcons; //Field offset: 0x18
	private readonly Profile _profile; //Field offset: 0x20
	private readonly List _statGroups; //Field offset: 0x28
	private readonly CountersCollection _counters; //Field offset: 0x30

	private bool Available
	{
		private get { } //Length: 9
	}

	public StatInfoFactory(EStatisticsType type, Profile profile, CountersCollection counters, List statGroups) { }

	public void AddBattleStats() { }

	public void AddDailyStats() { }

	public void AddHealthStats() { }

	public void AddLootingStats() { }

	public void AddOverallStats() { }

	public void AddStandingStats() { }

	private void AddStatInfo(ICollection list, string caption, EStatType type, string value, bool forceIgnoreZero = false) { }

	private string BodyPartName(EBodyPart part) { }

	private StatGroup CreateStatGroup(string caption, EStatGroupId statGroupId) { }

	private bool get_Available() { }

	private EBodyPart GetBodyPartFromCounter(Identifier key) { }

	private static string GetSurvivorClassText(ESurvivorClass survivorClass) { }

	private EBodyPart LeastDamagedBodyPart() { }

	private bool TryGetFavoriteQuestType(out EStatQuestType questType) { }

}

