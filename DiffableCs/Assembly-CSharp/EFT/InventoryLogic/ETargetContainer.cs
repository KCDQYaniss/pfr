namespace EFT.InventoryLogic;

[Flags]
public enum ETargetContainer
{
	None = 1,
	Stash = 2,
	Equipment = 4,
	SortingTable = 8,
	All = 14,
}

