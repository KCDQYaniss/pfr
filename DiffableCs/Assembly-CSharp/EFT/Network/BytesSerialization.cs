namespace EFT.Network;

public class BytesSerialization
{

	public BytesSerialization() { }

	public static void EnsureCapacity(ref byte[] buffer, int bufferCount) { }

	public static T Read(byte[] buffer, int position) { }

	public static T Read(byte[] buffer, ref int position) { }

	public static void Write(byte[] buffer, T value, int position) { }

	public static void Write(byte[] buffer, T value, ref int position) { }

}

