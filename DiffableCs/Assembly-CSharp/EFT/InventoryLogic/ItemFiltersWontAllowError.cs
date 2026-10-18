namespace EFT.InventoryLogic;

public sealed class ItemFiltersWontAllowError : InventoryError
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__3_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <ToString>b__3_0(ItemFilter x) { }

		internal string <ToString>b__3_1(MongoID x) { }

	}

	private readonly Item _item; //Field offset: 0x10
	private readonly StackSlot _stackSlot; //Field offset: 0x18

	public ItemFiltersWontAllowError(Item item, StackSlot stackSlot) { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

