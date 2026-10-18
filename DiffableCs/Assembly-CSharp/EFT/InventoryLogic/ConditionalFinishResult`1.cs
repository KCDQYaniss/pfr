namespace EFT.InventoryLogic;

public sealed class ConditionalFinishResult`1 : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IDialogLineActionResult
{
	internal sealed class FinishQuestInventoryCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x0
		[JsonProperty("qid")]
		public string QuestId; //Field offset: 0x0
		[JsonProperty("removeExcessItems")]
		public bool RemoveExcessItems; //Field offset: 0x0
		[JsonProperty("type", NullValueHandling = NullValueHandling::Ignore (1))]
		public string Type; //Field offset: 0x0

		public virtual bool Queued
		{
			 get { } //Length: 3
		}

		public FinishQuestInventoryCommand(string questId, bool isRepeatable, bool removeExcessItems = true) { }

		public virtual bool get_Queued() { }

	}

	public readonly TConditional Conditional; //Field offset: 0x0
	public readonly ConditionalController ConditionalController; //Field offset: 0x0
	public readonly IReadOnlyList Rewards; //Field offset: 0x0
	public readonly ItemController ItemController; //Field offset: 0x0
	private readonly int _totalCloneCount; //Field offset: 0x0

	public ConditionalFinishResult`1(TConditional conditional, ConditionalController conditionalController, ItemController itemController, IReadOnlyList rewards, int totalCloneCount) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override BaseInventoryCommand GetBaseInventoryCommand() { }

	public override Task LoadBundles() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public override InventoryOperationDescriptor ToDescriptor(IOperationInfo operation) { }

}

