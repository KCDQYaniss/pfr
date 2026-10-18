//Type is in global namespace

public class MenuCameraResolutionFixer : MonoBehaviour
{
	private Camera _currentCamera; //Field offset: 0x20
	private CameraManager _cameraManager; //Field offset: 0x28

	public MenuCameraResolutionFixer() { }

	private void Awake() { }

	private void OnPreCull() { }

}

