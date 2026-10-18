namespace EFT.Interactive;

public sealed class LootPointService : SelfInitializedSingleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__34_0; //Field offset: 0x8
		public static Func <>9__34_1; //Field offset: 0x10
		public static Func <>9__34_2; //Field offset: 0x18
		public static Func <>9__35_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal MongoID <InitItemNodesTree>b__34_0(KeyValuePair x) { }

		internal LootPointNode <InitItemNodesTree>b__34_1(KeyValuePair x) { }

		internal bool <InitItemNodesTree>b__34_2(KeyValuePair x) { }

		internal MongoID <InitPresetNodesTree>b__35_0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public Dictionary nodes; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal LootPointNode <InitItemNodesTree>b__3(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public MongoID id; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <InitPresetNodesTree>b__1(KeyValuePair x) { }

	}

	private const int DEFAULT_RETRIES_COUNT = 1; //Field offset: 0x0
	private const string LOOT_POINT_TEXTURE_NAME = "loot_point_icon"; //Field offset: 0x0
	private const string LOOT_POINT_TEXTURE_PATH = ""; //Field offset: 0x0
	private bool _initializing; //Field offset: 0x10
	private EditorItemService _itemService; //Field offset: 0x18
	private int _retriesCount; //Field offset: 0x20
	[CompilerGenerated]
	private List <LootSets>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Dictionary <LootSetsPerId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Texture <LootPointTexture>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private List <ItemTemplatesTree>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private List <ItemPresetsTree>k__BackingField; //Field offset: 0x50

	public private bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private List ItemPresetsTree
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private List ItemTemplatesTree
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Texture LootPointTexture
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private List LootSets
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Dictionary LootSetsPerId
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public LootPointService() { }

	private static void ClearProgress() { }

	private static void DisplayProgress(string header, string message, float progress) { }

	[CompilerGenerated]
	public bool get_Initialized() { }

	[CompilerGenerated]
	public List get_ItemPresetsTree() { }

	[CompilerGenerated]
	public List get_ItemTemplatesTree() { }

	[CompilerGenerated]
	public Texture get_LootPointTexture() { }

	[CompilerGenerated]
	public List get_LootSets() { }

	[CompilerGenerated]
	public Dictionary get_LootSetsPerId() { }

	public void Init(bool forceInitialize) { }

	private void InitItemNodesTree() { }

	private void InitPresetNodesTree() { }

	private void LoadLootSets() { }

	[CompilerGenerated]
	private void set_Initialized(bool value) { }

	[CompilerGenerated]
	private void set_ItemPresetsTree(List value) { }

	[CompilerGenerated]
	private void set_ItemTemplatesTree(List value) { }

	[CompilerGenerated]
	private void set_LootPointTexture(Texture value) { }

	[CompilerGenerated]
	private void set_LootSets(List value) { }

}

