namespace FlyingWormConsole3.LiteNetLib.Utils;

public static class FastBitConverter
{
	private struct ConverterHelperDouble
	{
		public ulong Along; //Field offset: 0x0
		public double Adouble; //Field offset: 0x0

	}

	private struct ConverterHelperFloat
	{
		public int Aint; //Field offset: 0x0
		public float Afloat; //Field offset: 0x0

	}


	public static void GetBytes(byte[] bytes, int startIndex, double value) { }

	public static void GetBytes(byte[] bytes, int startIndex, float value) { }

	public static void GetBytes(byte[] bytes, int startIndex, short value) { }

	public static void GetBytes(byte[] bytes, int startIndex, ushort value) { }

	public static void GetBytes(byte[] bytes, int startIndex, int value) { }

	public static void GetBytes(byte[] bytes, int startIndex, uint value) { }

	public static void GetBytes(byte[] bytes, int startIndex, long value) { }

	public static void GetBytes(byte[] bytes, int startIndex, ulong value) { }

	private static void WriteLittleEndian(byte[] buffer, int offset, ulong data) { }

	private static void WriteLittleEndian(byte[] buffer, int offset, int data) { }

	public static void WriteLittleEndian(byte[] buffer, int offset, short data) { }

}

