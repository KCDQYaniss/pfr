//Type is in global namespace

public class TOD_MoonParameters
{
	[Tooltip("Color of the moon mesh.\nInterpolates from left (day) to right (night).")]
	public Gradient MeshColor; //Field offset: 0x10
	[TOD_Min(0)]
	[Tooltip("Size of the moon mesh in degrees.")]
	public float MeshSize; //Field offset: 0x18
	[TOD_Min(0)]
	[Tooltip("Brightness of the moon mesh.")]
	public float MeshBrightness; //Field offset: 0x1C
	[TOD_Min(0)]
	[Tooltip("Contrast of the moon mesh.")]
	public float MeshContrast; //Field offset: 0x20
	[Tooltip("Color of the moon halo.\nInterpolates from left (day) to right (night).")]
	public Gradient HaloColor; //Field offset: 0x28
	[TOD_Min(0)]
	[Tooltip("Size of the moon halo.")]
	public float HaloSize; //Field offset: 0x30
	[Tooltip("Type of the moon position calculation.")]
	public TOD_MoonPositionType Position; //Field offset: 0x34

	public TOD_MoonParameters() { }

}

