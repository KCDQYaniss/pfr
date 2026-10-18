namespace EFT.InventoryLogic.Operations;

public sealed class QuestHandoverOperation : BaseQuestOperation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DestroyedItem <.ctor>b__0_0(ItemsCount item) { }

	}

	private readonly QuestHandoverResult _result; //Field offset: 0x50
	private readonly DestroyedItem[] _handoverItems; //Field offset: 0x58

	internal QuestHandoverOperation(ushort id, QuestHandoverResult result) { }

	public virtual void Dispose() { }

	protected virtual Task ExecuteAsync() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

