//Type is in global namespace

public sealed class LocalDebugProfileDataParams : IGetProfileData
{
	private readonly DebugBotProfileChooser _profileChooser; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <KeepZoneOnSpawn>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private BotSpawnParams <SpawnParams>k__BackingField; //Field offset: 0x18

	public override bool KeepZoneOnSpawn
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Nullable Side
	{
		 get { } //Length: 3
	}

	public override BotSpawnParams SpawnParams
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public LocalDebugProfileDataParams(DebugBotProfileChooser profileChooser) { }

	public override bool CanAtZoneByType(BotZone botZone, BotZonesLeaveController botsControllerZonesLeaveController) { }

	public bool CanSpawnByHour(int timeHour) { }

	public override Profile ChooseProfile(List profiles2Select, bool withDelete) { }

	[CompilerGenerated]
	public override bool get_KeepZoneOnSpawn() { }

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

