namespace EFT.HealthSystem;

public interface IHealthController : IBaseHealthController
{

	public event Action ApplyDamageEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action BodyPartDestroyedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action BodyPartRestoredEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action BurnEyesEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action DiedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EffectAddedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EffectRemovedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EffectResidualEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EffectStartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EffectStatusUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EffectUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action EnergyChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action HealerDoneEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action HealthChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action HydrationChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action StimulatorBuffActivationEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action StimulatorBuffEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action TemperatureChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public HealthEffects BodyPartEffects
	{
		 get { } //Length: 0
	}

	public float CarryingWeightAbsoluteModifier
	{
		 get { } //Length: 0
	}

	public float CarryingWeightRelativeModifier
	{
		 get { } //Length: 0
	}

	public float DamageCoeff
	{
		 get { } //Length: 0
	}

	public float EnergyRate
	{
		 get { } //Length: 0
	}

	public float FallSafeHeight
	{
		 set { } //Length: 0
	}

	public float HealthRate
	{
		 get { } //Length: 0
	}

	public float HydrationRate
	{
		 get { } //Length: 0
	}

	public bool IsAlive
	{
		 get { } //Length: 0
	}

	public float StaminaCoeff
	{
		 get { } //Length: 0
	}

	public float TemperatureRate
	{
		 get { } //Length: 0
	}

	public int UpdateTime
	{
		 get { } //Length: 0
	}

	public string[] ActiveBuffsNames() { }

	[CompilerGenerated]
	public void add_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public void add_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public void add_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public void add_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public void add_DiedEvent(Action value) { }

	[CompilerGenerated]
	public void add_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public void add_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public void add_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public void add_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public void add_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public void add_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public void add_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public void add_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_StimulatorBuffActivationEvent(Action value) { }

	[CompilerGenerated]
	public void add_StimulatorBuffEvent(Action value) { }

	[CompilerGenerated]
	public void add_TemperatureChangedEvent(Action value) { }

	public void AddFatigue() { }

	public void AddImmunityNotificationEffect() { }

	public bool ApplyItem(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public bool ApplyItem(Item item, OneAndList bodyPart, Nullable amount = null) { }

	public OneAndList BodyPartsPriority(Item item, bool continuousHealEnabled) { }

	public bool CanApplyItem(Item item, EBodyPart bodyPart) { }

	public void CancelApplyingItem() { }

	public void DisableMetabolism() { }

	[CanBeNull]
	public TEffect FindActiveEffect(EBodyPart bodyPart = 7) { }

	public IEnumerable FindActiveEffects(EBodyPart bodyPart = 7) { }

	[CanBeNull]
	public TEffect FindExistingEffect(EBodyPart bodyPart = 7) { }

	public HealthEffects get_BodyPartEffects() { }

	public float get_CarryingWeightAbsoluteModifier() { }

	public float get_CarryingWeightRelativeModifier() { }

	public float get_DamageCoeff() { }

	public float get_EnergyRate() { }

	public float get_HealthRate() { }

	public float get_HydrationRate() { }

	public bool get_IsAlive() { }

	public float get_StaminaCoeff() { }

	public float get_TemperatureRate() { }

	public int get_UpdateTime() { }

	public IEnumerable GetAllActiveEffects(EBodyPart bodyPart = 7) { }

	public IEnumerable GetAllEffects(EBodyPart bodyPart = 7) { }

	public IEnumerable GetAllResidualEffects(EBodyPart bodyPart = 7) { }

	public void GetBodyPartsInCriticalCondition(float threshold, out int all, out int vital) { }

	public IResult HasPartsToApply(Item item) { }

	public bool IsBodyPartBroken(EBodyPart bodyPart) { }

	public bool IsBodyPartDestroyed(EBodyPart bodyPart) { }

	public bool IsItemForHealing(Item item) { }

	public void ManualUpdate(float deltaTime) { }

	public void PropagateAllEffects() { }

	[CompilerGenerated]
	public void remove_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public void remove_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public void remove_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public void remove_DiedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public void remove_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_StimulatorBuffActivationEvent(Action value) { }

	[CompilerGenerated]
	public void remove_StimulatorBuffEvent(Action value) { }

	[CompilerGenerated]
	public void remove_TemperatureChangedEvent(Action value) { }

	public void set_FallSafeHeight(float value) { }

	public void SetEncumbered(bool encumbered) { }

	public void SetOverEncumbered(bool encumbered) { }

	public bool TryTriggerTearGasCoughIfNeeded(Item item) { }

}

