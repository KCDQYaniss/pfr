namespace EFT.Hideout;

public sealed class CultistsProducer : ItemsProducerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8
		public static Func <>9__3_0; //Field offset: 0x10
		public static Func <>9__5_0; //Field offset: 0x18
		public static Func <>9__8_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <get_CompleteItemsCount>b__1_0(KeyValuePair i) { }

		internal bool <get_HasCompletedItems>b__3_0(KeyValuePair i) { }

		internal bool <get_IsWorking>b__5_0(KeyValuePair i) { }

		internal int <SetDetailsData>b__8_0(KeyValuePair x) { }

	}


	public virtual int CompleteItemsCount
	{
		 get { } //Length: 355
	}

	public virtual bool HasCompletedItems
	{
		 get { } //Length: 408
	}

	public virtual bool IsWorking
	{
		 get { } //Length: 408
	}

	public CultistsProducer() { }

	protected virtual void BeforeProductionComplete(string doneItemId) { }

	public virtual int get_CompleteItemsCount() { }

	public virtual bool get_HasCompletedItems() { }

	public virtual bool get_IsWorking() { }

	public virtual void GetItems(string schemeId) { }

	protected virtual void InitDetails(AreaData data) { }

	protected virtual void SetDetailsData() { }

	protected virtual bool ShouldCreateProductionItemOnInit(ProductionData productionData, BaseHideoutScheme activeScheme) { }

	public virtual bool TryUpdateProduction(string schemeId, ProductionData productionData) { }

}

