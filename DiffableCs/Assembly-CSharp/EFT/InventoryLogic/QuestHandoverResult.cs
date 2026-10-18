namespace EFT.InventoryLogic;

public sealed class QuestHandoverResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IDialogLineActionResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__14_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal DestroyedItem <GetBaseInventoryCommand>b__14_0(ItemsCount item) { }

		internal DestroyedItem <ToDescriptor>b__11_0(ItemsCount item) { }

	}

	internal class QuestHandoverInventoryCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[JsonProperty("qid")]
		public string QuestId; //Field offset: 0x18
		[JsonProperty("conditionId")]
		public MongoID ConditionId; //Field offset: 0x20
		[JsonProperty("items")]
		public DestroyedItem[] Items; //Field offset: 0x38

		public virtual bool Queued
		{
			 get { } //Length: 3
		}

		public QuestHandoverInventoryCommand(string questId, MongoID conditionId, DestroyedItem[] items) { }

		public virtual bool get_Queued() { }

	}

	public readonly Quest Quest; //Field offset: 0x10
	public readonly QuestController QuestController; //Field offset: 0x18
	public readonly IReadOnlyCollection Items; //Field offset: 0x20
	public readonly ConditionItem Condition; //Field offset: 0x28
	public readonly ItemController ItemController; //Field offset: 0x30
	private readonly IReadOnlyList _removeResults; //Field offset: 0x38

	public QuestHandoverResult(Quest quest, QuestController questController, IReadOnlyCollection items, ConditionItem condition, IReadOnlyList removeResults, ItemController itemController) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override BaseInventoryCommand GetBaseInventoryCommand() { }

	public override Task LoadBundles() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public override InventoryOperationDescriptor ToDescriptor(IOperationInfo operation) { }

}

