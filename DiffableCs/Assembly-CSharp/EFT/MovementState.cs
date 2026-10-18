namespace EFT;

public class MovementState : BaseMovementState
{
	public static Vector3 G; //Field offset: 0x0
	public static float G_y; //Field offset: 0xC
	protected MovementContext MovementContext; //Field offset: 0x48
	public float NormalizedTime; //Field offset: 0x50
	protected bool StickToGround; //Field offset: 0x54
	public bool PlantMultitool; //Field offset: 0x55
	public float PlantTime; //Field offset: 0x58
	protected Nullable Destination; //Field offset: 0x5C
	[CompilerGenerated]
	private Vector2 <Direction>k__BackingField; //Field offset: 0x6C
	private Vector3 _currentDownForce; //Field offset: 0x74
	private Vector3 _motionShortage; //Field offset: 0x80
	private RollingMedian _sqrShortage; //Field offset: 0x90
	private Vector2 _speedRotationDamp; //Field offset: 0x98

	public override bool CanLoot
	{
		 get { } //Length: 3
	}

	public Vector2 Direction
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public virtual bool DisableRootMotion
	{
		 set { } //Length: 29
	}

	protected float FreefallTime
	{
		 get { } //Length: 31
		 set { } //Length: 31
	}

	private static MovementState() { }

	public MovementState(MovementContext movementContext) { }

	protected override void ApplyGravity(ref Vector3 motion, float deltaTime) { }

	protected override void ApplyMotion(ref Vector3 motion, float deltaTime) { }

	public virtual void AssignAnimatorPose(AnimatorPose animatorPose) { }

	protected override void BlendMotion(ref Vector3 motion, float deltaTime) { }

	public override void BlindFire(int b) { }

	public void CalculateMotionShortage() { }

	public override void Cancel() { }

	public override void ChangePose(float poseDelta) { }

	public override void ChangeSpeed(float speedDelta) { }

	public Vector3 ClampRotation(Vector3 deltaRotation) { }

	public override void DropStationary() { }

	public override void EnableBreath(bool enable) { }

	public override void EnableSprint(bool enable, bool isToggle = false) { }

	public override void Examine(bool enabled, Action action) { }

	public override void ExecuteDoorInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback, Player user) { }

	public override bool get_CanLoot() { }

	[CompilerGenerated]
	public Vector2 get_Direction() { }

	protected float get_FreefallTime() { }

	public override void Jump() { }

	public override void Kick() { }

	protected override void LimitMotion(ref Vector3 motion, float deltaTime) { }

	public override void Loot(bool enabled) { }

	protected override void ManualAnimatorMoveUpdate(float deltaTime) { }

	public override void Move(Vector2 direction) { }

	public override void OnInteraction() { }

	public override void OnInventory(bool enable) { }

	public override void OnReload(bool enable) { }

	public virtual void OnStateEnter(float normalizedTime) { }

	public virtual void OnStateExit(float normalizedTime) { }

	public virtual void OnStateMove(float normalizedTime) { }

	public override void OnThrow(bool enable) { }

	public override void Pickup(bool enabled, Action action) { }

	public override void Plant(bool enabled, bool multitool, float plantTime, Action action) { }

	protected override void ProcessAnimatorMovement(float deltaTime) { }

	protected override void ProcessRotation(float deltaTime) { }

	protected override void ProcessUpperbodyRotation(float deltaTime, bool isAi) { }

	public override void Prone() { }

	public override void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	[CompilerGenerated]
	public void set_Direction(Vector2 value) { }

	public virtual void set_DisableRootMotion(bool value) { }

	protected void set_FreefallTime(float value) { }

	public override void SetBlindFireAnim(float blindFire) { }

	public override void SetStep(int step) { }

	public override void SetTilt(float tilt) { }

	public void StartDoorInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback) { }

	protected void UpdateRotationSpeed(float deltaTime) { }

	public override void Vaulting() { }

}

