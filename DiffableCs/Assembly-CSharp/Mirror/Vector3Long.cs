namespace Mirror;

[DefaultMember("Item")]
public struct Vector3Long
{
	public static readonly Vector3Long zero; //Field offset: 0x0
	public static readonly Vector3Long one; //Field offset: 0x18
	public static readonly Vector3Long forward; //Field offset: 0x30
	public static readonly Vector3Long back; //Field offset: 0x48
	public static readonly Vector3Long left; //Field offset: 0x60
	public static readonly Vector3Long right; //Field offset: 0x78
	public static readonly Vector3Long up; //Field offset: 0x90
	public static readonly Vector3Long down; //Field offset: 0xA8
	public long x; //Field offset: 0x0
	public long y; //Field offset: 0x8
	public long z; //Field offset: 0x10

	public long Item
	{
		 get { } //Length: 190
		 set { } //Length: 190
	}

	private static Vector3Long() { }

	public Vector3Long(long x, long y, long z) { }

	public bool Equals(Vector3Long other) { }

	public virtual bool Equals(object other) { }

	public long get_Item(int index) { }

	public virtual int GetHashCode() { }

	public static Vector3Long op_Addition(Vector3Long a, Vector3Long b) { }

	public static bool op_Equality(Vector3Long a, Vector3Long b) { }

	public static bool op_Inequality(Vector3Long a, Vector3Long b) { }

	public static Vector3Long op_Multiply(Vector3Long a, long n) { }

	public static Vector3Long op_Multiply(long n, Vector3Long a) { }

	public static Vector3Long op_Subtraction(Vector3Long a, Vector3Long b) { }

	public static Vector3Long op_UnaryNegation(Vector3Long v) { }

	public void set_Item(int index, long value) { }

	public virtual string ToString() { }

}

