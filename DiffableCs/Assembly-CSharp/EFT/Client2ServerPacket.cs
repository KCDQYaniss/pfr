namespace EFT;

public struct Client2ServerPacket
{
	public const int INVENTORY_COMMANDS_BITS_COUNT = 8; //Field offset: 0x0
	private const float PRECISE_DELTA_TIME_RESOLUTION_MULTIPLIER = 0.1; //Field offset: 0x0
	private const float USUAL_DELTA_TIME_RESOLUTION = 0.00048828125; //Field offset: 0x0
	public const float LOWEST_USUAL_DELTA_TIME = 0.008333334; //Field offset: 0x0
	private const int MAX_USUAL_FPS = 120; //Field offset: 0x0
	private const int MAX_FRAMES_DIFF = 15; //Field offset: 0x0
	private const int HANDS_TYPE_BITS_COUNT = 3; //Field offset: 0x0
	public const int MAX_NON_CRITICAL_PACKETS_IN_ROW = 5; //Field offset: 0x0
	public static Client2ServerPacket DEFAULT_CLIENT2_SERVER_PACKET; //Field offset: 0x0
	public const int MAX_PACKETS_QUEUE = 127; //Field offset: 0x0
	public const int MAX_FRAMES_BETWEEN_CRITICAL_PACKETS = 6; //Field offset: 0x0
	private static readonly FloatQuantizer _usualDeltaTimeQuantizer; //Field offset: 0x620
	private static readonly FloatQuantizer _preciseDeltaTimeQuantizer; //Field offset: 0x63C
	public bool HasCriticalData; //Field offset: 0x0
	public Nullable RTT; //Field offset: 0x2
	public bool IsExtraPrecisionMovement; //Field offset: 0x6
	public float TempDeltaTime; //Field offset: 0x8
	public float ClientTime; //Field offset: 0xC
	public float DeltaTimeFromLastCriticalPacket; //Field offset: 0x10
	public bool SyncSkills; //Field offset: 0x14
	public MovementInfoPacket MovementInfoPacket; //Field offset: 0x18
	public HandsChangePacket HandsChangePacket; //Field offset: 0x190
	public List InventoryCommandPackets; //Field offset: 0x1B8
	public Nullable LootRayInfo; //Field offset: 0x1C0
	public EHandsTypePacket HandsTypePacket; //Field offset: 0x1DC
	public FirearmPacket FirearmPacket; //Field offset: 0x1E0
	public GrenadePacket GrenadePacket; //Field offset: 0x420
	public KnifePacket KnifePacket; //Field offset: 0x468
	public PhraseCommandPacket PhraseCommandPacket; //Field offset: 0x4B8
	public EmptyHandPacket EmptyHandPacket; //Field offset: 0x4C4
	public UsableItemPacket UsableItemPacket; //Field offset: 0x4C9
	public TripwireSoundInteractionPacket TripwireSoundInteractionPacket; //Field offset: 0x4D4
	public EVoipState VoipState; //Field offset: 0x4E0
	public bool IsTalked; //Field offset: 0x4E1
	public Nullable IsVoiceMuffled; //Field offset: 0x4E2
	public Nullable IsUnderRoof; //Field offset: 0x4E4
	public ViewPacket ViewPacket; //Field offset: 0x4E8
	public Nullable CancelApplyingItemPacket; //Field offset: 0x4EC
	public Nullable StopSearchContentPacket; //Field offset: 0x4F0
	public Nullable StopRecorderPacket; //Field offset: 0x500
	public Nullable RaidDialogEntryPointCommandPacket; //Field offset: 0x508
	public Nullable CutsceneEndedPacket; //Field offset: 0x520
	public Nullable CutsceneViewCompletePacket; //Field offset: 0x540
	public Nullable HelmetLightPacket; //Field offset: 0x558
	public Nullable DevelopHealPacket; //Field offset: 0x570
	public Nullable DevelopTeleportPacket; //Field offset: 0x57C
	public Nullable DevelopSetDamageCoeffPacket; //Field offset: 0x58C
	public Nullable DevelopContainerHidePacket; //Field offset: 0x598
	public Nullable DevelopEnableServerHitDebuggingPacket; //Field offset: 0x5B0
	public Nullable DevelopKillMePacket; //Field offset: 0x5B4
	public Nullable DevelopKillAllAIs; //Field offset: 0x5C0
	public Nullable DevelopSpawnAI; //Field offset: 0x5C4
	public Nullable DevelopStartEvent; //Field offset: 0x5CC
	public Nullable DevelopSnapshotAllPlayers; //Field offset: 0x5D4
	public Nullable DevelopAirdrop; //Field offset: 0x5D8
	public Nullable DevelopUnlockAllDoors; //Field offset: 0x5EC
	public Nullable DevelopResetDiscardLimits; //Field offset: 0x5EF
	public Nullable DevelopResetBufferZoneUsageTime; //Field offset: 0x5F1
	public Nullable DevelopSetBufferZoneAccess; //Field offset: 0x5F4
	public Nullable DevelopSetEncodedRadioTransmitter; //Field offset: 0x5FC
	public Nullable DevelopSetActiveLighthouseTraderZoneDebug; //Field offset: 0x5FE
	public Nullable DevelopLighthouseKeeperServicesDebug; //Field offset: 0x600
	public Nullable DevelopBtrSupportServiceDebug; //Field offset: 0x604
	public PacketAuxiliaryData PacketAuxiliaryData; //Field offset: 0x60C
	public ulong FrameId; //Field offset: 0x618

	public bool HasCommandsForHands
	{
		 get { } //Length: 164
	}

	public bool HasImportantData
	{
		 get { } //Length: 906
	}

	private static Client2ServerPacket() { }

	public void AddInventoryCommand(InventoryCommandPacket inventoryCommandPacket) { }

	public void AddInventoryCommand(InventoryCommandPacket inventoryCommandPacket, Vector3 origin, Vector3 direction) { }

	public void AddInventoryCommand(Vector3 origin, Vector3 direction) { }

	public void ClearNonStaticData() { }

	public static bool DeserializeDiffUsing(IBitReaderStream reader, ref Client2ServerPacket current, Client2ServerPacket prevFrame) { }

	public bool get_HasCommandsForHands() { }

	public bool get_HasImportantData() { }

	public static void SerializeDiffUsing(IBitWriterStream writer, ref Client2ServerPacket current, Client2ServerPacket prevFrame) { }

	public void Set(MovementInfoPacket movementInfoPacket) { }

	public void Set(KnifePacket knifePacket) { }

	public void Set(EmptyHandPacket emptyHandPacket) { }

	public void Set(UsableItemPacket usableItemPacket) { }

	public void Set(HandsChangePacket handsChangePacket) { }

	public void Set(FirearmPacket firearmPacket) { }

	public void Set(GrenadePacket grenadePacket) { }

	public void SetPhraseCommand(EPhraseTrigger phraseCommand, int netPhraseId) { }

}

