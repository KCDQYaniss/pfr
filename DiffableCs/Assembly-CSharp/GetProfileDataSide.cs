//Type is in global namespace

public sealed class GetProfileDataSide : IGetProfileData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetDebugLocalName>b__17_0(DebugBotProfileChooser item) { }

	}

	[CompilerGenerated]
	private readonly Nullable <Side>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <KeepZoneOnSpawn>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private BotSpawnParams <SpawnParams>k__BackingField; //Field offset: 0x20

	public override bool KeepZoneOnSpawn
	{
		[CompilerGenerated]
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
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public GetProfileDataSide(EPlayerSide side) { }

	[CompilerGenerated]
	private bool <ChooseProfile>b__5_0(Profile x) { }

	public override bool CanAtZoneByType(BotZone botZone, BotZonesLeaveController botsControllerZonesLeaveController) { }

	public bool CanSpawnByHour(int timeHour) { }

	public override Profile ChooseProfile(List profiles2Select, bool withDelete) { }

	[CompilerGenerated]
	public override bool get_KeepZoneOnSpawn() { }

	[CompilerGenerated]
	public override Nullable get_Side() { }

	[CompilerGenerated]
	public override BotSpawnParams get_SpawnParams() { }

	public override string GetDebugData() { }

	public override string GetDebugLocalName() { }

	public override bool IsBossOrFollower() { }

	public override bool IsBossOrFollowerByTime() { }

	public override bool IsSpawnOnStart() { }

	public override bool IsValidSpawnType(WildSpawnType wildSpawnType) { }

	public override bool IsZeroWave() { }

	public override CountTypeBotWave[] PrepareToLoadBackend(int count) { }

	[CompilerGenerated]
	public override void set_SpawnParams(BotSpawnParams value) { }

	public override bool ShallChooseByData() { }

	public override bool TryGetRole(out WildSpawnType role, out BotDifficulty difficulty) { }

}

