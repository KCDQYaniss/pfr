namespace EFT.UI;

public sealed class NotesTask : UIElement
{
	private const string DEFAULT_COLOR_KEY = "default"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSelected; //Field offset: 0x70
	[SerializeField]
	private QuestProgressView _progressView; //Field offset: 0x78
	[SerializeField]
	private List _backgroundImages; //Field offset: 0x80
	[SerializeField]
	private List _labels; //Field offset: 0x88
	[SerializeField]
	private Image _statusBackground; //Field offset: 0x90
	[SerializeField]
	private Image _traderAvatar; //Field offset: 0x98
	[SerializeField]
	private Image _typeIcon; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _taskLabel; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _statusLabel; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _locationLabel; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _timerLabel; //Field offset: 0xC0
	[SerializeField]
	private ColorMap _colorMap; //Field offset: 0xC8
	[SerializeField]
	private float _notAvailableAlphaMultiplier; //Field offset: 0xD0
	[SerializeField]
	private GameObject[] _dailyQuestObjects; //Field offset: 0xD8
	[SerializeField]
	private Image ScavBackground; //Field offset: 0xE0
	[SerializeField]
	private NotesTaskFavoriteButton _favoriteButton; //Field offset: 0xE8
	[SerializeField]
	private QuestTierAccessoryIconView _tierAccessoryIcon; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <_isAvailable>k__BackingField; //Field offset: 0xF8
	private readonly Dictionary _labelsColors; //Field offset: 0x100
	private NotesTaskDescriptionShort _taskDescription; //Field offset: 0x108
	private Quest _quest; //Field offset: 0x110
	private IEftSession _session; //Field offset: 0x118
	private InventoryController _inventoryController; //Field offset: 0x120
	private QuestController _questController; //Field offset: 0x128
	private IEnumerator _timerWorker; //Field offset: 0x130
	private bool _inited; //Field offset: 0x138
	private RichTextMarkWrapper[] _reachTextWrappers; //Field offset: 0x140
	private HashSet _activeMarkMask; //Field offset: 0x148

	public event Action OnSelected
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private bool _isAvailable
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public NotesTask() { }

	[CompilerGenerated]
	private void <Init>b__36_0(bool arg) { }

	[CompilerGenerated]
	public void add_OnSelected(Action value) { }

	public virtual void Close() { }

	private void FailDailyQuest() { }

	[CompilerGenerated]
	private bool get__isAvailable() { }

	private Color GetColor(string key) { }

	private void HideTask() { }

	private void Init() { }

	private void OpenTask() { }

	[CompilerGenerated]
	public void remove_OnSelected(Action value) { }

	[CompilerGenerated]
	private void set__isAvailable(bool value) { }

	private void SetBackgroundsColor(Color color) { }

	private void SetLabelsColor(bool selected) { }

	public void SetMarkMask(HashSet mask) { }

	internal void Show(Quest quest, IEftSession session, InventoryController inventoryController, QuestController questController, NotesTaskDescriptionShort description, FavoriteQuestManager favoriteQuests, bool availability) { }

	private void UpdateTimer() { }

}

