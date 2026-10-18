namespace EFT.InventoryLogic;

public sealed class NonEmptyCompoundItemError : InventoryError
{
	public const string CONTAINER_MUST_BE_EMPTY = "ragfair/container_must_be_empty_notification"; //Field offset: 0x0

	public NonEmptyCompoundItemError() { }

	public virtual string GetLocalizedDescription() { }

	public virtual string ToString() { }

}

