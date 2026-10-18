//Type is in global namespace

public class BotZonesLeaveController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__35_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ClearForPlaces>b__35_0(BotOwner x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public BotZonesLeaveController <>4__this; //Field offset: 0x10
		public WildSpawnType type; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal void <BlockAndClear>b__0() { }

	}

	private const float DAY_ENDS_HOUR = 23; //Field offset: 0x0
	private readonly float MIN_START_DAY_HOUR; //Field offset: 0x10
	private readonly float MAX_START_DAY_HOUR; //Field offset: 0x14
	private readonly BotsList _botsList; //Field offset: 0x18
	private readonly float CHECK_TIME_PERIOD_SEC; //Field offset: 0x20
	private float BLOCK_NIGHT_PERIOD_SEC; //Field offset: 0x24
	private readonly int _startDayHour; //Field offset: 0x28
	private readonly int _startDayMin; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <NoZoneBlocks>k__BackingField; //Field offset: 0x30
	private readonly Dictionary _blockedTypes; //Field offset: 0x38
	private readonly GameDateTime _gameTime; //Field offset: 0x40
	private DateTime _prevTime; //Field offset: 0x48
	private readonly IPlayersCollection _players; //Field offset: 0x50
	private bool _prevIsDay; //Field offset: 0x58
	private readonly bool _haveSectants; //Field offset: 0x59
	private int _maxCount; //Field offset: 0x5C

	public bool NoZoneBlocks
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BotZonesLeaveController(BotsList botsList, GameDateTime gameTime, BotZone[] allZones, bool haveSectants, int maxBots, IPlayersCollection players) { }

	public void Activate() { }

	private void BlockAllFor(WildSpawnType typeToBlock) { }

	public void BlockAllZonesSimpleTypes() { }

	private void BlockAndClear(WildSpawnType type, float blockPeriodSec = -1) { }

	public void BlockZoneFor(BotZone botZone, WildSpawnType spawnType) { }

	public void BotSpawned(BotOwner bot) { }

	public void ClearByTypeAll(WildSpawnType wildSpawnType) { }

	public void ClearForPlaces(int waveEscortCount) { }

	public void ClearZone(BotZone zone, WildSpawnType wildSpawnType) { }

	public void ClearZoneAndBlockForSimlpe(BotZone botZone) { }

	private int ConvertToMinutes(float remain) { }

	private void DayBlocks() { }

	public void Dispose() { }

	[CompilerGenerated]
	public bool get_NoZoneBlocks() { }

	public DebugZoneInfoStruct GetDebugData() { }

	public Dictionary GetForDebug() { }

	public int GetHour() { }

	public bool IsDay() { }

	public bool IsDayByHour(DateTime dateTime) { }

	public bool IsZoneBlockFor(BotZone zone, WildSpawnType type) { }

	public void LeaveAll() { }

	private void NightBlocks() { }

	private void OnBotAdd(BotOwner obj) { }

	private void OnBotRemove(BotOwner bot) { }

	public void RunScenarionTimeChecks() { }

	[CompilerGenerated]
	public void set_NoZoneBlocks(bool value) { }

	public void SetMaxBots(int maxBots) { }

	private void TimeCheck() { }

	private void UnBlockAllZoneFor(WildSpawnType typeToBlock) { }

	public void UnBlockAllZonesAsDay() { }

	public void UnBlockZoneFor(BotZone botZone, WildSpawnType spawnType) { }

}

