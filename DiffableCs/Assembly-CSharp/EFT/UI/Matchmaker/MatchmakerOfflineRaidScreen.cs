namespace EFT.UI.Matchmaker;

public sealed class MatchmakerOfflineRaidScreen : MatchmakerEftScreen
{
	internal sealed class OfflineRaidScreenController : EftMatchmakerScreenController
	{
		public readonly ProfileInfo ProfileInfo; //Field offset: 0x78
		public readonly RaidSettings RaidSettings; //Field offset: 0x80
		public readonly RaidSettings OfflineRaidSettings; //Field offset: 0x88

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public OfflineRaidScreenController(ProfileInfo profileInfo, ref RaidSettings raidSettings, ref RaidSettings offlineRaidSettings, MatchmakerPlayersController matchmakerPlayersController, EGameMode gameMode) { }

		public virtual bool get_KeyScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	[SerializeField]
	private UpdatableToggle _offlineModeToggle; //Field offset: 0xB0
	[SerializeField]
	private UiElementBlocker _onlineBlocker; //Field offset: 0xB8
	[SerializeField]
	private RaidSettingsWindow _raidSettingsWindow; //Field offset: 0xC0
	[SerializeField]
	private MatchmakerRaidSettingsSummaryView _raidSettingsSummaryView; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _changeSettingsButton; //Field offset: 0xD0
	[SerializeField]
	private DefaultUIButton _nextButtonSpawner; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _backButtonSpawner; //Field offset: 0xE0
	[SerializeField]
	private DefaultUIButton _readyButton; //Field offset: 0xE8
	private ProfileInfo _profileInfo; //Field offset: 0xF0
	private RaidSettings _raidSettings; //Field offset: 0xF8
	private RaidSettings _offlineRaidSettings; //Field offset: 0x100
	private ProfileBan _onlineBan; //Field offset: 0x108

	public MatchmakerOfflineRaidScreen() { }

	[CompilerGenerated]
	private void <Show>b__15_0() { }

	private void Awake() { }

	private void BanChangedHandler(EBanType banType = 4) { }

	private void CheckCoopGameAvailable() { }

	public virtual void Close() { }

	private bool IsOfflineModeUnavailableForLocation() { }

	private void OnBackButtonClicked() { }

	private void OnNextButtonClicked() { }

	private void OnReadyButtonClicked() { }

	private void RaidSettingsChangedHandler() { }

	private void SetGameConfiguration(bool value) { }

	private void SetRaidMode(bool isToggleOn) { }

	public virtual void Show(OfflineRaidScreenController controller) { }

	private void Show(ProfileInfo profileInfo, RaidSettings raidSettings, RaidSettings offlineRaidSettings) { }

	private void ShowRaidSettingsWindow() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

