namespace EFT.Quests;

public sealed class QuestNoteLinkOffer : QuestNoteLinkItemBase
{
	public readonly MongoID TraderId; //Field offset: 0x40
	private readonly FlatItem[] _flatItem; //Field offset: 0x58

	public virtual ELinkedItemType Type
	{
		 get { } //Length: 6
	}

	[JsonConstructor]
	private QuestNoteLinkOffer(MongoID id, MongoID traderId, FlatItem[] item, IEnumerable quests) { }

	protected virtual Item CreateItem() { }

	public virtual ELinkedItemType get_Type() { }

}

