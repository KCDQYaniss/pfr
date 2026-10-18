namespace EFT.WeaponMountingStates;

public sealed class IdleWeaponMountingState : MovementState
{
	private const float MAX_MOUNTING_POINT_OFFSET = -0.1; //Field offset: 0x0
	private const float POSSIBLE_POSITON_DELTASQR = 0.008; //Field offset: 0x0
	private const float DOWN_PITCH_CHECKER_RAY_DIST = 0.04; //Field offset: 0x0
	private const float DOWN_PITCH_LIMITATION_THRESHOLD = 2; //Field offset: 0x0
	private readonly IMountingMovementSettings _movementSettings; //Field offset: 0xA0
	private readonly Player _player; //Field offset: 0xA8
	private PlayerMountingPointData _mountingPointData; //Field offset: 0xB0
	private Vector2 _startHandsRotation; //Field offset: 0xB8
	private Quaternion _startBodyRotation; //Field offset: 0xC0
	private float _timer; //Field offset: 0xD0
	private Vector3 _startPos; //Field offset: 0xD4
	private bool _cachedCompass; //Field offset: 0xE0
	private float _targetPitchAngle; //Field offset: 0xE4
	private float _targetYawAngle; //Field offset: 0xE8
	private float _startingTilt; //Field offset: 0xEC
	private float _targetTilt; //Field offset: 0xF0
	private int _mountSideDirection; //Field offset: 0xF4
	private float _enterRotation; //Field offset: 0xF8
	private float _currentRotation; //Field offset: 0xFC
	private float _maxRotation; //Field offset: 0x100
	private bool _exiting; //Field offset: 0x104
	private float _currentDownLimit; //Field offset: 0x108
	private bool _downLimitSetted; //Field offset: 0x10C
	private Ray _dynamicDownLimitRay; //Field offset: 0x110

	private float DownPitchLimit
	{
		private get { } //Length: 9
	}

	private float UpPitchLimit
	{
		private get { } //Length: 31
	}

	public IdleWeaponMountingState(MovementContext movementContext, Player player) { }

	public virtual void BlindFire(int b) { }

	private void CalculateDynamicDownLimit() { }

	public virtual void ChangePose(float poseDelta) { }

	public virtual void ChangeSpeed(float speedDelta) { }

	public virtual void EnableBreath(bool enable) { }

	public virtual void EnableSprint(bool enable, bool isToggle = false) { }

	public virtual void Enter(bool isFromSameState) { }

	public virtual void Exit(bool toSameState) { }

	private float get_DownPitchLimit() { }

	private float get_UpPitchLimit() { }

	public virtual void Jump() { }

	protected virtual void ManualAnimatorMoveUpdate(float deltaTime) { }

	public virtual void Move(Vector2 direction) { }

	public virtual void Prone() { }

	public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false) { }

	public virtual void SetBlindFireAnim(float blindFire) { }

	public virtual void SetStep(int step) { }

	public virtual void SetTilt(float tilt) { }

	public void StartExiting() { }

	private void TryApproachTargetPosition(float deltaTime) { }

	private void UpdateCurrentTilt(float currentRotationFactor) { }

	private void UpdatePlayerBody() { }

	private void UpdatePoseLevel() { }

	public virtual void Vaulting() { }

}

