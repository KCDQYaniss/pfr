namespace EFT.Quests;

public abstract class QuestNoteLink
{
	internal enum ELinkedItemType
	{
		Item = 0,
		Craft = 1,
		Offer = 2,
	}

	public readonly MongoID Id; //Field offset: 0x10
	public readonly IEnumerable Quests; //Field offset: 0x28

	public abstract ELinkedItemType Type
	{
		 get { } //Length: 0
	}

	protected QuestNoteLink(MongoID id, IEnumerable quests) { }

	public abstract ELinkedItemType get_Type() { }

}

