namespace EFT;

[GenerateBinarySerialization]
public class ObservedPlayerInventoryOperationDescriptor
{
	public int PlayerRaidID; //Field offset: 0x10
	public InventoryOperationDescriptor Descriptor; //Field offset: 0x18

	public ObservedPlayerInventoryOperationDescriptor() { }

	public ObservedPlayerInventoryOperationDescriptor(int PlayerRaidID, InventoryOperationDescriptor Descriptor) { }

}

