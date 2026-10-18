namespace EFT;

public struct SelfPlayerInfo
{
	public const int PROCESSED_CRITICAL_PACKETS_COMMON_MAX_COUNT = 7; //Field offset: 0x0
	private const int PROCESSED_CRITICAL_PACKETS_MAX_COUNT = 2047; //Field offset: 0x0
	private const int OPERATIONS_MAX_SIZE = 320; //Field offset: 0x0
	private const int STATUS_MAX_SIZE = 64; //Field offset: 0x0
	private const int DEFAULT_MAX_SIZE = 16; //Field offset: 0x0
	private const int RTT_MAX_VALUE = 512; //Field offset: 0x0
	private const int ARMOR_UPDATE_MAX_SIZE = 32; //Field offset: 0x0
	public Nullable RTT; //Field offset: 0x0
	public int ServerFixedUpdate; //Field offset: 0x4
	public int ServerTime; //Field offset: 0x8
	public float ServerWorldTime; //Field offset: 0xC
	public List HitInfos; //Field offset: 0x10
	public List DetailedHitInfo; //Field offset: 0x18
	public List ArmorUpdates; //Field offset: 0x20
	public List PoisonUpdates; //Field offset: 0x28
	public List OperationStatuses; //Field offset: 0x30
	public List GlobalOperations; //Field offset: 0x38
	public CommonPacket CommonPacket; //Field offset: 0x40
	public Nullable SyncHealthPacket; //Field offset: 0x48
	public Nullable AcceptHitDebugDataPacket; //Field offset: 0xA0
	public Nullable QuestConditionValueChangedPacket; //Field offset: 0xB8
	public Nullable AchievementConditionValueChangedPacket; //Field offset: 0x118
	public Nullable PrestigeConditionValueChangedPacket; //Field offset: 0x178
	public Nullable ShowStatNotificationPacket; //Field offset: 0x1D8
	public Nullable SyncSessionExperiencePacket; //Field offset: 0x1F8
	public Nullable PlayerDiedPacket; //Field offset: 0x200
	public Nullable ClientConfirmCallbackPacket; //Field offset: 0x238
	public Nullable WeaponOverheatPacket; //Field offset: 0x258
	public Nullable ChangeSkillExperiencePacket; //Field offset: 0x280
	public Nullable ChangeMasteringExperiencePacket; //Field offset: 0x2A0
	public Nullable TradersInfoPacket; //Field offset: 0x2C0
	public Nullable TriggeredPerkPacket; //Field offset: 0x2E0
	public Nullable KeyUsagePacket; //Field offset: 0x308
	public Nullable StringNotificationPacket; //Field offset: 0x328
	public Nullable RadioTransmitterPacket; //Field offset: 0x340
	public Nullable LighthouseTraderZoneDataPacket; //Field offset: 0x360
	public Nullable LighthouseTraderZoneDebugToolPacket; //Field offset: 0x378
	public Nullable InteractWithBtrPacket; //Field offset: 0x390
	public Nullable InteractWithTripwirePacket; //Field offset: 0x3A0
	public Nullable RaidDialogEntryClaimResponsePacket; //Field offset: 0x3B0
	public bool TalkDetected; //Field offset: 0x3C8
	public int CriticalPacketsProcessed; //Field offset: 0x3CC
	private bool _hasData; //Field offset: 0x3D0

	public void AddAcceptHitDebugDataPacket(ClientShot[] clientShots) { }

	public void AddAchievementConditionValueChangedPacket(ConditionalProgressData conditionalData) { }

	public void AddChangeMasteringExperiencePacket(string groupName, float value) { }

	public void AddChangeSkillExperiencePacket(byte skillId, float value, float effectiveness, float pointsEarned) { }

	public void AddClientConfirmCallbackPacket(uint callbackId, string error) { }

	public void AddClientRadioTransmitterPacket(bool isEncoded, RadioTransmitterStatus status, bool isAgressor) { }

	public void AddDetailedHitInfo(EDamageType damageType, int damage, int absorbed, int staminaLoss, EBodyPart part, MaterialType special) { }

	private void AddDetailedHitInfo(DetailedHitInfo hitInfo) { }

	public void AddGlobalOperation(ObservedPlayerInventoryOperationDescriptor descriptor) { }

	public void AddGlobalOperation(InventoryOperationDescriptor descriptor) { }

	public void AddHitInfo(HitInfo hitInfo) { }

	public void AddKeyUsagePacket(string itemId, int numberOfUsages, bool removed) { }

	public void AddLighthouseTraderZoneDebugToolPacket(bool isActive) { }

	public void AddOperationStatus(InventoryOperationStatus operationStatus) { }

	public void AddPlayerDiedPacket(string aggressor, EPlayerSide aggressorSide, EBodyPartColliderType colliderType, string weaponName, EMemberCategory memberCategory, string aggressorMainCharacterName, WildSpawnType role, int prestigeLevel) { }

	public void AddPrestigeConditionValueChangedPacket(ConditionalProgressData conditionalData) { }

	public void AddQuestConditionValueChangedPacket(ConditionalProgressData conditionalData) { }

	public void AddShowStatNotificationPacket(uint localizationKey1, uint localizationKey2, int value) { }

	public void AddStringNotificationPacket(string message) { }

	public void AddSyncHealthPacket(SyncHealthPacket packet) { }

	public void AddSyncSessionExperiencePacket(int experience) { }

	public void AddTraderInfoPacket(string traderId, double standing) { }

	public void AddTriggeredPerkPacket(string perkId) { }

	public void AddWeaponOverheatPacket(string weaponId, float lastShotTime, float lastOverheat, bool slideReached) { }

	public static void Deserialize(IBitReaderStream reader, ref SelfPlayerInfo selfPlayerInfo) { }

	public void FlushSkills() { }

	public bool HasData() { }

	public virtual string ToString() { }

	public void UpdateArmor(ArmorUpdate a) { }

	public void UpdateSideEffectResource(SideEffectUpdate update) { }

}

