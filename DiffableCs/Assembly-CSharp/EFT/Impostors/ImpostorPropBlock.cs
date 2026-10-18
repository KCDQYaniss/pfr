namespace EFT.Impostors;

public struct ImpostorPropBlock
{
	public uint _Index; //Field offset: 0x0
	public float _Frames; //Field offset: 0x4
	public float _ImpostorSize; //Field offset: 0x8
	public float _TextureBias; //Field offset: 0xC
	public float _Parallax; //Field offset: 0x10
	public float _DepthSize; //Field offset: 0x14
	public float _ClipMask; //Field offset: 0x18
	public float _AI_ShadowBias; //Field offset: 0x1C
	public float _AI_ShadowView; //Field offset: 0x20
	public float _Hemi; //Field offset: 0x24
	public Vector4 _Offset; //Field offset: 0x28
	public Vector4 _AI_SizeOffset; //Field offset: 0x38
	public Vector2 padding; //Field offset: 0x48

	public static int Stride
	{
		 get { } //Length: 6
	}

	public static int get_Stride() { }

}

