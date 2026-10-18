namespace EFT;

public sealed class QuestHandoverDescriptor : QuestActionDescriptor
{
	public DestroyedItem[] Items; //Field offset: 0x38
	public MongoID ConditionId; //Field offset: 0x40

	public QuestHandoverDescriptor() { }

	[CompilerGenerated]
	private bool <ToQuestOperation>b__2_0(Quest q) { }

	protected virtual OperationCreationResult ToQuestOperation(Player player) { }

}

