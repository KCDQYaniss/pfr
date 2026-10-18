namespace Comfort.Common;

[Extension]
public static class BufferExtension
{

	[Extension]
	public static byte ReadByte(byte[] buffer, ref int offset) { }

	[Extension]
	public static DateTime ReadDateTime(byte[] buffer, ref int offset) { }

	[Extension]
	public static short ReadInt16(byte[] buffer, ref int offset) { }

	[Extension]
	public static int ReadInt32(byte[] buffer, ref int offset) { }

	[Extension]
	public static long ReadInt64(byte[] buffer, ref int offset) { }

	[Extension]
	public static float ReadSingle(byte[] buffer, ref int offset) { }

	[Extension]
	public static ushort ReadUInt16(byte[] buffer, ref int offset) { }

	[Extension]
	public static uint ReadUInt32(byte[] buffer, ref int offset) { }

	[Extension]
	public static ulong ReadUInt64(byte[] buffer, ref int offset) { }

	[Extension]
	public static int Write(byte[] buffer, DateTime value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, long value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, int value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, short value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, ulong value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, uint value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, ushort value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, float value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, byte value, int offset = 0) { }

}

