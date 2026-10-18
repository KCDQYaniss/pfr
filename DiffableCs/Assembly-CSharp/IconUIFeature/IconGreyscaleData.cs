namespace IconUIFeature;

public struct IconGreyscaleData : IEquatable
{
	public int Enabled; //Field offset: 0x0
	private Vector3 _pad0; //Field offset: 0x4

	public static IconGreyscaleData Default
	{
		 get { } //Length: 10
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(IconGreyscaleData other) { }

	public static IconGreyscaleData get_Default() { }

	public virtual int GetHashCode() { }

}

