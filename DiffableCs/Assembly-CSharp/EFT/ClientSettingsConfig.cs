namespace EFT;

public class ClientSettingsConfig
{
	internal class FramerateLimitSettings
	{
		public int MinFramerateLimit; //Field offset: 0x10
		public int MaxFramerateLobbyLimit; //Field offset: 0x14
		public int MaxFramerateGameLimit; //Field offset: 0x18

		public FramerateLimitSettings() { }

	}

	internal class NetworkStateViewSettings
	{
		public int LossThreshold; //Field offset: 0x10
		public int RttThreshold; //Field offset: 0x14

		public NetworkStateViewSettings() { }

	}

	internal class ReleaseProfilerSettings
	{
		public bool Enabled; //Field offset: 0x10
		public double RecordTriggerValue; //Field offset: 0x18
		public int MaxRecords; //Field offset: 0x20

		public ReleaseProfilerSettings() { }

	}

	public const int DEFAULT_SEND_RATE_LIMIT = 100; //Field offset: 0x0
	public const int DEFAULT_KEEP_ALIVE_LIMIT = 60; //Field offset: 0x0
	public const int DEFAULT_GROUP_STATUS_LIMIT = 20; //Field offset: 0x0
	public const int DEFAULT_GROUP_STATUS_BUTTON_UPDATE_LIMIT = 7; //Field offset: 0x0
	public const int DEFAULT_PING_SERVER_RESULT_SEND_INTERVAL = 20; //Field offset: 0x0
	public const int DEFAULT_PING_SERVERS_INTERVAL = 5; //Field offset: 0x0
	public const float DEFAULT_MATCHING_SINGLE_START_MAP_LOADING_PERCENT = 0.2; //Field offset: 0x0
	public bool TurnOffLogging; //Field offset: 0x10
	public bool CollectLoadTimeMetrics; //Field offset: 0x11
	public int ClientSendRateLimit; //Field offset: 0x14
	public int KeepAliveInterval; //Field offset: 0x18
	public bool KeepAliveStaticInterval; //Field offset: 0x1C
	public int GroupStatusInterval; //Field offset: 0x20
	public int GroupStatusButtonInterval; //Field offset: 0x24
	public int PingServerResultSendInterval; //Field offset: 0x28
	public int PingServersInterval; //Field offset: 0x2C
	public int FirstCycleDelaySeconds; //Field offset: 0x30
	public int SecondCycleDelaySeconds; //Field offset: 0x34
	public int NextCycleDelaySeconds; //Field offset: 0x38
	public int AdditionalRandomDelaySeconds; //Field offset: 0x3C
	public int DefaultRetriesCount; //Field offset: 0x40
	public int CriticalRetriesCount; //Field offset: 0x44
	public bool Mark502and504AsNonImportant; //Field offset: 0x48
	public int SteamSyncCooldownSeconds; //Field offset: 0x4C
	public bool DisablePrewarmsSoundsForObservers; //Field offset: 0x50
	public FramerateLimitSettings FramerateLimit; //Field offset: 0x58
	public NetworkStateViewSettings NetworkStateView; //Field offset: 0x60
	public MemoryManagementSettings MemoryManagementSettings; //Field offset: 0x68
	public bool NVidiaHighlights; //Field offset: 0x7C
	public ReleaseProfilerSettings ReleaseProfiler; //Field offset: 0x80
	public bool WebDiagnosticsEnabled; //Field offset: 0x88
	public float WeaponOverlapDistanceCulling; //Field offset: 0x8C
	public float AFKTimeoutSeconds; //Field offset: 0x90
	public string[] RequestsMadeThroughLobby; //Field offset: 0x98
	public float LobbyKeepAliveInterval; //Field offset: 0xA0
	public float[] RequestConfirmationTimeouts; //Field offset: 0xA8
	public bool ShouldEstablishLobbyConnection; //Field offset: 0xB0
	public bool ShouldEstablishLegacyConnection; //Field offset: 0xB1
	public float MatchingSingleStartMapLoadingPercent; //Field offset: 0xB4
	[JsonProperty("AudioSettings")]
	public ClientAudioSettings AudioSettings; //Field offset: 0xB8

	public ClientSettingsConfig() { }

}

