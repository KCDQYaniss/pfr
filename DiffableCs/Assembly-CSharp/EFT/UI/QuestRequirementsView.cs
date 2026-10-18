namespace EFT.UI;

public class QuestRequirementsView : UIElement
{
	[SerializeField]
	private QuestRequirementView _itemPrefab; //Field offset: 0x70
	[SerializeField]
	private GameObject _requirementsLabel; //Field offset: 0x78
	[SerializeField]
	private Transform _container; //Field offset: 0x80
	private UiElementPool _pool; //Field offset: 0x88
	private QuestBook _currentQuestBook; //Field offset: 0x90
	private Quest _currentQuest; //Field offset: 0x98

	public QuestRequirementsView() { }

	[CompilerGenerated]
	private void <Show>b__6_0() { }

	public void Show(QuestBook questBook, Quest quest, ConditionCollection conditions) { }

}

