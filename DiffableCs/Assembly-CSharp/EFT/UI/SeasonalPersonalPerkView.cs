namespace EFT.UI;

public sealed class SeasonalPersonalPerkView : ToggleButtonFeedback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public PersonalPerk selectedPerk; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <Show>b__0(PersonalPerkData conflictingData) { }

	}

	internal enum ESelectionStatus
	{
		Default = 0,
		Selected = 1,
		Locked = 2,
	}

	private const string PERSONAL_LOCK_TOOLTIP = "Perks/Season/Personal/Tooltip/LockedBy"; //Field offset: 0x0
	private const float LOCKED_CONTENT_ALPHA = 0.35; //Field offset: 0x0
	private const int MAX_TOOLTIP_WIDTH = 400; //Field offset: 0x0
	[SerializeField]
	private NetworkImageView _icon; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _points; //Field offset: 0xC8
	[SerializeField]
	private GameObject _idlePositiveBackground; //Field offset: 0xD0
	[SerializeField]
	private GameObject _idleNegativeBackground; //Field offset: 0xD8
	[SerializeField]
	private GameObject _selectedPositiveBackground; //Field offset: 0xE0
	[SerializeField]
	private GameObject _selectedNegativeBackground; //Field offset: 0xE8
	[SerializeField]
	private GameObject _hoverBackground; //Field offset: 0xF0
	[SerializeField]
	private GameObject _lockedBackground; //Field offset: 0xF8
	[SerializeField]
	private GameObject _lockedFrameObject; //Field offset: 0x100
	[SerializeField]
	private GameObject _notSelectedStatusObject; //Field offset: 0x108
	[SerializeField]
	private GameObject _selectedStatusObject; //Field offset: 0x110
	[SerializeField]
	private GameObject _lockedStatusObject; //Field offset: 0x118
	[SerializeField]
	private CanvasGroup _contentCanvasGroup; //Field offset: 0x120
	private PersonalPerk _perk; //Field offset: 0x128
	private string _lockedTooltipText; //Field offset: 0x130
	private ESelectionStatus _status; //Field offset: 0x138
	private bool _hovered; //Field offset: 0x139
	private bool _readOnly; //Field offset: 0x13A
	private bool _isGoodPerk; //Field offset: 0x13B
	private bool _hasDisplayedPerk; //Field offset: 0x13C
	private MongoID _displayedPerkId; //Field offset: 0x140
	private SimpleTooltip _tooltip; //Field offset: 0x158
	private readonly HashSet _conflictsCache; //Field offset: 0x160
	private readonly BindableEvent _onToggle; //Field offset: 0x168

	protected virtual bool IsToggledOn
	{
		 get { } //Length: 11
	}

	public IBindableEvent OnToggle
	{
		 get { } //Length: 8
	}

	public SeasonalPersonalPerkView() { }

	private void ApplyVisualState(ESelectionStatus state) { }

	public virtual void Close() { }

	protected virtual bool get_IsToggledOn() { }

	public IBindableEvent get_OnToggle() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	public void Show(PersonalPerk perk, IReadOnlyCollection selectedPerks, IImageLoader imageLoader, bool readOnly) { }

	private void ShowPerk(PersonalPerk perk, IImageLoader imageLoader) { }

	private void UpdateStatusObjects(ESelectionStatus state) { }

}

