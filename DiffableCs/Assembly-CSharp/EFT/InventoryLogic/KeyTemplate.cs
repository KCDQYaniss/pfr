namespace EFT.InventoryLogic;

public class KeyTemplate : ItemTemplate, IKeyComponentTemplate
{
	public int MaximumNumberOfUsage; //Field offset: 0x148

	private override string EFT.InventoryLogic.IKeyComponentTemplate.KeyId
	{
		private get { } //Length: 197
	}

	private override int EFT.InventoryLogic.IKeyComponentTemplate.MaximumNumberOfUsage
	{
		private get { } //Length: 7
	}

	public KeyTemplate() { }

	private override string EFT.InventoryLogic.IKeyComponentTemplate.get_KeyId() { }

	private override int EFT.InventoryLogic.IKeyComponentTemplate.get_MaximumNumberOfUsage() { }

}

