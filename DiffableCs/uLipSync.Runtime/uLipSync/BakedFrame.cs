namespace uLipSync;

public struct BakedFrame
{
	public float volume; //Field offset: 0x0
	public List phonemes; //Field offset: 0x8

	public static BakedFrame zero
	{
		 get { } //Length: 193
	}

	public static BakedFrame get_zero() { }

}

