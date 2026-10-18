namespace EFT.HealthSystem;

public abstract class NetworkHealthController : BaseHealthController
{
	internal class Berserk : Effect, IBerserk, IHealthEffect, IDesirable
	{

		public Berserk() { }

	}

	internal abstract class Bleeding : Effect
	{

		public override int HealExperience
		{
			 get { } //Length: 62
		}

		public override float RemovePrice
		{
			 get { } //Length: 62
		}

		protected Bleeding() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

	}

	internal class BodyTemperature : Effect, IBodyTemperature, IHealthEffect, IDesirable
	{

		public BodyTemperature() { }

	}

	internal class ChronicStaminaFatigue : Effect, IChronicStaminaFatigue, IHealthEffect, IEffectTriggersUIPanel
	{
		private EffectDescription _effectDescription; //Field offset: 0x60
		private List _buffs; //Field offset: 0x68

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 256
		}

		private float Rate
		{
			private get { } //Length: 222
		}

		public ChronicStaminaFatigue() { }

		[CompilerGenerated]
		private float <GetBuffs>b__7_0() { }

		public EffectDescription[] CustomVariation(IHealthEffect effect, bool exactTime) { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		private float get_Rate() { }

		private List GetBuffs() { }

		private string GetCustomString() { }

		public virtual void SetStrength(float strength) { }

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
		private int <Id>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Type <Type>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private EBodyPart <BodyPart>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private EEffectState <State>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private float <BuildUpTime>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private float <WorkStateTime>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private float <WholeTime>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private float <CurrentStrength>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private float <Strength>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private NetworkHealthController <HealthController>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private float <StateCurrentTime>k__BackingField; //Field offset: 0x48
		private float _defaultBuildUpTime; //Field offset: 0x4C
		private float _stateTime; //Field offset: 0x50
		[CompilerGenerated]
		private float <DelayTime>k__BackingField; //Field offset: 0x54
		[CompilerGenerated]
		private float <ResidueTime>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private bool <WasPaused>k__BackingField; //Field offset: 0x5C

		public override bool Active
		{
			 get { } //Length: 34
		}

		public private override EBodyPart BodyPart
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private float BuildUpTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override bool Critical
		{
			 get { } //Length: 3
		}

		public override float CurrentStrength
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public override float CurStateTimeLeft
		{
			 get { } //Length: 25
		}

		public private float DelayTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 81
		}

		protected EffectsSettings EffectsSettings
		{
			 get { } //Length: 73
		}

		public override bool Existing
		{
			 get { } //Length: 67
		}

		public private NetworkHealthController HealthController
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private int Id
		{
			[CompilerGenerated]
			 get { } //Length: 164
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public override float OverallDuration
		{
			 get { } //Length: 89
		}

		public override bool Residual
		{
			 get { } //Length: 34
		}

		public private float ResidueTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public override EEffectState State
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		protected private float StateCurrentTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public float StateTime
		{
			 get { } //Length: 6
		}

		protected override object StoreObj
		{
			 get { } //Length: 3
			 set { } //Length: 3
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
			 get { } //Length: 81
		}

		public private override Type Type
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
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

		public private override float WorkStateTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		protected Effect() { }

		[CompilerGenerated]
		private void <UnPauseEffect>g__AddedState|90_0() { }

		[CompilerGenerated]
		private void <UnPauseEffect>g__StartedState|90_1() { }

		protected override void Added() { }

		public override void AddWholeTime(float deltaTime) { }

		protected override void CalculateCurrentStrength(float deltaTime = 0) { }

		public static Effect Create(NetworkHealthController health, SyncAddEffect data) { }

		public static Effect Create(NetworkHealthController health, BinaryReader reader) { }

		protected override void Deserialize(BinaryReader reader) { }

		public override void ForceRemove() { }

		public override bool get_Active() { }

		[CompilerGenerated]
		public override EBodyPart get_BodyPart() { }

		[CompilerGenerated]
		public float get_BuildUpTime() { }

		public override bool get_Critical() { }

		[CompilerGenerated]
		public override float get_CurrentStrength() { }

		public override float get_CurStateTimeLeft() { }

		[CompilerGenerated]
		public float get_DelayTime() { }

		public override EffectDescription[] get_DisplayableVariations() { }

		protected EffectsSettings get_EffectsSettings() { }

		public override bool get_Existing() { }

		[CompilerGenerated]
		public NetworkHealthController get_HealthController() { }

		[CompilerGenerated]
		public int get_Id() { }

		public override float get_OverallDuration() { }

		public override bool get_Residual() { }

		[CompilerGenerated]
		public float get_ResidueTime() { }

		[CompilerGenerated]
		public override EEffectState get_State() { }

		[CompilerGenerated]
		protected float get_StateCurrentTime() { }

		public float get_StateTime() { }

		protected override object get_StoreObj() { }

		[CompilerGenerated]
		public override float get_Strength() { }

		public override float get_TimeLeft() { }

		[CompilerGenerated]
		public override Type get_Type() { }

		[CompilerGenerated]
		public override bool get_WasPaused() { }

		[CompilerGenerated]
		public override float get_WholeTime() { }

		[CompilerGenerated]
		public override float get_WorkStateTime() { }

		public void ManualUpdate(float deltaTime) { }

		public void NextState(float stateCurTime, float stateTime) { }

		public override void Propagate() { }

		protected override void Removed() { }

		protected override void Residue() { }

		[CompilerGenerated]
		private void set_BodyPart(EBodyPart value) { }

		[CompilerGenerated]
		private void set_BuildUpTime(float value) { }

		[CompilerGenerated]
		protected void set_CurrentStrength(float value) { }

		[CompilerGenerated]
		private void set_DelayTime(float value) { }

		[CompilerGenerated]
		private void set_HealthController(NetworkHealthController value) { }

		[CompilerGenerated]
		private void set_Id(int value) { }

		[CompilerGenerated]
		private void set_ResidueTime(float value) { }

		[CompilerGenerated]
		protected override void set_State(EEffectState value) { }

		[CompilerGenerated]
		private void set_StateCurrentTime(float value) { }

		protected override void set_StoreObj(object value) { }

		[CompilerGenerated]
		private void set_Strength(float value) { }

		[CompilerGenerated]
		private void set_Type(Type value) { }

		[CompilerGenerated]
		private void set_WasPaused(bool value) { }

		[CompilerGenerated]
		private void set_WholeTime(float value) { }

		[CompilerGenerated]
		private void set_WorkStateTime(float value) { }

		public void SetEffectInfo(int id, IHealthController hController, Type type, EBodyPart bodyPart, float strength, float currentStrength, float delayTime, float stateTime, float workStateTime, float buildUpTime, float residueStateTime, EEffectState state) { }

		public void SetRemainingStateTime(float value) { }

		public override void SetStrength(float value) { }

		protected override void Started() { }

		public override void UnPauseEffect() { }

	}

	internal abstract class Effect`1 : Effect
	{
		protected TStore _store; //Field offset: 0x0

		protected virtual object StoreObj
		{
			 get { } //Length: 42
			 set { } //Length: 101
		}

		protected Effect`1() { }

		protected virtual object get_StoreObj() { }

		protected virtual void set_StoreObj(object value) { }

	}

	internal class Encumbered : Effect, IEncumbered, IHealthEffect, IEffectTriggersUIPanel
	{
		private readonly List _tips; //Field offset: 0x60
		private Action _unsub; //Field offset: 0x68
		private EffectDescription _effectDescription; //Field offset: 0x70

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 14
		}

		public Encumbered() { }

		[CompilerGenerated]
		private void <GetDisplayVariations>b__5_0() { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		private EffectDescription[] GetDisplayVariations(IHealthEffect effect, bool exactTime) { }

		private void PhysicalOnWeightRelatedValuesUpdated() { }

		protected virtual void Removed() { }

		protected override void UpdateDebuffs() { }

	}

	internal class Endurance : Effect, IEndurance, IHealthEffect
	{

		public override bool Absolute
		{
			 get { } //Length: 5
		}

		public Endurance() { }

		protected virtual void Deserialize(BinaryReader reader) { }

		public override bool get_Absolute() { }

		protected virtual void Residue() { }

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
			 get { } //Length: 62
		}

		public override float RemovePrice
		{
			 get { } //Length: 62
		}

		public Fracture() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

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

		public HeavyBleeding() { }

	}

	internal sealed class ImmunityPreventedNegativeEffect : Effect, IImmunityPreventedNegativeEffect, IHealthEffect, IEffectTriggersUIPanel
	{

		public ImmunityPreventedNegativeEffect() { }

	}

	internal class Intoxication : Effect, IIntoxication, IRestorable, IPermanent, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		public override int HealExperience
		{
			 get { } //Length: 62
		}

		public override float RemovePrice
		{
			 get { } //Length: 62
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
			 get { } //Length: 62
		}

		public override float RemovePrice
		{
			 get { } //Length: 62
		}

		public LethalIntoxication() { }

		public virtual bool get_Critical() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

	}

	internal class LightBleeding : Bleeding, ILightBleeding, IBleeding, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		public LightBleeding() { }

	}

	internal class LowEdgeHealth : Effect, ILowEdgeHealth, IHealthEffect
	{

		public LowEdgeHealth() { }

	}

	internal class MedEffect : Effect, IMedEffect, IHealthEffect, IInitializable, IStackable, IDesirable
	{
		[CompilerGenerated]
		private Item <MedItem>k__BackingField; //Field offset: 0x70
		private HealthEffectsComponent _healthEffects; //Field offset: 0x78
		private MedKitComponent _medKit; //Field offset: 0x80
		private FoodDrinkComponent _foodDrink; //Field offset: 0x88

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
			 get { } //Length: 334
		}

		public MedEffect() { }

		[CompilerGenerated]
		private bool <Added>b__12_0(Item i) { }

		private void ActiveEventsHandler(ItemEventArgs eventArgs) { }

		protected virtual void Added() { }

		protected virtual void Deserialize(BinaryReader reader) { }

		public override float get_Amount() { }

		[CompilerGenerated]
		public override Item get_MedItem() { }

		public override bool get_NoMove() { }

		private bool IsNoMove() { }

		protected virtual void Removed() { }

		protected virtual void Residue() { }

		[CompilerGenerated]
		private void set_MedItem(Item value) { }

		protected virtual void Started() { }

		public void UpdateResource(float value) { }

	}

	internal class MildMusclePain : MusclePain, IMildMusclePain, IMusclePain, IRestorable, IHealthEffect, IInsignificant
	{

		public MildMusclePain() { }

	}

	internal class MisfireEffect : Effect, IMisfireEffect, IHealthEffect
	{

		public MisfireEffect() { }

	}

	internal abstract class MusclePain : Effect
	{

		protected MusclePain() { }

	}

	internal class OverEncumbered : Effect, IOverEncumbered, IHealthEffect, IEffectTriggersUIPanel
	{
		private readonly List _tips; //Field offset: 0x60
		private EffectDescription _effectDescription; //Field offset: 0x68

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 272
		}

		public OverEncumbered() { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		public EffectDescription[] GetDisplayVariations(IHealthEffect effect, bool exactTime) { }

		public override void UpdateDebuffs() { }

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
		private string <ItemTemplateId>k__BackingField; //Field offset: 0x60

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

		public Regeneration() { }

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

		public SevereMusclePain() { }

	}

	internal class StaminaZero : Effect, IStaminaZeroEffect, IHealthEffect, IInitializable
	{

		public StaminaZero() { }

		protected virtual void Started() { }

	}

	internal class Stimulator : Effect, IStimulator, IHealthEffect, IInitializable, IDesirable, IStackableFromDifferentTemplates
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public Buff buff; //Field offset: 0x10

			public <>c__DisplayClass9_0() { }

			internal bool <SyncBuff>b__0(Skill s) { }

		}

		private sealed class Buff : IStimulatorBuff, IStimulatorDebuff
		{
			[CompilerGenerated]
			private bool <Active>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			private float <Value>k__BackingField; //Field offset: 0x14
			[CompilerGenerated]
			private StimulatorBuffSettings <Settings>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			private EBodyPart <BodyPart>k__BackingField; //Field offset: 0x20
			[CompilerGenerated]
			private float <WholeTime>k__BackingField; //Field offset: 0x24

			public override bool Active
			{
				[CompilerGenerated]
				 get { } //Length: 5
				[CompilerGenerated]
				 set { } //Length: 4
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
				[CompilerGenerated]
				 get { } //Length: 6
				[CompilerGenerated]
				 set { } //Length: 6
			}

			public override float WholeTime
			{
				[CompilerGenerated]
				 get { } //Length: 6
				[CompilerGenerated]
				 set { } //Length: 6
			}

			public Buff() { }

			[CompilerGenerated]
			public override bool get_Active() { }

			[CompilerGenerated]
			public override EBodyPart get_BodyPart() { }

			public override string get_BuffName() { }

			public override Type get_BuffType() { }

			[CompilerGenerated]
			public override StimulatorBuffSettings get_Settings() { }

			[CompilerGenerated]
			public override float get_Value() { }

			[CompilerGenerated]
			public override float get_WholeTime() { }

			public override void IncreaseBySameBuff(float curStimulatorTime, float strength, SkillManager skillManager) { }

			[CompilerGenerated]
			public void set_Active(bool value) { }

			[CompilerGenerated]
			public void set_BodyPart(EBodyPart value) { }

			[CompilerGenerated]
			public void set_Settings(StimulatorBuffSettings value) { }

			[CompilerGenerated]
			public void set_Value(float value) { }

			[CompilerGenerated]
			public override void set_WholeTime(float value) { }

		}

		[CompilerGenerated]
		private IStimulatorBuff[] <ActiveBuffs>k__BackingField; //Field offset: 0x78

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

		protected virtual void Deserialize(BinaryReader reader) { }

		[CompilerGenerated]
		public override IStimulatorBuff[] get_ActiveBuffs() { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		public override string get_ItemTemplateId() { }

		[CompilerGenerated]
		private void set_ActiveBuffs(IStimulatorBuff[] value) { }

		public void SyncBuff(int index, bool activate, float affectedValue, float duration, float delay) { }

		public override void UpdateWithSameOne(float strength = 1) { }

	}

	internal class Stun : Effect, IStun, IHealthEffect
	{

		public Stun() { }

		protected virtual void CalculateCurrentStrength(float deltaTime = 0) { }

	}

	internal abstract class TearGas : Effect, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{
		private bool _buffsApplied; //Field offset: 0x60

		protected abstract TearGasSettings Settings
		{
			 get { } //Length: 0
		}

		protected TearGas() { }

		protected abstract TearGasSettings get_Settings() { }

		protected virtual void Removed() { }

		protected virtual void Started() { }

		public override void TryApplyBuffs() { }

	}

	internal class TearGasStrong : TearGas, ITearGasStrong, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{
		private float _lastCoughTime; //Field offset: 0x68

		protected virtual TearGasSettings Settings
		{
			 get { } //Length: 85
		}

		public TearGasStrong() { }

		protected virtual TearGasSettings get_Settings() { }

		public override bool TryTriggerCough() { }

	}

	internal class TearGasWeak : TearGas, ITearGasWeak, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{

		protected virtual TearGasSettings Settings
		{
			 get { } //Length: 85
		}

		public TearGasWeak() { }

		protected virtual TearGasSettings get_Settings() { }

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

	private ImmunityController _immunity; //Field offset: 0xD8
	[CompilerGenerated]
	private Action EffectStartedEvent; //Field offset: 0xE0
	[CompilerGenerated]
	private Action EffectUpdatedEvent; //Field offset: 0xE8
	[CompilerGenerated]
	private Action EffectResidualEvent; //Field offset: 0xF0
	[CompilerGenerated]
	private Action EffectRemovedEvent; //Field offset: 0xF8
	[CompilerGenerated]
	private Action EffectAddedEvent; //Field offset: 0x100
	[CompilerGenerated]
	private Action EffectStatusUpdateEvent; //Field offset: 0x108
	[CompilerGenerated]
	private Action ApplyDamageEvent; //Field offset: 0x110
	[CompilerGenerated]
	private Action HealthChangedEvent; //Field offset: 0x118
	[CompilerGenerated]
	private Action EnergyChangedEvent; //Field offset: 0x120
	[CompilerGenerated]
	private Action HydrationChangedEvent; //Field offset: 0x128
	[CompilerGenerated]
	private Action TemperatureChangedEvent; //Field offset: 0x130
	[CompilerGenerated]
	private Action PoisonChangedEvent; //Field offset: 0x138
	[CompilerGenerated]
	private Action BodyPartDestroyedEvent; //Field offset: 0x140
	[CompilerGenerated]
	private Action BodyPartRestoredEvent; //Field offset: 0x148
	[CompilerGenerated]
	private Action HealerDoneEvent; //Field offset: 0x150
	[CompilerGenerated]
	private Action DiedEvent; //Field offset: 0x158
	[CompilerGenerated]
	private Action BurnEyesEvent; //Field offset: 0x160

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

	protected abstract Player Player
	{
		 get { } //Length: 0
	}

	protected NetworkHealthController(byte[] serializedState, InventoryController inventory, SkillManager skills) { }

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

	private Effect FindEffectById(int id) { }

	protected abstract Player get_Player() { }

	public void HandleSyncPacket(SyncHealthPacket packet) { }

	protected virtual void ManualEffectUpdate(Effect effect, float deltaTime) { }

	private void NetworkSyncAddEffect(SyncAddEffect data) { }

	private void NetworkSyncApplyDamage(SyncApplyDamage data) { }

	private void NetworkSyncBodyHealth(SyncBodyHealth data) { }

	private void NetworkSyncBurnEyes(SyncBurnEyes data) { }

	private void NetworkSyncDamageCoeff(SyncDamageCoeff data) { }

	private void NetworkSyncDestroyedBodyPart(SyncDestroyedBodyPart data) { }

	private void NetworkSyncEffectMedResource(SyncEffectMedResource data) { }

	private void NetworkSyncEffectNextState(SyncEffectNextState data) { }

	private void NetworkSyncEffectStateTime(SyncEffectStateTime data) { }

	private void NetworkSyncEffectStimulatorBuff(SyncEffectStimulatorBuff data) { }

	private void NetworkSyncEffectStrength(SyncEffectStrength data) { }

	private void NetworkSyncEnergy(SyncHealthFactor data) { }

	private void NetworkSyncHealerDone(SyncHealerDone data) { }

	private void NetworkSyncHealthRates(SyncHealthRates data) { }

	private void NetworkSyncHydration(SyncHealthFactor data) { }

	private void NetworkSyncIsAlive(SyncIsAlive data) { }

	private void NetworkSyncPoison(SyncHealthFactor data) { }

	private void NetworkSyncRemoveEffect(SyncRemoveEffect data) { }

	private void NetworkSyncStaminaCoeff(SyncStaminaCoeff data) { }

	private void NetworkSyncTemperature(SyncHealthFactor data) { }

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

}

