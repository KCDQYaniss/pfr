namespace EFT.Weather;

public class WeatherController : MonoBehaviour
{
	public static WeatherController Instance; //Field offset: 0x0
	private static readonly int _cubemapNightMultiplier; //Field offset: 0x8
	private static readonly int _cubemapDayMultiplier; //Field offset: 0xC
	private static readonly int _topHorizontSkyColor; //Field offset: 0x10
	private static readonly int _minAmbientColor; //Field offset: 0x14
	public WindController WindController; //Field offset: 0x20
	public RainController RainController; //Field offset: 0x28
	public Camera PlayerCamera; //Field offset: 0x30
	[Header("Clouds")]
	public CloudController CloudController; //Field offset: 0x38
	public CloudRemapData CloudsRemap; //Field offset: 0x40
	[Header("Desaturate")]
	[MinMaxVec2(-0.5, 1, -1)]
	public Vector2 MinMaxAmmount; //Field offset: 0x48
	public float MinLyingWater; //Field offset: 0x50
	public AnimationCurve FogMultyplyer; //Field offset: 0x58
	public ToDController TimeOfDayController; //Field offset: 0x60
	public bool isDrawDebugGui; //Field offset: 0x68
	public float CubemapDayMult; //Field offset: 0x6C
	public float CubemapNightMult; //Field offset: 0x70
	[CompilerGenerated]
	private float <SunHeight>k__BackingField; //Field offset: 0x74
	public FogRemapData MBOITFogRemapData; //Field offset: 0x78
	public FogRemapDataV2 MBOITFogRemapDataV2; //Field offset: 0x80
	public WeatherDebug WeatherDebug; //Field offset: 0x88
	private bool _debugMieMultiplier; //Field offset: 0x90
	private float _initialMieMultiplier; //Field offset: 0x94
	private bool _debugMBOITFog; //Field offset: 0x98
	private IWeatherCurve backendWeatherCurve; //Field offset: 0xA0
	private TOD_Scattering _scatteringFog; //Field offset: 0xA8
	private MBOIT_Scattering _mboitScatteringFog; //Field offset: 0xB0
	private CC_Sharpen _desaturateEffect; //Field offset: 0xB8

	public float SunHeight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public IWeatherCurve WeatherCurve
	{
		 get { } //Length: 39
	}

	private static WeatherController() { }

	public WeatherController() { }

	[CompilerGenerated]
	internal static void <ControlClouds>g__GetDirectionAndMagnitude|49_0(in Vector2 input, out Vector2 direction, out float magnitude) { }

	[CompilerGenerated]
	internal static float <SetCloudWind>g__DirectionToRotation|51_0(Vector2 direction) { }

	private void Awake() { }

	private void ControlClouds(in CloudRemapRecord remapRecord) { }

	private void ControlComponents() { }

	private void ControlDesaturateEffect(float fogginess) { }

	private void ControlFogginess(float fogginess) { }

	private void ControlRain() { }

	private void ControlScattering(float fog, FogRemapRecordV2Result interpolatedParams) { }

	private void ControlSmoke() { }

	private void ControlWetting(float t01, float fogginess) { }

	private void ControlWind() { }

	public void Debug_LoadDebugWeatherPreset(bool subscribe) { }

	public void Debug_SetCloudWindMultiplier(int cloudsWindMultiplier) { }

	public void Debug_SetTestWeather(int rate) { }

	public void Debug_SetWeatherLog(bool subscribe) { }

	private void DisableGlobalShaderValues() { }

	public void Dispose() { }

	[CompilerGenerated]
	public float get_SunHeight() { }

	public IWeatherCurve get_WeatherCurve() { }

	private void LateUpdate() { }

	private static void MovingAverage(WeatherNode[] data, int windowSize = 2) { }

	private void OnCameraChanged() { }

	public void OnDestroy() { }

	[CompilerGenerated]
	public void set_SunHeight(float value) { }

	private void SetCloudsQuality(CloudsMode mode) { }

	private void SetCloudWind(Vector2 layerAOrientation, float layerASpeed) { }

	private void SetGlobalShaderValues() { }

	public void SetWeatherForce(WeatherNode node) { }

	internal void SetWeatherNodes(WeatherNode[] nodes) { }

	public void UpdateComponents() { }

	public void UpdateDateTime(DateTime dateTime) { }

}

