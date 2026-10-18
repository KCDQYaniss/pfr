namespace EFT.Animations;

public class PlayerSpring : MonoBehaviour
{
	[HideInInspector]
	public AimPlane DefaultAimPlane; //Field offset: 0x20
	[HideInInspector]
	public AimPlane[] CustomAimPlanes; //Field offset: 0x28
	[HideInInspector]
	public AimPlane FarPlane; //Field offset: 0x30
	public Spring HandsPosition; //Field offset: 0x38
	public Spring HandsRotation; //Field offset: 0x40
	public Spring CameraRotation; //Field offset: 0x48
	public Spring CameraPosition; //Field offset: 0x50
	public BetterSpring SwaySpring; //Field offset: 0x58
	public Transform TrackingTransform; //Field offset: 0x60
	public Transform WeaponRootAnim; //Field offset: 0x68
	public Transform CameraTransform; //Field offset: 0x70
	public Transform WeaponRoot; //Field offset: 0x78
	public Transform Weapon; //Field offset: 0x80
	public Transform Fireport; //Field offset: 0x88
	public Transform CameraAnimatedFP; //Field offset: 0x90
	public Transform CameraAnimatedTP; //Field offset: 0x98
	public Vector3 RotationCenter; //Field offset: 0xA0
	public Vector3 RotationCenterWoStock; //Field offset: 0xAC
	public Vector3 RecoilPivot; //Field offset: 0xB8
	public Vector3 MountingRotationCenter; //Field offset: 0xC4
	public Vector3 MountingRotationCenterBipods; //Field offset: 0xD0
	public Vector3 CameraOffset; //Field offset: 0xDC
	public Transform RootJoint; //Field offset: 0xE8

	public PlayerSpring() { }

	private void Start() { }

}

