namespace EFT.BinarySerialization;

[Extension]
public static class BinarySerializationMirrorExtensions
{
	private static List _types; //Field offset: 0x0

	private static BinarySerializationMirrorExtensions() { }

	[Extension]
	public static AggressorStats ReadAggressorStats(NetworkReader reader) { }

	[Extension]
	public static ClassQuaternion ReadClassQuaternion(NetworkReader reader) { }

	[Extension]
	public static ClassTransformSync ReadClassTransformSync(NetworkReader reader) { }

	[Extension]
	public static ClassVector3 ReadClassVector3(NetworkReader reader) { }

	[Extension]
	public static AddNoteOperationDescriptor ReadEFTAddNoteOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static AllergyPerkEffectParametersData ReadEFTAllergyPerkEffectParametersData(NetworkReader reader) { }

	[Extension]
	public static ApplyKeyOperationDescriptor ReadEFTApplyKeyOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static BattlePassProgressData ReadEFTBattlePassProgressData(NetworkReader reader) { }

	[Extension]
	public static BindItemOperationDescriptor ReadEFTBindItemOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static BodyPartDamageHistoryDescriptor ReadEFTBodyPartDamageHistoryDescriptor(NetworkReader reader) { }

	[Extension]
	public static BonusDescriptor ReadEFTBonusDescriptor(NetworkReader reader) { }

	[Extension]
	public static CheckMagazineOperationDescriptor ReadEFTCheckMagazineOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ContainerDescriptor ReadEFTContainerDescriptor(NetworkReader reader) { }

	[Extension]
	public static CounterCollectionDescriptor ReadEFTCounterCollectionDescriptor(NetworkReader reader) { }

	[Extension]
	public static CounterCollectionItemDescriptor ReadEFTCounterCollectionItemDescriptor(NetworkReader reader) { }

	[Extension]
	public static CreateMapMarkerOperationDescriptor ReadEFTCreateMapMarkerOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static CultistAmuletComponentDescriptor ReadEFTCultistAmuletComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static DamageHistoryDescriptor ReadEFTDamageHistoryDescriptor(NetworkReader reader) { }

	[Extension]
	public static DamageStatsDescriptor ReadEFTDamageStatsDescriptor(NetworkReader reader) { }

	[Extension]
	public static DeathCause ReadEFTDeathCause(NetworkReader reader) { }

	[Extension]
	public static DeleteMapMarkerOperationDescriptor ReadEFTDeleteMapMarkerOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static DeleteNoteOperationDescriptor ReadEFTDeleteNoteOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static DogTagComponentDescriptor ReadEFTDogTagComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static DroppedItem ReadEFTDroppedItem(NetworkReader reader) { }

	[Extension]
	public static EditMapMarkerOperationDescriptor ReadEFTEditMapMarkerOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static EditNoteOperationDescriptor ReadEFTEditNoteOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static EndingInfo ReadEFTEndingInfo(NetworkReader reader) { }

	[Extension]
	public static AvailableEndings ReadEFTEndingInfoAvailableEndings(NetworkReader reader) { }

	[Extension]
	public static ExamineMalfTypeOperationDescriptor ReadEFTExamineMalfTypeOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ExamineMalfunctionOperationDescriptor ReadEFTExamineMalfunctionOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ExamineOperationDescriptor ReadEFTExamineOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static FaceShieldComponentDescriptor ReadEFTFaceShieldComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static FaceshieldMarkOperationDescriptor ReadEFTFaceshieldMarkOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static FireModeComponentDescriptor ReadEFTFireModeComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static FoldableComponentDescriptor ReadEFTFoldableComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static FoldOperationDescriptor ReadEFTFoldOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static FoodDrinkComponentDescriptor ReadEFTFoodDrinkComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static FoundInRaidItem ReadEFTFoundInRaidItem(NetworkReader reader) { }

	[Extension]
	public static GridDescriptor ReadEFTGridDescriptor(NetworkReader reader) { }

	[Extension]
	public static GridItemAddressDescriptor ReadEFTGridItemAddressDescriptor(NetworkReader reader) { }

	[Extension]
	public static InventoryDescriptor ReadEFTInventoryDescriptor(NetworkReader reader) { }

	[Extension]
	public static InventoryEquipmentDescriptor ReadEFTInventoryEquipmentDescriptor(NetworkReader reader) { }

	[Extension]
	public static MapMarker ReadEFTInventoryLogicMapMarker(NetworkReader reader) { }

	[Extension]
	public static AddToWishlistOperationDescriptor ReadEFTInventoryLogicOperationsAddToWishlistOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ChangeItemsOperationDescriptor ReadEFTInventoryLogicOperationsChangeItemsOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ChangeWishlistItemCategoryOperationDescriptor ReadEFTInventoryLogicOperationsChangeWishlistItemCategoryOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static PurchaseTraderServiceOperationDescriptor ReadEFTInventoryLogicOperationsPurchaseTraderServiceOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ReadChapterConditionsOperationDescriptor ReadEFTInventoryLogicOperationsReadChapterConditionsOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ReadQuestConditionOperationDescriptor ReadEFTInventoryLogicOperationsReadQuestConditionOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ReadQuestLinkOperationDescriptor ReadEFTInventoryLogicOperationsReadQuestLinkOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ReadQuestNoteOperationDescriptor ReadEFTInventoryLogicOperationsReadQuestNoteOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static RemoveFromWishlistOperationDescriptor ReadEFTInventoryLogicOperationsRemoveFromWishlistOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static SearchContentOperationDescriptor ReadEFTInventoryLogicOperationsSearchContentOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static SearchSuboperationDescriptor ReadEFTInventoryLogicOperationsSearchSuboperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static SplitToNowhereDescriptor ReadEFTInventoryLogicOperationsSplitToNowhereDescriptor(NetworkReader reader) { }

	[Extension]
	public static TransferExfiltrationPaymentOperationDescriptor ReadEFTInventoryLogicOperationsTransferExfiltrationPaymentOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static TransferFromNowhereDescriptor ReadEFTInventoryLogicOperationsTransferFromNowhereDescriptor(NetworkReader reader) { }

	[Extension]
	public static ItemDescriptor ReadEFTItemDescriptor(NetworkReader reader) { }

	[Extension]
	public static ItemInfoDescriptor ReadEFTItemInfoDescriptor(NetworkReader reader) { }

	[Extension]
	public static ItemInGridDescriptor ReadEFTItemInGridDescriptor(NetworkReader reader) { }

	[Extension]
	public static JsonCorpseDescriptor ReadEFTJsonCorpseDescriptor(NetworkReader reader) { }

	[Extension]
	public static JsonLootItemDescriptor ReadEFTJsonLootItemDescriptor(NetworkReader reader) { }

	[Extension]
	public static KeyComponentDescriptor ReadEFTKeyComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static LightComponentDescriptor ReadEFTLightComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static LoadMagOperationDescriptor ReadEFTLoadMagOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static LockableComponentDescriptor ReadEFTLockableComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static LootDataDescriptor ReadEFTLootDataDescriptor(NetworkReader reader) { }

	[Extension]
	public static MalfunctionDescriptor ReadEFTMalfunctionDescriptor(NetworkReader reader) { }

	[Extension]
	public static MapComponentDescriptor ReadEFTMapComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static MedKitComponentDescriptor ReadEFTMedKitComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static MergeOperationDescriptor ReadEFTMergeOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static MoveOperationDescriptor ReadEFTMoveOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static NestedItemDescriptor ReadEFTNestedItemDescriptor(NetworkReader reader) { }

	[Extension]
	public static Note ReadEFTNotesNote(NetworkReader reader) { }

	[Extension]
	public static NotesDescriptor ReadEFTNotesNotesManagerNotesDescriptor(NetworkReader reader) { }

	[Extension]
	public static ObservedPlayerInventoryOperationDescriptor ReadEFTObservedPlayerInventoryOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static OperateStationaryWeaponOperationDescriptor ReadEFTOperateStationaryWeaponOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static OwnerItselfDescriptor ReadEFTOwnerItselfDescriptor(NetworkReader reader) { }

	[Extension]
	public static PlantTripwireOperationDescriptor ReadEFTPlantTripwireOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static PlayerVisualRepresentationDescriptor ReadEFTPlayerVisualRepresentationDescriptor(NetworkReader reader) { }

	[Extension]
	public static PoisonComponentDescriptor ReadEFTPoisonComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static PrestigeStatusData ReadEFTPrestigePrestigeStatusData(NetworkReader reader) { }

	[Extension]
	public static ProfileBanDescriptor ReadEFTProfileBanDescriptor(NetworkReader reader) { }

	[Extension]
	public static BattlePassDocumentLimitData ReadEFTProfileBattlePassDocumentLimitData(NetworkReader reader) { }

	[Extension]
	public static ProfileDescriptor ReadEFTProfileDescriptor(NetworkReader reader) { }

	[Extension]
	public static HealthInfo ReadEFTProfileHealthInfo(NetworkReader reader) { }

	[Extension]
	public static BodyPartInfo ReadEFTProfileHealthInfoBodyPartInfo(NetworkReader reader) { }

	[Extension]
	public static EffectInfo ReadEFTProfileHealthInfoEffectInfo(NetworkReader reader) { }

	[Extension]
	public static ValueInfo ReadEFTProfileHealthInfoValueInfo(NetworkReader reader) { }

	[Extension]
	public static ProfileInfoDescriptor ReadEFTProfileInfoDescriptor(NetworkReader reader) { }

	[Extension]
	public static MoneyTransferLimitData ReadEFTProfileMoneyTransferLimitData(NetworkReader reader) { }

	[Extension]
	public static ProfileSettings ReadEFTProfileSettings(NetworkReader reader) { }

	[Extension]
	public static ProfileStatsDescriptor ReadEFTProfileStatsDescriptor(NetworkReader reader) { }

	[Extension]
	public static ProfileStatsSeparatorDescriptor ReadEFTProfileStatsSeparatorDescriptor(NetworkReader reader) { }

	[Extension]
	public static UnlockedInfo ReadEFTProfileUnlockedInfo(NetworkReader reader) { }

	[Extension]
	public static QuestAcceptDescriptor ReadEFTQuestAcceptDescriptor(NetworkReader reader) { }

	[Extension]
	public static QuestFinishDescriptor ReadEFTQuestFinishDescriptor(NetworkReader reader) { }

	[Extension]
	public static QuestHandoverDescriptor ReadEFTQuestHandoverDescriptor(NetworkReader reader) { }

	[Extension]
	public static RecodableComponentDescriptor ReadEFTRecodableComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static RemoveOperationDescriptor ReadEFTRemoveOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static RepairableComponentDescriptor ReadEFTRepairableComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static RepairEnhancementComponentDescriptor ReadEFTRepairEnhancementComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static RepairKitComponentDescriptor ReadEFTRepairKitComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static ResourceItemComponentDescriptor ReadEFTResourceItemComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static ResourceKey ReadEFTResourceKey(NetworkReader reader) { }

	[Extension]
	public static SceneResourceKey ReadEFTSceneResourceKey(NetworkReader reader) { }

	[Extension]
	public static SeasonalPerkEffectParametersData ReadEFTSeasonalPerkEffectParametersData(NetworkReader reader) { }

	[Extension]
	public static SeasonalRewardData ReadEFTSeasonalRewardData(NetworkReader reader) { }

	[Extension]
	public static SetDialogProgressOperationDescriptor ReadEFTSetDialogProgressOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static SetupItemOperationDescriptor ReadEFTSetupItemOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ShellTemplateDescriptor ReadEFTShellTemplateDescriptor(NetworkReader reader) { }

	[Extension]
	public static SightComponentDescriptor ReadEFTSightComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static SkillsDescriptor ReadEFTSkillsDescriptor(NetworkReader reader) { }

	[Extension]
	public static MasteringInfoDescriptor ReadEFTSkillsDescriptorMasteringInfoDescriptor(NetworkReader reader) { }

	[Extension]
	public static SkillInfoDescriptor ReadEFTSkillsDescriptorSkillInfoDescriptor(NetworkReader reader) { }

	[Extension]
	public static SlotDescriptor ReadEFTSlotDescriptor(NetworkReader reader) { }

	[Extension]
	public static SlotItemAddressDescriptor ReadEFTSlotItemAddressDescriptor(NetworkReader reader) { }

	[Extension]
	public static SplitOperationDescriptor ReadEFTSplitOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static StackSlotDescriptor ReadEFTStackSlotDescriptor(NetworkReader reader) { }

	[Extension]
	public static StackSlotItemAddressDescriptor ReadEFTStackSlotItemAddressDescriptor(NetworkReader reader) { }

	[Extension]
	public static StudyItemOperationDescriptor ReadEFTStudyItemOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static StudyItemPlayerOperationDescriptor ReadEFTStudyItemPlayerOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static SwapOperationDescriptor ReadEFTSwapOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static TagComponentDescriptor ReadEFTTagComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static TagOperationDescriptor ReadEFTTagOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static ThrowOperationDescriptor ReadEFTThrowOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static TogglableComponentDescriptor ReadEFTTogglableComponentDescriptor(NetworkReader reader) { }

	[Extension]
	public static ToggleOperationDescriptor ReadEFTToggleOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static TraderInfoDescriptor ReadEFTTraderInfoDescriptor(NetworkReader reader) { }

	[Extension]
	public static TraderServiceAvailabilityData ReadEFTTraderServiceAvailabilityData(NetworkReader reader) { }

	[Extension]
	public static TransferOperationDescriptor ReadEFTTransferOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static UnbindItemOperationDescriptor ReadEFTUnbindItemOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static UnloadMagOperationDescriptor ReadEFTUnloadMagOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static VictimStats ReadEFTVictimStats(NetworkReader reader) { }

	[Extension]
	public static WeaponRechamberOperationDescriptor ReadEFTWeaponRechamberOperationDescriptor(NetworkReader reader) { }

	[Extension]
	public static T ReadEnum(NetworkReader reader) { }

	[Extension]
	public static GameEditionExperienceBonus ReadGameEditionExperienceBonus(NetworkReader reader) { }

	[Extension]
	public static InsuredProfileItems ReadJsonTypeInsuredProfileItems(NetworkReader reader) { }

	[Extension]
	public static PlayerInfo ReadJsonTypePlayerInfo(NetworkReader reader) { }

	[Extension]
	public static T ReadPolymorph(NetworkReader reader) { }

	[Extension]
	public static WeightedLootPointSpawnPosition ReadWeightedLootPointSpawnPosition(NetworkReader reader) { }

	[Extension]
	public static void WriteAggressorStats(NetworkWriter writer, AggressorStats target) { }

	[Extension]
	public static void WriteClassQuaternion(NetworkWriter writer, ClassQuaternion target) { }

	[Extension]
	public static void WriteClassTransformSync(NetworkWriter writer, ClassTransformSync target) { }

	[Extension]
	public static void WriteClassVector3(NetworkWriter writer, ClassVector3 target) { }

	[Extension]
	public static void WriteEFTAddNoteOperationDescriptor(NetworkWriter writer, AddNoteOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTAllergyPerkEffectParametersData(NetworkWriter writer, AllergyPerkEffectParametersData target) { }

	[Extension]
	public static void WriteEFTApplyKeyOperationDescriptor(NetworkWriter writer, ApplyKeyOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTBattlePassProgressData(NetworkWriter writer, BattlePassProgressData target) { }

	[Extension]
	public static void WriteEFTBindItemOperationDescriptor(NetworkWriter writer, BindItemOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTBodyPartDamageHistoryDescriptor(NetworkWriter writer, BodyPartDamageHistoryDescriptor target) { }

	[Extension]
	public static void WriteEFTBonusDescriptor(NetworkWriter writer, BonusDescriptor target) { }

	[Extension]
	public static void WriteEFTCheckMagazineOperationDescriptor(NetworkWriter writer, CheckMagazineOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTContainerDescriptor(NetworkWriter writer, ContainerDescriptor target) { }

	[Extension]
	public static void WriteEFTCounterCollectionDescriptor(NetworkWriter writer, CounterCollectionDescriptor target) { }

	[Extension]
	public static void WriteEFTCounterCollectionItemDescriptor(NetworkWriter writer, CounterCollectionItemDescriptor target) { }

	[Extension]
	public static void WriteEFTCreateMapMarkerOperationDescriptor(NetworkWriter writer, CreateMapMarkerOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTCultistAmuletComponentDescriptor(NetworkWriter writer, CultistAmuletComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTDamageHistoryDescriptor(NetworkWriter writer, DamageHistoryDescriptor target) { }

	[Extension]
	public static void WriteEFTDamageStatsDescriptor(NetworkWriter writer, DamageStatsDescriptor target) { }

	[Extension]
	public static void WriteEFTDeathCause(NetworkWriter writer, DeathCause target) { }

	[Extension]
	public static void WriteEFTDeleteMapMarkerOperationDescriptor(NetworkWriter writer, DeleteMapMarkerOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTDeleteNoteOperationDescriptor(NetworkWriter writer, DeleteNoteOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTDogTagComponentDescriptor(NetworkWriter writer, DogTagComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTDroppedItem(NetworkWriter writer, DroppedItem target) { }

	[Extension]
	public static void WriteEFTEditMapMarkerOperationDescriptor(NetworkWriter writer, EditMapMarkerOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTEditNoteOperationDescriptor(NetworkWriter writer, EditNoteOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTEndingInfo(NetworkWriter writer, EndingInfo target) { }

	[Extension]
	public static void WriteEFTEndingInfoAvailableEndings(NetworkWriter writer, AvailableEndings target) { }

	[Extension]
	public static void WriteEFTExamineMalfTypeOperationDescriptor(NetworkWriter writer, ExamineMalfTypeOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTExamineMalfunctionOperationDescriptor(NetworkWriter writer, ExamineMalfunctionOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTExamineOperationDescriptor(NetworkWriter writer, ExamineOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTFaceShieldComponentDescriptor(NetworkWriter writer, FaceShieldComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTFaceshieldMarkOperationDescriptor(NetworkWriter writer, FaceshieldMarkOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTFireModeComponentDescriptor(NetworkWriter writer, FireModeComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTFoldableComponentDescriptor(NetworkWriter writer, FoldableComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTFoldOperationDescriptor(NetworkWriter writer, FoldOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTFoodDrinkComponentDescriptor(NetworkWriter writer, FoodDrinkComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTFoundInRaidItem(NetworkWriter writer, FoundInRaidItem target) { }

	[Extension]
	public static void WriteEFTGridDescriptor(NetworkWriter writer, GridDescriptor target) { }

	[Extension]
	public static void WriteEFTGridItemAddressDescriptor(NetworkWriter writer, GridItemAddressDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryDescriptor(NetworkWriter writer, InventoryDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryEquipmentDescriptor(NetworkWriter writer, InventoryEquipmentDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicMapMarker(NetworkWriter writer, MapMarker target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsAddToWishlistOperationDescriptor(NetworkWriter writer, AddToWishlistOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsChangeItemsOperationDescriptor(NetworkWriter writer, ChangeItemsOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsChangeWishlistItemCategoryOperationDescriptor(NetworkWriter writer, ChangeWishlistItemCategoryOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsPurchaseTraderServiceOperationDescriptor(NetworkWriter writer, PurchaseTraderServiceOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsReadChapterConditionsOperationDescriptor(NetworkWriter writer, ReadChapterConditionsOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsReadQuestConditionOperationDescriptor(NetworkWriter writer, ReadQuestConditionOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsReadQuestLinkOperationDescriptor(NetworkWriter writer, ReadQuestLinkOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsReadQuestNoteOperationDescriptor(NetworkWriter writer, ReadQuestNoteOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsRemoveFromWishlistOperationDescriptor(NetworkWriter writer, RemoveFromWishlistOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsSearchContentOperationDescriptor(NetworkWriter writer, SearchContentOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsSearchSuboperationDescriptor(NetworkWriter writer, SearchSuboperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsSplitToNowhereDescriptor(NetworkWriter writer, SplitToNowhereDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsTransferExfiltrationPaymentOperationDescriptor(NetworkWriter writer, TransferExfiltrationPaymentOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTInventoryLogicOperationsTransferFromNowhereDescriptor(NetworkWriter writer, TransferFromNowhereDescriptor target) { }

	[Extension]
	public static void WriteEFTItemDescriptor(NetworkWriter writer, ItemDescriptor target) { }

	[Extension]
	public static void WriteEFTItemInfoDescriptor(NetworkWriter writer, ItemInfoDescriptor target) { }

	[Extension]
	public static void WriteEFTItemInGridDescriptor(NetworkWriter writer, ItemInGridDescriptor target) { }

	[Extension]
	public static void WriteEFTJsonCorpseDescriptor(NetworkWriter writer, JsonCorpseDescriptor target) { }

	[Extension]
	public static void WriteEFTJsonLootItemDescriptor(NetworkWriter writer, JsonLootItemDescriptor target) { }

	[Extension]
	public static void WriteEFTKeyComponentDescriptor(NetworkWriter writer, KeyComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTLightComponentDescriptor(NetworkWriter writer, LightComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTLoadMagOperationDescriptor(NetworkWriter writer, LoadMagOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTLockableComponentDescriptor(NetworkWriter writer, LockableComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTLootDataDescriptor(NetworkWriter writer, LootDataDescriptor target) { }

	[Extension]
	public static void WriteEFTMalfunctionDescriptor(NetworkWriter writer, MalfunctionDescriptor target) { }

	[Extension]
	public static void WriteEFTMapComponentDescriptor(NetworkWriter writer, MapComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTMedKitComponentDescriptor(NetworkWriter writer, MedKitComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTMergeOperationDescriptor(NetworkWriter writer, MergeOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTMoveOperationDescriptor(NetworkWriter writer, MoveOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTNestedItemDescriptor(NetworkWriter writer, NestedItemDescriptor target) { }

	[Extension]
	public static void WriteEFTNotesNote(NetworkWriter writer, Note target) { }

	[Extension]
	public static void WriteEFTNotesNotesManagerNotesDescriptor(NetworkWriter writer, NotesDescriptor target) { }

	[Extension]
	public static void WriteEFTObservedPlayerInventoryOperationDescriptor(NetworkWriter writer, ObservedPlayerInventoryOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTOperateStationaryWeaponOperationDescriptor(NetworkWriter writer, OperateStationaryWeaponOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTOwnerItselfDescriptor(NetworkWriter writer, OwnerItselfDescriptor target) { }

	[Extension]
	public static void WriteEFTPlantTripwireOperationDescriptor(NetworkWriter writer, PlantTripwireOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTPlayerVisualRepresentationDescriptor(NetworkWriter writer, PlayerVisualRepresentationDescriptor target) { }

	[Extension]
	public static void WriteEFTPoisonComponentDescriptor(NetworkWriter writer, PoisonComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTPrestigePrestigeStatusData(NetworkWriter writer, PrestigeStatusData target) { }

	[Extension]
	public static void WriteEFTProfileBanDescriptor(NetworkWriter writer, ProfileBanDescriptor target) { }

	[Extension]
	public static void WriteEFTProfileBattlePassDocumentLimitData(NetworkWriter writer, BattlePassDocumentLimitData target) { }

	[Extension]
	public static void WriteEFTProfileDescriptor(NetworkWriter writer, ProfileDescriptor target) { }

	[Extension]
	public static void WriteEFTProfileHealthInfo(NetworkWriter writer, HealthInfo target) { }

	[Extension]
	public static void WriteEFTProfileHealthInfoBodyPartInfo(NetworkWriter writer, BodyPartInfo target) { }

	[Extension]
	public static void WriteEFTProfileHealthInfoEffectInfo(NetworkWriter writer, EffectInfo target) { }

	[Extension]
	public static void WriteEFTProfileHealthInfoValueInfo(NetworkWriter writer, ValueInfo target) { }

	[Extension]
	public static void WriteEFTProfileInfoDescriptor(NetworkWriter writer, ProfileInfoDescriptor target) { }

	[Extension]
	public static void WriteEFTProfileMoneyTransferLimitData(NetworkWriter writer, MoneyTransferLimitData target) { }

	[Extension]
	public static void WriteEFTProfileSettings(NetworkWriter writer, ProfileSettings target) { }

	[Extension]
	public static void WriteEFTProfileStatsDescriptor(NetworkWriter writer, ProfileStatsDescriptor target) { }

	[Extension]
	public static void WriteEFTProfileStatsSeparatorDescriptor(NetworkWriter writer, ProfileStatsSeparatorDescriptor target) { }

	[Extension]
	public static void WriteEFTProfileUnlockedInfo(NetworkWriter writer, UnlockedInfo target) { }

	[Extension]
	public static void WriteEFTQuestAcceptDescriptor(NetworkWriter writer, QuestAcceptDescriptor target) { }

	[Extension]
	public static void WriteEFTQuestFinishDescriptor(NetworkWriter writer, QuestFinishDescriptor target) { }

	[Extension]
	public static void WriteEFTQuestHandoverDescriptor(NetworkWriter writer, QuestHandoverDescriptor target) { }

	[Extension]
	public static void WriteEFTRecodableComponentDescriptor(NetworkWriter writer, RecodableComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTRemoveOperationDescriptor(NetworkWriter writer, RemoveOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTRepairableComponentDescriptor(NetworkWriter writer, RepairableComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTRepairEnhancementComponentDescriptor(NetworkWriter writer, RepairEnhancementComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTRepairKitComponentDescriptor(NetworkWriter writer, RepairKitComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTResourceItemComponentDescriptor(NetworkWriter writer, ResourceItemComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTResourceKey(NetworkWriter writer, ResourceKey target) { }

	[Extension]
	public static void WriteEFTSceneResourceKey(NetworkWriter writer, SceneResourceKey target) { }

	[Extension]
	public static void WriteEFTSeasonalPerkEffectParametersData(NetworkWriter writer, SeasonalPerkEffectParametersData target) { }

	[Extension]
	public static void WriteEFTSeasonalRewardData(NetworkWriter writer, SeasonalRewardData target) { }

	[Extension]
	public static void WriteEFTSetDialogProgressOperationDescriptor(NetworkWriter writer, SetDialogProgressOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTSetupItemOperationDescriptor(NetworkWriter writer, SetupItemOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTShellTemplateDescriptor(NetworkWriter writer, ShellTemplateDescriptor target) { }

	[Extension]
	public static void WriteEFTSightComponentDescriptor(NetworkWriter writer, SightComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTSkillsDescriptor(NetworkWriter writer, SkillsDescriptor target) { }

	[Extension]
	public static void WriteEFTSkillsDescriptorMasteringInfoDescriptor(NetworkWriter writer, MasteringInfoDescriptor target) { }

	[Extension]
	public static void WriteEFTSkillsDescriptorSkillInfoDescriptor(NetworkWriter writer, SkillInfoDescriptor target) { }

	[Extension]
	public static void WriteEFTSlotDescriptor(NetworkWriter writer, SlotDescriptor target) { }

	[Extension]
	public static void WriteEFTSlotItemAddressDescriptor(NetworkWriter writer, SlotItemAddressDescriptor target) { }

	[Extension]
	public static void WriteEFTSplitOperationDescriptor(NetworkWriter writer, SplitOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTStackSlotDescriptor(NetworkWriter writer, StackSlotDescriptor target) { }

	[Extension]
	public static void WriteEFTStackSlotItemAddressDescriptor(NetworkWriter writer, StackSlotItemAddressDescriptor target) { }

	[Extension]
	public static void WriteEFTStudyItemOperationDescriptor(NetworkWriter writer, StudyItemOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTStudyItemPlayerOperationDescriptor(NetworkWriter writer, StudyItemPlayerOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTSwapOperationDescriptor(NetworkWriter writer, SwapOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTTagComponentDescriptor(NetworkWriter writer, TagComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTTagOperationDescriptor(NetworkWriter writer, TagOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTThrowOperationDescriptor(NetworkWriter writer, ThrowOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTTogglableComponentDescriptor(NetworkWriter writer, TogglableComponentDescriptor target) { }

	[Extension]
	public static void WriteEFTToggleOperationDescriptor(NetworkWriter writer, ToggleOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTTraderInfoDescriptor(NetworkWriter writer, TraderInfoDescriptor target) { }

	[Extension]
	public static void WriteEFTTraderServiceAvailabilityData(NetworkWriter writer, TraderServiceAvailabilityData target) { }

	[Extension]
	public static void WriteEFTTransferOperationDescriptor(NetworkWriter writer, TransferOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTUnbindItemOperationDescriptor(NetworkWriter writer, UnbindItemOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTUnloadMagOperationDescriptor(NetworkWriter writer, UnloadMagOperationDescriptor target) { }

	[Extension]
	public static void WriteEFTVictimStats(NetworkWriter writer, VictimStats target) { }

	[Extension]
	public static void WriteEFTWeaponRechamberOperationDescriptor(NetworkWriter writer, WeaponRechamberOperationDescriptor target) { }

	[Extension]
	public static void WriteEnum(NetworkWriter writer, T value) { }

	[Extension]
	public static void WriteGameEditionExperienceBonus(NetworkWriter writer, GameEditionExperienceBonus target) { }

	[Extension]
	public static void WriteJsonTypeInsuredProfileItems(NetworkWriter writer, InsuredProfileItems target) { }

	[Extension]
	public static void WriteJsonTypePlayerInfo(NetworkWriter writer, PlayerInfo target) { }

	[Extension]
	public static void WritePolymorph(NetworkWriter writer, T target) { }

	[Extension]
	public static void WriteWeightedLootPointSpawnPosition(NetworkWriter writer, WeightedLootPointSpawnPosition target) { }

}

