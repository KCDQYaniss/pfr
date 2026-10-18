namespace EFT.HealthSystem;

public class OfflineHealthController : BaseHealthController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__44_0; //Field offset: 0x8
		public static Func <>9__128_0; //Field offset: 0x10
		public static Func <>9__128_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal EBodyPart <ApplyTreatment>b__128_0(KeyValuePair kp) { }

		internal float <ApplyTreatment>b__128_1(KeyValuePair kp) { }

		internal float <CalculateRegenBaseRatesPerSecond>b__44_0(EBodyPart bodyPart) { }

	}

	internal class Berserk : Effect, IBerserk, IHealthEffect, IDesirable
	{

		public Berserk() { }

	}

	internal abstract class Bleeding : Effect
	{

		protected abstract BleedingSettings BleedingSettings
		{
			 get { } //Length: 0
		}

		public override int HealExperience
		{
			 get { } //Length: 41
		}

		public override float RemovePrice
		{
			 get { } //Length: 43
		}

		protected Bleeding() { }

		protected abstract BleedingSettings get_BleedingSettings() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

	}

	internal class BodyTemperature : Effect, IBodyTemperature, IHealthEffect, IDesirable
	{

		public BodyTemperature() { }

	}

	internal class ChronicStaminaFatigue : Effect, IChronicStaminaFatigue, IHealthEffect, IEffectTriggersUIPanel
	{

		public ChronicStaminaFatigue() { }

	}

	internal class Contusion : Effect, IContusion, IHealthEffect, IStackable
	{

		public Contusion() { }

	}

	internal class DamageModifier : Effect, IDamageModifier, IHealthEffect
	{

		public DamageModifier() { }

	}

	internal class Dehydration : Effect, IDehydration, IHealthEffect, IRestorable
	{

		public Dehydration() { }

	}

	internal class Disorientation : Effect, IDisorientation, IHealthEffect
	{

		public Disorientation() { }

	}

	internal abstract class Effect : IHealthEffect
	{
		[CompilerGenerated]
		private Type <Type>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private EBodyPart <BodyPart>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private EEffectState <State>k__BackingField; //Field offset: 0x1C
		[CompilerGenerated]
		private float <WholeTime>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private float <Strength>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private bool <WasPaused>k__BackingField; //Field offset: 0x28
		private float _workTime; //Field offset: 0x2C
		[CompilerGenerated]
		private int <UpdateTime>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private OfflineHealthController <_health>k__BackingField; //Field offset: 0x38
		private float _healthRate; //Field offset: 0x40
		private float _energyRate; //Field offset: 0x44
		private float _hydrationRate; //Field offset: 0x48
		private float _temperatureRate; //Field offset: 0x4C

		protected private OfflineHealthController _health
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override bool Active
		{
			 get { } //Length: 8
		}

		public private override EBodyPart BodyPart
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public override bool Critical
		{
			 get { } //Length: 3
		}

		public override float CurrentStrength
		{
			 get { } //Length: 9
		}

		public override float CurStateTimeLeft
		{
			 get { } //Length: 6
		}

		public override EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 81
		}

		public override bool Existing
		{
			 get { } //Length: 29
		}

		public override float OverallDuration
		{
			 get { } //Length: 6
		}

		public override bool Residual
		{
			 get { } //Length: 8
		}

		public private override EEffectState State
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override float Strength
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override float TimeLeft
		{
			 get { } //Length: 39
		}

		public private override Type Type
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected private int UpdateTime
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override bool WasPaused
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override float WholeTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override float WorkStateTime
		{
			 get { } //Length: 6
		}

		protected Effect() { }

		protected override void Added() { }

		public override void AddWholeTime(float deltaTime) { }

		public static Effect Create(OfflineHealthController health, string effectType, EBodyPart bodyPart, EffectInfo restoreInfo, Nullable updateTime) { }

		public static TEffect Create(OfflineHealthController health, EBodyPart bodyPart, EffectInfo restoreInfo, Nullable updateTime) { }

		[CompilerGenerated]
		protected OfflineHealthController get__health() { }

		public override bool get_Active() { }

		[CompilerGenerated]
		public override EBodyPart get_BodyPart() { }

		public override bool get_Critical() { }

		public override float get_CurrentStrength() { }

		public override float get_CurStateTimeLeft() { }

		public override EffectDescription[] get_DisplayableVariations() { }

		public override bool get_Existing() { }

		public override float get_OverallDuration() { }

		public override bool get_Residual() { }

		[CompilerGenerated]
		public override EEffectState get_State() { }

		[CompilerGenerated]
		public override float get_Strength() { }

		public override float get_TimeLeft() { }

		[CompilerGenerated]
		public override Type get_Type() { }

		[CompilerGenerated]
		protected int get_UpdateTime() { }

		[CompilerGenerated]
		public override bool get_WasPaused() { }

		[CompilerGenerated]
		public override float get_WholeTime() { }

		public override float get_WorkStateTime() { }

		protected static void InitEffect(Effect effect, OfflineHealthController health, EBodyPart bodyPart, EffectInfo restoreInfo, Nullable updateTime) { }

		public void ManualUpdate(float deltaTime) { }

		public override void Propagate() { }

		protected override void RegularUpdate(float deltaTime) { }

		public void Remove() { }

		protected override void Removed() { }

		[CompilerGenerated]
		private void set__health(OfflineHealthController value) { }

		[CompilerGenerated]
		private void set_BodyPart(EBodyPart value) { }

		[CompilerGenerated]
		private void set_State(EEffectState value) { }

		[CompilerGenerated]
		private void set_Strength(float value) { }

		[CompilerGenerated]
		private void set_Type(Type value) { }

		[CompilerGenerated]
		private void set_UpdateTime(int value) { }

		[CompilerGenerated]
		private void set_WasPaused(bool value) { }

		[CompilerGenerated]
		private void set_WholeTime(float value) { }

		protected void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature) { }

		protected override void Started() { }

		public override EffectInfo Store() { }

	}

	internal abstract class Effect`1 : Effect
	{
		protected TStore _store; //Field offset: 0x0

		protected Effect`1() { }

		public static TEffect Create(OfflineHealthController health, EBodyPart bodyPart, EffectInfo restoreInfo, Nullable updateTime, TStore store) { }

	}

	internal class Encumbered : Effect, IEncumbered, IHealthEffect, IEffectTriggersUIPanel
	{

		public Encumbered() { }

	}

	internal class Endurance : Effect, IEndurance, IHealthEffect
	{

		public override bool Absolute
		{
			 get { } //Length: 5
		}

		public Endurance() { }

		public override bool get_Absolute() { }

		protected virtual void Removed() { }

		protected virtual void Started() { }

	}

	internal class Exhaustion : Effect, IExhaustion, IHealthEffect, IRestorable
	{

		public Exhaustion() { }

	}

	internal class Existence : Effect, IExistence, IHealthEffect, IDesirable
	{

		public Existence() { }

	}

	internal class Flash : Effect, IFlash, IHealthEffect
	{

		public Flash() { }

	}

	internal class Fracture : Effect, IFracture, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		public override int HealExperience
		{
			 get { } //Length: 123
		}

		public override float RemovePrice
		{
			 get { } //Length: 125
		}

		public Fracture() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

	}

	internal class FractureSuppressed : Effect, IFractureSuppressed, ISuppressedEffect
	{

		public FractureSuppressed() { }

	}

	internal sealed class Frostbite : Effect, IFrostbite, IHealthEffect, IEffectTriggersUIPanel
	{

		public Frostbite() { }

	}

	internal class FullHealthRegenerationEffect : Effect, IFullHealthRegenerationEffect, IHealthEffect, IRestorable
	{

		public FullHealthRegenerationEffect() { }

	}

	internal sealed class HalloweenBuff : Effect, IHalloweenBuff, IHealthEffect
	{

		public HalloweenBuff() { }

	}

	internal class HealthBoost : Effect, IHealthBoost, IHealthEffect
	{

		public int HealExperience
		{
			 get { } //Length: 62
		}

		public HealthBoost() { }

		public int get_HealExperience() { }

	}

	internal class HeavyBleeding : Bleeding, IHeavyBleeding, IBleeding, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		protected virtual BleedingSettings BleedingSettings
		{
			 get { } //Length: 115
		}

		public HeavyBleeding() { }

		protected virtual BleedingSettings get_BleedingSettings() { }

	}

	internal class HeavyBleedingSuppressed : Effect, IHeavyBleedingSuppressed, ISuppressedEffect
	{

		public HeavyBleedingSuppressed() { }

	}

	private sealed class ImmunityController
	{
		private readonly OfflineHealthController _hc; //Field offset: 0x10
		private HashSet _immunitySettings; //Field offset: 0x18

		public ImmunityController(OfflineHealthController hc) { }

		private void EnsureImmunitySettingsLoaded() { }

		private bool IsImmune(Type effectType) { }

		private bool IsImmune(string effectName) { }

		public void TryApplyImmunityPolicy(Effect effectInstance) { }

		public string TryMapToSuppressedByName(string effectName) { }

	}

	internal sealed class ImmunityPreventedNegativeEffect : Effect, IImmunityPreventedNegativeEffect, IHealthEffect, IEffectTriggersUIPanel
	{

		public ImmunityPreventedNegativeEffect() { }

	}

	internal class Intoxication : Effect, IIntoxication, IRestorable, IPermanent, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		public override int HealExperience
		{
			 get { } //Length: 144
		}

		public override float RemovePrice
		{
			 get { } //Length: 146
		}

		public Intoxication() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

	}

	internal class LethalIntoxication : Effect, ILethalIntoxication, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect, IEffectTriggersUIPanel
	{

		public virtual bool Critical
		{
			 get { } //Length: 3
		}

		public override int HealExperience
		{
			 get { } //Length: 144
		}

		public override float RemovePrice
		{
			 get { } //Length: 146
		}

		public LethalIntoxication() { }

		public virtual bool get_Critical() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

	}

	internal class LightBleeding : Bleeding, ILightBleeding, IBleeding, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		protected virtual BleedingSettings BleedingSettings
		{
			 get { } //Length: 115
		}

		public LightBleeding() { }

		protected virtual BleedingSettings get_BleedingSettings() { }

	}

	internal class LightBleedingSuppressed : Effect, ILightBleedingSuppressed, ISuppressedEffect
	{

		public LightBleedingSuppressed() { }

	}

	internal class LowEdgeHealth : Effect, ILowEdgeHealth, IHealthEffect
	{

		public LowEdgeHealth() { }

	}

	internal class MedEffect : Effect, IMedEffect, IHealthEffect, IInitializable, IStackable, IDesirable
	{
		[CompilerGenerated]
		private Item <MedItem>k__BackingField; //Field offset: 0x60
		private HealthEffectsComponent _healthEffects; //Field offset: 0x68
		private MedKitComponent _medKit; //Field offset: 0x70
		private FoodDrinkComponent _foodDrink; //Field offset: 0x78
		private float _amount; //Field offset: 0x80
		private float _itemResourceUsageMultiplier; //Field offset: 0x84

		public override float Amount
		{
			 get { } //Length: 9
		}

		public private override Item MedItem
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override bool NoMove
		{
			 get { } //Length: 3
		}

		public MedEffect() { }

		[CompilerGenerated]
		private bool <Added>b__13_0(Item i) { }

		protected virtual void Added() { }

		public override float get_Amount() { }

		[CompilerGenerated]
		public override Item get_MedItem() { }

		public override bool get_NoMove() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		[CompilerGenerated]
		private void set_MedItem(Item value) { }

		protected virtual void Started() { }

	}

	internal class MildMusclePain : MusclePain, IMildMusclePain, IMusclePain, IRestorable, IHealthEffect, IInsignificant
	{

		protected virtual MusclePainSettings Settings
		{
			 get { } //Length: 139
		}

		public MildMusclePain() { }

		protected virtual MusclePainSettings get_Settings() { }

	}

	internal class MisfireEffect : Effect, IMisfireEffect, IHealthEffect
	{

		public MisfireEffect() { }

	}

	internal abstract class MusclePain : Effect
	{

		public float GymEffectivity
		{
			 get { } //Length: 43
		}

		protected abstract MusclePainSettings Settings
		{
			 get { } //Length: 0
		}

		public float TraumaChance
		{
			 get { } //Length: 43
		}

		protected MusclePain() { }

		public float get_GymEffectivity() { }

		protected abstract MusclePainSettings get_Settings() { }

		public float get_TraumaChance() { }

		public virtual EffectInfo Store() { }

	}

	internal class OverEncumbered : Effect, IOverEncumbered, IHealthEffect, IEffectTriggersUIPanel
	{

		public OverEncumbered() { }

	}

	internal class Pain : Effect, IPain, IExperienceHealthEffect, IHealthEffect, IHiddenByAnotherEffectAllOverBody
	{

		public override int HealExperience
		{
			 get { } //Length: 62
		}

		public override Type[] HiddenByTypes
		{
			 get { } //Length: 83
		}

		public Pain() { }

		public override int get_HealExperience() { }

		public override Type[] get_HiddenByTypes() { }

	}

	internal class PainKiller : Effect, IPainKiller, IHealthEffect, IStackableFromDifferentTemplates, IDesirable, IInitializable
	{
		[CompilerGenerated]
		private string <ItemTemplateId>k__BackingField; //Field offset: 0x50

		public private override string ItemTemplateId
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public PainKiller() { }

		[CompilerGenerated]
		public override string get_ItemTemplateId() { }

		[CompilerGenerated]
		private void set_ItemTemplateId(string value) { }

		public void StoreValues(string templateId, float duration) { }

		public override void UpdateWithSameOne(float strength) { }

	}

	internal class PainSuppressed : Effect, IPainSuppressed, ISuppressedEffect
	{

		public PainSuppressed() { }

	}

	internal class PanicEffect : Effect, IPanicEffect, IHealthEffect
	{

		public PanicEffect() { }

	}

	internal sealed class PerkEnergyRecoveryEffect : PerkTimedRatesEffect
	{

		public PerkEnergyRecoveryEffect() { }

	}

	internal sealed class PerkHealthRegenerationEffect : PerkTimedRatesEffect
	{

		public PerkHealthRegenerationEffect() { }

	}

	internal sealed class PerkHydrationRecoveryEffect : PerkTimedRatesEffect
	{

		public PerkHydrationRecoveryEffect() { }

	}

	internal sealed class PerkPainKillerEffect : PainKiller
	{

		public PerkPainKillerEffect() { }

	}

	internal class PerkTimedRatesEffect : Effect, IPerkTimedRatesEffect, IHealthEffect, IStackable, IInitializable
	{

		public PerkTimedRatesEffect() { }

	}

	internal class RadExposure : Effect, IRadExposure, IHealthEffect, IRestorable
	{

		public RadExposure() { }

	}

	internal class Regeneration : Effect, IRegeneration, IHealthEffect, IDesirable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__8_0; //Field offset: 0x8
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Influence", "Time"})]
			public static Func <>9__9_0; //Field offset: 0x10
			[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Influence", "Time", "Influence", "Time", "Influence", "Time"})]
			public static Func <>9__9_2; //Field offset: 0x18

			private static <>c() { }

			public <>c() { }

			internal bool <GetBodyPartHealthRegenTime>b__9_0(ValueTuple influence) { }

			internal ValueTuple <GetBodyPartHealthRegenTime>b__9_2(ValueTuple influence1, ValueTuple influence2) { }

			internal bool <RegularUpdate>b__8_0(BodyPartState s) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public EBodyPart bodyPart; //Field offset: 0x10

			public <>c__DisplayClass10_0() { }

			internal bool <GetInfluences>b__0(Effect e) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public EBodyPart bodyPart; //Field offset: 0x10

			public <>c__DisplayClass12_0() { }

			internal bool <GetInfluence>b__0(Effect e) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public float shortestTime; //Field offset: 0x10

			public <>c__DisplayClass9_0() { }

			internal bool <GetBodyPartHealthRegenTime>b__1(ValueTuple influence) { }

		}

		private float _loopTime; //Field offset: 0x50
		private float _hydrationPerLoop; //Field offset: 0x54
		private float _energyPerLoop; //Field offset: 0x58
		private float _curLoopTime; //Field offset: 0x5C

		public Regeneration() { }

		public void ForceUpdate() { }

		private float GetBodyPartHealthRegenTime(EBodyPart bodyPart, float healthToHeal) { }

		private float GetBodyPartRegenRatePerLoop(EBodyPart bodyPart) { }

		private void GetInfluence(EBodyPart bodyPart, out float healthInfluence, out float hydrationInfluence, out float energyInfluence) { }

		private List GetInfluences(EHealthFactorType healthFactor, EBodyPart bodyPart) { }

		public float GetOverallHealthRegenTime() { }

		public void RecalculateRates() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class SandingScreen : Effect, ISandingScreen, IHealthEffect
	{

		public SandingScreen() { }

	}

	internal class ScavRegeneration : Effect, IRegeneration, IHealthEffect, IDesirable
	{

		public ScavRegeneration() { }

	}

	internal class SevereMusclePain : MusclePain, ISevereMusclePain, IMusclePain, IRestorable, IHealthEffect, IInsignificant
	{

		protected virtual MusclePainSettings Settings
		{
			 get { } //Length: 139
		}

		public SevereMusclePain() { }

		protected virtual MusclePainSettings get_Settings() { }

	}

	internal class Stimulator : Effect, IStimulator, IHealthEffect, IInitializable, IDesirable, IStackableFromDifferentTemplates
	{
		private sealed class Buff : IStimulatorBuff, IStimulatorDebuff
		{
			[CompilerGenerated]
			private StimulatorBuffSettings <Settings>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			private EBodyPart <BodyPart>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			private float <WholeTime>k__BackingField; //Field offset: 0x1C

			public override bool Active
			{
				 get { } //Length: 3
			}

			public override EBodyPart BodyPart
			{
				[CompilerGenerated]
				 get { } //Length: 4
				[CompilerGenerated]
				 set { } //Length: 4
			}

			public override string BuffName
			{
				 get { } //Length: 11
			}

			public override Type BuffType
			{
				 get { } //Length: 11
			}

			public override StimulatorBuffSettings Settings
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				 set { } //Length: 82
			}

			public override float Value
			{
				 get { } //Length: 4
			}

			public override float WholeTime
			{
				[CompilerGenerated]
				 get { } //Length: 6
				[CompilerGenerated]
				 set { } //Length: 6
			}

			public Buff() { }

			public override bool get_Active() { }

			[CompilerGenerated]
			public override EBodyPart get_BodyPart() { }

			public override string get_BuffName() { }

			public override Type get_BuffType() { }

			[CompilerGenerated]
			public override StimulatorBuffSettings get_Settings() { }

			public override float get_Value() { }

			[CompilerGenerated]
			public override float get_WholeTime() { }

			public override void IncreaseBySameBuff(float curStimulatorTime, float strength, SkillManager skillManager) { }

			[CompilerGenerated]
			public void set_BodyPart(EBodyPart value) { }

			[CompilerGenerated]
			public void set_Settings(StimulatorBuffSettings value) { }

			[CompilerGenerated]
			public override void set_WholeTime(float value) { }

		}

		[CompilerGenerated]
		private IStimulatorBuff[] <ActiveBuffs>k__BackingField; //Field offset: 0x68

		public private override IStimulatorBuff[] ActiveBuffs
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 7
		}

		public override string ItemTemplateId
		{
			 get { } //Length: 5
		}

		public Stimulator() { }

		protected virtual void Added() { }

		public virtual void AddWholeTime(float deltaTime) { }

		[CompilerGenerated]
		public override IStimulatorBuff[] get_ActiveBuffs() { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		public override string get_ItemTemplateId() { }

		[CompilerGenerated]
		private void set_ActiveBuffs(IStimulatorBuff[] value) { }

		public override void UpdateWithSameOne(float strength = 1) { }

	}

	internal class Stun : Effect, IStun, IHealthEffect
	{

		public Stun() { }

	}

	internal class TearGasStrong : Effect, ITearGasStrong, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{

		public TearGasStrong() { }

		public override void TryApplyBuffs() { }

		public override bool TryTriggerCough() { }

	}

	internal class TearGasWeak : Effect, ITearGasWeak, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{

		public TearGasWeak() { }

		public override void TryApplyBuffs() { }

	}

	internal class Tremor : Effect, ITremor, IHealthEffect, IStackable
	{

		public Tremor() { }

	}

	internal class TunnelVision : Effect, ITunnelVision, IHealthEffect
	{

		public TunnelVision() { }

	}

	internal class Wound : Effect, IWound, IHealthEffect
	{

		public Wound() { }

	}

	internal class ZombieInfection : Effect, IZombieInfection, IHealthEffect
	{

		public ZombieInfection() { }

	}

	public static readonly List TreatableEffectTypes; //Field offset: 0x0
	[CompilerGenerated]
	private Action EffectStartedEvent; //Field offset: 0xD8
	[CompilerGenerated]
	private Action EffectUpdatedEvent; //Field offset: 0xE0
	[CompilerGenerated]
	private Action EffectResidualEvent; //Field offset: 0xE8
	[CompilerGenerated]
	private Action EffectRemovedEvent; //Field offset: 0xF0
	[CompilerGenerated]
	private Action EffectAddedEvent; //Field offset: 0xF8
	[CompilerGenerated]
	private Action EffectStatusUpdateEvent; //Field offset: 0x100
	[CompilerGenerated]
	private Action HealthChangedEvent; //Field offset: 0x108
	[CompilerGenerated]
	private Action EnergyChangedEvent; //Field offset: 0x110
	[CompilerGenerated]
	private Action HydrationChangedEvent; //Field offset: 0x118
	[CompilerGenerated]
	private Action TemperatureChangedEvent; //Field offset: 0x120
	[CompilerGenerated]
	private Action PoisonChangedEvent; //Field offset: 0x128
	[CompilerGenerated]
	private Action HealerDoneEvent; //Field offset: 0x130
	[CompilerGenerated]
	private Action ApplyDamageEvent; //Field offset: 0x138
	[CompilerGenerated]
	private Action BodyPartDestroyedEvent; //Field offset: 0x140
	[CompilerGenerated]
	private Action BodyPartRestoredEvent; //Field offset: 0x148
	[CompilerGenerated]
	private Action DiedEvent; //Field offset: 0x150
	[CompilerGenerated]
	private Action BurnEyesEvent; //Field offset: 0x158
	private Regeneration _regeneration; //Field offset: 0x160
	private ImmunityController _immunity; //Field offset: 0x168

	public virtual event Action ApplyDamageEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action BodyPartDestroyedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action BodyPartRestoredEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action BurnEyesEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action DiedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EffectAddedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EffectRemovedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EffectResidualEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EffectStartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EffectStatusUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EffectUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action EnergyChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action HealerDoneEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action HealthChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action HydrationChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action PoisonChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual event Action TemperatureChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected static EffectsSettings EffectsSettings
	{
		 get { } //Length: 73
	}

	private static OfflineHealthController() { }

	public OfflineHealthController(HealthInfo profileHealth, InventoryController inventory, SkillManager skills, bool regeneration = true) { }

	[CompilerGenerated]
	public virtual void add_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_DiedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_PoisonChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_TemperatureChangedEvent(Action value) { }

	public virtual bool ApplyItem(Item item, OneAndList bodyParts, Nullable amount = null) { }

	public virtual bool ApplyItem(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public void ApplyRegenerationImmediately() { }

	public void ApplyTreatment(IHealthObserver healthObserver) { }

	private static float CalculateBonus(EBonusType bonusType, double value) { }

	public static void CalculateRegenBaseRatesPerSecond(out float health, out float energy, out float hydration) { }

	public static void CalculateRegenRatesPerSecond(out float health, out float energy, out float hydration) { }

	public virtual bool CanApplyItem(Item item, EBodyPart bodyPart) { }

	public virtual void CancelApplyingItem() { }

	public void ChangeEnergy(float value) { }

	public void ChangeHealth(EBodyPart bodyPart, float value, DamageInfo damageInfo) { }

	public void ChangeHydration(float value) { }

	private void ChangePoison(float value) { }

	private void ChangeTemperature(float value) { }

	private void CreateMusclePain(float duration) { }

	public void CreateMusclePainEffect(float duration) { }

	public void DoFracture(EBodyPart bodyPart, float duration = -1) { }

	protected static EffectsSettings get_EffectsSettings() { }

	public MusclePainSettings GetMildMusclePainSettings() { }

	public float GetOverallHealthRegenTime() { }

	public MusclePainSettings GetSevereMusclePainSettings() { }

	public bool HasMildMusclePainEffect() { }

	public bool HasSevereMusclePainEffect() { }

	protected virtual void ManualEffectUpdate(Effect effect, float deltaTime) { }

	public void RecalculateRegeneration() { }

	[CompilerGenerated]
	public virtual void remove_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_DiedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_PoisonChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_TemperatureChangedEvent(Action value) { }

	public virtual HealthInfo Store(HealthInfo health = null) { }

	protected virtual bool TryGetBodyPartToApply(Item item, EBodyPart bodyPart, out Nullable damagedBodyPart) { }

}

