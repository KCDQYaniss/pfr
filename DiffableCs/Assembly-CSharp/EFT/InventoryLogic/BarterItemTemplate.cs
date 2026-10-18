namespace EFT.InventoryLogic;

public class BarterItemTemplate : ItemTemplate, IResourceItemTemplate
{
	public int MaxResource; //Field offset: 0x148

	private override float EFT.InventoryLogic.IResourceItemTemplate.MaxResource
	{
		private get { } //Length: 12
	}

	public BarterItemTemplate() { }

	private override float EFT.InventoryLogic.IResourceItemTemplate.get_MaxResource() { }

}

