namespace EFT.UI;

public abstract class ObjectiveView`1 : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0`1
	{
		public TConditional conditional; //Field offset: 0x0
		public Condition condition; //Field offset: 0x0

		public <>c__DisplayClass23_0`1() { }

		internal EQuestStatus <ShowObjective>b__0() { }

		internal bool <ShowObjective>b__1() { }

	}

	private const string GroupProgressTooltipKey = "QuestCondition/GroupProgressTooltip"; //Field offset: 0x0
	private Func _isDone; //Field offset: 0x0
	private Func _getQuestStatus; //Field offset: 0x0
	protected ItemController Controller; //Field offset: 0x0
	protected Profile Profile; //Field offset: 0x0
	protected ConditionProgressChecker ConditionProgressChecker; //Field offset: 0x0
	protected Condition Condition; //Field offset: 0x0
	protected BindableViewList ViewList; //Field offset: 0x0
	[SerializeField]
	protected RectTransform _container; //Field offset: 0x0
	[SerializeField]
	protected TObjectiveView _childObjectivePrefab; //Field offset: 0x0
	[SerializeField]
	private ColorMap _backColors; //Field offset: 0x0
	[SerializeField]
	private Image _back; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _counter; //Field offset: 0x0
	[SerializeField]
	private Image _doneIcon; //Field offset: 0x0
	[SerializeField]
	private GameObject _progressBlock; //Field offset: 0x0
	[SerializeField]
	private Image _progress; //Field offset: 0x0
	[SerializeField]
	private HoverTooltipArea _groupIconTooltip; //Field offset: 0x0
	[SerializeField]
	private Image _groupIcon; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x0
	[SerializeField]
	private Image _icon; //Field offset: 0x0
	private Func _isConditionDone; //Field offset: 0x0
	private bool _isMainQuest; //Field offset: 0x0

	protected ObjectiveView`1() { }

	protected override void Awake() { }

	public virtual void Close() { }

	protected abstract void CreateViewList() { }

	private void DisableGroupIconTooltip() { }

	private void EnableGroupIconTooltip() { }

	protected override void OnConditionChanged(ConditionProgressChecker conditionProgressChecker) { }

	private void OnConditionChangedProgressChecker(ConditionProgressChecker conditionProgressChecker) { }

	protected void ShowObjective(TConditional conditional, Condition condition, Profile profile, ItemController controller, Sprite icon, bool childCondition, string prefix) { }

	private void UpdateGroupIcon() { }

}

