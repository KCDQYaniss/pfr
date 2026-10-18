namespace EFT;

[DefaultExecutionOrder(1)]
public class NPCCurveToHeadLook : MonoBehaviour
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
	private Transform _headBone; //Field offset: 0x28
	[SerializeField]
	private string _curveName; //Field offset: 0x30
	[SerializeField]
	private Transform _targetTransform; //Field offset: 0x38
	[Header("Rotation Settings")]
	[SerializeField]
	private ForwardAxis _forwardAxis; //Field offset: 0x40
	[Range(0, 180)]
	[SerializeField]
	private float _maxHorizontalAngle; //Field offset: 0x44
	[Range(0, 180)]
	[SerializeField]
	private float _maxVerticalAngle; //Field offset: 0x48
	private int _curveHash; //Field offset: 0x4C
	private Quaternion _targetRotation; //Field offset: 0x50

	public NPCCurveToHeadLook() { }

	private Quaternion ClampRotation(Quaternion rotation, Quaternion originalRotation) { }

	private static Quaternion GetLookRotationForAxis(Vector3 direction, ForwardAxis forwardAxis) { }

	private void LateUpdate() { }

	public void OnEnter(EftGamePlayerOwner owner, Transform cameraTransform) { }

	private void Start() { }

}

