namespace EFT.Hideout;

public abstract class BaseItemSlotsAreaBehaviour : AreaBehaviour, IItemSlotsAreaBehaviour
{
	[CompilerGenerated]
	private Action OnItemInSlotChanged; //Field offset: 0x68
	[CompilerGenerated]
	private Item[] <UsingItems>k__BackingField; //Field offset: 0x70

	public override event Action OnItemInSlotChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool Changeable
	{
		 get { } //Length: 39
	}

	public private override Item[] UsingItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected BaseItemSlotsAreaBehaviour() { }

	[CompilerGenerated]
	public override void add_OnItemInSlotChanged(Action value) { }

	public abstract bool CanAcceptItem(Item item) { }

	public override bool get_Changeable() { }

	[CompilerGenerated]
	public override Item[] get_UsingItems() { }

	protected void InitializeItemSlots(AreaInfo profileInfo) { }

	public override void InstallConsumableItems(Item[] installedSupplies) { }

	protected override bool IsItemMatchesFilters(Item item) { }

	protected override void OnInitializeItemInserted(Item item, int slotIndex) { }

	protected override void OnItemRemoved(Item item, int slotIndex) { }

	[CompilerGenerated]
	public override void remove_OnItemInSlotChanged(Action value) { }

	[CompilerGenerated]
	private void set_UsingItems(Item[] value) { }

	protected override void SetItems(Item[] installedSupplies) { }

}

