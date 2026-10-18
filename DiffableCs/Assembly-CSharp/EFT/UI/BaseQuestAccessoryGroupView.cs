namespace EFT.UI;

public abstract class BaseQuestAccessoryGroupView : UIElement
{
	[SerializeField]
	private ETierAccessoryType _tier; //Field offset: 0x70
	[SerializeField]
	private Button _toggleButton; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _title; //Field offset: 0x80
	[SerializeField]
	private QuestTierAccessoryIconView _tierAccessoryIconView; //Field offset: 0x88
	[SerializeField]
	private GameObject _availableToStartIcon; //Field offset: 0x90
	[SerializeField]
	private GameObject _availableToFinishIcon; //Field offset: 0x98
	[SerializeField]
	private GameObject _availableToHandoverIcon; //Field offset: 0xA0
	[SerializeField]
	private GameObject _arrowIcon; //Field offset: 0xA8
	[SerializeField]
	private EUISoundType _expandSound; //Field offset: 0xB0
	protected bool _expanded; //Field offset: 0xB4
	protected IReadOnlyList _excludeFilter; //Field offset: 0xB8
	protected Action _onQuestSelected; //Field offset: 0xC0
	protected QuestController _questController; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnExpandedChanged; //Field offset: 0xD0

	public event Action OnExpandedChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected abstract RectTransform _contentContainer
	{
		 get { } //Length: 0
	}

	public ETierAccessoryType Tier
	{
		 get { } //Length: 4
	}

	protected BaseQuestAccessoryGroupView() { }

	[CompilerGenerated]
	public void add_OnExpandedChanged(Action value) { }

	public override void ApplyFilters(IReadOnlyList excludeFilter) { }

	protected override void Awake() { }

	protected abstract void ClearContentViews() { }

	public virtual void Close() { }

	public void CloseGroup() { }

	protected void DestroySpawnedViews(List views) { }

	public void EnsureExpanded() { }

	protected abstract RectTransform get__contentContainer() { }

	public ETierAccessoryType get_Tier() { }

	protected void HideWhenEmpty() { }

	public void Init(Action onQuestSelected, QuestController questController) { }

	private void PlayExpandSound() { }

	protected abstract void Refresh() { }

	public abstract void RefreshStatusIcons() { }

	protected void RefreshWithContent(bool hasContent, IReadOnlyList questsForStatusIcons) { }

	[CompilerGenerated]
	public void remove_OnExpandedChanged(Action value) { }

	protected abstract void ResetContentState() { }

	protected void SetContentContainerActive(bool active) { }

	public void SetExpanded(bool expanded) { }

	protected void ShowWhenHasContent() { }

	protected abstract void SyncContentContainer() { }

	private void ToggleExpanded() { }

	private void UpdateExpandedArrow() { }

	protected void UpdateStatusIcons(IReadOnlyList quests) { }

}

