namespace EFT.InventoryLogic;

public class MapTemplate : ItemTemplate, IMapComponentTemplate
{
	public string ConfigPathStr; //Field offset: 0x148
	public int MaxMarkersCount; //Field offset: 0x150
	public float scaleMin; //Field offset: 0x154
	public float scaleMax; //Field offset: 0x158

	private override string EFT.InventoryLogic.IMapComponentTemplate.ConfigPathStr
	{
		private get { } //Length: 8
	}

	private override int EFT.InventoryLogic.IMapComponentTemplate.MaxMarkersCount
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IMapComponentTemplate.ScaleMax
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IMapComponentTemplate.ScaleMin
	{
		private get { } //Length: 9
	}

	public MapTemplate() { }

	private override string EFT.InventoryLogic.IMapComponentTemplate.get_ConfigPathStr() { }

	private override int EFT.InventoryLogic.IMapComponentTemplate.get_MaxMarkersCount() { }

	private override float EFT.InventoryLogic.IMapComponentTemplate.get_ScaleMax() { }

	private override float EFT.InventoryLogic.IMapComponentTemplate.get_ScaleMin() { }

}

