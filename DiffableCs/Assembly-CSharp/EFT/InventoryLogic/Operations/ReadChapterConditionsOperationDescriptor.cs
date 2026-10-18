namespace EFT.InventoryLogic.Operations;

public sealed class ReadChapterConditionsOperationDescriptor : InventoryOperationDescriptor
{
	public MongoID ChapterId; //Field offset: 0x30
	public EChapterConditionType Type; //Field offset: 0x48

	public ReadChapterConditionsOperationDescriptor() { }

	[CompilerGenerated]
	private bool <ToInventoryOperation>b__2_0(QuestChapter ch) { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}

