namespace EFT.InventoryLogic;

public sealed class QuestAcceptResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IDialogLineActionResult
{
	internal sealed class AcceptQuestInventoryCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[JsonProperty("qid")]
		public string QuestId; //Field offset: 0x18
		[JsonProperty("type", NullValueHandling = NullValueHandling::Ignore (1))]
		public string Type; //Field offset: 0x20

		public virtual bool Queued
		{
			 get { } //Length: 3
		}

		public AcceptQuestInventoryCommand(string questId, bool isRepeatable) { }

		public virtual bool get_Queued() { }

	}

	public readonly Quest Quest; //Field offset: 0x10
	public readonly QuestController QuestController; //Field offset: 0x18

	public QuestAcceptResult(Quest quest, QuestController questController) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override BaseInventoryCommand GetBaseInventoryCommand() { }

	public override Task LoadBundles() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public override InventoryOperationDescriptor ToDescriptor(IOperationInfo operation) { }

}

