namespace EFT.HealthSystem;

public class EffectsSettings
{
	internal class BerserkSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float WorkingTime; //Field offset: 0x14
		public float DefaultResidueTime; //Field offset: 0x18

		public BerserkSettings() { }

	}

	internal class BleedingSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public float DamageEnergy; //Field offset: 0x18
		public float DamageHealth; //Field offset: 0x1C
		public float EnergyLoopTime; //Field offset: 0x20
		public float HealthLoopTime; //Field offset: 0x24
		public float DamageHealthDehydrated; //Field offset: 0x28
		public float HealthLoopTimeDehydrated; //Field offset: 0x2C
		public float LifeTimeDehydrated; //Field offset: 0x30
		public int HealExperience; //Field offset: 0x34
		public float RemovePrice; //Field offset: 0x38
		public float EliteVitalityDuration; //Field offset: 0x3C
		public ProbabilitySetting Probability; //Field offset: 0x40

		public BleedingSettings() { }

	}

	internal class BodyTemperatureSettings
	{
		public float DefaultBuildUpTime; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public float LoopTime; //Field offset: 0x18

		public BodyTemperatureSettings() { }

	}

	internal class ChronicStaminaFatigueSettings
	{
		public float EnergyRate; //Field offset: 0x10
		public float TicksEvery; //Field offset: 0x14
		public float WorkingTime; //Field offset: 0x18
		public float EnergyRatePerStack; //Field offset: 0x1C

		public ChronicStaminaFatigueSettings() { }

	}

	internal class ContusionSettings
	{

		public ContusionSettings() { }

	}

	internal class DehydrationSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public float DamageOnStrongDehydration; //Field offset: 0x18
		public float StrongDehydrationLoopTime; //Field offset: 0x1C

		public DehydrationSettings() { }

	}

	internal class DisorientationSettings
	{

		public DisorientationSettings() { }

	}

	internal class ExhaustionSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public float Damage; //Field offset: 0x18
		public float DamageLoopTime; //Field offset: 0x1C

		public ExhaustionSettings() { }

	}

	internal class ExistenceSettings
	{
		public float EnergyLoopTime; //Field offset: 0x10
		public float HydrationLoopTime; //Field offset: 0x14
		public float EnergyDamage; //Field offset: 0x18
		public float HydrationDamage; //Field offset: 0x1C
		public float DestroyedStomachEnergyTimeFactor; //Field offset: 0x20
		public float DestroyedStomachHydrationTimeFactor; //Field offset: 0x24

		public ExistenceSettings() { }

	}

	internal class FlashSettings
	{

		public FlashSettings() { }

	}

	internal class FractureSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public int HealExperience; //Field offset: 0x18
		public float RemovePrice; //Field offset: 0x1C
		public ProbabilitySetting FallingProbability; //Field offset: 0x20
		public ProbabilitySetting BulletHitProbability; //Field offset: 0x28

		public FractureSettings() { }

	}

	internal class HealerSettings
	{

		public HealerSettings() { }

	}

	internal sealed class HealthBoostSettings
	{
		public float LoopTime; //Field offset: 0x10

		public HealthBoostSettings() { }

	}

	internal class IntoxicationSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public float DamageHealth; //Field offset: 0x18
		public float HealthLoopTime; //Field offset: 0x1C
		public int HealExperience; //Field offset: 0x20
		public float RemovePrice; //Field offset: 0x24

		public IntoxicationSettings() { }

	}

	internal class LethalIntoxicationSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public int HealExperience; //Field offset: 0x18
		public float RemovePrice; //Field offset: 0x1C

		public LethalIntoxicationSettings() { }

	}

	internal class LowEdgeHealthSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14
		public float StartCommonHealth; //Field offset: 0x18

		public LowEdgeHealthSettings() { }

	}

	internal class MedEffectSettings
	{
		public float LoopTime; //Field offset: 0x10
		public float StartDelay; //Field offset: 0x14
		public float DrinkStartDelay; //Field offset: 0x18
		public float FoodStartDelay; //Field offset: 0x1C
		public float DrugsStartDelay; //Field offset: 0x20
		public float MedKitStartDelay; //Field offset: 0x24
		public float MedicalStartDelay; //Field offset: 0x28
		public float StimulatorStartDelay; //Field offset: 0x2C

		public MedEffectSettings() { }

	}

	internal sealed class MusclePainSettings
	{
		public float GymEffectivity; //Field offset: 0x10
		public float TraumaChance; //Field offset: 0x14

		public MusclePainSettings() { }

	}

	internal class PainKillerSettings
	{

		public PainKillerSettings() { }

	}

	internal class PainSettings
	{
		public float TremorDelay; //Field offset: 0x10
		public int HealExperience; //Field offset: 0x14

		public PainSettings() { }

	}

	internal sealed class ProbabilitySetting
	{
		public EProbabilityFunctionType FunctionType; //Field offset: 0x10
		public float K; //Field offset: 0x14
		public float B; //Field offset: 0x18
		public float Threshold; //Field offset: 0x1C

		public ProbabilitySetting() { }

		public float GetX(float x) { }

		public bool Try(float x, float cap, float bias = 0) { }

	}

	internal class RadExposureSettings
	{
		public float Damage; //Field offset: 0x10
		public float DamageLoopTime; //Field offset: 0x14

		public RadExposureSettings() { }

	}

	internal class RegenerationSettings
	{
		internal class HealthSettings
		{
			public float Value; //Field offset: 0x10

			public HealthSettings() { }

		}

		internal class InfluenceSettings
		{
			public float HealthSlowDownPercentage; //Field offset: 0x10
			public float HydrationSlowDownPercentage; //Field offset: 0x14
			public float EnergySlowDownPercentage; //Field offset: 0x18

			public InfluenceSettings() { }

		}

		public float LoopTime; //Field offset: 0x10
		public float MinimumHealthPercentage; //Field offset: 0x14
		public float Energy; //Field offset: 0x18
		public float Hydration; //Field offset: 0x1C
		public Dictionary BodyHealth; //Field offset: 0x20
		public Dictionary Influences; //Field offset: 0x28

		public RegenerationSettings() { }

	}

	internal class SandingScreenSettings
	{

		public SandingScreenSettings() { }

	}

	internal class StimulatorSettings
	{
		internal class StimulatorBuffSettings : ICloneable
		{
			private static readonly HashSet _ignoreAppliesPrefix; //Field offset: 0x0
			public EStimulatorBuffType BuffType; //Field offset: 0x10
			public float Chance; //Field offset: 0x14
			public float Delay; //Field offset: 0x18
			public float Duration; //Field offset: 0x1C
			public float Value; //Field offset: 0x20
			public bool AbsoluteValue; //Field offset: 0x24
			public string SkillName; //Field offset: 0x28
			public ProbabilitySetting Probability; //Field offset: 0x30
			public EBodyPart[] AppliesTo; //Field offset: 0x38

			public string BuffName
			{
				 get { } //Length: 104
			}

			public bool IsBuff
			{
				 get { } //Length: 16
			}

			private static StimulatorBuffSettings() { }

			public StimulatorBuffSettings() { }

			public override object Clone() { }

			public string get_BuffName() { }

			public bool get_IsBuff() { }

			public string GetFullStringValue(string displayName) { }

			public string GetStringValue() { }

		}

		public float BuffLoopTime; //Field offset: 0x10
		public Dictionary Buffs; //Field offset: 0x18

		public StimulatorSettings() { }

		public StimulatorBuffSettings GetPersonalBuffSettings(string buffName, int index, SkillManager skills, float strength = 1) { }

	}

	internal class StunSettings
	{

		public StunSettings() { }

	}

	internal class TearGasSettings
	{
		internal sealed class TearGasBlockingItem
		{
			public string ItemId; //Field offset: 0x10

			public TearGasBlockingItem() { }

		}

		public float WorkTime; //Field offset: 0x10
		public float ErgonomicsPenalty; //Field offset: 0x14
		public float StaminaRateDebuff; //Field offset: 0x18
		public float ChestDamagePerTick; //Field offset: 0x1C
		public float TickTime; //Field offset: 0x20
		public float CoughCooldown; //Field offset: 0x24
		public bool CancelHealingAndInteractions; //Field offset: 0x28
		public TearGasBlockingItem[] BlockingItems; //Field offset: 0x30

		public TearGasSettings() { }

	}

	internal class TremorSettings
	{
		public float DefaultDelay; //Field offset: 0x10
		public float DefaultResidueTime; //Field offset: 0x14

		public TremorSettings() { }

	}

	internal class WoundSettings
	{
		public float WorkingTime; //Field offset: 0x10
		public float ThresholdMin; //Field offset: 0x14
		public float ThresholdMax; //Field offset: 0x18

		public WoundSettings() { }

	}

	internal sealed class ZombieInfectionSettings
	{
		public float Dehydration; //Field offset: 0x10
		public float HearingDebuffPercentage; //Field offset: 0x14
		public float СumulativeTime; //Field offset: 0x18

		public ZombieInfectionSettings() { }

	}

	public ExistenceSettings Existence; //Field offset: 0x10
	public DehydrationSettings Dehydration; //Field offset: 0x18
	public BleedingSettings LightBleeding; //Field offset: 0x20
	public BleedingSettings HeavyBleeding; //Field offset: 0x28
	public FractureSettings Fracture; //Field offset: 0x30
	public ContusionSettings Contusion; //Field offset: 0x38
	public DisorientationSettings Disorientation; //Field offset: 0x40
	public ExhaustionSettings Exhaustion; //Field offset: 0x48
	public LowEdgeHealthSettings LowEdgeHealth; //Field offset: 0x50
	public RadExposureSettings RadExposure; //Field offset: 0x58
	public StunSettings Stun; //Field offset: 0x60
	public IntoxicationSettings Intoxication; //Field offset: 0x68
	public LethalIntoxicationSettings LethalIntoxication; //Field offset: 0x70
	public RegenerationSettings Regeneration; //Field offset: 0x78
	public WoundSettings Wound; //Field offset: 0x80
	public BerserkSettings Berserk; //Field offset: 0x88
	public MedEffectSettings MedEffect; //Field offset: 0x90
	public FlashSettings Flash; //Field offset: 0x98
	public PainSettings Pain; //Field offset: 0xA0
	public PainKillerSettings PainKiller; //Field offset: 0xA8
	public SandingScreenSettings SandingScreen; //Field offset: 0xB0
	public StimulatorSettings Stimulator; //Field offset: 0xB8
	public TremorSettings Tremor; //Field offset: 0xC0
	public ChronicStaminaFatigueSettings ChronicStaminaFatigue; //Field offset: 0xC8
	public BodyTemperatureSettings BodyTemperature; //Field offset: 0xD0
	public HealthBoostSettings HealthBoost; //Field offset: 0xD8
	public MusclePainSettings MildMusclePain; //Field offset: 0xE0
	public MusclePainSettings SevereMusclePain; //Field offset: 0xE8
	public ZombieInfectionSettings ZombieInfection; //Field offset: 0xF0
	public TearGasSettings TearGasWeak; //Field offset: 0xF8
	public TearGasSettings TearGasStrong; //Field offset: 0x100

	public EffectsSettings() { }

}

