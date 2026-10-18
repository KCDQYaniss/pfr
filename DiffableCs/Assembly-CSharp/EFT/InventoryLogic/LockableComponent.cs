namespace EFT.InventoryLogic;

public class LockableComponent : ItemComponent
{
	internal sealed class BadKeyError : InventoryError
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__3_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal string <ToString>b__3_0(string x) { }

		}

		public readonly LockableComponent Lockable; //Field offset: 0x10
		public readonly KeyComponent Key; //Field offset: 0x18

		public BadKeyError(LockableComponent lockable, KeyComponent key) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	[Diffable]
	public bool Locked; //Field offset: 0x18
	private readonly ILockableComponentTemplate _template; //Field offset: 0x20

	public string[] KeyIds
	{
		 get { } //Length: 75
	}

	public LockableComponent(Item item, ILockableComponentTemplate template) { }

	public OperationResult Apply(Item item, ItemController itemController, Grid[] grids, bool simulate) { }

	public OperationResult ApplyKey(KeyComponent key, InventoryController inventoryController, bool simulate) { }

	public string[] get_KeyIds() { }

}

