namespace EFT.Vehicle;

public class BTRTurretServer : MonoBehaviour
{
	private const float AIM_TUNE_ANGLE = 1.5; //Field offset: 0x0
	private const float DELTA_DOT_PRODUCT_HORIZONTAL = 0.02; //Field offset: 0x0
	private const float DELTA_DOT_PRODUCT_VERTICAL = 0.02; //Field offset: 0x0
	private const float SQRT_DIST_TO_USE_AIM_TUNE_ANGLE = 100; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsCanShoot>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <MachineGunAngleToTarget>k__BackingField; //Field offset: 0x24
	public Transform gunsBlockRoot; //Field offset: 0x28
	public Transform machineGunRoot; //Field offset: 0x30
	public Transform machineGunLaunchPoint; //Field offset: 0x38
	public Transform targetTransform; //Field offset: 0x40
	public float horizontalRotateSpeed; //Field offset: 0x48
	public float verticalRotateSpeed; //Field offset: 0x4C
	public Vector3 defaultAimingPosition; //Field offset: 0x50
	public Vector3 targetPosition; //Field offset: 0x5C
	public Vector2 verticalRotateLimits; //Field offset: 0x68
	private bool _lastHorizontalRotateRight; //Field offset: 0x70
	private bool _lastVerticalRotateUp; //Field offset: 0x71
	private bool _verticalLimitOn; //Field offset: 0x72
	private float _deltaVerticalAfterBlockAngle; //Field offset: 0x74
	[SerializeField]
	private Transform defaultTargetTransform; //Field offset: 0x78

	public private bool IsCanShoot
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float MachineGunAngleToTarget
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BTRTurretServer() { }

	private float CalcDeltaRotateLimits(float value) { }

	private void CalculateMachineGunAngleToTarget() { }

	private void CheckCanShoot() { }

	public bool CheckPositionInAimingZone(Vector3 position) { }

	private bool CheckVerticalRotateLimits(float value) { }

	public void DisableAiming() { }

	public void EnableAimingObject(Transform targetObject) { }

	public void EnableAimingPosition(Vector3 position) { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public bool get_IsCanShoot() { }

	[CompilerGenerated]
	public float get_MachineGunAngleToTarget() { }

	private Vector3 GetTargetPosition() { }

	private void HorizontalRotate() { }

	private void HorizontalRotateToSide(bool rotateRight) { }

	[CompilerGenerated]
	private void set_IsCanShoot(bool value) { }

	[CompilerGenerated]
	private void set_MachineGunAngleToTarget(float value) { }

	private void Start() { }

	private bool TargetInAimingZone() { }

	private void VerticalRotate() { }

	private void VerticalRotateToSide(bool rotateUp) { }

}

