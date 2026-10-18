namespace EFT.UI;

public sealed class QuestsListViewTestDataProvider : MonoBehaviour
{
	[CompilerGenerated]
	private Action TestDataStateChanged; //Field offset: 0x20

	public event Action TestDataStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool ExpandTieredGroups
	{
		 get { } //Length: 3
	}

	public bool UseTestData
	{
		 get { } //Length: 3
	}

	public QuestsListViewTestDataProvider() { }

	[CompilerGenerated]
	public void add_TestDataStateChanged(Action value) { }

	public bool get_ExpandTieredGroups() { }

	public bool get_UseTestData() { }

	[CompilerGenerated]
	public void remove_TestDataStateChanged(Action value) { }

	public void ResetTestData(QuestController questController) { }

	public void TryBegin(QuestController questController, Trader trader) { }

	public void TryEnd(QuestController questController) { }

	public bool TryHandleQuestSelected(QuestListItemView view, QuestListItemView selectedView, QuestView questView, Action applySelection, IEftSession backendSession) { }

}

