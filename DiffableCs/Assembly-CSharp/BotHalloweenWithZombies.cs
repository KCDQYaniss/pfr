//Type is in global namespace

public class BotHalloweenWithZombies
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <StopPartisan>b__21_0(BossLocationSpawn x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public BotHalloweenWithZombies <>4__this; //Field offset: 0x10
		public BotOwner bot; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <SubscribeOnZombie>b__0(DamageInfo di, EBodyPart bp, float t) { }

		internal void <SubscribeOnZombie>b__1(IPlayer trg) { }

	}

	private const string MINIMAL_INFECTED_SPAWN_TRIGGER = "MinimalInfectedBotOnStart"; //Field offset: 0x0
	private BotsList _list; //Field offset: 0x10
	private List _activePursuits; //Field offset: 0x18
	private BotHalloween2024 _halloweenConfig; //Field offset: 0x20
	private BotHalloweenCrowdSpawn _crowdSpawn; //Field offset: 0x28
	private BotHalloweenDistributions _botHalloweenDistributions; //Field offset: 0x30
	private bool _isInited; //Field offset: 0x38
	private BotSpawner _spawner; //Field offset: 0x40
	private bool _midSessionSpawned; //Field offset: 0x48

	public int InfectionPercentage
	{
		 get { } //Length: 18
	}

	public float MinSpawnDistToPlayer
	{
		 get { } //Length: 21
	}

	public float TargetPointSearchRadiusLimit
	{
		 get { } //Length: 21
	}

	public float ZombieLookCoeff
	{
		 get { } //Length: 26
	}

	public BotHalloweenWithZombies(BotsEventsController botsEventsController, BotsList botsList, BotSpawner spawner, BotHalloween2024 halloweenConfig) { }

	public void Activate() { }

	private void AddBackupProfiles() { }

	private void CheckMidSessionTriggerBotsSpawn() { }

	public void Dispose() { }

	private void DistributeZombie(BotOwner bot) { }

	public int get_InfectionPercentage() { }

	public float get_MinSpawnDistToPlayer() { }

	public float get_TargetPointSearchRadiusLimit() { }

	public float get_ZombieLookCoeff() { }

	public Vector3 GetNearestPursuitCenter(BotOwner owner) { }

	public static IEnumerable GetProfilesOnStart() { }

	public void ManualUpdate() { }

	private void OnBotAdd(BotOwner bot) { }

	private void OnGetHit(BotOwner zombieCaller, DamageInfo damageInfo, EBodyPart bodyPart, float arg3) { }

	private void OnSeeEnemy(BotOwner zombieCaller, IPlayer target) { }

	private void OnStop(BotHalloweenEventPursuit obj) { }

	public bool ShallUseInfectedLookCoeff(BotOwner owner) { }

	public void SpawnAction() { }

	private void StartPursuit(BotOwner zombieCaller, IPlayer target) { }

	private void StopPartisan() { }

	private void SubscribeOnZombie(BotOwner bot) { }

}

