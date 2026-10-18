//Type is in global namespace

public class TOD_FogParameters
{
	[Tooltip("Fog color mode.")]
	public TOD_FogType Mode; //Field offset: 0x10
	[TOD_Range(0, 1)]
	[Tooltip("Fog color sampling height.\n = 0 fog is atmosphere color at horizon.\n = 1 fog is atmosphere color at zenith.")]
	public float HeightBias; //Field offset: 0x14

	public TOD_FogParameters() { }

}

