namespace EFT.InventoryLogic;

public class GameDisk : Info
{
	private readonly DialogItemTemplate _template; //Field offset: 0x78

	public MongoID DialogId
	{
		 get { } //Length: 49
	}

	public GameDisk(string id, DialogItemTemplate template) { }

	public MongoID get_DialogId() { }

}

