namespace EFT;

public interface IOperationInfo
{

	public ushort OperationId
	{
		 get { } //Length: 0
	}

	public MongoID OwnerId
	{
		 get { } //Length: 0
	}

	public ushort get_OperationId() { }

	public MongoID get_OwnerId() { }

}

