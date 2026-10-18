namespace EFT.InventoryLogic;

public sealed class RefreshItemEventArgs : EventArgs
{
	public readonly Item Item; //Field offset: 0x10
	public readonly IContainer Container; //Field offset: 0x18
	public readonly bool RefreshIcon; //Field offset: 0x20
	public readonly bool CheckMagazine; //Field offset: 0x21

	public RefreshItemEventArgs(Item item, IContainer container, bool refreshIcon, bool checkMagazine) { }

}

