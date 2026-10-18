namespace EFT.UI.Quests;

public sealed class MainQuestTaskView : UIElement
{
	private enum EConditionStatus
	{
		Active = 0,
		Completed = 1,
		Incomplete = 2,
		Failed = 3,
		Skipped = 4,
	}

	[SerializeField]
	private Graphic _checkMarkBorder; //Field offset: 0x70
	[SerializeField]
	private Graphic _checkMark; //Field offset: 0x78
	[SerializeField]
	private Graphic _crossMark; //Field offset: 0x80
	[SerializeField]
	private Graphic _skipMark; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _descriptionField; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _titleField; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _counterField; //Field offset: 0xA0
	[SerializeField]
	private QuestObjectiveView _conditionView; //Field offset: 0xA8
	[SerializeField]
	private DialogButtonsContainer _dialogButtonsContainer; //Field offset: 0xB0
	[SerializeField]
	private Color32 _activeColor; //Field offset: 0xB8
	[SerializeField]
	private Color32 _finishedColor; //Field offset: 0xBC
	[SerializeField]
	private Color32 _failedColor; //Field offset: 0xC0
	[SerializeField]
	private Color32 _inactiveColor; //Field offset: 0xC4
	private MainQuest _quest; //Field offset: 0xC8
	private QuestChapter _chapter; //Field offset: 0xD0
	private Condition _condition; //Field offset: 0xD8
	private QuestController _questController; //Field offset: 0xE0
	private ConditionProgressChecker _progressChecker; //Field offset: 0xE8
	private IChaptersViewController _viewController; //Field offset: 0xF0
	[CompilerGenerated]
	private EConditionStatus <Status>k__BackingField; //Field offset: 0xF8

	private EConditionStatus Status
	{
		[CompilerGenerated]
		private get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public MainQuestTaskView() { }

	[CompilerGenerated]
	private void <InitVisitTraderButton>b__29_0(DialogStartData dialogData) { }

	[CompilerGenerated]
	private void <Show>b__24_0() { }

	private void ConditionChangeHandler(Conditional _) { }

	[CompilerGenerated]
	private EConditionStatus get_Status() { }

	private void InitVisitTraderButton() { }

	private void ProgressChangeHandler(ConditionProgressChecker _) { }

	[CompilerGenerated]
	private void set_Status(EConditionStatus value) { }

	private void SetColor(Color32 color) { }

	public void Show(MainQuest quest, Condition condition, IChaptersViewController viewController) { }

	private void StatusChangeHandler(Quest quest, bool _) { }

	private void UpdateConditionStatus() { }

	private void UpdateText() { }

	private void UpdateVisibility() { }

	private void UpdateVisitTraderButtonVisibility() { }

}

