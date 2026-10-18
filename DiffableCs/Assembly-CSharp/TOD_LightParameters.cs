//Type is in global namespace

public class TOD_LightParameters
{
	[TOD_Min(0)]
	[Tooltip("Refresh interval of the light source position in seconds.")]
	public float UpdateInterval; //Field offset: 0x10
	[TOD_Range(-1, 1)]
	[Tooltip("Controls how low the light source is allowed to go.\n = -1 light source can go as low as it wants.\n = 0 light source will never go below the horizon.\n = +1 light source will never leave zenith.")]
	public float MinimumHeight; //Field offset: 0x14

	public TOD_LightParameters() { }

}

