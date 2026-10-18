namespace EFT.Hideout;

public abstract class ItemsProducerBase : IUpdate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__50_0; //Field offset: 0x8
		public static Func <>9__93_0; //Field offset: 0x10
		public static Func <>9__105_0; //Field offset: 0x18
		public static Func <>9__105_1; //Field offset: 0x20
		public static Func <>9__117_0; //Field offset: 0x28
		public static Func <>9__117_1; //Field offset: 0x30
		public static Func <>9__117_2; //Field offset: 0x38
		public static Func <>9__117_3; //Field offset: 0x40
		public static Func <>9__117_4; //Field offset: 0x48
		public static Func <>9__117_5; //Field offset: 0x50
		public static Func <>9__117_6; //Field offset: 0x58
		public static Func <>9__117_7; //Field offset: 0x60
		public static Func <>9__117_8; //Field offset: 0x68
		public static Func <>9__117_9; //Field offset: 0x70
		public static Func <>9__137_0; //Field offset: 0x78

		private static <>c() { }

		public <>c() { }

		internal bool <CanStartByProductionCount>b__93_0(KeyValuePair i) { }

		internal bool <GetErrorsCount>b__50_0(KeyValuePair item) { }

		internal bool <GetProducer>b__105_0(BaseHideoutScheme scheme) { }

		internal bool <GetProducer>b__105_1(BaseHideoutScheme scheme) { }

		internal bool <InitAreaDataEarly>b__117_0(BaseHideoutScheme s) { }

		internal string <InitAreaDataEarly>b__117_1(BaseHideoutScheme scheme) { }

		internal BaseHideoutScheme <InitAreaDataEarly>b__117_2(BaseHideoutScheme scheme) { }

		internal bool <InitAreaDataEarly>b__117_3(BaseHideoutScheme s) { }

		internal string <InitAreaDataEarly>b__117_4(BaseHideoutScheme scheme) { }

		internal BaseHideoutScheme <InitAreaDataEarly>b__117_5(BaseHideoutScheme scheme) { }

		internal string <InitAreaDataEarly>b__117_6(BaseHideoutScheme scheme) { }

		internal BaseHideoutScheme <InitAreaDataEarly>b__117_7(BaseHideoutScheme scheme) { }

		internal string <InitAreaDataEarly>b__117_8(KeyValuePair keyValuePair) { }

		internal BaseHideoutScheme <InitAreaDataEarly>b__117_9(KeyValuePair keyValuePair) { }

		internal int <SetDetailsData>b__137_0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private EAreaType <AreaType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <LastRecipe>k__BackingField; //Field offset: 0x18
	protected AreaDetailsData ItemsReadyDetails; //Field offset: 0x20
	protected AreaDetailsData ProgressDetails; //Field offset: 0x28
	protected AreaDetailsGroup DetailsGroup; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnProductionSpeedChanged; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnWorkingStatusChanged; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnProduceStatusChanged; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnProductionStarted; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnProductionComplete; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnGetProducedItems; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnDataChanged; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnItemChanged; //Field offset: 0x70
	[CompilerGenerated]
	private Dictionary <Schemes>k__BackingField; //Field offset: 0x78
	protected readonly Dictionary _doneItems; //Field offset: 0x80
	protected readonly Dictionary _errorItems; //Field offset: 0x88
	[CompilerGenerated]
	private readonly Dictionary <ProducingItems>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Dictionary <DecryptedCodeProductionStorage>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private bool <IsFulfilled>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private int <MaxProducingItems>k__BackingField; //Field offset: 0xA4
	protected IProductionStorage _completeItemsStorage; //Field offset: 0xA8
	[CompilerGenerated]
	private AreaData <AreaData>k__BackingField; //Field offset: 0xB0
	protected float _productionSpeedCoefficient; //Field offset: 0xB8
	private EnergyController _energyController; //Field offset: 0xC0
	private BonusController _bonusController; //Field offset: 0xC8
	private float _skillTimeReduction; //Field offset: 0xD0
	[CompilerGenerated]
	private float <TimeReduction>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private readonly HideoutRepresentation <Hideout>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private bool <CanStart>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private bool <IsConstantConsumption>k__BackingField; //Field offset: 0xE1

	public event Action OnDataChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnGetProducedItems
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnItemChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnProduceStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnProductionComplete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnProductionSpeedChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnProductionStarted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnWorkingStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	protected private AreaData AreaData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EAreaType AreaType
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool CanStart
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public ProducingItemController ClosestToEndProducingItem
	{
		 get { } //Length: 703
	}

	public override int CompleteItemsCount
	{
		 get { } //Length: 99
	}

	public override IProductionStorage CompleteItemsStorage
	{
		 get { } //Length: 652
	}

	public private Dictionary DecryptedCodeProductionStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected EnergyController EnergyController
	{
		 get { } //Length: 163
	}

	public override bool HasCompletedItems
	{
		 get { } //Length: 99
	}

	protected HideoutRepresentation Hideout
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected private bool IsConstantConsumption
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsFulfilled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsWorking
	{
		 get { } //Length: 164
	}

	public string LastRecipe
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected int MaxProducingItems
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override EHideoutNotificationType NotificationType
	{
		 get { } //Length: 6
	}

	public Dictionary ProducingItems
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override float ProductionSpeedCoefficient
	{
		 get { } //Length: 9
		 set { } //Length: 413
	}

	public override float ReductionCoefficient
	{
		 get { } //Length: 17
	}

	public private Dictionary Schemes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float TimeReduction
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	protected ItemsProducerBase() { }

	[CompilerGenerated]
	public void add_OnDataChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnGetProducedItems(Action value) { }

	[CompilerGenerated]
	public void add_OnItemChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnProduceStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnProductionComplete(Action value) { }

	[CompilerGenerated]
	public void add_OnProductionSpeedChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnProductionStarted(Action value) { }

	[CompilerGenerated]
	public void add_OnWorkingStatusChanged(Action value) { }

	protected override void AddProducingItem(ProducingItemController item) { }

	protected override void ApplySkillsAndBuffsOnInit(SkillManager skillManager) { }

	protected override void BeforeProductionComplete(string doneItemId) { }

	public double CalculateProductionTime(BaseHideoutScheme scheme) { }

	protected void CallDataChanged() { }

	protected void CallGetProducedItems(Item[] items) { }

	protected void CallProducingStarted(ProducingItemController producingItem) { }

	protected void CallProductionSpeedChanged() { }

	protected void CallWorkingStatusChanged() { }

	public override bool CanStartByProductionCount() { }

	public bool CanStartScheme(ProductionScheme scheme) { }

	protected override Item CreateCompleteItem(BaseHideoutScheme scheme) { }

	[CompilerGenerated]
	protected AreaData get_AreaData() { }

	[CompilerGenerated]
	public EAreaType get_AreaType() { }

	[CompilerGenerated]
	public override bool get_CanStart() { }

	public ProducingItemController get_ClosestToEndProducingItem() { }

	public override int get_CompleteItemsCount() { }

	public override IProductionStorage get_CompleteItemsStorage() { }

	[CompilerGenerated]
	public Dictionary get_DecryptedCodeProductionStorage() { }

	protected EnergyController get_EnergyController() { }

	public override bool get_HasCompletedItems() { }

	[CompilerGenerated]
	protected HideoutRepresentation get_Hideout() { }

	[CompilerGenerated]
	protected bool get_IsConstantConsumption() { }

	[CompilerGenerated]
	public bool get_IsFulfilled() { }

	public override bool get_IsWorking() { }

	[CompilerGenerated]
	public string get_LastRecipe() { }

	[CompilerGenerated]
	protected int get_MaxProducingItems() { }

	public override EHideoutNotificationType get_NotificationType() { }

	[CompilerGenerated]
	public Dictionary get_ProducingItems() { }

	public override float get_ProductionSpeedCoefficient() { }

	public override float get_ReductionCoefficient() { }

	[CompilerGenerated]
	public Dictionary get_Schemes() { }

	[CompilerGenerated]
	public float get_TimeReduction() { }

	public int GetErrorsCount() { }

	public int GetErrorsCountRaw() { }

	public override void GetItems(string schemeId) { }

	public static List GetProducer(AreaData data, AreaInfo areaInfo, List productionData, IEnumerable schemes, SkillManager skillManager, FenceTraderInfo fenceInfo) { }

	public EProductionState GetProductionState(string schemeId) { }

	public override void InitAreaDataEarly(AreaData data) { }

	public override void InitAreaDataLate(AreaData data) { }

	protected override void InitDetails(AreaData data) { }

	protected override void InitInfo(AreaInfo areaInfo) { }

	private void InitProducingItem(ProductionData productionData, BaseHideoutScheme activeScheme) { }

	protected override void InitProduction(List productions) { }

	private void InitStorage(ProductionData productionData) { }

	protected void ItemChangedHandler(Item item) { }

	protected override void OnError() { }

	protected override bool PreUpdate(float deltaTime) { }

	private void ProcessDoneItems() { }

	protected void ProcessErrors() { }

	[CompilerGenerated]
	public void remove_OnDataChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnGetProducedItems(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnProduceStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnProductionComplete(Action value) { }

	[CompilerGenerated]
	public void remove_OnProductionSpeedChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnProductionStarted(Action value) { }

	[CompilerGenerated]
	public void remove_OnWorkingStatusChanged(Action value) { }

	[CompilerGenerated]
	private void set_AreaData(AreaData value) { }

	[CompilerGenerated]
	private void set_AreaType(EAreaType value) { }

	[CompilerGenerated]
	public override void set_CanStart(bool value) { }

	[CompilerGenerated]
	private void set_DecryptedCodeProductionStorage(Dictionary value) { }

	[CompilerGenerated]
	private void set_IsConstantConsumption(bool value) { }

	[CompilerGenerated]
	protected void set_IsFulfilled(bool value) { }

	[CompilerGenerated]
	public void set_LastRecipe(string value) { }

	[CompilerGenerated]
	protected void set_MaxProducingItems(int value) { }

	public override void set_ProductionSpeedCoefficient(float value) { }

	[CompilerGenerated]
	private void set_Schemes(Dictionary value) { }

	[CompilerGenerated]
	private void set_TimeReduction(float value) { }

	public override void SetAdditionalProductionLimit(int extraSlotsCount) { }

	protected override void SetDetailsData() { }

	public void SetErrorsChecked() { }

	protected override bool ShouldCreateProductionItemOnInit(ProductionData productionData, BaseHideoutScheme activeScheme) { }

	public override void StartProducing(BaseHideoutScheme scheme) { }

	public override bool TryUpdateProduction(string schemeId, ProductionData productionData) { }

	public override void Update(float deltaTime) { }

	private void UpdateErrorState(ProductionData productionData, BaseHideoutScheme activeScheme) { }

	protected void UpdateFulfilledStatus() { }

	private void UpdateProductionTimeReduction() { }

	public override void UpdateProductionTimeReduction(float value) { }

}

