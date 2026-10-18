namespace EFT.Interactive;

public class SniperWeaponView : MonoBehaviour
{
	[Header("Rotation Settings")]
	[SerializeField]
	private bool _enableHorizontalRotation; //Field offset: 0x20
	[SerializeField]
	private bool _enableVerticalRotation; //Field offset: 0x21
	[SerializeField]
	private float _horizontalAvailableRotation; //Field offset: 0x24
	[SerializeField]
	private float _verticalAvailableRotation; //Field offset: 0x28
	[SerializeField]
	private Transform _fireport; //Field offset: 0x30
	[SerializeField]
	private Transform _rotationObject; //Field offset: 0x38
	[Header("VFX")]
	[SerializeField]
	private FirearmsEffects _muzzleFlashEffect; //Field offset: 0x40
	private Quaternion _baseRotation; //Field offset: 0x48
	private Vector3 _baseEulerAngles; //Field offset: 0x58

	public Transform Fireport
	{
		 get { } //Length: 76
	}

	public Vector3 Position
	{
		 get { } //Length: 204
	}

	public Quaternion Rotation
	{
		 get { } //Length: 192
	}

	public SniperWeaponView() { }

	private void Awake() { }

	public Transform get_Fireport() { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	public void PlayMuzzleFlash(float sqrDist) { }

	public void RotateTowardsTarget(Vector3 targetPosition, Quaternion offset) { }

}

