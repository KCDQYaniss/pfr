//Type is in global namespace

[ExecuteInEditMode]
public class RotateAround : MonoBehaviour
{
	public Transform target; //Field offset: 0x20
	public bool autoRotate; //Field offset: 0x28
	[Range(0, 1)]
	public float value; //Field offset: 0x2C
	private Vector3 initialPosition; //Field offset: 0x30
	private Quaternion initialRotation; //Field offset: 0x3C
	private bool hasInitialized; //Field offset: 0x4C

	public RotateAround() { }

	private void OnEnable() { }

	private void Update() { }

}

