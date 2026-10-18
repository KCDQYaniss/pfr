namespace EFT.Weather;

public struct WindParams
{
	public Vector4 Param; //Field offset: 0x0
	public Vector4 ParamA; //Field offset: 0x10
	public Vector4 ParamB; //Field offset: 0x20
	public Vector4 ParamC; //Field offset: 0x30

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

