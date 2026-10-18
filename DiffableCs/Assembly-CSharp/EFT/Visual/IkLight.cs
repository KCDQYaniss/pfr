namespace EFT.Visual;

public class IkLight : MonoBehaviour
{
	[CanBeNull]
	[SerializeField]
	public Light Light; //Field offset: 0x20
	[CanBeNull]
	[SerializeField]
	public FlareLight FlareLight; //Field offset: 0x28
	private float _prevIntensity; //Field offset: 0x30

	private CameraManager CameraManager
	{
		private get { } //Length: 69
	}

	private OpticCameraManager OpticCameraManager
	{
		private get { } //Length: 84
	}

	public IkLight() { }

	private void Awake() { }

	private CameraManager get_CameraManager() { }

	private OpticCameraManager get_OpticCameraManager() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPreCullLight(Camera cam) { }

	private void OnValidate() { }

}

