//Type is in global namespace

public class PlayerOverlapManager : MonoBehaviour
{
	internal enum EExtrusionCollider
	{
		Default = 0,
		Prone = 1,
	}

	[SerializeField]
	private ColliderExtrusion _headColliderExtrusion; //Field offset: 0x20
	[SerializeField]
	private ColliderExtrusion _cameraColliderExtrusion; //Field offset: 0x28
	[SerializeField]
	private Collider[] _headColliders; //Field offset: 0x30
	[SerializeField]
	private Transform _proneColliderPivot; //Field offset: 0x38
	private Vector3 _colliderExtrusionOffset; //Field offset: 0x40
	private EExtrusionCollider _lastSetCollider; //Field offset: 0x4C

	public Collider CameraCollider
	{
		 get { } //Length: 27
	}

	public Collider Collider
	{
		 get { } //Length: 27
	}

	public PlayerOverlapManager() { }

	public void Calculate(Vector3 motion) { }

	public void Calculate(Vector3 motion, Quaternion rotation) { }

	public void ExtrudeCamera() { }

	public Collider get_CameraCollider() { }

	public Collider get_Collider() { }

	public Vector3 GetOffset() { }

	public Vector3 GetOffsetXZ() { }

	public void IgnoreCollider(Collider collider, bool ignore = true) { }

	public void Init(Collider playerCollider) { }

	public bool IsHeadCollider(Collider colliderForCheck) { }

	public void Off() { }

	public void On() { }

	public void SetCollider(EExtrusionCollider colliderIndex) { }

	private void UpdateProneColliderPosition() { }

}

