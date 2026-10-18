namespace EFT.InventoryLogic.Operations;

public sealed class ReadQuestConditionOperation : AbstractOperation
{
	internal sealed class ReadQuestConditionCommand : BaseInventoryCommand
	{
		[JsonProperty("id")]
		public MongoID ConditionId; //Field offset: 0x10

		[JsonProperty("Action")]
		public string Action
		{
			 get { } //Length: 49
		}

		public ReadQuestConditionCommand() { }

		public string get_Action() { }

	}

	private readonly Condition _condition; //Field offset: 0x40
	private readonly Profile _profile; //Field offset: 0x48

	public ReadQuestConditionOperation(ushort id, Condition condition, Profile profile, ItemController itemController) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

