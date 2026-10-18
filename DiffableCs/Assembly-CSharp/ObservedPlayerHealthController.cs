//Type is in global namespace

public sealed class ObservedPlayerHealthController : IHealthController, IBaseHealthController
{
	[CompilerGenerated]
	private struct <CreateCorpseWithDelay>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ObservedPlayerHealthController <>4__this; //Field offset: 0x20
		public CreateCorpsePacket deathPacket; //Field offset: 0x28
		public bool dropWeapon; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public ETagStatus HealthStatus; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsAlive>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Action OnEffectOnPlayerStatusChangedEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnHealthEffectDisplayChangedEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnSpectatorBlindnessChangedEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnSpectatorFaceShieldCrackingChangedEvent; //Field offset: 0x30
	[CompilerGenerated]
	private readonly SpectatorBlindnessState <SpectatorBlindnessState>k__BackingField; //Field offset: 0x38
	private ObservedPlayerView _player; //Field offset: 0x40
	private ObservedCorpse _playerCorpse; //Field offset: 0x48
	private Garbage _inHandOnDeadGarbage; //Field offset: 0x50
	private EPhysicalCondition _physicalCondition; //Field offset: 0x58
	private HashSet _currentMedEffectsIDs; //Field offset: 0x60
	private bool _gotDeathPacket; //Field offset: 0x68
	private Dictionary _spectatorHealthValues; //Field offset: 0x70
	private Dictionary _cachedSpectatorHealthEffects; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnPhysicalConditionChanged; //Field offset: 0x80
	[CompilerGenerated]
	private Action EffectAddedEvent; //Field offset: 0x88
	[CompilerGenerated]
	private Action EffectStartedEvent; //Field offset: 0x90
	[CompilerGenerated]
	private Action EffectUpdatedEvent; //Field offset: 0x98
	[CompilerGenerated]
	private Action EffectResidualEvent; //Field offset: 0xA0
	[CompilerGenerated]
	private Action EffectRemovedEvent; //Field offset: 0xA8
	[CompilerGenerated]
	private Action EffectStatusUpdateEvent; //Field offset: 0xB0
	[CompilerGenerated]
	private Action ApplyDamageEvent; //Field offset: 0xB8
	[CompilerGenerated]
	private Action HealthChangedEvent; //Field offset: 0xC0
	[CompilerGenerated]
	private Action EnergyChangedEvent; //Field offset: 0xC8
	[CompilerGenerated]
	private Action HydrationChangedEvent; //Field offset: 0xD0
	[CompilerGenerated]
	private Action TemperatureChangedEvent; //Field offset: 0xD8
	[CompilerGenerated]
	private Action BodyPartDestroyedEvent; //Field offset: 0xE0
	[CompilerGenerated]
	private Action BodyPartRestoredEvent; //Field offset: 0xE8
	[CompilerGenerated]
	private Action DiedEvent; //Field offset: 0xF0
	[CompilerGenerated]
	private Action HealerDoneEvent; //Field offset: 0xF8
	[CompilerGenerated]
	private Action BurnEyesEvent; //Field offset: 0x100
	[CompilerGenerated]
	private Action StimulatorBuffEvent; //Field offset: 0x108
	[CompilerGenerated]
	private Action StimulatorBuffActivationEvent; //Field offset: 0x110
	[CompilerGenerated]
	private float <FallSafeHeight>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private readonly ValueStruct <Energy>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private readonly ValueStruct <Hydration>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private readonly ValueStruct <Temperature>k__BackingField; //Field offset: 0x144
	[CompilerGenerated]
	private readonly ValueStruct <Poison>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private readonly float <HealthRate>k__BackingField; //Field offset: 0x16C
	[CompilerGenerated]
	private readonly float <EnergyRate>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private readonly float <HydrationRate>k__BackingField; //Field offset: 0x174
	[CompilerGenerated]
	private readonly float <TemperatureRate>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private readonly float <DamageCoeff>k__BackingField; //Field offset: 0x17C
	[CompilerGenerated]
	private readonly float <StaminaCoeff>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private readonly int <UpdateTime>k__BackingField; //Field offset: 0x184
	[CompilerGenerated]
	private readonly Player <Player>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private readonly HealthEffects <BodyPartEffects>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private readonly float <CarryingWeightAbsoluteModifier>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private readonly float <CarryingWeightRelativeModifier>k__BackingField; //Field offset: 0x19C

	public override event Action ApplyDamageEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action BodyPartDestroyedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action BodyPartRestoredEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action BurnEyesEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action DiedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EffectAddedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EffectRemovedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EffectResidualEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EffectStartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EffectStatusUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EffectUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action EnergyChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action HealerDoneEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action HealthChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action HydrationChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnEffectOnPlayerStatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnHealthEffectDisplayChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPhysicalConditionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSpectatorBlindnessChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnSpectatorFaceShieldCrackingChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action StimulatorBuffActivationEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action StimulatorBuffEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action TemperatureChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override HealthEffects BodyPartEffects
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public IReadOnlyDictionary CachedSpectatorHealthEffects
	{
		 get { } //Length: 5
	}

	public override float CarryingWeightAbsoluteModifier
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override float CarryingWeightRelativeModifier
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override float DamageCoeff
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override ValueStruct Energy
	{
		[CompilerGenerated]
		 get { } //Length: 23
	}

	public override float EnergyRate
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override float FallSafeHeight
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override float HealthRate
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override ValueStruct Hydration
	{
		[CompilerGenerated]
		 get { } //Length: 23
	}

	public override float HydrationRate
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public private override bool IsAlive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ObservedCorpse PlayerCorpse
	{
		 get { } //Length: 5
	}

	public override ValueStruct Poison
	{
		[CompilerGenerated]
		 get { } //Length: 23
	}

	public SpectatorBlindnessState SpectatorBlindnessState
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override float StaminaCoeff
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override ValueStruct Temperature
	{
		[CompilerGenerated]
		 get { } //Length: 23
	}

	public override float TemperatureRate
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override int UpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public ObservedPlayerHealthController(ObservedPlayerView player) { }

	public override string[] ActiveBuffsNames() { }

	[CompilerGenerated]
	public override void add_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public override void add_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public override void add_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public override void add_DiedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public override void add_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnEffectOnPlayerStatusChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnHealthEffectDisplayChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnPhysicalConditionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSpectatorBlindnessChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnSpectatorFaceShieldCrackingChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_StimulatorBuffActivationEvent(Action value) { }

	[CompilerGenerated]
	public override void add_StimulatorBuffEvent(Action value) { }

	[CompilerGenerated]
	public override void add_TemperatureChangedEvent(Action value) { }

	public override void AddFatigue() { }

	public override void AddImmunityNotificationEffect() { }

	public void Apply(ObservedPlayerMovementModel model) { }

	private void ApplyChangeEquipCommand(ChangeEquipCommandMessage command) { }

	private void ApplyCorpseImpulse(EBodyPartColliderType bodyPartColliderType, Vector3 direction, Vector3 point, float force) { }

	public void ApplyDeath(CreateCorpsePacket deathPacket) { }

	private void ApplyEffectOnPlayerCommand(EffectOnPlayerStatusCommandMessage effectOnPlayerStatusCommandMessage) { }

	private void ApplyHealthStatusCommand(HealthStatusCommandMessage healthStatusCommandMessage) { }

	public override bool ApplyItem(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public override bool ApplyItem(Item item, OneAndList bodyPart, Nullable amount = null) { }

	private void ApplyMedEffectUpdateStatus(MedEffectStatusCommandMessage medEffectStatusCommandMessage) { }

	private void ApplyTemperatureCommand(TemperatureCommandMessage temperatureCommandMessage) { }

	public override OneAndList BodyPartsPriority(Item item, bool continuousHealEnabled) { }

	public override bool CanApplyItem(Item item, EBodyPart bodyPart) { }

	public override void CancelApplyingItem() { }

	private ObservedCorpse CreateCorpse(Vector3 overallVelocity, bool simulateCorpse) { }

	[AsyncStateMachine(typeof(<CreateCorpseWithDelay>d__57))]
	private Task CreateCorpseWithDelay(CreateCorpsePacket deathPacket, bool dropWeapon) { }

	public override void DisableMetabolism() { }

	private void DropInHandItemOnDead(Item item, GameObject prefab, Vector3 velocity) { }

	public void Execute(ICommandMessage command) { }

	public void ExecuteSpectator(ICommandMessage command) { }

	public override TEffect FindActiveEffect(EBodyPart bodyPart = 7) { }

	public override IEnumerable FindActiveEffects(EBodyPart bodyPart = 7) { }

	public override TEffect FindExistingEffect(EBodyPart bodyPart = 7) { }

	[CompilerGenerated]
	public override HealthEffects get_BodyPartEffects() { }

	public IReadOnlyDictionary get_CachedSpectatorHealthEffects() { }

	[CompilerGenerated]
	public override float get_CarryingWeightAbsoluteModifier() { }

	[CompilerGenerated]
	public override float get_CarryingWeightRelativeModifier() { }

	[CompilerGenerated]
	public override float get_DamageCoeff() { }

	[CompilerGenerated]
	public override ValueStruct get_Energy() { }

	[CompilerGenerated]
	public override float get_EnergyRate() { }

	[CompilerGenerated]
	public float get_FallSafeHeight() { }

	[CompilerGenerated]
	public override float get_HealthRate() { }

	[CompilerGenerated]
	public override ValueStruct get_Hydration() { }

	[CompilerGenerated]
	public override float get_HydrationRate() { }

	[CompilerGenerated]
	public override bool get_IsAlive() { }

	[CompilerGenerated]
	public Player get_Player() { }

	public ObservedCorpse get_PlayerCorpse() { }

	[CompilerGenerated]
	public override ValueStruct get_Poison() { }

	[CompilerGenerated]
	public SpectatorBlindnessState get_SpectatorBlindnessState() { }

	[CompilerGenerated]
	public override float get_StaminaCoeff() { }

	[CompilerGenerated]
	public override ValueStruct get_Temperature() { }

	[CompilerGenerated]
	public override float get_TemperatureRate() { }

	[CompilerGenerated]
	public override int get_UpdateTime() { }

	public override IEnumerable GetAllActiveEffects(EBodyPart bodyPart = 7) { }

	public override IEnumerable GetAllEffects(EBodyPart bodyPart = 7) { }

	public override IEnumerable GetAllResidualEffects(EBodyPart bodyPart = 7) { }

	public override ValueStruct GetBodyPartHealth(EBodyPart bodyPart, bool rounded = false) { }

	public override void GetBodyPartsInCriticalCondition(float threshold, out int all, out int vital) { }

	private static FaceShieldComponent GetFaceShieldFromSlot(InventoryEquipment equipment, EquipmentSlot slot) { }

	public float GetSpectatorHealth(EBodyPart part) { }

	public override IResult HasPartsToApply(Item item) { }

	public bool HaveMedEffectWithID(string ID) { }

	private void InvokeApplyDamageEvent(EBodyPart eBodyPart, float damage, DamageInfo damageInfo) { }

	private void InvokeBodyPartDestroyedEvent(EBodyPart eBodyPart, EDamageType eDamageType) { }

	private void InvokeBodyPartRestoredEvent(EBodyPart eBodyPart, ValueStruct value) { }

	private void InvokeBurnEyesEvent(Vector3 position, float str, float time) { }

	private void InvokeDiedEvent(EDamageType eDamageType) { }

	private void InvokeEffectAddedEvent(IHealthEffect iHealthEffect) { }

	private void InvokeEffectRemovedEvent(IHealthEffect iHealthEffect) { }

	private void InvokeEffectResidualEvent(IHealthEffect iHealthEffect) { }

	private void InvokeEffectStartedEvent(IHealthEffect iHealthEffect) { }

	private void InvokeEffectStatusUpdateEvent(IHealthEffect iHealthEffect) { }

	private void InvokeEffectUpdatedEvent(IHealthEffect iHealthEffect) { }

	private void InvokeEnergyChangedEvent(float delta) { }

	private void InvokeHealerDoneEvent(IHealthEffect iHealthEffect) { }

	private void InvokeHealthChangedEvent(EBodyPart eBodyPart, float damage, DamageInfo damageInfo) { }

	private void InvokeHydrationChangedEvent(float delta) { }

	private void InvokeStimulatorBuffActivationEvent(IStimulatorBuff stimulatorBuff) { }

	private void InvokeStimulatorBuffEvent(IStimulatorBuff stimulatorBuff) { }

	private void InvokeTemperatureChangedEvent(float delta) { }

	public override bool IsBodyPartBroken(EBodyPart bodyPart) { }

	public override bool IsBodyPartDestroyed(EBodyPart bodyPart) { }

	public override bool IsItemForHealing(Item item) { }

	public override void ManualUpdate(float deltaTime) { }

	private void OnEffectOnPlayerStatusChanged(EffectOnPlayerStatusCommandMessage command) { }

	private void OnHealthEffectDisplayChanged(SpectatorHealthEffectDisplayCommandMessage command) { }

	private void OnSpectatorBlindnessChanged(SpectatorBlindnessCommandMessage command) { }

	private void OnSpectatorFaceShieldCrackingChanged(SpectatorFaceshieldCrackingCommandMessage command) { }

	public void PauseAllEffects() { }

	public bool PhysicalConditionContainsAny(EPhysicalCondition c) { }

	public bool PhysicalConditionIs(EPhysicalCondition c) { }

	public override void PropagateAllEffects() { }

	private void ReleaseHand() { }

	[CompilerGenerated]
	public override void remove_ApplyDamageEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_BodyPartDestroyedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_BodyPartRestoredEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_BurnEyesEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_DiedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EffectAddedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EffectRemovedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EffectResidualEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EffectStartedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EffectStatusUpdateEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EffectUpdatedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_EnergyChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_HealerDoneEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_HealthChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_HydrationChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnEffectOnPlayerStatusChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnHealthEffectDisplayChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnPhysicalConditionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpectatorBlindnessChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpectatorFaceShieldCrackingChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_StimulatorBuffActivationEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_StimulatorBuffEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_TemperatureChangedEvent(Action value) { }

	private void RemoveAttachment(RigidbodySpawner spawner) { }

	private FaceShieldComponent ResolveSpectatorFaceShieldComponent() { }

	[CompilerGenerated]
	public override void set_FallSafeHeight(float value) { }

	[CompilerGenerated]
	private void set_IsAlive(bool value) { }

	public override void SetEncumbered(bool encumbered) { }

	public override void SetOverEncumbered(bool encumbered) { }

	private void SetPhysicalCondition(EPhysicalCondition c) { }

	public void SetSpectatorHealth(EBodyPart part, float value) { }

	public override bool TryTriggerTearGasCoughIfNeeded(Item item) { }

	public void UnpauseAllEffects() { }

}

