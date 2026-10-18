namespace EFT.InventoryLogic;

public sealed class CorpseItemController : PersonItemController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <OutProcess>b__4_0(ContainerCollection x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IContainer container; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <CanSetMod>b__0(Slot x) { }

	}

	private const string ITEM_CONTROLLER_NAME = "Corpse"; //Field offset: 0x0
	private readonly ContainerCollectionView _containerCollectionView; //Field offset: 0x100
	public readonly string KilledProfileID; //Field offset: 0x108

	public CorpseItemController(Item rootItem, EPlayerSide side, string profileId, string killedProfileID, bool canBeLocalized = true, EOwnerType type = 0, MongoID firstId = null, ContainerCollectionView containerCollectionView = null) { }

	public bool CanSetMod(Weapon item, IContainer container) { }

	private void FoldStock(Weapon item) { }

	protected virtual void InProcess(ItemController executor, Item item, ItemAddress to, bool succeed, IInventoryOperation operation, Callback callback) { }

	protected virtual void OutProcess(ItemController executor, Item item, ItemAddress from, ItemAddress to, IInventoryOperation operation, Callback callback) { }

}

