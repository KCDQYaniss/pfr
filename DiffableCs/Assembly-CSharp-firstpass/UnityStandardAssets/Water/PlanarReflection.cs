namespace UnityStandardAssets.Water;

[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]
public class PlanarReflection : MonoBehaviour
{
	public LayerMask reflectionMask; //Field offset: 0x20
	public bool reflectSkybox; //Field offset: 0x24
	public Color clearColor; //Field offset: 0x28
	public string reflectionSampler; //Field offset: 0x38
	public float clipPlaneOffset; //Field offset: 0x40
	private Vector3 m_Oldpos; //Field offset: 0x44
	private Camera m_ReflectionCamera; //Field offset: 0x50
	private Material m_SharedMaterial; //Field offset: 0x58
	private Dictionary m_HelperCameras; //Field offset: 0x60

	public PlanarReflection() { }

	private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane) { }

	private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane) { }

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	private Camera CreateReflectionCameraFor(Camera cam) { }

	private RenderTexture CreateTextureFor(Camera cam) { }

	public void LateUpdate() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void RenderHelpCameras(Camera currentCam) { }

	private void RenderReflectionFor(Camera cam, Camera reflectCamera) { }

	private void SaneCameraSettings(Camera helperCam) { }

	private void SetStandardCameraParameter(Camera cam, LayerMask mask) { }

	private static float Sgn(float a) { }

	public void Start() { }

	public void WaterTileBeingRendered(Transform tr, Camera currentCam) { }

}

