//Type is in global namespace

public interface IPhysical
{

	public event Action OnSprintStateChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action WeightRelatedValuesUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool BerserkRestorationFactor
	{
		 set { } //Length: 0
	}

	public bool CanJump
	{
		 get { } //Length: 0
	}

	public bool CanMeleeHit
	{
		 get { } //Length: 0
	}

	public bool CanSprint
	{
		 get { } //Length: 0
	}

	public float CarryingWeightModifier
	{
		 get { } //Length: 0
	}

	public bool Exhausted
	{
		 get { } //Length: 0
	}

	public bool HoldingBreath
	{
		 get { } //Length: 0
	}

	public float SprintAcceleration
	{
		 get { } //Length: 0
	}

	public bool Sprinting
	{
		 get { } //Length: 0
	}

	public float SprintSensitivity
	{
		 get { } //Length: 0
	}

	public float SprintSpeed
	{
		 get { } //Length: 0
	}

	public StaminaParameters StaminaParameters
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnSprintStateChangedEvent(Action value) { }

	[CompilerGenerated]
	public void add_WeightRelatedValuesUpdated(Action value) { }

	public void Aim(float mass = 0) { }

	public void BulletHit(float staminaBurnRate) { }

	public void ConsumeAsMelee(float expense) { }

	public bool get_CanJump() { }

	public bool get_CanMeleeHit() { }

	public bool get_CanSprint() { }

	public float get_CarryingWeightModifier() { }

	public bool get_Exhausted() { }

	public bool get_HoldingBreath() { }

	public float get_SprintAcceleration() { }

	public bool get_Sprinting() { }

	public float get_SprintSensitivity() { }

	public float get_SprintSpeed() { }

	public StaminaParameters get_StaminaParameters() { }

	public void HoldBreath(bool enable) { }

	public void Init(Player player) { }

	public void InvokeInsufficient() { }

	public void LateUpdate() { }

	public void OnBreach() { }

	public void OnJump(bool enabled) { }

	public void OnThrow(bool lowThrow) { }

	public void OnWeightUpdated() { }

	[CompilerGenerated]
	public void remove_OnSprintStateChangedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_WeightRelatedValuesUpdated(Action value) { }

	public void set_BerserkRestorationFactor(bool value) { }

	public void Sprint(bool target) { }

	public void StandUp() { }

	public void Update(float dt) { }

	public void UpdatePose(int i) { }

	public void UpdateWeightLimits() { }

}

