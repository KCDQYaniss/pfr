namespace EFT.Interactive;

[ExecuteInEditMode]
public class Location : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__49_0; //Field offset: 0x8
		public static Func <>9__49_1; //Field offset: 0x10
		public static Func <>9__49_2; //Field offset: 0x18
		public static Func <>9__49_3; //Field offset: 0x20
		public static Func <>9__49_4; //Field offset: 0x28
		public static Func <>9__49_5; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <CollectLootPointsData>b__49_0(LootPoint point) { }

		internal bool <CollectLootPointsData>b__49_1(LootPoint point) { }

		internal bool <CollectLootPointsData>b__49_2(LootableContainer x) { }

		internal bool <CollectLootPointsData>b__49_3(LootableContainer x) { }

		internal bool <CollectLootPointsData>b__49_4(TriggerWithId x) { }

		internal int <CollectLootPointsData>b__49_5(TriggerWithId x) { }

	}

	public string SceneId; //Field offset: 0x20
	[CompilerGenerated]
	private LootPoint[] <ValidLootPoints>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private LootPoint[] <EmptyLootPoints>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private LootPoint[] <DisabledLootPoints>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private LootPoint[] <LootPoints>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private LootableContainer[] <ValidLootableContainers>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private LootableContainer[] <EmptyLootableContainers>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private LootableContainer[] <DisabledLootableContainers>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private LootableContainer[] <LootableContainers>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private SpawnPointMarker[] <SpawnPointMarkers>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private StationaryWeapon[] <Stationary>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private DailyZoneData[] <DailyQuestZones>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private LootableContainersGroup[] <LootableContainersGroups>k__BackingField; //Field offset: 0x80

	public private DailyZoneData[] DailyQuestZones
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootableContainer[] DisabledLootableContainers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootPoint[] DisabledLootPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootableContainer[] EmptyLootableContainers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootPoint[] EmptyLootPoints
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootableContainer[] LootableContainers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootableContainersGroup[] LootableContainersGroups
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootPoint[] LootPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private SpawnPointMarker[] SpawnPointMarkers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private StationaryWeapon[] Stationary
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootableContainer[] ValidLootableContainers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LootPoint[] ValidLootPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Location() { }

	[CompilerGenerated]
	private DailyZoneData <CollectLootPointsData>b__49_6(TriggerWithId x) { }

	public void CollectLootPointsData() { }

	[CompilerGenerated]
	public DailyZoneData[] get_DailyQuestZones() { }

	[CompilerGenerated]
	public LootableContainer[] get_DisabledLootableContainers() { }

	[CompilerGenerated]
	public LootPoint[] get_DisabledLootPoints() { }

	[CompilerGenerated]
	public LootableContainer[] get_EmptyLootableContainers() { }

	[CompilerGenerated]
	public LootPoint[] get_EmptyLootPoints() { }

	[CompilerGenerated]
	public LootableContainer[] get_LootableContainers() { }

	[CompilerGenerated]
	public LootableContainersGroup[] get_LootableContainersGroups() { }

	[CompilerGenerated]
	public LootPoint[] get_LootPoints() { }

	[CompilerGenerated]
	public SpawnPointMarker[] get_SpawnPointMarkers() { }

	[CompilerGenerated]
	public StationaryWeapon[] get_Stationary() { }

	[CompilerGenerated]
	public LootableContainer[] get_ValidLootableContainers() { }

	[CompilerGenerated]
	public LootPoint[] get_ValidLootPoints() { }

	[CompilerGenerated]
	private void set_DailyQuestZones(DailyZoneData[] value) { }

	[CompilerGenerated]
	private void set_DisabledLootableContainers(LootableContainer[] value) { }

	[CompilerGenerated]
	private void set_DisabledLootPoints(LootPoint[] value) { }

	[CompilerGenerated]
	private void set_EmptyLootableContainers(LootableContainer[] value) { }

	[CompilerGenerated]
	private void set_EmptyLootPoints(LootPoint[] value) { }

	[CompilerGenerated]
	private void set_LootableContainers(LootableContainer[] value) { }

	[CompilerGenerated]
	private void set_LootableContainersGroups(LootableContainersGroup[] value) { }

	[CompilerGenerated]
	private void set_LootPoints(LootPoint[] value) { }

	[CompilerGenerated]
	private void set_SpawnPointMarkers(SpawnPointMarker[] value) { }

	[CompilerGenerated]
	private void set_Stationary(StationaryWeapon[] value) { }

	[CompilerGenerated]
	private void set_ValidLootableContainers(LootableContainer[] value) { }

	[CompilerGenerated]
	private void set_ValidLootPoints(LootPoint[] value) { }

}

