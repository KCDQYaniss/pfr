//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class VolumetricLightRenderer : MonoBehaviour
{
	internal enum VolumtericResolution
	{
		Full = 0,
		Half = 1,
		Quarter = 2,
	}

	private static List _lights; //Field offset: 0x0
	private static Mesh _pointLightMesh; //Field offset: 0x8
	private static Mesh _spotLightMesh; //Field offset: 0x10
	private static Material _lightMaterial; //Field offset: 0x18
	private static Texture _defaultSpotCookie; //Field offset: 0x20
	private static Texture2D _ditheringTexture; //Field offset: 0x28
	private static Texture3D _noiseTexture; //Field offset: 0x30
	private static bool _opticTexturesInited; //Field offset: 0x38
	private static int _opticTexturesUsedSize; //Field offset: 0x3C
	private static RenderTexture _opticVolumeLightTexture; //Field offset: 0x40
	private static RenderTexture _opticHalfVolumeLightTexture; //Field offset: 0x48
	private static RenderTexture _opticHalfDepthBuffer; //Field offset: 0x50
	private static RenderTexture _opticQuarterVolumeLightTexture; //Field offset: 0x58
	private static RenderTexture _opticQuarterDepthBuffer; //Field offset: 0x60
	private static readonly int _halfResDepthBuffer; //Field offset: 0x68
	private static readonly int _halfResColor; //Field offset: 0x6C
	private static readonly int _quarterResDepthBuffer; //Field offset: 0x70
	private static readonly int _quarterResColor; //Field offset: 0x74
	private static readonly int _ditherTexture; //Field offset: 0x78
	private static readonly int _texture; //Field offset: 0x7C
	private static readonly int _volumetricTexId; //Field offset: 0x80
	public bool IsOn; //Field offset: 0x20
	public bool IsOptic; //Field offset: 0x21
	private Camera _camera; //Field offset: 0x28
	private SSAA _ssaa; //Field offset: 0x30
	private CommandBuffer _preLightPass; //Field offset: 0x38
	private CommandBuffer _postRenderPass; //Field offset: 0x40
	private Matrix4x4 _viewProj; //Field offset: 0x48
	private Material _blitAddMaterial; //Field offset: 0x88
	private Material _bilateralBlurMaterial; //Field offset: 0x90
	private RenderTexture _volumeLightTexture; //Field offset: 0x98
	private RenderTexture _halfVolumeLightTexture; //Field offset: 0xA0
	private RenderTexture _quarterVolumeLightTexture; //Field offset: 0xA8
	private RenderTexture _halfDepthBuffer; //Field offset: 0xB0
	private RenderTexture _quarterDepthBuffer; //Field offset: 0xB8
	private VolumtericResolution _currentResolution; //Field offset: 0xC0
	public VolumtericResolution Resolution; //Field offset: 0xC4
	public Texture DefaultSpotCookie; //Field offset: 0xC8
	private Matrix4x4 _proj; //Field offset: 0xD0
	private bool _isNeedToRecreateRT; //Field offset: 0x110
	private bool _isNeedToRecreateOpticRT; //Field offset: 0x111

	public CommandBuffer GlobalCommandBuffer
	{
		 get { } //Length: 5
	}

	public List Lights
	{
		 get { } //Length: 83
	}

	private static VolumetricLightRenderer() { }

	public VolumetricLightRenderer() { }

	public static void AddLight(VolumetricLight light) { }

	private void Awake() { }

	private void CleanOpticRT() { }

	private void CleanRT() { }

	private void CreateOpticVolumetricRenderTexture(int opticResolution) { }

	private Mesh CreateSpotLightMesh() { }

	private void CreateVolumetricRenderTextures() { }

	private void GenerateDitherTexture() { }

	public CommandBuffer get_GlobalCommandBuffer() { }

	public List get_Lights() { }

	public static Texture GetDefaultSpotCookie() { }

	public static Material GetLightMaterial() { }

	public static Mesh GetPointLightMesh() { }

	public static Mesh GetSpotLightMesh() { }

	public RenderTexture GetVolumeLightBuffer() { }

	public RenderTexture GetVolumeLightDepthBuffer() { }

	private void InitPostRenderPass() { }

	private void InitPrePass() { }

	private void LoadNoise3dTexture() { }

	private void OnDestroy() { }

	public void OnPreRender() { }

	private void RecreateRTsIfNeeded() { }

	public static void RemoveLight(VolumetricLight light) { }

	private void SetOpticTextures() { }

	private void Update() { }

	private void UpdateMaterialParameters() { }

}

