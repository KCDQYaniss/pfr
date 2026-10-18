//Type is in global namespace

public class TOD_StarParameters
{
	[TOD_Min(0)]
	[Tooltip("Tiling of the stars texture.")]
	public float Tiling; //Field offset: 0x10
	[TOD_Min(0)]
	[Tooltip("Brightness of the stars.")]
	public float Brightness; //Field offset: 0x14
	[Tooltip("Type of the stars position calculation.")]
	public TOD_StarsPositionType Position; //Field offset: 0x18

	public TOD_StarParameters() { }

}

