//Type is in global namespace

[AddComponentMenu("Scripts/Game/Components/LevelSettings")]
public class LevelSettings : MonoBehaviour, ISettings
{
	private static readonly int _directionLightShadow; //Field offset: 0x0
	private static readonly int _waterLevel; //Field offset: 0x4
	private static readonly int _topHorizontSkyColor; //Field offset: 0x8
	private static readonly int _minAmbientColor; //Field offset: 0xC
	private static readonly int _SSRFactorId; //Field offset: 0x10
	public PrismPreset PrismPresetPrefab; //Field offset: 0x20
	public PostProcessProfile PostProcessProfilePrefab; //Field offset: 0x28
	private IEnumerable allTreeWind; //Field offset: 0x30
	public Camera CameraPrefab; //Field offset: 0x38
	public Material skybox; //Field offset: 0x40
	public Bounds RainBounds; //Field offset: 0x48
	[Header("Ambient")]
	public AmbientMode AmbientMode; //Field offset: 0x60
	public Color SkyColor; //Field offset: 0x64
	public Color EquatorColor; //Field offset: 0x74
	public Color GroundColor; //Field offset: 0x84
	public float AmbientIntensity; //Field offset: 0x94
	[Header("NightVisionAmbient")]
	public Color NightVisionSkyColor; //Field offset: 0x98
	public Color NightVisionEquatorColor; //Field offset: 0xA8
	public Color NightVisionGroundColor; //Field offset: 0xB8
	public float NightVisionAmbientIntensity; //Field offset: 0xC8
	[SerializeField]
	[Space]
	private Color _minSmokeAmbientColor; //Field offset: 0xCC
	public float SSRFactor; //Field offset: 0xDC
	[Header("Fog")]
	public bool fog; //Field offset: 0xE0
	public Color fogColor; //Field offset: 0xE4
	public float fogDensity; //Field offset: 0xF4
	public float fogEndDistance; //Field offset: 0xF8
	public FogMode fogMode; //Field offset: 0xFC
	public float fogStartDistance; //Field offset: 0x100
	[Header("Sun")]
	public Color SunColor; //Field offset: 0x104
	public float SunScratchesIntensity; //Field offset: 0x114
	public float SunShaftsIntensity; //Field offset: 0x118
	public float SunShaftsDensity; //Field offset: 0x11C
	public bool SunLensFlares; //Field offset: 0x120
	public bool SunBackGroung; //Field offset: 0x121
	public float LyingWater; //Field offset: 0x124
	[Range(0, 1)]
	public float DirectionLightShadowForUnshadowedShaders; //Field offset: 0x128
	public float DistantShadowOffset; //Field offset: 0x12C
	public float DistantShadowFarPlane; //Field offset: 0x130
	[Header("Scattering")]
	[Range(0, 1)]
	public float HeightFalloff; //Field offset: 0x134
	public float ZeroLevel; //Field offset: 0x138
	[Header("Compass")]
	[Range(0, 360)]
	[SerializeField]
	private float _northDirection; //Field offset: 0x13C
	[SerializeField]
	public Vector4 MaxMapTextureMemory; //Field offset: 0x140
	[CompilerGenerated]
	private AmbientType <AmbientType>k__BackingField; //Field offset: 0x150
	private Action _antiAliasingBinding; //Field offset: 0x158
	private Color ambientLight_temp; //Field offset: 0x160
	private float flareStrength_temp; //Field offset: 0x170
	private bool fog_temp; //Field offset: 0x174
	private Color fogColor_temp; //Field offset: 0x178
	private float fogDensity_temp; //Field offset: 0x188
	private float fogEndDistance_temp; //Field offset: 0x18C
	private FogMode fogMode_temp; //Field offset: 0x190
	private float fogStartDistance_temp; //Field offset: 0x194
	private float haloStrength_temp; //Field offset: 0x198
	private Material skybox_temp; //Field offset: 0x1A0
	[SerializeField]
	[Space]
	private VolumeRenderConfig _volumeRenderConfig; //Field offset: 0x1A8

	public AmbientType AmbientType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private override Camera EFT.CameraControl.CameraManager.ISettings.CameraPrefab
	{
		private get { } //Length: 5
	}

	private override PostProcessProfile EFT.CameraControl.CameraManager.ISettings.PostProcessProfilePrefab
	{
		private get { } //Length: 5
	}

	private override PrismPreset EFT.CameraControl.CameraManager.ISettings.PrismPresetPrefab
	{
		private get { } //Length: 5
	}

	protected bool isTaaHighEnabled
	{
		 get { } //Length: 213
	}

	public float NorthDirection
	{
		 get { } //Length: 9
	}

	public Vector3 NorthVector
	{
		 get { } //Length: 651
	}

	public VolumeRenderConfig VolumeRenderConfig
	{
		 get { } //Length: 8
	}

	private static LevelSettings() { }

	public LevelSettings() { }

	[CompilerGenerated]
	private void <OnPostLoadingScene>b__74_0(EAntialiasingMode x) { }

	public void ApplySettings() { }

	public void ApplyTreeWindSettings() { }

	private void Awake() { }

	private override Camera EFT.CameraControl.CameraManager.ISettings.get_CameraPrefab() { }

	private override PostProcessProfile EFT.CameraControl.CameraManager.ISettings.get_PostProcessProfilePrefab() { }

	private override PrismPreset EFT.CameraControl.CameraManager.ISettings.get_PrismPresetPrefab() { }

	[CompilerGenerated]
	public AmbientType get_AmbientType() { }

	protected bool get_isTaaHighEnabled() { }

	public float get_NorthDirection() { }

	public Vector3 get_NorthVector() { }

	public VolumeRenderConfig get_VolumeRenderConfig() { }

	public void GetSceneParameters() { }

	public void OnDestroy() { }

	public void OnPostLoadingScene() { }

	private void OnPreCullCallback(Camera cam) { }

	private void OnTaaChange() { }

	[CompilerGenerated]
	public void set_AmbientType(AmbientType value) { }

	private void SetMotionVectorsToAllTree() { }

	private void UnBindAntiAliasing() { }

}

