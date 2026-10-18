namespace System.Numerics;

[DefaultMember("Item")]
[Intrinsic]
public struct Vector`1 : IEquatable, IFormattable
{
	private struct VectorSizeHelper
	{
		internal Vector _placeholder; //Field offset: 0x0
		internal byte _byte; //Field offset: 0x0

	}

	private static readonly int s_count; //Field offset: 0x0
	private static readonly Vector s_zero; //Field offset: 0x0
	private static readonly Vector s_one; //Field offset: 0x0
	private static readonly Vector s_allOnes; //Field offset: 0x0
	private Register register; //Field offset: 0x0

	public static int Count
	{
		[Intrinsic]
		 get { } //Length: 151
	}

	public T Item
	{
		[Intrinsic]
		 get { } //Length: 2811
	}

	public static Vector Zero
	{
		[Intrinsic]
		 get { } //Length: 159
	}

	private static Vector`1() { }

	[Intrinsic]
	public Vector`1(T value) { }

	internal Vector`1(void* dataPointer) { }

	internal Vector`1(void* dataPointer, int offset) { }

	private Vector`1(ref Register existingRegister) { }

	[Intrinsic]
	internal static Vector Equals(Vector left, Vector right) { }

	[Intrinsic]
	public override bool Equals(Vector other) { }

	public virtual bool Equals(object obj) { }

	[Intrinsic]
	public static int get_Count() { }

	[Intrinsic]
	public T get_Item(int index) { }

	[Intrinsic]
	public static Vector get_Zero() { }

	private static T GetAllBitsSetValue() { }

	public virtual int GetHashCode() { }

	private static T GetOneValue() { }

	private static int InitializeCount() { }

	public static bool op_Equality(Vector left, Vector right) { }

	[CLSCompliant(False)]
	[Intrinsic]
	public static Vector op_Explicit(Vector value) { }

	public static bool op_Inequality(Vector left, Vector right) { }

	private static bool ScalarEquals(T left, T right) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

