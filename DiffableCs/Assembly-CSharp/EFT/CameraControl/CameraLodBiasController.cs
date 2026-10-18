namespace EFT.CameraControl;

public class CameraLodBiasController : MonoBehaviour
{
	[SerializeField]
	public float LodBiasFactor; //Field offset: 0x20
	private float MaxFov; //Field offset: 0x24
	private float originalLodBias; //Field offset: 0x28

	public CameraLodBiasController() { }

	public void Awake() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	public void SetBiasByFov(float fov) { }

	public void SetMaxFov(float fov) { }

}

