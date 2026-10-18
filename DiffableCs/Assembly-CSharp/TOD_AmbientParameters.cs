//Type is in global namespace

public class TOD_AmbientParameters
{
	[Tooltip("Ambient light mode.")]
	public TOD_AmbientType Mode; //Field offset: 0x10
	[TOD_Min(0)]
	[Tooltip("Refresh interval of the ambient light probe in seconds.")]
	public float UpdateInterval; //Field offset: 0x14

	public TOD_AmbientParameters() { }

}

