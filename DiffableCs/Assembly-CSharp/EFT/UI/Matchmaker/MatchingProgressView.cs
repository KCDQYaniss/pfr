namespace EFT.UI.Matchmaker;

public class MatchingProgressView : UIElement
{
	private const int SERVER_CHECK_SECONDS = 5; //Field offset: 0x0
	private const float UPDATE_INTERVAL = 1; //Field offset: 0x0
	[SerializeField]
	private GameObject _progressBar; //Field offset: 0x70
	[SerializeField]
	private MatchingProgressBarSegmentView _segmentTemplate; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _segmentsRoot; //Field offset: 0x80
	[SerializeField]
	private GameObject _progressBarPlaceHolder; //Field offset: 0x88
	[SerializeField]
	private GameObject _estimateTimeSpinner; //Field offset: 0x90
	[SerializeField]
	private GameObject _warning; //Field offset: 0x98
	[SerializeField]
	private Sprite _warningSprite; //Field offset: 0xA0
	[SerializeField]
	private HoverTrigger _warningHoverTrigger; //Field offset: 0xA8
	[SerializeField]
	[Space(10)]
	private TMP_Text _stageTitle; //Field offset: 0xB0
	[SerializeField]
	private TMP_Text _stageProgress; //Field offset: 0xB8
	[SerializeField]
	private TMP_Text _estimateTimeTitle; //Field offset: 0xC0
	[SerializeField]
	private TMP_Text _loadingOverallTimeTitle; //Field offset: 0xC8
	[SerializeField]
	[Space(10)]
	private Image _loadingTimeGlow; //Field offset: 0xD0
	[SerializeField]
	private Color _loadingTimeGlowColorDefault; //Field offset: 0xD8
	[SerializeField]
	private Color _loadingTimeGlowColorWarning; //Field offset: 0xE8
	[SerializeField]
	private Color _loadingTimeTextColorDefault; //Field offset: 0xF8
	[SerializeField]
	private Color _loadingTimeTextColorWarning; //Field offset: 0x108
	[SerializeField]
	private Color _estimateTimeTextColorWarning; //Field offset: 0x118
	private List _segments; //Field offset: 0x128
	private MatchingProgress _matchingProgress; //Field offset: 0x130
	private DateTime _lastUpdateTime; //Field offset: 0x138
	private TimeSpan _lastServerCheck; //Field offset: 0x140
	private Nullable _matchingWarningType; //Field offset: 0x148
	private CompoundTooltip _warningTooltip; //Field offset: 0x150
	private List _warningTooltipTextData; //Field offset: 0x158
	private bool _serversLimited; //Field offset: 0x160
	private bool _canUpdateStatus; //Field offset: 0x161
	private int _maxMatchingTimeInSeconds; //Field offset: 0x164

	public MatchingProgressView() { }

	[CompilerGenerated]
	private void <Awake>b__30_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__30_1(PointerEventData arg) { }

	private void Awake() { }

	private void CreateSegments() { }

	private static string GetProgressText(Nullable currentStageProgress, bool isGameLeavingStage) { }

	private void SetActiveGroup(int groupIndex) { }

	public void SetMatchingProgress(MatchingProgress matchingProgress) { }

	public void Show(MatchingProgress matchingProgress, int maxMatchingTimeInSeconds) { }

	private void UpdateEstimateTime(Nullable estimateTime, bool longTimeWaiting, bool delayed, bool isGameLeaving) { }

	private void UpdateLoadingTime(TimeSpan passedTime, bool delayed, bool isGameLeaving) { }

	public void UpdateStatus() { }

	public void UpdateTime(ERaidMode raidMode, bool isSearchingForGame, bool serversLimited) { }

	private void UpdateWarningState(bool serversLimited, bool longTimeWaiting, bool delayed, bool isGameLeavingStage) { }

	private void UpdateWarningText(Nullable matchingWarningType) { }

}

