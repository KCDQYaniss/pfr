namespace EFT.Weather;

[ExecuteAlways]
public class TODSkySimple : MonoBehaviourSingleton, ITODSky
{
	private struct SphericalHarmonicsContainer
	{
		public SphericalHarmonicsL2 FullSH; //Field offset: 0x0
		public SphericalHarmonicsL2 SHWithoutTop; //Field offset: 0x6C

	}

	private static readonly int _globalReflectionProbeId; //Field offset: 0x0
	private const float THRESHOLD = 0.1; //Field offset: 0x0
	private const float AMBIENT_CLOUDINESS_COLOR_RATIO = 0.333; //Field offset: 0x0
	private const string USE_SIMPLE_REFLECTION_PROBE = "USE_SIMPLE_REFLECTION_PROBE"; //Field offset: 0x0
	private static readonly int _todLightDirectionId; //Field offset: 0x4
	private static readonly int _todLightColorId; //Field offset: 0x8
	private readonly Color _environmentColor; //Field offset: 0x20
	private readonly float[] _qualityUpdateIntervals; //Field offset: 0x30
	private Color _lightSourceColor; //Field offset: 0x38
	private TOD_Time _currentTime; //Field offset: 0x48
	[Space]
	public Cubemap AtmosphereCubemap; //Field offset: 0x50
	public Light LightSource; //Field offset: 0x58
	public AmbientLight AmbientLight; //Field offset: 0x60
	[Header("Static Scattering")]
	[SerializeField]
	private Color _sunSkyColor; //Field offset: 0x68
	[SerializeField]
	private Color _moonSkyColor; //Field offset: 0x78
	[SerializeField]
	private Color _groundColor; //Field offset: 0x88
	[SerializeField]
	private TOD_AtmosphereParameters _atmosphere; //Field offset: 0x98
	[Space]
	public Gradient LightColorGradient; //Field offset: 0xA0
	public Gradient AddTopAmbient; //Field offset: 0xA8
	public Gradient AddAmbient; //Field offset: 0xB0
	public Color CloudnessLightColor; //Field offset: 0xB8
	public AnimationCurve BounceHarmonicIntensity; //Field offset: 0xC8
	public AnimationCurve AmbientBrightness; //Field offset: 0xD0
	public AnimationCurve AmbientSaturation; //Field offset: 0xD8
	public AnimationCurve AmbientContrast; //Field offset: 0xE0
	public float HarmonicsDaylight; //Field offset: 0xE8
	[Range(-90, 90)]
	[Space]
	public float Latitude; //Field offset: 0xEC
	[Range(-180, 180)]
	public float Longitude; //Field offset: 0xF0
	[Range(-14, 14)]
	public float UTC; //Field offset: 0xF4
	[CompilerGenerated]
	private float <UpdateInterval>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private float <ClearSky>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private readonly float <ForceIndoor>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private float <SunVisibility>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private bool <IsDay>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private bool <IsNight>k__BackingField; //Field offset: 0x109
	[CompilerGenerated]
	[SerializeField]
	private TOD_CycleParameters <Cycle>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private SphericalHarmonicsL2 <SH>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private Vector3 <SunDirection>k__BackingField; //Field offset: 0x184

	public override TOD_AtmosphereParameters Atmosphere
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public override float ClearSky
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override TOD_Time CurrentTime
	{
		 get { } //Length: 5
	}

	public override TOD_CycleParameters Cycle
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override float ForceIndoor
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public override bool IsDay
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsNight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Light LightObject
	{
		 get { } //Length: 5
	}

	public Transform LightTransform
	{
		 get { } //Length: 90
	}

	public SphericalHarmonicsL2 SH
	{
		[CompilerGenerated]
		 get { } //Length: 91
		[CompilerGenerated]
		 set { } //Length: 88
	}

	public override Vector3 SunDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override float SunVisibility
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override float UpdateInterval
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public VolumetricLight VolumetricLight
	{
		 get { } //Length: 73
	}

	private static TODSkySimple() { }

	public TODSkySimple() { }

	private void ApplyGlobalReflectionProbe() { }

	public virtual void Awake() { }

	private SphericalHarmonicsContainer CalculateSphericalHarmonics(float t, float t01) { }

	private Color ContrastColor(float light, Color color, float t) { }

	private Color ContrastColor(Color color, float t) { }

	public void Dispose() { }

	public override TOD_AtmosphereParameters get_Atmosphere() { }

	[CompilerGenerated]
	public override float get_ClearSky() { }

	public override TOD_Time get_CurrentTime() { }

	[CompilerGenerated]
	public override TOD_CycleParameters get_Cycle() { }

	[CompilerGenerated]
	public override float get_ForceIndoor() { }

	[CompilerGenerated]
	public override bool get_IsDay() { }

	[CompilerGenerated]
	public override bool get_IsNight() { }

	public override Light get_LightObject() { }

	public Transform get_LightTransform() { }

	[CompilerGenerated]
	public SphericalHarmonicsL2 get_SH() { }

	[CompilerGenerated]
	public override Vector3 get_SunDirection() { }

	[CompilerGenerated]
	public override float get_SunVisibility() { }

	[CompilerGenerated]
	public override float get_UpdateInterval() { }

	public VolumetricLight get_VolumetricLight() { }

	public override void Initialize() { }

	public override Vector3 LightDirectionExtrapolated(float addTime) { }

	private Color LimitColor(Color color) { }

	private void OnCameraCreated() { }

	public virtual void OnDestroy() { }

	private void OnGameTimeUpdated() { }

	private Color SaturateColor(Color color, float t) { }

	public void set_Atmosphere(TOD_AtmosphereParameters value) { }

	[CompilerGenerated]
	public override void set_ClearSky(float value) { }

	[CompilerGenerated]
	public void set_Cycle(TOD_CycleParameters value) { }

	[CompilerGenerated]
	public override void set_IsDay(bool value) { }

	[CompilerGenerated]
	public override void set_IsNight(bool value) { }

	[CompilerGenerated]
	public void set_SH(SphericalHarmonicsL2 value) { }

	[CompilerGenerated]
	public override void set_SunDirection(Vector3 value) { }

	[CompilerGenerated]
	public override void set_SunVisibility(float value) { }

	[CompilerGenerated]
	public override void set_UpdateInterval(float value) { }

	public void SetDebugCamera(Camera camera) { }

	private void Start() { }

	private void Update() { }

	private void UpdateSunVisibility() { }

}

