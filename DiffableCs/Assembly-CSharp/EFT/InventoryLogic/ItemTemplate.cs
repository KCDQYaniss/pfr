namespace EFT.InventoryLogic;

public class ItemTemplate : IUnlootableComponentTemplate, IAnimationVariantsComponentTemplate, IItemTemplate
{
	[CompilerGenerated]
	private sealed class <get_AllResources>d__54 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ResourceKey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ItemTemplate <>4__this; //Field offset: 0x28

		private override ResourceKey System.Collections.Generic.IEnumerator<EFT.ResourceKey>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_AllResources>d__54(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.ResourceKey>.GetEnumerator() { }

		[DebuggerHidden]
		private override ResourceKey System.Collections.Generic.IEnumerator<EFT.ResourceKey>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class TemplateSerializer : PolymorphicSerializer
	{
		private const bool IGNORE_ERRORS = False; //Field offset: 0x0
		public string _id; //Field offset: 0x20
		public string _name; //Field offset: 0x28
		public NodeType _type; //Field offset: 0x30
		public FlatItem[] _items; //Field offset: 0x38

		public TemplateSerializer() { }

		public virtual ItemTemplate Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer) { }

		protected virtual Type KeyToType(string serializedType) { }

		private static Type TryGetTemplateType(string typeId, string serializedType, string itemName, string description) { }

		protected virtual string TypeToKey(Type serializedType) { }

	}

	public string Name; //Field offset: 0x10
	public string ShortName; //Field offset: 0x18
	public string Description; //Field offset: 0x20
	public float Weight; //Field offset: 0x28
	public bool ExaminedByDefault; //Field offset: 0x2C
	public float ExamineTime; //Field offset: 0x30
	public bool QuestItem; //Field offset: 0x34
	public TaxonomyColor BackgroundColor; //Field offset: 0x38
	public int Width; //Field offset: 0x3C
	public int Height; //Field offset: 0x40
	public int ExtraSizeLeft; //Field offset: 0x44
	public int ExtraSizeRight; //Field offset: 0x48
	public int ExtraSizeUp; //Field offset: 0x4C
	public int ExtraSizeDown; //Field offset: 0x50
	public bool ExtraSizeForceAdd; //Field offset: 0x54
	public int StackMaxSize; //Field offset: 0x58
	public int StackObjectsCount; //Field offset: 0x5C
	public int CreditsPrice; //Field offset: 0x60
	public string ItemSound; //Field offset: 0x68
	public ResourceKey Prefab; //Field offset: 0x70
	public ResourceKey UsePrefab; //Field offset: 0x78
	public ELootRarity Rarity; //Field offset: 0x80
	public float SpawnChance; //Field offset: 0x84
	public bool NotShownInSlot; //Field offset: 0x88
	public int LootExperience; //Field offset: 0x8C
	public bool HideEntrails; //Field offset: 0x90
	public int ExamineExperience; //Field offset: 0x94
	public int RepairCost; //Field offset: 0x98
	public int RepairSpeed; //Field offset: 0x9C
	public bool MergesWithChildren; //Field offset: 0xA0
	public bool CanSellOnRagfair; //Field offset: 0xA1
	public int RagfairLevelToTrade; //Field offset: 0xA4
	public bool CanRequireOnRagfair; //Field offset: 0xA8
	public MongoID[] ConflictingItems; //Field offset: 0xB0
	public int AnimationVariantsNumber; //Field offset: 0xB8
	public float RagFairCommissionModifier; //Field offset: 0xBC
	public bool IsAlwaysAvailableForInsurance; //Field offset: 0xC0
	public bool InsuranceDisabled; //Field offset: 0xC1
	[CompilerGenerated]
	private int <DiscardLimit>k__BackingField; //Field offset: 0xC4
	public bool Unlootable; //Field offset: 0xC8
	public bool IsUnremovable; //Field offset: 0xC9
	public bool IsSpecialSlotOnly; //Field offset: 0xCA
	public bool IsSecretExitRequirement; //Field offset: 0xCB
	public bool LeftHandItem; //Field offset: 0xCC
	public string UnlootableFromSlot; //Field offset: 0xD0
	public EPlayerSideMask UnlootableFromSide; //Field offset: 0xD8
	[CompilerGenerated]
	private MongoID <_id>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private string <_name>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Nullable <ParentId>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private NodeType <_type>k__BackingField; //Field offset: 0x120
	protected List ReadonlyComponents; //Field offset: 0x128
	private List _children; //Field offset: 0x130
	[JsonIgnore]
	private IReadOnlyList _compatibleItems; //Field offset: 0x138
	[CompilerGenerated]
	private ItemTemplate <Parent>k__BackingField; //Field offset: 0x140

	public MongoID _id
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public string _name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public NodeType _type
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override IEnumerable AllResources
	{
		[IteratorStateMachine(typeof(<get_AllResources>d__54))]
		 get { } //Length: 175
	}

	[JsonIgnore]
	public IReadOnlyList Children
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public IReadOnlyList CompatibleItems
	{
		 get { } //Length: 898
	}

	public string DescriptionLocalizationKey
	{
		 get { } //Length: 228
	}

	public override int DiscardLimit
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private override int EFT.InventoryLogic.IAnimationVariantsComponentTemplate.AnimationVariantsNumber
	{
		private get { } //Length: 7
	}

	private override EPlayerSideMask EFT.InventoryLogic.IUnlootableComponentTemplate.Side
	{
		private get { } //Length: 7
	}

	private override string EFT.InventoryLogic.IUnlootableComponentTemplate.SlotName
	{
		private get { } //Length: 8
	}

	public ExtraSize ExtraSize
	{
		 get { } //Length: 148
	}

	public string NameLocalizationKey
	{
		 get { } //Length: 228
	}

	[JsonIgnore]
	public ItemTemplate Parent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonProperty("_parent")]
	public Nullable ParentId
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public string ShortNameLocalizationKey
	{
		 get { } //Length: 228
	}

	public string StringId
	{
		 get { } //Length: 143
	}

	public ItemTemplate(MongoID id) { }

	[JsonConstructor]
	public ItemTemplate() { }

	public void AddChild(ItemTemplate template) { }

	protected override List CreateReadonlyComponentsCollection() { }

	private override int EFT.InventoryLogic.IAnimationVariantsComponentTemplate.get_AnimationVariantsNumber() { }

	private override EPlayerSideMask EFT.InventoryLogic.IUnlootableComponentTemplate.get_Side() { }

	private override string EFT.InventoryLogic.IUnlootableComponentTemplate.get_SlotName() { }

	[CompilerGenerated]
	public MongoID get__id() { }

	[CompilerGenerated]
	public string get__name() { }

	[CompilerGenerated]
	public NodeType get__type() { }

	[IteratorStateMachine(typeof(<get_AllResources>d__54))]
	public override IEnumerable get_AllResources() { }

	public IReadOnlyList get_Children() { }

	public IReadOnlyList get_CompatibleItems() { }

	public string get_DescriptionLocalizationKey() { }

	[CompilerGenerated]
	public override int get_DiscardLimit() { }

	public ExtraSize get_ExtraSize() { }

	public string get_NameLocalizationKey() { }

	[CompilerGenerated]
	public ItemTemplate get_Parent() { }

	[CompilerGenerated]
	public Nullable get_ParentId() { }

	public string get_ShortNameLocalizationKey() { }

	public string get_StringId() { }

	[NotNull]
	public List GetReadonlyComponents() { }

	public bool IsChildOf(MongoID parentTemplateId) { }

	public override void OnInit() { }

	[CompilerGenerated]
	protected void set__id(MongoID value) { }

	[CompilerGenerated]
	protected void set__name(string value) { }

	[CompilerGenerated]
	protected void set__type(NodeType value) { }

	[CompilerGenerated]
	public override void set_DiscardLimit(int value) { }

	[CompilerGenerated]
	public void set_Parent(ItemTemplate value) { }

	[CompilerGenerated]
	protected void set_ParentId(Nullable value) { }

}

