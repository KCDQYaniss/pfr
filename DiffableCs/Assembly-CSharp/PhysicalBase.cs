//Type is in global namespace

public class PhysicalBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass123_0
	{
		public PhysicalBase <>4__this; //Field offset: 0x10
		public Action unsub; //Field offset: 0x18

		public <>c__DisplayClass123_0() { }

		internal float <Init>b__0() { }

		internal float <Init>b__1() { }

		internal void <Init>b__2() { }

		internal float <Init>b__3() { }

		internal float <Init>b__4() { }

		internal void <Init>b__5(ClientPlayerEffectsPauseEvent calledEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass156_0
	{
		public PhysicalBase <>4__this; //Field offset: 0x10
		public Action updateBreathStatus; //Field offset: 0x18

		public <>c__DisplayClass156_0() { }

		internal void <SubscribeToAudibleEffects>b__0() { }

		internal void <SubscribeToAudibleEffects>b__1() { }

	}

	internal interface IObserverToPlayerBridge
	{

		public event Action OnPhysicalConditionChanged
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		public event Action OnTotalWeightUpdated
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		public IPlayer iPlayer
		{
			 get { } //Length: 0
		}

		public SkillManager Skills
		{
			 get { } //Length: 0
		}

		public float TotalWeight
		{
			 get { } //Length: 0
		}

		[CompilerGenerated]
		public void add_OnPhysicalConditionChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnTotalWeightUpdated(Action value) { }

		public IPlayer get_iPlayer() { }

		public SkillManager get_Skills() { }

		public float get_TotalWeight() { }

		public bool PhysicalConditionContainsAny(EPhysicalCondition c) { }

		[CompilerGenerated]
		public void remove_OnPhysicalConditionChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnTotalWeightUpdated(Action value) { }

	}

	internal class ObserverBridge : IObserverToPlayerBridge
	{
		[CompilerGenerated]
		private Action OnTotalWeightUpdated; //Field offset: 0x10
		[CompilerGenerated]
		private Action OnPhysicalConditionChanged; //Field offset: 0x18
		private ObservedPlayerView _observedPlayer; //Field offset: 0x20

		public override event Action OnPhysicalConditionChanged
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action OnTotalWeightUpdated
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override IPlayer iPlayer
		{
			 get { } //Length: 5
		}

		public override SkillManager Skills
		{
			 get { } //Length: 3
		}

		public override float TotalWeight
		{
			 get { } //Length: 4
		}

		public ObserverBridge(ObservedPlayerView player) { }

		[CompilerGenerated]
		public override void add_OnPhysicalConditionChanged(Action value) { }

		[CompilerGenerated]
		public override void add_OnTotalWeightUpdated(Action value) { }

		private void CallOnPhysicalConditionChanged(EPhysicalCondition adddedOrRemoved, EPhysicalCondition result) { }

		private void CallOnTotalWeightUpdated() { }

		public override IPlayer get_iPlayer() { }

		public override SkillManager get_Skills() { }

		public override float get_TotalWeight() { }

		public override bool PhysicalConditionContainsAny(EPhysicalCondition c) { }

		[CompilerGenerated]
		public override void remove_OnPhysicalConditionChanged(Action value) { }

		[CompilerGenerated]
		public override void remove_OnTotalWeightUpdated(Action value) { }

	}

	internal class PlayerBridge : IObserverToPlayerBridge
	{
		[CompilerGenerated]
		private Action OnTotalWeightUpdated; //Field offset: 0x10
		[CompilerGenerated]
		private Action OnPhysicalConditionChanged; //Field offset: 0x18
		private Player _player; //Field offset: 0x20

		public override event Action OnPhysicalConditionChanged
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action OnTotalWeightUpdated
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override IPlayer iPlayer
		{
			 get { } //Length: 5
		}

		public override SkillManager Skills
		{
			 get { } //Length: 47
		}

		public override float TotalWeight
		{
			 get { } //Length: 205
		}

		public PlayerBridge(Player player) { }

		[CompilerGenerated]
		public override void add_OnPhysicalConditionChanged(Action value) { }

		[CompilerGenerated]
		public override void add_OnTotalWeightUpdated(Action value) { }

		private void CallOnPhysicalConditionChanged(EPhysicalCondition adddedOrRemoved, EPhysicalCondition result) { }

		private void CallOnTotalWeightUpdated() { }

		public override IPlayer get_iPlayer() { }

		public override SkillManager get_Skills() { }

		public override float get_TotalWeight() { }

		public override bool PhysicalConditionContainsAny(EPhysicalCondition c) { }

		[CompilerGenerated]
		public override void remove_OnPhysicalConditionChanged(Action value) { }

		[CompilerGenerated]
		public override void remove_OnTotalWeightUpdated(Action value) { }

	}

	internal struct StaminaStruct
	{
		public bool StaminaExhausted; //Field offset: 0x0
		public bool OxygenExhausted; //Field offset: 0x1
		public bool HandsExhausted; //Field offset: 0x2

		public bool Equals(StaminaStruct other) { }

	}

	private const float MIN_STEP_SOUND = 0.6; //Field offset: 0x0
	protected IObserverToPlayerBridge _playerBridge; //Field offset: 0x10
	public float MaxPoseLevel; //Field offset: 0x18
	public float Overweight; //Field offset: 0x1C
	public float WalkOverweight; //Field offset: 0x20
	public float WalkSpeedLimit; //Field offset: 0x24
	public float Inertia; //Field offset: 0x28
	public float MoveSideInertia; //Field offset: 0x2C
	public float MoveDiagonalInertia; //Field offset: 0x30
	public Deferred MinStepSound; //Field offset: 0x38
	public Deferred TransitionSpeed; //Field offset: 0x40
	public Deferred PoseLevelIncreaseSpeed; //Field offset: 0x48
	public Deferred PoseLevelDecreaseSpeed; //Field offset: 0x50
	public float SoundRadius; //Field offset: 0x58
	private bool _droppedBelowFatigueThreshold; //Field offset: 0x5C
	private float _fatigueTimer; //Field offset: 0x60
	public float Fatigue; //Field offset: 0x64
	public Stamina Stamina; //Field offset: 0x68
	public Stamina HandsStamina; //Field offset: 0x70
	public Stamina Oxygen; //Field offset: 0x78
	private float _capacityBuff; //Field offset: 0x80
	private float _restoreRateBuff; //Field offset: 0x84
	public float FallDamageMultiplier; //Field offset: 0x88
	public float StaminaCapacity; //Field offset: 0x8C
	public float StaminaRestoreRate; //Field offset: 0x90
	public float HandsCapacity; //Field offset: 0x94
	public float HandsRestoreRate; //Field offset: 0x98
	public float OxygenCapacity; //Field offset: 0x9C
	public float OxygenRestoreRate; //Field offset: 0xA0
	public Vector2 WalkOverweightLimits; //Field offset: 0xA4
	public Vector2 BaseOverweightLimits; //Field offset: 0xAC
	public Vector3 BaseInertiaLimits; //Field offset: 0xB4
	public Vector2 SprintOverweightLimits; //Field offset: 0xC0
	public Vector2 WalkSpeedOverweightLimits; //Field offset: 0xC8
	protected float SprintOverweight; //Field offset: 0xD0
	public float PreviousWeight; //Field offset: 0xD4
	private bool _weightIsOutOfDate; //Field offset: 0xD8
	private bool _sprinting; //Field offset: 0xD9
	private StaminaStruct _serializationStruct; //Field offset: 0xDA
	private bool _canFatigue; //Field offset: 0xDD
	[CompilerGenerated]
	private Action OnSprintStateChangedEvent; //Field offset: 0xE0
	[CompilerGenerated]
	private Action WeightRelatedValuesUpdated; //Field offset: 0xE8
	[CompilerGenerated]
	private Action OverweightIncreased; //Field offset: 0xF0
	[CompilerGenerated]
	private Action EncumberedChanged; //Field offset: 0xF8
	[CompilerGenerated]
	private Action OverEncumberedChanged; //Field offset: 0x100
	[CompilerGenerated]
	private Action HoldBreathChanged; //Field offset: 0x108
	[CompilerGenerated]
	private bool <BerserkRestorationFactor>k__BackingField; //Field offset: 0x110
	public float SprintAcceleration; //Field offset: 0x114
	public float PreSprintAcceleration; //Field offset: 0x118
	private bool _encumbered; //Field offset: 0x11C
	private bool _overEncumbered; //Field offset: 0x11D
	protected Action UnsubscribeAction; //Field offset: 0x120
	private bool _encumberDisabled; //Field offset: 0x128

	public event Action EncumberedChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action HoldBreathChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnSprintStateChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OverEncumberedChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OverweightIncreased
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action WeightRelatedValuesUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override bool BerserkRestorationFactor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool BreathIsAudible
	{
		 get { } //Length: 161
	}

	public override bool CanClimb
	{
		 get { } //Length: 3
	}

	public bool CanFatigue
	{
		 get { } //Length: 8
	}

	public override bool CanJump
	{
		 get { } //Length: 3
	}

	public override bool CanMeleeHit
	{
		 get { } //Length: 3
	}

	public override bool CanSprint
	{
		 get { } //Length: 3
	}

	public override bool CanVault
	{
		 get { } //Length: 3
	}

	public float CapacityBuff
	{
		 get { } //Length: 9
		 set { } //Length: 140
	}

	public bool EncumberDisabled
	{
		 get { } //Length: 8
		 set { } //Length: 63
	}

	public override bool Exhausted
	{
		 get { } //Length: 3
	}

	public override float FastWeaponSwitchStaminaLack
	{
		 get { } //Length: 4
	}

	public override bool HoldingBreath
	{
		 get { } //Length: 3
	}

	private bool IsEncumbered
	{
		private get { } //Length: 55
	}

	public float MeleeSpeed
	{
		 get { } //Length: 113
	}

	public float RestoreRateBuff
	{
		 get { } //Length: 9
		 set { } //Length: 80
	}

	public StaminaStruct SerializationStruct
	{
		 get { } //Length: 111
		 set { } //Length: 290
	}

	public override bool Sprinting
	{
		 get { } //Length: 8
	}

	public float SprintSensitivity
	{
		 get { } //Length: 148
	}

	public float SprintSpeed
	{
		 get { } //Length: 148
	}

	public StaminaParameters StaminaParameters
	{
		 get { } //Length: 64
	}

	public PhysicalBase() { }

	[CompilerGenerated]
	public void add_EncumberedChanged(Action value) { }

	[CompilerGenerated]
	public void add_HoldBreathChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSprintStateChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_OverEncumberedChanged(Action value) { }

	[CompilerGenerated]
	public void add_OverweightIncreased(Action value) { }

	[CompilerGenerated]
	public void add_WeightRelatedValuesUpdated(Action value) { }

	public override void AddTearGasStaminaDrain(float value) { }

	public override void Aim(float mass = 0) { }

	public override void BulletHit(float staminaBurnRate) { }

	public float CalculateValue(Vector3 dependency, float weight) { }

	public override void ConsumeAsMelee(float expense) { }

	public override void ConsumePoseLevelChange(float notches) { }

	[CompilerGenerated]
	public override bool get_BerserkRestorationFactor() { }

	public bool get_BreathIsAudible() { }

	public override bool get_CanClimb() { }

	public bool get_CanFatigue() { }

	public override bool get_CanJump() { }

	public override bool get_CanMeleeHit() { }

	public override bool get_CanSprint() { }

	public override bool get_CanVault() { }

	public float get_CapacityBuff() { }

	public bool get_EncumberDisabled() { }

	public override bool get_Exhausted() { }

	public override float get_FastWeaponSwitchStaminaLack() { }

	public override bool get_HoldingBreath() { }

	private bool get_IsEncumbered() { }

	public float get_MeleeSpeed() { }

	public float get_RestoreRateBuff() { }

	public StaminaStruct get_SerializationStruct() { }

	public override bool get_Sprinting() { }

	public float get_SprintSensitivity() { }

	public float get_SprintSpeed() { }

	public StaminaParameters get_StaminaParameters() { }

	protected override float GetHandsCapacityFunc() { }

	protected override float GetHandsRestorationFunc() { }

	protected override float GetOxygenCapacityFunc() { }

	protected override float GetOxygenRestorationFunc() { }

	protected override float GetStaminaCapacityFunc() { }

	protected override float GetStaminaRestorationFunc() { }

	public override void HoldBreath(bool enable) { }

	public override void Init(IPlayer iPlayer) { }

	protected void InvokeEnergyExpenseEvent() { }

	protected void InvokeHoldBreathChanged() { }

	public override void InvokeInsufficient() { }

	protected void InvokeOverweightIncreased() { }

	protected void InvokeWeightRelatedValuesUpdate() { }

	public void LateUpdate() { }

	private void MarkWeightAsDirty() { }

	public override void OnBreach() { }

	public override void OnClimb() { }

	private void OnHealthEffectChanged(IHealthEffect effect) { }

	public override void OnJump(bool enabled) { }

	private void OnPlayerEffectsPaused(ClientPlayerEffectsPauseEvent invokedEvent) { }

	private void OnStaminaOnThresholdPass() { }

	public override void OnThrow(bool lowThrow) { }

	public override void OnVault() { }

	public override void OnWeaponSwitchFast(int weaponTypeMasteringLevel) { }

	public void OnWeightLimitsUpdated() { }

	public override void OnWeightUpdated() { }

	protected override void PhysicalConditionChanged(EPhysicalCondition diff, EPhysicalCondition full) { }

	protected void RefreshStaminaBuffs() { }

	[CompilerGenerated]
	public void remove_EncumberedChanged(Action value) { }

	[CompilerGenerated]
	public void remove_HoldBreathChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSprintStateChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OverEncumberedChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OverweightIncreased(Action value) { }

	[CompilerGenerated]
	public void remove_WeightRelatedValuesUpdated(Action value) { }

	public override void RemoveTearGasStaminaDrain(float value) { }

	[CompilerGenerated]
	public override void set_BerserkRestorationFactor(bool value) { }

	public void set_CapacityBuff(float value) { }

	public void set_EncumberDisabled(bool value) { }

	public void set_RestoreRateBuff(float value) { }

	public void set_SerializationStruct(StaminaStruct value) { }

	public override void Sprint(bool target) { }

	public override void StandUp() { }

	public Action SubscribeToAudibleEffects(Action updateBreathStatus) { }

	public void Unsubscribe() { }

	public override void Update(float dt) { }

	protected void UpdateInternalParameters(float weight) { }

	public void UpdateWeightLimits() { }

}

