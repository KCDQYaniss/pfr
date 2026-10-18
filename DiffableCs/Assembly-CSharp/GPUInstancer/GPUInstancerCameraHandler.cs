namespace GPUInstancer;

[RequireComponent(typeof(Camera))]
public class GPUInstancerCameraHandler : MonoBehaviour
{
	private Camera _camera; //Field offset: 0x20
	private bool _isCameraSet; //Field offset: 0x28

	public GPUInstancerCameraHandler() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Update() { }

}

