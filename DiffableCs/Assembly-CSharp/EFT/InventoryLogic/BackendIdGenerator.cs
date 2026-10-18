namespace EFT.InventoryLogic;

public sealed class BackendIdGenerator
{
	private readonly List _idCache; //Field offset: 0x10
	private int _idIndex; //Field offset: 0x18
	private readonly Profile _profile; //Field offset: 0x20

	public MongoID NextId
	{
		 get { } //Length: 297
	}

	public BackendIdGenerator(Profile profile) { }

	public MongoID get_NextId() { }

	public void RollBack() { }

}

