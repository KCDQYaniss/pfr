namespace EFT.InventoryLogic;

[Extension]
public static class ContainerCollectionExtension
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ContainerCollection container; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <Contains>b__0(Item parentItem) { }

	}


	[Extension]
	public static bool Contains(ContainerCollection container, Item item) { }

	[Extension]
	public static bool TryFindContainer(ContainerCollection collection, string containerId, string parentId, out IContainer container) { }

	[Extension]
	public static bool TryFindItem(ContainerCollection collection, string itemId, out TItemComponent component) { }

}

