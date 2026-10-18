namespace EFT.InventoryLogic;

[Extension]
public static class ContainerExtensions
{

	[Extension]
	public static IItemOwner GetOwner(ItemAddress container) { }

	[CanBeNull]
	[Extension]
	public static IItemOwner GetOwnerOrNull(ItemAddress container) { }

	[Extension]
	public static bool MergesWithChildren(IContainer container) { }

	[Extension]
	public static bool NotMergedWithChildren(IContainer container) { }

	[Extension]
	public static float TotalWeight(IContainer container) { }

}

