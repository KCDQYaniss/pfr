namespace System.Numerics;

[Intrinsic]
public static class Vector
{

	public static bool IsHardwareAccelerated
	{
		[Intrinsic]
		 get { } //Length: 3
	}

	[CLSCompliant(False)]
	public static Vector AsVectorUInt64(Vector value) { }

	public static Vector Equals(Vector left, Vector right) { }

	[Intrinsic]
	public static bool get_IsHardwareAccelerated() { }

}

