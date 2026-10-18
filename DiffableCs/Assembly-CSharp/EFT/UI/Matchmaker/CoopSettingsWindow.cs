namespace EFT.UI.Matchmaker;

public sealed class CoopSettingsWindow : BaseUiWindow
{
	[SerializeField]
	private MatchmakerRaidSettingsSummaryView _summaryView; //Field offset: 0x80

	public CoopSettingsWindow() { }

	public void Show(RaidSettings raidSettings) { }

}

