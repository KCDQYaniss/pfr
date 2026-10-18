namespace EFT.Hideout;

public class PermanentProducer : ItemsProducerBase, IConsumer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8
		public static Func <>9__51_0; //Field offset: 0x10
		public static Func <>9__56_0; //Field offset: 0x18
		public static Func <>9__59_0; //Field offset: 0x20
		public static Func <>9__61_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <InitAreaDataLate>b__51_0(Requirement req) { }

		internal bool <InstallSupplySlot>b__59_0(BarterItem x) { }

		internal bool <ItemResourceEndedHandler>b__56_0(BarterItem installed) { }

		internal float <PreUpdate>b__61_0(KeyValuePair x) { }

		internal int <SetDetailsData>b__28_0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private Action OnConsumableItemChanged; //Field offset: 0xE8
	private float _baseConsumption; //Field offset: 0xF0
	protected ProductionScheme _actualScheme; //Field offset: 0xF8
	[CompilerGenerated]
	private ResourceConsumer <ResourceConsumer>k__BackingField; //Field offset: 0x100
	public Nullable SlotItemTemplate; //Field offset: 0x108
	protected int _installedSuppliesCount; //Field offset: 0x128
	private float _resourceRelatedSpeedCoefficient; //Field offset: 0x12C
	[CompilerGenerated]
	private AdditionalSlotsBonus <Slots>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private bool <Changeable>k__BackingField; //Field offset: 0x138

	public override event Action OnConsumableItemChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected Item[] AvailableItems
	{
		 get { } //Length: 484
	}

	public int AvailableItemsCount
	{
		 get { } //Length: 29
	}

	public virtual bool CanStart
	{
		 get { } //Length: 24
		 set { } //Length: 46
	}

	public private override bool Changeable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual IProductionStorage CompleteItemsStorage
	{
		 get { } //Length: 359
	}

	public override float Consumption
	{
		 get { } //Length: 44
	}

	public override float ConsumptionReduction
	{
		 get { } //Length: 31
	}

	public override int InstalledSuppliesCount
	{
		 get { } //Length: 7
		 set { } //Length: 37
	}

	public virtual bool IsWorking
	{
		 get { } //Length: 271
	}

	public int MaxSuppliesCount
	{
		 get { } //Length: 43
	}

	public virtual float ProductionSpeedCoefficient
	{
		 get { } //Length: 17
		 set { } //Length: 422
	}

	public private ResourceConsumer ResourceConsumer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected float ResourceRelatedSpeedCoefficient
	{
		 get { } //Length: 9
		 set { } //Length: 143
	}

	public private override AdditionalSlotsBonus Slots
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override BarterItem[] UsingItems
	{
		 get { } //Length: 30
	}

	public PermanentProducer() { }

	[CompilerGenerated]
	public override void add_OnConsumableItemChanged(Action value) { }

	protected virtual void AddProducingItem(ProducingItemController item) { }

	protected virtual void ApplySkillsAndBuffsOnInit(SkillManager skillManager) { }

	protected virtual void BeforeProductionComplete(string doneItemId) { }

	public virtual bool CanStartByProductionCount() { }

	private bool CheckCanStartProduction() { }

	protected Item[] get_AvailableItems() { }

	public int get_AvailableItemsCount() { }

	public virtual bool get_CanStart() { }

	[CompilerGenerated]
	public override bool get_Changeable() { }

	public virtual IProductionStorage get_CompleteItemsStorage() { }

	public override float get_Consumption() { }

	public override float get_ConsumptionReduction() { }

	public override int get_InstalledSuppliesCount() { }

	public virtual bool get_IsWorking() { }

	public int get_MaxSuppliesCount() { }

	public virtual float get_ProductionSpeedCoefficient() { }

	[CompilerGenerated]
	public ResourceConsumer get_ResourceConsumer() { }

	protected float get_ResourceRelatedSpeedCoefficient() { }

	[CompilerGenerated]
	public override AdditionalSlotsBonus get_Slots() { }

	public override BarterItem[] get_UsingItems() { }

	public virtual void GetItems(string schemeId) { }

	public virtual void InitAreaDataLate(AreaData data) { }

	protected virtual void InitInfo(AreaInfo areaInfo) { }

	public override void InstallConsumableItems(BarterItem[] installedSupplies) { }

	public bool InstallSupplySlot(Item item, int slotIndex) { }

	private void ItemResourceEndedHandler(Item item, int index) { }

	protected virtual void OnError() { }

	private void OnStatusChangedHandler() { }

	protected virtual bool PreUpdate(float deltaTime) { }

	[CompilerGenerated]
	public override void remove_OnConsumableItemChanged(Action value) { }

	public virtual void set_CanStart(bool value) { }

	[CompilerGenerated]
	private void set_Changeable(bool value) { }

	protected override void set_InstalledSuppliesCount(int value) { }

	public virtual void set_ProductionSpeedCoefficient(float value) { }

	[CompilerGenerated]
	private void set_ResourceConsumer(ResourceConsumer value) { }

	protected void set_ResourceRelatedSpeedCoefficient(float value) { }

	[CompilerGenerated]
	private void set_Slots(AdditionalSlotsBonus value) { }

	public virtual void SetAdditionalProductionLimit(int extraSlotsCount) { }

	protected virtual void SetDetailsData() { }

	protected virtual bool ShouldCreateProductionItemOnInit(ProductionData productionData, BaseHideoutScheme activeScheme) { }

	public virtual void StartProducing(BaseHideoutScheme scheme) { }

	protected void TryToStartProduction() { }

	private void UpdateConsumption() { }

	public virtual void UpdateProductionTimeReduction(float value) { }

}

