//Type is in global namespace

public class BotZoneMigration : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_1; //Field offset: 0x8
		public static Func <>9__16_0; //Field offset: 0x10
		public static Func <>9__16_1; //Field offset: 0x18
		public static Func <>9__16_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <FindDebugConnectionGroupId>b__16_0(AICorePoint c) { }

		internal int <FindDebugConnectionGroupId>b__16_1(AICorePoint c) { }

		internal int <FindDebugConnectionGroupId>b__16_2(AICorePoint c) { }

		internal int <FindSpawn>b__13_1(AICorePoint c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public int connectionGroupId; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <FindSpawn>b__0(AICorePoint c) { }

		internal bool <FindSpawn>b__2(AICorePoint c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public int currentCgId; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <FindDebugConnectionGroupId>b__3(int id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public int coreId; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <TryMigrateTo>b__0(AICorePoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public int cgId; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <TryMigrateTo>b__0(AICorePoint x) { }

	}

	private const float minDistance = 100; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnMigrated; //Field offset: 0x18

	public event Action OnMigrated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotZoneMigration(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnMigrated(Action value) { }

	public void Dispose() { }

	private int FindDebugConnectionGroupId() { }

	private bool FindSpawn(int connectionGroupId, out SpawnPointMarker spawn, out BotZone zone, out AICorePoint corePoint) { }

	private BotZone FindZone(Nullable spawn) { }

	private string GetCurrentEnemies() { }

	private void MigrateInner(AICorePoint core, BotZone zone, Vector3 spawn) { }

	private bool PossibleToMigrate() { }

	public void RandomMigration() { }

	[CompilerGenerated]
	public void remove_OnMigrated(Action value) { }

	private void RemoveAllEnemies() { }

	private void StopTilt() { }

	public bool TryMigrateTo(BotZone zoneToMigrate) { }

	public bool TryMigrateTo(int cgId) { }

}

