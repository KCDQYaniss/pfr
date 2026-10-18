namespace EFT.InventoryLogic;

[Extension]
public static class OwnerTypeExtensions
{
	private static EOwnerType[] _personalizedOwnerTypes; //Field offset: 0x0

	private static OwnerTypeExtensions() { }

	[Extension]
	public static bool IsPersonalizedOwner(EOwnerType ownerType) { }

}

