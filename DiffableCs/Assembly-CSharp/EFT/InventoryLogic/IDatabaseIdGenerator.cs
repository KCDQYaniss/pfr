namespace EFT.InventoryLogic;

public interface IDatabaseIdGenerator
{

	public MongoID NextId
	{
		 get { } //Length: 0
	}

	public MongoID get_NextId() { }

	public void RollBack() { }

}

