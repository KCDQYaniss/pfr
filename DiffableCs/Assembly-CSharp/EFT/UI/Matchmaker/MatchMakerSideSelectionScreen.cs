namespace EFT.UI.Matchmaker;

public sealed class MatchMakerSideSelectionScreen : MatchmakerEftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__41_0; //Field offset: 0x8
		public static Action <>9__44_0; //Field offset: 0x10
		public static Action <>9__44_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal double <get_GroupScavsLastTime>b__41_0(RaidPlayer player) { }

		internal void <Show>b__44_0() { }

		internal void <Show>b__44_1() { }

	}

	private enum EScavLockReason
	{
		None = 0,
		ScavNotReadySolo = 1,
		ScavNotReadyGroup = 2,
		OnlineBan = 3,
		GroupTooBig = 4,
	}

	internal sealed class RaidSideSelectionScreenController : EftMatchmakerScreenController
	{
		public readonly IEftSession Session; //Field offset: 0x78
		public readonly RaidSettings RaidSettings; //Field offset: 0x80
		public readonly IHealthController HealthController; //Field offset: 0x88
		public readonly InventoryController InventoryController; //Field offset: 0x90

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public RaidSideSelectionScreenController(IEftSession session, ref RaidSettings raidSettings, IHealthController healthController, InventoryController inventoryController, MatchmakerPlayersController matchmakerController) { }

		public virtual bool get_KeyScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

		public void UpdateSideSelection(ESideType side) { }

	}

	private const float CALL_DELAY = 0.25; //Field offset: 0x0
	private const float WARNING_FADE_SPEED = 0.3; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB8
	[SerializeField]
	private TMP_Text _savageBlockMessage; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _sideDescriptionText; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _savageBlocker; //Field offset: 0xD0
	[SerializeField]
	private CanvasGroup _lowHealthWarning; //Field offset: 0xD8
	[SerializeField]
	private CanvasGroup _notFullHealthWarning; //Field offset: 0xE0
	[SerializeField]
	private UIAnimatedToggleSpawner _randomButton; //Field offset: 0xE8
	[SerializeField]
	private UIAnimatedToggleSpawner _savagesButton; //Field offset: 0xF0
	[SerializeField]
	private UIAnimatedToggleSpawner _pmcButton; //Field offset: 0xF8
	[SerializeField]
	private Button _savagesBigButton; //Field offset: 0x100
	[SerializeField]
	private Button _pmcBigButton; //Field offset: 0x108
	[SerializeField]
	private PlayerModelView _pmcModelView; //Field offset: 0x110
	[SerializeField]
	private PlayerModelView _savageModelView; //Field offset: 0x118
	[SerializeField]
	private InventoryScreenHealthPanel _healthPanel; //Field offset: 0x120
	[SerializeField]
	private Image _randomIcon; //Field offset: 0x128
	[SerializeField]
	private Light _mainLight; //Field offset: 0x130
	[SerializeField]
	private Light _hairLight; //Field offset: 0x138
	[SerializeField]
	private Light _downLight; //Field offset: 0x140
	private DateTime _lastUpdate; //Field offset: 0x148
	private Profile _profile; //Field offset: 0x150
	private Profile _savageProfile; //Field offset: 0x158
	private ESideType _sideType; //Field offset: 0x160
	private IHealthController _healthController; //Field offset: 0x168
	private InventoryController _inventoryController; //Field offset: 0x170
	private bool _healthIsLow; //Field offset: 0x178
	private bool _healthPanelVisibility; //Field offset: 0x179
	private CanvasGroup _healthPanelCanvasGroup; //Field offset: 0x180
	private bool _scavDisabled; //Field offset: 0x188
	private readonly Dictionary _visibilityTargets; //Field offset: 0x190

	private static Color32 DefaultHairLightColor
	{
		private get { } //Length: 13
	}

	private double GroupScavsLastTime
	{
		private get { } //Length: 403
	}

	private bool ScavAvailable
	{
		private get { } //Length: 330
	}

	private double ScavLockTime
	{
		private get { } //Length: 215
	}

	public MatchMakerSideSelectionScreen() { }

	[CompilerGenerated]
	private void <Awake>b__42_0(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__42_1(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__42_2(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__42_3() { }

	[CompilerGenerated]
	private void <Awake>b__42_4() { }

	[CompilerGenerated]
	private void <Awake>b__42_5() { }

	[CompilerGenerated]
	private void <Awake>b__42_6() { }

	[CompilerGenerated]
	private void <Show>b__44_2() { }

	private void Awake() { }

	private void BanChangedHandler(EBanType banType = 4) { }

	public virtual void Close() { }

	private static Color32 get_DefaultHairLightColor() { }

	private double get_GroupScavsLastTime() { }

	private bool get_ScavAvailable() { }

	private double get_ScavLockTime() { }

	private EScavLockReason GetScavBlockReason() { }

	private void OnPMCPointerEnter(BaseEventData eventData = null) { }

	private void OnPMCPointerExit(BaseEventData eventData = null) { }

	private void SetHealthPanelVisibility(bool visibility, bool instantly = false) { }

	private void SetObjectVisibility(CanvasGroup warning, bool visibility, bool instantly = false) { }

	private void SetScavAvailable() { }

	private void SetSelectedSide(ESideType side) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private void Show(IEftSession session, RaidSettings raidSettings, IHealthController healthController, InventoryController inventoryController) { }

	public virtual void Show(RaidSideSelectionScreenController controller) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

