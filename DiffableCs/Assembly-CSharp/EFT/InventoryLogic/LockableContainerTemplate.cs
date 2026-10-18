namespace EFT.InventoryLogic;

public class LockableContainerTemplate : CompoundItemTemplate, ILockableComponentTemplate
{
	public string[] KeyIds; //Field offset: 0x170

	private override string[] EFT.InventoryLogic.ILockableComponentTemplate.KeyIds
	{
		private get { } //Length: 8
	}

	public LockableContainerTemplate() { }

	private override string[] EFT.InventoryLogic.ILockableComponentTemplate.get_KeyIds() { }

}

