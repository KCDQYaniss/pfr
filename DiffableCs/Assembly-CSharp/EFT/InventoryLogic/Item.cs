namespace EFT.InventoryLogic;

public class Item
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__70_1; //Field offset: 0x8
		public static Func <>9__70_2; //Field offset: 0x10
		public static Func <>9__70_5; //Field offset: 0x18
		public static Func <>9__70_6; //Field offset: 0x20
		public static Func <>9__75_0; //Field offset: 0x28
		public static Func <>9__133_0; //Field offset: 0x30
		public static Func <>9__133_1; //Field offset: 0x38
		public static Func <>9__133_2; //Field offset: 0x40
		public static Func <>9__133_3; //Field offset: 0x48
		public static Func <>9__133_4; //Field offset: 0x50
		public static Func <>9__133_5; //Field offset: 0x58
		public static Func <>9__133_6; //Field offset: 0x60
		public static Func <>9__133_7; //Field offset: 0x68
		public static Func <>9__133_8; //Field offset: 0x70
		public static Func <>9__133_9; //Field offset: 0x78
		public static Func <>9__133_10; //Field offset: 0x80
		public static Func <>9__144_0; //Field offset: 0x88
		public static Func <>9__145_1; //Field offset: 0x90

		private static <>c() { }

		public <>c() { }

		internal float <.ctor>b__70_1() { }

		internal EItemAttributeDisplayType <.ctor>b__70_2() { }

		internal string <.ctor>b__70_5() { }

		internal EItemAttributeDisplayType <.ctor>b__70_6() { }

		internal bool <Compare>b__133_0(DogtagComponent comp1, DogtagComponent comp2) { }

		internal bool <Compare>b__133_1(RepairableComponent comp1, RepairableComponent comp2) { }

		internal IEnumerable <Compare>b__133_10(IContainer x) { }

		internal bool <Compare>b__133_2(MedKitComponent comp1, MedKitComponent comp2) { }

		internal bool <Compare>b__133_3(FoodDrinkComponent comp1, FoodDrinkComponent comp2) { }

		internal bool <Compare>b__133_4(KeyComponent comp1, KeyComponent comp2) { }

		internal bool <Compare>b__133_5(ResourceComponent comp1, ResourceComponent comp2) { }

		internal bool <Compare>b__133_6(SideEffectComponent comp1, SideEffectComponent comp2) { }

		internal bool <Compare>b__133_7(RepairKitComponent comp1, RepairKitComponent comp2) { }

		internal bool <Compare>b__133_8(BuffComponent comp1, BuffComponent comp2) { }

		internal IEnumerable <Compare>b__133_9(IContainer x) { }

		internal bool <GetAllVisibleItems>b__144_0(Item item, IContainer container) { }

		internal bool <IsArmorMod>b__75_0(EBodyPartColliderType collider) { }

		internal IEnumerable <TraverseTree>b__145_1(IContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass141_0`2
	{
		public string postfix; //Field offset: 0x0
		public EItemAttributeDisplayType displayType; //Field offset: 0x0
		public EItemAttributeLabelVariations variation; //Field offset: 0x0
		public Func <>9__3; //Field offset: 0x0

		public <>c__DisplayClass141_0`2() { }

		internal ItemAttribute <CreateAttributesFromDictionary>b__0(KeyValuePair spec) { }

		internal EItemAttributeDisplayType <CreateAttributesFromDictionary>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass141_1`2
	{
		public KeyValuePair spec; //Field offset: 0x0
		public <>c__DisplayClass141_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass141_1`2() { }

		internal float <CreateAttributesFromDictionary>b__1() { }

		internal string <CreateAttributesFromDictionary>b__2() { }

		internal string <CreateAttributesFromDictionary>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass143_0
	{
		public ItemAttribute itemAttribute; //Field offset: 0x10

		public <>c__DisplayClass143_0() { }

		internal bool <AddOrReplaceAttribute>b__0(ItemAttribute attr) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass145_0
	{
		public Func weHaveToGoDeeper; //Field offset: 0x10
		public Item item; //Field offset: 0x18
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass145_0() { }

		internal bool <TraverseTree>b__0(IContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass147_0`1
	{
		public EItemAttributeDisplayType displayType; //Field offset: 0x0
		public Func <>9__0; //Field offset: 0x0

		public <>c__DisplayClass147_0`1() { }

		internal EItemAttributeDisplayType <CreateAttributesFromDictionary>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass147_1`1
	{
		public DamageEffectSpecification spec; //Field offset: 0x0

		public <>c__DisplayClass147_1`1() { }

		internal string <CreateAttributesFromDictionary>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass147_2`1
	{
		public string replacement; //Field offset: 0x0
		public <>c__DisplayClass147_1 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass147_2`1() { }

		internal string <CreateAttributesFromDictionary>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__140 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public Item <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28

		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <get_ItemInteractionButtons>d__140(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.EItemInfoButton>.GetEnumerator() { }

		[DebuggerHidden]
		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class ItemComparer : IEqualityComparer
	{

		public ItemComparer() { }

		public override bool Equals(Item x, Item y) { }

		public override int GetHashCode(Item obj) { }

	}

	[CompilerGenerated]
	private static readonly IEqualityComparer <ItemNoHashComparer>k__BackingField; //Field offset: 0x0
	private static readonly IEnumerable _itemInteractions; //Field offset: 0x8
	private static readonly Dictionary _replacements; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Nullable <DiscardLimit>k__BackingField; //Field offset: 0x10
	public bool UnlimitedCount; //Field offset: 0x18
	public int BuyRestrictionMax; //Field offset: 0x1C
	[DefaultValue(0)]
	[Diffable]
	public int BuyRestrictionCurrent; //Field offset: 0x20
	[DefaultValue(1)]
	[Diffable]
	public int StackObjectsCount; //Field offset: 0x24
	public int Version; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x30
	[CanBeNull]
	public ItemAddress OriginalAddress; //Field offset: 0x38
	protected private readonly List Components; //Field offset: 0x40
	private string _toStringCache; //Field offset: 0x48
	[CompilerGenerated]
	private ItemAddress <CurrentAddress>k__BackingField; //Field offset: 0x50
	public readonly BindableEvent ChildrenChanged; //Field offset: 0x58
	[CompilerGenerated]
	private readonly ItemTemplate <Template>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <SpawnedInSession>k__BackingField; //Field offset: 0x68
	[DefaultValue(EItemPinLockState::Free (0))]
	[Diffable]
	public EItemPinLockState PinLockState; //Field offset: 0x6C
	public List Attributes; //Field offset: 0x70

	public TaxonomyColor BackgroundColor
	{
		 get { } //Length: 41
	}

	public override bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public bool CanBeRagfairForbidden
	{
		 get { } //Length: 152
	}

	public bool CanRequireOnRagfair
	{
		 get { } //Length: 45
	}

	public override bool CanSellOnRagfair
	{
		 get { } //Length: 45
	}

	public bool CanSellOnRagfairRaidRelated
	{
		 get { } //Length: 20
	}

	public MongoID[] ConflictingItems
	{
		 get { } //Length: 45
	}

	[CanBeNull]
	public ItemAddress CurrentAddress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Description
	{
		 get { } //Length: 261
	}

	public override Nullable DiscardLimit
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ExaminedByDefault
	{
		 get { } //Length: 80
	}

	public int ExamineExperience
	{
		 get { } //Length: 44
	}

	public float ExamineTime
	{
		 get { } //Length: 43
	}

	public override int Height
	{
		 get { } //Length: 41
	}

	public bool HideEntrails
	{
		 get { } //Length: 45
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public override bool ImportantForCheckSpawnedInSession
	{
		 get { } //Length: 3
	}

	public override bool IsContainer
	{
		 get { } //Length: 3
	}

	public bool IsEmptyStack
	{
		 get { } //Length: 8
	}

	public bool IsSecretExitRequirement
	{
		 get { } //Length: 45
	}

	public bool IsSpecialSlotOnly
	{
		 get { } //Length: 45
	}

	public bool IsUnremovable
	{
		 get { } //Length: 45
	}

	public override IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__140))]
		 get { } //Length: 175
	}

	private static IEqualityComparer ItemNoHashComparer
	{
		[CompilerGenerated]
		private get { } //Length: 83
	}

	public string ItemSound
	{
		 get { } //Length: 42
	}

	public bool LeftHandItem
	{
		 get { } //Length: 45
	}

	public bool LimitedDiscard
	{
		 get { } //Length: 138
	}

	public int LootExperience
	{
		 get { } //Length: 44
	}

	public override bool MarkedAsSpawnedInSession
	{
		 get { } //Length: 20
	}

	public override bool MergesWithChildren
	{
		 get { } //Length: 45
	}

	public string Name
	{
		 get { } //Length: 47
	}

	public bool NotShownInSlot
	{
		 get { } //Length: 45
	}

	public IItemOwner Owner
	{
		 get { } //Length: 154
	}

	public ItemAddress Parent
	{
		 get { } //Length: 150
	}

	public override ResourceKey Prefab
	{
		 get { } //Length: 42
	}

	public override bool QuestItem
	{
		 get { } //Length: 42
	}

	public override int RagfairLevelToTrade
	{
		 get { } //Length: 44
	}

	public int RepairCost
	{
		 get { } //Length: 44
	}

	public int RepairSpeed
	{
		 get { } //Length: 44
	}

	public string ShortName
	{
		 get { } //Length: 47
	}

	public bool ShownInSlot
	{
		 get { } //Length: 48
	}

	[DefaultValue(False)]
	[Diffable]
	public override bool SpawnedInSession
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int StackMaxSize
	{
		 get { } //Length: 41
	}

	public string StringTemplateId
	{
		 get { } //Length: 233
	}

	public override ItemTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MongoID TemplateId
	{
		 get { } //Length: 76
	}

	public override float TotalWeight
	{
		 get { } //Length: 79
	}

	public override bool Undiscardable
	{
		 get { } //Length: 3
	}

	public ResourceKey UsePrefab
	{
		 get { } //Length: 42
	}

	protected override float Weight
	{
		 get { } //Length: 43
	}

	public override int Width
	{
		 get { } //Length: 41
	}

	private static Item() { }

	public Item(string id, ItemTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__70_3() { }

	[CompilerGenerated]
	private string <.ctor>b__70_4() { }

	[CompilerGenerated]
	private string <.ctor>g__SizeStringGetter|70_0() { }

	public void AddOrReplaceAttribute(ItemAttribute itemAttribute, bool ignoreZero = false) { }

	public override IntVec2 CalculateCellSize() { }

	public IntVec2 CalculateRotatedSize(ItemRotation rotation) { }

	public Option CheckAction(ItemAddress location) { }

	public override bool Compare(Item item) { }

	private bool ComponentsEqual(Item item, Func comparator) { }

	public void CreateAttributesFromDictionary(Dictionary specifications, EItemAttributeDisplayType displayType, EItemAttributeLabelVariations variation, string postfix = "") { }

	public void CreateAttributesFromDictionary(Dictionary specifications, EItemAttributeDisplayType displayType) { }

	public TaxonomyColor get_BackgroundColor() { }

	public override bool get_CanBePickedUp() { }

	public bool get_CanBeRagfairForbidden() { }

	public bool get_CanRequireOnRagfair() { }

	public override bool get_CanSellOnRagfair() { }

	public bool get_CanSellOnRagfairRaidRelated() { }

	public MongoID[] get_ConflictingItems() { }

	[CompilerGenerated]
	public ItemAddress get_CurrentAddress() { }

	public string get_Description() { }

	[CompilerGenerated]
	public override Nullable get_DiscardLimit() { }

	public bool get_ExaminedByDefault() { }

	public int get_ExamineExperience() { }

	public float get_ExamineTime() { }

	public override int get_Height() { }

	public bool get_HideEntrails() { }

	[CompilerGenerated]
	public string get_Id() { }

	public override bool get_ImportantForCheckSpawnedInSession() { }

	public override bool get_IsContainer() { }

	public bool get_IsEmptyStack() { }

	public bool get_IsSecretExitRequirement() { }

	public bool get_IsSpecialSlotOnly() { }

	public bool get_IsUnremovable() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__140))]
	public override IEnumerable get_ItemInteractionButtons() { }

	[CompilerGenerated]
	private static IEqualityComparer get_ItemNoHashComparer() { }

	public string get_ItemSound() { }

	public bool get_LeftHandItem() { }

	public bool get_LimitedDiscard() { }

	public int get_LootExperience() { }

	public override bool get_MarkedAsSpawnedInSession() { }

	public override bool get_MergesWithChildren() { }

	public string get_Name() { }

	public bool get_NotShownInSlot() { }

	public IItemOwner get_Owner() { }

	public ItemAddress get_Parent() { }

	public override ResourceKey get_Prefab() { }

	public override bool get_QuestItem() { }

	public override int get_RagfairLevelToTrade() { }

	public int get_RepairCost() { }

	public int get_RepairSpeed() { }

	public string get_ShortName() { }

	public bool get_ShownInSlot() { }

	[CompilerGenerated]
	public override bool get_SpawnedInSession() { }

	public int get_StackMaxSize() { }

	public string get_StringTemplateId() { }

	[CompilerGenerated]
	public override ItemTemplate get_Template() { }

	public MongoID get_TemplateId() { }

	public override float get_TotalWeight() { }

	public override bool get_Undiscardable() { }

	public ResourceKey get_UsePrefab() { }

	protected override float get_Weight() { }

	public override int get_Width() { }

	public IEnumerable GetAllVisibleItems() { }

	[CanBeNull]
	public override Magazine GetCurrentMagazine() { }

	public override int GetHashSum() { }

	public override ItemInfo GetInfo() { }

	[CanBeNull]
	public T GetItemComponent() { }

	public IEnumerable GetPathOfContainers() { }

	private string GetSizeAttribute(int down, int up, int left, int right) { }

	protected T GetTemplate() { }

	public bool IsArmorMod() { }

	public bool IsSameItem(Item other) { }

	public void RaiseRefreshEvent(bool refreshIcon = false, bool checkMagazine = true) { }

	public void SafelyAddAttributeToList(ItemAttribute itemAttribute) { }

	[CompilerGenerated]
	public void set_CurrentAddress(ItemAddress value) { }

	[CompilerGenerated]
	public override void set_SpawnedInSession(bool value) { }

	public string ToFullString() { }

	public virtual string ToString() { }

	private static void TraverseTree(Item item, ICollection list, Func weHaveToGoDeeper) { }

	public bool TryGetItemComponent(out T component) { }

	public void UpdateAttributes() { }

}

