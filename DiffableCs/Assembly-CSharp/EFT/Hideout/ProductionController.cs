namespace EFT.Hideout;

public sealed class ProductionController : IUpdate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8
		public static Func <>9__17_0; //Field offset: 0x10
		public static Func <>9__18_0; //Field offset: 0x18
		public static Func <>9__23_4; //Field offset: 0x20
		public static Func <>9__30_0; //Field offset: 0x28
		public static Func <>9__31_0; //Field offset: 0x30
		public static Func <>9__32_0; //Field offset: 0x38
		public static Func <>9__33_0; //Field offset: 0x40
		public static Func <>9__33_1; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal int <get_TotalFailedItemsCount>b__17_0(ItemsProducerBase producer) { }

		internal int <get_TotalProducedItemsCount>b__15_0(ItemsProducerBase producer) { }

		internal bool <GetClosestToEndProducingItemOnArea>b__33_0(ItemsProducerBase producer) { }

		internal ProducingItemController <GetClosestToEndProducingItemOnArea>b__33_1(ItemsProducerBase producer) { }

		internal bool <GetProducersWithProducedItem>b__18_0(ItemsProducerBase producer) { }

		internal bool <HasCompletedItemOnArea>b__32_0(ItemsProducerBase p) { }

		internal bool <HasFulfilledProducerOnArea>b__31_0(ItemsProducerBase p) { }

		internal bool <HasWorkingProducerOnArea>b__30_0(ItemsProducerBase p) { }

		internal IEnumerable <SetProducer>b__23_4(List areaProducers) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public AreaData data; //Field offset: 0x10
		public ProductionController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <SetProducer>b__2() { }

		internal void <SetProducer>b__3(bool silent) { }

		internal void <SetProducer>g__OnProducingStarted|1(ItemsProducerBase producer, ProducingItemController item) { }

		internal void <SetProducer>g__ProducingCompleteHandler|0(ItemsProducerBase producer, Item[] items, ProducingItemController producingItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_1
	{
		public ItemsProducerBase producer; //Field offset: 0x10
		public <>c__DisplayClass23_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass23_1() { }

		internal void <SetProducer>b__5() { }

		internal void <SetProducer>b__6() { }

		internal void <SetProducer>b__7() { }

		internal void <SetProducer>b__8() { }

	}

	private sealed class ProductionCompletedEventData
	{
		[CompilerGenerated]
		private readonly ItemsProducerBase <Producer>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly List <Items>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly ProducingItemController <ProducingItemController>k__BackingField; //Field offset: 0x20

		public List Items
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ItemsProducerBase Producer
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ProducingItemController ProducingItemController
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ProductionCompletedEventData(ItemsProducerBase producer, IEnumerable items, ProducingItemController producingItemController) { }

		[CompilerGenerated]
		public List get_Items() { }

		[CompilerGenerated]
		public ItemsProducerBase get_Producer() { }

		[CompilerGenerated]
		public ProducingItemController get_ProducingItemController() { }

	}

	[CompilerGenerated]
	private Action OnProductionComplete; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnProducedItemCountChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnProductionStatusChanged; //Field offset: 0x20
	private readonly float _defaultNoEnergyCoefficient; //Field offset: 0x28
	private readonly Dictionary _areaProducers; //Field offset: 0x30
	private readonly List _disposeActions; //Field offset: 0x38
	private readonly Dictionary _productionCompletedEventData; //Field offset: 0x40

	public event Action OnProducedItemCountChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnProductionComplete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnProductionStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int TotalFailedItemsCount
	{
		 get { } //Length: 920
	}

	public int TotalProducedItemsCount
	{
		 get { } //Length: 920
	}

	public ProductionController(float defaultNoEnergyCoefficient) { }

	[CompilerGenerated]
	public void add_OnProducedItemCountChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnProductionComplete(Action value) { }

	[CompilerGenerated]
	public void add_OnProductionStatusChanged(Action value) { }

	private void CompleteItemsCountChangedHandler(IProductionStorage sender) { }

	public void EnergySupplyChanged(bool isEnergyOn) { }

	public int get_TotalFailedItemsCount() { }

	public int get_TotalProducedItemsCount() { }

	public List GetAreaProducers(AreaData behaviour) { }

	public ProducingItemController GetClosestToEndProducingItemOnArea(AreaData areaData) { }

	public IEnumerable GetProducersWithProducedItem() { }

	public bool HasCompletedItemOnArea(AreaData areaData) { }

	public bool HasFulfilledProducerOnArea(AreaData areaData) { }

	public bool HasWorkingProducerOnArea(AreaData areaData) { }

	private void ProduceStatusChanged() { }

	private void RaiseProductionCompleteNotifications() { }

	[CompilerGenerated]
	public void remove_OnProducedItemCountChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnProductionComplete(Action value) { }

	[CompilerGenerated]
	public void remove_OnProductionStatusChanged(Action value) { }

	public void SetProducer(AreaData data, List producers) { }

	public override void Update(float deltaTime) { }

	public void UpdateProducingSchemesEarly(AreaData data) { }

	private void UpdateProducingSchemesLate(AreaData data) { }

	public void UpdateProductions(Dictionary productionDataChanges) { }

}

