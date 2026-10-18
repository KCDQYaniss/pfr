namespace EFT.Quests;

public sealed class QuestNoteLinkCraft : QuestNoteLinkItemBase
{
	public readonly EAreaType Area; //Field offset: 0x40
	private readonly FlatItem[] _flatItem; //Field offset: 0x48

	public virtual ELinkedItemType Type
	{
		 get { } //Length: 6
	}

	[JsonConstructor]
	private QuestNoteLinkCraft(MongoID id, EAreaType area, FlatItem[] item, IEnumerable quests) { }

	protected virtual Item CreateItem() { }

	public virtual ELinkedItemType get_Type() { }

}

