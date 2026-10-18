namespace EFT;

public sealed class SplitOperationDescriptor : InventoryOperationDescriptor
{
	private sealed class SplitIdGenerator : IDatabaseIdGenerator
	{
		[CompilerGenerated]
		private readonly MongoID <NextId>k__BackingField; //Field offset: 0x10

		public override MongoID NextId
		{
			[CompilerGenerated]
			 get { } //Length: 21
		}

		public SplitIdGenerator(MongoID id) { }

		[CompilerGenerated]
		public override MongoID get_NextId() { }

		public override void RollBack() { }

	}

	public string ItemId; //Field offset: 0x30
	public string CloneId; //Field offset: 0x38
	public ItemAddressDescriptor From; //Field offset: 0x40
	public ItemAddressDescriptor To; //Field offset: 0x48
	public int Count; //Field offset: 0x50

	public SplitOperationDescriptor() { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

	public virtual string ToString() { }

}

