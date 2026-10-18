namespace EFT;

public abstract class TransferItemsController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <HasNonEmptyTransferContainer>b__0(Stash container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <GetOrAddTransferContainer>b__0(Stash container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <MoveItemsFromTempStashToTransferStash>b__0(Stash grid) { }

		internal bool <MoveItemsFromTempStashToTransferStash>b__1(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <TryGetTransferContainer>b__0(Stash grid) { }

	}

	private ItemController _transferController; //Field offset: 0x10
	private readonly List _transferContainers; //Field offset: 0x18
	private readonly List _tempItemsList; //Field offset: 0x20
	[CompilerGenerated]
	private Stash <Stash>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ETraderServiceType <ServiceType>k__BackingField; //Field offset: 0x30
	public Action OnCautionState; //Field offset: 0x38
	protected readonly GameWorld _gameWorld; //Field offset: 0x40
	private readonly bool _isOfflineGame; //Field offset: 0x48

	public private ETraderServiceType ServiceType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Stash Stash
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected TransferItemsController(GameWorld gameWorld, bool isOfflineGame, ETraderServiceType serviceType) { }

	public abstract int CalculateServicePrice(string profileId, ETraderServiceType serviceType, int basePrice) { }

	[CompilerGenerated]
	public ETraderServiceType get_ServiceType() { }

	[CompilerGenerated]
	public Stash get_Stash() { }

	public abstract double GetDeliveryPriceForProfile(string profileId) { }

	protected int GetGridItemsPrice(Stash stashContainer, ETraderServiceType traderServiceType, float deliveryPrice, float modDeliveryCost) { }

	public abstract int GetGridItemsPrice(Stash stashContainer) { }

	protected abstract Vector3 GetGridSize(Profile profile) { }

	private IntVec2 GetGridSizeForProfileId(string profileId) { }

	public Stash GetOrAddTransferContainer(string profileId) { }

	public bool HasNonEmptyTransferContainer(string profileId) { }

	public void InitItemControllerServer(MongoID traderId, string name) { }

	public void InitPlayerStash(Player player) { }

	public void InitTransferContainer(Stash newContainer, string name) { }

	public void MoveItemsFromTempStashToTransferStash(Player player) { }

	[CompilerGenerated]
	private void set_ServiceType(ETraderServiceType value) { }

	[CompilerGenerated]
	private void set_Stash(Stash value) { }

	protected bool TryGetTransferContainer(string profileId, out Stash playerContainer) { }

}

