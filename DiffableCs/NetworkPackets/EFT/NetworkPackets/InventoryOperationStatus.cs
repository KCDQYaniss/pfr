namespace EFT.NetworkPackets;

public struct InventoryOperationStatus
{
	public ushort Id; //Field offset: 0x0
	public EOperationStatus Status; //Field offset: 0x4
	public string Error; //Field offset: 0x8
	public int InventoryHashSum; //Field offset: 0x10
	public bool BadBeforeExecuting; //Field offset: 0x14

	public virtual string ToString() { }

}

