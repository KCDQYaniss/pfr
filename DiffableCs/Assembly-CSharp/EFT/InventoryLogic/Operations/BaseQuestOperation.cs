namespace EFT.InventoryLogic.Operations;

public abstract class BaseQuestOperation : AbstractOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <ExecuteInternal>b__0(Task acceptTask) { }

	}

	protected readonly Quest Quest; //Field offset: 0x40
	protected readonly QuestController QuestController; //Field offset: 0x48

	protected BaseQuestOperation(ushort id, ItemController controller, QuestController questController, Quest quest) { }

	protected abstract Task ExecuteAsync() { }

	protected virtual void ExecuteInternal(Callback callback) { }

}

