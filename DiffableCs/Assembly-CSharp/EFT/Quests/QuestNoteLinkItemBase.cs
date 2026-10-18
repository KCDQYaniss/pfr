namespace EFT.Quests;

public abstract class QuestNoteLinkItemBase : QuestNoteLink
{
	private Item _item; //Field offset: 0x30
	private ItemController _controller; //Field offset: 0x38

	public ItemController Controller
	{
		 get { } //Length: 26
	}

	public Item Item
	{
		 get { } //Length: 26
	}

	protected QuestNoteLinkItemBase(MongoID id, IEnumerable quests) { }

	protected abstract Item CreateItem() { }

	private void CreateItemAndController() { }

	public ItemController get_Controller() { }

	public Item get_Item() { }

}

