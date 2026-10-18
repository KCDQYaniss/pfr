//Type is in global namespace

public sealed class ProfileStats
{
	internal enum EStatType
	{
		Date = 0,
		DateTime = 1,
		Experience = 2,
		Litres = 3,
		Number = 4,
		BodyPart = 5,
		Health = 6,
		SurvivorClass = 7,
		Text = 8,
	}

	internal enum ESurvivorClass
	{
		Unknown = 0,
		Neutralizer = 1,
		Marauder = 2,
		Paramedic = 3,
		Survivor = 4,
	}

	internal sealed class StatInfo
	{
		public string Caption; //Field offset: 0x10
		public object Value; //Field offset: 0x18
		public EStatType Type; //Field offset: 0x20

		public StatInfo() { }

	}

	public CountersCollection SessionCounters; //Field offset: 0x10
	public readonly CountersCollection OverallCounters; //Field offset: 0x18
	public float SessionExperienceMult; //Field offset: 0x20
	public float ExperienceBonusMult; //Field offset: 0x24
	public GameEditionExperienceBonus GameEditionExperienceBonus; //Field offset: 0x28
	public int TotalSessionExperience; //Field offset: 0x30
	[JsonIgnore]
	public int ReferralExperienceBonusPercent; //Field offset: 0x34
	public int LastSessionDate; //Field offset: 0x38
	public AggressorStats Aggressor; //Field offset: 0x40
	public readonly List DroppedItems; //Field offset: 0x48
	public readonly List FoundInRaidItems; //Field offset: 0x50
	public readonly UpdatableBindableList Victims; //Field offset: 0x58
	public readonly List CarriedQuestItems; //Field offset: 0x60
	[CanBeNull]
	public readonly DamageHistory DamageHistory; //Field offset: 0x68
	[CanBeNull]
	public DeathCause DeathCause; //Field offset: 0x70
	[CanBeNull]
	public PlayerVisualRepresentation LastPlayerState; //Field offset: 0x78
	public long TotalInGameTime; //Field offset: 0x80

	public ESurvivorClass SurvivorClass
	{
		 get { } //Length: 397
	}

	public ProfileStats(ProfileStatsDescriptor descriptor) { }

	public ESurvivorClass get_SurvivorClass() { }

}

