//Type is in global namespace

public class SingleFlareController : MonoBehaviour
{
	private Camera _camera; //Field offset: 0x20
	[SerializeField]
	private float _changeSpeed; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	private float _minAngle; //Field offset: 0x2C
	[FormerlySerializedAs("Light")]
	[SerializeField]
	private FlareLight _light; //Field offset: 0x30

	public SingleFlareController() { }

	private void GrabCamera() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static float Remap(float value, float inMin, float inMax) { }

	private void Update() { }

}

