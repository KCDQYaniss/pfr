namespace EFT.InventoryLogic;

public sealed class CollectiveItem : Item
{
	private sealed class CollectiveItemAddress : ItemAddress
	{
		private sealed class CollectiveContainerAddResult : ContainerAddResult
		{
			private readonly ContainerAddResult _realResult; //Field offset: 0x30

			public CollectiveContainerAddResult(CollectiveItem item, CollectiveItemAddress to, ContainerAddResult realResult, bool simulated) { }

			protected virtual void RaiseEventsInternal(IItemOwner controller, CommandStatus status) { }

			protected virtual void RollBackInternal() { }

		}

		private sealed class CollectiveContainerRemoveResult : ContainerRemoveResult
		{
			private readonly ContainerRemoveResult _realResult; //Field offset: 0x28

			public CollectiveContainerRemoveResult(CollectiveItem item, CollectiveItemAddress from, ContainerRemoveResult realResult, bool simulated) { }

			protected virtual void RaiseEventsInternal(IItemOwner controller, CommandStatus status) { }

			protected virtual void RollBackInternal() { }

		}

		private readonly ItemAddress _realItemAddress; //Field offset: 0x18

		public virtual string ContainerName
		{
			 get { } //Length: 42
		}

		public CollectiveItemAddress(ItemAddress realItemAddress) { }

		public virtual OperationResult Add(Item item, bool simulate) { }

		public virtual OperationResult AddWithoutRestrictions(Item item) { }

		public virtual string get_ContainerName() { }

		public virtual Option GetMaxAddCount(Item item) { }

		public virtual OperationResult Remove(Item item, bool simulate) { }

		public virtual OperationResult RemoveWithoutRestrictions(Item item) { }

		public virtual ItemAddressDescriptor ToDescriptor() { }

	}

	private static readonly IEnumerable _itemInteractions; //Field offset: 0x0
	public readonly IReadOnlyCollection Items; //Field offset: 0x78
	public readonly Item MainItem; //Field offset: 0x80
	private readonly float _weight; //Field offset: 0x88
	private readonly bool _spawnedInSession; //Field offset: 0x8C

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 83
	}

	public virtual bool SpawnedInSession
	{
		 get { } //Length: 8
	}

	public virtual float TotalWeight
	{
		 get { } //Length: 9
	}

	private static CollectiveItem() { }

	public CollectiveItem(ItemTemplate template, IReadOnlyCollection items) { }

	private static bool Equal(CollectiveItem a, Item b) { }

	public virtual bool Equals(object obj) { }

	private bool Equals(Item obj) { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

	public virtual bool get_SpawnedInSession() { }

	public virtual float get_TotalWeight() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(CollectiveItem a, Item b) { }

	public static bool op_Equality(Item b, CollectiveItem a) { }

	public static bool op_Inequality(CollectiveItem a, Item b) { }

	public static bool op_Inequality(Item b, CollectiveItem a) { }

}

