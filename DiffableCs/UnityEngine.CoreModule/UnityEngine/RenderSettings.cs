namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType::Dot (0))]
public sealed class RenderSettings : Object
{

	public static Color ambientEquatorColor
	{
		 get { } //Length: 87
		 set { } //Length: 78
	}

	public static Color ambientGroundColor
	{
		 get { } //Length: 87
		 set { } //Length: 78
	}

	public static float ambientIntensity
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight
	{
		 get { } //Length: 87
		 set { } //Length: 78
	}

	public static AmbientMode ambientMode
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static Color ambientSkyColor
	{
		 get { } //Length: 87
		 set { } //Length: 78
	}

	[NativeProperty("UseFog")]
	public static bool fog
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	public static Color fogColor
	{
		 get { } //Length: 87
		 set { } //Length: 78
	}

	public static float fogDensity
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public static FogMode fogMode
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public static float reflectionIntensity
	{
		 get { } //Length: 69
	}

	[NativeProperty("SkyboxMaterial")]
	public static Material skybox
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	public static Color get_ambientEquatorColor() { }

	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	public static Color get_ambientGroundColor() { }

	private static void get_ambientGroundColor_Injected(out Color ret) { }

	public static float get_ambientIntensity() { }

	public static Color get_ambientLight() { }

	private static void get_ambientLight_Injected(out Color ret) { }

	public static AmbientMode get_ambientMode() { }

	public static Color get_ambientSkyColor() { }

	private static void get_ambientSkyColor_Injected(out Color ret) { }

	public static bool get_fog() { }

	public static Color get_fogColor() { }

	private static void get_fogColor_Injected(out Color ret) { }

	public static float get_fogDensity() { }

	public static float get_fogEndDistance() { }

	public static FogMode get_fogMode() { }

	public static float get_fogStartDistance() { }

	public static float get_reflectionIntensity() { }

	public static Material get_skybox() { }

	public static void set_ambientEquatorColor(Color value) { }

	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	public static void set_ambientGroundColor(Color value) { }

	private static void set_ambientGroundColor_Injected(ref Color value) { }

	public static void set_ambientIntensity(float value) { }

	public static void set_ambientLight(Color value) { }

	private static void set_ambientLight_Injected(ref Color value) { }

	public static void set_ambientMode(AmbientMode value) { }

	public static void set_ambientSkyColor(Color value) { }

	private static void set_ambientSkyColor_Injected(ref Color value) { }

	public static void set_fog(bool value) { }

	public static void set_fogColor(Color value) { }

	private static void set_fogColor_Injected(ref Color value) { }

	public static void set_fogDensity(float value) { }

	public static void set_fogEndDistance(float value) { }

	public static void set_fogMode(FogMode value) { }

	public static void set_fogStartDistance(float value) { }

	public static void set_skybox(Material value) { }

}

