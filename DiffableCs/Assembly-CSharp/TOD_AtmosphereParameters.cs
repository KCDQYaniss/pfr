//Type is in global namespace

public class TOD_AtmosphereParameters
{
	[TOD_Min(0)]
	[Tooltip("Intensity of the atmospheric Rayleigh scattering.")]
	public float RayleighMultiplier; //Field offset: 0x10
	[TOD_Min(0)]
	[Tooltip("Intensity of the atmospheric Mie scattering.")]
	public float MieMultiplier; //Field offset: 0x14
	[TOD_Min(0)]
	[Tooltip("Overall brightness of the atmosphere.")]
	public float Brightness; //Field offset: 0x18
	[TOD_Min(0)]
	[Tooltip("Scattering brightness of the atmosphere.")]
	public float ScatteringBrightness; //Field offset: 0x1C
	[TOD_Min(0)]
	[Tooltip("Overall contrast of the atmosphere.")]
	public float Contrast; //Field offset: 0x20
	[TOD_Range(0, 1)]
	[Tooltip("Directionality factor that determines the size of the glow around the sun.")]
	public float Directionality; //Field offset: 0x24
	[TOD_Range(0, 1)]
	[Tooltip("Density of the fog covering the sky.")]
	public float Fogginess; //Field offset: 0x28

	public TOD_AtmosphereParameters() { }

}

