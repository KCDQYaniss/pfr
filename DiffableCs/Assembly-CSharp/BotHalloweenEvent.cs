//Type is in global namespace

public sealed class BotHalloweenEvent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_0; //Field offset: 0x8
		public static Func <>9__38_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CheckOnFinalTime>b__33_0(BotOwner x) { }

		internal bool <CheckOnSectantsCount>b__38_0(BotOwner x) { }

	}

	public const string ZRYACHIY_PEAACE_KILL = "ZryachiyPeaceKill"; //Field offset: 0x0
	public const string ZRYACHIY_SUMMON_COMPLETE = "SummonComplete"; //Field offset: 0x0
	public const string ZRYACHIY_SUMMON_FAIL = "SummonFail"; //Field offset: 0x0
	public const string FIRST_CONTACT = "HalloweenFirstContact"; //Field offset: 0x0
	public const string FIRST_KILL = "HalloweenFirstKill"; //Field offset: 0x0
	public const int CULTIST_ANIMATION_LAYER = 17; //Field offset: 0x0
	public int ToCircle; //Field offset: 0x10
	public bool IsEventRaised; //Field offset: 0x14
	private readonly BotsEventsController _allEvents; //Field offset: 0x18
	private readonly BotSpawner _spawner; //Field offset: 0x20
	private readonly AIPlaceInfoHolder _placesInfo; //Field offset: 0x28
	private readonly int _eventTime; //Field offset: 0x30
	private AIPlaceInfoHalloweenCircle _targetCircle; //Field offset: 0x38
	private bool _ritualStarted; //Field offset: 0x40
	private float _endSummon; //Field offset: 0x44
	private bool _firstContact; //Field offset: 0x48
	private bool _firstKill; //Field offset: 0x49
	private int _ownerSectantGroup; //Field offset: 0x4C
	[CompilerGenerated]
	private readonly HashSet <PlayersIdsToKill>k__BackingField; //Field offset: 0x50
	public HashSet PlayersRaidIdsToKill; //Field offset: 0x58

	public HashSet PlayersIdsToKill
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AIPlaceInfoHalloweenCircle TargetCircle
	{
		 get { } //Length: 1423
	}

	public BotHalloweenEvent(BotsEventsController allEvents, BotSpawner spawner, AIPlaceInfoHolder placesInfo) { }

	public void AddToKill(IPlayer player) { }

	private void CheckOnFinalTime() { }

	public void CheckOnSectantsCount() { }

	public void Dispose() { }

	public void FirstContact() { }

	[CompilerGenerated]
	public HashSet get_PlayersIdsToKill() { }

	public AIPlaceInfoHalloweenCircle get_TargetCircle() { }

	public bool IsMyGroup(int ownerGroupId) { }

	public void KillFirstSectant() { }

	private void OnBotRemove(BotOwner obj) { }

	public void PeaceZryachiyKilled() { }

	private void RaiseSpawnEvent() { }

	public void RitualCompleted() { }

	public void RitualFail() { }

	public void SetupGroup(int ownerGroupId) { }

	public void StartRitual() { }

	public void UpdateFromBoss() { }

}

