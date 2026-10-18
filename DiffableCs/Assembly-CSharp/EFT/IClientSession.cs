namespace EFT;

public interface IClientSession : IBackendSession, ITradingSession, IImageLoader, ISocial, IProfileSession, IQuestSession
{

	public event Action OnLobbyPushNotificationReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnSessionError
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CanBeNull]
	public ProfileStatus ActiveProfileStatus
	{
		 get { } //Length: 0
	}

	public Profile[] AllProfiles
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public ProfileStatus[] AllProfileStatus
	{
		 get { } //Length: 0
	}

	public GlobalConfigurationResponse BackEndConfig
	{
		 get { } //Length: 0
	}

	public Action ExamineRequestFailed
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public EGameMode GameMode
	{
		 get { } //Length: 0
	}

	public GameModeDescriptor GameModeDescriptor
	{
		 get { } //Length: 0
	}

	public GameServerPing[] GameServers
	{
		 get { } //Length: 0
	}

	public bool IsFlushing
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsGameSynced
	{
		 get { } //Length: 0
	}

	public bool IsLobbyConnectionEstablished
	{
		 get { } //Length: 0
	}

	public PlayerVisualRepresentation LastPlayerState
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ProfileStats LastPlayerStats
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool LimitedServersAvailability
	{
		 get { } //Length: 0
	}

	public LocationSettings LocationSettings
	{
		 get { } //Length: 0
	}

	public CountersCollection OverallAccountStats
	{
		 get { } //Length: 0
	}

	public Dictionary PurchasedGames
	{
		 get { } //Length: 0
	}

	public EOperationQueueStatus QueueStatus
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public BindableEvent QueueStatusChanged
	{
		 get { } //Length: 0
	}

	public long TotalInGameTime
	{
		 get { } //Length: 0
	}

	public void AbortMatching(bool isPet, Callback callback, bool ignoreCallbacks = false) { }

	[CompilerGenerated]
	public void add_OnLobbyPushNotificationReceived(Action value) { }

	[CompilerGenerated]
	public void add_OnSessionError(Action value) { }

	public Task ApplyCustomization(IEnumerable customizations) { }

	public Task CancelGameSearching(bool isPet) { }

	public void ChangeNickname(string profileId, string nickname, Callback callback) { }

	public void ChangeProfileStatus(ProfileStatus status) { }

	public void ClearProfileUpdaters() { }

	public void CreateNotifierChannel(Callback callback) { }

	public Task CreateProfile(EPlayerSide profileSide, string profileNickname, string headId, string voiceId, IReadOnlyCollection selectedPerkIds) { }

	public Task Destroy() { }

	public Task FlushOperationQueue() { }

	public ProfileStatus get_ActiveProfileStatus() { }

	public Profile[] get_AllProfiles() { }

	public ProfileStatus[] get_AllProfileStatus() { }

	public GlobalConfigurationResponse get_BackEndConfig() { }

	public Action get_ExamineRequestFailed() { }

	public EGameMode get_GameMode() { }

	public GameModeDescriptor get_GameModeDescriptor() { }

	public GameServerPing[] get_GameServers() { }

	public bool get_IsFlushing() { }

	public bool get_IsGameSynced() { }

	public bool get_IsLobbyConnectionEstablished() { }

	public PlayerVisualRepresentation get_LastPlayerState() { }

	public ProfileStats get_LastPlayerStats() { }

	public bool get_LimitedServersAvailability() { }

	public LocationSettings get_LocationSettings() { }

	public CountersCollection get_OverallAccountStats() { }

	public Dictionary get_PurchasedGames() { }

	public EOperationQueueStatus get_QueueStatus() { }

	public BindableEvent get_QueueStatusChanged() { }

	public long get_TotalInGameTime() { }

	public Task GetAvailableCustomizationsStorage() { }

	public Task GetClientSettingsConfig() { }

	public Task GetGlobalConfig() { }

	public Task GetMetricsConfig() { }

	public Profile GetProfileBySide(ESideType side) { }

	public Task GetReservedNickname() { }

	public string GetSessionId(bool isPet) { }

	public Task GetTutorialInfo(bool skipTutorial = false) { }

	public Task GetTutorialProfile() { }

	public Task IsMatchingAvailable() { }

	public Task LoadBots(List limit) { }

	public Task Logout() { }

	public void ReadEncyclopedia(string[] ids, Callback callback) { }

	public void RefreshProfileStatuses(bool isPet, Callback callback = null) { }

	public void RegisterProfileUpdater(string profileId, IProfileUpdatesHandler profileUpdater) { }

	[CompilerGenerated]
	public void remove_OnLobbyPushNotificationReceived(Action value) { }

	[CompilerGenerated]
	public void remove_OnSessionError(Action value) { }

	public Task RemoveBuild(MongoID id) { }

	public Task RequestBuilds() { }

	public Task RequestHandbookInfo(HandbookInfo returnInCaseOfCache = null) { }

	public Task SaveEquipmentBuild(MongoID id, string name, string root, FlatItem[] items) { }

	public Task SaveMagBuild(MagPreset preset) { }

	public Task SaveWeaponBuild(MongoID id, string name, string root, FlatItem[] items) { }

	public void SendClientProfileSettings(Nullable groupInvitesRestrict, Nullable selectedIcon, Callback callback, Nullable prestigeGameMode = null) { }

	public Task SendDisconnectEvent(string profileId, string clientHost, string serverHost) { }

	public void SendLoadMetrics(int onlineAffiliation, int metricsType, int metricsValue, string locationName, bool isPMC) { }

	public Task SendMetrics(ClientMetrics metrics) { }

	public Task SendMetricsJson(string output, string error) { }

	public void SendOperationQueued(object operation, Action execute, Callback callback) { }

	public void SendOperationRightNow(object operation, Callback callback) { }

	public void SendReport(EReportType reportType, string profileId, Callback callback) { }

	public void set_ExamineRequestFailed(Action value) { }

	public void set_IsFlushing(bool value) { }

	public void set_LastPlayerState(PlayerVisualRepresentation value) { }

	public void set_LastPlayerStats(ProfileStats value) { }

	public void set_QueueStatus(EOperationQueueStatus value) { }

	public void SetBotSettings(GlobalConfigurationResponse backEndConfig) { }

	public Task StartGameGroupLeader(string groupId, bool isPet) { }

	public Task StartGameGroupPlayer(string groupId, bool isPet) { }

	public void StartKeepAliveCoroutine(int keepAliveInterval, bool keepAliveStaticInterval) { }

	public Task StartMatching(string locationId, bool isPet, EDateTime dateTime, string keyId, Action estimateTimeSetter) { }

	public void StopKeepAlive() { }

	public void TrySendCommands() { }

	public void ValidateNickname(string nickname, Callback callback) { }

	public Task WaitForProfileStatus(EProfileStatus status, EProfileStatus interruptStatus, bool isPet) { }

}

