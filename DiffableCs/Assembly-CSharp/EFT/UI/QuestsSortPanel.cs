namespace EFT.UI;

public sealed class QuestsSortPanel : BaseSortPanel
{
	internal sealed class QuestSortToButtonDictionary : SerializableEnumDictionary
	{

		public QuestSortToButtonDictionary() { }

	}

	[SerializeField]
	private QuestSortToButtonDictionary _buttons; //Field offset: 0x90

	public QuestsSortPanel() { }

	public void Show(EQuestsSortType defaultSortingType, bool defaultAscending) { }

}

