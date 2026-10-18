namespace EFT.InventoryLogic;

public class MobContainerTemplate : SearchableItemTemplate
{
	public object[] containType; //Field offset: 0x180
	public int sizeWidth; //Field offset: 0x188
	public int sizeHeight; //Field offset: 0x18C
	public bool isSecured; //Field offset: 0x190
	public string spawnTypes; //Field offset: 0x198
	public object[] lootFilter; //Field offset: 0x1A0
	public string spawnRarity; //Field offset: 0x1A8
	public int minCountSpawn; //Field offset: 0x1B0
	public int maxCountSpawn; //Field offset: 0x1B4
	public object[] openedByKeyID; //Field offset: 0x1B8

	public MobContainerTemplate() { }

}

