namespace EFT;

[GenerateBinarySerialization]
public sealed class ProfileStatsDescriptor
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__ClonePolymorph; //Field offset: 0x0
		public static Func <1>__ClonePolymorph; //Field offset: 0x8
		public static Func <2>__ClonePolymorph; //Field offset: 0x10

	}

	[JsonProperty("SessionCounters", NullValueHandling = NullValueHandling::Ignore (1))]
	public CounterCollectionDescriptor SessionCounters; //Field offset: 0x10
	[JsonProperty("OverallCounters", NullValueHandling = NullValueHandling::Ignore (1))]
	public CounterCollectionDescriptor OverallCounters; //Field offset: 0x18
	[JsonProperty("SessionExperienceMult")]
	public float SessionExperienceMult; //Field offset: 0x20
	[JsonProperty("ExperienceBonusMult")]
	public float ExperienceBonusMult; //Field offset: 0x24
	[JsonProperty("GameEditionExperienceBonus", NullValueHandling = NullValueHandling::Ignore (1))]
	public GameEditionExperienceBonus GameEditionExperienceBonus; //Field offset: 0x28
	[JsonProperty("TotalSessionExperience")]
	public int TotalSessionExperience; //Field offset: 0x30
	[JsonProperty("LastSessionDate")]
	public int LastSessionDate; //Field offset: 0x34
	[CanBeNull]
	[JsonProperty("Aggressor", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public AggressorStats Aggressor; //Field offset: 0x38
	[JsonProperty("DroppedItems", NullValueHandling = NullValueHandling::Ignore (1))]
	public List DroppedItems; //Field offset: 0x40
	[JsonProperty("FoundInRaidItems", NullValueHandling = NullValueHandling::Ignore (1))]
	public List FoundInRaidItems; //Field offset: 0x48
	[JsonProperty("Victims", NullValueHandling = NullValueHandling::Ignore (1))]
	public List Victims; //Field offset: 0x50
	[JsonProperty("CarriedQuestItems", NullValueHandling = NullValueHandling::Ignore (1))]
	public List CarriedQuestItems; //Field offset: 0x58
	[CanBeNull]
	[JsonProperty("DamageHistory", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public DamageHistoryDescriptor DamageHistory; //Field offset: 0x60
	[CanBeNull]
	[JsonProperty("DeathCause", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public DeathCause DeathCause; //Field offset: 0x68
	[CanBeNull]
	[JsonProperty("LastPlayerState", NullValueHandling = NullValueHandling::Ignore (1))]
	[Nullable]
	public PlayerVisualRepresentationDescriptor LastPlayerState; //Field offset: 0x70
	[JsonProperty("TotalInGameTime")]
	public long TotalInGameTime; //Field offset: 0x78
	[JsonProperty("SurvivorClass")]
	public ESurvivorClass SurvivorClass; //Field offset: 0x80

	public ProfileStatsDescriptor() { }

	public ProfileStatsDescriptor(ProfileStats stats) { }

}

