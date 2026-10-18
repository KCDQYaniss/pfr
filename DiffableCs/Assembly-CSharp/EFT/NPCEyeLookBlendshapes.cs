namespace EFT;

[DefaultExecutionOrder(2)]
public class NPCEyeLookBlendshapes : MonoBehaviour
{
	internal enum ForwardAxis
	{
		PositiveX = 0,
		NegativeX = 1,
		PositiveY = 2,
		NegativeY = 3,
		PositiveZ = 4,
		NegativeZ = 5,
	}

	[SerializeField]
	private Animator _animator; //Field offset: 0x20
	[SerializeField]
	private string _curveName; //Field offset: 0x28
	[SerializeField]
	private SkinnedMeshRenderer _faceMeshRenderer; //Field offset: 0x30
	[SerializeField]
	private Transform _headBone; //Field offset: 0x38
	[SerializeField]
	private Transform _targetTransform; //Field offset: 0x40
	[Header("Left Eye Blendshapes")]
	[SerializeField]
	private string _leftEyeLookInName; //Field offset: 0x48
	[SerializeField]
	private string _leftEyeLookOutName; //Field offset: 0x50
	[SerializeField]
	private string _leftEyeLookUpName; //Field offset: 0x58
	[SerializeField]
	private string _leftEyeLookDownName; //Field offset: 0x60
	[Header("Right Eye Blendshapes")]
	[SerializeField]
	private string _rightEyeLookInName; //Field offset: 0x68
	[SerializeField]
	private string _rightEyeLookOutName; //Field offset: 0x70
	[SerializeField]
	private string _rightEyeLookUpName; //Field offset: 0x78
	[SerializeField]
	private string _rightEyeLookDownName; //Field offset: 0x80
	[Header("Eye Settings")]
	[SerializeField]
	private ForwardAxis _forwardAxis; //Field offset: 0x88
	[Range(10, 90)]
	[SerializeField]
	private float _maxHorizontalAngle; //Field offset: 0x8C
	[Range(0, 100)]
	[SerializeField]
	private float _maxHorizontalBlendshapeWeight; //Field offset: 0x90
	[Range(10, 90)]
	[SerializeField]
	private float _maxVerticalAngle; //Field offset: 0x94
	[Range(0, 100)]
	[SerializeField]
	private float _maxVerticalBlendshapeWeight; //Field offset: 0x98
	[Range(0, 100)]
	[SerializeField]
	private float _blendshapeMultiplier; //Field offset: 0x9C
	[SerializeField]
	private float _smoothSpeed; //Field offset: 0xA0
	[Header("Idle Eye Movement")]
	[SerializeField]
	private bool _enableIdleMovement; //Field offset: 0xA4
	[Range(0, 1)]
	[SerializeField]
	private float _idleHorizontalRange; //Field offset: 0xA8
	[Range(0, 1)]
	[SerializeField]
	private float _idleVerticalRange; //Field offset: 0xAC
	[Range(0.1, 5)]
	[SerializeField]
	private float _idleMovementSpeed; //Field offset: 0xB0
	[Range(0, 10)]
	[SerializeField]
	private float _idleChangeInterval; //Field offset: 0xB4
	[Range(0, 5)]
	[SerializeField]
	private float _idleChangeVariation; //Field offset: 0xB8
	[Range(0, 1)]
	[SerializeField]
	private float _idleStrengthDuringTracking; //Field offset: 0xBC
	[Header("Debug")]
	[SerializeField]
	private bool _enableGizmos; //Field offset: 0xC0
	[SerializeField]
	private bool _debugMode; //Field offset: 0xC1
	[Range(0, 1)]
	[SerializeField]
	private float _debugCurveValue; //Field offset: 0xC4
	private int _curveHash; //Field offset: 0xC8
	private int _leftEyeLookInIndex; //Field offset: 0xCC
	private int _leftEyeLookOutIndex; //Field offset: 0xD0
	private int _leftEyeLookUpIndex; //Field offset: 0xD4
	private int _leftEyeLookDownIndex; //Field offset: 0xD8
	private int _rightEyeLookInIndex; //Field offset: 0xDC
	private int _rightEyeLookOutIndex; //Field offset: 0xE0
	private int _rightEyeLookUpIndex; //Field offset: 0xE4
	private int _rightEyeLookDownIndex; //Field offset: 0xE8
	private float _currentLeftHorizontal; //Field offset: 0xEC
	private float _currentLeftVertical; //Field offset: 0xF0
	private float _currentRightHorizontal; //Field offset: 0xF4
	private float _currentRightVertical; //Field offset: 0xF8
	private float _idleHorizontalTarget; //Field offset: 0xFC
	private float _idleVerticalTarget; //Field offset: 0x100
	private float _nextIdleChangeTime; //Field offset: 0x104
	private float _noiseOffsetX; //Field offset: 0x108
	private float _noiseOffsetY; //Field offset: 0x10C

	public NPCEyeLookBlendshapes() { }

	private void ApplyEyeBlendshapes() { }

	private int GetBlendshapeIndex(string blendshapeName) { }

	private Vector3 GetLocalDirectionForAxis(Vector3 worldDirection) { }

	private void InitializeBlendshapeIndices() { }

	private void LateUpdate() { }

	public void OnEnter(EftGamePlayerOwner owner, Transform cameraTransform) { }

	public void ResetEyes() { }

	private void SetBlendshapeWeight(int index, float weight) { }

	private void Start() { }

	private void UpdateIdleMovement() { }

}

