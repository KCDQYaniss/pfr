//Type is in global namespace

public class TOD_NightParameters
{
	[Tooltip("Color of the light that hits the atmosphere at night.\nInterpolates from left (day) to right (night).")]
	public Gradient SkyColor; //Field offset: 0x10
	[Tooltip("Color of the light that hits the ground at night.\nInterpolates from left (day) to right (night).")]
	public Gradient LightColor; //Field offset: 0x18
	[Tooltip("Color of the god rays at night.\nInterpolates from left (day) to right (night).")]
	public Gradient RayColor; //Field offset: 0x20
	[Tooltip("Color of the clouds at night.\nInterpolates from left (day) to right (night).")]
	public Gradient CloudColor; //Field offset: 0x28
	[Tooltip("Color of the ambient light at night.\nInterpolates from left (day) to right (night).")]
	public Gradient AmbientColor; //Field offset: 0x30
	[TOD_Min(0)]
	[Tooltip("Intensity of the light source at night.")]
	public float LightIntensity; //Field offset: 0x38
	[TOD_Range(0, 1)]
	[Tooltip("Opacity of the shadows dropped by the light source at night.")]
	public float ShadowStrength; //Field offset: 0x3C
	[Range(0, 1)]
	[Tooltip("Brightness multiplier of the color gradients at night.")]
	public float ColorMultiplier; //Field offset: 0x40
	[Range(0, 1)]
	[Tooltip("Brightness multiplier of the ambient light at night.")]
	public float AmbientMultiplier; //Field offset: 0x44
	[Range(0, 1)]
	[Tooltip("Brightness multiplier of the reflection probe at night.")]
	public float ReflectionMultiplier; //Field offset: 0x48

	public TOD_NightParameters() { }

}

