namespace EFT.CameraControl;

[ExecuteAlways]
public class OpticComponentUpdater : MonoBehaviour
{
	private Transform cameraPivot; //Field offset: 0x20
	private Camera opticCamera; //Field offset: 0x28
	private ChromaticAberration chromaticAberration; //Field offset: 0x30
	private BloomOptimized bloomOptimized; //Field offset: 0x38
	private ThermalVision thermalVision; //Field offset: 0x40
	private CC_FastVignette fastVignette; //Field offset: 0x48
	private UltimateBloom ultimateBloom; //Field offset: 0x50
	private Tonemapping tonemapping; //Field offset: 0x58
	private NightVision nightVision; //Field offset: 0x60
	private Fisheye fisheye; //Field offset: 0x68
	private OpticCullingMask opticCullingMask; //Field offset: 0x70
	private TOD_Scattering mainScattering; //Field offset: 0x78
	private MBOIT_Scattering mainMBOITScattering; //Field offset: 0x80
	private Undithering mainUndithering; //Field offset: 0x88
	private PostProcessLayer mainPostProcessLayer; //Field offset: 0x90
	private VolumetricLightRenderer mainVolumetricLightRenderer; //Field offset: 0x98
	private TOD_Scattering scattering; //Field offset: 0xA0
	private MBOIT_Scattering mboitScattering; //Field offset: 0xA8
	private Undithering undithering; //Field offset: 0xB0
	private PostProcessLayer postProcessLayer; //Field offset: 0xB8
	private VolumetricLightRenderer volumetricLightRenderer; //Field offset: 0xC0
	private CameraLodBiasController cameraLodBiasController; //Field offset: 0xC8
	private int _cachedOpticId; //Field offset: 0xD0
	private float _opticSightFov; //Field offset: 0xD4
	private OpticSight _opticSight; //Field offset: 0xD8
	private ScopeZoomHandler _scopeZoomHandler; //Field offset: 0xE0
	public float OpticScatterReductionStrength; //Field offset: 0xE8

	public Camera MainCamera
	{
		 get { } //Length: 84
	}

	public OpticComponentUpdater() { }

	private void Awake() { }

	public void Clear() { }

	public void CopyComponentFromOptic(OpticSight opticSight) { }

	public Camera get_MainCamera() { }

	private void GetMainCameraComponents() { }

	public void LateUpdate() { }

	private void OnDestroy() { }

	public void SetPivot(Transform pivot) { }

}

