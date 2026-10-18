namespace EFT.UI;

public sealed class MenuUI : MonoBehaviourSingleton
{
	public TraderScreensGroup TraderScreensGroup; //Field offset: 0x20
	public TradingScreen TradingScreen; //Field offset: 0x28
	public MatchMakerSideSelectionScreen MatchMakerSideSelectionScreen; //Field offset: 0x30
	public MatchMakerSelectionLocationScreen MatchMakerSelectionLocationScreen; //Field offset: 0x38
	public MatchmakerKeyAccessScreen MatchmakerKeyAccessScreen; //Field offset: 0x40
	public MatchmakerMapPointsScreen MatchmakerMapPoints; //Field offset: 0x48
	public MatchMakerAcceptScreen MatchMakerAcceptScreen; //Field offset: 0x50
	public MatchmakerInsuranceScreen MatchmakerInsuranceScreen; //Field offset: 0x58
	public MatchmakerTimeHasCome MatchmakerTimeHasCome; //Field offset: 0x60
	public MatchmakerOfflineRaidScreen MatchmakerOfflineRaidScreen; //Field offset: 0x68
	public MatchmakerFinalCountdown MatchmakerFinalCountdown; //Field offset: 0x70
	public MatchmakerIntroVideoScreen MatchmakerIntroVideoScreen; //Field offset: 0x78
	public OperationQueueIndicator OperationQueueIndicator; //Field offset: 0x80
	public HideoutAreaTransferItemsScreen HideoutAreaTransferItemsScreen; //Field offset: 0x88
	public EquipmentBuildsScreen EquipmentBuildsScreen; //Field offset: 0x90
	public OtherPlayerProfileScreen OtherPlayerProfileScreen; //Field offset: 0x98
	public NewsHubScreen NewsHubScreen; //Field offset: 0xA0
	public HideoutMannequinEquipmentScreen HideoutMannequinEquipmentScreen; //Field offset: 0xA8
	public HideoutCircleOfCultistsScreen HideoutCircleOfCultistsScreen; //Field offset: 0xB0
	public ObtainPrestigeScreen ObtainPrestigeScreen; //Field offset: 0xB8
	public FinalStatisticsScreen FinalStatisticsScreen; //Field offset: 0xC0
	public EventDialogScreen EventDialogScreen; //Field offset: 0xC8
	public SeasonsHubScreen SeasonsHubScreen; //Field offset: 0xD0
	public SeasonsIntroScreen SeasonsIntroScreen; //Field offset: 0xD8
	public SeasonsLeaguesTutorialScreen SeasonsLeaderboardTutorialScreen; //Field offset: 0xE0
	public SeasonsChangeRankScreen SeasonsChangeRankScreen; //Field offset: 0xE8
	public CharacterSelectionScreen CharacterSelectionScreen; //Field offset: 0xF0

	public MenuUI() { }

	public virtual void Awake() { }

	public virtual void OnDestroy() { }

}

