//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(TOD_Resources))]
[RequireComponent(typeof(TOD_Components))]
public class TOD_Sky : MonoBehaviourSingleton, ITODSky
{
	private const int TOD_SAMPLES = 2; //Field offset: 0x0
	private const float pi = 3.1415927; //Field offset: 0x0
	private const float tau = 6.2831855; //Field offset: 0x0
	private const string USE_SIMPLE_REFLECTION_PROBE = "USE_SIMPLE_REFLECTION_PROBE"; //Field offset: 0x0
	private int probeRenderID; //Field offset: 0x20
	public TOD_ColorSpaceType ColorSpace; //Field offset: 0x24
	public TOD_ColorRangeType ColorRange; //Field offset: 0x28
	public TOD_SkyQualityType SkyQuality; //Field offset: 0x2C
	public TOD_CloudQualityType CloudQuality; //Field offset: 0x30
	public TOD_MeshQualityType MeshQuality; //Field offset: 0x34
	[CompilerGenerated]
	[SerializeField]
	private TOD_CycleParameters <Cycle>k__BackingField; //Field offset: 0x38
	public TOD_WorldParameters World; //Field offset: 0x40
	[CompilerGenerated]
	[SerializeField]
	private TOD_AtmosphereParameters <Atmosphere>k__BackingField; //Field offset: 0x48
	public TOD_DayParameters Day; //Field offset: 0x50
	public TOD_NightParameters Night; //Field offset: 0x58
	public TOD_SunParameters Sun; //Field offset: 0x60
	public TOD_MoonParameters Moon; //Field offset: 0x68
	public TOD_StarParameters Stars; //Field offset: 0x70
	public TOD_LightParameters Light; //Field offset: 0x78
	public TOD_FogParameters Fog; //Field offset: 0x80
	public TOD_AmbientParameters Ambient; //Field offset: 0x88
	public TOD_ReflectionParameters Reflection; //Field offset: 0x90
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private TOD_Components <Components>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private float <SunVisibility>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <ClearSky>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private TOD_Resources <Resources>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <IsDay>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <IsNight>k__BackingField; //Field offset: 0xB9
	[CompilerGenerated]
	private float <LerpValue>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private float <SunZenith>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private float <MoonZenith>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Vector3 <SunDirection>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Vector3 <MoonDirection>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private Vector3 <LightDirection>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private Vector3 <LocalSunDirection>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	private Vector3 <LocalMoonDirection>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Vector3 <LocalLightDirection>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private Color <SunLightColor>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private Color <MoonLightColor>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Color <SunRayColor>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private Color <MoonRayColor>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Color <RayColor>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private Color <SunSkyColor>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Color <MoonSkyColor>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private Color <SunMeshColor>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private Color <MoonMeshColor>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private Color <GroundColor>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private Color <AmbientColor>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private Color <MoonHaloColor>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ReflectionProbe <Probe>k__BackingField; //Field offset: 0x1D0
	private float timeSinceLightUpdate; //Field offset: 0x1D8
	private float timeSinceAmbientUpdate; //Field offset: 0x1DC
	private float timeSinceReflectionUpdate; //Field offset: 0x1E0
	private float timeRotationsUpdateDuration; //Field offset: 0x1E4
	private float timeRotationsUpdated; //Field offset: 0x1E8
	private Vector3 kBetaMie; //Field offset: 0x1EC
	private Vector4 kSun; //Field offset: 0x1F8
	private Vector4 k4PI; //Field offset: 0x208
	private Vector4 kRadius; //Field offset: 0x218
	private Vector4 kScale; //Field offset: 0x228
	[Tooltip("sLerp debug rotation speed")]
	public float rotationSpeed; //Field offset: 0x238
	private float cached_sun_theta; //Field offset: 0x23C
	private float cached_sun_phi; //Field offset: 0x240
	private float cached_moon_theta; //Field offset: 0x244
	private float cached_moon_phi; //Field offset: 0x248
	private Quaternion prevRotation; //Field offset: 0x24C
	private Quaternion targetRotation; //Field offset: 0x25C

	public private Color AmbientColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public override TOD_AtmosphereParameters Atmosphere
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override float ClearSky
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private TOD_Components Components
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override TOD_Time CurrentTime
	{
		 get { } //Length: 33
	}

	public override TOD_CycleParameters Cycle
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float Diameter
	{
		 get { } //Length: 128
	}

	public override float ForceIndoor
	{
		 get { } //Length: 4
	}

	public private Color GroundColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public bool Headless
	{
		 get { } //Length: 74
	}

	public private bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
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

	public private float LerpValue
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public Color LightColor
	{
		 get { } //Length: 141
	}

	public private Vector3 LightDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public float LightIntensity
	{
		 get { } //Length: 105
	}

	public override Light LightObject
	{
		 get { } //Length: 33
	}

	public float LightZenith
	{
		 get { } //Length: 19
	}

	public private Vector3 LocalLightDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Vector3 LocalMoonDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Vector3 LocalSunDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Vector3 MoonDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Color MoonHaloColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color MoonLightColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color MoonMeshColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color MoonRayColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color MoonSkyColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private float MoonZenith
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private ReflectionProbe Probe
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float Radius
	{
		 get { } //Length: 124
	}

	public private Color RayColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private TOD_Resources Resources
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Vector3 SunDirection
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public private Color SunLightColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color SunMeshColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color SunRayColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private Color SunSkyColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public override float SunVisibility
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private float SunZenith
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public override float UpdateInterval
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public TOD_Sky() { }

	public virtual void Awake() { }

	[CompilerGenerated]
	public Color get_AmbientColor() { }

	[CompilerGenerated]
	public override TOD_AtmosphereParameters get_Atmosphere() { }

	[CompilerGenerated]
	public override float get_ClearSky() { }

	[CompilerGenerated]
	public TOD_Components get_Components() { }

	public override TOD_Time get_CurrentTime() { }

	[CompilerGenerated]
	public override TOD_CycleParameters get_Cycle() { }

	public float get_Diameter() { }

	public override float get_ForceIndoor() { }

	[CompilerGenerated]
	public Color get_GroundColor() { }

	public bool get_Headless() { }

	[CompilerGenerated]
	public bool get_Initialized() { }

	[CompilerGenerated]
	public override bool get_IsDay() { }

	[CompilerGenerated]
	public override bool get_IsNight() { }

	[CompilerGenerated]
	public float get_LerpValue() { }

	public Color get_LightColor() { }

	[CompilerGenerated]
	public Vector3 get_LightDirection() { }

	public float get_LightIntensity() { }

	public override Light get_LightObject() { }

	public float get_LightZenith() { }

	[CompilerGenerated]
	public Vector3 get_LocalLightDirection() { }

	[CompilerGenerated]
	public Vector3 get_LocalMoonDirection() { }

	[CompilerGenerated]
	public Vector3 get_LocalSunDirection() { }

	[CompilerGenerated]
	public Vector3 get_MoonDirection() { }

	[CompilerGenerated]
	public Color get_MoonHaloColor() { }

	[CompilerGenerated]
	public Color get_MoonLightColor() { }

	[CompilerGenerated]
	public Color get_MoonMeshColor() { }

	[CompilerGenerated]
	public Color get_MoonRayColor() { }

	[CompilerGenerated]
	public Color get_MoonSkyColor() { }

	[CompilerGenerated]
	public float get_MoonZenith() { }

	[CompilerGenerated]
	public ReflectionProbe get_Probe() { }

	public float get_Radius() { }

	[CompilerGenerated]
	public Color get_RayColor() { }

	[CompilerGenerated]
	public TOD_Resources get_Resources() { }

	[CompilerGenerated]
	public override Vector3 get_SunDirection() { }

	[CompilerGenerated]
	public Color get_SunLightColor() { }

	[CompilerGenerated]
	public Color get_SunMeshColor() { }

	[CompilerGenerated]
	public Color get_SunRayColor() { }

	[CompilerGenerated]
	public Color get_SunSkyColor() { }

	[CompilerGenerated]
	public override float get_SunVisibility() { }

	[CompilerGenerated]
	public float get_SunZenith() { }

	public override float get_UpdateInterval() { }

	public override void Initialize() { }

	public static Vector3 InverseDirection(Quaternion rotation, Vector3 direction) { }

	protected void LateUpdate() { }

	public override Vector3 LightDirectionExtrapolated(float addTime) { }

	public void LoadParameters(string xml) { }

	public virtual void OnDestroy() { }

	public Vector3 OrbitalToLocal(float theta, float phi) { }

	public Vector3 OrbitalToUnity(float radius, float theta, float phi) { }

	public void RenderToCubemap(RenderTexture targetTexture = null) { }

	public SphericalHarmonicsL2 RenderToSphericalHarmonics() { }

	public Color SampleAtmosphere(Vector3 direction, bool directLight = true) { }

	public Color SampleAtmosphereRaw(Vector3 direction, bool directLight = true) { }

	public Color SampleAtmosphereRawMT(Quaternion rotation, Vector3 direction, bool directLight = true) { }

	public Color SampleEquatorColor() { }

	public Color SampleFogColor(bool directLight = true) { }

	public Color SampleSkyColor() { }

	[CompilerGenerated]
	private void set_AmbientColor(Color value) { }

	[CompilerGenerated]
	public void set_Atmosphere(TOD_AtmosphereParameters value) { }

	[CompilerGenerated]
	public override void set_ClearSky(float value) { }

	[CompilerGenerated]
	private void set_Components(TOD_Components value) { }

	[CompilerGenerated]
	public void set_Cycle(TOD_CycleParameters value) { }

	[CompilerGenerated]
	private void set_GroundColor(Color value) { }

	[CompilerGenerated]
	private void set_Initialized(bool value) { }

	[CompilerGenerated]
	public override void set_IsDay(bool value) { }

	[CompilerGenerated]
	public override void set_IsNight(bool value) { }

	[CompilerGenerated]
	private void set_LerpValue(float value) { }

	[CompilerGenerated]
	private void set_LightDirection(Vector3 value) { }

	[CompilerGenerated]
	private void set_LocalLightDirection(Vector3 value) { }

	[CompilerGenerated]
	private void set_LocalMoonDirection(Vector3 value) { }

	[CompilerGenerated]
	private void set_LocalSunDirection(Vector3 value) { }

	[CompilerGenerated]
	private void set_MoonDirection(Vector3 value) { }

	[CompilerGenerated]
	private void set_MoonHaloColor(Color value) { }

	[CompilerGenerated]
	private void set_MoonLightColor(Color value) { }

	[CompilerGenerated]
	private void set_MoonMeshColor(Color value) { }

	[CompilerGenerated]
	private void set_MoonRayColor(Color value) { }

	[CompilerGenerated]
	private void set_MoonSkyColor(Color value) { }

	[CompilerGenerated]
	private void set_MoonZenith(float value) { }

	[CompilerGenerated]
	private void set_Probe(ReflectionProbe value) { }

	[CompilerGenerated]
	private void set_RayColor(Color value) { }

	[CompilerGenerated]
	private void set_Resources(TOD_Resources value) { }

	[CompilerGenerated]
	public override void set_SunDirection(Vector3 value) { }

	[CompilerGenerated]
	private void set_SunLightColor(Color value) { }

	[CompilerGenerated]
	private void set_SunMeshColor(Color value) { }

	[CompilerGenerated]
	private void set_SunRayColor(Color value) { }

	[CompilerGenerated]
	private void set_SunSkyColor(Color value) { }

	[CompilerGenerated]
	public override void set_SunVisibility(float value) { }

	[CompilerGenerated]
	private void set_SunZenith(float value) { }

	public override void set_UpdateInterval(float value) { }

	private void SetColorRange(Material material) { }

	private void SetColorSpace(Material material) { }

	private void SetSkyQuality(Material material) { }

	private float ShaderMiePhase(float eyeCos, float eyeCos2) { }

	private Color ShaderMoonHaloColor(Vector3 dir) { }

	private Color ShaderNightSkyColor(Vector3 dir) { }

	private float ShaderRayleighPhase(float eyeCos2) { }

	private float ShaderScale(float inCos) { }

	private Color ShaderScatteringColor(Vector3 dir, bool directLight = true) { }

	private Color TOD_GAMMA2LINEAR(Color color) { }

	private Color TOD_HDR2LDR(Color color) { }

	private Color TOD_HDR2LDR_RAW(Color color, float brightness) { }

	private Color TOD_LINEAR2GAMMA(Color color) { }

	public void UpdateAmbient() { }

	private void UpdateCelestials() { }

	public void UpdateFog() { }

	private void UpdateQualitySettings() { }

	public void UpdateReflection() { }

	private void UpdateRenderSettings() { }

	private void UpdateScattering() { }

	private void UpdateShaderKeywords() { }

	private void UpdateShaderProperties() { }

}

