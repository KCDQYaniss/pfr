namespace EFT.UI;

public sealed class CharacterSelectionSlotViewSeason : CharacterSelectionSlotViewBase
{
	private const string MODE_TYPE_SEASONAL_KEY = "CharacterSelection/ModeType/Seasonal"; //Field offset: 0x0
	[Header("Seasonal UI References")]
	[SerializeField]
	private DefaultUiButtonNewStyle _seasonInfoButton; //Field offset: 0x1A8
	[SerializeField]
	private CharacterSelectionSeasonPanel _seasonPanel; //Field offset: 0x1B0
	[SerializeField]
	private SeasonRankView _seasonRankView; //Field offset: 0x1B8
	[SerializeField]
	private RectTransform _infoPanel; //Field offset: 0x1C0
	[Header("Seasonal Panel Animation")]
	[SerializeField]
	private float _infoPanelClosedY; //Field offset: 0x1C8
	[SerializeField]
	private float _infoPanelOpenedY; //Field offset: 0x1CC
	[Header("Seasonal Panel Animation Settings")]
	[SerializeField]
	private float _hoverAnimationDuration; //Field offset: 0x1D0
	[SerializeField]
	private Ease _hoverAnimationEase; //Field offset: 0x1D4
	private Tween _hoverTween; //Field offset: 0x1D8
	private bool _hasSeasonHover; //Field offset: 0x1E0
	private bool _infoButtonHovered; //Field offset: 0x1E1
	private SeasonalPerksData _seasonalPerks; //Field offset: 0x1E8
	private string _modeTypeText; //Field offset: 0x1F0
	private DateTime _seasonEndTimeUtc; //Field offset: 0x1F8
	private DateTime _lastCountdownUpdateUtc; //Field offset: 0x200
	private bool _countdownActive; //Field offset: 0x208
	[CompilerGenerated]
	private Action SeasonInfoRequested; //Field offset: 0x210

	public event Action SeasonInfoRequested
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public CharacterSelectionSlotViewSeason() { }

	[CompilerGenerated]
	public void add_SeasonInfoRequested(Action value) { }

	private void OnSeasonInfoButtonPointerEnter() { }

	private void OnSeasonInfoButtonPointerExit() { }

	private void OnSeasonInfoButtonPressed() { }

	protected virtual void RefreshHoverState(bool hovered, bool forced = false) { }

	protected virtual void RefreshModeSpecificState(EGameMode gameMode, CharacterSelectionProfileData profileData) { }

	[CompilerGenerated]
	public void remove_SeasonInfoRequested(Action value) { }

	protected virtual void ResetModeSpecificState() { }

	public void SetSeasonalPerks(SeasonalPerksData seasonalPerks) { }

	private void SetupSeasonCountdown(CharacterSelectionSeasonInfo seasonInfo) { }

	private static bool TryResolveSeasonEnd(CharacterSelectionSeasonInfo seasonInfo, out DateTime endUtc) { }

	private void Update() { }

	private void UpdateSeasonCountdown(DateTime now) { }

}

