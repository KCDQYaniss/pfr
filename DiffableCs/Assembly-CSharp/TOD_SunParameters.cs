//Type is in global namespace

public class TOD_SunParameters
{
	[Tooltip("Color of the sun spot.\nInterpolates from left (day) to right (night).")]
	public Gradient MeshColor; //Field offset: 0x10
	[TOD_Min(0)]
	[Tooltip("Size of the sun spot in degrees.")]
	public float MeshSize; //Field offset: 0x18
	[TOD_Min(0)]
	[Tooltip("Brightness of the sun spot.")]
	public float MeshBrightness; //Field offset: 0x1C
	[TOD_Min(0)]
	[Tooltip("Contrast of the sun spot.")]
	public float MeshContrast; //Field offset: 0x20

	public TOD_SunParameters() { }

}

