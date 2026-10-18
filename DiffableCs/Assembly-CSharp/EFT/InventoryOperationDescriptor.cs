namespace EFT;

[GenerateBinarySerialization]
public abstract class InventoryOperationDescriptor : IOperationInfo
{
	[CompilerGenerated]
	private ushort <OperationId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MongoID <OwnerId>k__BackingField; //Field offset: 0x18

	public IOperationInfo Operation
	{
		 set { } //Length: 211
	}

	public override ushort OperationId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override MongoID OwnerId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 98
	}

	protected InventoryOperationDescriptor() { }

	[CompilerGenerated]
	public override ushort get_OperationId() { }

	[CompilerGenerated]
	public override MongoID get_OwnerId() { }

	public void set_Operation(IOperationInfo value) { }

	[CompilerGenerated]
	public void set_OperationId(ushort value) { }

	[CompilerGenerated]
	public void set_OwnerId(MongoID value) { }

	public abstract OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

