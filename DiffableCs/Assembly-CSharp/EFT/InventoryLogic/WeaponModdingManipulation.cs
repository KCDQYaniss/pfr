namespace EFT.InventoryLogic;

public sealed class WeaponModdingManipulation : DropdownManipulation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetItemCollections>b__1_0(Item topLevelItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Slot slot; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <GetItemCollections>b__1(Item item) { }

	}


	public WeaponModdingManipulation(InventoryController controller, CompoundItem[] collections) { }

	public virtual EEditBuildItemAvailability GetItemAvailability(Item item) { }

	public virtual IEnumerable GetItemCollections(Slot slot) { }

	protected virtual bool Select(Item item, Slot slot, bool simulate, out Error error) { }

}

