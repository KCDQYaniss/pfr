//Type is in global namespace

[ExecuteInEditMode]
public sealed class LocationScene : MonoBehaviour, IPreProcessHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__48_0; //Field offset: 0x8
		public static Func <>9__48_1; //Field offset: 0x10
		public static Func <>9__48_2; //Field offset: 0x18
		public static Func <>9__48_3; //Field offset: 0x20
		public static Func <>9__52_0; //Field offset: 0x28
		public static Func <>9__52_1; //Field offset: 0x30
		public static Func <>9__52_2; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <Awake>b__48_0(GameObject te) { }

		internal IEnumerable <Awake>b__48_1(GameObject te) { }

		internal bool <Awake>b__48_2(ITriggerEntity te) { }

		internal IEnumerable <Awake>b__48_3(MonoBehaviour cc) { }

		internal bool <FillArraysFrom>b__52_0(ITriggerEntity te) { }

		internal GameObject <FillArraysFrom>b__52_1(ITriggerEntity te) { }

		internal MonoBehaviour <FillArraysFrom>b__52_2(IEventSoundContentChanger cc) { }

	}

	[CompilerGenerated]
	private sealed class <>c__44`1
	{
		public static readonly <>c__44 <>9; //Field offset: 0x0
		public static Func <>9__44_0; //Field offset: 0x0

		private static <>c__44`1() { }

		public <>c__44`1() { }

		internal IEnumerable <GetAll>b__44_0(LocationScene scene) { }

	}

	[CompilerGenerated]
	private sealed class <>c__46`1
	{
		public static readonly <>c__46 <>9; //Field offset: 0x0
		public static Func <>9__46_0; //Field offset: 0x0

		private static <>c__46`1() { }

		public <>c__46`1() { }

		internal IEnumerable <GetAllObjectsNoBehaviour>b__46_0(LocationScene scene) { }

	}

	[CompilerGenerated]
	private sealed class <>c__47`1
	{
		public static readonly <>c__47 <>9; //Field offset: 0x0
		public static Func <>9__47_0; //Field offset: 0x0

		private static <>c__47`1() { }

		public <>c__47`1() { }

		internal IEnumerable <GetAllObjectsAndWhenISayAllIActuallyMeanIt>b__47_0(LocationScene x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0`1
	{
		public bool withDisabled; //Field offset: 0x0
		public Func <>9__1; //Field offset: 0x0

		public <>c__DisplayClass45_0`1() { }

		internal IEnumerable <GetAllObjects>b__0(LocationScene scene) { }

		internal bool <GetAllObjects>b__1(T obj) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass52_0
	{
		public Scene scene; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Scene scene; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal bool <FillTreeWinds>b__0(TreeWind x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0`1
	{
		public bool includeInactive; //Field offset: 0x0

		public <>c__DisplayClass55_0`1() { }

		internal IEnumerable <FindAllObjectsOnScene>b__0(GameObject x) { }

	}

	public static readonly List LoadedScenes; //Field offset: 0x0
	public static readonly List DoorsCollisionColliders; //Field offset: 0x8
	public StaticLoot[] StaticLoot; //Field offset: 0x20
	public LootableContainer[] LootableContainers; //Field offset: 0x28
	public WorldInteractiveObject[] WorldInteractiveObjects; //Field offset: 0x30
	public ISyncAble[] SyncAbles; //Field offset: 0x38
	public ControlledLampGroup[] ControlledLampGroups; //Field offset: 0x40
	public GameObject[] TriggerEntities; //Field offset: 0x48
	public NavMeshDoorLink[] NavMeshLinks; //Field offset: 0x50
	public SpawnPointMarker[] SpawnPointMarkers; //Field offset: 0x58
	public BotZone[] BotZones; //Field offset: 0x60
	public ExfiltrationPoint[] ExfiltrationPoints; //Field offset: 0x68
	public AIPlaceInfo[] AIPlaceInfos; //Field offset: 0x70
	public StationaryWeapon[] StationaryWeapons; //Field offset: 0x78
	public MovingPlatform[] MovingPlatforms; //Field offset: 0x80
	public BorderZone[] BorderZones; //Field offset: 0x88
	public BaseRestrictableZone[] RestrictableZones; //Field offset: 0x90
	public LampController[] Lamps; //Field offset: 0x98
	public WindowBreaker[] Windows; //Field offset: 0xA0
	public SynchronizableObject[] SynchronizableObjects; //Field offset: 0xA8
	public AirdropPoint[] AirdropPoints; //Field offset: 0xB0
	public BufferZoneContainer[] BufferZoneContainers; //Field offset: 0xB8
	public TransitPoint[] TransitPoints; //Field offset: 0xC0
	public LocationOrigin[] LocationOrigins; //Field offset: 0xC8
	public EventObject[] EventObjects; //Field offset: 0xD0
	public FlameDamageTrigger[] FlameDamages; //Field offset: 0xD8
	public EventEnvironment[] EventEnvironments; //Field offset: 0xE0
	public SeasonEnvironment[] SeasonEnvironments; //Field offset: 0xE8
	public QuestLocationObject[] QuestObjects; //Field offset: 0xF0
	public PasscodeTerminal[] PasscodeTerminals; //Field offset: 0xF8
	public HintGroup[] HintGroups; //Field offset: 0x100
	public CutsceneObjects[] CutsceneObjects; //Field offset: 0x108
	public HideoutController[] AreasControllers; //Field offset: 0x110
	public AudioSource[] AudioSources; //Field offset: 0x118
	public ClientBroadcastPlayer[] BroadcastPlayers; //Field offset: 0x120
	public MonoBehaviour[] EventSoundContentChangers; //Field offset: 0x128
	public RaidDialogEntryPoint[] RaidDialogEntryPoints; //Field offset: 0x130
	[HideInInspector]
	public TreeWind[] treeWinds; //Field offset: 0x138
	[HideInInspector]
	public Settings[] treeWindSettingsPresets; //Field offset: 0x140
	private readonly Dictionary _typeToContainer; //Field offset: 0x148

	private int CachedTreeWinds
	{
		private get { } //Length: 29
	}

	private static LocationScene() { }

	public LocationScene() { }

	[CompilerGenerated]
	internal static T[] <FillArraysFrom>g__FindObjects|52_3(bool includeInactive = true, ref <>c__DisplayClass52_0 unnamed_param_1) { }

	private void Awake() { }

	private void CheckOnNull(Type type, Behaviour[] objects) { }

	public void FillArrays() { }

	public void FillArraysFrom(Scene scene) { }

	private void FillTreeWinds() { }

	private static T[] FindAllObjectsOnScene(ref Scene scene, bool includeInactive = true) { }

	private int get_CachedTreeWinds() { }

	public static IEnumerable GetAll() { }

	public static IEnumerable GetAllObjects(bool withDisabled = false) { }

	public static IEnumerable GetAllObjectsAndWhenISayAllIActuallyMeanIt() { }

	public static IEnumerable GetAllObjectsNoBehaviour() { }

	private T[] GetObjects() { }

	private void OnDestroy() { }

	public override void OnPreProcess() { }

	private void Register(T[] array) { }

}

