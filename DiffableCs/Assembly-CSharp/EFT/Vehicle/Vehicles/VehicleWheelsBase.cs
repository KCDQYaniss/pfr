namespace EFT.Vehicle.Vehicles;

public class VehicleWheelsBase : MonoBehaviour
{
	private const float MIN_TURN_DIRECTION_SQR = 0.0001; //Field offset: 0x0
	public Transform surfaceChecker; //Field offset: 0x20
	public Transform horizontalAxis; //Field offset: 0x28
	public float diameterWheel; //Field offset: 0x30
	public float maxTurnAngle; //Field offset: 0x34
	public float lerpTurn; //Field offset: 0x38
	public float turnSpeedTrashHold; //Field offset: 0x3C
	public float heightWheel; //Field offset: 0x40
	public float heightMaxPosLimit; //Field offset: 0x44
	public float heightMinPosLimit; //Field offset: 0x48
	public float heightOffset; //Field offset: 0x4C
	public float snapDeltaThreshold; //Field offset: 0x50
	private bool _turnOn; //Field offset: 0x54
	private bool _rotateOn; //Field offset: 0x55
	private bool _rotateForward; //Field offset: 0x56
	private float _vehicleSpeed; //Field offset: 0x58
	private Vector3 _previousPosition; //Field offset: 0x5C
	private Quaternion _defaultRotation; //Field offset: 0x68
	private Vector3 _mainDirectionSumm; //Field offset: 0x78
	private int _stackDirectionCount; //Field offset: 0x84
	private int _stackDirectionCapacity; //Field offset: 0x88
	public float lerpToTargetHeight; //Field offset: 0x8C
	public float snapToSurfaceTimer; //Field offset: 0x90
	private float _snapToSurfaceTimerTemp; //Field offset: 0x94
	private float _targetWheelHeight; //Field offset: 0x98
	private float _targetWheelHeightDefault; //Field offset: 0x9C
	private Transform _transformCache; //Field offset: 0xA0
	private RaycastHit[] snapHitInfo; //Field offset: 0xA8

	public VehicleWheelsBase() { }

	private void Awake() { }

	private Vector3 CalculateMainWheelDirection(Vector3 newDirection) { }

	private void CalculateTargetWheelHeight() { }

	private void RotateBySpeed() { }

	public void RotateWheel(bool rotateOn, bool rotateForward, float vehicleSpeed, bool turnOn = false, VehicleWheelsBase linkWheel = null) { }

	public void SetWheelSettings(float diameter, float height, float offset, float heightWheelMax, float heightWheelMin, float snapToSurfaceSpeed, float checkSurfaceForWheelsTimer) { }

	private void SnapToSurface() { }

	private void TurnToDefault() { }

	private void Update() { }

}

