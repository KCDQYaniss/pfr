//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class HdrModeSwitcher : MonoBehaviour
{
	[SerializeField]
	private CameraHDRMode HdrMode; //Field offset: 0x20
	private CameraHDRMode _lastMode; //Field offset: 0x24

	public HdrModeSwitcher() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	private void SetMode(CameraHDRMode hdrMode) { }

}

