namespace EFT.Impostors;

public struct ImpostorBounds
{
	public Vector3 Center; //Field offset: 0x0
	public float Size; //Field offset: 0xC
	public float Near; //Field offset: 0x10
	public float Far; //Field offset: 0x14
	public Vector2 Padding; //Field offset: 0x18

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

