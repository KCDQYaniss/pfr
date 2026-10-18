namespace EFT;

public interface IEftSession : IRepairController, IMatchmakerSession, IProfileSession, IBackendSession, IClientSession, ITradingSession, IImageLoader, ISocial, IQuestSession, ILocalizationLoader
{

	public event Action InventoryErrorHappened
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action InventoryWarningHappened
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public float Acceleration
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public ProfileStatus ActivePetStatus
	{
		 get { } //Length: 0
	}

	public IBackendCache Cache
	{
		 get { } //Length: 0
	}

	public EquipmentBuildsStorage EquipmentBuildsStorage
	{
		 get { } //Length: 0
	}

	public FinalsResponse FinalsResponse
	{
		 get { } //Length: 0
	}

	public string LocationTime
	{
		 get { } //Length: 0
	}

	public MagBuildsStorage MagBuildsStorage
	{
		 get { } //Length: 0
	}

	public float ProfilesUpdateTime
	{
		 get { } //Length: 0
	}

	public RagFair RagFair
	{
		 get { } //Length: 0
	}

	public ESeason Season
	{
		 get { } //Length: 0
	}

	public SeasonRanksDataStorage SeasonRankDataStorage
	{
		 get { } //Length: 0
	}

	public SeasonsSettings SeasonsSettings
	{
		 get { } //Length: 0
	}

	public WeaponBuildsStorage WeaponBuildsStorage
	{
		 get { } //Length: 0
	}

	public WeatherNode Weather
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_InventoryErrorHappened(Action value) { }

	[CompilerGenerated]
	public void add_InventoryWarningHappened(Action value) { }

	public void CheckLoginQueue(Callback callback) { }

	public Task CheckVersion() { }

	public Task ClaimSeasonalLeaguesRankReward() { }

	public Task CompleteUpgradeZone(int areaType) { }

	public void ConfigureLobbyRelatedParameters(ClientSettingsConfig config) { }

	public Task ConfirmSeasonalLeaguesRankEnd() { }

	public Task DownloadQuestTraderDialog(MongoID dialogId) { }

	public Task EstablishWSConnection() { }

	public void FindById(long id, Callback callback) { }

	public void FinishCultistsProduction(string schemeId) { }

	public Task FinishScavSession() { }

	public float get_Acceleration() { }

	public ProfileStatus get_ActivePetStatus() { }

	public IBackendCache get_Cache() { }

	public EquipmentBuildsStorage get_EquipmentBuildsStorage() { }

	public FinalsResponse get_FinalsResponse() { }

	public string get_LocationTime() { }

	public MagBuildsStorage get_MagBuildsStorage() { }

	public float get_ProfilesUpdateTime() { }

	public RagFair get_RagFair() { }

	public ESeason get_Season() { }

	public SeasonRanksDataStorage get_SeasonRankDataStorage() { }

	public SeasonsSettings get_SeasonsSettings() { }

	public WeaponBuildsStorage get_WeaponBuildsStorage() { }

	public WeatherNode get_Weather() { }

	public Task GetAreasQte() { }

	public Task GetAreaTemplatesUnparsed() { }

	public Task GetBaseTraderDialogs() { }

	public Task GetBattlePassData() { }

	public Task GetCaptcha() { }

	public Task GetCutscenesSubtitlesData() { }

	public Task GetExpansionsAccessData(string body) { }

	public Task GetExpansionsPlayerData() { }

	public Task GetFinalLocalization(string endingId) { }

	public Task GetFinals() { }

	public AreaInfo[] GetHideoutAreasInfo() { }

	public Task GetHideoutCustomizationOffers() { }

	public Dictionary GetHideoutImprovements() { }

	public Task GetHideoutSettings() { }

	public int GetHideoutShootingRangeScore() { }

	public Task GetLevelSettings() { }

	public Task GetMainQuestSettings() { }

	public void GetMarketPrices(string templateId, Callback callback) { }

	public Task GetOffers(int page, int limit, int sortType, bool direction, int currency, int priceFrom, int priceTo, int quantityFrom, int quantityTo, int conditionFrom, int conditionTo, bool oneHourExpiration, bool removeBartering, int offerOwnerType, bool onlyFunctional, string handbookId, string linkedSearchId, string neededSearchId, Dictionary buildItems, int buildCount, bool updateOfferCount) { }

	[CanBeNull]
	public string GetPhpSessionId() { }

	public Task GetPrestigeSettings() { }

	public Task GetProductionRecipes() { }

	public Task GetProfiles() { }

	[CanBeNull]
	public ProfileStatus GetProfileStatus(bool isPet) { }

	public Task GetProfileVariables() { }

	public Task GetQuestNoteTemplate() { }

	public Task GetSeasonalLeaderboardInfo() { }

	public Task GetSeasonalLeaguesRanks() { }

	public Task GetSeasonalLeaguesState() { }

	public Task GetSeasonalPerks() { }

	public Task GetSeasonalRewards() { }

	public Task GetTapesSubtitlesData() { }

	public Task GetTraderSettings() { }

	public Task GetValidWSToken() { }

	public Task GetWeatherAndTime() { }

	public Task HideoutProductionCancel(string recipeId) { }

	public Task HideoutProductionReset(string recipeId) { }

	public Task IssueWSToken() { }

	public Task LoadGlobalConfig() { }

	public Task LoadProfiles() { }

	public Task LocalRaidEnded(LocalRaidSettings settings, SessionResult results, FlatItem[] lostInsuredItems, Dictionary transferItems) { }

	public Task LocalRaidStarted(LocalRaidSettings settings) { }

	public void MarkSurveyAsViewed(int surveyId) { }

	public Task ObtainFinalReward(string endingId) { }

	public Task ObtainPrestige(PrestigeObtainData[] prestigeObtainData) { }

	public Task ObtainSeasonalReward(MongoID seasonalRewardConfigId) { }

	public bool OfferAlreadyReported(long offerId) { }

	public void PutItemsInAreaSlots(EAreaType areaType, Dictionary items, Callback onComplete) { }

	public void RagfairAddOffer(bool sellInOnePiece, string[] items, BarterTemplate[] requirements, Callback callback) { }

	public void RagfairGetPrices(Callback callback) { }

	public Task RagfairPurchaseOffers(CommoditiesToPurchase commodities) { }

	public void RagfairRemoveOffer(string offerId, Callback callback) { }

	public void RagfairRenewOffer(string offerId, bool priority, int renewalTime, Callback callback) { }

	public void RagfairReportOffer(long offerId, Callback callback) { }

	public Task ReceiveCoopRaidSettings() { }

	public void RefreshPings(int sendPingResultInterval, int pingServersInterval, Callback callback = null) { }

	public void RegisterCaptchaHandler(ICaptchaHandler captchaHandler) { }

	[CompilerGenerated]
	public void remove_InventoryErrorHappened(Action value) { }

	[CompilerGenerated]
	public void remove_InventoryWarningHappened(Action value) { }

	public Task RequestSurvey() { }

	public void RestoreHealth(HealthTreatmentData treatmentData, List cost, string traderId) { }

	public void SendSurveyResult(SurveyAnswersData answerData) { }

	public Task SendTransactionSignRequest(string transactionId) { }

	public void SetDisplayedEnding(string endingId, Callback callback) { }

	public void SetFavoriteItems(IEnumerable items, Callback callback = null) { }

	public void SetHideoutCustomizationItem(MongoID offerId, Callback callback = null) { }

	public void SetHideoutMannequinPose(Dictionary poses, Callback callback = null) { }

	public void SetHideoutShootingRangeScore(int value) { }

	public Task SetMainProfile(Profile profile) { }

	public void SetProfiles(ProfileDescriptor[] profilesData) { }

	public void StartContinuousProduction(string schemeId) { }

	public Task StartCultistsProduction() { }

	public void StartImprovement(string id, EAreaType areaType, IEnumerable items) { }

	public Task StartScavCaseProduction(string schemeId, IEnumerable items, IEnumerable tools) { }

	public void StartSingleProduction(string schemeId, IEnumerable items, IEnumerable tools) { }

	public Task TakeHideoutProduction(string recipeId) { }

	public void TakeItemsFromAreaSlots(EAreaType areaType, int[] slots, Callback callback) { }

	public Task TakeItemsFromAreaSlotsAsync(EAreaType areaType, int[] slots) { }

	public void ToggleArea(EAreaType areaType, bool enabled) { }

	public Task Unpack(string targetItemId, string profileId) { }

	public Task UpgradeZone(int areaType, IEnumerable items) { }

	public Task ValidateCaptcha(IEnumerable items, string captchaType) { }

	public Task WeatherRequest() { }

	public void WorkoutEnded(IEnumerable qtesResult, string qteId, string accountId, Callback callback) { }

}

