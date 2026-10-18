namespace EFT.InventoryLogic.Operations;

public sealed class ReadQuestLinkOperation : AbstractOperation
{
	internal sealed class ReadQuestLinkCommand : BaseInventoryCommand
	{
		[JsonProperty("id")]
		public MongoID LinkId; //Field offset: 0x10

		[JsonProperty("Action")]
		public string Action
		{
			 get { } //Length: 49
		}

		public ReadQuestLinkCommand() { }

		public string get_Action() { }

	}

	private readonly QuestNoteLink _link; //Field offset: 0x40
	private readonly Profile _profile; //Field offset: 0x48

	public ReadQuestLinkOperation(ushort id, QuestNoteLink link, Profile profile, ItemController itemController) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

