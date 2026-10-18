namespace IconUIFeature;

public struct IconBlurData : IEquatable
{
	public Vector4 Direction; //Field offset: 0x0
	[Range(0, 40)]
	public int Radius; //Field offset: 0x10
	[Range(3, 6)]
	public int SampleCount; //Field offset: 0x14
	public int Enabled; //Field offset: 0x18
	private int _pad0; //Field offset: 0x1C

	public static IconBlurData Default
	{
		 get { } //Length: 97
	}

	public override bool Equals(IconBlurData other) { }

	public virtual bool Equals(object obj) { }

	public static IconBlurData get_Default() { }

	public virtual int GetHashCode() { }

}

