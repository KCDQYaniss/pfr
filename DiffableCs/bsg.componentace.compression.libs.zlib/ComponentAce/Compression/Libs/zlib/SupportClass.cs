namespace ComponentAce.Compression.Libs.zlib;

public class SupportClass
{

	public SupportClass() { }

	public static long Identity(long literal) { }

	public static ulong Identity(ulong literal) { }

	public static float Identity(float literal) { }

	public static double Identity(double literal) { }

	public static int ReadInput(Stream sourceStream, byte[] target, int start, int count) { }

	public static int ReadInput(TextReader sourceTextReader, byte[] target, int start, int count) { }

	public static byte[] ToByteArray(string sourceString) { }

	public static char[] ToCharArray(byte[] byteArray) { }

	public static int URShift(int number, int bits) { }

	public static int URShift(int number, long bits) { }

	public static long URShift(long number, int bits) { }

	public static long URShift(long number, long bits) { }

}

