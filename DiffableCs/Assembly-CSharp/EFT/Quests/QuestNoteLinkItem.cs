namespace EFT.Quests;

public sealed class QuestNoteLinkItem : QuestNoteLinkItemBase
{
	private readonly MongoID _templateID; //Field offset: 0x40

	public virtual ELinkedItemType Type
	{
		 get { } //Length: 3
	}

	[JsonConstructor]
	private QuestNoteLinkItem(MongoID id, MongoID templateId, IEnumerable quests) { }

	protected virtual Item CreateItem() { }

	public virtual ELinkedItemType get_Type() { }

}

