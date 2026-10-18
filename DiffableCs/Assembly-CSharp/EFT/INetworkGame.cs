namespace EFT;

internal interface INetworkGame
{

	public IClientSession BackEndSession
	{
		 get { } //Length: 0
	}

	public GameDateTime GameDateTime
	{
		 get { } //Length: 0
	}

	public string LocationId
	{
		 get { } //Length: 0
	}

	public Transform Transform
	{
		 get { } //Length: 0
	}

	public void Abort(string error) { }

	public void AirdropFlareSuccessEvent(bool canSendAirdrop) { }

	public void BeginChunkedPlayerSpawnProfile(ClientPlayer player, byte[] messageTail, ChunkedProfileSpawnParameters parameters) { }

	public void ConfirmQuestTemplates(string profileID, string error) { }

	public void GameMatching(float playersReady, float playersToWait, float secondsLeftToStart, float maxWaitSeconds) { }

	public void GameOverSaveStatus(RpcGameOverSaveStatusMessage gameOverSaveStatusMessage) { }

	public void GameRestarted() { }

	public void GameRestarting() { }

	public Task GameSpawned() { }

	public void GameStarted(float pastTime, int sessionSeconds) { }

	public void GameStarting(int seconds) { }

	public void GameStartingWithTeleport(Vector3 position, int exfiltrationId, string entryPoint) { }

	public void GameStopped(ExitStatus exitStatus, TimeSpan playTime) { }

	public void GameStopping() { }

	public IClientSession get_BackEndSession() { }

	public GameDateTime get_GameDateTime() { }

	public string get_LocationId() { }

	public Transform get_Transform() { }

	public void GetNewQuestTemplates(byte[] data) { }

	public void GetRadioTransmitterData(string profileID) { }

	public void GetTraderServicesData(string profileID, string traderId) { }

	public void ObserverDespawn(NetworkReader reader, Callback callback) { }

	public void OnDisconnectStatusAccepted(DisconnectionReason disconnectionReason) { }

	public void ParseAirdropContainerData(byte[] data) { }

	public void ParseBufferZoneData(byte[] data) { }

	public void ParseCreateCorpseData(byte[] data) { }

	public void ParseMineExplosionData(byte[] data) { }

	public void PlayerSpawn(NetworkReader reader, Callback callback) { }

	public void ReceiveClientRadioTransmitterData(RadioTransmitterData data) { }

	public void ReceiveCompletedAchievementsData(CompletedAchievementConditionsData data) { }

	public void ReceiveLeftHandData(LeftHandData data) { }

	public void ReceiveLighthouseTraderZoneData(LighthouseTraderZoneData data) { }

	public void ReceiveObserverRadioTransmitterData(RadioTransmitterData data) { }

	public void ReceivePlayerSpawnProfileChunk(NetworkMessage networkMessage) { }

	public void ReceiveRaidDialogEntryOccupancySync(string pointId, int occupantRaidID) { }

	public void ReceiveTraderServicesData(byte[] packet) { }

	public void ReceiveVolumetricSystemInitialState(NetworkMessage message) { }

	public void ReceiveWorldSyncAbles(NetworkMessage message) { }

	public void RecieveSyncWeaponData(ItemDescriptor weapon) { }

	public Task Run(INetworkGameSession session, bool canRestart, GameDateTime gameDateTime, IDictionary interactables, ResourceKey[] prefabs, string[] customizations, WeatherNode[] weathers, ESeason season, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings, float fixedDeltaTime, bool speedLimitsEnabled, Config speedLimits, VoipSettings voipSettings = null) { }

	public void SendCommonEventData(ArraySegment segment) { }

	public void SoftStopNotification(TimeSpan sessionTime) { }

	public void Spawn() { }

	public void Stop() { }

	public void VoipAbuseNotification() { }

	public Task WorldSpawn(NetworkMessage message) { }

	public void WorldSpawnLoot(NetworkMessage message) { }

}

