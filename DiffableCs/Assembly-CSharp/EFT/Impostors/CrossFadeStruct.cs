namespace EFT.Impostors;

public struct CrossFadeStruct
{
	public float time; //Field offset: 0x0
	public float sign; //Field offset: 0x4
	public Vector2 padding; //Field offset: 0x8

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

