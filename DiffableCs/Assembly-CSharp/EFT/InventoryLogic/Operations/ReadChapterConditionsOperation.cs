namespace EFT.InventoryLogic.Operations;

public sealed class ReadChapterConditionsOperation : AbstractOperation
{
	[Flags]
	internal enum EChapterConditionType
	{
		Main = 1,
		Optional = 2,
		All = 3,
	}

	internal sealed class ReadChapterConditionsCommand : BaseInventoryCommand
	{
		[JsonProperty("id")]
		public MongoID ConditionId; //Field offset: 0x10

		[JsonProperty("Action")]
		public string Action
		{
			 get { } //Length: 49
		}

		public ReadChapterConditionsCommand() { }

		public string get_Action() { }

	}

	private readonly QuestChapter _chapter; //Field offset: 0x40
	private readonly Profile _profile; //Field offset: 0x48
	private readonly EChapterConditionType _type; //Field offset: 0x50
	private readonly List _unreadConditions; //Field offset: 0x58

	public ReadChapterConditionsOperation(ushort id, QuestChapter chapter, Profile profile, ItemController itemController, QuestBook questBook, EChapterConditionType type) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual IEnumerable ToBaseInventoryCommands(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

