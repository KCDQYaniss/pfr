//Type is in global namespace

public class Physical : PhysicalBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public Physical <>4__this; //Field offset: 0x10
		public Action unsub; //Field offset: 0x18

		public <>c__DisplayClass60_0() { }

		internal void <Init>b__0() { }

		internal float <Init>b__1() { }

		internal float <Init>b__10() { }

		internal float <Init>b__11() { }

		internal float <Init>b__12() { }

		internal float <Init>b__13() { }

		internal float <Init>b__14() { }

		internal float <Init>b__15() { }

		internal float <Init>b__16() { }

		internal float <Init>b__17() { }

		internal float <Init>b__18() { }

		internal float <Init>b__19() { }

		internal bool <Init>b__2() { }

		internal float <Init>b__20() { }

		internal float <Init>b__3() { }

		internal float <Init>b__4() { }

		internal float <Init>b__5() { }

		internal float <Init>b__6() { }

		internal float <Init>b__7() { }

		internal float <Init>b__8() { }

		internal bool <Init>b__9() { }

	}

	internal sealed class Consumption
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			public Consumption <>4__this; //Field offset: 0x10
			public PhysicalBase physical; //Field offset: 0x18

			public <>c__DisplayClass13_0() { }

			internal void <ApplyTo>b__1() { }

			internal void <ApplyTo>g__Fallback|0() { }

		}

		public readonly EConsumptionType ConsumptionType; //Field offset: 0x10
		public Compute Delta; //Field offset: 0x18
		public Compute Availability; //Field offset: 0x20
		public float StartThreshold; //Field offset: 0x28
		public EConsumptionTarget Requires; //Field offset: 0x2C
		public float Downtime; //Field offset: 0x30
		public bool AllowsRestoration; //Field offset: 0x34
		public bool IgnoresConsumptionMultiplier; //Field offset: 0x35
		public EConsumptionTarget PrimaryTarget; //Field offset: 0x38
		private Action _stopConsumption; //Field offset: 0x40

		public Consumption(EConsumptionType consumptionType) { }

		private void ApplyTo(PhysicalBase physical) { }

		public void Consume(PhysicalBase physical, bool fromHit = false) { }

		public void SetActive(PhysicalBase physical, bool isActive) { }

	}

	[Flags]
	internal enum EConsumptionTarget
	{
		Base = 1,
		Hands = 2,
		Oxygen = 4,
		None = 8,
	}

	internal enum EConsumptionType
	{
		OverweightIdle = 0,
		Sprint = 1,
		Walk = 2,
		Jump = 3,
		Aim = 4,
		Melee = 5,
		HoldBreath = 6,
		Wound = 7,
		TearGas = 8,
		StandUp = 9,
		Prone = 10,
		SitToStand = 11,
		FastWeaponSwitch = 12,
		VaultLegs = 13,
		ClimbLegs = 14,
		VaultHands = 15,
		ClimbHands = 16,
	}

	internal enum EPose
	{
		Prone = 0,
		Sit = 1,
		Stand = 2,
	}

	private const float OVERWEIGHT_STANCE = 0.9; //Field offset: 0x0
	public readonly Dictionary Consumptions; //Field offset: 0x130
	public float BaseHoldBreathConsumption; //Field offset: 0x138
	private bool _sprinting; //Field offset: 0x13C
	private EPose _pose; //Field offset: 0x140
	private float _aimMass; //Field offset: 0x144
	private readonly float[] _aimMultiplierByPose; //Field offset: 0x148
	private readonly float[] _restorationMultiplierByPose; //Field offset: 0x150
	private readonly float[] _overweightConsumptionByPose; //Field offset: 0x158
	private float _meleeConsumedRef; //Field offset: 0x160
	private float _woundConsumedRef; //Field offset: 0x164
	private float _tearGasDrain; //Field offset: 0x168
	private float _notchesUpdated; //Field offset: 0x16C
	private float _sprintSpamSize; //Field offset: 0x170
	private float _sprintSpamTimer; //Field offset: 0x174
	private float _fastWeaponSwitchStaminaLack; //Field offset: 0x178
	private int _weaponTypeMasteringLevel; //Field offset: 0x17C
	private readonly Consumption _sprintSpam; //Field offset: 0x180
	private Player _player; //Field offset: 0x188

	public virtual bool BerserkRestorationFactor
	{
		 set { } //Length: 49
	}

	public virtual bool CanClimb
	{
		 get { } //Length: 576
	}

	public virtual bool CanJump
	{
		 get { } //Length: 218
	}

	public virtual bool CanMeleeHit
	{
		 get { } //Length: 396
	}

	public virtual bool CanSprint
	{
		 get { } //Length: 218
	}

	public virtual bool CanVault
	{
		 get { } //Length: 576
	}

	public virtual bool Exhausted
	{
		 get { } //Length: 60
	}

	public virtual float FastWeaponSwitchStaminaLack
	{
		 get { } //Length: 9
	}

	public virtual bool HoldingBreath
	{
		 get { } //Length: 144
	}

	private float HydrationFactor
	{
		private get { } //Length: 162
	}

	private float PerkFallDamageMultiplier
	{
		private get { } //Length: 208
	}

	private float PerkHandsStaminaCapacityOffset
	{
		private get { } //Length: 188
	}

	private float PerkHandsStaminaConsumptionMultiplier
	{
		private get { } //Length: 208
	}

	private float PerkHandsStaminaRestorationMultiplier
	{
		private get { } //Length: 208
	}

	private float PerkStaminaCapacityOffset
	{
		private get { } //Length: 188
	}

	private float PerkStaminaConsumptionMultiplier
	{
		private get { } //Length: 208
	}

	private float PerkStaminaRestorationMultiplier
	{
		private get { } //Length: 208
	}

	public virtual bool Sprinting
	{
		 get { } //Length: 8
	}

	public Physical() { }

	public virtual void AddTearGasStaminaDrain(float value) { }

	public virtual void Aim(float mass = 0) { }

	private float BaseStaminaFunction(float baseValue, float perkCapacityOffset) { }

	private float BaseStaminaRestorationFunc(float baseValue, float perkMultiplier) { }

	public virtual void BulletHit(float staminaBurnRate) { }

	public virtual void ConsumeAsMelee(float expense) { }

	public virtual void ConsumePoseLevelChange(float notches) { }

	public virtual bool get_CanClimb() { }

	public virtual bool get_CanJump() { }

	public virtual bool get_CanMeleeHit() { }

	public virtual bool get_CanSprint() { }

	public virtual bool get_CanVault() { }

	public virtual bool get_Exhausted() { }

	public virtual float get_FastWeaponSwitchStaminaLack() { }

	public virtual bool get_HoldingBreath() { }

	private float get_HydrationFactor() { }

	private float get_PerkFallDamageMultiplier() { }

	private float get_PerkHandsStaminaCapacityOffset() { }

	private float get_PerkHandsStaminaConsumptionMultiplier() { }

	private float get_PerkHandsStaminaRestorationMultiplier() { }

	private float get_PerkStaminaCapacityOffset() { }

	private float get_PerkStaminaConsumptionMultiplier() { }

	private float get_PerkStaminaRestorationMultiplier() { }

	public virtual bool get_Sprinting() { }

	private float GetCrouchPoseMultiplier() { }

	protected virtual float GetHandsCapacityFunc() { }

	protected virtual float GetHandsRestorationFunc() { }

	protected virtual float GetOxygenCapacityFunc() { }

	protected virtual float GetOxygenRestorationFunc() { }

	protected virtual float GetStaminaCapacityFunc() { }

	protected virtual float GetStaminaRestorationFunc() { }

	private void HandsStaminaExpired() { }

	private float HandsStaminaFunction(float baseValue) { }

	public virtual void HoldBreath(bool enable) { }

	public virtual void Init(IPlayer player) { }

	private void MovementContextOnStateChanged(EPlayerState previousState, EPlayerState nextState) { }

	public virtual void OnBreach() { }

	public virtual void OnClimb() { }

	private void OnEnduranceLevelUp() { }

	private void OnEnergyChanged(float delta) { }

	private void OnHydrationChanged(float delta) { }

	public virtual void OnJump(bool enabled) { }

	private void OnPerksChanged() { }

	private void OnStaminaThresholdPass() { }

	private void OnStaminaValueChanged() { }

	private void OnStrLevelUp() { }

	public virtual void OnThrow(bool lowThrow) { }

	public virtual void OnVault() { }

	public virtual void OnWeaponSwitchFast(int level) { }

	public virtual void OnWeightUpdated() { }

	private void OxygenExpired() { }

	protected virtual void PhysicalConditionChanged(EPhysicalCondition diff, EPhysicalCondition full) { }

	private void RefreshPerkStaminaConsumptionMultipliers() { }

	public virtual void RemoveTearGasStaminaDrain(float value) { }

	private void ResetOveruse() { }

	public virtual void set_BerserkRestorationFactor(bool value) { }

	public virtual void Sprint(bool target) { }

	private void StaminaConsumptionChanged() { }

	private void StaminaExpired() { }

	public virtual void StandUp() { }

	public virtual void Update(float dt) { }

	private void UpdatePose(int i) { }

}

