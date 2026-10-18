//Type is in global namespace

public class ParticleForceFieldsDemo_CameraRig : MonoBehaviour
{
	public Transform pivot; //Field offset: 0x20
	private Vector3 targetRotation; //Field offset: 0x28
	[Range(0, 90)]
	public float rotationLimit; //Field offset: 0x34
	public float rotationSpeed; //Field offset: 0x38
	public float rotationLerpSpeed; //Field offset: 0x3C
	private Vector3 startRotation; //Field offset: 0x40

	public ParticleForceFieldsDemo_CameraRig() { }

	private void Start() { }

	private void Update() { }

}

