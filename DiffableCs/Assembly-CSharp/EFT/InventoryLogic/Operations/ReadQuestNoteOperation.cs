namespace EFT.InventoryLogic.Operations;

public sealed class ReadQuestNoteOperation : AbstractOperation
{
	internal sealed class ReadQuestNoteCommand : BaseInventoryCommand
	{
		[JsonProperty("noteId")]
		public MongoID NoteId; //Field offset: 0x10

		[JsonProperty("Action")]
		public string Action
		{
			 get { } //Length: 49
		}

		public ReadQuestNoteCommand() { }

		public string get_Action() { }

	}

	private readonly QuestNote _note; //Field offset: 0x40
	private readonly Profile _profile; //Field offset: 0x48

	public ReadQuestNoteOperation(ushort id, QuestNote note, Profile profile, ItemController itemController) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

