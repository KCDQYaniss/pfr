namespace EFT.Impostors;

internal struct ImpostorStruct
{
	public uint enabled; //Field offset: 0x0
	public Vector3 position; //Field offset: 0x4
	public Vector2 customScale; //Field offset: 0x10
	public uint type_id; //Field offset: 0x18
	public uint wind_id; //Field offset: 0x1C

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

