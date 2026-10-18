namespace EFT.HandBook;

[DefaultMember("Item")]
public sealed class Handbook : BaseHandbook, IBasePriceSource
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__71_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ReadEncyclopedia>b__71_0(IResult _) { }

	}

	public const string HANDBOOK_FILES_FOLDER = "/files/handbook/"; //Field offset: 0x0
	public const string BUILD_CATEGORY_ID = "Builds"; //Field offset: 0x0
	public const string WISHLIST_CATEGORY_ID = "Wishlist"; //Field offset: 0x0
	public const string WEAPON_MODS_CATEGORY_ID = "5b5f71a686f77447ed5636ab"; //Field offset: 0x0
	private const string WEAPON_CATEGORY_ID = "5b5f78dc86f77409407a7f8e"; //Field offset: 0x0
	private static readonly string[] _hidedNodes; //Field offset: 0x0
	private Profile _profile; //Field offset: 0x10
	[CompilerGenerated]
	private HandbookNodes <StructuredItems>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly HandbookNode <RootNode>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private HandbookNodes <StructuredKnownItems>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private HandbookNodes <WeaponNodesWithParent>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private HandbookNodes <EncyclopediaNodes>k__BackingField; //Field offset: 0x38
	public readonly HandbookData[] Categories; //Field offset: 0x40
	public readonly HandbookData[] Items; //Field offset: 0x48
	private readonly IEftSession _session; //Field offset: 0x50
	private readonly HandbookData[] _allData; //Field offset: 0x58
	private readonly HashSet _categoryIds; //Field offset: 0x60
	private int _newNodesCount; //Field offset: 0x68
	private int _newCompletableCount; //Field offset: 0x6C
	private Dictionary _allNodes; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnNodesCountChanged; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnNewCompletableCountChanged; //Field offset: 0x80

	public event Action OnNewCompletableCountChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnNodesCountChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	protected virtual Dictionary AllNodes
	{
		 get { } //Length: 5
	}

	public IReadOnlyDictionary CompletableItems
	{
		 get { } //Length: 30
	}

	public private HandbookNodes EncyclopediaNodes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[CanBeNull]
	public HandbookNode Item
	{
		 get { } //Length: 42
	}

	public private int NewCompletableCount
	{
		 get { } //Length: 4
		private set { } //Length: 31
	}

	public private int NewNodesCount
	{
		 get { } //Length: 4
		private set { } //Length: 28
	}

	private Encyclopedia ProfileEncyclopedia
	{
		private get { } //Length: 27
	}

	private List QuestItems
	{
		private get { } //Length: 39
	}

	protected virtual HandbookNode RootNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private HandbookNodes StructuredItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HandbookNodes StructuredKnownItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HandbookNodes WeaponNodesWithParent
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static Handbook() { }

	public Handbook(HandbookData[] categories, HandbookData[] items, IEftSession session, Profile profile) { }

	[CompilerGenerated]
	public void add_OnNewCompletableCountChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnNodesCountChanged(Action value) { }

	private static void CollectNewItems(HandbookNode node, List result) { }

	private void CompletableItemCompletedHandler(MongoID templateId, bool completed) { }

	private bool ContainsCompletedCompletable(HandbookNode node) { }

	public Dictionary CreateNodesTree(bool onlyKnown = false, bool setChildCount = true) { }

	private Dictionary CreateNodeTree(IReadOnlyList data, bool onlyKnown, bool setChildCount = true) { }

	private Dictionary CreateWeaponTree() { }

	private Dictionary CreateWishlistTree() { }

	public void ExamineItem(MongoID templateId) { }

	public void Forget(string templateId) { }

	protected virtual Dictionary get_AllNodes() { }

	public IReadOnlyDictionary get_CompletableItems() { }

	[CompilerGenerated]
	public HandbookNodes get_EncyclopediaNodes() { }

	public HandbookNode get_Item(string id) { }

	public int get_NewCompletableCount() { }

	public int get_NewNodesCount() { }

	private Encyclopedia get_ProfileEncyclopedia() { }

	private List get_QuestItems() { }

	[CompilerGenerated]
	protected virtual HandbookNode get_RootNode() { }

	[CompilerGenerated]
	public HandbookNodes get_StructuredItems() { }

	[CompilerGenerated]
	public HandbookNodes get_StructuredKnownItems() { }

	[CompilerGenerated]
	public HandbookNodes get_WeaponNodesWithParent() { }

	public override double GetBasePrice(MongoID itemId) { }

	private static int GetChildCount(Dictionary childrenDict) { }

	private static Dictionary GetTreeRootNodes(Dictionary fromNodes) { }

	private void Init(Profile profile) { }

	private void InsertInParent(HandbookNode node, HandbookNode parent) { }

	public virtual bool IsCategory(string testId) { }

	private bool IsDataKnown(HandbookData data) { }

	private int ReadEncyclopedia(IReadOnlyList nodes) { }

	public void ReadEncyclopedia(HandbookNode node) { }

	public void ReadWholeEncyclopedia() { }

	[CompilerGenerated]
	public void remove_OnNewCompletableCountChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnNodesCountChanged(Action value) { }

	[CompilerGenerated]
	private void set_EncyclopediaNodes(HandbookNodes value) { }

	private void set_NewCompletableCount(int value) { }

	private void set_NewNodesCount(int value) { }

	[CompilerGenerated]
	private void set_StructuredItems(HandbookNodes value) { }

	[CompilerGenerated]
	private void set_StructuredKnownItems(HandbookNodes value) { }

	[CompilerGenerated]
	private void set_WeaponNodesWithParent(HandbookNodes value) { }

	private void UpdateCompletableCount() { }

	public void UpdateProfile(Profile profile) { }

	public void ValidateWishlistNodes() { }

}

