//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Light))]
public class VolumetricLight : MonoBehaviour
{
	private static readonly int _sampleCount; //Field offset: 0x0
	private static readonly int _noiseVelocity; //Field offset: 0x4
	private static readonly int _noiseData; //Field offset: 0x8
	private static readonly int _mieG; //Field offset: 0xC
	private static readonly int _volumetricLight; //Field offset: 0x10
	private static readonly int _zTest; //Field offset: 0x14
	private static readonly int _heightFog; //Field offset: 0x18
	private static readonly int _cameraForward; //Field offset: 0x1C
	private static readonly int _cameraDepthTexture; //Field offset: 0x20
	private static readonly int _lightTexture0; //Field offset: 0x24
	private static readonly int _lightPos; //Field offset: 0x28
	private static readonly int _myLightMatrix0; //Field offset: 0x2C
	private static readonly int _worldViewProj; //Field offset: 0x30
	private static readonly int _worldView; //Field offset: 0x34
	private static readonly int _lightColor; //Field offset: 0x38
	private static readonly int _cosAngle; //Field offset: 0x3C
	private static readonly int _planeD; //Field offset: 0x40
	private static readonly int _coneApex; //Field offset: 0x44
	private static readonly int _coneAxis; //Field offset: 0x48
	private static readonly int _myWorld2Shadow; //Field offset: 0x4C
	private static readonly int _maxRayLength; //Field offset: 0x50
	private static readonly int _lightDir; //Field offset: 0x54
	private static readonly int _corners; //Field offset: 0x58
	private static readonly int _shadowStrength; //Field offset: 0x5C
	[CompilerGenerated]
	private bool <NeedToPrerender>k__BackingField; //Field offset: 0x20
	private Light _light; //Field offset: 0x28
	private Shader _shader; //Field offset: 0x30
	private Material _material; //Field offset: 0x38
	private CommandBuffer _commandBuffer; //Field offset: 0x40
	private CommandBuffer _cascadeShadowCommandBuffer; //Field offset: 0x48
	[Range(1, 64)]
	public int SampleCount; //Field offset: 0x50
	[Range(0, 1)]
	public float ScatteringCoef; //Field offset: 0x54
	[Range(0, 0.1)]
	public float ExtinctionCoef; //Field offset: 0x58
	[Range(0, 1)]
	public float SkyboxExtinctionCoef; //Field offset: 0x5C
	[Range(0, 0.999)]
	public float MieG; //Field offset: 0x60
	public bool HeightFog; //Field offset: 0x64
	[Range(0, 0.5)]
	public float HeightScale; //Field offset: 0x68
	public float GroundLevel; //Field offset: 0x6C
	public bool Noise; //Field offset: 0x70
	public float NoiseScale; //Field offset: 0x74
	public float NoiseIntensity; //Field offset: 0x78
	public float NoiseIntensityOffset; //Field offset: 0x7C
	public Vector2 NoiseVelocity; //Field offset: 0x80
	[Tooltip(null)]
	public float MaxRayLength; //Field offset: 0x88
	private Vector4[] _frustumCorners; //Field offset: 0x90
	private bool _reversedZ; //Field offset: 0x98
	private bool _weaponFlashlight; //Field offset: 0x99
	private Vector3 _lastPosition; //Field offset: 0x9C
	private Quaternion _lastRotation; //Field offset: 0xA8
	private float _scale; //Field offset: 0xB8
	private float _angleScale; //Field offset: 0xBC
	private Matrix4x4 _world; //Field offset: 0xC0
	private Matrix4x4 _view; //Field offset: 0x100
	private Matrix4x4 _clip; //Field offset: 0x140
	private Matrix4x4 _shadowClip; //Field offset: 0x180
	private Matrix4x4 _proj; //Field offset: 0x1C0
	private Matrix4x4 _shadowProj; //Field offset: 0x200
	private Matrix4x4 _tmpMatrix; //Field offset: 0x240
	private Matrix4x4 _shadowView; //Field offset: 0x280
	private Vector3 _apex; //Field offset: 0x2C0
	private Vector3 _axis; //Field offset: 0x2CC
	private Mesh _mesh; //Field offset: 0x2D8

	public Light Light
	{
		 get { } //Length: 5
	}

	public private bool NeedToPrerender
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Material VolumetricMaterial
	{
		 get { } //Length: 5
	}

	private static VolumetricLight() { }

	public VolumetricLight() { }

	private void Awake() { }

	public void CheckIntensity() { }

	private void ClearCommandBuffer() { }

	private void CreateCommandBuffer() { }

	private void CreateShaderAndMaterial() { }

	public Light get_Light() { }

	[CompilerGenerated]
	public bool get_NeedToPrerender() { }

	public Material get_VolumetricMaterial() { }

	private bool IsCameraInPointLightBounds() { }

	private bool IsCameraInSpotLightBounds() { }

	public void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public static void RefreshAll() { }

	[CompilerGenerated]
	private void set_NeedToPrerender(bool value) { }

	private void SetDefaultDirectionalLightValues() { }

	private void SetDefaultLightValues() { }

	private void SetDefaultPointLightValues() { }

	private void SetDefaultSpotLightValues() { }

	private void SetDefaultValues() { }

	private void SetDynamicDirectionalLightValues() { }

	private void SetDynamicLightValues() { }

	private void SetDynamicPointLightValues() { }

	private void SetDynamicSpotLightValues() { }

	private void SetupDirectionalLight(VolumetricLightRenderer renderer, Matrix4x4 viewProj) { }

	private void SetupPointLight(VolumetricLightRenderer renderer, Matrix4x4 viewProj) { }

	private void SetupSpotLight(VolumetricLightRenderer renderer, Matrix4x4 viewProj) { }

	public void SetWeaponFlashlight() { }

	public void VolumetricLightPreRender(VolumetricLightRenderer renderer, Matrix4x4 viewProj) { }

}

