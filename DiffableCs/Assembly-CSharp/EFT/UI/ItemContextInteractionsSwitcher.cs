namespace EFT.UI;

public sealed class ItemContextInteractionsSwitcher
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__54_0; //Field offset: 0x8
		public static Func <>9__64_0; //Field offset: 0x10
		public static Func <>9__64_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_IsBeingExamined>b__54_0(ItemEventArgs eventArgs) { }

		internal Item <IsInteractive>b__64_0(RepairableComponent repairable) { }

		internal bool <IsInteractive>b__64_1(Slot camora) { }

	}

	private ItemContext _itemContext; //Field offset: 0x10
	private Item _item; //Field offset: 0x18
	private readonly ItemController _itemController; //Field offset: 0x20
	private readonly IHealthController _healthController; //Field offset: 0x28
	private readonly EItemUiContextType _contextType; //Field offset: 0x30
	private readonly RepairController _repairController; //Field offset: 0x38
	private readonly InsuranceCompany _insurance; //Field offset: 0x40
	private readonly RagFair _ragfair; //Field offset: 0x48
	private readonly ItemUiContext _uiContext; //Field offset: 0x50
	private readonly InventoryEquipment _equipment; //Field offset: 0x58
	private bool _examinationRequired; //Field offset: 0x60

	private bool BadContextType
	{
		private get { } //Length: 17
	}

	private bool CanToggle
	{
		private get { } //Length: 225
	}

	private EItemViewType CurrentViewType
	{
		private get { } //Length: 26
	}

	private bool Equipped
	{
		private get { } //Length: 155
	}

	private bool Examined
	{
		private get { } //Length: 62
	}

	private FoldableComponent Foldable
	{
		private get { } //Length: 97
	}

	private bool Gameplay
	{
		private get { } //Length: 59
	}

	private bool HasOwner
	{
		private get { } //Length: 44
	}

	private bool HealAvailable
	{
		private get { } //Length: 76
	}

	private bool InternalMag
	{
		private get { } //Length: 42
	}

	private bool IsBeingExamined
	{
		private get { } //Length: 394
	}

	private bool IsBlockInteractionsForItem
	{
		private get { } //Length: 37
	}

	public bool IsOwnedByPlayer
	{
		 get { } //Length: 43
	}

	private bool IsQuestItem
	{
		private get { } //Length: 42
	}

	private bool MagazineIsEmpty
	{
		private get { } //Length: 61
	}

	private bool ModInstalled
	{
		private get { } //Length: 139
	}

	private IItemOwner Owner
	{
		private get { } //Length: 39
	}

	private Item Parent
	{
		private get { } //Length: 99
	}

	private bool PlayerBusy
	{
		private get { } //Length: 29
	}

	private bool RagFairAvailable
	{
		private get { } //Length: 187
	}

	private RecodableComponent Recodable
	{
		private get { } //Length: 97
	}

	private TogglableComponent Togglable
	{
		private get { } //Length: 97
	}

	private bool UseAvailable
	{
		private get { } //Length: 9
	}

	private Weapon Weapon
	{
		private get { } //Length: 119
	}

	public ItemContextInteractionsSwitcher(ItemController itemController, IHealthController healthController, InsuranceCompany insurance, RepairController repairController, RagFair ragfair, ItemUiContext uiContext, InventoryEquipment equipment) { }

	private bool CanLoadAmmoFromMenu() { }

	private bool CanModifyItem(out FailedResult result) { }

	private bool CanRepair(RepairItemContext repairItemContext, Item item) { }

	private bool get_BadContextType() { }

	private bool get_CanToggle() { }

	private EItemViewType get_CurrentViewType() { }

	private bool get_Equipped() { }

	private bool get_Examined() { }

	private FoldableComponent get_Foldable() { }

	private bool get_Gameplay() { }

	private bool get_HasOwner() { }

	private bool get_HealAvailable() { }

	private bool get_InternalMag() { }

	private bool get_IsBeingExamined() { }

	private bool get_IsBlockInteractionsForItem() { }

	public bool get_IsOwnedByPlayer() { }

	private bool get_IsQuestItem() { }

	private bool get_MagazineIsEmpty() { }

	private bool get_ModInstalled() { }

	private IItemOwner get_Owner() { }

	private Item get_Parent() { }

	private bool get_PlayerBusy() { }

	private bool get_RagFairAvailable() { }

	private RecodableComponent get_Recodable() { }

	private TogglableComponent get_Togglable() { }

	private bool get_UseAvailable() { }

	private Weapon get_Weapon() { }

	public ItemContextInteractionsSwitcher Init(ItemContext itemContext, bool examinationRequired) { }

	public bool IsActive(EItemInfoButton button) { }

	public IResult IsInteractive(EItemInfoButton button) { }

}

