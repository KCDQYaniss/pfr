namespace EFT;

public sealed class GlobalConfiguration
{
	internal class AimDrills
	{
		public float WeaponShotAction; //Field offset: 0x10

		public AimDrills() { }

	}

	internal class AimingConfiguration
	{
		public Vector3 ProceduralIntensityByPose; //Field offset: 0x10
		public float AimProceduralIntensity; //Field offset: 0x1C
		public float MinTimeHeavy; //Field offset: 0x20
		public float MaxTimeHeavy; //Field offset: 0x24
		public float MinTimeLight; //Field offset: 0x28
		public float MaxTimeLight; //Field offset: 0x2C
		public float HeavyWeight; //Field offset: 0x30
		public float LightWeight; //Field offset: 0x34
		public float RecoilScaling; //Field offset: 0x38
		public float RecoilDamping; //Field offset: 0x3C
		public float CameraSnapGlobalMult; //Field offset: 0x40
		public Vector3 RecoilXIntensityByPose; //Field offset: 0x44
		public Vector3 RecoilYIntensityByPose; //Field offset: 0x50
		public Vector3 RecoilZIntensityByPose; //Field offset: 0x5C
		public bool RecoilCrank; //Field offset: 0x68
		public float RecoilHandDamping; //Field offset: 0x6C
		public float RecoilConvergenceMult; //Field offset: 0x70
		public float RecoilVertBonus; //Field offset: 0x74
		public float RecoilBackBonus; //Field offset: 0x78

		public AimingConfiguration() { }

	}

	internal sealed class AirdropSettings
	{
		public int PlaneMinFlightHeight; //Field offset: 0x10
		public int PlaneMaxFlightHeight; //Field offset: 0x14
		public int PlaneSpeed; //Field offset: 0x18
		public int PlaneAdditionalDistance; //Field offset: 0x1C
		public int ParachuteStartOpenHeight; //Field offset: 0x20
		public int ParachuteEndOpenHeight; //Field offset: 0x24
		public int PlaneAirdropDuration; //Field offset: 0x28
		public int SmokeActivateHeight; //Field offset: 0x2C
		public int PlaneAirdropSmoke; //Field offset: 0x30
		public int PlaneAirdropFlareWait; //Field offset: 0x34
		public EAirdropViewType AirdropViewType; //Field offset: 0x38

		public AirdropSettings() { }

	}

	internal sealed class ArmorMaterialValues
	{
		public float Destructibility; //Field offset: 0x10
		public float MinRepairDegradation; //Field offset: 0x14
		public float MaxRepairDegradation; //Field offset: 0x18
		public float ExplosionDestructibility; //Field offset: 0x1C
		public float MinRepairKitDegradation; //Field offset: 0x20
		public float MaxRepairKitDegradation; //Field offset: 0x24

		public ArmorMaterialValues() { }

	}

	internal sealed class ArmorSettings
	{
		internal sealed class ArmorClassSettings
		{
			[JsonProperty("resistance")]
			public int Resistance; //Field offset: 0x10

			public ArmorClassSettings() { }

		}

		[JsonProperty("class")]
		public ArmorClassSettings[] ArmorClass; //Field offset: 0x10

		public ArmorSettings() { }

		public ArmorClassSettings GetArmorClass(int classIndex) { }

	}

	internal class Assault
	{
		public float WeaponReloadAction; //Field offset: 0x10
		public float WeaponShotAction; //Field offset: 0x14
		public float WeaponFixAction; //Field offset: 0x18
		public float WeaponChamberAction; //Field offset: 0x1C

		public Assault() { }

	}

	internal class Attention
	{
		public float ExamineWithInstruction; //Field offset: 0x10
		public float FindActionTrue; //Field offset: 0x14
		public float FindActionFalse; //Field offset: 0x18

		public Attention() { }

	}

	internal sealed class BallisticSettings
	{
		public float GlobalDamageDegradationCoefficient; //Field offset: 0x10

		public BallisticSettings() { }

	}

	internal sealed class BattlePassConfig
	{
		[JsonProperty("battlePasses")]
		public readonly IReadOnlyList BattlePasses; //Field offset: 0x10
		[CompilerGenerated]
		private BattlePassUniversalDocumentData <UniversalDocumentData>k__BackingField; //Field offset: 0x18

		[JsonIgnore]
		public private BattlePassUniversalDocumentData UniversalDocumentData
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public BattlePassConfig() { }

		[CompilerGenerated]
		public BattlePassUniversalDocumentData get_UniversalDocumentData() { }

		public void Init(BattlePassUniversalDocumentData universalDocumentData) { }

		[CompilerGenerated]
		private void set_UniversalDocumentData(BattlePassUniversalDocumentData value) { }

	}

	internal sealed class BufferZoneSettings
	{
		public float CustomerCriticalTimeStart; //Field offset: 0x10
		public float CustomerKickNotifTime; //Field offset: 0x14
		public float CustomerAccessTime; //Field offset: 0x18

		public BufferZoneSettings() { }

	}

	internal class BuffSettings
	{
		public float CommonBuffMinChanceValue; //Field offset: 0x10
		public float CommonBuffChanceLevelBonus; //Field offset: 0x14
		public float RareBuffChanceCoff; //Field offset: 0x18
		public float ReceivedDurabilityMaxPercent; //Field offset: 0x1C

		public BuffSettings() { }

	}

	internal class Charisma
	{
		internal class CharismaBonusSettings
		{
			public LevelBonusSettings LevelBonusSettings; //Field offset: 0x10
			public EliteBonusSettings EliteBonusSettings; //Field offset: 0x18

			public CharismaBonusSettings() { }

		}

		internal class EliteBonusSettings
		{
			public float ScavCaseDiscount; //Field offset: 0x10
			public float FenceStandingLossDiscount; //Field offset: 0x14
			public int RepeatableQuestExtraCount; //Field offset: 0x18

			public EliteBonusSettings() { }

		}

		internal class LevelBonusSettings
		{
			public float RepeatableQuestChangeDiscount; //Field offset: 0x10
			public float HealthRestoreDiscount; //Field offset: 0x14
			public float HealthRestoreTraderDiscount; //Field offset: 0x18
			public float InsuranceDiscount; //Field offset: 0x1C
			public float InsuranceTraderDiscount; //Field offset: 0x20
			public float PaidExitDiscount; //Field offset: 0x24

			public LevelBonusSettings() { }

		}

		public float SkillProgressInt; //Field offset: 0x10
		public float SkillProgressAtn; //Field offset: 0x14
		public float SkillProgressPer; //Field offset: 0x18
		public CharismaBonusSettings BonusSettings; //Field offset: 0x20

		public Charisma() { }

	}

	internal sealed class CoopGlobalSettings
	{
		public string[] AvailableVersions; //Field offset: 0x10

		public CoopGlobalSettings() { }

	}

	internal class CovertMovement
	{
		public float MovementAction; //Field offset: 0x10

		public CovertMovement() { }

	}

	internal sealed class Crafting
	{
		public float PointsPerCraftingCycle; //Field offset: 0x10
		public float CraftingCycleHours; //Field offset: 0x14
		public float PointsPerUniqueCraftCycle; //Field offset: 0x18
		public float UniqueCraftsPerCycle; //Field offset: 0x1C
		public float CraftTimeReductionPerLevel; //Field offset: 0x20
		public float ProductionTimeReductionPerLevel; //Field offset: 0x24
		public float EliteExtraProductions; //Field offset: 0x28
		[JsonProperty("CraftingPointsToInteligence")]
		public float CraftingPointsToIntelligence; //Field offset: 0x2C

		public float CraftingCycleSeconds
		{
			 get { } //Length: 22
		}

		public float PointsPerOriginalCraft
		{
			 get { } //Length: 11
		}

		public float PointsPerSecond
		{
			 get { } //Length: 31
		}

		public Crafting() { }

		public float get_CraftingCycleSeconds() { }

		public float get_PointsPerOriginalCraft() { }

		public float get_PointsPerSecond() { }

	}

	internal class Customization
	{
		public string[] ProfileVersionsBothFactionsSuitsInterface; //Field offset: 0x10

		public Customization() { }

		public bool IsAllSidesCustomizationAllowed(string profileVersion) { }

	}

	internal class DMR
	{
		public float WeaponReloadAction; //Field offset: 0x10
		public float WeaponShotAction; //Field offset: 0x14
		public float WeaponFixAction; //Field offset: 0x18
		public float WeaponChamberAction; //Field offset: 0x1C

		public DMR() { }

	}

	internal class Endurance
	{
		public float MovementAction; //Field offset: 0x10
		public float SprintAction; //Field offset: 0x14
		public float GainPerFatigueStack; //Field offset: 0x18

		public Endurance() { }

	}

	internal sealed class ExperienceSettings
	{
		internal sealed class HealSettings
		{
			[JsonProperty("expForHeal")]
			public float ExpForHeal; //Field offset: 0x10
			[JsonProperty("expForEnergy")]
			public float ExpForEnergy; //Field offset: 0x14
			[JsonProperty("expForHydration")]
			public float ExpForHydration; //Field offset: 0x18

			public HealSettings() { }

		}

		internal sealed class KillSettings
		{
			internal sealed class ComboSettings
			{
				[JsonProperty("percent")]
				public int Percent; //Field offset: 0x10

				public ComboSettings() { }

			}

			[JsonProperty("victimLevelExp")]
			public int VictimLevelExp; //Field offset: 0x10
			[JsonProperty("victimBotLevelExp")]
			public int VictimBotLevelExp; //Field offset: 0x14
			[JsonProperty("pmcHeadShotMult")]
			public float PmcHeadShotMult; //Field offset: 0x18
			[JsonProperty("botHeadShotMult")]
			public float BotHeadShotMult; //Field offset: 0x1C
			[JsonProperty("pmcExpOnDamageAllHealth")]
			public float PmcExpOnDamageAllHealth; //Field offset: 0x20
			[JsonProperty("botExpOnDamageAllHealth")]
			public float BotExpOnDamageAllHealth; //Field offset: 0x24
			[JsonProperty("longShotDistance")]
			public float LongShotDistance; //Field offset: 0x28
			[JsonProperty("bloodLossToLitre")]
			public float BloodLossToLitre; //Field offset: 0x2C
			[JsonProperty("combo")]
			public ComboSettings[] Combo; //Field offset: 0x30

			public KillSettings() { }

			public int GetKillingBonusPercent(int killed) { }

		}

		internal sealed class LevelSettings
		{
			[JsonProperty("exp_table")]
			public GlobalsArray Table; //Field offset: 0x10
			[JsonProperty("mastering1")]
			public int Mastering1; //Field offset: 0x18
			[JsonProperty("mastering2")]
			public int Mastering2; //Field offset: 0x1C

			public LevelSettings() { }

		}

		internal sealed class LootAttemptSettings
		{
			[JsonProperty("k_exp")]
			public float Mult; //Field offset: 0x10

			public LootAttemptSettings() { }

		}

		internal sealed class MatchEndSettings
		{
			internal sealed class TransitMult
			{
				[JsonProperty("mlp")]
				public float mlp; //Field offset: 0x10

				public TransitMult() { }

			}

			[JsonProperty("survived_exp_requirement")]
			public int SurvivedExpRequirement; //Field offset: 0x10
			[JsonProperty("survived_seconds_requirement")]
			public int SurvivedTimeRequirement; //Field offset: 0x14
			[JsonProperty("survived_exp_reward")]
			public int SurvivedReward; //Field offset: 0x18
			[JsonProperty("transit_exp_reward")]
			public int TransitReward; //Field offset: 0x1C
			[JsonProperty("mia_exp_reward")]
			public int MiaReward; //Field offset: 0x20
			[JsonProperty("runner_exp_reward")]
			public int RunnerReward; //Field offset: 0x24
			[JsonProperty("leftMult")]
			public float LeftMult; //Field offset: 0x28
			[JsonProperty("killedMult")]
			public float KilledMult; //Field offset: 0x2C
			[JsonProperty("miaMult")]
			public float MiaMult; //Field offset: 0x30
			[JsonProperty("survivedMult")]
			public float SurvivedMult; //Field offset: 0x34
			[JsonProperty("runnerMult")]
			public float RunnerMult; //Field offset: 0x38
			[JsonProperty("transit_mult")]
			public TransitMult[] transit_mult; //Field offset: 0x40

			public MatchEndSettings() { }

			public float GetMultiplier(ExitStatus exitStatus, int transitCount) { }

			private float GetMultiplierByTransitCount(int count) { }

			public int GetReward(ExitStatus status) { }

			public bool IsRunnerExitPrediction(int sessionExp, float pastTime, float remainingCountdown) { }

			public bool IsSurvivedExit(int sessionExp, float pastTime) { }

		}

		[JsonProperty("loot_attempts")]
		public LootAttemptSettings[] LootAttempts; //Field offset: 0x10
		[JsonProperty("expForLockedDoorOpen")]
		public int ExpForLockedDoorOpen; //Field offset: 0x18
		[JsonProperty("expForLockedDoorBreach")]
		public int ExpForLockedDoorBreach; //Field offset: 0x1C
		[JsonProperty("kill")]
		public KillSettings Kill; //Field offset: 0x20
		[JsonProperty("level")]
		public LevelSettings Level; //Field offset: 0x28
		[JsonProperty("heal")]
		public HealSettings Heal; //Field offset: 0x30
		[JsonProperty("match_end")]
		public MatchEndSettings MatchEnd; //Field offset: 0x38
		[JsonProperty("triggerMult")]
		public float TriggerMult; //Field offset: 0x40
		[JsonProperty("expForLevelOneDogtag")]
		public float ExpForLevelOneDogtag; //Field offset: 0x44

		public ExperienceSettings() { }

		public float GetMultForLootingAttempts(int count) { }

	}

	internal sealed class FenceGlobalSettings
	{
		[JsonProperty("FenceId")]
		public MongoID FenceId; //Field offset: 0x10
		[JsonProperty("Levels")]
		public readonly SortedDictionary LoyaltyLevels; //Field offset: 0x28
		[JsonProperty("PmcBotKillStandingMultiplier")]
		public float PmcBotKillStandingMultiplier; //Field offset: 0x30

		public FenceGlobalSettings() { }

		public FenceLoyaltyLevel GetSettings(double standing) { }

		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context) { }

	}

	internal class GlobalSkillsSettings
	{
		public float SkillProgressRate; //Field offset: 0x10
		public float WeaponSkillProgressRate; //Field offset: 0x14
		public float WeaponSkillRecoilBonusPerLevel; //Field offset: 0x18
		public float MountingErgonomicsBonusPerLevel; //Field offset: 0x1C
		public float BipodErgonomicsBonusPerLevel; //Field offset: 0x20
		public HideoutManagement HideoutManagement; //Field offset: 0x28
		public Crafting Crafting; //Field offset: 0x30
		public Metabolism Metabolism; //Field offset: 0x38
		public Immunity Immunity; //Field offset: 0x40
		public Endurance Endurance; //Field offset: 0x48
		public Strength Strength; //Field offset: 0x50
		public Vitality Vitality; //Field offset: 0x58
		public HealthSkill Health; //Field offset: 0x60
		public StressResistance StressResistance; //Field offset: 0x68
		public Throwing Throwing; //Field offset: 0x70
		public RecoilControl RecoilControl; //Field offset: 0x78
		public Pistol Pistol; //Field offset: 0x80
		public Assault Assault; //Field offset: 0x88
		public Shotgun Shotgun; //Field offset: 0x90
		public Sniper Sniper; //Field offset: 0x98
		public DMR DMR; //Field offset: 0xA0
		public CovertMovement CovertMovement; //Field offset: 0xA8
		public Search Search; //Field offset: 0xB0
		public MagDrills MagDrills; //Field offset: 0xB8
		public Perception Perception; //Field offset: 0xC0
		public Intellect Intellect; //Field offset: 0xC8
		public Attention Attention; //Field offset: 0xD0
		public Charisma Charisma; //Field offset: 0xD8
		public Memory Memory; //Field offset: 0xE0
		public Surgery Surgery; //Field offset: 0xE8
		public AimDrills AimDrills; //Field offset: 0xF0
		public WeaponTreatment WeaponTreatment; //Field offset: 0xF8
		public TroubleShooting TroubleShooting; //Field offset: 0x100
		public Revolver Revolver; //Field offset: 0x108
		public LightVests LightVests; //Field offset: 0x110
		public HeavyVests HeavyVests; //Field offset: 0x118

		public GlobalSkillsSettings() { }

	}

	internal sealed class HealthSettings
	{
		internal sealed class FallingSettings
		{
			public float DamagePerMeter; //Field offset: 0x10
			public float SafeHeight; //Field offset: 0x14

			public FallingSettings() { }

		}

		internal sealed class HealPriceSettings
		{
			public float HealthPointPrice; //Field offset: 0x10
			public float HydrationPointPrice; //Field offset: 0x14
			public float EnergyPointPrice; //Field offset: 0x18
			public int TrialLevels; //Field offset: 0x1C
			public int TrialRaids; //Field offset: 0x20

			public HealPriceSettings() { }

			public bool IsFastHealFree(Profile profile) { }

		}

		internal sealed class HealthFactorData
		{
			public float Minimum; //Field offset: 0x10
			public float Maximum; //Field offset: 0x14
			public float Default; //Field offset: 0x18
			public float OverDamageReceivedMultiplier; //Field offset: 0x1C
			public float EnvironmentDamageMultiplier; //Field offset: 0x20

			public HealthValue HealthValue
			{
				 get { } //Length: 190
			}

			public ValueInfo ValueInfo
			{
				 get { } //Length: 100
			}

			public ValueStruct ValueStruct
			{
				 get { } //Length: 33
			}

			public HealthFactorData() { }

			public HealthValue get_HealthValue() { }

			public ValueInfo get_ValueInfo() { }

			public ValueStruct get_ValueStruct() { }

		}

		internal sealed class PlayerHealthFactorsSettings
		{
			[CompilerGenerated]
			private Dictionary <BodyPartsSettings>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			private Dictionary <HealthFactorsSettings>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			private string <DefaultStimulatorBuff>k__BackingField; //Field offset: 0x20

			[JsonProperty]
			public private Dictionary BodyPartsSettings
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				private set { } //Length: 82
			}

			[JsonProperty]
			public private string DefaultStimulatorBuff
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				private set { } //Length: 82
			}

			[JsonProperty]
			public private Dictionary HealthFactorsSettings
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				private set { } //Length: 82
			}

			public PlayerHealthFactorsSettings() { }

			[CompilerGenerated]
			public Dictionary get_BodyPartsSettings() { }

			[CompilerGenerated]
			public string get_DefaultStimulatorBuff() { }

			[CompilerGenerated]
			public Dictionary get_HealthFactorsSettings() { }

			[CompilerGenerated]
			private void set_BodyPartsSettings(Dictionary value) { }

			[CompilerGenerated]
			private void set_DefaultStimulatorBuff(string value) { }

			[CompilerGenerated]
			private void set_HealthFactorsSettings(Dictionary value) { }

		}

		private const float TEMPERATURE_DEFAULT_CURRENT = 36.6; //Field offset: 0x0
		private const float TEMPERATURE_MINIMUM_CURRENT = 28; //Field offset: 0x0
		private const float TEMPERATURE_MAXIMUM_CURRENT = 40; //Field offset: 0x0
		private const float DEFAULT_MINIMUM_VALUE = 0; //Field offset: 0x0
		private const float DEFAULT_MAXIMUM_VALUE = 100; //Field offset: 0x0
		[CompilerGenerated]
		private PlayerHealthFactorsSettings <ProfileHealthSettings>k__BackingField; //Field offset: 0x10
		public EffectsSettings Effects; //Field offset: 0x18
		public FallingSettings Falling; //Field offset: 0x20
		public HealPriceSettings HealPrice; //Field offset: 0x28

		[JsonProperty]
		public private PlayerHealthFactorsSettings ProfileHealthSettings
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public HealthSettings() { }

		private static ValueInfo CreateFallbackHealthFactorValueInfo(EHealthFactorType factorType) { }

		[CompilerGenerated]
		public PlayerHealthFactorsSettings get_ProfileHealthSettings() { }

		public static ValueInfo GetProfileHealthFactorDefaultValueInfo(EHealthFactorType factorType) { }

		[CompilerGenerated]
		private void set_ProfileHealthSettings(PlayerHealthFactorsSettings value) { }

	}

	internal class HealthSkill
	{
		public float SkillProgress; //Field offset: 0x10

		public HealthSkill() { }

	}

	internal class HeavyVests
	{
		public float WearAmountRepairHVestsReducePerLevel; //Field offset: 0x10
		public float WearChanceRepairHVestsReduceEliteLevel; //Field offset: 0x14
		public float MoveSpeedPenaltyReductionHVestsReducePerLevel; //Field offset: 0x18
		public float BluntThroughputDamageHVestsReducePerLevel; //Field offset: 0x1C
		public float RicochetChanceHVestsEliteLevel; //Field offset: 0x20
		public float RicochetChanceHVestsMaxDurabilityThreshold; //Field offset: 0x24
		public float RicochetChanceHVestsCurrentDurabilityThreshold; //Field offset: 0x28
		public BuffSettings BuffSettings; //Field offset: 0x30

		public HeavyVests() { }

	}

	internal sealed class HideoutManagement
	{
		internal sealed class AdditionalEliteSlots
		{
			public int Slots; //Field offset: 0x10
			public int Container; //Field offset: 0x14

			public AdditionalEliteSlots() { }

		}

		internal sealed class PointsRate
		{
			public float ResourceSpent; //Field offset: 0x10
			public float PointsGained; //Field offset: 0x14

			public float PointsPerResource
			{
				 get { } //Length: 11
			}

			public PointsRate() { }

			public float get_PointsPerResource() { }

		}

		public float SkillPointsPerAreaUpgrade; //Field offset: 0x10
		public float SkillPointsPerCraft; //Field offset: 0x14
		public double SkillBoostPercent; //Field offset: 0x18
		public float ConsumptionReductionPerLevel; //Field offset: 0x20
		public Dictionary SkillPointsRate; //Field offset: 0x28
		public Dictionary EliteSlots; //Field offset: 0x30

		public HideoutManagement() { }

	}

	internal class Immunity
	{
		public float ImmunityMiscEffects; //Field offset: 0x10
		public float ImmunityPoisonBuff; //Field offset: 0x14
		public float ImmunityPainKiller; //Field offset: 0x18
		public float HealthNegativeEffect; //Field offset: 0x1C
		public float StimulatorNegativeBuff; //Field offset: 0x20

		public Immunity() { }

	}

	internal sealed class InertiaSettings
	{
		public Vector2 ExitMovementStateSpeedThreshold; //Field offset: 0x10
		public Vector2 WalkInertia; //Field offset: 0x18
		public float FallThreshold; //Field offset: 0x20
		public Vector2 SpeedLimitAfterFallMin; //Field offset: 0x24
		public Vector2 SpeedLimitAfterFallMax; //Field offset: 0x2C
		public Vector2 SpeedLimitDurationMin; //Field offset: 0x34
		public Vector2 SpeedLimitDurationMax; //Field offset: 0x3C
		public Vector2 SpeedInertiaAfterJump; //Field offset: 0x44
		public float BaseJumpPenaltyDuration; //Field offset: 0x4C
		public float DurationPower; //Field offset: 0x50
		public float BaseJumpPenalty; //Field offset: 0x54
		public float PenaltyPower; //Field offset: 0x58
		public Vector2 InertiaTiltCurveMin; //Field offset: 0x5C
		public Vector2 InertiaTiltCurveMax; //Field offset: 0x64
		public Vector2 InertiaBackwardCoef; //Field offset: 0x6C
		public Vector2 TiltInertiaMaxSpeed; //Field offset: 0x74
		public Vector2 TiltStartSideBackSpeed; //Field offset: 0x7C
		public Vector2 TiltMaxSideBackSpeed; //Field offset: 0x84
		public Vector2 TiltAcceleration; //Field offset: 0x8C
		public int AverageRotationFrameSpan; //Field offset: 0x94
		public Vector2 SprintSpeedInertiaCurveMin; //Field offset: 0x98
		public Vector2 SprintSpeedInertiaCurveMax; //Field offset: 0xA0
		public Vector2 SprintBrakeInertia; //Field offset: 0xA8
		public Vector2 SprintTransitionMotionPreservation; //Field offset: 0xB0
		public Vector3 InertiaLimits; //Field offset: 0xB8
		public Vector2 WeaponFlipSpeed; //Field offset: 0xC4
		public float InertiaLimitsStep; //Field offset: 0xCC
		public Vector2 SprintAccelerationLimits; //Field offset: 0xD0
		public Vector2 PreSprintAccelerationLimits; //Field offset: 0xD8
		public Vector2 SideTime; //Field offset: 0xE0
		public Vector2 DiagonalTime; //Field offset: 0xE8
		public float MinDirectionBlendTime; //Field offset: 0xF0
		public Vector2 MoveTimeRange; //Field offset: 0xF4
		public Vector2 MinMovementAccelerationRangeRight; //Field offset: 0xFC
		public Vector2 MaxMovementAccelerationRangeRight; //Field offset: 0x104
		public float SuddenChangesSmoothness; //Field offset: 0x10C
		public Vector2 MaxTimeWithoutInput; //Field offset: 0x110
		public Vector2 ProneDirectionAccelerationRange; //Field offset: 0x118
		public Vector2 ProneSpeedAccelerationRange; //Field offset: 0x120
		public Vector2 DiagonalStayTimeRange; //Field offset: 0x128
		public Vector2 CrouchSpeedAccelerationRange; //Field offset: 0x130

		public InertiaSettings() { }

	}

	internal class Intellect
	{
		public float ExamineAction; //Field offset: 0x10
		public float SkillProgress; //Field offset: 0x14
		public float RepairAction; //Field offset: 0x18
		[JsonProperty("WearAmountReducePerLevel")]
		public float WearAmountReducePerLevel; //Field offset: 0x1C
		[JsonProperty("RepairPointsCostReduction")]
		public float RepairPointsCostReduction; //Field offset: 0x20

		public Intellect() { }

	}

	internal interface ITraderInfo
	{

		public int ProfileLevel
		{
			 get { } //Length: 0
		}

		public long SalesSum
		{
			 get { } //Length: 0
		}

		public double Standing
		{
			 get { } //Length: 0
		}

		public int get_ProfileLevel() { }

		public long get_SalesSum() { }

		public double get_Standing() { }

	}

	internal class LightVests
	{
		public float WearAmountRepairLVestsReducePerLevel; //Field offset: 0x10
		public float WearChanceRepairLVestsReduceEliteLevel; //Field offset: 0x14
		public float MoveSpeedPenaltyReductionLVestsReducePerLevel; //Field offset: 0x18
		public float MeleeDamageLVestsReducePerLevel; //Field offset: 0x1C
		public BuffSettings BuffSettings; //Field offset: 0x20

		public LightVests() { }

	}

	internal class MagDrills
	{
		public float RaidLoadedAmmoAction; //Field offset: 0x10
		public float RaidUnloadedAmmoAction; //Field offset: 0x14
		public float MagazineCheckAction; //Field offset: 0x18

		public MagDrills() { }

	}

	[JsonObject(MemberSerialization::OptIn (1))]
	internal sealed class MainQuestSettings
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__0_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal string <.ctor>b__0_0(MongoID chapterId) { }

		}

		public readonly IEnumerable Chapters; //Field offset: 0x10

		[JsonConstructor]
		private MainQuestSettings(GlobalsArray chapters) { }

		public MainQuestSettings() { }

	}

	internal sealed class MalfunctionSettings
	{
		public float AmmoMalfChanceMult; //Field offset: 0x10
		public float MagazineMalfChanceMult; //Field offset: 0x14
		public float MalfRepairHardSlideMult; //Field offset: 0x18
		public float MalfRepairOneHandBrokenMult; //Field offset: 0x1C
		public float MalfRepairTwoHandsBrokenMult; //Field offset: 0x20
		public bool AllowMalfForBots; //Field offset: 0x24
		public int ShowGlowAttemptsCount; //Field offset: 0x28
		public float OutToIdleSpeedMultForPistol; //Field offset: 0x2C
		public float IdleToOutSpeedMultOnMalf; //Field offset: 0x30
		public float TimeToQuickdrawPistol; //Field offset: 0x34
		public Vector3 DurRangeToIgnoreMalfs; //Field offset: 0x38
		public float DurFeedWt; //Field offset: 0x44
		public float DurMisfireWt; //Field offset: 0x48
		public float DurJamWt; //Field offset: 0x4C
		public float DurSoftSlideWt; //Field offset: 0x50
		public float DurHardSlideMinWt; //Field offset: 0x54
		public float DurHardSlideMaxWt; //Field offset: 0x58
		public float AmmoMisfireWt; //Field offset: 0x5C
		public float AmmoFeedWt; //Field offset: 0x60
		public float AmmoJamWt; //Field offset: 0x64
		public float OverheatFeedWt; //Field offset: 0x68
		public float OverheatJamWt; //Field offset: 0x6C
		public float OverheatSoftSlideWt; //Field offset: 0x70
		public float OverheatHardSlideMinWt; //Field offset: 0x74
		public float OverheatHardSlideMaxWt; //Field offset: 0x78

		public MalfunctionSettings() { }

	}

	internal sealed class MasteringGroup
	{
		public string[] Templates; //Field offset: 0x10
		[JsonProperty("Name")]
		public string Id; //Field offset: 0x18
		public int Level2; //Field offset: 0x20
		public int Level3; //Field offset: 0x24

		public MasteringGroup() { }

	}

	internal class Memory
	{
		public float AnySkillUp; //Field offset: 0x10
		public float SkillProgress; //Field offset: 0x14

		public Memory() { }

	}

	internal class Metabolism
	{
		public float HydrationRecoveryRate; //Field offset: 0x10
		public float EnergyRecoveryRate; //Field offset: 0x14
		public float IncreasePositiveEffectDurationRate; //Field offset: 0x18
		public float DecreaseNegativeEffectDurationRate; //Field offset: 0x1C
		public float DecreasePoisonDurationRate; //Field offset: 0x20

		public Metabolism() { }

	}

	internal sealed class OverheatSettings
	{
		public float MinOverheat; //Field offset: 0x10
		public float MaxOverheat; //Field offset: 0x14
		public float OverheatProblemsStart; //Field offset: 0x18
		public float ModHeatFactor; //Field offset: 0x1C
		public float ModCoolFactor; //Field offset: 0x20
		public float MinWearOnOverheat; //Field offset: 0x24
		public float MaxWearOnOverheat; //Field offset: 0x28
		public float MinWearOnMaxOverheat; //Field offset: 0x2C
		public float MaxWearOnMaxOverheat; //Field offset: 0x30
		public float OverheatWearLimit; //Field offset: 0x34
		public float MaxCOIIncreaseMult; //Field offset: 0x38
		public float MinMalfChance; //Field offset: 0x3C
		public float MaxMalfChance; //Field offset: 0x40
		public float DurReduceMinMult; //Field offset: 0x44
		public float DurReduceMaxMult; //Field offset: 0x48
		public float BarrelMoveRndDuration; //Field offset: 0x4C
		public float BarrelMoveMaxMult; //Field offset: 0x50
		public float FireratePitchMult; //Field offset: 0x54
		public float FirerateReduceMinMult; //Field offset: 0x58
		public float FirerateReduceMaxMult; //Field offset: 0x5C
		public float FirerateOverheatBorder; //Field offset: 0x60
		public bool EnableSlideOnMaxOverheat; //Field offset: 0x64
		public float StartSlideOverheat; //Field offset: 0x68
		public float FixSlideOverheat; //Field offset: 0x6C
		public float AutoshotMinOverheat; //Field offset: 0x70
		public float AutoshotChance; //Field offset: 0x74
		public float AutoshotPossibilityDuration; //Field offset: 0x78
		public float HeatVisibleFactor; //Field offset: 0x7C
		public float HeatThermalFactor; //Field offset: 0x80
		public float MaxOverheatCoolCoef; //Field offset: 0x84

		public OverheatSettings() { }

	}

	internal sealed class PDTSettingsData
	{
		[JsonProperty("PDTExpBonus")]
		public float PDTExpBonus; //Field offset: 0x10

		public PDTSettingsData() { }

	}

	internal class Perception
	{
		public float OnlineAction; //Field offset: 0x10
		public float UniqueLoot; //Field offset: 0x14

		public Perception() { }

	}

	internal class Pistol
	{
		public float WeaponReloadAction; //Field offset: 0x10
		public float WeaponShotAction; //Field offset: 0x14
		public float WeaponFixAction; //Field offset: 0x18
		public float WeaponChamberAction; //Field offset: 0x1C

		public Pistol() { }

	}

	internal class RecoilControl
	{
		public float RecoilAction; //Field offset: 0x10
		public float RecoilBonusPerLevel; //Field offset: 0x14

		public RecoilControl() { }

	}

	internal sealed class RepairKitSettings
	{
		internal sealed class ItemEnhancementValues
		{
			public float PriceModifier; //Field offset: 0x10

			public ItemEnhancementValues() { }

		}

		internal sealed class RepairKitStrategy
		{
			public MongoID[] Filter; //Field offset: 0x10
			public ERepairBuffType[] BuffTypes; //Field offset: 0x18

			public RepairKitStrategy() { }

		}

		public int armorClassDivisor; //Field offset: 0x10
		public float durabilityPointCostArmor; //Field offset: 0x14
		public float durabilityPointCostGuns; //Field offset: 0x18
		public Dictionary RepairStrategies; //Field offset: 0x20
		public float currentDurabilityLossToRemoveBuff; //Field offset: 0x28
		public float maxDurabilityLossToRemoveBuff; //Field offset: 0x2C
		public int minimumLevelToApplyBuff; //Field offset: 0x30
		public Dictionary ItemEnhancementSettings; //Field offset: 0x38

		public RepairKitSettings() { }

	}

	internal sealed class RestrictionInRaid
	{
		public string TemplateId; //Field offset: 0x10
		public int MaxInLobby; //Field offset: 0x18
		public int MaxInRaid; //Field offset: 0x1C

		public RestrictionInRaid() { }

	}

	internal class Revolver
	{
		public float WeaponReloadAction; //Field offset: 0x10
		public float WeaponShotAction; //Field offset: 0x14
		public float WeaponFixAction; //Field offset: 0x18
		public float WeaponChamberAction; //Field offset: 0x1C

		public Revolver() { }

	}

	internal class Search
	{
		public float SearchAction; //Field offset: 0x10
		public float FindAction; //Field offset: 0x14

		public Search() { }

	}

	internal class SeasonEvents
	{
		internal class InfectionHalloween
		{
			public bool DisplayUIEnabled; //Field offset: 0x10
			public bool Enabled; //Field offset: 0x11
			public float ZombieBleedMul; //Field offset: 0x14
			[JsonIgnore]
			public int RedThreatValue; //Field offset: 0x18
			[CompilerGenerated]
			private IReadOnlyDictionary <LocationInfection>k__BackingField; //Field offset: 0x20

			[JsonIgnore]
			public private IReadOnlyDictionary LocationInfection
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				private set { } //Length: 82
			}

			public InfectionHalloween() { }

			[CompilerGenerated]
			public IReadOnlyDictionary get_LocationInfection() { }

			public void Init(Dictionary locationInfection) { }

			[CompilerGenerated]
			private void set_LocationInfection(IReadOnlyDictionary value) { }

		}

		[JsonProperty("InfectionHalloween")]
		public InfectionHalloween InfectionHalloweenConfig; //Field offset: 0x10

		public SeasonEvents() { }

	}

	internal class ServiceData
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__0_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal SubService <.ctor>b__0_0(KeyValuePair subServiceData) { }

		}

		[CompilerGenerated]
		private MongoID <TraderId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private ETraderServiceType <ServiceType>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private SubService[] <SubServices>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private ServiceRequirements <TraderServiceRequirements>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private GlobalsDictionary <ServiceItemCost>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private MongoID[] <UniqueItems>k__BackingField; //Field offset: 0x48

		[JsonProperty("ServiceItemCost")]
		public private GlobalsDictionary ServiceItemCost
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		[JsonProperty("TraderServiceType")]
		public private ETraderServiceType ServiceType
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		[JsonProperty("SubServices")]
		public SubService[] SubServices
		{
			[CompilerGenerated]
			 get { } //Length: 76
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[JsonProperty("TraderId")]
		public private MongoID TraderId
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			private set { } //Length: 98
		}

		[JsonProperty("Requirements")]
		public private ServiceRequirements TraderServiceRequirements
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		[JsonProperty("UniqueItems")]
		public private MongoID[] UniqueItems
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public ServiceData(TraderServiceAvailabilityData serviceData, ServiceRequirements requirements = null) { }

		[JsonConstructor]
		private ServiceData() { }

		[CompilerGenerated]
		public GlobalsDictionary get_ServiceItemCost() { }

		[CompilerGenerated]
		public ETraderServiceType get_ServiceType() { }

		[CompilerGenerated]
		public SubService[] get_SubServices() { }

		[CompilerGenerated]
		public MongoID get_TraderId() { }

		[CompilerGenerated]
		public ServiceRequirements get_TraderServiceRequirements() { }

		[CompilerGenerated]
		public MongoID[] get_UniqueItems() { }

		[CompilerGenerated]
		private void set_ServiceItemCost(GlobalsDictionary value) { }

		[CompilerGenerated]
		private void set_ServiceType(ETraderServiceType value) { }

		[CompilerGenerated]
		public void set_SubServices(SubService[] value) { }

		[CompilerGenerated]
		private void set_TraderId(MongoID value) { }

		[CompilerGenerated]
		private void set_TraderServiceRequirements(ServiceRequirements value) { }

		[CompilerGenerated]
		private void set_UniqueItems(MongoID[] value) { }

	}

	internal class Shotgun
	{
		public float WeaponReloadAction; //Field offset: 0x10
		public float WeaponShotAction; //Field offset: 0x14
		public float WeaponFixAction; //Field offset: 0x18
		public float WeaponChamberAction; //Field offset: 0x1C

		public Shotgun() { }

	}

	internal class Sniper
	{
		public float WeaponReloadAction; //Field offset: 0x10
		public float WeaponShotAction; //Field offset: 0x14
		public float WeaponFixAction; //Field offset: 0x18
		public float WeaponChamberAction; //Field offset: 0x1C

		public Sniper() { }

	}

	internal sealed class StaminaParameters
	{
		internal class CrouchLevelStaminaConsumptionMultipliers
		{
			public float PoseLevel; //Field offset: 0x10
			public float StaminaMultiplier; //Field offset: 0x14

			public CrouchLevelStaminaConsumptionMultipliers() { }

		}

		public float Capacity; //Field offset: 0x10
		public float SprintDrainRate; //Field offset: 0x14
		public float BaseRestorationRate; //Field offset: 0x18
		public float JumpConsumption; //Field offset: 0x1C
		public float WeaponFastSwitchConsumption; //Field offset: 0x20
		public float GrenadeHighThrow; //Field offset: 0x24
		public float GrenadeLowThrow; //Field offset: 0x28
		public float AimDrainRate; //Field offset: 0x2C
		public float AimRangeFinderDrainRate; //Field offset: 0x30
		public float OxygenCapacity; //Field offset: 0x34
		public float OxygenRestoration; //Field offset: 0x38
		public float HandsCapacity; //Field offset: 0x3C
		public float HandsRestoration; //Field offset: 0x40
		public Vector2 WalkOverweightLimits; //Field offset: 0x44
		public Vector2 BaseOverweightLimits; //Field offset: 0x4C
		public Vector2 SprintOverweightLimits; //Field offset: 0x54
		public Vector2 WalkSpeedOverweightLimits; //Field offset: 0x5C
		public Vector2 CrouchConsumption; //Field offset: 0x64
		public CrouchLevelStaminaConsumptionMultipliers[] CrouchLevelConsumptionMultipliers; //Field offset: 0x70
		public Vector2 WalkConsumption; //Field offset: 0x78
		public Vector2 TransitionSpeed; //Field offset: 0x80
		public Vector2 VaultLegsConsumption; //Field offset: 0x88
		public Vector2 VaultOneHandConsumption; //Field offset: 0x90
		public Vector3 ClimbLegsConsumption; //Field offset: 0x98
		public Vector3 ClimbOneHandConsumption; //Field offset: 0xA4
		public Vector3 ClimbTwoHandsConsumption; //Field offset: 0xB0
		public Vector2 PoseLevelIncreaseSpeed; //Field offset: 0xBC
		public Vector2 PoseLevelDecreaseSpeed; //Field offset: 0xC4
		public Vector2 StandupConsumption; //Field offset: 0xCC
		public Vector2 PoseLevelConsumptionPerNotch; //Field offset: 0xD4
		public Vector2 SoundRadius; //Field offset: 0xDC
		public float SprintSpeedLowerLimit; //Field offset: 0xE4
		public float SprintSensitivityLowerLimit; //Field offset: 0xE8
		public float AimingSpeedMultiplier; //Field offset: 0xEC
		public float WalkVisualEffectMultiplier; //Field offset: 0xF0
		public Vector3 AimConsumptionByPose; //Field offset: 0xF4
		public Vector3 RestorationMultiplierByPose; //Field offset: 0x100
		public Vector3 OverweightConsumptionByPose; //Field offset: 0x10C
		public float ProneConsumption; //Field offset: 0x118
		public float BaseHoldBreathConsumption; //Field offset: 0x11C
		public float ExhaustedMeleeSpeed; //Field offset: 0x120
		public float FatigueRestorationRate; //Field offset: 0x124
		public float FatigueAmountToCreateEffect; //Field offset: 0x128
		public float ExhaustedMeleeDamageMultiplier; //Field offset: 0x12C
		public float FallDamageMultiplier; //Field offset: 0x130
		public float SafeHeightOverweight; //Field offset: 0x134
		public Vector2 HoldBreathStaminaMultiplier; //Field offset: 0x138
		public bool StaminaExhaustionCausesJiggle; //Field offset: 0x140
		public bool StaminaExhaustionStartsBreathSound; //Field offset: 0x141
		public bool StaminaExhaustionRocksCamera; //Field offset: 0x142
		public float MountingVerticalAimDrainRateMultiplier; //Field offset: 0x144
		public float MountingHorizontalAimDrainRateMultiplier; //Field offset: 0x148
		public float BipodAimDrainRateMultiplier; //Field offset: 0x14C

		public float LowerOverweightLimit
		{
			 get { } //Length: 235
		}

		public float UpperOverweightLimit
		{
			 get { } //Length: 6
		}

		public StaminaParameters() { }

		public float get_LowerOverweightLimit() { }

		public float get_UpperOverweightLimit() { }

	}

	internal sealed class StaminaPolygonalGraph
	{
		public float LowerLeftPoint; //Field offset: 0x10
		public float LowerRightPoint; //Field offset: 0x14
		public float LeftPlatoPoint; //Field offset: 0x18
		public float RightPlatoPoint; //Field offset: 0x1C
		public float RightLimit; //Field offset: 0x20
		public float ZeroValue; //Field offset: 0x24

		public StaminaPolygonalGraph() { }

		public float GetAt(float normalEnergy) { }

	}

	internal class Strength
	{
		public float SprintActionMin; //Field offset: 0x10
		public float SprintActionMax; //Field offset: 0x14
		public float MovementActionMin; //Field offset: 0x18
		public float MovementActionMax; //Field offset: 0x1C
		public float PushUpMin; //Field offset: 0x20
		public float PushUpMax; //Field offset: 0x24
		public float FistfightAction; //Field offset: 0x28
		public float ThrowAction; //Field offset: 0x2C

		public Strength() { }

	}

	internal class StressResistance
	{
		public float HealthNegativeEffect; //Field offset: 0x10
		public float LowHPDuration; //Field offset: 0x14

		public StressResistance() { }

	}

	internal class Surgery
	{
		public float SurgeryAction; //Field offset: 0x10
		public float SkillProgress; //Field offset: 0x14

		public Surgery() { }

	}

	internal class Throwing
	{
		public float ThrowAction; //Field offset: 0x10
		public float AdditiveThrowSpeedPerLevel; //Field offset: 0x14
		public float MaxThrowSpeed; //Field offset: 0x18

		public Throwing() { }

	}

	internal sealed class TraderInsurance
	{
		[JsonProperty("availability")]
		public bool Availability; //Field offset: 0x10
		[JsonProperty("min_payment")]
		public int MinPayment; //Field offset: 0x14
		[JsonProperty("min_return_hour")]
		public int MinReturnHours; //Field offset: 0x18
		[JsonProperty("max_return_hour")]
		public int MaxReturnHours; //Field offset: 0x1C
		[JsonProperty("excluded_category")]
		public string[] ExcludedCategories; //Field offset: 0x20

		public TraderInsurance() { }

	}

	internal struct TraderLoyaltyLevel
	{
		[JsonProperty("minLevel")]
		public readonly int MinProfileLevel; //Field offset: 0x0
		[JsonProperty("minSalesSum")]
		public readonly long MinSalesSum; //Field offset: 0x8
		[JsonProperty("minStanding")]
		public readonly double MinStanding; //Field offset: 0x10
		[JsonProperty("buy_price_coef")]
		public readonly double SellToTraderPriceCoef; //Field offset: 0x18
		[JsonProperty("repair_price_coef")]
		public readonly double RepairPriceCoef; //Field offset: 0x20
		[JsonProperty("insurance_price_coef")]
		public readonly double InsurancePriceCoef; //Field offset: 0x28
		[JsonProperty("exchange_price_coef")]
		public readonly double ExchangePriceCoef; //Field offset: 0x30
		[JsonProperty("heal_price_coef")]
		public readonly float HealPriceCoef; //Field offset: 0x38

		public bool MeetsRequirements(ITraderInfo info) { }

	}

	internal sealed class TraderRepair
	{
		[JsonProperty("quality")]
		public float Quality; //Field offset: 0x10
		[JsonProperty("excluded_category")]
		public MongoID[] ExcludedCategories; //Field offset: 0x18
		[JsonProperty("currency")]
		public string Currency; //Field offset: 0x20
		[JsonProperty("currency_coefficient")]
		public float CurrencyCoefficient; //Field offset: 0x28
		[JsonProperty("availability")]
		public bool Availability; //Field offset: 0x2C

		public TraderRepair() { }

	}

	internal class TraderSettings
	{
		[CompilerGenerated]
		private struct <AvatarGetter>d__60 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TraderSettings <>4__this; //Field offset: 0x20
			public CancellationToken cancellationToken; //Field offset: 0x28
			public Image image; //Field offset: 0x30
			public bool setDefaultColor; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <GetAvatar>d__58 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TraderSettings <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal class HandbookEntities
		{
			public readonly IEnumerable Items; //Field offset: 0x10
			public readonly IEnumerable Categories; //Field offset: 0x18

			public HandbookEntities() { }

			[JsonConstructor]
			private HandbookEntities(MongoID[] items, MongoID[] categories) { }

			protected HandbookEntities(IReadOnlyCollection entities) { }

			protected HandbookEntities(IEnumerable items, IEnumerable categories) { }

			public override bool Contains(ItemTemplate itemTemplate) { }

		}

		[JsonProperty("_id")]
		public string Id; //Field offset: 0x10
		[JsonProperty("avatar")]
		public string AvatarURL; //Field offset: 0x18
		[JsonProperty("balance_rub")]
		public long BalanceRUB; //Field offset: 0x20
		[JsonProperty("balance_dol")]
		public long BalanceUSD; //Field offset: 0x28
		[JsonProperty("balance_eur")]
		public long BalanceEUR; //Field offset: 0x30
		[JsonProperty("discount")]
		public float Discount; //Field offset: 0x38
		[JsonProperty("discount_end")]
		public long DiscountEnd; //Field offset: 0x40
		[JsonProperty("buyer_up")]
		public bool BuyerUp; //Field offset: 0x48
		[JsonProperty("sell_modifier_for_prohibited_items")]
		public int ProhibitedItemsSellModifier; //Field offset: 0x4C
		[JsonProperty("currency")]
		public ECurrencyType Currency; //Field offset: 0x50
		[JsonProperty("repair")]
		public TraderRepair Repair; //Field offset: 0x58
		[JsonProperty("insurance")]
		public TraderInsurance Insurance; //Field offset: 0x60
		[JsonProperty("customization_seller")]
		public bool CustomizationSeller; //Field offset: 0x68
		[JsonProperty("medic")]
		public bool Medic; //Field offset: 0x69
		[JsonProperty("availableInRaid")]
		public bool AvailableInRaid; //Field offset: 0x6A
		[JsonProperty("unlockedByDefault")]
		public bool UnlockedByDefault; //Field offset: 0x6B
		[JsonProperty("nextResupply")]
		public int NextResupply; //Field offset: 0x6C
		[JsonProperty("mainDialogue")]
		public Nullable MainDialog; //Field offset: 0x70
		[CompilerGenerated]
		private HandbookEntities <BuysItems>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		private Dictionary <SellItems>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		private HandbookEntities <DoesNotBuyItems>k__BackingField; //Field offset: 0xA0
		[JsonProperty("isCanTransferItems")]
		public bool CanTransferItems; //Field offset: 0xA8
		[JsonProperty("isCanTransferItemsFromPve")]
		public bool CanTransferItemsFromPve; //Field offset: 0xA9
		[CompilerGenerated]
		private HandbookEntities <TransferableItems>k__BackingField; //Field offset: 0xB0
		[CompilerGenerated]
		private HandbookEntities <ProhibitedTransferableItems>k__BackingField; //Field offset: 0xB8
		[JsonProperty("loyaltyLevels")]
		public TraderLoyaltyLevel[] LoyaltyLevels; //Field offset: 0xC0
		private Sprite _avatar; //Field offset: 0xC8
		private Func _avatarGetter; //Field offset: 0xD0
		private Task _avatarTask; //Field offset: 0xD8

		[JsonProperty("items_buy")]
		public HandbookEntities BuysItems
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public string Description
		{
			 get { } //Length: 66
		}

		[JsonProperty("items_buy_prohibited")]
		public HandbookEntities DoesNotBuyItems
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public string FirstName
		{
			 get { } //Length: 66
		}

		public string FullName
		{
			 get { } //Length: 66
		}

		public string Location
		{
			 get { } //Length: 66
		}

		public string Nickname
		{
			 get { } //Length: 66
		}

		[JsonProperty("prohibitedTransferableItems")]
		public HandbookEntities ProhibitedTransferableItems
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[JsonProperty("items_sell")]
		public Dictionary SellItems
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[JsonProperty("transferableItems")]
		public HandbookEntities TransferableItems
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public TraderSettings() { }

		[AsyncStateMachine(typeof(<AvatarGetter>d__60))]
		private Task AvatarGetter(Image image, CancellationToken cancellationToken, bool setDefaultColor) { }

		[CompilerGenerated]
		public HandbookEntities get_BuysItems() { }

		public string get_Description() { }

		[CompilerGenerated]
		public HandbookEntities get_DoesNotBuyItems() { }

		public string get_FirstName() { }

		public string get_FullName() { }

		public string get_Location() { }

		public string get_Nickname() { }

		[CompilerGenerated]
		public HandbookEntities get_ProhibitedTransferableItems() { }

		[CompilerGenerated]
		public Dictionary get_SellItems() { }

		[CompilerGenerated]
		public HandbookEntities get_TransferableItems() { }

		public Task GetAndAssignAvatar(Image image, CancellationToken cancellationToken, bool setDefaultColor = true) { }

		[AsyncStateMachine(typeof(<GetAvatar>d__58))]
		public Task GetAvatar() { }

		public int GetLoyaltyLevel(ITraderInfo info) { }

		public Nullable GetLoyaltyLevelSettings(int loyaltyLevel) { }

		public void InitSession(Func avatarGetter) { }

		[CompilerGenerated]
		protected void set_BuysItems(HandbookEntities value) { }

		[CompilerGenerated]
		protected void set_DoesNotBuyItems(HandbookEntities value) { }

		[CompilerGenerated]
		protected void set_ProhibitedTransferableItems(HandbookEntities value) { }

		[CompilerGenerated]
		protected void set_SellItems(Dictionary value) { }

		[CompilerGenerated]
		protected void set_TransferableItems(HandbookEntities value) { }

	}

	internal sealed class TriggersSettings
	{
		internal class HandlerChanceConfig
		{
			[CompilerGenerated]
			private string <Name>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			private float <Chance>k__BackingField; //Field offset: 0x18

			public float Chance
			{
				[CompilerGenerated]
				 get { } //Length: 6
				[CompilerGenerated]
				 set { } //Length: 6
			}

			public string Name
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				 set { } //Length: 82
			}

			public HandlerChanceConfig() { }

			[CompilerGenerated]
			public float get_Chance() { }

			[CompilerGenerated]
			public string get_Name() { }

			[CompilerGenerated]
			public void set_Chance(float value) { }

			[CompilerGenerated]
			public void set_Name(string value) { }

		}

		public Dictionary HandlerDamage; //Field offset: 0x10
		[JsonProperty("HandlerChance")]
		public List HandlerChance; //Field offset: 0x18
		public Dictionary HandlerChancesConfigs; //Field offset: 0x20

		public TriggersSettings() { }

		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context) { }

	}

	internal class TroubleShooting
	{
		public float MalfRepairSpeedBonusPerLevel; //Field offset: 0x10
		public float SkillPointsPerMalfFix; //Field offset: 0x14
		public float EliteDurabilityChanceReduceMult; //Field offset: 0x18
		public float EliteAmmoChanceReduceMult; //Field offset: 0x1C
		public float EliteMagChanceReduceMult; //Field offset: 0x20

		public TroubleShooting() { }

	}

	internal class Tutorial
	{
		[JsonProperty("BrokenWeaponId")]
		public string BrokenWeaponId; //Field offset: 0x10
		[JsonProperty("TutorialWeather")]
		public WeatherFinalConfig WeatherConfig; //Field offset: 0x18

		public Tutorial() { }

	}

	internal class Vitality
	{
		public float DamageTakenAction; //Field offset: 0x10
		public float HealthNegativeEffect; //Field offset: 0x14

		public Vitality() { }

	}

	internal class WeaponTreatment
	{
		public float SkillPointsPerRepair; //Field offset: 0x10
		[JsonProperty("WearAmountRepairGunsReducePerLevel")]
		public float WearAmountRepairGunsReducePerLevel; //Field offset: 0x14
		[JsonProperty("DurLossReducePerLevel")]
		public float DurabilityLossReducePerLevel; //Field offset: 0x18
		public BuffSettings BuffSettings; //Field offset: 0x20

		public WeaponTreatment() { }

	}

	public Dictionary ServicesData; //Field offset: 0x10
	[JsonIgnore]
	public BTRServerSettings BTRLocalSettings; //Field offset: 0x18
	[JsonProperty("FenceSettings")]
	public readonly FenceGlobalSettings FenceSettings; //Field offset: 0x20
	[JsonProperty("TradingSettings")]
	public readonly TradingGlobalSettings TradingSettings; //Field offset: 0x28
	public readonly RepairKitSettings RepairSettings; //Field offset: 0x30
	public readonly Dictionary TradersSettings; //Field offset: 0x38
	[CompilerGenerated]
	private PrestigeSettings <PrestigeSettings>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private MainQuestSettings <MainQuest>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private IEnumerable <QuestNotes>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private IEnumerable <GroupProfileVariables>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private SeasonalPerksData <PerksSettings>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private ActiveSeasonResponse <SeasonalRewards>k__BackingField; //Field offset: 0x68
	[JsonProperty("exp")]
	public ExperienceSettings Experience; //Field offset: 0x70
	[JsonProperty("PDTSettings")]
	public PDTSettingsData PDTSettings; //Field offset: 0x78
	public AimingConfiguration Aiming; //Field offset: 0x80
	public HealthSettings Health; //Field offset: 0x88
	public Dictionary ArmorMaterials; //Field offset: 0x90
	public Dictionary RequirementReferences; //Field offset: 0x98
	[JsonProperty("armor")]
	public ArmorSettings Armor; //Field offset: 0xA0
	public RagfairSettings RagFair; //Field offset: 0xA8
	[JsonProperty("handbook")]
	public HandbookSettings Handbook; //Field offset: 0xB0
	[JsonProperty("MaxBotsAliveOnMap")]
	public int MaxBotsAliveOnMap; //Field offset: 0xB8
	public float MarksmanAccuracy; //Field offset: 0xBC
	public int SavagePlayCooldown; //Field offset: 0xC0
	public int TimeBeforeDeploy; //Field offset: 0xC4
	public int TimeBeforeDeployLocal; //Field offset: 0xC8
	public float LoadTimeSpeedProgress; //Field offset: 0xCC
	public float BaseLoadTime; //Field offset: 0xD0
	public float BaseUnloadTime; //Field offset: 0xD4
	public float BaseCheckTime; //Field offset: 0xD8
	public float WAVE_COEF_LOW; //Field offset: 0xDC
	public float WAVE_COEF_MID; //Field offset: 0xE0
	public float WAVE_COEF_HIGH; //Field offset: 0xE4
	public float WAVE_COEF_HORDE; //Field offset: 0xE8
	[JsonProperty("Customization")]
	public Customization CustomizationInfo; //Field offset: 0xF0
	public bool UncheckOnShot; //Field offset: 0xF8
	public int SessionsToShowHotKeys; //Field offset: 0xFC
	public string TODSkyDate; //Field offset: 0x100
	public float SkillMinEffectiveness; //Field offset: 0x108
	public float SkillFatiguePerPoint; //Field offset: 0x10C
	public float SkillFreshEffectiveness; //Field offset: 0x110
	public int SkillFreshPoints; //Field offset: 0x114
	public int SkillPointsBeforeFatigue; //Field offset: 0x118
	public int SkillFatigueReset; //Field offset: 0x11C
	public float SkillEnduranceWeightThreshold; //Field offset: 0x120
	public float AimPunchMagnitude; //Field offset: 0x124
	public bool SkillAtrophy; //Field offset: 0x128
	public bool AllowSelectEntryPoint; //Field offset: 0x129
	public float LegsOverdamage; //Field offset: 0x12C
	public float HandsOverdamage; //Field offset: 0x130
	public float StomachOverdamage; //Field offset: 0x134
	public float BluntDamageReduceFromSoftArmorMod; //Field offset: 0x138
	public bool DiscardLimitsEnabled; //Field offset: 0x13C
	public float MailItemsExpirationTimeLimitWarning; //Field offset: 0x140
	public MasteringGroup[] Mastering; //Field offset: 0x148
	public StaminaParameters Stamina; //Field offset: 0x150
	public StaminaPolygonalGraph StaminaRestoration; //Field offset: 0x158
	public StaminaPolygonalGraph StaminaDrain; //Field offset: 0x160
	private Dictionary _overDamageFactor; //Field offset: 0x168
	private Dictionary _associations; //Field offset: 0x170
	public bool AzimuthPanelShowsPlayerOrientation; //Field offset: 0x178
	public Vector3 WallContusionAbsorption; //Field offset: 0x17C
	public Vector2 WalkSpeed; //Field offset: 0x188
	public Vector2 SprintSpeed; //Field offset: 0x190
	private RestrictionInRaid[] _restrictionInRaid; //Field offset: 0x198
	public EEventType[] EventType; //Field offset: 0x1A0
	public int TeamSearchingTimeout; //Field offset: 0x1A8
	public int GameSearchingTimeout; //Field offset: 0x1AC
	public int MaxMatchingTimeInSeconds; //Field offset: 0x1B0
	public MalfunctionSettings Malfunction; //Field offset: 0x1B8
	public OverheatSettings Overheat; //Field offset: 0x1C0
	public InertiaSettings Inertia; //Field offset: 0x1C8
	public BallisticSettings Ballistic; //Field offset: 0x1D0
	public AirdropSettings Airdrop; //Field offset: 0x1D8
	public TriggersSettings Triggers; //Field offset: 0x1E0
	public BufferZoneSettings BufferZone; //Field offset: 0x1E8
	[JsonProperty("CoopSettings")]
	public readonly CoopGlobalSettings CoopSettings; //Field offset: 0x1F0
	[JsonProperty("PveSettings")]
	public readonly PveGlobalSettings PveSettings; //Field offset: 0x1F8
	[JsonProperty("EventSettings")]
	public readonly EventGlobalSettings EventSettings; //Field offset: 0x200
	[JsonProperty("BTRSettings")]
	public readonly BTRGlobalSettings BTRSettings; //Field offset: 0x208
	[JsonProperty("TripwiresSettings")]
	public readonly TripwiresGlobalSettings TripwiresSettings; //Field offset: 0x210
	[JsonProperty("TransitSettings")]
	public readonly TransitGlobalSettings transitSettings; //Field offset: 0x218
	[JsonProperty("ArtilleryShelling")]
	public readonly ArtilleryShellingGlobalSettings ArtilleryShelling; //Field offset: 0x220
	[JsonProperty("RunddansSettings")]
	public readonly RunddansGlobalSettings runddansSettings; //Field offset: 0x228
	[JsonProperty("KolotunSettings")]
	public readonly KolotunGlobalSettings kolotunSettings; //Field offset: 0x230
	[JsonProperty("FinalMissionSettings")]
	public readonly CutscenesGlobalConfig FinalMissionSettings; //Field offset: 0x238
	[JsonProperty("ItemsCommonSettings")]
	public readonly ItemsCommonSettings ItemsSettings; //Field offset: 0x240
	[JsonProperty("VaultingSettings")]
	public readonly VaultingGlobalSettings VaultingSettings; //Field offset: 0x248
	[JsonProperty("ObstacleSettings")]
	public readonly Dictionary ObstacleSettings; //Field offset: 0x250
	[JsonProperty("WeaponFastDrawSettings")]
	public readonly WeaponFastDrawSettings WeaponFastDrawGlobalSettings; //Field offset: 0x258
	[JsonProperty("AudioSettings")]
	public readonly GlobalAudioSettings AudioSettings; //Field offset: 0x260
	[JsonProperty("FavoriteItemsSettings")]
	public readonly FavoriteItemsGlobalSettings FavoriteItemsSettings; //Field offset: 0x268
	[JsonProperty("WishlistSettings")]
	public readonly WishlistSettings WishlistSettings; //Field offset: 0x270
	[JsonProperty("BodyPartColliderSettings")]
	public readonly Dictionary BodyPartColliderSettings; //Field offset: 0x278
	[JsonProperty("ArenaEftTransferSettings")]
	public readonly ArenaEftTransferGlobalSettings ArenaEftTransferSettings; //Field offset: 0x280
	[JsonProperty("MountingSettings")]
	public readonly MountingGlobalSettings MountingSettings; //Field offset: 0x288
	[JsonProperty("DialogSettings")]
	public readonly DialogSettings DialogSettings; //Field offset: 0x290
	[JsonProperty("ExtensionsSettings")]
	public readonly ExtensionsSettings ExtensionsSettings; //Field offset: 0x298
	[JsonProperty("SteamStatusSettings")]
	public readonly SteamStatusSettings SteamStatusSettings; //Field offset: 0x2A0
	[JsonProperty("PasscodeSettings")]
	public readonly PasscodeGlobalSettings PasscodeSettings; //Field offset: 0x2A8
	[JsonProperty("SpectatingSettings")]
	public readonly SpectatingGlobalSettings SpectatingSettings; //Field offset: 0x2B0
	[JsonProperty("BattlePassUniversalDocument")]
	private readonly BattlePassUniversalDocumentData _battlePassUniversalDocumentSettings; //Field offset: 0x2B8
	[JsonProperty("SeasonsLeagues")]
	public readonly SeasonsLeaguesData SeasonsLeaguesData; //Field offset: 0x2C0
	[JsonProperty("GroupQuestSetting")]
	public readonly GroupQuestSetting GroupQuestSetting; //Field offset: 0x2C8
	[JsonProperty("SeasonActivity")]
	public SeasonEvents SeasonEventsConfig; //Field offset: 0x2D0
	public GlobalSkillsSettings SkillsSettings; //Field offset: 0x2D8
	[JsonProperty("Tutorial")]
	public Tutorial TutorialConfig; //Field offset: 0x2E0
	[CompilerGenerated]
	private BattlePassConfig <BattlePassSettings>k__BackingField; //Field offset: 0x2E8

	public Dictionary Associations
	{
		 get { } //Length: 946
	}

	[JsonProperty("battlePasses")]
	public private BattlePassConfig BattlePassSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IEnumerable GroupProfileVariables
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private MainQuestSettings MainQuest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Dictionary OverDamageFactor
	{
		 get { } //Length: 742
	}

	[JsonProperty("PerksSettings")]
	public private SeasonalPerksData PerksSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private PrestigeSettings PrestigeSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IEnumerable QuestNotes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[UsedImplicitly]
	public RestrictionInRaid[] RestrictionsInRaid
	{
		 get { } //Length: 8
		 set { } //Length: 177
	}

	public private ActiveSeasonResponse SeasonalRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public GlobalConfiguration() { }

	public Dictionary get_Associations() { }

	[CompilerGenerated]
	public BattlePassConfig get_BattlePassSettings() { }

	[CompilerGenerated]
	public IEnumerable get_GroupProfileVariables() { }

	[CompilerGenerated]
	public MainQuestSettings get_MainQuest() { }

	public Dictionary get_OverDamageFactor() { }

	[CompilerGenerated]
	public SeasonalPerksData get_PerksSettings() { }

	[CompilerGenerated]
	public PrestigeSettings get_PrestigeSettings() { }

	[CompilerGenerated]
	public IEnumerable get_QuestNotes() { }

	public RestrictionInRaid[] get_RestrictionsInRaid() { }

	[CompilerGenerated]
	public ActiveSeasonResponse get_SeasonalRewards() { }

	[CompilerGenerated]
	private void set_BattlePassSettings(BattlePassConfig value) { }

	[CompilerGenerated]
	private void set_GroupProfileVariables(IEnumerable value) { }

	[CompilerGenerated]
	private void set_MainQuest(MainQuestSettings value) { }

	[CompilerGenerated]
	private void set_PerksSettings(SeasonalPerksData value) { }

	[CompilerGenerated]
	private void set_PrestigeSettings(PrestigeSettings value) { }

	[CompilerGenerated]
	private void set_QuestNotes(IEnumerable value) { }

	public void set_RestrictionsInRaid(RestrictionInRaid[] value) { }

	[CompilerGenerated]
	private void set_SeasonalRewards(ActiveSeasonResponse value) { }

	public void UpdateBattlePassSettings(BattlePassConfig config) { }

	public void UpdateSettings(IEnumerable tradersSettings, PrestigeSettings prestigeSettings, MainQuestSettings mainQuestSettings, IEnumerable questNotes, IEnumerable groupProfileVariables, SeasonalPerksData seasonalPerks, ActiveSeasonResponse seasonalRewards) { }

}

