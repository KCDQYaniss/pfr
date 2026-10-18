namespace EFT;

public sealed class ClientBackEndEmulator : IClientBackEnd, IBackEnd, ILocalizationLoader
{
	internal sealed class ClientBackendSessionEmulator : IEftSession, IRepairController, IMatchmakerSession, IProfileSession, IBackendSession, IClientSession, ITradingSession, IImageLoader, ISocial, IQuestSession, ILocalizationLoader
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__183_0; //Field offset: 0x8
			public static Func <>9__185_0; //Field offset: 0x10
			public static Func <>9__187_0; //Field offset: 0x18
			public static Func <>9__189_0; //Field offset: 0x20

			private static <>c() { }

			public <>c() { }

			internal bool <get_DisplayableTraders>b__183_0(Trader trader) { }

			internal bool <get_Insurers>b__185_0(Trader trader) { }

			internal bool <get_Medic>b__189_0(Trader trader) { }

			internal bool <get_Repairers>b__187_0(Trader trader) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass123_0
		{
			public ClientBackendSessionEmulator <>4__this; //Field offset: 0x10
			public Callback callback; //Field offset: 0x18

			public <>c__DisplayClass123_0() { }

			internal void <RefreshProfileStatuses>b__0(Result result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass124_0
		{
			public ClientBackendSessionEmulator <>4__this; //Field offset: 0x10
			public TaskCompletionSource completionSource; //Field offset: 0x18

			public <>c__DisplayClass124_0() { }

			internal void <GetLevelSettings>b__0(Result result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass126_0
		{
			public TaskCompletionSource completionSource; //Field offset: 0x10
			public ClientBackendSessionEmulator <>4__this; //Field offset: 0x18

			public <>c__DisplayClass126_0() { }

			internal void <GetProfiles>b__0(Result result) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass213_0
		{
			public string traderId; //Field offset: 0x10

			public <>c__DisplayClass213_0() { }

			internal bool <EFT.Trading.ITradingSession.GetTrader>b__0(Trader trader) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass230_0
		{
			public string profileId; //Field offset: 0x10

			public <>c__DisplayClass230_0() { }

			internal bool <SelectProfile>b__0(Profile profile) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass329_0
		{
			public Result assortment; //Field offset: 0x10

			public <>c__DisplayClass329_0() { }

			internal void <GetTraderAssortment>b__0(Result assort) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass93_0
		{
			public Profile profile; //Field offset: 0x10

			public <>c__DisplayClass93_0() { }

			internal bool <get_ActivePetStatus>b__0(ProfileStatus status) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass94_0
		{
			public Profile profile; //Field offset: 0x10

			public <>c__DisplayClass94_0() { }

			internal bool <GetProfileStatus>b__0(ProfileStatus status) { }

		}

		[CompilerGenerated]
		private struct <GetGlobalConfig>d__267`1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public ClientBackendSessionEmulator <>4__this; //Field offset: 0x0
			private TaskCompletionSource <tradersCompletionSource>5__2; //Field offset: 0x0
			private T <globalConfig>5__3; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0
			private TaskAwaiter <>u__2; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private sealed class <StartMatchingEnumerator>d__233 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public ClientBackendSessionEmulator <>4__this; //Field offset: 0x20
			public bool isPet; //Field offset: 0x28
			public string locationId; //Field offset: 0x30
			public Callback callback; //Field offset: 0x38

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			[DebuggerHidden]
			public <StartMatchingEnumerator>d__233(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private int _joinRequestNum; //Field offset: 0x10
		private ClientBackEndEmulator _backEnd; //Field offset: 0x18
		private bool _downloadTemplatesFromFile; //Field offset: 0x20
		[CompilerGenerated]
		private string <LocationTime>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private float <Acceleration>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private ChatServerState[] <ChatServers>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private readonly EGameMode <GameMode>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private readonly GameModeDescriptor <GameModeDescriptor>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private Action InventoryErrorHappened; //Field offset: 0x50
		[CompilerGenerated]
		private Action OnSessionError; //Field offset: 0x58
		[CompilerGenerated]
		private Action InventoryWarningHappened; //Field offset: 0x60
		[CompilerGenerated]
		private bool <IsGameSynced>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private LocationSettings <LocationSettings>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private Profile[] <AllProfiles>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private Profile <Profile>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private CountersCollection <OverallAccountStats>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private float <ProfilesUpdateTime>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		private bool <LimitedServersAvailability>k__BackingField; //Field offset: 0x94
		[CompilerGenerated]
		private PlayerVisualRepresentation <LastPlayerState>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		private ProfileStats <LastPlayerStats>k__BackingField; //Field offset: 0xA0
		[CompilerGenerated]
		private ProfileStatus[] <AllProfileStatus>k__BackingField; //Field offset: 0xA8
		[CompilerGenerated]
		private GameServerPing[] <GameServers>k__BackingField; //Field offset: 0xB0
		[CompilerGenerated]
		private readonly InsuranceCompany <InsuranceCompany>k__BackingField; //Field offset: 0xB8
		[CompilerGenerated]
		private readonly RagFair <RagFair>k__BackingField; //Field offset: 0xC0
		[CompilerGenerated]
		private readonly FinalsResponse <FinalsResponse>k__BackingField; //Field offset: 0xC8
		[CompilerGenerated]
		private SocialNetwork <SocialNetwork>k__BackingField; //Field offset: 0xD0
		private List _traders; //Field offset: 0xD8
		private RepairController _repairController; //Field offset: 0xE0
		[CompilerGenerated]
		private bool <IsFlushing>k__BackingField; //Field offset: 0xE8
		[CompilerGenerated]
		private EOperationQueueStatus <QueueStatus>k__BackingField; //Field offset: 0xEC
		private readonly BindableEvent _queueStatusChanged; //Field offset: 0xF0
		private IEftSession _eftEndSessionImplementation; //Field offset: 0xF8
		[CompilerGenerated]
		private Action <ExamineRequestFailed>k__BackingField; //Field offset: 0x100
		[CompilerGenerated]
		private DateTime <GetCurrentLocationTime>k__BackingField; //Field offset: 0x108
		[CompilerGenerated]
		private bool <Destroyed>k__BackingField; //Field offset: 0x110
		[CompilerGenerated]
		private GlobalConfigurationResponse <BackEndConfig>k__BackingField; //Field offset: 0x118
		[CompilerGenerated]
		private readonly SeasonRanksDataStorage <SeasonRankDataStorage>k__BackingField; //Field offset: 0x120
		[CompilerGenerated]
		private Action OnLobbyPushNotificationReceived; //Field offset: 0x128

		public override event Action InventoryErrorHappened
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action InventoryWarningHappened
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action OnLobbyPushNotificationReceived
		{
			[CompilerGenerated]
			 add { } //Length: 278
			[CompilerGenerated]
			 remove { } //Length: 278
		}

		public override event Action OnSessionError
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public private override float Acceleration
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override ProfileStatus ActivePetStatus
		{
			 get { } //Length: 315
		}

		public override ProfileStatus ActiveProfileStatus
		{
			 get { } //Length: 179
		}

		public private override Profile[] AllProfiles
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override ProfileStatus[] AllProfileStatus
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override GlobalConfigurationResponse BackEndConfig
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override IBackendCache Cache
		{
			 get { } //Length: 3
		}

		public private override ChatServerState[] ChatServers
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override bool Destroyed
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public override IEnumerable DisplayableTraders
		{
			 get { } //Length: 355
		}

		public override EquipmentBuildsStorage EquipmentBuildsStorage
		{
			 get { } //Length: 3
		}

		public override Action ExamineRequestFailed
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public override FinalsResponse FinalsResponse
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override EGameMode GameMode
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public override GameModeDescriptor GameModeDescriptor
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public private override GameServerPing[] GameServers
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override DateTime GetCurrentLocationTime
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		public override InsuranceCompany InsuranceCompany
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override IEnumerable Insurers
		{
			 get { } //Length: 355
		}

		public override bool IsFlushing
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public private override bool IsGameSynced
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public override bool IsLobbyConnectionEstablished
		{
			 get { } //Length: 3
		}

		public override PlayerVisualRepresentation LastPlayerState
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public override ProfileStats LastPlayerStats
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public private override bool LimitedServersAvailability
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public override ELinkedPlatform[] LinkedPlatforms
		{
			 get { } //Length: 53
		}

		public private override LocationSettings LocationSettings
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override string LocationTime
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override MagBuildsStorage MagBuildsStorage
		{
			 get { } //Length: 3
		}

		public override Trader Medic
		{
			 get { } //Length: 355
		}

		public override CountersCollection OverallAccountStats
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public private override Profile Profile
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override Profile ProfileOfPet
		{
			 get { } //Length: 184
		}

		public private override float ProfilesUpdateTime
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			private set { } //Length: 9
		}

		public override Dictionary PurchasedGames
		{
			 get { } //Length: 217
		}

		public override EOperationQueueStatus QueueStatus
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			 set { } //Length: 7
		}

		public override BindableEvent QueueStatusChanged
		{
			 get { } //Length: 8
		}

		public override RagFair RagFair
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override RepairController RepairController
		{
			 get { } //Length: 8
		}

		public override IEnumerable Repairers
		{
			 get { } //Length: 355
		}

		public override bool ReportAvailable
		{
			 get { } //Length: 3
		}

		public override ESeason Season
		{
			 get { } //Length: 3
		}

		public override SeasonRanksDataStorage SeasonRankDataStorage
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override SeasonsSettings SeasonsSettings
		{
			 get { } //Length: 3
		}

		public private override SocialNetwork SocialNetwork
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override long TotalInGameTime
		{
			 get { } //Length: 3
		}

		public override IEnumerable Traders
		{
			 get { } //Length: 8
		}

		public override WeaponBuildsStorage WeaponBuildsStorage
		{
			 get { } //Length: 3
		}

		public override WeatherNode Weather
		{
			 get { } //Length: 69
		}

		public ClientBackendSessionEmulator(ClientBackEndEmulator backEnd, bool downloadTemplatesFromFile = true) { }

		[CompilerGenerated]
		private bool <get_ActiveProfileStatus>b__91_0(ProfileStatus t) { }

		[CompilerGenerated]
		private bool <get_ProfileOfPet>b__85_0(Profile p) { }

		public override void AbortMatching(bool isPet, Callback callback, bool ignoreCallbacks = false) { }

		public override Task AcceptAllFriendRequests() { }

		public override void AcceptFriendRequest(string profileId, Callback callback) { }

		public override void AcceptGroupInvite(string requestId, Callback callback) { }

		[CompilerGenerated]
		public override void add_InventoryErrorHappened(Action value) { }

		[CompilerGenerated]
		public override void add_InventoryWarningHappened(Action value) { }

		[CompilerGenerated]
		public override void add_OnLobbyPushNotificationReceived(Action value) { }

		[CompilerGenerated]
		public override void add_OnSessionError(Action value) { }

		public override void AddNotificationToHandle(string notificationType, Action action) { }

		public override void AllAttachmentsFromDialog(string dialogId, Callback callback) { }

		public override Task ApplyCustomization(IEnumerable customizations) { }

		public override Task ArenaManagerItemsTransfer(ArenaEftTransferItem[] items, string traderId, int transferTax) { }

		public override void BuyCustomizationWear(string offer, IEnumerable items, Callback onFinished) { }

		public override Task CancelAllInvites() { }

		public override Task CancelFriendRequest(string profileId) { }

		public override Task CancelGameSearching(bool isPet) { }

		public override void CancelInvite(string requestId, Callback callback) { }

		public override void ChangeNickname(string profileId, string nickname, Callback callback) { }

		public override void ChangeProfileStatus(ProfileStatus status) { }

		public void ChangeVoice(string voice, Callback callback = null) { }

		public override void ChatCreateGroupDialog(string chatName, string[] groupMembers, Callback callback) { }

		public override Task ChatDeleteAllMessages(string dialogId) { }

		public override void ChatDeleteMessage(string dialogId, string messageId, Callback callback) { }

		public override Task ChatGetDialogList(int limit, int offset) { }

		public override void ChatGetDialogMessages(string id, int type, int limit, double time, Callback callback) { }

		public override void ChatReadDialogues(string[] dialogs, Callback callback) { }

		public override void ChatSendMessage(string id, int type, string text, string replyTo, Callback callback) { }

		public override void CheckLoginQueue(Callback callback) { }

		public override Task CheckVersion() { }

		public override Task ClaimSeasonalLeaguesRankReward() { }

		public override void ClearProfileUpdaters() { }

		public override Task CompleteUpgradeZone(int areaType) { }

		public override void ConfigureLobbyRelatedParameters(ClientSettingsConfig config) { }

		public override Task ConfirmPurchase(string traderId, string itemId, int count, int schemeId, TradingItemReference[] items) { }

		public override Task ConfirmSeasonalLeaguesRankEnd() { }

		public override void ConfirmSell(string traderId, TradingItemReference[] items, int price, Callback onFinished) { }

		public override void CreateNotifierChannel(Callback callback) { }

		public override Task CreateProfile(EPlayerSide profileSide, string profileNickname, string headId, string voiceId, IReadOnlyCollection selectedPerkIds) { }

		public override void DeclineFriendRequest(string profileId, Callback callback) { }

		public override void DeclineGroupInvite(string requestId, Callback callback) { }

		public override Task DeleteDialog(string dialogId) { }

		public void Destroy() { }

		public override void DisbandRaidGroup(Callback callback) { }

		public override Task DownloadQuestTraderDialog(MongoID dialogId) { }

		private override Task EFT.IClientSession.Destroy() { }

		private override Task EFT.IQuestSession.AchievementComplete(string qid, bool removeExcessItems) { }

		private override void EFT.IQuestSession.AddQuestNote(string questId, MongoID conditionId, MongoID noteId) { }

		private override Task EFT.IQuestSession.GetDailyQuests() { }

		private override Task EFT.IQuestSession.GetQuestsByCompletableItem(MongoID completableItemTemplateId) { }

		private override Task EFT.IQuestSession.QuestAccept(string qid, bool isRepeatable) { }

		private override Task EFT.IQuestSession.QuestChange(string qid) { }

		private override Task EFT.IQuestSession.QuestFail(string qid) { }

		private override Task EFT.IQuestSession.RequestAchievementsGlobalProgress() { }

		private override Task EFT.IQuestSession.RequestAchievementsTemplates(bool withCompleted) { }

		private override Task EFT.IQuestSession.RequestQuestChains() { }

		private override Task EFT.IQuestSession.RequestQuestsTemplates(bool withCompleted) { }

		private override Trader EFT.Trading.ITradingSession.GetTrader(string traderId) { }

		public override Task EstablishWSConnection() { }

		public override Task ExitFromMatchmakerGroupMenu() { }

		public override void FindAccountByNickname(string nickname, Callback callback) { }

		public override void FindById(long id, Callback callback) { }

		public override void FinishCultistsProduction(string schemeId) { }

		public override Task FinishScavSession() { }

		public override Task FlushOperationQueue() { }

		[CompilerGenerated]
		public override float get_Acceleration() { }

		public override ProfileStatus get_ActivePetStatus() { }

		public override ProfileStatus get_ActiveProfileStatus() { }

		[CompilerGenerated]
		public override Profile[] get_AllProfiles() { }

		[CompilerGenerated]
		public override ProfileStatus[] get_AllProfileStatus() { }

		[CompilerGenerated]
		public override GlobalConfigurationResponse get_BackEndConfig() { }

		public override IBackendCache get_Cache() { }

		[CompilerGenerated]
		public override ChatServerState[] get_ChatServers() { }

		[CompilerGenerated]
		public override bool get_Destroyed() { }

		public override IEnumerable get_DisplayableTraders() { }

		public override EquipmentBuildsStorage get_EquipmentBuildsStorage() { }

		[CompilerGenerated]
		public override Action get_ExamineRequestFailed() { }

		[CompilerGenerated]
		public override FinalsResponse get_FinalsResponse() { }

		[CompilerGenerated]
		public override EGameMode get_GameMode() { }

		[CompilerGenerated]
		public override GameModeDescriptor get_GameModeDescriptor() { }

		[CompilerGenerated]
		public override GameServerPing[] get_GameServers() { }

		[CompilerGenerated]
		public override DateTime get_GetCurrentLocationTime() { }

		[CompilerGenerated]
		public override InsuranceCompany get_InsuranceCompany() { }

		public override IEnumerable get_Insurers() { }

		[CompilerGenerated]
		public override bool get_IsFlushing() { }

		[CompilerGenerated]
		public override bool get_IsGameSynced() { }

		public override bool get_IsLobbyConnectionEstablished() { }

		[CompilerGenerated]
		public override PlayerVisualRepresentation get_LastPlayerState() { }

		[CompilerGenerated]
		public override ProfileStats get_LastPlayerStats() { }

		[CompilerGenerated]
		public override bool get_LimitedServersAvailability() { }

		public override ELinkedPlatform[] get_LinkedPlatforms() { }

		[CompilerGenerated]
		public override LocationSettings get_LocationSettings() { }

		[CompilerGenerated]
		public override string get_LocationTime() { }

		public override MagBuildsStorage get_MagBuildsStorage() { }

		public override Trader get_Medic() { }

		[CompilerGenerated]
		public override CountersCollection get_OverallAccountStats() { }

		[CompilerGenerated]
		public override Profile get_Profile() { }

		public override Profile get_ProfileOfPet() { }

		[CompilerGenerated]
		public override float get_ProfilesUpdateTime() { }

		public override Dictionary get_PurchasedGames() { }

		[CompilerGenerated]
		public override EOperationQueueStatus get_QueueStatus() { }

		public override BindableEvent get_QueueStatusChanged() { }

		[CompilerGenerated]
		public override RagFair get_RagFair() { }

		public override RepairController get_RepairController() { }

		public override IEnumerable get_Repairers() { }

		public override bool get_ReportAvailable() { }

		public override ESeason get_Season() { }

		[CompilerGenerated]
		public override SeasonRanksDataStorage get_SeasonRankDataStorage() { }

		public override SeasonsSettings get_SeasonsSettings() { }

		[CompilerGenerated]
		public override SocialNetwork get_SocialNetwork() { }

		public override long get_TotalInGameTime() { }

		public override IEnumerable get_Traders() { }

		public override WeaponBuildsStorage get_WeaponBuildsStorage() { }

		public override WeatherNode get_Weather() { }

		public override Task GetAllCustomizations(Dictionary returnInCaseOfCache = null) { }

		public override Task GetAreasQte() { }

		public override Task GetAreaTemplatesUnparsed() { }

		public override Task GetAvailableCustomizationsStorage() { }

		public override Task GetBaseTraderDialogs() { }

		public override Task GetBattlePassData() { }

		public override Task GetCaptcha() { }

		public override void GetChatServers(string versionId, Callback callback) { }

		public override Task GetClientSettingsConfig() { }

		public override Task GetCutscenesSubtitlesData() { }

		public override void GetDialogInformation(string dialogId, Callback callback) { }

		public override Task GetExpansionsAccessData(string body) { }

		public override Task GetExpansionsPlayerData() { }

		public override Task GetFinalLocalization(string _) { }

		public override Task GetFinals() { }

		public override Task GetFriendsList() { }

		[AsyncStateMachine(typeof(<GetGlobalConfig>d__267`1))]
		public override Task GetGlobalConfig() { }

		public override void GetGroupStatus(Callback callback) { }

		public override AreaInfo[] GetHideoutAreasInfo() { }

		public override Task GetHideoutCustomizationOffers() { }

		public override Dictionary GetHideoutImprovements() { }

		public override Task GetHideoutSettings() { }

		public override int GetHideoutShootingRangeScore() { }

		public override void GetInsurancePrice(string[] traderId, string[] itemIds, Callback callback) { }

		public override Task GetLevelSettings() { }

		public override Task GetMainQuestSettings() { }

		public override void GetMarketPrices(string templateId, Callback callback) { }

		public override Task GetMetricsConfig() { }

		public override void GetOffers(string traderId, string side, Callback onFinished) { }

		public override Task GetOffers(int page, int limit, int sortType, bool direction, int currency, int priceFrom, int priceTo, int quantityFrom, int quantityTo, int conditionFrom, int conditionTo, bool oneHourExpiration, bool removeBartering, int offerOwnerType, bool onlyFunctional, string handbookId, string linkedSearchId, string neededSearchId, Dictionary buildItems, int buildCount, bool updateOfferCount) { }

		public override Task GetOtherPlayerProfile(string accountId) { }

		public override string GetPhpSessionId() { }

		public override Task GetPrestigeSettings() { }

		public override Task GetProductionRecipes() { }

		public override Profile GetProfileBySide(ESideType side) { }

		public override Task GetProfiles() { }

		public override ProfileStatus GetProfileStatus(bool isPet) { }

		public override Task GetProfileVariables() { }

		public override Task GetQuestNoteTemplate() { }

		public override void GetRaidReadyStatus(object readyStatusParams, Callback callback) { }

		public override Task GetReservedNickname() { }

		public override Task GetSeasonalLeaderboardInfo() { }

		public override Task GetSeasonalLeaguesRanks() { }

		public override Task GetSeasonalLeaguesState() { }

		public override Task GetSeasonalPerks() { }

		public override Task GetSeasonalRewards() { }

		public override string GetSessionId(bool isPet) { }

		public override Task GetSupplyData(string traderId) { }

		public override Task GetTapesSubtitlesData() { }

		public override Task GetTemplates(ItemTemplates defaultValueInCaseOfCache) { }

		public override Task GetTraderAssortment(string traderId) { }

		public Task GetTraderMarketPrices(string traderId) { }

		public override Task GetTraderSettings() { }

		public override Task GetTutorialInfo(bool skipTutorial = false) { }

		public override Task GetTutorialProfile() { }

		public override Task GetValidWSToken() { }

		public override Task GetWeatherAndTime() { }

		public override Task HideoutProductionCancel(string recipeId) { }

		public override Task HideoutProductionReset(string recipeId) { }

		public override void InsureItems(string[] items, string traderId, Callback callback) { }

		public override void InviteToDialogue(string dialogId, string[] uid, Callback callback) { }

		public override Task IsMatchingAvailable() { }

		public override Task IssueWSToken() { }

		public override void LeaveChatDialogue(string dialogId, Callback callback) { }

		public override Task LeaveMatchmakerGroup() { }

		public override Task LoadBots(List limit) { }

		public override Task LoadGlobalConfig() { }

		public override Task LoadLocale(string locale = null) { }

		public override Task LoadMainMenuLocale(string locale = null) { }

		public override Task LoadProfiles() { }

		public override Task LoadTextureMain(string url) { }

		public override Task LocalRaidEnded(LocalRaidSettings settings, SessionResult results, FlatItem[] lostInsuredItems, Dictionary transferItems) { }

		public override Task LocalRaidStarted(LocalRaidSettings settings) { }

		public override Task Logout() { }

		public override void MarkSurveyAsViewed(int surveyId) { }

		public override void MutePlayer(string uid, Callback callback) { }

		public override Task ObtainFinalReward(string endingId) { }

		public override Task ObtainPrestige(PrestigeObtainData[] prestigeObtainData) { }

		public override Task ObtainSeasonalReward(MongoID seasonalRewardConfigId) { }

		public override bool OfferAlreadyReported(long offerId) { }

		public override void PinDialog(string dialogId, Callback callback) { }

		public override void PinFriend(string friendId, Callback callback) { }

		public override bool PlayerAlreadyReported(string playerId, EReportType reportType) { }

		public override void PutItemsInAreaSlots(EAreaType areaType, Dictionary items, Callback onComplete) { }

		public override void RagfairAddOffer(bool sellInOnePiece, string[] items, BarterTemplate[] requirements, Callback callback) { }

		public override void RagfairGetPrices(Callback callback) { }

		public void RagfairPurchaseOffers(CommoditiesToPurchase commodities, Callback callback) { }

		public override Task RagfairPurchaseOffers(CommoditiesToPurchase commodities) { }

		public override void RagfairRemoveOffer(string offerId, Callback callback) { }

		public override void RagfairRenewOffer(string offerId, bool priority, int renewalTime, Callback callback) { }

		public override void RagfairReportOffer(long offerId, Callback callback) { }

		public override void ReadEncyclopedia(string[] ids, Callback callback) { }

		public override Task ReceiveCoopRaidSettings() { }

		public override Task RedeemProfileRewards(ChatMessageProfileEvent[] rewards) { }

		public override void RefreshPings(int sendPingResultInterval, int pingServersInterval, Callback callback) { }

		public override void RefreshProfileStatuses(bool isPet, Callback callback = null) { }

		public override void RegisterCaptchaHandler(ICaptchaHandler captchaHandler) { }

		public override void RegisterProfileUpdater(string profileId, IProfileUpdatesHandler profileUpdater) { }

		[CompilerGenerated]
		public override void remove_InventoryErrorHappened(Action value) { }

		[CompilerGenerated]
		public override void remove_InventoryWarningHappened(Action value) { }

		[CompilerGenerated]
		public override void remove_OnLobbyPushNotificationReceived(Action value) { }

		[CompilerGenerated]
		public override void remove_OnSessionError(Action value) { }

		public override Task RemoveBuild(MongoID id) { }

		public override void RemoveFromDialogue(string dialogId, string uid, Callback callback) { }

		public override void RemoveFromFriendsList(string id, Callback callback) { }

		public override void RemovePlayerFromGroup(string profileAid, Callback callback) { }

		public override Task RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItemId) { }

		public override Task RepairItemsByTrader(string traderId, RepairItem repairItem) { }

		public override void ReportNickname(string aId, Callback callback) { }

		public override Task RequestBuilds() { }

		public override Task RequestCaptcha() { }

		public override Task RequestHandbookInfo(HandbookInfo returnInCaseOfCache = null) { }

		public override Task RequestSurvey() { }

		public override void RestoreHealth(HealthTreatmentData treatmentData, List cost, string traderId) { }

		public override Task SaveEquipmentBuild(MongoID id, string name, string root, FlatItem[] items) { }

		public override Task SaveMagBuild(MagPreset preset) { }

		public override Task SaveWeaponBuild(MongoID id, string name, string root, FlatItem[] items) { }

		public Task SelectProfile(string profileId) { }

		public override Task SellAllFromSavage(string playerId, string petId) { }

		public override void SendClientProfileSettings(Nullable groupInvitesRestrict, Nullable selectedIcon, Callback callback, Nullable prestigeGameMode = null) { }

		public override Task SendDisconnectEvent(string profileId, string clientHost, string serverHost) { }

		public override void SendFriendRequest(string id, Callback callback) { }

		public override void SendGroupInvite(string accountId, bool inLobby, Callback callback) { }

		public override void SendLoadMetrics(int onlineAffiliation, int metricsType, int metricsValue, string locationName, bool isPMC) { }

		public override Task SendMetrics(ClientMetrics metrics) { }

		public override Task SendMetricsJson(string output, string error) { }

		public override void SendOperationQueued(object operation, Action execute, Callback callback) { }

		public override void SendOperationRightNow(object operation, Callback callback) { }

		public override Task SendQuestComplete(string questId) { }

		public override Task SendQuestFail(string questId) { }

		public override Task SendRaidSettings(RaidSettings raidSettings) { }

		public override void SendReport(EReportType reportType, string profileId, Callback callback) { }

		public override void SendSurveyResult(SurveyAnswersData answerData) { }

		public override Task SendTransactionSignRequest(string transactionId) { }

		[CompilerGenerated]
		private void set_Acceleration(float value) { }

		[CompilerGenerated]
		private void set_AllProfiles(Profile[] value) { }

		[CompilerGenerated]
		private void set_AllProfileStatus(ProfileStatus[] value) { }

		[CompilerGenerated]
		private void set_BackEndConfig(GlobalConfigurationResponse value) { }

		[CompilerGenerated]
		private void set_ChatServers(ChatServerState[] value) { }

		[CompilerGenerated]
		private void set_Destroyed(bool value) { }

		[CompilerGenerated]
		public override void set_ExamineRequestFailed(Action value) { }

		[CompilerGenerated]
		private void set_GameServers(GameServerPing[] value) { }

		[CompilerGenerated]
		private void set_GetCurrentLocationTime(DateTime value) { }

		[CompilerGenerated]
		public override void set_IsFlushing(bool value) { }

		[CompilerGenerated]
		private void set_IsGameSynced(bool value) { }

		[CompilerGenerated]
		public override void set_LastPlayerState(PlayerVisualRepresentation value) { }

		[CompilerGenerated]
		public override void set_LastPlayerStats(ProfileStats value) { }

		[CompilerGenerated]
		private void set_LimitedServersAvailability(bool value) { }

		[CompilerGenerated]
		private void set_LocationSettings(LocationSettings value) { }

		[CompilerGenerated]
		private void set_LocationTime(string value) { }

		[CompilerGenerated]
		protected void set_OverallAccountStats(CountersCollection value) { }

		[CompilerGenerated]
		private void set_Profile(Profile value) { }

		[CompilerGenerated]
		private void set_ProfilesUpdateTime(float value) { }

		[CompilerGenerated]
		public override void set_QueueStatus(EOperationQueueStatus value) { }

		[CompilerGenerated]
		private void set_SocialNetwork(SocialNetwork value) { }

		public override void SetBotSettings(GlobalConfigurationResponse backEndConfig) { }

		public override void SetDisplayedEnding(string endingId, Callback callback) { }

		public override void SetFavoriteItems(IEnumerable items, Callback callback = null) { }

		public override void SetHideoutCustomizationItem(MongoID offerId, Callback callback = null) { }

		public override void SetHideoutMannequinPose(Dictionary poses, Callback callback = null) { }

		public override void SetHideoutShootingRangeScore(int value) { }

		public override Task SetMainProfile(Profile profile) { }

		public override void SetNotReadyReadyStatus(Callback callback) { }

		public override void SetProfiles(ProfileDescriptor[] profilesData) { }

		public override void SetReadyRaidStatus(Callback callback) { }

		public Task SetVariableValue(List variableData) { }

		public override void StartContinuousProduction(string schemeId) { }

		public override Task StartCultistsProduction() { }

		public override Task StartGameGroupLeader(string groupId, bool isPet) { }

		public override Task StartGameGroupPlayer(string groupId, bool isPet) { }

		public override void StartImprovement(string id, EAreaType areaType, IEnumerable items) { }

		public override void StartKeepAliveCoroutine(int keepAliveInterval, bool keepAliveStaticInterval) { }

		public override Task StartLookingForGroup() { }

		public override Task StartMatching(string locationId, bool isPet, EDateTime dateTime, string keyId, Action estimateTimeSetter) { }

		[IteratorStateMachine(typeof(<StartMatchingEnumerator>d__233))]
		private IEnumerator StartMatchingEnumerator(string locationId, bool isPet, Callback callback) { }

		public override Task StartScavCaseProduction(string schemeId, IEnumerable items, IEnumerable tools) { }

		public override void StartSingleProduction(string schemeId, IEnumerable items, IEnumerable tools) { }

		public override void StopKeepAlive() { }

		public override Task StopLookingForGroup() { }

		public override Task SyncPlatformFriends(ELinkedPlatform platform) { }

		public override Task TakeHideoutProduction(string recipeId) { }

		public override void TakeItemsFromAreaSlots(EAreaType areaType, int[] slots, Callback callback) { }

		public override Task TakeItemsFromAreaSlotsAsync(EAreaType areaType, int[] slots) { }

		public override void ToggleArea(EAreaType areaType, bool enabled) { }

		public override void TransferChatLeadership(string dialogId, string uid, Callback callback) { }

		public override void TransferGroupLeadership(string profileAid, Callback callback) { }

		public override void TrySendCommands() { }

		public override void UnmutePlayer(string uid, Callback callback) { }

		public override Task Unpack(string targetItemId, string profileId) { }

		public override void UnpinDialog(string dialogId, Callback callback) { }

		public override void UnpinFriend(string friendId, Callback callback) { }

		public override Task UpgradeZone(int areaType, IEnumerable items) { }

		public override Task ValidateCaptcha(IEnumerable items, string captchaType) { }

		public override void ValidateNickname(string profileNickname, Callback callback) { }

		public override Task WaitForProfileStatus(EProfileStatus status, EProfileStatus interruptStatus, bool isPet) { }

		public override Task WeatherRequest() { }

		public override void WorkoutEnded(IEnumerable qtesResult, string qteId, string accountId, Callback callback) { }

	}

	private readonly string _ipAddress; //Field offset: 0x10
	private readonly int _port; //Field offset: 0x18
	private readonly float _simulatedDelay; //Field offset: 0x1C
	private readonly bool _loadTemplatesFromBackend; //Field offset: 0x20
	private ClientBackendSessionEmulator _session; //Field offset: 0x28
	[CompilerGenerated]
	private BackendStatus <Status>k__BackingField; //Field offset: 0x30

	public private override ClientBackendSessionEmulator Session
	{
		 get { } //Length: 5
		private set { } //Length: 185
	}

	public private override BackendStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private ITradingSession TradingSession
	{
		 get { } //Length: 5
		private set { } //Length: 185
	}

	private ClientBackEndEmulator(string ipAddress, int port, bool loadTemplatesFromBackend = false) { }

	internal static ClientBackEndEmulator Create(string ipAddress = "localhost", int port = 7777, bool loadTemplatesFromBackend = false) { }

	public override Task CreateClientSession() { }

	public override Task Destroy() { }

	public override void EnableDiagnostics(bool webDiagnosticsEnabled) { }

	public Task FlushOperationQueue() { }

	public void FlushOperationQueue(Callback callback) { }

	public override ClientBackendSessionEmulator get_Session() { }

	[CompilerGenerated]
	public override BackendStatus get_Status() { }

	public ITradingSession get_TradingSession() { }

	public override Task GetAvailableLanguages() { }

	public override Task GetCharacters() { }

	public override Task GetExpansionsSettings() { }

	public override Task GetGameMode(Nullable sessionMode) { }

	public override Task GetLocalization(string locale) { }

	public override Task GetMainMenuLocalization(string locale) { }

	public override Task GetSeasonalPerks() { }

	public override Task GetTemplates(ItemTemplates returnInCaseOfCache) { }

	private static void LoadFromBackend(string url, Callback onFinished) { }

	public static void LoadFromFile(string fileName, Callback onFinished) { }

	public override Task LoadLocale(string locale = null) { }

	public override Task LoadMainMenuLocale(string locale = null) { }

	public override Task Login(string login, string password) { }

	public override Task Logout() { }

	public void ManualUpdate() { }

	public override Task RegenerateToken() { }

	public override void RegisterDevice(string email, string activateCode, Callback onFinished) { }

	private void set_Session(ClientBackendSessionEmulator value) { }

	[CompilerGenerated]
	private void set_Status(BackendStatus value) { }

	private void set_TradingSession(ITradingSession value) { }

	public override Task ValidateVersion() { }

}

