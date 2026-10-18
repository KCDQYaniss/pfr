namespace EFT.HealthSystem;

public abstract class ActiveHealthController : BaseHealthController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__81_0; //Field offset: 0x8
		public static Func <>9__100_0; //Field offset: 0x10
		public static Func <>9__101_0; //Field offset: 0x18
		public static Func <>9__102_0; //Field offset: 0x20
		public static Func <>9__115_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <ActiveBuffsNames>b__115_0(Stimulator stimulator) { }

		internal bool <RemoveBleedingEffects>b__102_0(Effect effect) { }

		internal bool <RemoveMedEffect>b__101_0(Effect effect) { }

		internal bool <RemoveNegativeEffects>b__100_0(Effect effect) { }

		internal string <TryDoExternalBuff>b__81_0(Stimulator stimulator) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass108_0
	{
		public SideEffectComponent sideEffect; //Field offset: 0x10
		public Item weapon; //Field offset: 0x18
		public EBodyPart bodyPart; //Field offset: 0x20

		public <>c__DisplayClass108_0() { }

		internal void <TryApplySideEffects>b__0(Stimulator e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass113_0
	{
		public EStimulatorBuffType buffType; //Field offset: 0x10
		public Func <>9__1; //Field offset: 0x18

		public <>c__DisplayClass113_0() { }

		internal bool <HasStimulatorBuff>b__0(Stimulator s) { }

		internal bool <HasStimulatorBuff>b__1(IStimulatorBuff b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass154_0
	{
		public Meds <meds>5__2; //Field offset: 0x10
		public FoodDrink <foodDrink>5__3; //Field offset: 0x18
		public float actualAmount; //Field offset: 0x20

		public <>c__DisplayClass154_0() { }

		internal void <DoMedEffect>b__0(MedEffect e) { }

		internal void <DoMedEffect>b__1(MedEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0`1
	{
		public Item effectSourceItem; //Field offset: 0x0

		public <>c__DisplayClass77_0`1() { }

		internal bool <AddStackableEffect>b__0(TEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0`1
	{
		public EBodyPart bodyPart; //Field offset: 0x0
		public Action initCallback; //Field offset: 0x0

		public <>c__DisplayClass78_0`1() { }

		internal bool <AddEffect>b__0(Effect e) { }

		internal void <AddEffect>b__1(Effect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public List pausedEffects; //Field offset: 0x10
		public List pausedEffectsInfo; //Field offset: 0x18
		public ActiveHealthController <>4__this; //Field offset: 0x20

		public <>c__DisplayClass79_0() { }

		internal void <PauseAllEffects>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public string buffName; //Field offset: 0x10

		public <>c__DisplayClass81_0() { }

		internal bool <TryDoExternalBuff>b__1(string buff) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public string buffName; //Field offset: 0x10

		public <>c__DisplayClass82_0() { }

		internal void <DoExternalBuff>b__0(Stimulator e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0`1
	{
		public float healthPerSecond; //Field offset: 0x0
		public float energyPerSecond; //Field offset: 0x0
		public float hydrationPerSecond; //Field offset: 0x0

		public <>c__DisplayClass88_0`1() { }

		internal void <ApplyPerkTimedRates>b__0(TEffect effect) { }

	}

	internal class Berserk : Effect, IBerserk, IHealthEffect, IDesirable
	{

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 95
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 95
		}

		protected virtual float DefaultWorkTime
		{
			 get { } //Length: 95
		}

		public Berserk() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual float get_DefaultWorkTime() { }

	}

	internal abstract class Bleeding : Effect
	{
		private float _curHealthDamage; //Field offset: 0x88
		private float _healthLoopTime; //Field offset: 0x8C
		private float _healthCurLoopTime; //Field offset: 0x90
		private float _energyCurLoopTime; //Field offset: 0x94
		private float _totalHealthDamage; //Field offset: 0x98
		private float _totalEnergyDamage; //Field offset: 0x9C

		protected float DamageEnergy
		{
			 get { } //Length: 43
		}

		protected abstract DamageInfo DamageInfo
		{
			 get { } //Length: 0
		}

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 43
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 43
		}

		protected virtual float DefaultWorkTime
		{
			 get { } //Length: 229
		}

		protected float EnergyLoopTime
		{
			 get { } //Length: 43
		}

		public override int HealExperience
		{
			 get { } //Length: 41
		}

		public override float RemovePrice
		{
			 get { } //Length: 43
		}

		protected abstract BleedingSettings Settings
		{
			 get { } //Length: 0
		}

		protected Bleeding() { }

		private void BleedEnergy() { }

		private void BleedHealth() { }

		protected float get_DamageEnergy() { }

		protected abstract DamageInfo get_DamageInfo() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual float get_DefaultWorkTime() { }

		protected float get_EnergyLoopTime() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

		protected abstract BleedingSettings get_Settings() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		public override void ResetParameters(bool hasDehydration) { }

		protected virtual void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature) { }

		protected virtual void Started() { }

	}

	internal class BodyTemperature : Effect, IBodyTemperature, IHealthEffect, IDesirable
	{
		private float _lastStrength; //Field offset: 0x88
		private float _currentLoopTime; //Field offset: 0x8C
		private float _loopTime; //Field offset: 0x90

		protected virtual float DefaultBuildUpTime
		{
			 get { } //Length: 95
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 95
		}

		public BodyTemperature() { }

		protected virtual float get_DefaultBuildUpTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Removed() { }

		protected virtual void ResidualUpdate(float deltaTime) { }

		protected virtual void Residue() { }

		protected virtual void Started() { }

	}

	internal class ChronicStaminaFatigue : Effect, IChronicStaminaFatigue, IHealthEffect, IEffectTriggersUIPanel
	{
		private float _nextTick; //Field offset: 0x88
		private EffectDescription _effectDescription; //Field offset: 0x90
		private List _buffs; //Field offset: 0x98

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 275
		}

		private float Rate
		{
			private get { } //Length: 222
		}

		public ChronicStaminaFatigue() { }

		[CompilerGenerated]
		private float <GetBuffs>b__8_0() { }

		public EffectDescription[] CustomVariation(IHealthEffect effect, bool exactTime) { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		private float get_Rate() { }

		private List GetBuffs() { }

		private string GetCustomString() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		public virtual void SetStrength(float strength) { }

		protected virtual void Started() { }

	}

	internal class Contusion : Effect, IContusion, IHealthEffect, IStackable
	{
		private const float DEFAULT_FORCE_RESIDUE_TIME = 2; //Field offset: 0x0

		public Contusion() { }

		public virtual void ForceResidue() { }

	}

	internal sealed class DamageModifier : Effect, IDamageModifier, IHealthEffect
	{

		private float DamageMultiplier
		{
			private get { } //Length: 14
		}

		public DamageModifier() { }

		private float get_DamageMultiplier() { }

		protected virtual void Residue() { }

		protected virtual void Started() { }

	}

	internal class Dehydration : Effect, IDehydration, IHealthEffect, IRestorable
	{
		private float _lastDamage; //Field offset: 0x88
		private float _damageCurLoopTime; //Field offset: 0x8C

		private float Damage
		{
			private get { } //Length: 139
		}

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public Dehydration() { }

		protected virtual void Added() { }

		private float get_Damage() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Residue() { }

		protected virtual void Started() { }

	}

	internal class Disorientation : Effect, IDisorientation, IHealthEffect
	{

		public Disorientation() { }

		protected virtual void ResidualUpdate(float deltaTime) { }

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
		private float <CurrentStrength>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private float <Strength>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private float <DelayTime>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private float <BuildUpTime>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private float <WorkStateTime>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private float <ResidueStateTime>k__BackingField; //Field offset: 0x3C
		[CompilerGenerated]
		private float <WholeTime>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private bool <ForceRemoved>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		private float <StateCurrentTime>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private bool <WasPaused>k__BackingField; //Field offset: 0x4C
		[CompilerGenerated]
		private ActiveHealthController <HealthController>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private int <UpdateTime>k__BackingField; //Field offset: 0x58
		private Effect _sideEffect; //Field offset: 0x60
		private float _healthRate; //Field offset: 0x68
		private float _energyRate; //Field offset: 0x6C
		private float _hydrationRate; //Field offset: 0x70
		private float _temperatureRate; //Field offset: 0x74
		private float _stateTime; //Field offset: 0x78
		protected float _energyGainedByEffect; //Field offset: 0x7C
		protected float _hydrationGainedByEffect; //Field offset: 0x80

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

		protected override float DefaultBuildUpTime
		{
			 get { } //Length: 9
		}

		protected override float DefaultDelayTime
		{
			 get { } //Length: 4
		}

		protected override float DefaultResidueTime
		{
			 get { } //Length: 4
		}

		protected override float DefaultWorkTime
		{
			 get { } //Length: 9
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

		protected static EffectsSettings EffectsSettings
		{
			 get { } //Length: 73
		}

		public override bool Existing
		{
			 get { } //Length: 29
		}

		public private bool ForceRemoved
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private ActiveHealthController HealthController
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
			 get { } //Length: 8
		}

		public private float ResidueStateTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override EEffectState State
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
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

		public int UpdateTime
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
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
		private void <UnPauseEffect>g__AddedState|118_0() { }

		[CompilerGenerated]
		private void <UnPauseEffect>g__StartedState|118_1() { }

		protected override void Added() { }

		protected void AddSideEffect(EBodyPart bodyPart, Nullable delayTime = null, Nullable workTime = null, Nullable residueTime = null, Nullable strength = null) { }

		public override void AddWholeTime(float deltaTime) { }

		public void AddWorkTime(Nullable time, bool reset) { }

		protected override void CalculateCurrentStrength(float deltaTime = 0) { }

		public static Effect Create(ActiveHealthController health, string effectType, EBodyPart bodyPart, EffectInfo restoreInfo) { }

		public static TEffect Create(ActiveHealthController health, EBodyPart bodyPart, Nullable delayTime, Nullable workTime, Nullable residueTime, Nullable strength, Nullable updateTime, Action initCallback) { }

		public override void ForceRemove() { }

		public override void ForceResidue() { }

		public override bool get_Active() { }

		[CompilerGenerated]
		public override EBodyPart get_BodyPart() { }

		[CompilerGenerated]
		public float get_BuildUpTime() { }

		public override bool get_Critical() { }

		[CompilerGenerated]
		public override float get_CurrentStrength() { }

		public override float get_CurStateTimeLeft() { }

		protected override float get_DefaultBuildUpTime() { }

		protected override float get_DefaultDelayTime() { }

		protected override float get_DefaultResidueTime() { }

		protected override float get_DefaultWorkTime() { }

		[CompilerGenerated]
		public float get_DelayTime() { }

		public override EffectDescription[] get_DisplayableVariations() { }

		protected static EffectsSettings get_EffectsSettings() { }

		public override bool get_Existing() { }

		[CompilerGenerated]
		public bool get_ForceRemoved() { }

		[CompilerGenerated]
		public ActiveHealthController get_HealthController() { }

		[CompilerGenerated]
		public int get_Id() { }

		public override float get_OverallDuration() { }

		public override bool get_Residual() { }

		[CompilerGenerated]
		public float get_ResidueStateTime() { }

		[CompilerGenerated]
		public override EEffectState get_State() { }

		[CompilerGenerated]
		protected float get_StateCurrentTime() { }

		public float get_StateTime() { }

		[CompilerGenerated]
		public override float get_Strength() { }

		public override float get_TimeLeft() { }

		[CompilerGenerated]
		public override Type get_Type() { }

		[CompilerGenerated]
		public int get_UpdateTime() { }

		[CompilerGenerated]
		public override bool get_WasPaused() { }

		[CompilerGenerated]
		public override float get_WholeTime() { }

		[CompilerGenerated]
		public override float get_WorkStateTime() { }

		protected override void Init(ActiveHealthController health, EBodyPart bodyPart, Nullable delayTime, Nullable workTime, Nullable residueTime, float strength, Nullable updateTime) { }

		public void ManualUpdate(float deltaTime) { }

		private void NextState() { }

		public void PauseEffect() { }

		public override void Propagate() { }

		protected override void RegularUpdate(float deltaTime) { }

		protected override void Removed() { }

		private void RemoveSideEffect() { }

		protected override void ResidualUpdate(float deltaTime) { }

		protected override void Residue() { }

		protected override void Restored() { }

		protected override void Serialize(BinaryWriter writer) { }

		public void SerializeState(BinaryWriter writer) { }

		[CompilerGenerated]
		private void set_BodyPart(EBodyPart value) { }

		[CompilerGenerated]
		private void set_BuildUpTime(float value) { }

		[CompilerGenerated]
		protected void set_CurrentStrength(float value) { }

		[CompilerGenerated]
		private void set_DelayTime(float value) { }

		[CompilerGenerated]
		private void set_ForceRemoved(bool value) { }

		[CompilerGenerated]
		private void set_HealthController(ActiveHealthController value) { }

		[CompilerGenerated]
		private void set_Id(int value) { }

		[CompilerGenerated]
		private void set_ResidueStateTime(float value) { }

		[CompilerGenerated]
		private void set_State(EEffectState value) { }

		[CompilerGenerated]
		private void set_StateCurrentTime(float value) { }

		[CompilerGenerated]
		private void set_Strength(float value) { }

		[CompilerGenerated]
		private void set_Type(Type value) { }

		[CompilerGenerated]
		protected void set_UpdateTime(int value) { }

		[CompilerGenerated]
		private void set_WasPaused(bool value) { }

		[CompilerGenerated]
		private void set_WholeTime(float value) { }

		[CompilerGenerated]
		private void set_WorkStateTime(float value) { }

		public void SetEffectInfo(int id, IHealthController hController, Type type, EBodyPart bodyPart, float strength, float currentStrength, float delayTime, float stateTime, float workStateTime, float buildUpTime, float residueStateTime, int updateTime, EEffectState state) { }

		protected override void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature) { }

		public override void SetResidueTime(float time) { }

		public override void SetStrength(float strength) { }

		protected override void Started() { }

		public override EffectInfo Store() { }

		public override void UnPauseEffect() { }

	}

	internal abstract class Effect`1 : Effect
	{
		protected TStore _store; //Field offset: 0x0

		protected Effect`1() { }

		public void NetworkSync(out TStore data) { }

	}

	internal sealed class Encumbered : Effect, IEncumbered, IHealthEffect, IEffectTriggersUIPanel
	{
		private readonly List _tips; //Field offset: 0x88
		private Action _unsub; //Field offset: 0x90
		private EffectDescription _effectDescription; //Field offset: 0x98

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

		public void UpdateDebuffs() { }

	}

	internal class Endurance : Effect, IEndurance, IHealthEffect
	{

		public override bool Absolute
		{
			 get { } //Length: 8
		}

		public Endurance() { }

		public override bool get_Absolute() { }

		public void Init(bool absolute) { }

		protected virtual void Residue() { }

		protected virtual void Serialize(BinaryWriter writer) { }

		protected virtual void Started() { }

	}

	internal class Exhaustion : Effect, IExhaustion, IHealthEffect, IRestorable
	{
		private float _lastDamage; //Field offset: 0x88
		private float _damageCurLoopTime; //Field offset: 0x8C

		private float Damage
		{
			private get { } //Length: 139
		}

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public Exhaustion() { }

		private float get_Damage() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class Existence : Effect, IExistence, IHealthEffect, IDesirable
	{
		private float _energyCurLoopTime; //Field offset: 0x88
		private float _energyLoopTime; //Field offset: 0x8C
		private float _hydrationCurLoopTime; //Field offset: 0x90
		private float _hydrationLoopTime; //Field offset: 0x94
		private bool _destroyedStomach; //Field offset: 0x98

		public Existence() { }

		private float GetEnergyDamage() { }

		private float GetHydrationDamage() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class Flash : Effect, IFlash, IHealthEffect
	{

		public Flash() { }

	}

	internal class Fracture : Effect, IFracture, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		protected FractureSettings FractureSettings
		{
			 get { } //Length: 82
		}

		public override int HealExperience
		{
			 get { } //Length: 90
		}

		public override float RemovePrice
		{
			 get { } //Length: 92
		}

		public Fracture() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected FractureSettings get_FractureSettings() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

		protected virtual void Started() { }

	}

	internal class FractureSuppressed : Effect, IFractureSuppressed, ISuppressedEffect
	{

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public FractureSuppressed() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

	}

	internal sealed class Frostbite : Effect, IFrostbite, IHealthEffect, IEffectTriggersUIPanel
	{

		public Frostbite() { }

	}

	internal class FullHealthRegenerationEffect : Effect, IFullHealthRegenerationEffect, IHealthEffect, IRestorable
	{

		public FullHealthRegenerationEffect() { }

		protected virtual void Started() { }

	}

	internal sealed class HalloweenBuff : Effect, IHalloweenBuff, IHealthEffect
	{

		public HalloweenBuff() { }

	}

	internal class HealthBoost : Effect, IHealthBoost, IHealthEffect
	{
		private float _healthRate; //Field offset: 0x88
		private float _loopTime; //Field offset: 0x8C
		private float _currentLoopTime; //Field offset: 0x90

		public HealthBoost() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class HeavyBleeding : Bleeding, IHeavyBleeding, IBleeding, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		protected virtual DamageInfo DamageInfo
		{
			 get { } //Length: 214
		}

		protected virtual BleedingSettings Settings
		{
			 get { } //Length: 82
		}

		public HeavyBleeding() { }

		protected virtual DamageInfo get_DamageInfo() { }

		protected virtual BleedingSettings get_Settings() { }

		protected virtual void Removed() { }

	}

	internal class HeavyBleedingSuppressed : Effect, IHeavyBleedingSuppressed, ISuppressedEffect
	{

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public HeavyBleedingSuppressed() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

	}

	internal sealed class ImmunityController
	{
		private static readonly Dictionary _suppressedTypeMap; //Field offset: 0x0
		private static readonly HashSet _residueImmediatelyTypes; //Field offset: 0x8
		private readonly ActiveHealthController _healthController; //Field offset: 0x10
		private HashSet _immunitySettings; //Field offset: 0x18
		private bool _sweepDone; //Field offset: 0x20

		private static ImmunityController() { }

		public ImmunityController(ActiveHealthController healthController) { }

		private void ApplyPolicy(Type effectType, Effect effect) { }

		private void EnsureImmunitySettingsLoaded() { }

		public bool HasDestroyLimbSpeedImmunity(EBodyPart bodyPart) { }

		private bool IsImmune(Type effectType) { }

		private bool IsImmune(string effectName) { }

		public void TryApplyImmunityPolicy(Effect effectInstance) { }

		public Type TryGetSuppressedType(Type effectType) { }

		public string TryMapToSuppressedByName(string effectName) { }

		public void TrySweepExistingOnce() { }

	}

	internal sealed class ImmunityPreventedNegativeEffect : Effect, IImmunityPreventedNegativeEffect, IHealthEffect, IEffectTriggersUIPanel
	{

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 9
		}

		protected virtual float DefaultWorkTime
		{
			 get { } //Length: 9
		}

		public ImmunityPreventedNegativeEffect() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual float get_DefaultWorkTime() { }

	}

	internal class Intoxication : Effect, IIntoxication, IRestorable, IPermanent, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{
		private float _healthDamage; //Field offset: 0x88
		private float _healthLoopTime; //Field offset: 0x8C
		private float _healthCurLoopTime; //Field offset: 0x90
		private float _totalHealthDamage; //Field offset: 0x94

		protected DamageInfo DamageInfo
		{
			 get { } //Length: 214
		}

		public static EBodyPart DefaultBodyPart
		{
			 get { } //Length: 6
		}

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultWorkTime
		{
			 get { } //Length: 9
		}

		public override int HealExperience
		{
			 get { } //Length: 90
		}

		public override float RemovePrice
		{
			 get { } //Length: 92
		}

		protected IntoxicationSettings Settings
		{
			 get { } //Length: 82
		}

		public Intoxication() { }

		private void BleedHealth() { }

		protected DamageInfo get_DamageInfo() { }

		public static EBodyPart get_DefaultBodyPart() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual float get_DefaultWorkTime() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

		protected IntoxicationSettings get_Settings() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void SetHealthRatesPerSecond(float health, float energy, float hydration, float temperature) { }

		protected virtual void Started() { }

	}

	internal sealed class LethalIntoxication : Effect, ILethalIntoxication, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect, IEffectTriggersUIPanel
	{

		public virtual bool Critical
		{
			 get { } //Length: 3
		}

		private DamageInfo DamageInfo
		{
			private get { } //Length: 214
		}

		public static EBodyPart DefaultBodyPart
		{
			 get { } //Length: 6
		}

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public override int HealExperience
		{
			 get { } //Length: 90
		}

		public override float RemovePrice
		{
			 get { } //Length: 92
		}

		private LethalIntoxicationSettings Settings
		{
			private get { } //Length: 82
		}

		public LethalIntoxication() { }

		public virtual bool get_Critical() { }

		private DamageInfo get_DamageInfo() { }

		public static EBodyPart get_DefaultBodyPart() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		public override int get_HealExperience() { }

		public override float get_RemovePrice() { }

		private LethalIntoxicationSettings get_Settings() { }

		protected virtual void Removed() { }

		protected virtual void Started() { }

	}

	internal class LightBleeding : Bleeding, ILightBleeding, IBleeding, IRestorable, IExperienceHealthEffect, IHealthEffect, IQuickHealHealthEffect
	{

		protected virtual DamageInfo DamageInfo
		{
			 get { } //Length: 214
		}

		protected virtual BleedingSettings Settings
		{
			 get { } //Length: 82
		}

		public LightBleeding() { }

		protected virtual DamageInfo get_DamageInfo() { }

		protected virtual BleedingSettings get_Settings() { }

	}

	internal class LightBleedingSuppressed : Effect, ILightBleedingSuppressed, ISuppressedEffect
	{

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public LightBleedingSuppressed() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

	}

	internal class LowEdgeHealth : Effect, ILowEdgeHealth, IHealthEffect
	{

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 92
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 92
		}

		public LowEdgeHealth() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class MedEffect : Effect, IMedEffect, IHealthEffect, IInitializable, IStackable, IDesirable
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			public DamageEffectSpecification damageEffect; //Field offset: 0x10
			public MedEffect <>4__this; //Field offset: 0x18

			public <>c__DisplayClass28_0() { }

			internal void <Residue>b__1(PainKiller x) { }

		}

		[CompilerGenerated]
		private Item <MedItem>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		private float <Amount>k__BackingField; //Field offset: 0xA0
		private HealthEffectsComponent _healthEffects; //Field offset: 0xA8
		private MedKitComponent _medKit; //Field offset: 0xB0
		private FoodDrinkComponent _foodDrink; //Field offset: 0xB8
		private float _healthPoints; //Field offset: 0xC0
		private float _energyPoints; //Field offset: 0xC4
		private float _hydrationPoints; //Field offset: 0xC8
		private float _curLoopTime; //Field offset: 0xCC
		private bool _interrupted; //Field offset: 0xD0
		private bool _wasInterrupted; //Field offset: 0xD1
		private bool _perkItemUseEffectsApplied; //Field offset: 0xD2
		private float _itemResourceUsageMultiplier; //Field offset: 0xD4

		public private override float Amount
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			private set { } //Length: 9
		}

		public private override Item MedItem
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public override bool NoMove
		{
			 get { } //Length: 340
		}

		public MedEffect() { }

		[CompilerGenerated]
		private void <Residue>b__28_0(Stimulator e) { }

		[CompilerGenerated]
		private bool <Restored>b__23_0(Item i) { }

		private void ActiveEventsHandler(ItemEventArgs eventArgs) { }

		protected virtual void Added() { }

		private void ApplyPerkItemUseEffectsOnce() { }

		public virtual void ForceRemove() { }

		public virtual void ForceResidue() { }

		[CompilerGenerated]
		public override float get_Amount() { }

		[CompilerGenerated]
		public override Item get_MedItem() { }

		public override bool get_NoMove() { }

		public void Init(Item item, float amount) { }

		private bool IsNoMove() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Residue() { }

		protected virtual void Restored() { }

		protected virtual void Serialize(BinaryWriter writer) { }

		[CompilerGenerated]
		private void set_Amount(float value) { }

		[CompilerGenerated]
		private void set_MedItem(Item value) { }

		protected virtual void Started() { }

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

		public virtual EffectInfo Store() { }

	}

	internal class OverEncumbered : Effect, IOverEncumbered, IHealthEffect, IEffectTriggersUIPanel
	{
		private readonly List _tips; //Field offset: 0x88
		private EffectDescription _effectDescription; //Field offset: 0x90

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 291
		}

		public OverEncumbered() { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		public EffectDescription[] GetDisplayVariations(IHealthEffect effect, bool exactTime) { }

		public override void UpdateDebuffs() { }

	}

	internal class Pain : Effect, IPain, IExperienceHealthEffect, IHealthEffect, IHiddenByAnotherEffectAllOverBody
	{
		private const float DEFAULT_FORCE_RESIDUE_TIME = 2; //Field offset: 0x0
		private Nullable _addTremorTime; //Field offset: 0x88

		protected virtual float DefaultBuildUpTime
		{
			 get { } //Length: 9
		}

		public static float DefaultResidue
		{
			 get { } //Length: 9
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 9
		}

		public override int HealExperience
		{
			 get { } //Length: 93
		}

		public override Type[] HiddenByTypes
		{
			 get { } //Length: 83
		}

		public Pain() { }

		public virtual void ForceResidue() { }

		protected virtual float get_DefaultBuildUpTime() { }

		public static float get_DefaultResidue() { }

		protected virtual float get_DefaultResidueTime() { }

		public override int get_HealExperience() { }

		public override Type[] get_HiddenByTypes() { }

		protected virtual void Init(ActiveHealthController health, EBodyPart bodyPart, Nullable delayTime, Nullable workTime, Nullable residueTime, float strength, Nullable updateTime) { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class PainKiller : Effect, IPainKiller, IHealthEffect, IStackableFromDifferentTemplates, IDesirable, IInitializable
	{
		[CompilerGenerated]
		private string <ItemTemplateId>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private float <MaxDuration>k__BackingField; //Field offset: 0x90

		public private override string ItemTemplateId
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public float MaxDuration
		{
			[CompilerGenerated]
			 get { } //Length: 9
			[CompilerGenerated]
			 set { } //Length: 9
		}

		public PainKiller() { }

		[CompilerGenerated]
		public override string get_ItemTemplateId() { }

		[CompilerGenerated]
		public float get_MaxDuration() { }

		[CompilerGenerated]
		private void set_ItemTemplateId(string value) { }

		[CompilerGenerated]
		public void set_MaxDuration(float value) { }

		public void StoreValues(string templateId, float duration) { }

		public override void UpdateWithSameOne(float strength) { }

	}

	internal class PainSuppressed : Effect, IPainSuppressed, ISuppressedEffect
	{

		protected virtual float DefaultBuildUpTime
		{
			 get { } //Length: 9
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 9
		}

		public PainSuppressed() { }

		protected virtual float get_DefaultBuildUpTime() { }

		protected virtual float get_DefaultResidueTime() { }

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
		private float _healthPerSecond; //Field offset: 0x88
		private float _energyPerSecond; //Field offset: 0x8C
		private float _hydrationPerSecond; //Field offset: 0x90

		public PerkTimedRatesEffect() { }

		public void Init(float healthPerSecond, float energyPerSecond, float hydrationPerSecond) { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class RadExposure : Effect, IRadExposure, IHealthEffect, IRestorable
	{
		private float _damageCurLoopTime; //Field offset: 0x88

		public RadExposure() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

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
		private const float LOOP_TIME_SECONDS = 3; //Field offset: 0x0
		private float _hpPerLoop; //Field offset: 0x88
		private float _currentLoopTime; //Field offset: 0x8C
		private IEnumerable _bodyParts; //Field offset: 0x90

		public ScavRegeneration() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	internal class SevereMusclePain : MusclePain, ISevereMusclePain, IMusclePain, IRestorable, IHealthEffect, IInsignificant
	{

		public SevereMusclePain() { }

	}

	internal sealed class StaminaZero : Effect, IStaminaZeroEffect, IHealthEffect, IInitializable
	{

		public StaminaZero() { }

		protected virtual void Started() { }

	}

	internal class Stimulator : Effect, IStimulator, IHealthEffect, IInitializable, IDesirable, IStackableFromDifferentTemplates
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Converter <>9__13_0; //Field offset: 0x8
			public static Func <>9__18_0; //Field offset: 0x10
			public static Func <>9__21_0; //Field offset: 0x18
			public static Func <>9__27_0; //Field offset: 0x20
			public static Func <>9__27_1; //Field offset: 0x28
			public static Func <>9__27_2; //Field offset: 0x30
			public static Func <>9__27_3; //Field offset: 0x38
			public static Func <>9__27_4; //Field offset: 0x40
			public static Func <>9__27_5; //Field offset: 0x48

			private static <>c() { }

			public <>c() { }

			internal Buff <get__buffs>b__13_0(IStimulatorBuff x) { }

			internal bool <RecalculateHealthRates>b__27_0(IStimulatorBuff b) { }

			internal float <RecalculateHealthRates>b__27_1(IStimulatorBuff b) { }

			internal bool <RecalculateHealthRates>b__27_2(IStimulatorBuff b) { }

			internal float <RecalculateHealthRates>b__27_3(IStimulatorBuff b) { }

			internal bool <RecalculateHealthRates>b__27_4(IStimulatorBuff b) { }

			internal float <RecalculateHealthRates>b__27_5(IStimulatorBuff b) { }

			internal bool <RegularUpdate>b__21_0(Buff b) { }

			internal bool <Serialize>b__18_0(IStimulatorBuff b) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass24_0
		{
			public Buff buff; //Field offset: 0x10
			public Stimulator <>4__this; //Field offset: 0x18
			public Func <>9__1; //Field offset: 0x20

			public <>c__DisplayClass24_0() { }

			internal bool <ActivateBuff>b__0(Skill s) { }

			internal bool <ActivateBuff>b__1(Effect effect) { }

		}

		private sealed class Buff : IStimulatorBuff, IStimulatorDebuff
		{
			[CompilerGenerated]
			private bool <Active>k__BackingField; //Field offset: 0x10
			public StimulatorBuffSettings OriginalSettings; //Field offset: 0x18
			[CompilerGenerated]
			private StimulatorBuffSettings <Settings>k__BackingField; //Field offset: 0x20
			[CompilerGenerated]
			private EBodyPart <BodyPart>k__BackingField; //Field offset: 0x28
			public bool Processed; //Field offset: 0x2C
			public object ValueObj; //Field offset: 0x30
			[CompilerGenerated]
			private float <WholeTime>k__BackingField; //Field offset: 0x38

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
				 get { } //Length: 244
			}

			public override float WholeTime
			{
				[CompilerGenerated]
				 get { } //Length: 6
				[CompilerGenerated]
				 set { } //Length: 6
			}

			public Buff() { }

			private float ClampDuration(float duration, bool isBuff, SkillManager skillManager) { }

			[CompilerGenerated]
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
			public void set_Active(bool value) { }

			[CompilerGenerated]
			public void set_BodyPart(EBodyPart value) { }

			[CompilerGenerated]
			public void set_Settings(StimulatorBuffSettings value) { }

			[CompilerGenerated]
			public override void set_WholeTime(float value) { }

			public virtual string ToString() { }

		}

		[CompilerGenerated]
		private IStimulatorBuff[] <ActiveBuffs>k__BackingField; //Field offset: 0xA0
		private float _curTime; //Field offset: 0xA8
		private float _curLoopTime; //Field offset: 0xAC

		private Buff[] _buffs
		{
			private get { } //Length: 355
		}

		public private override IStimulatorBuff[] ActiveBuffs
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public virtual EffectDescription[] DisplayableVariations
		{
			 get { } //Length: 7
		}

		public override string ItemTemplateId
		{
			 get { } //Length: 8
		}

		public string Name
		{
			 get { } //Length: 8
		}

		public Stimulator() { }

		private void ActivateBuff(Buff buff, bool activate) { }

		protected virtual void Added() { }

		public virtual void AddWholeTime(float deltaTime) { }

		private static float EvaluateValue(StimulatorBuffSettings buffSettings, float refValue, Nullable limits = null) { }

		private Buff[] get__buffs() { }

		[CompilerGenerated]
		public override IStimulatorBuff[] get_ActiveBuffs() { }

		public virtual EffectDescription[] get_DisplayableVariations() { }

		public override string get_ItemTemplateId() { }

		public string get_Name() { }

		private bool IsAppliedAccordingToSettings(Buff buff) { }

		private void ProcessBuff(IStimulatorBuff buff, float deltaTime) { }

		private void RecalculateHealthRates() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Removed() { }

		protected virtual void Residue() { }

		protected virtual void Serialize(BinaryWriter writer) { }

		[CompilerGenerated]
		private void set_ActiveBuffs(IStimulatorBuff[] value) { }

		protected virtual void Started() { }

		public void StoreValues(string buffsName, string templateId, EBodyPart appliedTo) { }

		public override void UpdateWithSameOne(float strength = 1) { }

	}

	internal class Stun : Effect, IStun, IHealthEffect
	{

		protected virtual float DefaultBuildUpTime
		{
			 get { } //Length: 9
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 9
		}

		public static float StunBuildUpTime
		{
			 get { } //Length: 9
		}

		public Stun() { }

		protected virtual void CalculateCurrentStrength(float deltaTime = 0) { }

		protected virtual float get_DefaultBuildUpTime() { }

		protected virtual float get_DefaultResidueTime() { }

		public static float get_StunBuildUpTime() { }

	}

	internal abstract class TearGas : Effect, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{
		private bool _buffsApplied; //Field offset: 0x88

		protected virtual float DefaultWorkTime
		{
			 get { } //Length: 103
		}

		protected abstract TearGasSettings Settings
		{
			 get { } //Length: 0
		}

		protected TearGas() { }

		protected virtual float get_DefaultWorkTime() { }

		protected abstract TearGasSettings get_Settings() { }

		protected virtual void Removed() { }

		protected virtual void Started() { }

		public override void TryApplyBuffs() { }

	}

	internal class TearGasStrong : TearGas, ITearGasStrong, ITearGas, IHealthEffect, IEffectTriggersUIPanel
	{
		private float _tickTimer; //Field offset: 0x90
		private float _lastCoughTime; //Field offset: 0x94

		protected virtual TearGasSettings Settings
		{
			 get { } //Length: 85
		}

		public TearGasStrong() { }

		protected virtual TearGasSettings get_Settings() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

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

		protected virtual float DefaultDelayTime
		{
			 get { } //Length: 95
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 95
		}

		public Tremor() { }

		protected virtual float get_DefaultDelayTime() { }

		protected virtual float get_DefaultResidueTime() { }

	}

	internal class TunnelVision : Effect, ITunnelVision, IHealthEffect
	{

		protected virtual float DefaultBuildUpTime
		{
			 get { } //Length: 9
		}

		protected virtual float DefaultResidueTime
		{
			 get { } //Length: 9
		}

		public TunnelVision() { }

		protected virtual float get_DefaultBuildUpTime() { }

		protected virtual float get_DefaultResidueTime() { }

	}

	internal class Wound : Effect, IWound, IHealthEffect
	{
		private float _bleedingThreshold; //Field offset: 0x88
		private float _currentBuildUp; //Field offset: 0x8C

		protected virtual float DefaultWorkTime
		{
			 get { } //Length: 311
		}

		public Wound() { }

		protected virtual void Added() { }

		public void BuildUp(float value) { }

		protected virtual float get_DefaultWorkTime() { }

		private void ResetRelapseProgress() { }

	}

	internal class ZombieInfection : Effect, IZombieInfection, IHealthEffect
	{
		public const string BUFF_NAME = "BuffsZombieInfection"; //Field offset: 0x0
		private const float LOOP_TIME = 3; //Field offset: 0x0
		private float _curLoopTime; //Field offset: 0x88
		private float _hydrationDamage; //Field offset: 0x8C

		public ZombieInfection() { }

		protected virtual void RegularUpdate(float deltaTime) { }

		protected virtual void Started() { }

	}

	public const float HEAL_SPEEDUP_MULTIPLIER = 0.2; //Field offset: 0x0
	public const int SMALL_HP_DELTA = 10; //Field offset: 0x0
	public static readonly Type[] PAIN_HIDDEN_BY; //Field offset: 0x0
	private static readonly DamageInfo _tearGasDamageInfo; //Field offset: 0x8
	protected readonly Player Player; //Field offset: 0xD8
	private readonly ImmunityController _immunity; //Field offset: 0xE0
	[CompilerGenerated]
	private Action EffectStartedEvent; //Field offset: 0xE8
	[CompilerGenerated]
	private Action EffectUpdatedEvent; //Field offset: 0xF0
	[CompilerGenerated]
	private Action EffectResidualEvent; //Field offset: 0xF8
	[CompilerGenerated]
	private Action EffectRemovedEvent; //Field offset: 0x100
	[CompilerGenerated]
	private Action EffectAddedEvent; //Field offset: 0x108
	[CompilerGenerated]
	private Action EffectStatusUpdateEvent; //Field offset: 0x110
	[CompilerGenerated]
	private Action ApplyDamageEvent; //Field offset: 0x118
	[CompilerGenerated]
	private Action HealthChangedEvent; //Field offset: 0x120
	[CompilerGenerated]
	private Action EnergyChangedEvent; //Field offset: 0x128
	[CompilerGenerated]
	private Action HydrationChangedEvent; //Field offset: 0x130
	[CompilerGenerated]
	private Action TemperatureChangedEvent; //Field offset: 0x138
	[CompilerGenerated]
	private Action PoisonChangedEvent; //Field offset: 0x140
	[CompilerGenerated]
	private Action BodyPartDestroyedEvent; //Field offset: 0x148
	[CompilerGenerated]
	private Action BodyPartRestoredEvent; //Field offset: 0x150
	[CompilerGenerated]
	private Action HealerDoneEvent; //Field offset: 0x158
	[CompilerGenerated]
	private Action DiedEvent; //Field offset: 0x160
	[CompilerGenerated]
	private Action BurnEyesEvent; //Field offset: 0x168
	[CompilerGenerated]
	private Action OnApplyDamageByPlayer; //Field offset: 0x170
	private Effect _encumberedEffect; //Field offset: 0x178
	private Effect _overEncumberedEffect; //Field offset: 0x180
	private float _fallSafeHeight; //Field offset: 0x188
	private int _effectIdCounter; //Field offset: 0x18C

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

	public event Action OnApplyDamageByPlayer
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

	protected override bool _sendNetworkSyncPackets
	{
		 get { } //Length: 3
	}

	public float EffectiveEnergyRate
	{
		 get { } //Length: 164
	}

	public float EffectiveHydrationRate
	{
		 get { } //Length: 164
	}

	protected float EnergyDrainMultiplier
	{
		 get { } //Length: 208
	}

	public virtual float FallSafeHeight
	{
		 set { } //Length: 9
	}

	protected float HydrationDrainMultiplier
	{
		 get { } //Length: 208
	}

	private static ActiveHealthController() { }

	protected ActiveHealthController(Player player, HealthInfo profileHealth, InventoryController inventory, SkillManager skills) { }

	public virtual string[] ActiveBuffsNames() { }

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
	public void add_OnApplyDamageByPlayer(Action value) { }

	[CompilerGenerated]
	public virtual void add_PoisonChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void add_TemperatureChangedEvent(Action value) { }

	private void AddDamageMultiplier(float value) { }

	protected TEffect AddEffect(EBodyPart bodyPart, Nullable delayTime = null, Nullable workTime = null, Nullable residueTime = null, Nullable strength = null, Action initCallback = null) { }

	public virtual void AddFatigue() { }

	public virtual void AddImmunityNotificationEffect() { }

	public void AddMisfireEffect(Nullable workTime = null, bool reapply = true) { }

	private TEffect AddOrRefreshPerkEffect(EBodyPart bodyPart, float duration, Nullable strength = null, Action initCallback = null) { }

	private TEffect AddStackableEffect(EBodyPart bodyPart, Item effectSourceItem, Nullable strength = null, Nullable delay = null, Nullable duration = null, Nullable residueTime = null, Action initCallback = null) { }

	public void AddStaminaZeroffect(Nullable workTime = null) { }

	private bool ApplyAllergySubEffect(SeasonalPerkSubEffect subEffect) { }

	public float ApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void ApplyDistributedHealthRate(float healthPerSecond, float deltaTime, DamageInfo damageInfo, EDamageType destroyDamageType) { }

	private static float ApplyDrainMultiplier(float rate, float multiplier) { }

	private bool ApplyPerkItemUseEffect(AllergyPerkEffect effect) { }

	public void ApplyPerkItemUseEffects(Item item) { }

	private bool ApplyPerkPain(float duration) { }

	private bool ApplyPerkPainkiller(float duration) { }

	private bool ApplyPerkTimedRates(float healthPerSecond, float energyPerSecond, float hydrationPerSecond, float duration) { }

	private bool ApplyPerkTremor(float duration) { }

	private bool ApplyPerkTunnelVision(float duration) { }

	private void ApplyTimedRatesTick(float healthPerSecond, float energyPerSecond, float hydrationPerSecond, float deltaTime, DamageInfo damageInfo, EDamageType destroyDamageType) { }

	public void BluntContusion(EBodyPart bodyPartType, float absorbed) { }

	public void ChangeEnergy(float value) { }

	public override void ChangeHealth(EBodyPart bodyPart, float value, DamageInfo damageInfo) { }

	public void ChangeHydration(float value) { }

	private void ChangePoison(float value) { }

	private void ChangeTemperature(float value) { }

	public void DestroyBodyPart(EBodyPart bodyPart, EDamageType damageType) { }

	public void DoBleed(bool isHeavy, EBodyPart bodyPart) { }

	protected void DoBleed(EBodyPart bodyPart) { }

	public void DoBurnEyes(Vector3 position, float distanceStrength, float normalTime, float maxTime) { }

	public void DoContusion(float applyTime, float strength) { }

	public void DoDisorientation(float applyTime) { }

	public void DoEventEffect() { }

	public void DoExternalBuff(string buffName, float delay = 0) { }

	public void DoFracture(EBodyPart bodyPart) { }

	public Effect DoIntoxication() { }

	public Effect DoLethalIntoxication(float delay, float duration) { }

	public IHealthEffect DoMedEffect(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public void DoPain(EBodyPart bodyPart, float delayTime, float workTime, float residueTime, Nullable strength = null) { }

	public void DoPainKiller() { }

	public void DoPermanentHealthBoost(float bodyPartHpPerSecond) { }

	public void DoRadExposure() { }

	public void DoSandingScreen(float applyTime) { }

	public void DoScavRegeneration(float regenerationPerMin) { }

	public void DoShootOnArmor(float damage) { }

	public void DoStopBleedingEffect() { }

	public void DoStun(float maxTime, float normalizedStrength) { }

	public void DoWoundRelapse(float relapseValue, EBodyPart bodyPart) { }

	public void DoZombieInfection(EBodyPart bodyPart) { }

	protected bool FullRestoreBodyPart(EBodyPart bodyPart) { }

	protected override bool get__sendNetworkSyncPackets() { }

	public float get_EffectiveEnergyRate() { }

	public float get_EffectiveHydrationRate() { }

	protected float get_EnergyDrainMultiplier() { }

	protected float get_HydrationDrainMultiplier() { }

	public override float HandleFall(float height) { }

	private bool HasBloodLossBlockers() { }

	public bool HasDestroyLimbSpeedImmunity(EBodyPart bodyPart) { }

	private bool HasStimulatorBuff(EStimulatorBuffType buffType) { }

	public void Heal(EBodyPart bodyPart, float value) { }

	private bool IsBlockedByInventory(TearGasBlockingItem[] templateIds) { }

	protected override bool IsBodyPartCanBeDamaged(EBodyPart bodyPart, BodyPartState partState) { }

	public override void Kill(EDamageType damageType) { }

	protected virtual void ManualEffectUpdate(Effect effect, float deltaTime) { }

	public virtual void ManualUpdate(float deltaTime) { }

	private void NetworkSyncAddEffect(Effect effect) { }

	private void NetworkSyncApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void NetworkSyncBodyHealth(EBodyPart bodyPart) { }

	private void NetworkSyncBurnEyes(Vector3 position, float distanceStrength, float normalTime) { }

	private void NetworkSyncDamageCoeff() { }

	private void NetworkSyncDestroyedBodyPart(EBodyPart bodyPart, EDamageType damageType) { }

	private void NetworkSyncEffectMedResource(Effect effect, float resource) { }

	private void NetworkSyncEffectNextState(Effect effect) { }

	private void NetworkSyncEffectStateTime(Effect effect) { }

	private void NetworkSyncEffectStimulatorBuff(Effect effect, int buffIndex, bool buffActivate, float buffValue, float buffDuration, float buffDelay) { }

	private void NetworkSyncEffectStrength(Effect effect) { }

	private void NetworkSyncEnergy() { }

	private void NetworkSyncHealerDone(Effect effect) { }

	private void NetworkSyncHealthRates() { }

	private void NetworkSyncHydration() { }

	private void NetworkSyncIsAlive(EDamageType damageType) { }

	private void NetworkSyncPoison() { }

	private void NetworkSyncRemoveEffect(Effect effect) { }

	private void NetworkSyncStaminaCoeff() { }

	private void NetworkSyncTemperature() { }

	public void PauseAllEffects() { }

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
	public void remove_OnApplyDamageByPlayer(Action value) { }

	[CompilerGenerated]
	public virtual void remove_PoisonChangedEvent(Action value) { }

	[CompilerGenerated]
	public virtual void remove_TemperatureChangedEvent(Action value) { }

	private void RemoveBleedingEffects(EBodyPart bodyPart) { }

	private TEffect RemoveEffect(EBodyPart bodyPart) { }

	private void RemoveIntoxication() { }

	public void RemoveMedEffect() { }

	public void RemoveMisfireEffect() { }

	public void RemoveNegativeEffects(EBodyPart bodyPart) { }

	private TEffect ResidueEffect(EBodyPart bodyPart) { }

	private void ResidueEffectsWhere(EBodyPart bodyPart, Func predicate) { }

	public bool RestoreBodyPart(EBodyPart bodyPart, float healthPenalty) { }

	public void RestoreFullHealth() { }

	protected override void SendNetworkSyncPacket(SyncHealthPacket packet) { }

	public byte[] SerializeState() { }

	public virtual void set_FallSafeHeight(float value) { }

	public void SetDamageCoeff(float value) { }

	public virtual void SetEncumbered(bool encumbered) { }

	public virtual void SetOverEncumbered(bool encumbered) { }

	public void SetStaminaCoeff(float value) { }

	protected void SpreadOverDamage(float overDamage, EBodyPart bodyPart, DamageInfo damageInfo) { }

	public virtual HealthInfo Store(HealthInfo health = null) { }

	public HealthInfo Store(TransitGlobalSettings transitSettings, HealthInfo health = null) { }

	public bool TryAddTearGasStrong(EBodyPart bodyPart) { }

	public bool TryAddTearGasWeak(EBodyPart bodyPart) { }

	private void TryAddZombieInfection(EDamageType damageType, DamageInfo damageInfo, EBodyPart bodyPart) { }

	public bool TryApplySideEffects(DamageInfo damage, EBodyPart bodyPart, out SideEffectComponent sideEffectComponent) { }

	protected void TryApplyStartupBuff() { }

	public void TryDoExternalBuff(string buffName) { }

	private void TryToKillAfterDestroyPart(EBodyPart bodyPart, EDamageType damageType) { }

	public void UpdateAITearGasImmunity() { }

}

