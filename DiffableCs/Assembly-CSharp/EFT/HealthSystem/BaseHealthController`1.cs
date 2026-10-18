namespace EFT.HealthSystem;

public abstract class BaseHealthController`1 : IHealthController, IBaseHealthController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__186_0; //Field offset: 0x0
		public static Func <>9__194_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EffectInfoStorage <.ctor>b__194_0() { }

		internal bool <GetBodyPartToApply>b__186_0(BodyPartHealHelper bodyPartHelper) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass151_0
	{
		public EBodyPart bodyPart; //Field offset: 0x0

		public <>c__DisplayClass151_0() { }

		internal bool <IsBodyPartBroken>b__0(TEffectType e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass159_0`1
	{
		public EBodyPart bodyPart; //Field offset: 0x0

		public <>c__DisplayClass159_0`1() { }

		internal bool <FindExistingEffects>b__0(TEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass161_0`1
	{
		public EBodyPart bodyPart; //Field offset: 0x0

		public <>c__DisplayClass161_0`1() { }

		internal bool <FindActiveEffects>b__0(TEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass162_0
	{
		public EBodyPart bodyPart; //Field offset: 0x0

		public <>c__DisplayClass162_0() { }

		internal bool <GetAllActiveEffects>b__0(IHealthEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass163_0
	{
		public EBodyPart bodyPart; //Field offset: 0x0

		public <>c__DisplayClass163_0() { }

		internal bool <GetAllEffects>b__0(IHealthEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass165_0
	{
		public EBodyPart bodyPart; //Field offset: 0x0

		public <>c__DisplayClass165_0() { }

		internal bool <GetAllResidualEffects>b__0(IHealthEffect e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass185_0
	{
		public HealthEffectsComponent healthEffects; //Field offset: 0x0
		public MedKitComponent medKit; //Field offset: 0x0
		public float itemResourceUsageMultiplier; //Field offset: 0x0

		public <>c__DisplayClass185_0() { }

		internal bool <CanApplyToBodyPart>b__0(BodyPartHealHelper partHelper) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass188_0
	{
		public EBodyPart[] priorityOrder; //Field offset: 0x0
		public int defaultPriority; //Field offset: 0x0

		public <>c__DisplayClass188_0() { }

		internal int <PrioritizeBodyParts>b__0(BodyPartHealHelper originObject) { }

	}

	[CompilerGenerated]
	private sealed class <BodyPartsPriority>d__187 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private EBodyPart <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public BaseHealthController <>4__this; //Field offset: 0x0
		private HealthEffectsComponent healthEffects; //Field offset: 0x0
		public HealthEffectsComponent <>3__healthEffects; //Field offset: 0x0
		private MedKitComponent medKit; //Field offset: 0x0
		public MedKitComponent <>3__medKit; //Field offset: 0x0
		private float itemResourceUsageMultiplier; //Field offset: 0x0
		public float <>3__itemResourceUsageMultiplier; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override EBodyPart System.Collections.Generic.IEnumerator<EBodyPart>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <BodyPartsPriority>d__187(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EBodyPart>.GetEnumerator() { }

		[DebuggerHidden]
		private override EBodyPart System.Collections.Generic.IEnumerator<EBodyPart>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class BodyPartHealHelper : IComparable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__15_0; //Field offset: 0x0
			public static Func <>9__15_1; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal EDamageEffectType <.ctor>b__15_0(EDamageEffectType effectType) { }

			internal DamageEffectSpecification <.ctor>b__15_1(EDamageEffectType _) { }

		}

		[CompilerGenerated]
		private struct <>c__DisplayClass19_0
		{
			public HealthEffectsComponent healthEffects; //Field offset: 0x0
			public MedKitComponent medKit; //Field offset: 0x0
			public float itemResourceUsageMultiplier; //Field offset: 0x0

		}

		[CompilerGenerated]
		private struct <>c__DisplayClass21_0
		{
			public HealthEffectsComponent healthEffects; //Field offset: 0x0
			public BodyPartHealHelper <>4__this; //Field offset: 0x0

		}

		private const float EQUALITY_TOLERANCE = 0.05; //Field offset: 0x0
		private bool _hasHeavyBleeding; //Field offset: 0x0
		private bool _hasLightBleeding; //Field offset: 0x0
		private bool _hasFracture; //Field offset: 0x0
		public readonly EBodyPart BodyPart; //Field offset: 0x0
		private readonly BodyPartState _bodyState; //Field offset: 0x0
		private readonly List _effects; //Field offset: 0x0
		private readonly List _effectsToHeal; //Field offset: 0x0
		private readonly Dictionary _specsCache; //Field offset: 0x0
		[CompilerGenerated]
		private bool <CanBeHealed>k__BackingField; //Field offset: 0x0

		public private bool CanBeHealed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		private bool HasEffectsToHeal
		{
			private get { } //Length: 63
		}

		public BodyPartHealHelper(EBodyPart bodyPart, BodyPartState bodyState) { }

		[CompilerGenerated]
		internal static bool <CanApply>g__CanHealEffect|19_0(EDamageEffectType effectType, ref <>c__DisplayClass19_0 unnamed_param_1) { }

		[CompilerGenerated]
		private void <UpdateCache>g__TryCacheEffect|21_0(EDamageEffectType effectType, ref <>c__DisplayClass21_0 unnamed_param_1) { }

		public void AddEffect(TEffectType effect) { }

		public bool CanApply(HealthEffectsComponent healthEffects, MedKitComponent medKit, float itemResourceUsageMultiplier) { }

		public override int CompareTo(BodyPartHealHelper another) { }

		[CompilerGenerated]
		public bool get_CanBeHealed() { }

		private bool get_HasEffectsToHeal() { }

		private int GetHealPriorityTier() { }

		public void RemoveEffect(TEffectType effect) { }

		public void ResetCache() { }

		[CompilerGenerated]
		private void set_CanBeHealed(bool value) { }

		public void UpdateCache(HealthEffectsComponent healthEffects, MedKitComponent medKit, float itemResourceUsageMultiplier) { }

	}

	internal sealed class BodyPartState
	{
		public bool IsDestroyed; //Field offset: 0x0
		public HealthValue Health; //Field offset: 0x0

		public BodyPartState() { }

	}

	internal class HealControllerLogger : AbstractLogger
	{

		public HealControllerLogger() { }

		public void LogActivateBuff(IStimulatorBuff buff) { }

		public void LogAddEffectToEffectsCollection(IHealthEffect effect) { }

		public void LogEffectAdded(IHealthEffect effect) { }

		public void LogRemoveEffectFromEffectsCollection(IHealthEffect effect) { }

	}

	private const string INCOMPATIBLE_ITEM_KEY = "Inventory/IncompatibleItem"; //Field offset: 0x0
	private readonly List _bodyPartHelpers; //Field offset: 0x0
	private readonly Dictionary _bodyPartEffects; //Field offset: 0x0
	private readonly Dictionary _bodyPartHelpersIndex; //Field offset: 0x0
	private readonly Dictionary _bodyState; //Field offset: 0x0
	protected bool CanHealTroughTearGas; //Field offset: 0x0
	protected bool ImmuneToTearGas; //Field offset: 0x0
	protected float DamageRate; //Field offset: 0x0
	protected float HealRate; //Field offset: 0x0
	protected SkillManager _skills; //Field offset: 0x0
	protected InventoryController _inventory; //Field offset: 0x0
	protected HealthValue _poison; //Field offset: 0x0
	protected HealthValue _temperature; //Field offset: 0x0
	protected HealthValue _hydration; //Field offset: 0x0
	protected HealthValue _energy; //Field offset: 0x0
	protected readonly HealControllerLogger _logger; //Field offset: 0x0
	[CompilerGenerated]
	private float <CarryingWeightRelativeModifier>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <CarryingWeightAbsoluteModifier>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action StimulatorBuffEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action StimulatorBuffActivationEvent; //Field offset: 0x0
	[CompilerGenerated]
	private float <FallSafeHeight>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsAlive>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <MetabolismDisabled>k__BackingField; //Field offset: 0x0
	private float _energyRate; //Field offset: 0x0
	protected readonly List _effects; //Field offset: 0x0
	private float _hydrationRate; //Field offset: 0x0
	[CompilerGenerated]
	private float <DamageCoeff>k__BackingField; //Field offset: 0x0
	private float _staminaCoeff; //Field offset: 0x0
	[CompilerGenerated]
	private float <DamageMultiplier>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <UpdateTime>k__BackingField; //Field offset: 0x0
	protected Action _unpauseEffectsAction; //Field offset: 0x0
	protected ObjectPool _effectsInfoPool; //Field offset: 0x0
	[CompilerGenerated]
	private float <TemperatureRate>k__BackingField; //Field offset: 0x0
	private readonly List _manualUpdateEffects; //Field offset: 0x0

	public abstract event Action ApplyDamageEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action BodyPartDestroyedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action BodyPartRestoredEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action BurnEyesEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action DiedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EffectAddedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EffectRemovedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EffectResidualEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EffectStartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EffectStatusUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EffectUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action EnergyChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action HealerDoneEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action HealthChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action HydrationChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action PoisonChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public override event Action StimulatorBuffActivationEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action StimulatorBuffEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public abstract event Action TemperatureChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	protected static HealthSettings _settings
	{
		 get { } //Length: 64
	}

	public override HealthEffects BodyPartEffects
	{
		 get { } //Length: 1528
	}

	protected Dictionary BodyState
	{
		 get { } //Length: 8
	}

	public private override float CarryingWeightAbsoluteModifier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private override float CarryingWeightRelativeModifier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public override float DamageCoeff
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float DamageMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected IReadOnlyList Effects
	{
		 get { } //Length: 8
	}

	public override ValueStruct Energy
	{
		 get { } //Length: 39
	}

	public override float EnergyRate
	{
		 get { } //Length: 16
		 set { } //Length: 6
	}

	public override float FallSafeHeight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float HealthRate
	{
		 get { } //Length: 22
	}

	public override ValueStruct Hydration
	{
		 get { } //Length: 39
	}

	public override float HydrationRate
	{
		 get { } //Length: 16
		 set { } //Length: 6
	}

	public override bool IsAlive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected private bool MetabolismDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override ValueStruct Poison
	{
		 get { } //Length: 42
	}

	public override float StaminaCoeff
	{
		 get { } //Length: 9
		 set { } //Length: 6
	}

	public override ValueStruct Temperature
	{
		 get { } //Length: 39
	}

	public override float TemperatureRate
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override int UpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected BaseHealthController`1() { }

	[CompilerGenerated]
	private float <ChangeHealthRate>g__GetRate|148_0(float value) { }

	[CompilerGenerated]
	internal static bool <TryGetBodyPartToApply>g__BodyPartToResult|184_0(Nullable part, out Nullable result) { }

	public override string[] ActiveBuffsNames() { }

	[CompilerGenerated]
	public abstract void add_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_DiedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_PoisonChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_StimulatorBuffActivationEvent(Action value) { }

	[CompilerGenerated]
	public override void add_StimulatorBuffEvent(Action value) { }

	[CompilerGenerated]
	public abstract void add_TemperatureChangedEvent(Action value) { }

	protected void AddBodyState(EBodyPart bodyPart, BodyPartState bodyState) { }

	protected void AddEffectForBodyPart(TEffectType effect) { }

	protected override void AddEffectToList(TEffectType effect) { }

	public override void AddFatigue() { }

	public override void AddImmunityNotificationEffect() { }

	public abstract bool ApplyItem(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public abstract bool ApplyItem(Item item, OneAndList bodyPart, Nullable amount = null) { }

	public override OneAndList BodyPartsPriority(Item item, bool continuousHealEnabled) { }

	[IteratorStateMachine(typeof(<BodyPartsPriority>d__187))]
	private IEnumerable BodyPartsPriority(HealthEffectsComponent healthEffects, MedKitComponent medKit, float itemResourceUsageMultiplier) { }

	public override bool CanApplyItem(Item item, EBodyPart bodyPart) { }

	private bool CanApplyToBodyPart(HealthEffectsComponent healthEffects, MedKitComponent medKit, EBodyPart bodyPart, float itemResourceUsageMultiplier) { }

	public abstract void CancelApplyingItem() { }

	protected void ChangeHealthRate(float oldDelta, float newDelta) { }

	public override void DisableMetabolism() { }

	public override TEffect FindActiveEffect(EBodyPart bodyPart = 7) { }

	public override IEnumerable FindActiveEffects(EBodyPart bodyPart = 7) { }

	public override TEffect FindExistingEffect(EBodyPart bodyPart = 7) { }

	protected IEnumerable FindExistingEffects(EBodyPart bodyPart = 7) { }

	protected static HealthSettings get__settings() { }

	public override HealthEffects get_BodyPartEffects() { }

	protected Dictionary get_BodyState() { }

	[CompilerGenerated]
	public override float get_CarryingWeightAbsoluteModifier() { }

	[CompilerGenerated]
	public override float get_CarryingWeightRelativeModifier() { }

	[CompilerGenerated]
	public override float get_DamageCoeff() { }

	[CompilerGenerated]
	public float get_DamageMultiplier() { }

	protected IReadOnlyList get_Effects() { }

	public override ValueStruct get_Energy() { }

	public override float get_EnergyRate() { }

	[CompilerGenerated]
	public override float get_FallSafeHeight() { }

	public override float get_HealthRate() { }

	public override ValueStruct get_Hydration() { }

	public override float get_HydrationRate() { }

	[CompilerGenerated]
	public override bool get_IsAlive() { }

	[CompilerGenerated]
	protected bool get_MetabolismDisabled() { }

	public override ValueStruct get_Poison() { }

	public override float get_StaminaCoeff() { }

	public override ValueStruct get_Temperature() { }

	[CompilerGenerated]
	public override float get_TemperatureRate() { }

	[CompilerGenerated]
	public override int get_UpdateTime() { }

	public override IEnumerable GetAllActiveEffects(EBodyPart bodyPart = 7) { }

	public override IEnumerable GetAllEffects(EBodyPart bodyPart = 7) { }

	public IEnumerable GetAllEffects() { }

	public override IEnumerable GetAllResidualEffects(EBodyPart bodyPart = 7) { }

	public override ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false) { }

	public override void GetBodyPartsInCriticalCondition(float threshold, out int all, out int vital) { }

	private Nullable GetBodyPartToApply(HealthEffectsComponent healthEffects, MedKitComponent medKit, EBodyPart bodyPart, float itemResourceUsageMultiplier) { }

	protected float GetItemResourceUsageMultiplier(Item item) { }

	public override IResult HasPartsToApply(Item item) { }

	public override bool IsBodyPartBroken(EBodyPart bodyPart) { }

	public override bool IsBodyPartDestroyed(EBodyPart bodyPart) { }

	public override bool IsItemForHealing(Item item) { }

	protected abstract void ManualEffectUpdate(TEffectType effect, float deltaTime) { }

	public override void ManualUpdate(float deltaTime) { }

	private IEnumerable PrioritizeBodyParts(IEnumerable originList, EBodyPart[] priorityOrder) { }

	public override void PropagateAllEffects() { }

	private IResult ReadyToApplyItem(Item item) { }

	[CompilerGenerated]
	public abstract void remove_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_DiedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_PoisonChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_StimulatorBuffActivationEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_StimulatorBuffEvent(Action value) { }

	[CompilerGenerated]
	public abstract void remove_TemperatureChangedEvent(Action value) { }

	protected void RemoveEffectFromBodyPart(TEffectType effect) { }

	protected override bool RemoveEffectFromList(TEffectType effect) { }

	protected float ResolveFoodDrinkUseAmount(Item item, FoodDrinkComponent foodDrink, Nullable amount) { }

	[CompilerGenerated]
	private void set_CarryingWeightAbsoluteModifier(float value) { }

	[CompilerGenerated]
	private void set_CarryingWeightRelativeModifier(float value) { }

	[CompilerGenerated]
	protected void set_DamageCoeff(float value) { }

	[CompilerGenerated]
	protected void set_DamageMultiplier(float value) { }

	protected void set_EnergyRate(float value) { }

	[CompilerGenerated]
	public override void set_FallSafeHeight(float value) { }

	protected void set_HydrationRate(float value) { }

	[CompilerGenerated]
	protected void set_IsAlive(bool value) { }

	[CompilerGenerated]
	private void set_MetabolismDisabled(bool value) { }

	protected override void set_StaminaCoeff(float value) { }

	[CompilerGenerated]
	protected void set_TemperatureRate(float value) { }

	[CompilerGenerated]
	protected void set_UpdateTime(int value) { }

	public override void SetEncumbered(bool encumbered) { }

	public override void SetOverEncumbered(bool encumbered) { }

	protected void StimulatorBuffEventCall(IStimulatorBuff buff, bool isUpdateCall = true) { }

	public override HealthInfo Store(HealthInfo health = null) { }

	protected override bool TryGetBodyPartToApply(Item item, EBodyPart bodyPart, out Nullable damagedBodyPart) { }

	private bool TryGetBodyPartToApply(Item item, EBodyPart bodyPart, bool fastSearch, out Nullable damagedBodyPart) { }

	public override bool TryTriggerTearGasCoughIfNeeded(Item item) { }

	public void UnpauseAllEffects() { }

	protected void UpdateWeightModifier() { }

}

