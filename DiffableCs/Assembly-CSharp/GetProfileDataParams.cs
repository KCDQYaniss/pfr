//Type is in global namespace

public sealed class GetProfileDataParams : IGetProfileData
{
	private const float IsBossNoPlayerTime = 10; //Field offset: 0x0
	public const float LESS_TIME_SPAWN_SEC = 60; //Field offset: 0x0
	private static int _idSt; //Field offset: 0x0
	private readonly WildSpawnType Role; //Field offset: 0x10
	private readonly BotDifficulty BotDifficulty; //Field offset: 0x14
	private readonly float _spawnTime; //Field offset: 0x18
	private readonly bool _keepZoneOnSpawn; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly Nullable <Side>k__BackingField; //Field offset: 0x20
	private int _id; //Field offset: 0x28
	[CompilerGenerated]
	private BotSpawnParams <SpawnParams>k__BackingField; //Field offset: 0x30

	public override bool KeepZoneOnSpawn
	{
		 get { } //Length: 5
	}

	public override Nullable Side
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override BotSpawnParams SpawnParams
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public GetProfileDataParams(EPlayerSide side, WildSpawnType role, BotDifficulty botDifficulty, float spawnTime, BotSpawnParams spawnParams = null, bool keepZoneOnSpawn = false) { }

	[CompilerGenerated]
	private bool <ChooseProfile>b__15_0(Profile x) { }

	public override bool CanAtZoneByType(BotZone botZone, BotZonesLeaveController botsControllerZonesLeaveController) { }

	public bool CanSpawnByHour(int timeHour) { }

	public override Profile ChooseProfile(List profiles2Select, bool withDelete) { }

	public override bool get_KeepZoneOnSpawn() { }

	[CompilerGenerated]
	public override Nullable get_Side() { }

	[CompilerGenerated]
	public override BotSpawnParams get_SpawnParams() { }

	public override string GetDebugData() { }

	public override string GetDebugLocalName() { }

	public override bool IsBossOrFollower() { }

	public override bool IsBossOrFollowerByTime() { }

	private bool IsDayTime(int timeHour) { }

	public override bool IsSpawnOnStart() { }

	public override bool IsValidSpawnType(WildSpawnType wildSpawnType) { }

	public override bool IsZeroWave() { }

	public override CountTypeBotWave[] PrepareToLoadBackend(int count) { }

	public bool SameSide(EPlayerSide side) { }

	[CompilerGenerated]
	public override void set_SpawnParams(BotSpawnParams value) { }

	public override bool ShallChooseByData() { }

	public override bool TryGetRole(out WildSpawnType role, out BotDifficulty difficulty) { }

}

