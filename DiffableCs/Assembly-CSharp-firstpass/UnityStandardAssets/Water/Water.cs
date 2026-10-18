namespace UnityStandardAssets.Water;

[ExecuteInEditMode]
public class Water : MonoBehaviour
{
	internal enum WaterMode
	{
		Simple = 0,
		Reflective = 1,
		Refractive = 2,
	}

	private static Dictionary m_ReflectionCameras; //Field offset: 0x0
	private static Dictionary m_RefractionCameras; //Field offset: 0x8
	private static RenderTexture m_ReflectionTexture; //Field offset: 0x10
	private static RenderTexture m_RefractionTexture; //Field offset: 0x18
	private static WaterMode m_HardwareWaterSupport; //Field offset: 0x20
	private static int m_OldReflectionTextureSize; //Field offset: 0x24
	private static int m_OldRefractionTextureSize; //Field offset: 0x28
	private static bool s_InsideWater; //Field offset: 0x2C
	public static Dictionary Rendered; //Field offset: 0x30
	private static readonly int _reflectionTex; //Field offset: 0x38
	private static readonly int _refractionTex; //Field offset: 0x3C
	public Material WaterMaterial; //Field offset: 0x20
	public WaterMode waterMode; //Field offset: 0x28
	public bool disablePixelLights; //Field offset: 0x2C
	public int textureSize; //Field offset: 0x30
	public float clipPlaneOffset; //Field offset: 0x34
	public LayerMask reflectLayers; //Field offset: 0x38
	public LayerMask refractLayers; //Field offset: 0x3C
	public float FarClipPlane; //Field offset: 0x40
	public bool UseOcclusionCulling; //Field offset: 0x44

	private static Water() { }

	public Water() { }

	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane) { }

	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) { }

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera) { }

	private WaterMode FindHardwareWaterSupport() { }

	private WaterMode GetWaterMode() { }

	private void OnDisable() { }

	public void OnWillRenderObject() { }

	private void Update() { }

	private void UpdateCameraModes(Camera src, Camera dest) { }

}

